Public Class SimulationDebtAccount
  Inherits SimulationAccount
  Implements ISimulationBill, ICanBeProcessed

  Private _currentState As SimulationDebtAccountState = SimulationDebtAccountState.Due

  Public Sub New(startDate As Date, debt As Debt)
    MyBase.New(debt)

    Interest = debt.Interest
    Due = new SimulationDueInfo(startDate, debt.Due)

    Type = debt.Type
    AccountId = debt.AccountId
    Payment = debt.Payment
  End Sub

  Public Property Payment As Decimal Implements ISimulationBill.Payment
  Public ReadOnly Property Due As SimulationDueInfo Implements ICanBeProcessed.Due
  Public ReadOnly Property Type As DebtType
  Public ReadOnly Property AccountId As String
  Public ReadOnly Property Interest As Decimal
  Public ReadOnly Property CurrentState As SimulationDebtAccountState
    Get
      Return _currentState
    End Get
  End Property

  Public ReadOnly Property IsPaidOff
    Get
      Return _currentState = SimulationDebtAccountState.PaidOff
    End Get

  End Property

  Public Function SetState(newState As SimulationDebtAccountState) As Boolean
    If CurrentState <> newState Then
      _currentState = newState
      Return True
    End If
    Return False
  End Function

  Public Sub Process(state As SimulationState, processDate As Date) Implements ICanBeProcessed.Process
    If IsPaidOff Then
      Return
    End If

    Dim amount = Payment
    If state.IsSnowball And ReferenceEquals(state.SnowballTarget, Me) Then
      amount += state.SnowballAmount
    End If

    If amount > Balance
      amount = Balance
    End If

    state.Deposit(processDate, Me, "Payment", amount)
    state.Withdraw(processDate, AccountId, Name, amount)
  End Sub

  Public Overrides Sub ProcessInterest(state As SimulationState, processDate As Date)
    If Interest > 0 And Not IsPaidOff And processDate >= Due.StartDate
      Dim amount = (Interest / 12d) * Balance
      state.Withdraw(processDate, Me, $"Interest ({Interest:P2})", amount)
    End If
  End Sub

  Public Overrides Sub Deposit(state As SimulationState, depositDate As Date, amount As Decimal)
    Balance -= amount
  End Sub

  Public Overrides Sub Withdraw(state As SimulationState, withdrawDate As Date, amount As Decimal)
    Balance += amount
  End Sub
End Class
