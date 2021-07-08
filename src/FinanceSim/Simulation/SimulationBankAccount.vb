Public Class SimulationBankAccount
  Inherits SimulationAccount

  Public Sub New(account As BankAccount)
    MyBase.New(account)
    APY = account.APY
  End Sub

  Public Property APY As Decimal

  Public Overrides Sub ProcessInterest(state As SimulationState, processDate As Date)
    If APY > 0 Then
      Dim amount = (APY / 12d) * Balance
      state.Deposit(processDate, Me, $"APY({APY:P2})", amount)
    End If
  End Sub

  Public Overrides Sub Deposit(state As SimulationState, depositDate As Date, amount As Decimal)
    Balance += amount
  End Sub

  Public Overrides Sub Withdraw(state As SimulationState, withdrawDate As Date, amount As Decimal)
    Dim currentBalance = Balance
    Balance -= amount
    If Balance < 0 And currentBalance >= 0 Then
      state.AddNotice(withdrawDate, $"ALERT: {Name} has balance of {Balance:C2}")
    End If
  End Sub
End Class
