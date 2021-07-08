Public Class SimulationTransaction
  Implements ISimulationItem, ICanBeProcessed

  Public Sub New(startDate As Date, transaction As Transaction)
    Due = New SimulationDueInfo(startDate, transaction.Due)

    Id = transaction.Id
    Name = transaction.Name
    Amount = transaction.Amount
    FromId = transaction.FromId
    ToId = transaction.ToId
  End Sub

  Public ReadOnly Property Id As String Implements ISimulationItem.Id
  Public ReadOnly Property Name As String Implements ISimulationItem.Name
  Public ReadOnly Property Due As SimulationDueInfo Implements ICanBeProcessed.Due
  Public ReadOnly Property Amount As Decimal
  Public ReadOnly Property FromId As String
  Public ReadOnly Property ToId As String

  Public Sub Process(state As SimulationState, processDate As Date) Implements ICanBeProcessed.Process
    state.Withdraw(processDate, FromId, Name, Amount)
    state.Deposit(processDate, ToId, Name, Amount)
  End Sub
End Class
