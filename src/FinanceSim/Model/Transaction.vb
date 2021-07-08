Public Class Transaction
  Implements IHasDueInfo
  Public Property Due As DueInfo Implements IHasDueInfo.Due
  Public Property Id As String Implements IHasName.Id
  Public Property Name As String Implements IHasName.Name
  Public Property FromId As String
  Public Property ToId As String
  Public Property Amount As Decimal
End Class
