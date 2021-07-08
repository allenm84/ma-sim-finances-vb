Public Class Profile
  Implements IHasName
  Public Property Id As String Implements IHasName.Id
  Public Property Name As String Implements IHasName.Name
  Public Property Created As Date
  Public Property Accounts As List(Of BankAccount) = New List(Of BankAccount)
  Public Property Bills As List(Of Bill) = New List(Of Bill)
  Public Property Debts As List(Of Debt) = New List(Of Debt)
  Public Property Paychecks As List(Of Paycheck) = New List(Of Paycheck)
  Public Property Transactions As List(Of Transaction) = New List(Of Transaction)
  Public Property Events As List(Of BaseEvent) = New List(Of BaseEvent)
  Public Property Snowball As SnowBallSetup = New SnowBallSetup()
  Public Property Setup As SimulationSetup = New SimulationSetup()
End Class
