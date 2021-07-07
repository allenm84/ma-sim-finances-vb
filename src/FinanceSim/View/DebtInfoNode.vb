Public Class DebtInfoNode
  Inherits TreeNode

  Public Sub New(debt As Debt)
    Text = $"{debt.Name} [{debt.Balance:C2}]"
    Me.Debt = debt
  End Sub

  Public ReadOnly Property Debt As Debt
End Class
