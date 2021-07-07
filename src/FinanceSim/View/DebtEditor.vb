Public Class DebtEditor
  Implements ICollectionItemEditor

  Private _debt As Debt

  Public Sub New()
    ' This call is required by the designer.
    InitializeComponent()

    Dim values = [Enum].GetValues(GetType(DebtType)).OfType(Of DebtType)
    For Each value In values
      cboType.Items.Add(value)
    Next

    numPayment.InitializeForDecimal()
    numBalance.InitializeForDecimal()
    numInterest.InitializeForDecimal()
  End Sub

  Public Property Profile As Profile Implements ICollectionItemEditor.Profile
    Get
      Return cboAccount.Profile
    End Get
    Set(value As Profile)
      cboAccount.Initialize(value, Function(it) it.Accounts)
    End Set
  End Property

  Public Sub Populate(item As Object) Implements ICollectionItemEditor.Populate
    _debt = DirectCast(item, Debt)
    If _debt IsNot Nothing Then
      txtName.Text = _debt.Name
      cboType.SelectedItem = _debt.Type
      cboAccount.SelectById(_debt.AccountId)
      numPayment.Value = _debt.Payment
      numBalance.Value = _debt.Balance
      numInterest.Value = _debt.Interest
      ctrlDue.Populate(_debt.Due)
    End If
  End Sub

  Public Sub Flush() Implements ICollectionItemEditor.Flush
    If _debt IsNot Nothing Then
      _debt.Name = txtName.Text
      _debt.AccountId = cboAccount.SelectedItem?.Id
      _debt.Due = ctrlDue.ToDueInfo()
      _debt.Payment = numPayment.Value
      _debt.Balance = numBalance.Value
      _debt.Interest = numInterest.Value
      _debt.Type = cboType.SelectedItem
    End If
  End Sub

  Public Function CreateNew() As IHasName Implements ICollectionItemEditor.CreateNew
    Return New Debt With {.Name = "New Debt"}
  End Function
End Class
