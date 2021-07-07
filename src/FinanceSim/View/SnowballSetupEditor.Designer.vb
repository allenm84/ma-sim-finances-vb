<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SnowballSetupEditor
  Inherits System.Windows.Forms.UserControl

  'UserControl overrides dispose to clean up the component list.
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.numInitialAmount = New System.Windows.Forms.NumericUpDown()
        Me.trvDebts = New System.Windows.Forms.TreeView()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.numInitialAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.numInitialAmount, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.trvDebts, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(665, 296)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Initial Amount:"
        '
        'numInitialAmount
        '
        Me.numInitialAmount.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numInitialAmount.DecimalPlaces = 2
        Me.numInitialAmount.Location = New System.Drawing.Point(137, 3)
        Me.numInitialAmount.Name = "numInitialAmount"
        Me.numInitialAmount.Size = New System.Drawing.Size(525, 31)
        Me.numInitialAmount.TabIndex = 1
        Me.numInitialAmount.ThousandsSeparator = True
        '
        'trvDebts
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.trvDebts, 2)
        Me.trvDebts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.trvDebts.FullRowSelect = True
        Me.trvDebts.HideSelection = False
        Me.trvDebts.Location = New System.Drawing.Point(3, 55)
        Me.trvDebts.Name = "trvDebts"
        Me.trvDebts.ShowLines = False
        Me.trvDebts.ShowPlusMinus = False
        Me.trvDebts.ShowRootLines = False
        Me.trvDebts.Size = New System.Drawing.Size(659, 238)
        Me.trvDebts.TabIndex = 2
        '
        'SnowballSetupEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "SnowballSetupEditor"
        Me.Size = New System.Drawing.Size(665, 296)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.numInitialAmount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents numInitialAmount As NumericUpDown
    Friend WithEvents trvDebts As TreeView
End Class
