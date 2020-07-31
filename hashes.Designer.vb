<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmHashes
	Inherits System.Windows.Forms.Form

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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmHashes))
		Me.BtnMD5 = New System.Windows.Forms.Button()
		Me.BtnSHA256 = New System.Windows.Forms.Button()
		Me.BtnSHA512 = New System.Windows.Forms.Button()
		Me.TxtMD5 = New System.Windows.Forms.TextBox()
		Me.TxtSHA256 = New System.Windows.Forms.TextBox()
		Me.TxtSHA512 = New System.Windows.Forms.TextBox()
		Me.BtnCMD5 = New System.Windows.Forms.Button()
		Me.BtnCSHA256 = New System.Windows.Forms.Button()
		Me.BtnCSHA512 = New System.Windows.Forms.Button()
		Me.TxtCMD5 = New System.Windows.Forms.TextBox()
		Me.TxtCSHA256 = New System.Windows.Forms.TextBox()
		Me.TxtCSHA512 = New System.Windows.Forms.TextBox()
		Me.BtnBrowse = New System.Windows.Forms.Button()
		Me.BtnClose = New System.Windows.Forms.Button()
		Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
		Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.FIleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
		Me.MoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
		Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.TxtFileName = New System.Windows.Forms.TextBox()
		Me.MenuStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		'BtnMD5
		'
		Me.BtnMD5.Location = New System.Drawing.Point(15, 123)
		Me.BtnMD5.Name = "BtnMD5"
		Me.BtnMD5.Size = New System.Drawing.Size(163, 20)
		Me.BtnMD5.TabIndex = 2
		Me.BtnMD5.Text = "MD5"
		Me.BtnMD5.UseVisualStyleBackColor = True
		'
		'BtnSHA256
		'
		Me.BtnSHA256.Location = New System.Drawing.Point(15, 232)
		Me.BtnSHA256.Name = "BtnSHA256"
		Me.BtnSHA256.Size = New System.Drawing.Size(163, 20)
		Me.BtnSHA256.TabIndex = 6
		Me.BtnSHA256.Text = "SHA256"
		Me.BtnSHA256.UseVisualStyleBackColor = True
		'
		'BtnSHA512
		'
		Me.BtnSHA512.Location = New System.Drawing.Point(15, 343)
		Me.BtnSHA512.Name = "BtnSHA512"
		Me.BtnSHA512.Size = New System.Drawing.Size(163, 20)
		Me.BtnSHA512.TabIndex = 10
		Me.BtnSHA512.Text = "SHA512"
		Me.BtnSHA512.UseVisualStyleBackColor = True
		'
		'TxtMD5
		'
		Me.TxtMD5.Location = New System.Drawing.Point(197, 123)
		Me.TxtMD5.Name = "TxtMD5"
		Me.TxtMD5.ReadOnly = True
		Me.TxtMD5.Size = New System.Drawing.Size(757, 20)
		Me.TxtMD5.TabIndex = 3
		'
		'TxtSHA256
		'
		Me.TxtSHA256.Location = New System.Drawing.Point(197, 232)
		Me.TxtSHA256.Name = "TxtSHA256"
		Me.TxtSHA256.ReadOnly = True
		Me.TxtSHA256.Size = New System.Drawing.Size(757, 20)
		Me.TxtSHA256.TabIndex = 7
		'
		'TxtSHA512
		'
		Me.TxtSHA512.Location = New System.Drawing.Point(197, 343)
		Me.TxtSHA512.Name = "TxtSHA512"
		Me.TxtSHA512.ReadOnly = True
		Me.TxtSHA512.Size = New System.Drawing.Size(757, 20)
		Me.TxtSHA512.TabIndex = 11
		'
		'BtnCMD5
		'
		Me.BtnCMD5.Location = New System.Drawing.Point(15, 164)
		Me.BtnCMD5.Name = "BtnCMD5"
		Me.BtnCMD5.Size = New System.Drawing.Size(163, 22)
		Me.BtnCMD5.TabIndex = 4
		Me.BtnCMD5.Text = "Compare MD5"
		Me.BtnCMD5.UseVisualStyleBackColor = True
		'
		'BtnCSHA256
		'
		Me.BtnCSHA256.Location = New System.Drawing.Point(15, 272)
		Me.BtnCSHA256.Name = "BtnCSHA256"
		Me.BtnCSHA256.Size = New System.Drawing.Size(163, 22)
		Me.BtnCSHA256.TabIndex = 8
		Me.BtnCSHA256.Text = "Compare SHA256"
		Me.BtnCSHA256.UseVisualStyleBackColor = True
		'
		'BtnCSHA512
		'
		Me.BtnCSHA512.Location = New System.Drawing.Point(15, 380)
		Me.BtnCSHA512.Name = "BtnCSHA512"
		Me.BtnCSHA512.Size = New System.Drawing.Size(163, 20)
		Me.BtnCSHA512.TabIndex = 12
		Me.BtnCSHA512.Text = "Compare SHA512"
		Me.BtnCSHA512.UseVisualStyleBackColor = True
		'
		'TxtCMD5
		'
		Me.TxtCMD5.AllowDrop = True
		Me.TxtCMD5.BackColor = System.Drawing.SystemColors.Window
		Me.TxtCMD5.Location = New System.Drawing.Point(197, 164)
		Me.TxtCMD5.Name = "TxtCMD5"
		Me.TxtCMD5.Size = New System.Drawing.Size(757, 20)
		Me.TxtCMD5.TabIndex = 5
		'
		'TxtCSHA256
		'
		Me.TxtCSHA256.AllowDrop = True
		Me.TxtCSHA256.Location = New System.Drawing.Point(197, 274)
		Me.TxtCSHA256.Name = "TxtCSHA256"
		Me.TxtCSHA256.Size = New System.Drawing.Size(757, 20)
		Me.TxtCSHA256.TabIndex = 9
		'
		'TxtCSHA512
		'
		Me.TxtCSHA512.AllowDrop = True
		Me.TxtCSHA512.Location = New System.Drawing.Point(197, 380)
		Me.TxtCSHA512.Name = "TxtCSHA512"
		Me.TxtCSHA512.Size = New System.Drawing.Size(757, 20)
		Me.TxtCSHA512.TabIndex = 13
		'
		'BtnBrowse
		'
		Me.BtnBrowse.Location = New System.Drawing.Point(15, 58)
		Me.BtnBrowse.Name = "BtnBrowse"
		Me.BtnBrowse.Size = New System.Drawing.Size(163, 23)
		Me.BtnBrowse.TabIndex = 0
		Me.BtnBrowse.Text = "Browse for file..."
		Me.BtnBrowse.UseVisualStyleBackColor = True
		'
		'BtnClose
		'
		Me.BtnClose.Location = New System.Drawing.Point(879, 422)
		Me.BtnClose.Name = "BtnClose"
		Me.BtnClose.Size = New System.Drawing.Size(75, 23)
		Me.BtnClose.TabIndex = 14
		Me.BtnClose.Text = "Close"
		Me.BtnClose.UseVisualStyleBackColor = True
		'
		'MenuStrip1
		'
		Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FIleToolStripMenuItem, Me.HelpToolStripMenuItem})
		Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.MenuStrip1.Name = "MenuStrip1"
		Me.MenuStrip1.Size = New System.Drawing.Size(985, 24)
		Me.MenuStrip1.TabIndex = 14
		Me.MenuStrip1.Text = "MenuStrip1"
		'
		'FIleToolStripMenuItem
		'
		Me.FIleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.ResetToolStripMenuItem, Me.ToolStripMenuItem1, Me.MoreToolStripMenuItem, Me.ToolStripMenuItem2, Me.ExitToolStripMenuItem})
		Me.FIleToolStripMenuItem.Name = "FIleToolStripMenuItem"
		Me.FIleToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
		Me.FIleToolStripMenuItem.Text = "FIle"
		'
		'OpenToolStripMenuItem
		'
		Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
		Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
		Me.OpenToolStripMenuItem.Text = "Browse for file..."
		'
		'ResetToolStripMenuItem
		'
		Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
		Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
		Me.ResetToolStripMenuItem.Text = "Reset"
		'
		'ToolStripMenuItem1
		'
		Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
		Me.ToolStripMenuItem1.Size = New System.Drawing.Size(155, 6)
		'
		'MoreToolStripMenuItem
		'
		Me.MoreToolStripMenuItem.Name = "MoreToolStripMenuItem"
		Me.MoreToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
		Me.MoreToolStripMenuItem.Text = "More"
		'
		'ToolStripMenuItem2
		'
		Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
		Me.ToolStripMenuItem2.Size = New System.Drawing.Size(155, 6)
		'
		'ExitToolStripMenuItem
		'
		Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
		Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
		Me.ExitToolStripMenuItem.Text = "Exit"
		'
		'HelpToolStripMenuItem
		'
		Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
		Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
		Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
		Me.HelpToolStripMenuItem.Text = "Help"
		'
		'AboutToolStripMenuItem
		'
		Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
		Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
		Me.AboutToolStripMenuItem.Text = "About Hashes 4 Windows 10"
		'
		'TxtFileName
		'
		Me.TxtFileName.AllowDrop = True
		Me.TxtFileName.Location = New System.Drawing.Point(197, 61)
		Me.TxtFileName.Name = "TxtFileName"
		Me.TxtFileName.ReadOnly = True
		Me.TxtFileName.Size = New System.Drawing.Size(757, 20)
		Me.TxtFileName.TabIndex = 15
		Me.TxtFileName.WordWrap = False
		'
		'FrmHashes
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(985, 466)
		Me.Controls.Add(Me.TxtFileName)
		Me.Controls.Add(Me.BtnClose)
		Me.Controls.Add(Me.BtnBrowse)
		Me.Controls.Add(Me.TxtCSHA512)
		Me.Controls.Add(Me.TxtCSHA256)
		Me.Controls.Add(Me.TxtCMD5)
		Me.Controls.Add(Me.BtnCSHA512)
		Me.Controls.Add(Me.BtnCSHA256)
		Me.Controls.Add(Me.BtnCMD5)
		Me.Controls.Add(Me.TxtSHA512)
		Me.Controls.Add(Me.TxtSHA256)
		Me.Controls.Add(Me.TxtMD5)
		Me.Controls.Add(Me.BtnSHA512)
		Me.Controls.Add(Me.BtnSHA256)
		Me.Controls.Add(Me.BtnMD5)
		Me.Controls.Add(Me.MenuStrip1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.Name = "FrmHashes"
		Me.Text = "Hashes 4 Windows 10"
		Me.MenuStrip1.ResumeLayout(False)
		Me.MenuStrip1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents BtnMD5 As Button
	Friend WithEvents BtnSHA256 As Button
	Friend WithEvents BtnSHA512 As Button
	Friend WithEvents TxtMD5 As TextBox
	Friend WithEvents TxtSHA256 As TextBox
	Friend WithEvents TxtSHA512 As TextBox
	Friend WithEvents BtnCMD5 As Button
	Friend WithEvents BtnCSHA256 As Button
	Friend WithEvents BtnCSHA512 As Button
	Friend WithEvents TxtCMD5 As TextBox
	Friend WithEvents TxtCSHA256 As TextBox
	Friend WithEvents TxtCSHA512 As TextBox
	Friend WithEvents BtnBrowse As Button
	Friend WithEvents BtnClose As Button
	Friend WithEvents OpenFileDialog1 As OpenFileDialog
	Friend WithEvents MenuStrip1 As MenuStrip
	Friend WithEvents FIleToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents TxtFileName As TextBox
	Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
	Friend WithEvents ResetToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents MoreToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
End Class
