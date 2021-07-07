<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransactionEditor
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.numAmount = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboFromAccount = New FinanceSim.ItemDropDown()
        Me.ctrlDue = New FinanceSim.DueInfoEditor()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboToAccount = New FinanceSim.ItemDropDown()
        Me.tlpLayout.SuspendLayout()
        CType(Me.numAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlpLayout
        '
        Me.tlpLayout.ColumnCount = 2
        Me.tlpLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpLayout.Controls.Add(Me.cboToAccount, 1, 3)
        Me.tlpLayout.Controls.Add(Me.Label1, 0, 0)
        Me.tlpLayout.Controls.Add(Me.txtName, 1, 0)
        Me.tlpLayout.Controls.Add(Me.Label2, 0, 2)
        Me.tlpLayout.Controls.Add(Me.Label4, 0, 4)
        Me.tlpLayout.Controls.Add(Me.cboFromAccount, 1, 2)
        Me.tlpLayout.Controls.Add(Me.ctrlDue, 1, 4)
        Me.tlpLayout.Controls.Add(Me.Label3, 0, 1)
        Me.tlpLayout.Controls.Add(Me.numAmount, 1, 1)
        Me.tlpLayout.Controls.Add(Me.Label5, 0, 3)
        Me.tlpLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpLayout.Location = New System.Drawing.Point(0, 0)
        Me.tlpLayout.Name = "tlpLayout"
        Me.tlpLayout.RowCount = 6
        Me.tlpLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpLayout.Size = New System.Drawing.Size(731, 333)
        Me.tlpLayout.TabIndex = 2
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
        Me.txtName.Location = New System.Drawing.Point(96, 3)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(632, 31)
        Me.txtName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "From:"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Amount:"
        '
        'numAmount
        '
        Me.numAmount.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numAmount.DecimalPlaces = 2
        Me.numAmount.Location = New System.Drawing.Point(96, 40)
        Me.numAmount.Name = "numAmount"
        Me.numAmount.Size = New System.Drawing.Size(632, 31)
        Me.numAmount.TabIndex = 5
        Me.numAmount.ThousandsSeparator = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 159)
        Me.Label4.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Schedule:"
        '
        'cboFromAccount
        '
        Me.cboFromAccount.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboFromAccount.AutoSize = True
        Me.cboFromAccount.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cboFromAccount.Location = New System.Drawing.Point(93, 74)
        Me.cboFromAccount.Margin = New System.Windows.Forms.Padding(0)
        Me.cboFromAccount.Name = "cboFromAccount"
        Me.cboFromAccount.Size = New System.Drawing.Size(638, 41)
        Me.cboFromAccount.TabIndex = 8
        '
        'ctrlDue
        '
        Me.ctrlDue.AutoSize = True
        Me.ctrlDue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ctrlDue.Location = New System.Drawing.Point(96, 159)
        Me.ctrlDue.Name = "ctrlDue"
        Me.ctrlDue.Size = New System.Drawing.Size(601, 82)
        Me.ctrlDue.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 25)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "To:"
        '
        'cboToAccount
        '
        Me.cboToAccount.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboToAccount.AutoSize = True
        Me.cboToAccount.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cboToAccount.Location = New System.Drawing.Point(93, 115)
        Me.cboToAccount.Margin = New System.Windows.Forms.Padding(0)
    Me.cboToAccount.Name = "cboToAccount"
    Me.cboToAccount.Size = New System.Drawing.Size(638, 41)
        Me.cboToAccount.TabIndex = 11
        '
        'TransactionEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tlpLayout)
        Me.Name = "TransactionEditor"
        Me.Size = New System.Drawing.Size(731, 333)
        Me.tlpLayout.ResumeLayout(False)
        Me.tlpLayout.PerformLayout()
        CType(Me.numAmount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpLayout As TableLayoutPanel
    Friend WithEvents cboToAccount As ItemDropDown
    Friend WithEvents Label1 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cboFromAccount As ItemDropDown
    Friend WithEvents ctrlDue As DueInfoEditor
    Friend WithEvents Label3 As Label
    Friend WithEvents numAmount As NumericUpDown
    Friend WithEvents Label5 As Label
End Class
