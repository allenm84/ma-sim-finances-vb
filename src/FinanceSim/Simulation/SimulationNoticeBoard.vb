Public Class SimulationNoticeBoard
  Implements IAccount

  Public Const AccountId As String = "208a5a33-0d6b-4824-b1e8-e19a43f49331"

  Public Property Balance As Decimal Implements IAccount.Balance

  Public ReadOnly Property Id As String Implements IHasName.Id
    Get
      Return AccountId
    End Get
  End Property

  Public ReadOnly Property Name As String Implements IHasName.Name
    Get
      Return "Notices"
    End Get
  End Property
End Class
