Imports Google.Cloud.Firestore
Imports Newtonsoft.Json

Public NotInheritable Class FinanceSimSystem
  Private Const ProjectId = "mapa-apps"
  Private Const CollectionName = "financeSim"

  Public Shared Async Function Fetch() As Task(Of IEnumerable(Of Profile))
    Dim db = Await FirestoreDb.CreateAsync(ProjectId)
    Dim collectionRef = db.Collection(CollectionName)
    Dim snapshot = Await collectionRef.GetSnapshotAsync()
    Dim profiles = New List(Of Profile)
    For Each document In snapshot.Documents
      Dim values = document.ToDictionary()
      Dim encrypted = DirectCast(values("Data"), String)
      Dim decrypted = StringCipher.Decrypt(encrypted)
      Dim profile = JsonConvert.DeserializeObject (Of Profile)(decrypted, JsonConvertSettings)
      profiles.Add(profile)
    Next
    Return profiles.OrderBy(Function(it) it.Created)
  End Function

  Public Shared Async Function Push(profiles As IEnumerable(Of Profile), removedProfileIds As IEnumerable(Of String)) As Task
    Dim db = Await FirestoreDb.CreateAsync(ProjectId)
    Dim collectionRef = db.Collection(CollectionName)
    For Each profile In profiles
      Dim decrypted = JsonConvert.SerializeObject(profile, JsonConvertSettings)
      Dim encrypted = StringCipher.Encrypt(decrypted)
      Dim docRef = collectionRef.Document(profile.Id)
      Dim docData = New Dictionary(Of String, Object) From {
        {"Name", profile.Name},
        {"Created", profile.Created.ToUniversalTime()},
        {"Data", encrypted}
      }
      Await docRef.SetAsync(docData)
    Next

    For Each id In removedProfileIds
      Dim docRef = collectionRef.Document(id)
      Await docRef.DeleteAsync()
    Next
  End Function
End Class
