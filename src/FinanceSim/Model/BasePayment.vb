Public MustInherit Class BasePayment
  Implements IHasDueInfo

  Public Property Due As DueInfo Implements IHasDueInfo.Due
  Public Property Id As String Implements IHasName.Id
  Public Property Name As String Implements IHasName.Name
  Public Property Payment As Decimal
  Public Property AccountId As String
End Class
