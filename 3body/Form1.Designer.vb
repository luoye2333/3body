<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
	Inherits System.Windows.Forms.Form

	'Form 重写 Dispose，以清理组件列表。
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

	'Windows 窗体设计器所必需的
	Private components As System.ComponentModel.IContainer

	'注意: 以下过程是 Windows 窗体设计器所必需的
	'可以使用 Windows 窗体设计器修改它。  
	'不要使用代码编辑器修改它。
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.b1 = New System.Windows.Forms.PictureBox()
		Me.b2 = New System.Windows.Forms.PictureBox()
		Me.Maintime = New System.Windows.Forms.Timer(Me.components)
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Button2 = New System.Windows.Forms.Button()
		CType(Me.b1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.b2, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'b1
		'
		Me.b1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.b1.Location = New System.Drawing.Point(145, 212)
		Me.b1.Name = "b1"
		Me.b1.Size = New System.Drawing.Size(10, 10)
		Me.b1.TabIndex = 0
		Me.b1.TabStop = False
		'
		'b2
		'
		Me.b2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.b2.Location = New System.Drawing.Point(294, 212)
		Me.b2.Name = "b2"
		Me.b2.Size = New System.Drawing.Size(10, 10)
		Me.b2.TabIndex = 1
		Me.b2.TabStop = False
		'
		'Maintime
		'
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(22, 98)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(75, 23)
		Me.Button1.TabIndex = 2
		Me.Button1.Text = "控制"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'Button2
		'
		Me.Button2.Location = New System.Drawing.Point(22, 172)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(75, 23)
		Me.Button2.TabIndex = 5
		Me.Button2.Text = "属性"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(475, 442)
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.b2)
		Me.Controls.Add(Me.b1)
		Me.Name = "Form1"
		Me.Text = "Form1"
		CType(Me.b1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.b2, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents b1 As PictureBox
	Friend WithEvents b2 As PictureBox
	Friend WithEvents Maintime As Timer
	Friend WithEvents Button1 As Button
	Friend WithEvents Button2 As Button
End Class
