Public Class SnowballSetupEditor

  Public Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    numInitialAmount.InitializeForDecimal()
  End Sub

  Public Sub Populate(setup As SnowBallSetup, profile As Profile)
    numInitialAmount.Value = setup.InitialAmount
    trvDebts.BeginUpdate()
    trvDebts.Nodes.Clear()
    Dim debts = profile.Debts.ToDictionary(Function(it) it.Id)
    For Each id In setup.DebtOrder
      Dim debt As Debt = Nothing
      If debts.TryGetValue(id, debt) Then
        trvDebts.Nodes.Add(New DebtInfoNode(debt))
      End If
    Next
    trvDebts.EndUpdate()
  End Sub

  Public Function ToSetup() As SnowBallSetup
    Return New SnowBallSetup With {
      .InitialAmount = numInitialAmount.Value,
      .DebtOrder = trvDebts.Nodes.OfType(Of DebtInfoNode).Select(Function(it) it.Debt.Id).ToList()
    }
  End Function

End Class