<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BillEditor
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
        Me.numPayment = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboAccount = New FinanceSim.EntityDropDown()
        Me.ctrlDue = New FinanceSim.DueInfoEditor()
        Me.tlpLayout.SuspendLayout()
        CType(Me.numPayment, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tlpLayout.Controls.Add(Me.Label3, 0, 2)
        Me.tlpLayout.Controls.Add(Me.numPayment, 1, 2)
        Me.tlpLayout.Controls.Add(Me.Label4, 0, 3)
        Me.tlpLayout.Controls.Add(Me.cboAccount, 1, 1)
        Me.tlpLayout.Controls.Add(Me.ctrlDue, 1, 3)
        Me.tlpLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpLayout.Location = New System.Drawing.Point(0, 0)
        Me.tlpLayout.Name = "tlpLayout"
        Me.tlpLayout.RowCount = 5
        Me.tlpLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpLayout.Size = New System.Drawing.Size(705, 343)
        Me.tlpLayout.TabIndex = 1
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
        Me.txtName.Size = New System.Drawing.Size(606, 31)
        Me.txtName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Account:"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Payment:"
        '
        'numPayment
        '
        Me.numPayment.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numPayment.DecimalPlaces = 2
        Me.numPayment.Location = New System.Drawing.Point(96, 81)
        Me.numPayment.Name = "numPayment"
        Me.numPayment.Size = New System.Drawing.Size(606, 31)
        Me.numPayment.TabIndex = 5
        Me.numPayment.ThousandsSeparator = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 118)
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
        Me.cboAccount.Location = New System.Drawing.Point(93, 37)
        Me.cboAccount.Margin = New System.Windows.Forms.Padding(0)
    Me.cboAccount.Name = "cboAccount"
    Me.cboAccount.Size = New System.Drawing.Size(612, 41)
        Me.cboAccount.TabIndex = 8
        '
        'ctrlDue
        '
        Me.ctrlDue.AutoSize = True
        Me.ctrlDue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ctrlDue.Location = New System.Drawing.Point(96, 118)
        Me.ctrlDue.Name = "ctrlDue"
        Me.ctrlDue.Size = New System.Drawing.Size(601, 82)
        Me.ctrlDue.TabIndex = 9
        '
        'BillEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tlpLayout)
        Me.Name = "BillEditor"
        Me.Size = New System.Drawing.Size(705, 343)
        Me.tlpLayout.ResumeLayout(False)
        Me.tlpLayout.PerformLayout()
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
    Friend WithEvents cboAccount As EntityDropDown
    Friend WithEvents ctrlDue As DueInfoEditor
End Class
