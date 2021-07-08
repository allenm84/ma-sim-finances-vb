Public NotInheritable Class Simulation
  Private Shared Sub ProcessEvent(state As SimulationState, processDate As Date, item As BaseEvent)
    Dim adjustPaycheckTotal = TryCast(item, AdjustPaycheckTotalEvent)
    If adjustPaycheckTotal IsNot Nothing Then
      state.AddToPaycheckTotal(processDate, adjustPaycheckTotal.PaycheckId, adjustPaycheckTotal.Amount)
      Exit Sub
    End If

    Dim adjustSnowball = TryCast(item, AdjustSnowballAmountEvent)
    If adjustSnowball IsNot Nothing Then
      state.AddToSnowball(processDate, adjustSnowball.Amount)
      Exit Sub
    End If

    Dim changeBillPayment = TryCast(item, ChangeBillPaymentEvent)
    If changeBillPayment IsNot Nothing Then
      state.ChangeBillPayment(processDate, changeBillPayment.BillId, changeBillPayment.NewPayment)
      Exit Sub
    End If
  End Sub

  Public Shared Function Run(profile As Profile) As Dictionary(Of IAccount, DataTable)
    Return Run(profile, profile.Setup.StartDate, profile.Setup.EndDate, profile.Setup.IsSnowball)
  End Function

  Public Shared Function Run(profile As Profile, startDate As Date, endDate As Date, isSnowBall As Boolean) As Dictionary(Of IAccount, DataTable)
    Dim state = New SimulationState(profile, startDate, isSnowBall)

    Dim currentDate = startDate
    While currentDate <= endDate
      Dim events = state.Events(currentDate)
      For Each item In events
        ProcessEvent(state, currentDate, item)
      Next

      If currentDate.IsEndOfMonth() Then
        For Each account In state.GetAccounts()
          account.ProcessInterest(state, currentDate)
        Next
      End If

      For Each dueItem In state.GetDueItems(currentDate)
        dueItem.Process(state, currentDate)
        dueItem.Due.MoveNext()
      Next

      For Each debt In state.Debts.Values.Where(Function(it) it.Balance <= 0)
        state.PayOff(currentDate, debt)
      Next

      state.UpdateSnowball(currentDate)

      If Not state.ShouldKeepGoing()
        Exit While
      End If

      currentDate = currentDate.AddDays(1)
    End While

    Return state.Results
  End Function
End Class
