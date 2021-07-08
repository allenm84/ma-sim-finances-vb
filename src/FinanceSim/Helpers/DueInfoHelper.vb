Public NotInheritable Class DueInfoHelper
  Private Shared Function Sanitize(value As Date, due As DueInfo) As Date
    If value.Day <> due.Seed.Day Then
      Dim days = Date.DaysInMonth(value.Year, value.Month)
      value = New Date(value.Year, value.Month, Math.Min(days, due.Seed.Day))
    End If
    Return value
  End Function

  Public Shared Function GetNewDate(value As Date, due As DueInfo) As Date
    Dim newDate As Date
    Select Case due.Type
      Case DueType.Daily
        newDate = value.AddDays(due.Period)
      Case DueType.Weekly
        newDate = value.AddDays(7 * due.Period)
      Case DueType.Monthly
        newDate = Sanitize(value.AddMonths(due.Period), due)
      Case DueType.Yearly
        newDate = Sanitize(value.AddYears(due.Period), due)
    End Select
    Return newDate
  End Function

  Public Shared Function GetDisplay(due As DueInfo) As String
    If due.Type = DueType.Once Then
      Return $"{due.Seed:d}"
    Else
      Return $"{due.Period}x {due.Type}, seed: {due.Seed:d}"
    End If
  End Function
End Class
