<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditSetupDialog
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditSetupDialog))
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
    Me.ptgSetupEditor = New System.Windows.Forms.PropertyGrid()
    Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
    Me.btnRefresh = New System.Windows.Forms.Button()
    Me.btnOK = New System.Windows.Forms.Button()
    Me.btnCancel = New System.Windows.Forms.Button()
    Me.TableLayoutPanel1.SuspendLayout
    Me.TableLayoutPanel2.SuspendLayout
    Me.SuspendLayout
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.ColumnCount = 1
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
    Me.TableLayoutPanel1.Controls.Add(Me.ptgSetupEditor, 0, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
    Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(10, 10)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 2
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(397, 336)
    Me.TableLayoutPanel1.TabIndex = 0
    '
    'ptgSetupEditor
    '
    Me.ptgSetupEditor.Dock = System.Windows.Forms.DockStyle.Fill
    Me.ptgSetupEditor.HelpVisible = false
    Me.ptgSetupEditor.Location = New System.Drawing.Point(3, 3)
    Me.ptgSetupEditor.Name = "ptgSetupEditor"
    Me.ptgSetupEditor.Size = New System.Drawing.Size(391, 290)
    Me.ptgSetupEditor.TabIndex = 1
    Me.ptgSetupEditor.ToolbarVisible = false
    '
    'TableLayoutPanel2
    '
    Me.TableLayoutPanel2.AutoSize = true
    Me.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
    Me.TableLayoutPanel2.ColumnCount = 4
    Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
    Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
    Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
    Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
    Me.TableLayoutPanel2.Controls.Add(Me.btnRefresh, 0, 0)
    Me.TableLayoutPanel2.Controls.Add(Me.btnOK, 2, 0)
    Me.TableLayoutPanel2.Controls.Add(Me.btnCancel, 3, 0)
    Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 296)
    Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
    Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
    Me.TableLayoutPanel2.RowCount = 1
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
    Me.TableLayoutPanel2.Size = New System.Drawing.Size(397, 40)
    Me.TableLayoutPanel2.TabIndex = 2
    '
    'btnRefresh
    '
    Me.btnRefresh.Location = New System.Drawing.Point(3, 3)
    Me.btnRefresh.Name = "btnRefresh"
    Me.btnRefresh.Size = New System.Drawing.Size(112, 34)
    Me.btnRefresh.TabIndex = 0
    Me.btnRefresh.Text = "Refresh"
    Me.btnRefresh.UseVisualStyleBackColor = true
    '
    'btnOK
    '
    Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
    Me.btnOK.Location = New System.Drawing.Point(164, 3)
    Me.btnOK.Name = "btnOK"
    Me.btnOK.Size = New System.Drawing.Size(112, 34)
    Me.btnOK.TabIndex = 1
    Me.btnOK.Text = "OK"
    Me.btnOK.UseVisualStyleBackColor = true
    '
    'btnCancel
    '
    Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnCancel.Location = New System.Drawing.Point(282, 3)
    Me.btnCancel.Name = "btnCancel"
    Me.btnCancel.Size = New System.Drawing.Size(112, 34)
    Me.btnCancel.TabIndex = 2
    Me.btnCancel.Text = "Cancel"
    Me.btnCancel.UseVisualStyleBackColor = true
    '
    'EditSimulationSetup
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(10!, 25!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(417, 356)
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
    Me.MinimizeBox = false
    Me.Name = "EditSimulationSetup"
    Me.Padding = New System.Windows.Forms.Padding(10)
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Edit Setup"
    Me.TableLayoutPanel1.ResumeLayout(false)
    Me.TableLayoutPanel1.PerformLayout
    Me.TableLayoutPanel2.ResumeLayout(false)
    Me.ResumeLayout(false)

End Sub

  Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
  Friend WithEvents ptgSetupEditor As PropertyGrid
  Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
  Friend WithEvents btnRefresh As Button
  Friend WithEvents btnOK As Button
  Friend WithEvents btnCancel As Button
End Class
