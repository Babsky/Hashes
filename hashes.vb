Public Class FrmHashes

	Public vGFileName As String 'Global filename variable
	Private vFileName As String  'filename variable
	Private vstrMD5 As String    'Calculated MD5
	Private vstrCMD5 As String   'MD5 to compare to
	Private vstrSHA256 As String 'Calculated SHA256
	Private vstrCSHA256 As String    'SHA256 to compare to
	Private vstrSHA512 As String 'Calculated SHA512
	Private vstrCSHA512 As String   'SHA512 to compare to
	Private ReadOnly vClsHash As New ClsHash

	Private Sub FrmHashes_Load(sender As Object, e As EventArgs) Handles Me.Load

		Reset_Form()

	End Sub

	Private Sub Reset_Form()
		'Set var defaults
		vGFileName = ""
		vFileName = ""
		vstrMD5 = ""
		vstrCMD5 = TxtCMD5.Text
		vstrSHA256 = ""
		vstrCSHA256 = TxtCSHA256.Text
		vstrSHA512 = ""
		vstrCSHA512 = TxtCSHA512.Text

		'Set textbox text
		Reset_Filename()
		Reset_Hashes()
		Reset_Compare()

		'Disable hash buttons
		BtnMD5.Enabled = False
		BtnSHA256.Enabled = False
		BtnSHA512.Enabled = False

		'Disable compare buttons
		BtnCMD5.Enabled = False
		BtnCSHA256.Enabled = False
		BtnCSHA512.Enabled = False

		'Disable Reset until something has been done
		ResetToolStripMenuItem.Enabled = False

		'Disable 'More' until a file has been selected
		MoreToolStripMenuItem.Enabled = False

	End Sub

	Private Sub Reset_Filename()
		TxtFileName.Text = "Browse for a file or drag a file here"
	End Sub

	Private Sub Reset_Hashes()
		TxtMD5.Text = ""
		TxtSHA256.Text = ""
		TxtSHA512.Text = ""
	End Sub

	Private Sub Reset_Compare()
		TxtCMD5.Text = "Paste or drag & drop MD5 here to compare"
		TxtCSHA256.Text = "Paste or drag & drop SHA256 here to compare"
		TxtCSHA512.Text = "Paste or drag & drop SHA512 here to compare "
	End Sub

	Private Sub BtnBrowse_Click(sender As Object, e As EventArgs) Handles BtnBrowse.Click
		Browseforfile()
	End Sub

	Private Sub Browseforfile()

		' Call ShowDialog.
		Dim result As DialogResult = OpenFileDialog1.ShowDialog()

		' Test if the OK button was clicked or a file was double clicked.
		If result = Windows.Forms.DialogResult.OK Then
			' Set the FileName variable to the selected file
			vFileName = OpenFileDialog1.FileName
			' Display the selected file name in the textbox
			TxtFileName.Text = vFileName
			vGFileName = vFileName
			ResetToolStripMenuItem.Enabled = True
			MoreToolStripMenuItem.Enabled = True
		End If
	End Sub

	Private Sub TxtFileName_DragEnter(sender As Object, e As DragEventArgs) Handles TxtFileName.DragEnter
		e.Effect = DragDropEffects.All
		'get the filename
		Dim Data = e.Data.GetData(DataFormats.FileDrop)

		If Data IsNot Nothing Then

			Dim fileNames = Data(0).ToString
			'set the var to the filename
			'enable Reset
			If (fileNames.Length > 0) Then
				vFileName = fileNames
				ResetToolStripMenuItem.Enabled = True
				MoreToolStripMenuItem.Enabled = True
			End If

		End If

		TxtFileName.Text = vFileName
	End Sub

	Private Sub TxtFileName_TextChanged(sender As Object, e As EventArgs) Handles TxtFileName.TextChanged

		'if the filename isn't "" or "Browse for a file or drag a file here" 
		' then enable the hash buttons
		If TxtFileName.Text <> "" And TxtFileName.Text <> "Browse for a file or drag a file here" Then
			'if a file is chosen enabled the hash buttons
			BtnMD5.Enabled = True
			BtnSHA256.Enabled = True
			BtnSHA512.Enabled = True

			'set the var
			vFileName = TxtFileName.Text
			'if the filename is different 
			' clear the hashes and comparisons
			If TxtFileName.Text <> vGFileName Then
				Reset_Hashes()
				Reset_Compare()
			End If
			vGFileName = vFileName
		Else
			BtnMD5.Enabled = False
			BtnCSHA256.Enabled = False
			BtnSHA512.Enabled = False
		End If

	End Sub

	Private Sub TxtFileName_LostFocus(sender As Object, e As EventArgs) Handles TxtFileName.LostFocus
		If TxtFileName.Text <> "" And TxtFileName.Text <> "Browse for a file or drag a file here" Then
			vGFileName = vFileName
		End If
	End Sub

	'**********************************************************************************
	'*********************************** MD5*******************************************											
	'**********************************************************************************
	Private Sub BtnMD5_Click(sender As Object, e As EventArgs) Handles BtnMD5.Click
		' generate MD5 
		TxtMD5.Text = vClsHash.get_hash(vFileName, "MD5")
	End Sub

	Private Sub TxtMD5_TextChanged(sender As Object, e As EventArgs) Handles TxtMD5.TextChanged
		'Set the var to the textbox text
		vstrMD5 = TxtMD5.Text
	End Sub

	Private Sub TxtCMD5_MouseClick(sender As Object, e As MouseEventArgs) Handles TxtCMD5.MouseClick
		' clear the MD5 "compare to" textbox on mouseclick
		TxtCMD5.Text = ""
	End Sub
	Private Sub TxtCMD5_DragEnter(sender As Object, e As DragEventArgs) Handles TxtCMD5.DragEnter
		' Change the mouse pointer
		e.Effect = DragDropEffects.All
	End Sub

	Private Sub TxtCMD5_DragDrop(sender As Object, e As DragEventArgs) Handles TxtCMD5.DragDrop
		' Set the textbox text to the text being dropped
		TxtCMD5.Text = e.Data.GetData(DataFormats.Text)
	End Sub

	Private Sub TxtCMD5_TextChanged(sender As Object, e As EventArgs) Handles TxtCMD5.TextChanged
		vstrCMD5 = TxtCMD5.Text
		If TxtCMD5.Text <> "" And TxtCMD5.Text <> "Paste or drag & drop MD5 here to compare" Then
			BtnCMD5.Enabled = True
		Else
			BtnCMD5.Enabled = False
			TxtCMD5.BackColor = Color.White
		End If
	End Sub

	Private Sub TxtCMD5_LostFocus(sender As Object, e As EventArgs) Handles TxtCMD5.LostFocus
		If TxtCMD5.Text.Trim = "" Then
			TxtCMD5.Text = "Paste or drag & drop MD5 here to compare"
			BtnCMD5.Enabled = False
		End If
	End Sub

	Private Sub BtnCMD5_Click(sender As Object, e As EventArgs) Handles BtnCMD5.Click
		' compare calculated MD5 to comparison MD5
		If vstrMD5.Trim = vstrCMD5.Trim Then
			TxtCMD5.BackColor = Color.Lime
		Else
			TxtCMD5.BackColor = Color.Red
		End If

	End Sub


	'**********************************************************************************
	'***********************************SHA256*****************************************											
	'**********************************************************************************
	Private Sub BtnSHA256_Click(sender As Object, e As EventArgs) Handles BtnSHA256.Click
		' generate SHA256
		TxtSHA256.Text = vClsHash.get_hash(vFileName, "SHA256")
	End Sub

	Private Sub TxtSHA256_TextChanged(sender As Object, e As EventArgs) Handles TxtSHA256.TextChanged
		' set the SHA256 var to the textbox text
		vstrSHA256 = TxtSHA256.Text
	End Sub

	Private Sub TxtCSHA256_MouseClick(sender As Object, e As MouseEventArgs) Handles TxtCSHA256.MouseClick
		' clear the SHA256 "compare to" textbox on mouseclick
		TxtCSHA256.Text = ""
	End Sub
	Private Sub TxtCSHA256_DragEnter(sender As Object, e As DragEventArgs) Handles TxtCSHA256.DragEnter
		' Change the mouse pointer
		e.Effect = DragDropEffects.All
	End Sub
	Private Sub TxtCSHA256_DragDrop(sender As Object, e As DragEventArgs) Handles TxtCSHA256.DragDrop
		' Set the textbox text to the text being dropped
		TxtCSHA256.Text = e.Data.GetData(DataFormats.Text)
	End Sub
	Private Sub TxtCSHA256_TextChanged(sender As Object, e As EventArgs) Handles TxtCSHA256.TextChanged
		vstrCSHA256 = TxtCSHA256.Text
		If TxtCSHA256.Text <> "" And TxtCSHA256.Text <> "Paste or drag & drop MD5 here to compare" Then
			BtnCSHA256.Enabled = True
		Else
			BtnCSHA256.Enabled = False
			TxtCSHA256.BackColor = Color.White
		End If
	End Sub

	Private Sub TxtCSHA256_LostFocus(sender As Object, e As EventArgs) Handles TxtCSHA256.LostFocus
		If TxtCSHA256.Text.Trim = "" Then
			TxtCSHA256.Text = "Paste or drag & drop SHA256 here to compare"
			BtnCSHA256.Enabled = False
		End If
	End Sub

	Private Sub BtnCSHA256_Click(sender As Object, e As EventArgs) Handles BtnCSHA256.Click
		'Compare calculated SHA256 to comparison SHA256
		If vstrSHA256.Trim = vstrCSHA256.Trim Then
			TxtCSHA256.BackColor = Color.Lime
		Else
			TxtCSHA256.BackColor = Color.Red
		End If
	End Sub


	'**********************************************************************************
	'***********************************SHA512*****************************************											
	'**********************************************************************************
	Private Sub BtnSHA512_Click(sender As Object, e As EventArgs) Handles BtnSHA512.Click
		' generate SHA512
		TxtSHA512.Text = vClsHash.get_hash(vFileName, "SHA512")
	End Sub

	Private Sub TxtSHA512_TextChanged(sender As Object, e As EventArgs) Handles TxtSHA512.TextChanged
		'Set the var to the textbox text
		vstrSHA512 = TxtSHA512.Text
	End Sub

	Private Sub TxtCSHA512_MouseClick(sender As Object, e As EventArgs) Handles TxtCSHA512.MouseClick
		' clear the SHA512 "compare to" textbox on mouseclick
		TxtCSHA512.Text = ""
	End Sub

	Private Sub TxtCSHA512_TextChanged(sender As Object, e As EventArgs) Handles TxtCSHA512.TextChanged
		vstrCSHA512 = TxtCSHA512.Text
		If TxtCSHA512.Text <> "" And TxtCSHA512.Text <> "Paste or drag & drop MD5 here to compare" Then
			BtnCSHA512.Enabled = True
		Else
			BtnCSHA512.Enabled = False
			TxtCSHA512.BackColor = Color.White
		End If
	End Sub
	Private Sub TxtCSHA512_DragEnter(sender As Object, e As DragEventArgs) Handles TxtCSHA512.DragEnter
		' Change the mouse pointer
		e.Effect = DragDropEffects.All
		' Set the textbox text to the text being dropped
		'TxtCSHA512.Text = e.Data.GetData(DataFormats.Text)
	End Sub
	Private Sub TxtCSHA512_DragDrop(sender As Object, e As DragEventArgs) Handles TxtCSHA512.DragDrop
		' Set the textbox text to the text being dropped
		TxtCSHA512.Text = e.Data.GetData(DataFormats.Text)
	End Sub
	Private Sub TxtCSHA512_LostFocus(sender As Object, e As EventArgs) Handles TxtCSHA512.LostFocus
		If TxtCSHA512.Text.Trim = "" Then
			TxtCSHA512.Text = "Paste or drag & drop SHA512 here to compare"
			BtnCSHA512.Enabled = False
		End If
	End Sub

	Private Sub BtnCSHA512_Click(sender As Object, e As EventArgs) Handles BtnCSHA512.Click
		' compare calculated SHA512 to comparison SHA512
		If vstrSHA512.Trim = vstrCSHA512.Trim Then
			TxtCSHA512.BackColor = Color.Lime
		Else
			TxtCSHA512.BackColor = Color.Red
		End If
	End Sub

	'**********************************************************************************
	'*********************************Menu Items***************************************											
	'**********************************************************************************

	Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
		Browseforfile()
	End Sub
	Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click
		Reset_Form()
	End Sub
	Private Sub MoreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MoreToolStripMenuItem.Click
		FrmMore.Show()
	End Sub

	Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
		Me.Close()
	End Sub
	Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
		AboutBox.Show()
	End Sub

	'**********************************************************************************
	Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
		Me.Close()
	End Sub

End Class
