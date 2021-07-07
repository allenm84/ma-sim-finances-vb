Public Class PaycheckEditor
  Implements ICollectionItemEditor

  Private _paycheck As Paycheck

  Public Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    numTotal.InitializeForDecimal()
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
    _paycheck = DirectCast(item, Paycheck)
    If _paycheck IsNot Nothing Then
      txtName.Text = _paycheck.Name
      cboAccount.SelectById(_paycheck.AccountId)
      numTotal.Value = _paycheck.Total
      ctrlDue.Populate(_paycheck.Due)

      tlpScroller.Controls.Clear()
      tlpScroller.SuspendLayout()
      tlpScroller.RowStyles.Clear()
      tlpScroller.RowCount = _paycheck.Deposits.Count
      For Each deposit In _paycheck.Deposits
        Dim editor = New PaycheckDepositEditor With {
          .Profile = Profile,
          .Anchor = AnchorStyles.Left Or AnchorStyles.Right
        }
        editor.Populate(deposit)
        tlpScroller.RowStyles.Add(New RowStyle With {.SizeType = SizeType.AutoSize})
        tlpScroller.Controls.Add(editor)
      Next
      tlpScroller.ResumeLayout()
    End If
  End Sub

  Public Sub Flush() Implements ICollectionItemEditor.Flush
    If _paycheck IsNot Nothing Then
      _paycheck.Name = txtName.Text
      _paycheck.AccountId = cboAccount.SelectedItem?.Id
      _paycheck.Deposits = tlpScroller.Controls.OfType(Of PaycheckDepositEditor).Select(Function(it) it.ToPaycheckDeposit()).ToList()
      _paycheck.Due = ctrlDue.ToDueInfo()
      _paycheck.Total = numTotal.Value
    End If
  End Sub

  Public Function CreateNew() As IHasName Implements ICollectionItemEditor.CreateNew
    Return New Paycheck() With {.Name = "New Paycheck"}
  End Function
End Class
