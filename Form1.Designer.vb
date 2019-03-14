<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1

	'Using Metro Framework
	Inherits MetroFramework.Forms.MetroForm

	'Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
		Me.Label1 = New System.Windows.Forms.Label()
		Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
		Me.ts_Transaction = New System.Windows.Forms.ToolStripButton()
		Me.ts_StockMaster = New System.Windows.Forms.ToolStripButton()
		Me.ts_Customer = New System.Windows.Forms.ToolStripButton()
		Me.ts_ManageUser = New System.Windows.Forms.ToolStripButton()
		Me.ts_Setting = New System.Windows.Forms.ToolStripButton()
		Me.ts_Report = New System.Windows.Forms.ToolStripButton()
		Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
		Me.ts_Login = New System.Windows.Forms.ToolStripButton()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.ToolStrip1.SuspendLayout()
		Me.Panel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.BackColor = System.Drawing.Color.DeepPink
		Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
		Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Label1.Font = New System.Drawing.Font("Hobo Std", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.White
		Me.Label1.Location = New System.Drawing.Point(20, 60)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(802, 109)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Inventory Management System" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CV. PASIFIC INDAH"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'ToolStrip1
		'
		Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
		Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(30, 30)
		Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ts_Transaction, Me.ts_StockMaster, Me.ts_Customer, Me.ts_ManageUser, Me.ts_Setting, Me.ts_Report, Me.ToolStripSeparator1, Me.ts_Login})
		Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
		Me.ToolStrip1.Name = "ToolStrip1"
		Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0)
		Me.ToolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ToolStrip1.Size = New System.Drawing.Size(802, 52)
		Me.ToolStrip1.Stretch = True
		Me.ToolStrip1.TabIndex = 1
		Me.ToolStrip1.Text = "ToolStrip1"
		'
		'ts_Transaction
		'
		Me.ts_Transaction.BackColor = System.Drawing.Color.Cyan
		Me.ts_Transaction.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ts_Transaction.Image = CType(resources.GetObject("ts_Transaction.Image"), System.Drawing.Image)
		Me.ts_Transaction.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.ts_Transaction.Name = "ts_Transaction"
		Me.ts_Transaction.Size = New System.Drawing.Size(98, 49)
		Me.ts_Transaction.Text = "TRANSACTIONS"
		Me.ts_Transaction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		'
		'ts_StockMaster
		'
		Me.ts_StockMaster.BackColor = System.Drawing.Color.DeepSkyBlue
		Me.ts_StockMaster.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ts_StockMaster.Image = CType(resources.GetObject("ts_StockMaster.Image"), System.Drawing.Image)
		Me.ts_StockMaster.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.ts_StockMaster.Name = "ts_StockMaster"
		Me.ts_StockMaster.Size = New System.Drawing.Size(102, 49)
		Me.ts_StockMaster.Text = "STOCK MASTERS"
		Me.ts_StockMaster.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		'
		'ts_Customer
		'
		Me.ts_Customer.BackColor = System.Drawing.Color.Cyan
		Me.ts_Customer.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ts_Customer.Image = CType(resources.GetObject("ts_Customer.Image"), System.Drawing.Image)
		Me.ts_Customer.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.ts_Customer.Name = "ts_Customer"
		Me.ts_Customer.Size = New System.Drawing.Size(78, 49)
		Me.ts_Customer.Text = "CUSTOMERS"
		Me.ts_Customer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		'
		'ts_ManageUser
		'
		Me.ts_ManageUser.BackColor = System.Drawing.Color.DeepSkyBlue
		Me.ts_ManageUser.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ts_ManageUser.Image = CType(resources.GetObject("ts_ManageUser.Image"), System.Drawing.Image)
		Me.ts_ManageUser.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.ts_ManageUser.Name = "ts_ManageUser"
		Me.ts_ManageUser.Size = New System.Drawing.Size(96, 49)
		Me.ts_ManageUser.Text = "MANAGE USERS"
		Me.ts_ManageUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		'
		'ts_Setting
		'
		Me.ts_Setting.BackColor = System.Drawing.Color.Cyan
		Me.ts_Setting.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ts_Setting.Image = CType(resources.GetObject("ts_Setting.Image"), System.Drawing.Image)
		Me.ts_Setting.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.ts_Setting.Name = "ts_Setting"
		Me.ts_Setting.Size = New System.Drawing.Size(63, 49)
		Me.ts_Setting.Text = "SETTINGS"
		Me.ts_Setting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		'
		'ts_Report
		'
		Me.ts_Report.BackColor = System.Drawing.Color.DeepSkyBlue
		Me.ts_Report.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ts_Report.Image = CType(resources.GetObject("ts_Report.Image"), System.Drawing.Image)
		Me.ts_Report.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.ts_Report.Name = "ts_Report"
		Me.ts_Report.Size = New System.Drawing.Size(60, 49)
		Me.ts_Report.Text = "REPORTS"
		Me.ts_Report.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.ts_Report.ToolTipText = "REPORTS"
		'
		'ToolStripSeparator1
		'
		Me.ToolStripSeparator1.BackColor = System.Drawing.SystemColors.WindowText
		Me.ToolStripSeparator1.ForeColor = System.Drawing.Color.Black
		Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
		Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 52)
		'
		'ts_Login
		'
		Me.ts_Login.BackColor = System.Drawing.Color.Cyan
		Me.ts_Login.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ts_Login.Image = CType(resources.GetObject("ts_Login.Image"), System.Drawing.Image)
		Me.ts_Login.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.ts_Login.Name = "ts_Login"
		Me.ts_Login.Size = New System.Drawing.Size(46, 49)
		Me.ts_Login.Text = "LOGIN"
		Me.ts_Login.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		'
		'Panel1
		'
		Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Panel1.BackColor = System.Drawing.Color.Transparent
		Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
		Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.Panel1.Controls.Add(Me.ToolStrip1)
		Me.Panel1.ForeColor = System.Drawing.SystemColors.MenuText
		Me.Panel1.Location = New System.Drawing.Point(20, 169)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(802, 416)
		Me.Panel1.TabIndex = 2
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(842, 568)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.Panel1)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "Form1"
		Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
		Me.Style = MetroFramework.MetroColorStyle.Magenta
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		Me.ToolStrip1.ResumeLayout(False)
		Me.ToolStrip1.PerformLayout()
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents ToolStrip1 As ToolStrip
	Friend WithEvents ts_Transaction As ToolStripButton
	Friend WithEvents ts_StockMaster As ToolStripButton
	Friend WithEvents ts_Customer As ToolStripButton
	Friend WithEvents ts_ManageUser As ToolStripButton
	Friend WithEvents ts_Setting As ToolStripButton
	Friend WithEvents ts_Report As ToolStripButton
	Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
	Friend WithEvents ts_Login As ToolStripButton
	Friend WithEvents Panel1 As Panel
End Class
