<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PaycheckEditor
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
        Me.tlpLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.numTotal = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tlpDeposits = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlDeposits = New System.Windows.Forms.Panel()
        Me.tlpScroller = New System.Windows.Forms.TableLayoutPanel()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboAccount = New FinanceSim.EntityDropDown()
        Me.ctrlDue = New FinanceSim.DueInfoEditor()
        Me.tlpLayout.SuspendLayout()
        CType(Me.numTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpDeposits.SuspendLayout()
        Me.pnlDeposits.SuspendLayout()
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
        Me.tlpLayout.Controls.Add(Me.numTotal, 1, 2)
        Me.tlpLayout.Controls.Add(Me.Label4, 0, 3)
        Me.tlpLayout.Controls.Add(Me.tlpDeposits, 1, 3)
        Me.tlpLayout.Controls.Add(Me.Label5, 0, 4)
        Me.tlpLayout.Controls.Add(Me.cboAccount, 1, 1)
        Me.tlpLayout.Controls.Add(Me.ctrlDue, 1, 4)
        Me.tlpLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpLayout.Location = New System.Drawing.Point(0, 0)
        Me.tlpLayout.Name = "tlpLayout"
        Me.tlpLayout.RowCount = 5
        Me.tlpLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666!))
        Me.tlpLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpLayout.Size = New System.Drawing.Size(715, 336)
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
        Me.txtName.Size = New System.Drawing.Size(616, 31)
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
        Me.Label3.Size = New System.Drawing.Size(53, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Total:"
        '
        'numTotal
        '
        Me.numTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numTotal.DecimalPlaces = 2
        Me.numTotal.Location = New System.Drawing.Point(96, 81)
        Me.numTotal.Name = "numTotal"
        Me.numTotal.Size = New System.Drawing.Size(616, 31)
        Me.numTotal.TabIndex = 5
        Me.numTotal.ThousandsSeparator = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 118)
        Me.Label4.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Deposits:"
        '
        'tlpDeposits
        '
        Me.tlpDeposits.ColumnCount = 2
        Me.tlpDeposits.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpDeposits.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpDeposits.Controls.Add(Me.pnlDeposits, 0, 0)
        Me.tlpDeposits.Controls.Add(Me.btnAdd, 1, 0)
        Me.tlpDeposits.Controls.Add(Me.btnRemove, 1, 1)
        Me.tlpDeposits.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpDeposits.Location = New System.Drawing.Point(96, 118)
        Me.tlpDeposits.Name = "tlpDeposits"
        Me.tlpDeposits.RowCount = 3
        Me.tlpDeposits.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpDeposits.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpDeposits.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpDeposits.Size = New System.Drawing.Size(616, 127)
        Me.tlpDeposits.TabIndex = 8
        '
        'pnlDeposits
        '
        Me.pnlDeposits.AutoScroll = True
        Me.pnlDeposits.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlDeposits.Controls.Add(Me.tlpScroller)
        Me.pnlDeposits.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDeposits.Location = New System.Drawing.Point(0, 0)
        Me.pnlDeposits.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlDeposits.Name = "pnlDeposits"
        Me.tlpDeposits.SetRowSpan(Me.pnlDeposits, 3)
        Me.pnlDeposits.Size = New System.Drawing.Size(498, 127)
        Me.pnlDeposits.TabIndex = 7
        '
        'tlpScroller
        '
        Me.tlpScroller.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpScroller.AutoSize = True
        Me.tlpScroller.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpScroller.ColumnCount = 1
        Me.tlpScroller.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpScroller.Location = New System.Drawing.Point(0, 0)
        Me.tlpScroller.Name = "tlpScroller"
        Me.tlpScroller.RowCount = 1
        Me.tlpScroller.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpScroller.Size = New System.Drawing.Size(491, 0)
        Me.tlpScroller.TabIndex = 0
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(501, 3)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(112, 34)
        Me.btnAdd.TabIndex = 8
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(501, 43)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(112, 34)
        Me.btnRemove.TabIndex = 9
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 248)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 25)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Schedule:"
        '
        'cboAccount
        '
        Me.cboAccount.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboAccount.AutoSize = True
        Me.cboAccount.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cboAccount.Location = New System.Drawing.Point(93, 37)
        Me.cboAccount.Margin = New System.Windows.Forms.Padding(0)
        Me.cboAccount.Name = "cboAccount"
        Me.cboAccount.Size = New System.Drawing.Size(622, 41)
        Me.cboAccount.TabIndex = 10
        '
        'ctrlDue
        '
        Me.ctrlDue.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ctrlDue.AutoSize = True
        Me.ctrlDue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ctrlDue.Location = New System.Drawing.Point(96, 251)
        Me.ctrlDue.Name = "ctrlDue"
        Me.ctrlDue.Size = New System.Drawing.Size(616, 82)
        Me.ctrlDue.TabIndex = 11
        '
        'PaycheckEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tlpLayout)
        Me.Name = "PaycheckEditor"
        Me.Size = New System.Drawing.Size(715, 336)
        Me.tlpLayout.ResumeLayout(False)
        Me.tlpLayout.PerformLayout()
        CType(Me.numTotal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpDeposits.ResumeLayout(False)
        Me.pnlDeposits.ResumeLayout(False)
        Me.pnlDeposits.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpLayout As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents numTotal As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents pnlDeposits As Panel
    Friend WithEvents tlpScroller As TableLayoutPanel
    Friend WithEvents tlpDeposits As TableLayoutPanel
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents cboAccount As EntityDropDown
    Friend WithEvents ctrlDue As DueInfoEditor
End Class
