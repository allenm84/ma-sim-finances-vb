Public Class ChangeBillPaymentEventEditor
  Implements IBaseEventEditor

  Private _event As ChangeBillPaymentEvent

  Public Sub New(baseEvent As ChangeBillPaymentEvent, profile As Profile)
    ' This call is required by the designer.
    InitializeComponent()
    Dock = DockStyle.Fill

    numNewPayment.InitializeForDecimal()
    _event = baseEvent
    cboBills.Initialize(profile, Function(it) it.Bills)
    Read()
  End Sub

  Private Sub Read()
    If _event IsNot Nothing Then
      txtName.Text = _event.Name
      dtpDate.Value = _event.OccursOn
      numNewPayment.Value = _event.NewPayment
      cboBills.SelectById(_event.BillId)
    End If
  End Sub

  Public Sub Flush() Implements IBaseEventEditor.Flush
    If _event IsNot Nothing Then
      _event.Name = txtName.Text
      _event.OccursOn = dtpDate.Value
      _event.NewPayment = numNewPayment.Value
      _event.BillId = cboBills.SelectedItem?.Id
    End If
  End Sub
End Class
