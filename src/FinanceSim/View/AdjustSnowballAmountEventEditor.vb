Public Class AdjustSnowballAmountEventEditor
  Implements IBaseEventEditor

  Private _event As AdjustSnowballAmountEvent

  Public Sub New(baseEvent As AdjustSnowballAmountEvent, profile As Profile)
    ' This call is required by the designer.
    InitializeComponent()
    Dock = DockStyle.Fill

    numAmount.InitializeForDecimal()
    _event = baseEvent
    Read()
  End Sub

  Private Sub Read()
    If _event IsNot Nothing Then
      txtName.Text = _event.Name
      dtpDate.Value = _event.OccursOn
      numAmount.Value = _event.Amount
    End If
  End Sub

  Public Sub Flush() Implements IBaseEventEditor.Flush
    If _event IsNot Nothing Then
      _event.Name = txtName.Text
      _event.OccursOn = dtpDate.Value
      _event.Amount = numAmount.Value
    End If
  End Sub
End Class
