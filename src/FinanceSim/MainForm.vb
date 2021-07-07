Public Class MainForm
  Private currentProfile As Profile

  Private Function BeginOperation() As IDisposable
    SetIsWorking(True)
    Return New UsingStatement(Sub() SetIsWorking(False))
  End Function

  Private Sub SetIsWorking(isWorking As Boolean)
    Enabled = Not isWorking
    pgbStatus.Visible = isWorking
  End Sub

  Private Async Sub LoadProfiles() Handles Me.Load
    Using BeginOperation()
      Dim profiles = Await FinanceSimSystem.ReadProfiles()
      Dim selectedIndex = -1
      For Each profile In profiles
        cboProfiles.Items.Add(New ComboBoxItem(profile.Name, profile))
        selectedIndex += 1
      Next
      cboProfiles.SelectedIndex = selectedIndex
    End Using
  End Sub

  Private Sub WriteProfile()
    If currentProfile IsNot Nothing Then
      currentProfile.Name = txtProfileName.Text
      currentProfile.Accounts = cleAccounts.GetItems(Of BankAccount).ToList()
      currentProfile.Paychecks = clePaychecks.GetItems(Of Paycheck).ToList()
      currentProfile.Bills = cleBills.GetItems(Of Bill).ToList()
      currentProfile.Debts = cleDebts.GetItems(Of Debt).ToList()
      currentProfile.Transactions = cleTransactions.GetItems(Of Transaction).ToList()
      currentProfile.Events = cleEvents.GetItems(Of BaseEvent).ToList()
      currentProfile.Snowball = ctrlSnowballSetup.ToSetup()
    End If
  End Sub

  Private Sub ReadProfile()
    If currentProfile IsNot Nothing Then
      txtProfileName.Text = currentProfile.Name
      cleAccounts.Populate(Of BankAccount, BankAccountEditor)(currentProfile.Accounts, currentProfile)
      clePaychecks.Populate(Of Paycheck, PaycheckEditor)(currentProfile.Paychecks, currentProfile)
      cleBills.Populate(Of Bill, BillEditor)(currentProfile.Bills, currentProfile)
      cleDebts.Populate(Of Debt, DebtEditor)(currentProfile.Debts, currentProfile)
      cleTransactions.Populate(Of Transaction, TransactionEditor)(currentProfile.Transactions, currentProfile)
      cleEvents.Populate(Of BaseEvent, BaseEventEditor)(currentProfile.Events, currentProfile)
      ctrlSnowballSetup.Populate(currentProfile.Snowball, currentProfile)
    End If
  End Sub

  Private Sub cboProfiles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProfiles.SelectedIndexChanged
    Dim item = TryCast(cboProfiles.SelectedItem, ComboBoxItem)
    WriteProfile()
    currentProfile = TryCast(item?.Value, Profile)
    ReadProfile()
  End Sub
End Class
