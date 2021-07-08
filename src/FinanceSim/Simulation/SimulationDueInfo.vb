Public Class SimulationDueInfo
  Private Shared ReadOnly MaxDate As New Date(9876, 12, 31)

  Private ReadOnly _dueInfo As DueInfo
  Private ReadOnly _dueDates As IEnumerator(of Date)

  Public Sub New(startDate As Date, info As DueInfo)
    _dueInfo = info
    _dueDates = CreateDueDateGenerator(startDate).GetEnumerator()
    _dueDates.MoveNext()
    Me.StartDate = Current
  End Sub

  Public ReadOnly Property Current As Date
    Get
      Return _dueDates.Current
    End Get
  End Property

  Public ReadOnly Property StartDate As Date

  Public Sub MoveNext()
    _dueDates.MoveNext()
  End Sub

  Private Function GetNextDate(value as Date) As Date
    Return DueInfoHelper.GetNewDate(value, _dueInfo)
  End Function

  Private Iterator Function GenerateDueDates() As IEnumerable(Of Date)
    Dim endDate = _dueInfo.EndOn.GetValueOrDefault(MaxDate)

    Dim value = _dueInfo.Seed
    While value <= endDate
      Yield value
      value = GetNextDate(value)
      If value = _dueInfo.Seed
        ' If we didn't advance, then exit
        Exit While
      End If
    End While
  End Function

  Private Function CreateDueDateGenerator(value As Date) As IEnumerable(Of Date)
    Dim d1 = value.Date
    Dim d2 = _dueInfo.StartOn.Date
    Dim latest = If(d1 > d2, d1, d2)
    Return GenerateDueDates().SkipWhile(Function(it) it < latest)
  End Function
End Class
