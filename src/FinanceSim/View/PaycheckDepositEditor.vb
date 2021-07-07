Public Class PaycheckDepositEditor
  Public Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    numAmount.InitializeForDecimal()
  End Sub

  Public Property Profile As Profile
    Get
      Return cboAccount.Profile
    End Get
    Set(value As Profile)
      cboAccount.Initialize(value, Function(it) it.Accounts)
    End Set
  End Property

  Public Sub Populate(deposit As PaycheckDeposit)
    txtName.Text = deposit.Name
    numAmount.Value = deposit.Amount
    cboAccount.SelectById(deposit.AccountId)
  End Sub

  Public Function ToPaycheckDeposit() As PaycheckDeposit
    Return New PaycheckDeposit With {
      .AccountId = cboAccount.SelectedItem?.Id,
      .Amount = numAmount.Value,
      .Name = txtName.Text
    }
  End Function
End Class
