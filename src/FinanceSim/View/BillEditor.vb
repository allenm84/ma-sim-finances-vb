Public Class BillEditor
  Implements ICollectionItemEditor

  Private _bill As Bill

  Public Sub New()

    ' This call is required by the designer.
    InitializeComponent()
    numPayment.InitializeForDecimal()
  End Sub

  Public Property Profile As Profile Implements ICollectionItemEditor.Profile
    Get
      Return cboAccount.Profile
    End Get
    Set(value As Profile)
      cboAccount.Initialize(value, Function(it) it.GetAccounts())
    End Set
  End Property

  Public Sub Populate(item As Object) Implements ICollectionItemEditor.Populate
    _bill = DirectCast(item, Bill)
    If _bill IsNot Nothing Then
      txtName.Text = _bill.Name
      cboAccount.SelectById(_bill.AccountId)
      numPayment.Value = _bill.Payment
      ctrlDue.Populate(_bill.Due)
    End If
  End Sub

  Public Sub Flush() Implements ICollectionItemEditor.Flush
    If _bill IsNot Nothing Then
      _bill.Name = txtName.Text
      _bill.AccountId = cboAccount.SelectedItem?.Id
      _bill.Due = ctrlDue.ToDueInfo()
      _bill.Payment = numPayment.Value
    End If
  End Sub

  Public Function CreateNew() As IHasName Implements ICollectionItemEditor.CreateNew
    Return New Bill With {
      .Id = Guid.NewGuid().ToString(),
      .Name = "New Bill"
    }
  End Function
End Class
