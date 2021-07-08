Public MustInherit Class SimulationAccount
  Implements IAccount, ISimulationItem

  Protected Sub New(account As IAccount)
    Balance = account.Balance
    Id = account.Id
    Name = account.Name
  End Sub

  Public Property Balance As Decimal Implements IAccount.Balance
  Public ReadOnly Property Id As String Implements IHasName.Id, ISimulationItem.Id
  Public ReadOnly Property Name As String Implements IHasName.Name, ISimulationItem.Name
  Public MustOverride Sub ProcessInterest(state As SimulationState, processDate As Date)
  Public MustOverride Sub Deposit(state As SimulationState, depositDate As Date, amount As Decimal)
  Public MustOverride Sub Withdraw(state As SimulationState, withdrawDate As Date, amount As Decimal)
End Class