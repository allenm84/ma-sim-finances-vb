Public Interface ICollectionItemEditor
  Inherits IDisposable
  Property Profile As Profile
  Sub Populate(item As Object)
  Sub Flush()
  Function CreateNew() As IHasName
End Interface
