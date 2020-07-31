<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMore
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMore))
		Me.CboMore1 = New System.Windows.Forms.ComboBox()
		Me.LblMoreFileName = New System.Windows.Forms.Label()
		Me.BtnMoreClose = New System.Windows.Forms.Button()
		Me.txtMoreHash1 = New System.Windows.Forms.TextBox()
		Me.BtnMoreCompare1 = New System.Windows.Forms.Button()
		Me.TxtMoreCompare1 = New System.Windows.Forms.TextBox()
		Me.SuspendLayout()
		'
		'CboMore1
		'
		Me.CboMore1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.CboMore1.FormattingEnabled = True
		Me.CboMore1.Location = New System.Drawing.Point(52, 83)
		Me.CboMore1.Name = "CboMore1"
		Me.CboMore1.Size = New System.Drawing.Size(151, 21)
		Me.CboMore1.TabIndex = 0
		'
		'LblMoreFileName
		'
		Me.LblMoreFileName.AutoSize = True
		Me.LblMoreFileName.Location = New System.Drawing.Point(49, 42)
		Me.LblMoreFileName.Name = "LblMoreFileName"
		Me.LblMoreFileName.Size = New System.Drawing.Size(39, 13)
		Me.LblMoreFileName.TabIndex = 1
		Me.LblMoreFileName.Text = "Label1"
		'
		'BtnMoreClose
		'
		Me.BtnMoreClose.Location = New System.Drawing.Point(844, 223)
		Me.BtnMoreClose.Name = "BtnMoreClose"
		Me.BtnMoreClose.Size = New System.Drawing.Size(75, 23)
		Me.BtnMoreClose.TabIndex = 3
		Me.BtnMoreClose.Text = "Close"
		Me.BtnMoreClose.UseVisualStyleBackColor = True
		'
		'txtMoreHash1
		'
		Me.txtMoreHash1.BackColor = System.Drawing.SystemColors.Control
		Me.txtMoreHash1.Location = New System.Drawing.Point(209, 84)
		Me.txtMoreHash1.Name = "txtMoreHash1"
		Me.txtMoreHash1.ReadOnly = True
		Me.txtMoreHash1.Size = New System.Drawing.Size(710, 20)
		Me.txtMoreHash1.TabIndex = 4
		'
		'BtnMoreCompare1
		'
		Me.BtnMoreCompare1.Location = New System.Drawing.Point(52, 110)
		Me.BtnMoreCompare1.Name = "BtnMoreCompare1"
		Me.BtnMoreCompare1.Size = New System.Drawing.Size(151, 23)
		Me.BtnMoreCompare1.TabIndex = 5
		Me.BtnMoreCompare1.Text = "Compare"
		Me.BtnMoreCompare1.UseVisualStyleBackColor = True
		'
		'TxtMoreCompare1
		'
		Me.TxtMoreCompare1.AllowDrop = True
		Me.TxtMoreCompare1.Location = New System.Drawing.Point(209, 110)
		Me.TxtMoreCompare1.Name = "TxtMoreCompare1"
		Me.TxtMoreCompare1.Size = New System.Drawing.Size(710, 20)
		Me.TxtMoreCompare1.TabIndex = 6
		'
		'FrmMore
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(931, 258)
		Me.Controls.Add(Me.TxtMoreCompare1)
		Me.Controls.Add(Me.BtnMoreCompare1)
		Me.Controls.Add(Me.txtMoreHash1)
		Me.Controls.Add(Me.BtnMoreClose)
		Me.Controls.Add(Me.LblMoreFileName)
		Me.Controls.Add(Me.CboMore1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.Name = "FrmMore"
		Me.Text = "More"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents CboMore1 As ComboBox
	Friend WithEvents LblMoreFileName As Label
	Friend WithEvents BtnMoreClose As Button
	Friend WithEvents txtMoreHash1 As TextBox
	Friend WithEvents BtnMoreCompare1 As Button
	Friend WithEvents TxtMoreCompare1 As TextBox
End Class
