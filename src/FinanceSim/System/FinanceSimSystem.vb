Imports Google.Cloud.Firestore
Imports Newtonsoft.Json

Public NotInheritable Class FinanceSimSystem
  Private Const ProjectId = "mapa-apps"
  Private Const CollectionName = "financeSim"

  Private Shared ReadOnly JsonConvertSettings = New JsonSerializerSettings With {
    .TypeNameHandling = TypeNameHandling.Auto
  }

  Public Shared Async Function ReadProfiles() As Task(Of IEnumerable(Of Profile))
    Dim db = FirestoreDb.Create(ProjectId)
    Dim collectionRef = db.Collection(CollectionName)
    Dim snapshot = Await collectionRef.GetSnapshotAsync()
    Dim profiles = New List(Of Profile)
    For Each document In snapshot.Documents
      Dim values = document.ToDictionary()
      Dim ejson = DirectCast(values("Data"), String)
      Dim djson = StringCipher.Decrypt(ejson)
      Dim profile = JsonConvert.DeserializeObject(Of Profile)(djson, JsonConvertSettings)
      profiles.Add(profile)
    Next
    Return profiles.OrderBy(Function(it) it.Created)
  End Function
End Class
