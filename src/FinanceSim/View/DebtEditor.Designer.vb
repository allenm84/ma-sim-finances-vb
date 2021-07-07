<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DebtEditor
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
        Me.numInterest = New System.Windows.Forms.NumericUpDown()
        Me.numBalance = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.numPayment = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboAccount = New FinanceSim.ItemDropDown()
        Me.ctrlDue = New FinanceSim.DueInfoEditor()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tlpLayout.SuspendLayout()
        CType(Me.numInterest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numBalance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numPayment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlpLayout
        '
        Me.tlpLayout.ColumnCount = 2
        Me.tlpLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpLayout.Controls.Add(Me.numInterest, 1, 5)
        Me.tlpLayout.Controls.Add(Me.numBalance, 1, 4)
        Me.tlpLayout.Controls.Add(Me.Label1, 0, 0)
        Me.tlpLayout.Controls.Add(Me.txtName, 1, 0)
        Me.tlpLayout.Controls.Add(Me.Label2, 0, 2)
        Me.tlpLayout.Controls.Add(Me.Label3, 0, 3)
        Me.tlpLayout.Controls.Add(Me.numPayment, 1, 3)
        Me.tlpLayout.Controls.Add(Me.Label4, 0, 6)
        Me.tlpLayout.Controls.Add(Me.cboAccount, 1, 2)
        Me.tlpLayout.Controls.Add(Me.ctrlDue, 1, 6)
        Me.tlpLayout.Controls.Add(Me.Label5, 0, 1)
        Me.tlpLayout.Controls.Add(Me.cboType, 1, 1)
        Me.tlpLayout.Controls.Add(Me.Label6, 0, 4)
        Me.tlpLayout.Controls.Add(Me.Label7, 0, 5)
        Me.tlpLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpLayout.Location = New System.Drawing.Point(0, 0)
        Me.tlpLayout.Name = "tlpLayout"
        Me.tlpLayout.RowCount = 8
        Me.tlpLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpLayout.Size = New System.Drawing.Size(727, 365)
        Me.tlpLayout.TabIndex = 2
        '
        'numInterest
        '
        Me.numInterest.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numInterest.DecimalPlaces = 2
        Me.numInterest.Location = New System.Drawing.Point(96, 194)
        Me.numInterest.Name = "numInterest"
        Me.numInterest.Size = New System.Drawing.Size(628, 31)
        Me.numInterest.TabIndex = 15
        Me.numInterest.ThousandsSeparator = True
        '
        'numBalance
        '
        Me.numBalance.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numBalance.DecimalPlaces = 2
        Me.numBalance.Location = New System.Drawing.Point(96, 157)
        Me.numBalance.Name = "numBalance"
        Me.numBalance.Size = New System.Drawing.Size(628, 31)
        Me.numBalance.TabIndex = 14
        Me.numBalance.ThousandsSeparator = True
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
        Me.txtName.Size = New System.Drawing.Size(628, 31)
        Me.txtName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Account:"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Payment:"
        '
        'numPayment
        '
        Me.numPayment.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numPayment.DecimalPlaces = 2
        Me.numPayment.Location = New System.Drawing.Point(96, 120)
        Me.numPayment.Name = "numPayment"
        Me.numPayment.Size = New System.Drawing.Size(628, 31)
        Me.numPayment.TabIndex = 5
        Me.numPayment.ThousandsSeparator = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 231)
        Me.Label4.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Schedule:"
        '
        'cboAccount
        '
        Me.cboAccount.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboAccount.AutoSize = True
        Me.cboAccount.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cboAccount.Location = New System.Drawing.Point(93, 76)
        Me.cboAccount.Margin = New System.Windows.Forms.Padding(0)
    Me.cboAccount.Name = "cboAccount"
    Me.cboAccount.Size = New System.Drawing.Size(634, 41)
        Me.cboAccount.TabIndex = 8
        '
        'ctrlDue
        '
        Me.ctrlDue.AutoSize = True
        Me.ctrlDue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ctrlDue.Location = New System.Drawing.Point(96, 231)
        Me.ctrlDue.Name = "ctrlDue"
        Me.ctrlDue.Size = New System.Drawing.Size(601, 82)
        Me.ctrlDue.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 25)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Type:"
        '
        'cboType
        '
        Me.cboType.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboType.FormattingEnabled = True
        Me.cboType.Location = New System.Drawing.Point(96, 40)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(628, 33)
        Me.cboType.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 25)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Balance:"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 197)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 25)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Interest:"
        '
        'DebtEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tlpLayout)
        Me.Name = "DebtEditor"
        Me.Size = New System.Drawing.Size(727, 365)
        Me.tlpLayout.ResumeLayout(False)
        Me.tlpLayout.PerformLayout()
        CType(Me.numInterest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numBalance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numPayment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpLayout As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents numPayment As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents cboAccount As ItemDropDown
    Friend WithEvents ctrlDue As DueInfoEditor
    Friend WithEvents Label5 As Label
    Friend WithEvents cboType As ComboBox
    Friend WithEvents numInterest As NumericUpDown
    Friend WithEvents numBalance As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
