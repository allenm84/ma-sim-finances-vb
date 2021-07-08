Imports Newtonsoft.Json

Public Class SimulationSetup
  <JsonProperty("Start")>
  Public Property StartDate As Date
  <JsonProperty("End")>
  Public Property EndDate As Date
  <JsonProperty("UseSnowball")>
  Public Property IsSnowball As Boolean
End Class
