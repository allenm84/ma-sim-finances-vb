Public Class UsingStatement
  Implements IDisposable

  Private _onDispose As Action

  Public Sub New(onDispose As Action)
    _onDispose = onDispose
  End Sub

  Public Sub Dispose() Implements IDisposable.Dispose
    If _onDispose IsNot Nothing Then
      _onDispose.Invoke()
      _onDispose = Nothing
    End If
  End Sub
End Class
