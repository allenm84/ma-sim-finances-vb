Public Class BankAccountEditor
  Implements ICollectionItemEditor

  Private _account As BankAccount

  Public Sub New()
    ' This call is required by the designer.
    InitializeComponent()

    numAPY.InitializeForDecimal()
    numBalance.InitializeForDecimal()

    cboType.Items.Add(BankAccountType.Checking)
    cboType.Items.Add(BankAccountType.Savings)
  End Sub

  Public Property Profile As Profile Implements ICollectionItemEditor.Profile

  Public Sub Populate(item As Object) Implements ICollectionItemEditor.Populate
    _account = DirectCast(item, BankAccount)
    If _account IsNot Nothing Then
      txtName.Text = _account.Name
      cboType.SelectedItem = _account.Type
      numBalance.Value = _account.Balance
      numAPY.Value = _account.APY
    End If
  End Sub

  Public Sub Flush() Implements ICollectionItemEditor.Flush
    If _account IsNot Nothing Then
      _account.Name = txtName.Text
      _account.Type = DirectCast(cboType.SelectedItem, BankAccountType)
      _account.Balance = numBalance.Value
      _account.APY = numAPY.Value
    End If

    txtName.Text = ""
    cboType.SelectedIndex = -1
    numBalance.Value = 0
    numAPY.Value = 0
  End Sub

  Public Function CreateNew() As IHasName Implements ICollectionItemEditor.CreateNew
    Return New BankAccount() With {
      .Id = Guid.NewGuid().ToString(),
      .Name = "New Account"
    }
  End Function
End Class
