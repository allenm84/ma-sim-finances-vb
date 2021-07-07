<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CollectionEditor
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
        Me.tlpItemSelector = New System.Windows.Forms.TableLayoutPanel()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.trvCollection = New System.Windows.Forms.TreeView()
        Me.pnlItemEditor = New System.Windows.Forms.Panel()
        Me.tlpLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpItemSelector.SuspendLayout()
        Me.tlpLayout.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpItemSelector
        '
        Me.tlpItemSelector.ColumnCount = 3
        Me.tlpItemSelector.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpItemSelector.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpItemSelector.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpItemSelector.Controls.Add(Me.btnAdd, 0, 1)
        Me.tlpItemSelector.Controls.Add(Me.btnRemove, 2, 1)
        Me.tlpItemSelector.Controls.Add(Me.trvCollection, 0, 0)
        Me.tlpItemSelector.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpItemSelector.Location = New System.Drawing.Point(3, 3)
        Me.tlpItemSelector.Name = "tlpItemSelector"
        Me.tlpItemSelector.RowCount = 2
        Me.tlpItemSelector.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpItemSelector.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpItemSelector.Size = New System.Drawing.Size(244, 482)
        Me.tlpItemSelector.TabIndex = 0
        '
        'btnAdd
        '
        Me.btnAdd.AutoSize = True
        Me.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAdd.Location = New System.Drawing.Point(3, 444)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(56, 35)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.AutoSize = True
        Me.btnRemove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnRemove.Location = New System.Drawing.Point(155, 444)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(86, 35)
        Me.btnRemove.TabIndex = 2
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'trvCollection
        '
        Me.tlpItemSelector.SetColumnSpan(Me.trvCollection, 3)
        Me.trvCollection.Dock = System.Windows.Forms.DockStyle.Fill
        Me.trvCollection.FullRowSelect = True
        Me.trvCollection.HideSelection = False
        Me.trvCollection.Location = New System.Drawing.Point(3, 3)
        Me.trvCollection.Name = "trvCollection"
        Me.trvCollection.ShowLines = False
        Me.trvCollection.ShowPlusMinus = False
        Me.trvCollection.ShowRootLines = False
        Me.trvCollection.Size = New System.Drawing.Size(238, 435)
        Me.trvCollection.TabIndex = 3
        '
        'pnlItemEditor
        '
        Me.pnlItemEditor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlItemEditor.Location = New System.Drawing.Point(250, 0)
        Me.pnlItemEditor.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlItemEditor.Name = "pnlItemEditor"
        Me.pnlItemEditor.Size = New System.Drawing.Size(363, 488)
        Me.pnlItemEditor.TabIndex = 0
        '
        'tlpLayout
        '
        Me.tlpLayout.ColumnCount = 2
        Me.tlpLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250.0!))
        Me.tlpLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpLayout.Controls.Add(Me.pnlItemEditor, 1, 0)
        Me.tlpLayout.Controls.Add(Me.tlpItemSelector, 0, 0)
        Me.tlpLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpLayout.Location = New System.Drawing.Point(0, 0)
        Me.tlpLayout.Name = "tlpLayout"
        Me.tlpLayout.RowCount = 1
        Me.tlpLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpLayout.Size = New System.Drawing.Size(613, 488)
        Me.tlpLayout.TabIndex = 1
        '
        'CollectionEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tlpLayout)
        Me.Name = "CollectionEditor"
        Me.Size = New System.Drawing.Size(613, 488)
        Me.tlpItemSelector.ResumeLayout(False)
        Me.tlpItemSelector.PerformLayout()
        Me.tlpLayout.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlpItemSelector As TableLayoutPanel
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents pnlItemEditor As Panel
    Friend WithEvents trvCollection As TreeView
    Friend WithEvents tlpLayout As TableLayoutPanel
End Class
