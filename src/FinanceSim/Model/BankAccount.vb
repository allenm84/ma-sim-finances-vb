Public Enum BankAccountType
  Checking
  Savings
End Enum

Public Class BankAccount
  Implements IAccount

  Public Property Balance As Decimal Implements IAccount.Balance
  Public Property Id As String Implements IHasName.Id
  Public Property Name As String Implements IHasName.Name
  Public Property Type As BankAccountType
  Public Property APY As Decimal
End Class
