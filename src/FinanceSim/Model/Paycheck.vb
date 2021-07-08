Public Class Paycheck
  Implements IHasDueInfo
  Public Property Due As DueInfo Implements IHasDueInfo.Due
  Public Property Id As String Implements IHasName.Id
  Public Property Name As String Implements IHasName.Name
  Public Property AccountId As String
  Public Property Total As Decimal
  Public Property Deposits As List(Of PaycheckDeposit)
End Class
