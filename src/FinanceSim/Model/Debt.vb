Public Enum DebtType
  Loan
  Mortgage
  Revolving
  Debt
End Enum

Public Class Debt
  Inherits Bill
  Implements IAccount
  Public Property Balance As Decimal Implements IAccount.Balance
  Public Property Interest As Decimal
  Public Property Type As DebtType
End Class
