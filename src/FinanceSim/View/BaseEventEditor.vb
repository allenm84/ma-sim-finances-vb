Public Class BaseEventEditor
  Implements ICollectionItemEditor

  Private _editor As IBaseEventEditor

  Public Property Profile As Profile Implements ICollectionItemEditor.Profile

  Public Sub Populate(item As Object) Implements ICollectionItemEditor.Populate
    SuspendLayout()

    Dim currentEditor As Control = Nothing
    If Controls.Count > 0 Then
      currentEditor = Controls(0)
    End If

    _editor = Nothing

    Dim baseEvent = DirectCast(item, BaseEvent)
    Select Case baseEvent.GetType()
      Case GetType(AdjustPaycheckTotalEvent)
        _editor = New AdjustPaycheckTotalEventEditor(baseEvent, Profile)
      Case GetType(AdjustSnowballAmountEvent)
        _editor = New AdjustSnowballAmountEventEditor(baseEvent, Profile)
      Case GetType(ChangeBillPaymentEvent)
        _editor = New ChangeBillPaymentEventEditor(baseEvent, Profile)
    End Select

    If _editor IsNot Nothing Then
      Controls.Add(_editor)
    End If

    If currentEditor IsNot Nothing Then
      currentEditor.SendToBack()
      currentEditor.Dispose()
    End If

    ResumeLayout()

  End Sub

  Public Sub Flush() Implements ICollectionItemEditor.Flush
    If _editor IsNot Nothing Then
      _editor.Flush()
    End If
  End Sub

  Public Function CreateNew() As IHasName Implements ICollectionItemEditor.CreateNew
    Throw New NotImplementedException
  End Function

End Class
