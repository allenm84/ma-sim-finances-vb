<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SimulationResultWindow
  Inherits System.Windows.Forms.Form

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    Try
      If disposing AndAlso components IsNot Nothing Then
        components.Dispose()
      End If
    Finally
      MyBase.Dispose(disposing)
    End Try
  End Sub

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SimulationResultWindow))
    Me.tbcResults = New System.Windows.Forms.TabControl()
    Me.SuspendLayout
    '
    'tbcResults
    '
    Me.tbcResults.Dock = System.Windows.Forms.DockStyle.Fill
    Me.tbcResults.Location = New System.Drawing.Point(10, 10)
    Me.tbcResults.Name = "tbcResults"
    Me.tbcResults.SelectedIndex = 0
    Me.tbcResults.Size = New System.Drawing.Size(780, 430)
    Me.tbcResults.TabIndex = 0
    '
    'SimulationResultWindow
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(10!, 25!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(800, 450)
    Me.Controls.Add(Me.tbcResults)
    Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
    Me.Name = "SimulationResultWindow"
    Me.Padding = New System.Windows.Forms.Padding(10)
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Results"
    Me.ResumeLayout(false)

End Sub

  Friend WithEvents tbcResults As TabControl
End Class
