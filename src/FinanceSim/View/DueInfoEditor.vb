Public Class DueInfoEditor
  Private Shared CopiedDueInfo? As DueInfo

  Public Sub New()
    ' This call is required by the designer.
    InitializeComponent()

    numPeriod.InitializeForInteger()

    Dim values = [Enum].GetValues(GetType(DueType)).Cast(Of DueType)
    For Each value In values
      cboDueType.Items.Add(value)
    Next

    RefreshEndDate()
    RefreshClipboardState()
  End Sub

  Private Sub RefreshEndDate()
    dtpEnd.Enabled = chkHasEnd.Checked
  End Sub

  Private Sub RefreshClipboardState()
    btnPaste.Enabled = CopiedDueInfo IsNot Nothing
  End Sub

  Public Sub Populate(info As DueInfo)
    dtpStart.SetValue(info.StartOn)
    If info.EndOn.HasValue Then
      chkHasEnd.Checked = True
      dtpEnd.SetValue(info.EndOn.Value)
    Else
      chkHasEnd.Checked = False
      dtpEnd.Value = dtpEnd.MinDate
    End If
    numPeriod.Value = info.Period
    cboDueType.SelectedItem = info.Type
    dtpSeed.Value = info.Seed
    RefreshClipboardState()
  End Sub

  Public Function ToDueInfo() As DueInfo
    Return New DueInfo With {
      .StartOn = dtpStart.Value,
      .EndOn = If(chkHasEnd.Checked, dtpEnd.Value, Nothing),
      .Period = numPeriod.Value,
      .Type = cboDueType.SelectedItem,
      .Seed = dtpSeed.Value
    }
  End Function

  Private Sub chkHasEnd_CheckedChanged(sender As Object, e As EventArgs) Handles chkHasEnd.CheckedChanged
    RefreshEndDate()
  End Sub

  Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click
    CopiedDueInfo = ToDueInfo()
    RefreshClipboardState()
  End Sub

  Private Sub btnPaste_Click(sender As Object, e As EventArgs) Handles btnPaste.Click
    Populate(CopiedDueInfo)
  End Sub
End Class
