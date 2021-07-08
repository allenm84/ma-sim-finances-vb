Public Class SimulationPaycheck
  Implements ISimulationItem, ICanBeProcessed

  Private ReadOnly _deposits() As PaycheckDeposit

  Public Sub New(startDate As Date, paycheck As Paycheck)
    Due = New SimulationDueInfo(startDate, paycheck.Due)
    _deposits = paycheck.Deposits.ToArray()

    Id = paycheck.Id
    AccountId = paycheck.AccountId
    Name = paycheck.Name
    Total = paycheck.Total
  End Sub

  Public ReadOnly Property Id As String Implements ISimulationItem.Id
  Public ReadOnly Property AccountId As String
  Public ReadOnly Property Name As String Implements ISimulationItem.Name
  Public ReadOnly Property Due As SimulationDueInfo Implements ICanBeProcessed.Due
  Public Property Total As Decimal

  Public Sub Process(state As SimulationState, processDate As Date) Implements ICanBeProcessed.Process
    Dim remainingTotal = Total
    For Each deposit In _deposits
      state.Deposit(processDate, deposit.AccountId, deposit.Name, deposit.Amount)
      remainingTotal -= deposit.Amount
    Next
    state.Deposit(processDate, AccountId, Name, remainingTotal)
  End Sub
End Class
