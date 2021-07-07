Public MustInherit Class BaseNamedWithoutId
  Implements IHasName

  Public ReadOnly Property Id As String = "{no-id}" Implements IHasName.Id
  Public Property Name As String Implements IHasName.Name
End Class
