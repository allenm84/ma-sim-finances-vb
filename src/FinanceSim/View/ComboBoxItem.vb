Public Class ComboBoxItem
  Public Sub New(text As String, value As Object)
    Me.Text = text
    Me.Value = value
  End Sub

  Public ReadOnly Property Text As String
  Public ReadOnly Property Value As Object
  Public Overrides Function ToString() As String
    Return Text
  End Function
End Class
