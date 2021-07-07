<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BankAccountEditor
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
        Me.tlpLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.numBalance = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.numAPY = New System.Windows.Forms.NumericUpDown()
        Me.tlpLayout.SuspendLayout()
        CType(Me.numBalance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numAPY, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlpLayout
        '
        Me.tlpLayout.ColumnCount = 2
        Me.tlpLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpLayout.Controls.Add(Me.Label1, 0, 0)
        Me.tlpLayout.Controls.Add(Me.txtName, 1, 0)
        Me.tlpLayout.Controls.Add(Me.Label2, 0, 1)
        Me.tlpLayout.Controls.Add(Me.cboType, 1, 1)
        Me.tlpLayout.Controls.Add(Me.Label3, 0, 2)
        Me.tlpLayout.Controls.Add(Me.numBalance, 1, 2)
        Me.tlpLayout.Controls.Add(Me.Label4, 0, 3)
        Me.tlpLayout.Controls.Add(Me.numAPY, 1, 3)
        Me.tlpLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpLayout.Location = New System.Drawing.Point(0, 0)
        Me.tlpLayout.Name = "tlpLayout"
        Me.tlpLayout.RowCount = 5
        Me.tlpLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpLayout.Size = New System.Drawing.Size(437, 432)
        Me.tlpLayout.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name:"
        '
        'txtName
        '
        Me.txtName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtName.Location = New System.Drawing.Point(84, 3)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(350, 31)
        Me.txtName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Type:"
        '
        'cboType
        '
        Me.cboType.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboType.FormattingEnabled = True
        Me.cboType.Location = New System.Drawing.Point(84, 40)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(350, 33)
        Me.cboType.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Balance:"
        '
        'numBalance
        '
        Me.numBalance.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numBalance.DecimalPlaces = 2
        Me.numBalance.Location = New System.Drawing.Point(84, 79)
        Me.numBalance.Name = "numBalance"
        Me.numBalance.Size = New System.Drawing.Size(350, 31)
        Me.numBalance.TabIndex = 5
        Me.numBalance.ThousandsSeparator = True
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "APY:"
        '
        'numAPY
        '
        Me.numAPY.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numAPY.DecimalPlaces = 2
        Me.numAPY.Location = New System.Drawing.Point(84, 116)
        Me.numAPY.Name = "numAPY"
        Me.numAPY.Size = New System.Drawing.Size(350, 31)
        Me.numAPY.TabIndex = 7
        '
        'BankAccountEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tlpLayout)
        Me.Name = "BankAccountEditor"
        Me.Size = New System.Drawing.Size(437, 432)
        Me.tlpLayout.ResumeLayout(False)
        Me.tlpLayout.PerformLayout()
        CType(Me.numBalance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numAPY, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpLayout As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cboType As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents numBalance As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents numAPY As NumericUpDown
End Class
