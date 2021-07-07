Imports Newtonsoft.Json

Public Enum DueType
  Once
  Daily
  Weekly
  Monthly
  Yearly
End Enum

Public Structure DueInfo
  <JsonProperty("Start")>
  Public Property StartOn As Date
  <JsonProperty("End")>
  Public Property EndOn As Nullable(Of DateTime)
  Public Property Type As DueType
  Public Property Period As Integer
  Public Property Seed As Date
  Public Overrides Function ToString() As String
    Return DueInfoHelper.GetDisplay(Me)
  End Function
End Structure
