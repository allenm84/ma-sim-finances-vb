<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaycheckDepositEditor
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
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.numAmount = New System.Windows.Forms.NumericUpDown()
        Me.cboAccount = New FinanceSim.EntityDropDown()
        Me.tlpLayout.SuspendLayout()
        CType(Me.numAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlpLayout
        '
        Me.tlpLayout.AutoSize = True
        Me.tlpLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpLayout.ColumnCount = 3
        Me.tlpLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.tlpLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.tlpLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.tlpLayout.Controls.Add(Me.txtName, 0, 0)
        Me.tlpLayout.Controls.Add(Me.numAmount, 1, 0)
        Me.tlpLayout.Controls.Add(Me.cboAccount, 2, 0)
        Me.tlpLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpLayout.Location = New System.Drawing.Point(0, 0)
        Me.tlpLayout.Name = "tlpLayout"
        Me.tlpLayout.RowCount = 1
        Me.tlpLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpLayout.Size = New System.Drawing.Size(620, 52)
        Me.tlpLayout.TabIndex = 0
        '
        'txtName
        '
        Me.txtName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtName.Location = New System.Drawing.Point(3, 10)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(180, 31)
        Me.txtName.TabIndex = 0
        '
        'numAmount
        '
        Me.numAmount.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numAmount.Location = New System.Drawing.Point(189, 3)
        Me.numAmount.Name = "numAmount"
        Me.numAmount.Size = New System.Drawing.Size(180, 31)
        Me.numAmount.TabIndex = 1
        '
        'cboAccount
        '
        Me.cboAccount.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboAccount.AutoSize = True
        Me.cboAccount.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cboAccount.Location = New System.Drawing.Point(372, 5)
        Me.cboAccount.Margin = New System.Windows.Forms.Padding(0)
        Me.cboAccount.Name = "cboAccount"
        Me.cboAccount.Size = New System.Drawing.Size(248, 41)
        Me.cboAccount.TabIndex = 2
        '
        'PaycheckDepositEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Controls.Add(Me.tlpLayout)
        Me.Name = "PaycheckDepositEditor"
        Me.Size = New System.Drawing.Size(620, 52)
        Me.tlpLayout.ResumeLayout(False)
        Me.tlpLayout.PerformLayout()
        CType(Me.numAmount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tlpLayout As TableLayoutPanel
    Friend WithEvents txtName As TextBox
    Friend WithEvents numAmount As NumericUpDown
    Friend WithEvents cboAccount As EntityDropDown
End Class
