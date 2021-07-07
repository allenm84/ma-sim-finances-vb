<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdjustSnowballAmountEventEditor
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.numAmount = New System.Windows.Forms.NumericUpDown()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tlpLayout.SuspendLayout()
        CType(Me.numAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlpLayout
        '
        Me.tlpLayout.ColumnCount = 2
        Me.tlpLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpLayout.Controls.Add(Me.Label1, 0, 1)
        Me.tlpLayout.Controls.Add(Me.txtName, 1, 1)
        Me.tlpLayout.Controls.Add(Me.Label3, 0, 2)
        Me.tlpLayout.Controls.Add(Me.Label4, 0, 3)
        Me.tlpLayout.Controls.Add(Me.numAmount, 1, 3)
        Me.tlpLayout.Controls.Add(Me.dtpDate, 1, 2)
        Me.tlpLayout.Controls.Add(Me.Label2, 0, 0)
        Me.tlpLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpLayout.Location = New System.Drawing.Point(0, 0)
        Me.tlpLayout.Name = "tlpLayout"
        Me.tlpLayout.RowCount = 5
        Me.tlpLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpLayout.Size = New System.Drawing.Size(701, 421)
        Me.tlpLayout.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name:"
        '
        'txtName
        '
        Me.txtName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtName.Location = New System.Drawing.Point(90, 40)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(608, 31)
        Me.txtName.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Date:"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Amount:"
        '
        'numAmount
        '
        Me.numAmount.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numAmount.DecimalPlaces = 2
        Me.numAmount.Location = New System.Drawing.Point(90, 114)
        Me.numAmount.Name = "numAmount"
        Me.numAmount.Size = New System.Drawing.Size(608, 31)
        Me.numAmount.TabIndex = 7
        '
        'dtpDate
        '
        Me.dtpDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(90, 77)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(608, 31)
        Me.dtpDate.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.tlpLayout.SetColumnSpan(Me.Label2, 2)
        Me.Label2.Location = New System.Drawing.Point(6, 6)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(210, 25)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Adjust Snowball Amount"
        '
        'AdjustSnowballAmountEventEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tlpLayout)
        Me.Name = "AdjustSnowballAmountEventEditor"
        Me.Size = New System.Drawing.Size(701, 421)
        Me.tlpLayout.ResumeLayout(False)
        Me.tlpLayout.PerformLayout()
        CType(Me.numAmount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpLayout As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents numAmount As NumericUpDown
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents Label2 As Label
End Class
