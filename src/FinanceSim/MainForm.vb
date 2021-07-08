Imports System.IO
Imports Newtonsoft.Json

Public Class MainForm
  Private Shared ScheduleSettings As New ScheduleSetup With {
    .DaysAfter = 3,
    .DaysBefore = 3,
    .TargetDate = Date.Today
  }

  Private ReadOnly _removedProfileIds As List(Of String) = New List(Of String)()
  Private currentProfile As Profile

  Private Function BeginOperation() As IDisposable
    SetIsWorking(True)
    Return New UsingStatement(Sub() SetIsWorking(False))
  End Function

  Private Sub SetIsWorking(isWorking As Boolean)
    Enabled = Not isWorking
    pgbStatus.Visible = isWorking
  End Sub

  Private Function AddProfile(profile As Profile) As Integer
    Return cboProfiles.Items.Add(New ComboBoxItem(profile.Name, profile))
  End Function

  Private Sub AddAndSelect(profile As Profile)
    Dim index = AddProfile(profile)
    cboProfiles.SelectedIndex = index
  End Sub

  Private Sub SetProfile(value As Profile)
    Flush()
    currentProfile = value
    Populate()
  End Sub

  Private Sub Flush()
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

  Private Sub Populate()
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

  Private Function RemoveConfirmed() As Boolean
    Dim result = MessageBox.Show(Me, $"Are you sure you want to remove '{currentProfile.Name}'?", "Remove", MessageBoxButtons.YesNo)
    Return result = DialogResult.Yes
  End Function

  Private Shared Sub RefreshSetup(value As SimulationSetup)
    Dim today = Date.Today
    value.StartDate = today
    value.EndDate = today.AddYears(10)
  End Sub

  Private Async Sub DoLoadProfiles() Handles Me.Load
    Using BeginOperation()
      Dim profiles = Await FinanceSimSystem.Fetch()
      Dim selectedIndex = -1
      For Each profile In profiles
        AddProfile(profile)
        selectedIndex += 1
      Next
      cboProfiles.SelectedIndex = selectedIndex
    End Using
  End Sub

  Private Async Sub DoSaveProfiles() Handles tbbSave.Click
    Using BeginOperation()
      Flush()
      Dim profiles = cboProfiles.Items.OfType(Of ComboBoxItem).Select(Function(it) DirectCast(it.Value, Profile))
      Await FinanceSimSystem.Push(profiles, _removedProfileIds)
      _removedProfileIds.Clear()
    End Using
  End Sub

  Private Sub DoUpdateCurrentProfile() Handles cboProfiles.SelectedIndexChanged
    Dim item = TryCast(cboProfiles.SelectedItem, ComboBoxItem)
    SetProfile(TryCast(item?.Value, Profile))
  End Sub

  Private Sub DoCreateNewProfile() Handles tbbNew.Click
    AddAndSelect(New Profile With {
      .Id = Guid.NewGuid().ToString(),
      .Name = "New Profile",
      .Created = Date.Now
    })
  End Sub

  Private Sub DoCloneCurrentProfile() Handles tbbClone.Click
    If currentProfile IsNot Nothing Then
      Dim cloned = currentProfile.Clone()
      cloned.Name = $"{currentProfile.Name} - Copy"
      AddAndSelect(cloned)
    End If
  End Sub

  Private Sub DoRemoveCurrentProfile() Handles tbbRemove.Click
    If currentProfile IsNot Nothing And RemoveConfirmed() Then
      For index = 0 To cboProfiles.Items.Count - 1 Step 1
        Dim item = DirectCast(cboProfiles.Items(index), ComboBoxItem)
        If ReferenceEquals(item.Value, currentProfile) Then
          _removedProfileIds.Add(currentProfile.Id)
          cboProfiles.Items.RemoveAt(index)
          cboProfiles.SelectedIndex = index.Clamp(0, cboProfiles.Items.Count - 1)
          Exit For
        End If
      Next
    End If
  End Sub

  Private Sub DoExportCurrentProfile() Handles tbbExport.Click
    If currentProfile IsNot Nothing Then
      Dim dlg As New SaveFileDialog With {
        .OverwritePrompt = True,
        .Filter = "JSON (*.json) | *.json",
        .Title = "Export Profile"
      }

      If dlg.ShowDialog(Me) = DialogResult.OK Then
        Dim json = JsonConvert.SerializeObject(currentProfile)
        File.WriteAllText(dlg.FileName, json)
      End If
    End If
  End Sub

  Private Sub DoRunSimulation() Handles tbbRun.Click
    If currentProfile IsNot Nothing Then
      Dim setupDlg = New EditSetupDialog()
      setupDlg.Initialize(currentProfile.Setup, AddressOf RefreshSetup)

      If setupDlg.ShowDialog(Me) = DialogResult.OK
        currentProfile.Setup = setupDlg.Value
        Dim results = Simulation.Run(currentProfile)
        Dim resultsWindow = new SimulationResultWindow(results)
        resultsWindow.Show()
      End If
    End If
  End Sub

  Private Sub DoShowSchedule() Handles tbbSchedule.Click
    If currentProfile IsNot Nothing Then
      Dim setupDlg = New EditSetupDialog()
      setupDlg.Initialize(ScheduleSettings, Nothing)
      If setupDlg.ShowDialog(Me) = DialogResult.OK
        ScheduleSettings = setupDlg.Value
        Dim startDate = ScheduleSettings.TargetDate.AddDays(-ScheduleSettings.DaysBefore)
        Dim endDate = ScheduleSettings.TargetDate.AddDays(ScheduleSettings.DaysAfter)
        Dim results = Simulation.Run(currentProfile, startDate, endDate, False)
        Dim resultsWindow = new SimulationResultWindow(results)
        resultsWindow.Show()
      End If
    End If
  End Sub

  Private Class ScheduleSetup
    Public Property DaysBefore As Integer
    Public Property DaysAfter As Integer
    Public Property TargetDate As Date
  End Class
End Class
