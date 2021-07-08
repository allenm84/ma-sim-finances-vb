Public Class SimulationBill
  Implements ISimulationItem, ISimulationBill, ICanBeProcessed

  public Sub New(startDate As Date, bill As Bill)
    Due = new SimulationDueInfo(startDate, bill.Due)

    Id = bill.Id
    Name = bill.Name
    AccountId = bill.AccountId
    Payment = bill.Payment
  End Sub

  Public ReadOnly Property Id As String Implements ISimulationItem.Id
  Public ReadOnly Property Name As String Implements ISimulationItem.Name
  Public Property Payment As Decimal Implements ISimulationBill.Payment
  Public ReadOnly Property Due As SimulationDueInfo Implements ICanBeProcessed.Due
  Public Property AccountId As String

  Public Sub Process(state As SimulationState, processDate As Date) Implements ICanBeProcessed.Process
    state.Withdraw(processDate, AccountId, Name, Payment)
  End Sub
End Class
