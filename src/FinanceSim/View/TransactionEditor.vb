Public Class TransactionEditor
  Implements ICollectionItemEditor

  Private _profile As Profile
  Private _transaction As Transaction

  Public Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    numAmount.InitializeForDecimal()
  End Sub

  Public Property Profile As Profile Implements ICollectionItemEditor.Profile
    Get
      Return _profile
    End Get
    Set(value As Profile)
      _profile = value
      cboFromAccount.Initialize(_profile, Function(it) it.GetAccounts())
      cboToAccount.Initialize(_profile, Function(it) it.GetAccounts())
    End Set
  End Property

  Public Sub Populate(item As Object) Implements ICollectionItemEditor.Populate
    _transaction = DirectCast(item, Transaction)
    If _transaction IsNot Nothing Then
      txtName.Text = _transaction.Name
      numAmount.Value = _transaction.Amount
      cboFromAccount.SelectById(_transaction.FromId)
      cboToAccount.SelectById(_transaction.ToId)
      ctrlDue.Populate(_transaction.Due)
    End If
  End Sub

  Public Sub Flush() Implements ICollectionItemEditor.Flush
    If _transaction IsNot Nothing Then
      _transaction.Name = txtName.Text
      _transaction.Amount = numAmount.Value
      _transaction.FromId = cboFromAccount.SelectedItem?.Id
      _transaction.ToId = cboToAccount.SelectedItem?.Id
      _transaction.Due = ctrlDue.ToDueInfo()
    End If
  End Sub

  Public Function CreateNew() As IHasName Implements ICollectionItemEditor.CreateNew
    Return New Transaction With {
      .Id = Guid.NewGuid().ToString(),
      .Name = "New Transaction"
    }
  End Function
End Class
