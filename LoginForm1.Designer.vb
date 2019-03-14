<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")>
Partial Class LoginForm1

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
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm1))
		Me.lbldate = New System.Windows.Forms.Label()
		Me.lbltime = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Button3 = New System.Windows.Forms.Button()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.txtpass = New System.Windows.Forms.TextBox()
		Me.txtusername = New System.Windows.Forms.TextBox()
		Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Button1 = New System.Windows.Forms.Button()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'lbldate
		'
		Me.lbldate.AutoSize = True
		Me.lbldate.Font = New System.Drawing.Font("Digital-7 Mono", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbldate.Location = New System.Drawing.Point(86, 286)
		Me.lbldate.Name = "lbldate"
		Me.lbldate.Size = New System.Drawing.Size(63, 20)
		Me.lbldate.TabIndex = 20
		Me.lbldate.Text = "Time :"
		'
		'lbltime
		'
		Me.lbltime.AutoSize = True
		Me.lbltime.Font = New System.Drawing.Font("Digital-7 Mono", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbltime.Location = New System.Drawing.Point(86, 263)
		Me.lbltime.Name = "lbltime"
		Me.lbltime.Size = New System.Drawing.Size(63, 20)
		Me.lbltime.TabIndex = 19
		Me.lbltime.Text = "Time :"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Digital-7 Mono", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(24, 286)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(63, 20)
		Me.Label4.TabIndex = 17
		Me.Label4.Text = "Date :"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Digital-7 Mono", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(24, 263)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(63, 20)
		Me.Label3.TabIndex = 18
		Me.Label3.Text = "Time :"
		'
		'Button3
		'
		Me.Button3.BackColor = System.Drawing.SystemColors.ButtonHighlight
		Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.DeepPink
		Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Pink
		Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Pink
		Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button3.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button3.ForeColor = System.Drawing.Color.DeepPink
		Me.Button3.Location = New System.Drawing.Point(190, 208)
		Me.Button3.Name = "Button3"
		Me.Button3.Size = New System.Drawing.Size(75, 27)
		Me.Button3.TabIndex = 16
		Me.Button3.Text = "Close"
		Me.Button3.UseVisualStyleBackColor = False
		'
		'Button2
		'
		Me.Button2.BackColor = System.Drawing.SystemColors.ButtonHighlight
		Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.DeepPink
		Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Pink
		Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Pink
		Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button2.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button2.ForeColor = System.Drawing.Color.DeepPink
		Me.Button2.Location = New System.Drawing.Point(109, 208)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(75, 27)
		Me.Button2.TabIndex = 15
		Me.Button2.Text = "Clear"
		Me.Button2.UseVisualStyleBackColor = False
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.ForeColor = System.Drawing.Color.DeepPink
		Me.Label2.Location = New System.Drawing.Point(25, 152)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(66, 16)
		Me.Label2.TabIndex = 11
		Me.Label2.Text = "Password :"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.DeepPink
		Me.Label1.Location = New System.Drawing.Point(25, 98)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(67, 16)
		Me.Label1.TabIndex = 12
		Me.Label1.Text = "Username :"
		'
		'txtpass
		'
		Me.txtpass.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtpass.Location = New System.Drawing.Point(28, 171)
		Me.txtpass.Name = "txtpass"
		Me.txtpass.Size = New System.Drawing.Size(234, 22)
		Me.txtpass.TabIndex = 13
		Me.txtpass.UseSystemPasswordChar = True
		'
		'txtusername
		'
		Me.txtusername.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtusername.Location = New System.Drawing.Point(28, 117)
		Me.txtusername.Name = "txtusername"
		Me.txtusername.Size = New System.Drawing.Size(234, 22)
		Me.txtusername.TabIndex = 10
		'
		'Timer1
		'
		'
		'PictureBox1
		'
		Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
		Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
		Me.PictureBox1.Location = New System.Drawing.Point(285, 101)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(188, 205)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.PictureBox1.TabIndex = 21
		Me.PictureBox1.TabStop = False
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Hobo Std", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(134, 50)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(242, 34)
		Me.Label5.TabIndex = 22
		Me.Label5.Text = "CV. PASIFIC INDAH"
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'Button1
		'
		Me.Button1.BackColor = System.Drawing.SystemColors.ButtonHighlight
		Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.DeepPink
		Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Pink
		Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Pink
		Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button1.ForeColor = System.Drawing.Color.DeepPink
		Me.Button1.Location = New System.Drawing.Point(28, 208)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(75, 27)
		Me.Button1.TabIndex = 14
		Me.Button1.Text = "&Login"
		Me.Button1.UseVisualStyleBackColor = False
		'
		'LoginForm1
		'
		Me.AcceptButton = Me.Button1
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(487, 329)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.lbldate)
		Me.Controls.Add(Me.lbltime)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Button3)
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.txtpass)
		Me.Controls.Add(Me.txtusername)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.PictureBox1)
		Me.ForeColor = System.Drawing.Color.DeepPink
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "LoginForm1"
		Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
		Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
		Me.Style = MetroFramework.MetroColorStyle.Magenta
		Me.Text = "Login"
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents lbldate As Label
	Friend WithEvents lbltime As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Button3 As Button
	Friend WithEvents Button2 As Button
	Friend WithEvents Label2 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents txtpass As TextBox
	Friend WithEvents txtusername As TextBox
	Friend WithEvents Timer1 As Timer
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents Label5 As Label
	Friend WithEvents Button1 As Button
End Class
