Imports Newtonsoft.Json

Public MustInherit Class BaseEvent
  Inherits BaseNamedWithoutId
  <JsonProperty("Date")>
  Public Property OccursOn As Date
End Class
