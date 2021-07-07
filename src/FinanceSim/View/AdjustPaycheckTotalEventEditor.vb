Public Class AdjustPaycheckTotalEventEditor
  Implements IBaseEventEditor

  Private _event As AdjustPaycheckTotalEvent

  Public Sub New(baseEvent As AdjustPaycheckTotalEvent, profile As Profile)
    ' This call is required by the designer.
    InitializeComponent()
    Dock = DockStyle.Fill

    numAmount.InitializeForDecimal()
    _event = baseEvent
    cboPaychecks.Initialize(profile, Function(it) it.Paychecks)
    Read()
  End Sub

  Private Sub Read()
    If _event IsNot Nothing Then
      txtName.Text = _event.Name
      dtpDate.Value = _event.OccursOn
      numAmount.Value = _event.Amount
      cboPaychecks.SelectById(_event.PaycheckId)
    End If
  End Sub

  Public Sub Flush() Implements IBaseEventEditor.Flush
    If _event IsNot Nothing Then
      _event.Name = txtName.Text
      _event.OccursOn = dtpDate.Value
      _event.Amount = numAmount.Value
      _event.PaycheckId = cboPaychecks.SelectedItem?.Id
    End If
  End Sub
End Class
