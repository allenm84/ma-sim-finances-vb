<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
  Inherits System.Windows.Forms.Form

  'Form overrides dispose to clean up the component list.
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
    Me.tsMain = New System.Windows.Forms.ToolStrip()
    Me.tbbSave = New System.Windows.Forms.ToolStripButton()
    Me.tbsSeparator1 = New System.Windows.Forms.ToolStripSeparator()
    Me.tbbNew = New System.Windows.Forms.ToolStripButton()
    Me.tbbClone = New System.Windows.Forms.ToolStripButton()
    Me.tbbRemove = New System.Windows.Forms.ToolStripButton()
    Me.tbbExport = New System.Windows.Forms.ToolStripButton()
    Me.tbsSeparator2 = New System.Windows.Forms.ToolStripSeparator()
    Me.tbbRun = New System.Windows.Forms.ToolStripButton()
    Me.tbsSeparator3 = New System.Windows.Forms.ToolStripSeparator()
    Me.tbbSchedule = New System.Windows.Forms.ToolStripButton()
    Me.tlpMainLayout = New System.Windows.Forms.TableLayoutPanel()
    Me.lbProfiles = New System.Windows.Forms.Label()
    Me.cboProfiles = New System.Windows.Forms.ComboBox()
    Me.grpSelectedProfile = New System.Windows.Forms.GroupBox()
    Me.tlpProfileData = New System.Windows.Forms.TableLayoutPanel()
    Me.lblProfileName = New System.Windows.Forms.Label()
    Me.txtProfileName = New System.Windows.Forms.TextBox()
    Me.tcData = New System.Windows.Forms.TabControl()
    Me.tcpAccounts = New System.Windows.Forms.TabPage()
        Me.cleAccounts = New FinanceSim.CollectionEditor()
        Me.tcpPaychecks = New System.Windows.Forms.TabPage()
        Me.clePaychecks = New FinanceSim.CollectionEditor()
        Me.tcpBills = New System.Windows.Forms.TabPage()
        Me.cleBills = New FinanceSim.CollectionEditor()
        Me.tcpDebts = New System.Windows.Forms.TabPage()
        Me.cleDebts = New FinanceSim.CollectionEditor()
        Me.tcpTransactions = New System.Windows.Forms.TabPage()
        Me.cleTransactions = New FinanceSim.CollectionEditor()
        Me.tcpEvents = New System.Windows.Forms.TabPage()
        Me.cleEvents = New FinanceSim.CollectionEditor()
        Me.tcpSnowball = New System.Windows.Forms.TabPage()
        Me.ctrlSnowballSetup = New FinanceSim.SnowballSetupEditor()
        Me.pgbStatus = New System.Windows.Forms.ProgressBar()
        Me.tsMain.SuspendLayout()
        Me.tlpMainLayout.SuspendLayout()
        Me.grpSelectedProfile.SuspendLayout()
        Me.tlpProfileData.SuspendLayout()
        Me.tcData.SuspendLayout()
        Me.tcpAccounts.SuspendLayout()
        Me.tcpPaychecks.SuspendLayout()
        Me.tcpBills.SuspendLayout()
        Me.tcpDebts.SuspendLayout()
        Me.tcpTransactions.SuspendLayout()
        Me.tcpEvents.SuspendLayout()
        Me.tcpSnowball.SuspendLayout()
        Me.SuspendLayout()
        '
        'tsMain
        '
        Me.tsMain.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.tsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tbbSave, Me.tbsSeparator1, Me.tbbNew, Me.tbbClone, Me.tbbRemove, Me.tbbExport, Me.tbsSeparator2, Me.tbbRun, Me.tbsSeparator3, Me.tbbSchedule})
        Me.tsMain.Location = New System.Drawing.Point(0, 0)
        Me.tsMain.Name = "tsMain"
        Me.tsMain.Size = New System.Drawing.Size(1124, 34)
        Me.tsMain.TabIndex = 0
        Me.tsMain.Text = "ToolStrip1"
        '
        'tbbSave
        '
        Me.tbbSave.Image = Global.FinanceSim.My.Resources.Resources.Save
        Me.tbbSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbbSave.Name = "tbbSave"
        Me.tbbSave.Size = New System.Drawing.Size(77, 29)
        Me.tbbSave.Text = "Save"
        '
        'tbsSeparator1
        '
        Me.tbsSeparator1.Name = "tbsSeparator1"
        Me.tbsSeparator1.Size = New System.Drawing.Size(6, 34)
        '
        'tbbNew
        '
        Me.tbbNew.Image = Global.FinanceSim.My.Resources.Resources.NewProfile
        Me.tbbNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbbNew.Name = "tbbNew"
        Me.tbbNew.Size = New System.Drawing.Size(75, 29)
        Me.tbbNew.Text = "New"
        '
        'tbbClone
        '
        Me.tbbClone.Image = Global.FinanceSim.My.Resources.Resources.CloneProfile
        Me.tbbClone.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbbClone.Name = "tbbClone"
        Me.tbbClone.Size = New System.Drawing.Size(85, 29)
        Me.tbbClone.Text = "Clone"
        '
        'tbbRemove
        '
        Me.tbbRemove.Image = Global.FinanceSim.My.Resources.Resources.RemoveProfile
        Me.tbbRemove.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbbRemove.Name = "tbbRemove"
        Me.tbbRemove.Size = New System.Drawing.Size(104, 29)
        Me.tbbRemove.Text = "Remove"
        '
        'tbbExport
        '
        Me.tbbExport.Image = Global.FinanceSim.My.Resources.Resources.ExportProfile
        Me.tbbExport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbbExport.Name = "tbbExport"
        Me.tbbExport.Size = New System.Drawing.Size(91, 29)
        Me.tbbExport.Text = "Export"
        '
        'tbsSeparator2
        '
        Me.tbsSeparator2.Name = "tbsSeparator2"
        Me.tbsSeparator2.Size = New System.Drawing.Size(6, 34)
        '
        'tbbRun
        '
        Me.tbbRun.Image = Global.FinanceSim.My.Resources.Resources.Run
        Me.tbbRun.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbbRun.Name = "tbbRun"
        Me.tbbRun.Size = New System.Drawing.Size(71, 29)
        Me.tbbRun.Text = "Run"
        '
        'tbsSeparator3
        '
        Me.tbsSeparator3.Name = "tbsSeparator3"
        Me.tbsSeparator3.Size = New System.Drawing.Size(6, 34)
        '
        'tbbSchedule
        '
        Me.tbbSchedule.Image = Global.FinanceSim.My.Resources.Resources.Schedule
        Me.tbbSchedule.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbbSchedule.Name = "tbbSchedule"
        Me.tbbSchedule.Size = New System.Drawing.Size(111, 29)
        Me.tbbSchedule.Text = "Schedule"
        '
        'tlpMainLayout
        '
        Me.tlpMainLayout.ColumnCount = 2
        Me.tlpMainLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMainLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMainLayout.Controls.Add(Me.lbProfiles, 0, 0)
        Me.tlpMainLayout.Controls.Add(Me.cboProfiles, 1, 0)
        Me.tlpMainLayout.Controls.Add(Me.grpSelectedProfile, 0, 1)
        Me.tlpMainLayout.Controls.Add(Me.pgbStatus, 0, 2)
        Me.tlpMainLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMainLayout.Location = New System.Drawing.Point(0, 34)
        Me.tlpMainLayout.Name = "tlpMainLayout"
        Me.tlpMainLayout.RowCount = 3
        Me.tlpMainLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMainLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMainLayout.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMainLayout.Size = New System.Drawing.Size(1124, 610)
        Me.tlpMainLayout.TabIndex = 1
        '
        'lbProfiles
        '
        Me.lbProfiles.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lbProfiles.AutoSize = True
        Me.lbProfiles.Location = New System.Drawing.Point(3, 7)
        Me.lbProfiles.Name = "lbProfiles"
        Me.lbProfiles.Size = New System.Drawing.Size(74, 25)
        Me.lbProfiles.TabIndex = 0
        Me.lbProfiles.Text = "Profiles:"
        '
        'cboProfiles
        '
        Me.cboProfiles.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboProfiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProfiles.FormattingEnabled = True
        Me.cboProfiles.Location = New System.Drawing.Point(83, 3)
        Me.cboProfiles.Name = "cboProfiles"
        Me.cboProfiles.Size = New System.Drawing.Size(1038, 33)
        Me.cboProfiles.TabIndex = 1
        '
        'grpSelectedProfile
        '
        Me.tlpMainLayout.SetColumnSpan(Me.grpSelectedProfile, 2)
        Me.grpSelectedProfile.Controls.Add(Me.tlpProfileData)
        Me.grpSelectedProfile.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpSelectedProfile.Location = New System.Drawing.Point(3, 42)
        Me.grpSelectedProfile.Name = "grpSelectedProfile"
        Me.grpSelectedProfile.Size = New System.Drawing.Size(1118, 525)
        Me.grpSelectedProfile.TabIndex = 2
        Me.grpSelectedProfile.TabStop = False
        Me.grpSelectedProfile.Text = "Data"
        '
        'tlpProfileData
        '
        Me.tlpProfileData.ColumnCount = 2
        Me.tlpProfileData.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpProfileData.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpProfileData.Controls.Add(Me.lblProfileName, 0, 0)
        Me.tlpProfileData.Controls.Add(Me.txtProfileName, 1, 0)
        Me.tlpProfileData.Controls.Add(Me.tcData, 0, 1)
        Me.tlpProfileData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpProfileData.Location = New System.Drawing.Point(3, 27)
        Me.tlpProfileData.Name = "tlpProfileData"
        Me.tlpProfileData.RowCount = 2
        Me.tlpProfileData.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpProfileData.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpProfileData.Size = New System.Drawing.Size(1112, 495)
        Me.tlpProfileData.TabIndex = 0
        '
        'lblProfileName
        '
        Me.lblProfileName.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblProfileName.AutoSize = True
        Me.lblProfileName.Location = New System.Drawing.Point(3, 6)
        Me.lblProfileName.Name = "lblProfileName"
        Me.lblProfileName.Size = New System.Drawing.Size(63, 25)
        Me.lblProfileName.TabIndex = 0
        Me.lblProfileName.Text = "Name:"
        '
        'txtProfileName
        '
        Me.txtProfileName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtProfileName.Location = New System.Drawing.Point(72, 3)
        Me.txtProfileName.Name = "txtProfileName"
        Me.txtProfileName.Size = New System.Drawing.Size(1037, 31)
        Me.txtProfileName.TabIndex = 1
        '
        'tcData
        '
        Me.tlpProfileData.SetColumnSpan(Me.tcData, 2)
        Me.tcData.Controls.Add(Me.tcpAccounts)
        Me.tcData.Controls.Add(Me.tcpPaychecks)
        Me.tcData.Controls.Add(Me.tcpBills)
        Me.tcData.Controls.Add(Me.tcpDebts)
        Me.tcData.Controls.Add(Me.tcpTransactions)
        Me.tcData.Controls.Add(Me.tcpEvents)
        Me.tcData.Controls.Add(Me.tcpSnowball)
        Me.tcData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcData.Location = New System.Drawing.Point(3, 40)
        Me.tcData.Name = "tcData"
        Me.tcData.SelectedIndex = 0
        Me.tcData.Size = New System.Drawing.Size(1106, 452)
        Me.tcData.TabIndex = 2
        '
        'tcpAccounts
        '
        Me.tcpAccounts.Controls.Add(Me.cleAccounts)
        Me.tcpAccounts.Location = New System.Drawing.Point(4, 34)
        Me.tcpAccounts.Name = "tcpAccounts"
        Me.tcpAccounts.Padding = New System.Windows.Forms.Padding(3)
        Me.tcpAccounts.Size = New System.Drawing.Size(1098, 414)
        Me.tcpAccounts.TabIndex = 0
        Me.tcpAccounts.Text = "Accounts"
        Me.tcpAccounts.UseVisualStyleBackColor = True
        '
        'cleAccounts
        '
        Me.cleAccounts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cleAccounts.Location = New System.Drawing.Point(3, 3)
        Me.cleAccounts.Name = "cleAccounts"
        Me.cleAccounts.Size = New System.Drawing.Size(1092, 408)
        Me.cleAccounts.TabIndex = 0
        '
        'tcpPaychecks
        '
        Me.tcpPaychecks.Controls.Add(Me.clePaychecks)
        Me.tcpPaychecks.Location = New System.Drawing.Point(4, 34)
        Me.tcpPaychecks.Name = "tcpPaychecks"
        Me.tcpPaychecks.Padding = New System.Windows.Forms.Padding(3)
        Me.tcpPaychecks.Size = New System.Drawing.Size(1098, 414)
        Me.tcpPaychecks.TabIndex = 1
        Me.tcpPaychecks.Text = "Paychecks"
        Me.tcpPaychecks.UseVisualStyleBackColor = True
        '
        'clePaychecks
        '
        Me.clePaychecks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.clePaychecks.Location = New System.Drawing.Point(3, 3)
        Me.clePaychecks.Name = "clePaychecks"
        Me.clePaychecks.Size = New System.Drawing.Size(1092, 408)
        Me.clePaychecks.TabIndex = 0
        '
        'tcpBills
        '
        Me.tcpBills.Controls.Add(Me.cleBills)
        Me.tcpBills.Location = New System.Drawing.Point(4, 34)
        Me.tcpBills.Name = "tcpBills"
        Me.tcpBills.Padding = New System.Windows.Forms.Padding(3)
        Me.tcpBills.Size = New System.Drawing.Size(1098, 414)
        Me.tcpBills.TabIndex = 2
        Me.tcpBills.Text = "Bills"
        Me.tcpBills.UseVisualStyleBackColor = True
        '
        'cleBills
        '
        Me.cleBills.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cleBills.Location = New System.Drawing.Point(3, 3)
        Me.cleBills.Name = "cleBills"
        Me.cleBills.Size = New System.Drawing.Size(1092, 408)
        Me.cleBills.TabIndex = 0
        '
        'tcpDebts
        '
        Me.tcpDebts.Controls.Add(Me.cleDebts)
        Me.tcpDebts.Location = New System.Drawing.Point(4, 34)
        Me.tcpDebts.Name = "tcpDebts"
        Me.tcpDebts.Padding = New System.Windows.Forms.Padding(3)
        Me.tcpDebts.Size = New System.Drawing.Size(1098, 414)
        Me.tcpDebts.TabIndex = 3
        Me.tcpDebts.Text = "Debts"
        Me.tcpDebts.UseVisualStyleBackColor = True
        '
        'cleDebts
        '
        Me.cleDebts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cleDebts.Location = New System.Drawing.Point(3, 3)
        Me.cleDebts.Name = "cleDebts"
        Me.cleDebts.Size = New System.Drawing.Size(1092, 408)
        Me.cleDebts.TabIndex = 0
        '
        'tcpTransactions
        '
        Me.tcpTransactions.Controls.Add(Me.cleTransactions)
        Me.tcpTransactions.Location = New System.Drawing.Point(4, 34)
        Me.tcpTransactions.Name = "tcpTransactions"
        Me.tcpTransactions.Padding = New System.Windows.Forms.Padding(3)
        Me.tcpTransactions.Size = New System.Drawing.Size(1098, 414)
        Me.tcpTransactions.TabIndex = 4
        Me.tcpTransactions.Text = "Transactions"
        Me.tcpTransactions.UseVisualStyleBackColor = True
        '
        'cleTransactions
        '
        Me.cleTransactions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cleTransactions.Location = New System.Drawing.Point(3, 3)
        Me.cleTransactions.Name = "cleTransactions"
        Me.cleTransactions.Size = New System.Drawing.Size(1092, 408)
        Me.cleTransactions.TabIndex = 0
        '
        'tcpEvents
        '
        Me.tcpEvents.Controls.Add(Me.cleEvents)
        Me.tcpEvents.Location = New System.Drawing.Point(4, 34)
        Me.tcpEvents.Name = "tcpEvents"
        Me.tcpEvents.Padding = New System.Windows.Forms.Padding(3)
        Me.tcpEvents.Size = New System.Drawing.Size(1098, 414)
        Me.tcpEvents.TabIndex = 5
        Me.tcpEvents.Text = "Events"
        Me.tcpEvents.UseVisualStyleBackColor = True
        '
        'cleEvents
        '
        Me.cleEvents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cleEvents.Location = New System.Drawing.Point(3, 3)
        Me.cleEvents.Name = "cleEvents"
        Me.cleEvents.Size = New System.Drawing.Size(1092, 408)
        Me.cleEvents.TabIndex = 0
        '
        'tcpSnowball
        '
        Me.tcpSnowball.Controls.Add(Me.ctrlSnowballSetup)
        Me.tcpSnowball.Location = New System.Drawing.Point(4, 34)
        Me.tcpSnowball.Name = "tcpSnowball"
        Me.tcpSnowball.Padding = New System.Windows.Forms.Padding(3)
        Me.tcpSnowball.Size = New System.Drawing.Size(1098, 414)
        Me.tcpSnowball.TabIndex = 6
        Me.tcpSnowball.Text = "Snowball"
        Me.tcpSnowball.UseVisualStyleBackColor = True
        '
        'ctrlSnowballSetup
        '
        Me.ctrlSnowballSetup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ctrlSnowballSetup.Location = New System.Drawing.Point(3, 3)
        Me.ctrlSnowballSetup.Name = "ctrlSnowballSetup"
        Me.ctrlSnowballSetup.Size = New System.Drawing.Size(1092, 408)
        Me.ctrlSnowballSetup.TabIndex = 0
        '
        'pgbStatus
        '
        Me.tlpMainLayout.SetColumnSpan(Me.pgbStatus, 2)
        Me.pgbStatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pgbStatus.Location = New System.Drawing.Point(3, 573)
        Me.pgbStatus.Name = "pgbStatus"
        Me.pgbStatus.Size = New System.Drawing.Size(1118, 34)
        Me.pgbStatus.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.pgbStatus.TabIndex = 3
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1124, 644)
        Me.Controls.Add(Me.tlpMainLayout)
        Me.Controls.Add(Me.tsMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Finance Sim"
        Me.tsMain.ResumeLayout(False)
        Me.tsMain.PerformLayout()
        Me.tlpMainLayout.ResumeLayout(False)
        Me.tlpMainLayout.PerformLayout()
        Me.grpSelectedProfile.ResumeLayout(False)
        Me.tlpProfileData.ResumeLayout(False)
        Me.tlpProfileData.PerformLayout()
        Me.tcData.ResumeLayout(False)
        Me.tcpAccounts.ResumeLayout(False)
        Me.tcpPaychecks.ResumeLayout(False)
        Me.tcpBills.ResumeLayout(False)
        Me.tcpDebts.ResumeLayout(False)
        Me.tcpTransactions.ResumeLayout(False)
        Me.tcpEvents.ResumeLayout(False)
        Me.tcpSnowball.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tsMain As ToolStrip
    Friend WithEvents tbbSave As ToolStripButton
    Friend WithEvents tbsSeparator1 As ToolStripSeparator
    Friend WithEvents tbbNew As ToolStripButton
    Friend WithEvents tbbClone As ToolStripButton
    Friend WithEvents tbbRemove As ToolStripButton
    Friend WithEvents tbbExport As ToolStripButton
    Friend WithEvents tbsSeparator2 As ToolStripSeparator
    Friend WithEvents tbbRun As ToolStripButton
    Friend WithEvents tbsSeparator3 As ToolStripSeparator
    Friend WithEvents tbbSchedule As ToolStripButton
    Friend WithEvents tlpMainLayout As TableLayoutPanel
    Friend WithEvents lbProfiles As Label
    Friend WithEvents cboProfiles As ComboBox
    Friend WithEvents grpSelectedProfile As GroupBox
    Friend WithEvents tlpProfileData As TableLayoutPanel
    Friend WithEvents lblProfileName As Label
    Friend WithEvents txtProfileName As TextBox
    Friend WithEvents tcData As TabControl
    Friend WithEvents tcpAccounts As TabPage
    Friend WithEvents tcpPaychecks As TabPage
    Friend WithEvents tcpBills As TabPage
    Friend WithEvents tcpDebts As TabPage
    Friend WithEvents tcpTransactions As TabPage
    Friend WithEvents tcpEvents As TabPage
    Friend WithEvents tcpSnowball As TabPage
    Friend WithEvents pgbStatus As ProgressBar
    Friend WithEvents cleAccounts As CollectionEditor
    Friend WithEvents clePaychecks As CollectionEditor
    Friend WithEvents cleBills As CollectionEditor
    Friend WithEvents cleDebts As CollectionEditor
    Friend WithEvents cleTransactions As CollectionEditor
    Friend WithEvents cleEvents As CollectionEditor
    Friend WithEvents ctrlSnowballSetup As SnowballSetupEditor
End Class
