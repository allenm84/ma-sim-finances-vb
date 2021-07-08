Public Class SimulationResultWindow
  Public Sub New(data As Dictionary(Of IAccount, DataTable))
    InitializeComponent()

    For Each kvp In data.OrderBy(Function(it) it.Key.Name)
      Dim account = kvp.Key
      Dim page As New TabPage With {.Text = account.Name}
      Dim grid = New DataGridView With {
        .DataSource = kvp.Value,
        .ReadOnly = True,
        .RowHeadersVisible = False,
        .SelectionMode = DataGridViewSelectionMode.FullRowSelect,
        .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
        .AllowUserToDeleteRows = False,
        .AllowUserToResizeRows = False
      }
      grid.Dock = DockStyle.Fill
      page.Controls.Add(grid)
      tbcResults.TabPages.Add(page)
    Next

    tbcResults.SelectedIndex = 0

  End Sub
End Class