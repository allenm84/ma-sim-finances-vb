Imports Newtonsoft.Json

Public Class SimulationSetup
  <JsonProperty("Start")>
  Public Property Starts As Date
  <JsonProperty("End")>
  Public Property Stops As Date
  <JsonProperty("UseSnowball")>
  Public Property IsSnowball As Boolean
End Class
