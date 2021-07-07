Public Class CollectionEditorNode
  Inherits TreeNode

  Public Sub New(value As Object, text As String)
    Me.Text = text
    Me.Value = value
  End Sub

  Public ReadOnly Property Value As Object

End Class
