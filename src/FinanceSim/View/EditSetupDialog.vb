Public Class EditSetupDialog
  Private _currentValue As Object
  Private _refreshAction As Action(Of Object)

  Public Sub Initialize(Of T)(setup As T, refreshAction As Action(Of Object))
    _refreshAction = refreshAction
    _currentValue = setup.Clone()
    ptgSetupEditor.SelectedObject = _currentValue
    btnRefresh.Visible = refreshAction IsNot Nothing
  End Sub

  Public ReadOnly Property Value As Object
    Get
      Return _currentValue
    End Get
  End Property

  Private Sub DoRefreshSetup() Handles btnRefresh.Click
    _refreshAction.Invoke(_currentValue)
    ptgSetupEditor.Refresh()
  End Sub
End Class