<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EntityDropDown
  Inherits System.Windows.Forms.UserControl

  'UserControl overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()>
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
  <System.Diagnostics.DebuggerStepThrough()>
  Private Sub InitializeComponent()
    Me.cboItems = New System.Windows.Forms.ComboBox()
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
    Me.btnRefresh = New System.Windows.Forms.Button()
    Me.TableLayoutPanel1.SuspendLayout()
    Me.SuspendLayout()
    '
    'cboItems
    '
    Me.cboItems.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cboItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboItems.FormattingEnabled = True
    Me.cboItems.Location = New System.Drawing.Point(3, 4)
    Me.cboItems.Name = "cboItems"
    Me.cboItems.Size = New System.Drawing.Size(182, 33)
    Me.cboItems.TabIndex = 0
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.AutoSize = True
    Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
    Me.TableLayoutPanel1.ColumnCount = 2
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
    Me.TableLayoutPanel1.Controls.Add(Me.cboItems, 0, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.btnRefresh, 1, 0)
    Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 1
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(228, 41)
    Me.TableLayoutPanel1.TabIndex = 1
    '
    'btnRefresh
    '
    Me.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.None
    Me.btnRefresh.AutoSize = True
    Me.btnRefresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
    Me.btnRefresh.Location = New System.Drawing.Point(191, 3)
    Me.btnRefresh.Name = "btnRefresh"
    Me.btnRefresh.Size = New System.Drawing.Size(34, 35)
    Me.btnRefresh.TabIndex = 1
    Me.btnRefresh.Text = "↻"
    Me.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
    Me.btnRefresh.UseVisualStyleBackColor = True
    '
    'EntityDropDown
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.AutoSize = True
    Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.Name = "EntityDropDown"
    Me.Size = New System.Drawing.Size(228, 41)
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.TableLayoutPanel1.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents cboItems As ComboBox
  Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
  Friend WithEvents btnRefresh As Button
End Class
