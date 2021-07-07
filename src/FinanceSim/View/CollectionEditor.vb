Public Class CollectionEditor
  Private _itemEditor As ICollectionItemEditor

  Private Sub AddNode(Of TItem As IHasName)(item As TItem)
    trvCollection.Nodes.Add(New CollectionEditorNode(item, item.Name))
  End Sub

  Public Sub Populate(Of TItem As IHasName, TEditor As {ICollectionItemEditor, Control, New})(items As List(Of TItem), profile As Profile)
    If _itemEditor IsNot Nothing Then
      _itemEditor.Dispose()
      _itemEditor = Nothing
    End If

    _itemEditor = New TEditor()
    _itemEditor.Profile = profile

    Dim control = DirectCast(_itemEditor, Control)
    control.Dock = DockStyle.Fill
    pnlItemEditor.Controls.Add(control)

    trvCollection.BeginUpdate()
    trvCollection.Nodes.Clear()
    For Each item In items.OrderBy(Function(it) it.Name)
      AddNode(item)
    Next
    trvCollection.EndUpdate()

    If trvCollection.Nodes.Count > 0 Then
      trvCollection.SelectedNode = trvCollection.Nodes(0)
    End If
  End Sub

  Public Iterator Function GetItems(Of TItem As IHasName)() As IEnumerable(Of TItem)
    For Each node In trvCollection.Nodes.OfType(Of CollectionEditorNode)
      Yield node.Value
    Next
  End Function

  Private Sub trvCollection_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles trvCollection.AfterSelect
    If _itemEditor IsNot Nothing Then
      _itemEditor.Flush()

      Dim node = TryCast(e.Node, CollectionEditorNode)
      If node IsNot Nothing Then
        _itemEditor.Populate(node.Value)
      End If
    End If
  End Sub

  Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
    Dim item = _itemEditor.CreateNew()
    AddNode(item)
  End Sub

  Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
    Dim node = trvCollection.SelectedNode
    If node IsNot Nothing Then
      Dim result = MessageBox.Show(Me, $"Are you sure you want to remove '{node.Text}'", "Confirm", MessageBoxButtons.YesNo)
      If result = DialogResult.Yes Then
        node.Remove()
      End If
    End If
  End Sub
End Class
