Public Class ItemDropDown
  Private _profile As Profile
  Private _selector As Func(Of Profile, IEnumerable(Of IHasName))

  Public ReadOnly Property Profile As Profile
    Get
      Return _profile
    End Get
  End Property

  Public ReadOnly Property SelectedItem() As IHasName
    Get
      Dim item = TryCast(cboItems.SelectedItem, ComboBoxItem)
      Return TryCast(item?.Value, IHasName)
    End Get
  End Property

  Public Sub Initialize(profile As Profile, selector As Func(Of Profile, IEnumerable(Of IHasName)))
    _profile = profile
    _selector = selector
    RefreshDropDown()
  End Sub

  Public Sub SelectById(id As String)
    cboItems.SelectedIndex = -1
    For index As Integer = 0 To cboItems.Items.Count - 1 Step 1
      Dim item = TryCast(cboItems.Items(index), ComboBoxItem)
      Dim account = TryCast(item?.Value, IHasName)
      If String.Equals(account?.Id, id) Then
        cboItems.SelectedIndex = index
        Exit For
      End If
    Next
  End Sub

  Private Sub RefreshDropDown()
    Dim accountId = SelectedItem?.Id
    cboItems.BeginUpdate()
    cboItems.Items.Clear()

    Dim items = _selector.Invoke(_profile)
    For Each item In items.OrderBy(Function(it) it.Name)
      cboItems.Items.Add(New ComboBoxItem(item.Name, item))
    Next
    cboItems.EndUpdate()
    SelectById(accountId)
  End Sub

  Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
    RefreshDropDown()
  End Sub
End Class
