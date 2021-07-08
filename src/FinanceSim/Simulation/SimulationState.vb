Public NotInheritable Class SimulationState
  Private Delegate Sub AccountActionDelegate(account As SimulationAccount, state As SimulationState, actionDate As Date, amount As Decimal)
  Private ReadOnly _noticeAccount As New SimulationNoticeBoard

  Public Sub New(profile As Profile, startDate As Date, isSnowBall As Boolean)
    Me.IsSnowball = isSnowBall

    Accounts = profile.Accounts.Select(Function(it) New SimulationBankAccount(it)).ToDictionary(Function(it) it.Id)
    Bills = profile.Bills.Select(Function(it) New SimulationBill(startDate, it)).ToDictionary(Function(it) it.Id)
    Debts = profile.Debts.Select(Function(it) New SimulationDebtAccount(startDate, it)).ToDictionary(Function(it) it.Id)
    Paychecks = profile.Paychecks.Select(Function(it) New SimulationPaycheck(startDate, it)).ToDictionary(Function(it) it.Id)
    Transactions = profile.Transactions.Select(Function(it) New SimulationTransaction(startDate, it)).ToDictionary(Function(it) it.Id)
    Events = profile.Events.ToLookUp(Function(it) it.OccursOn)

    Dim queueItems = Debts.Values.
      Select(Function(it, index) New DebtInfo(it, GetDebtOrder(it, profile.Snowball, index))).
      OrderBy(Function(it) it.Order).
      Select(Function(it) it.Debt)
    SnowballPool = New Queue(Of SimulationDebtAccount)(queueItems)
    SnowballTarget = SnowballPool.SafeDequeue()
    SnowballAmount = profile.Snowball.InitialAmount

    Results = new Dictionary(Of IAccount, DataTable)
    AddToSnowball(startDate, 0)
  End Sub

  Public ReadOnly Property IsSnowball As Boolean
  Public ReadOnly Property Accounts As Dictionary(Of String, SimulationBankAccount)
  Public ReadOnly Property Bills As Dictionary(Of String, SimulationBill)
  Public ReadOnly Property Debts As Dictionary(Of String, SimulationDebtAccount)
  Public ReadOnly Property Paychecks As Dictionary(Of String, SimulationPaycheck)
  Public ReadOnly Property Transactions As Dictionary(Of String, SimulationTransaction)
  Public ReadOnly Property Events As ILookup(Of Date, BaseEvent)

  Public Property SnowballTarget As SimulationDebtAccount
  Public ReadOnly Property SnowballPool As Queue(Of SimulationDebtAccount)
  Public Property SnowballAmount As Decimal

  Public ReadOnly Property Results As Dictionary(Of IAccount, DataTable)

  Private Shared Function GetDebtOrder(debt As SimulationDebtAccount, setup As SnowBallSetup, defaultOrder As Integer)
    Dim index = setup.DebtOrder.IndexOf(debt.Id)
    If index < 0 Then
      index = defaultOrder
    End If
    Return index
  End Function

  Private Shared Function CreateResultsTable(key As IAccount)
    Dim table = New DataTable(key.Id)
    table.Columns.Add("Date", GetType(Date))
    table.Columns.Add("Name", GetType(String))
    table.Columns.Add("Amount", GetType(String))
    table.Columns.Add("Balance", GetType(String))
    Return table
  End Function

  Private Sub AddResultItem(key As IAccount, resultDate As Date, amount As Decimal, name As String)
    Dim table As DataTable = Nothing
    If Not Results.TryGetValue(key, table) Then
      table = CreateResultsTable(key)
      Results(key) = table
    End If
    table.Rows.Add(resultDate, name, $"{amount:C2}", $"{key.Balance:C2}")
  End Sub

  Private Shared Function CanBeSnowballTarget(debt As SimulationDebtAccount) As Nullable(Of Boolean)
    Return debt?.CurrentState = SimulationDebtAccountState.Due
  End Function

  Private Shared Sub DepositDelegate(account As SimulationAccount, state As SimulationState, actionDate As Date, amount As Decimal)
    account.Deposit(state, actionDate, amount)
  End Sub

  Private Sub WithdrawDelegate(account As SimulationAccount, state As SimulationState, actionDate As Date, amount As Decimal)
    account.Withdraw(state, actionDate, amount)
  End Sub

  Private Sub DoAction(action As AccountActionDelegate, actionDate As Date, account As SimulationAccount, name As String, amount As Decimal)
    Dim beforeBalance = account.Balance
    action.Invoke(account, Me, actionDate, amount)
    Dim afterBalance = account.Balance
    Dim sign = afterBalance.CompareTo(beforeBalance)
    AddResultItem(account, actionDate, amount * sign, name)
  End Sub

  Private Function GetBill(id As String) As ISimulationBill
    Dim bill As SimulationBill = Nothing
    Dim debt As SimulationDebtAccount = Nothing

    If Bills.TryGetValue(id, bill)
      Return bill
    End If

    If Debts.TryGetValue(id, debt)
      Return debt
    End If

    Return Nothing
  End Function

  Public Iterator Function GetDueItems(dueDate As Date) As IEnumerable(Of ICanBeProcessed)
    Dim isDue = New Func(Of ICanBeProcessed, Boolean)(Function(it) it.Due.Current = dueDate)

    For Each item In Paychecks.Values.Where(isDue)
      Yield item
    Next

    For Each item In Bills.Values.Where(isDue)
      Yield item
    Next

    For Each item In Debts.Values.Where(isDue)
      Yield item
    Next

    For Each item In Transactions.Values.Where(isDue)
      Yield item
    Next
  End Function

  Public Function GetAccount(id As String) As SimulationAccount
    Dim debt As SimulationDebtAccount = Nothing
    Dim account As SimulationBankAccount = Nothing

    If Debts.TryGetValue(id, debt) Then
      Return debt
    End If

    If Accounts.TryGetValue(id, account) Then
      Return account
    End If

    Return Nothing
  End Function

  Public Iterator Function GetAccounts() As IEnumerable(Of SimulationAccount)
    For Each account In Accounts.Values
      Yield account
    Next

    For Each debt In Debts.Values
      Yield debt
    Next
  End Function

  Public Function ShouldKeepGoing() As Boolean
    Return Not IsSnowball Or SnowballPool.Count > 0
  End Function

  Public Sub AddNotice(noticeDate As Date, text As String)
    AddResultItem(_noticeAccount, noticeDate, 0, text)
  End Sub

  Public Sub AddToPaycheckTotal(addDate As Date, id As String, amount As Decimal)
    Dim paycheck As SimulationPaycheck = Nothing
    If Paychecks.TryGetValue(id, paycheck) Then
      paycheck.Total += amount
      AddNotice(addDate, $"Paycheck Update({paycheck.Name} to {paycheck.Total:C2})")
    End If
  End Sub

  Public Sub AddToSnowball(addDate As Date, amount As Decimal)
    Dim oldSnowball = SnowballAmount
    SnowballAmount += amount

    Dim sign = If(amount < 0, "-", "+")
    Dim absAmount = Math.Abs(amount)

    If absAmount > 0 Then
      AddNotice(addDate, $"Snowball(Amount = ({oldSnowball:C2} {sign} {absAmount:C2}) = {SnowballAmount:C2})")
    Else
      AddNotice(addDate, $"Snowball(Amount = {SnowballAmount:C2})")
    End If
  End Sub

  Public Sub PayOff(payoffDate As Date, debt As SimulationDebtAccount)
    If debt.Type = DebtType.Revolving Then
      ' a revolving debt doesn't get paid off, it just
      ' becomes ineligible to be a snowball target
      If debt.SetState(SimulationDebtAccountState.None) Then
        AddNotice(payOffDate, $"{debt.Name} balance to {0d:C2}")
      End If
    Else
      ' any other debt type gets paid off and added to the snowball
      If debt.SetState(SimulationDebtAccountState.PaidOff) Then
        AddNotice(payOffDate, $"{debt.Name} paid off")
        If IsSnowball Then
          AddToSnowball(payoffDate, debt.Payment)
        End If
      End If
    End If
  End Sub

  Public Sub UpdateSnowball(updateDate As Date)
    If Not IsSnowball Then
      Return
    End If

    Dim currentSnowballTarget = SnowballTarget
    While Not CanBeSnowballTarget(SnowballTarget)
      SnowballTarget = SnowballPool.SafeDequeue()
    End While

    If Not ReferenceEquals(currentSnowballTarget, SnowballTarget)
      AddNotice(updateDate, $"Snowball Target Updated({currentSnowballTarget.Name} => {SnowballTarget?.Name})")
    End If
  End Sub

  Public Sub ChangeBillPayment(changeDate As Date, id As String, newPayment As Decimal)
    Dim bill = GetBill(id)
    If bill IsNot Nothing Then
      Dim oldPayment = bill.Payment
      bill.Payment = newPayment

      AddNotice(changeDate, $"Payment Update ({bill.Name} to {newPayment:C2})")
      Dim diff = newPayment - oldPayment
      If diff > 0
        ' take money away from the snowball to pay for this
        AddToSnowball(changeDate, -diff)
      End If
    End If
  End Sub

  Public Sub Deposit(actionDate As Date, accountId As String, name As String, amount As Decimal)
    Dim account = GetAccount(accountId)
    If account IsNot Nothing Then
      Deposit(actionDate, account, name, amount)
    End If
  End Sub

  Public Sub Deposit(actionDate As Date, account As SimulationAccount, name As String, amount As Decimal)
    DoAction(AddressOf DepositDelegate, actionDate, account, name, amount)
  End Sub

  Public Sub Withdraw(actionDate As Date, accountId As String, name As String, amount As Decimal)
    Dim account = GetAccount(accountId)
    If account IsNot Nothing Then
      Withdraw(actionDate, account, name, amount)
    End If
  End Sub

  Public Sub Withdraw(actionDate As Date, account As SimulationAccount, name As String, amount As Decimal)
    DoAction(AddressOf WithdrawDelegate, actionDate, account, name, amount)
  End Sub

  Private Class DebtInfo
    Public Sub New(debt As SimulationDebtAccount, order As Integer)
      Me.Debt = debt
      Me.Order = order
    End Sub

    Public ReadOnly Property Debt As SimulationDebtAccount
    Public ReadOnly Property Order As Integer
  End Class
End Class
