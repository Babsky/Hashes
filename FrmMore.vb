Public Class FrmMore

	Private ReadOnly vClsHash As New ClsHash
	Private vstrMoreCompare1 As String
	Private Sub FrmMore_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		CboMore1.Items.Add("Please select an algorithm")
		CboMore1.Items.Add("MD2")
		CboMore1.Items.Add("MD4")
		'CboMore1.Items.Add("MD5")
		CboMore1.Items.Add("SHA1")
		'CboMore1.Items.Add("SHA256")
		CboMore1.Items.Add("SHA384")
		'CboMore1.Items.Add("SHA512")

		CboMore1.SelectedIndex = 0

		TxtMoreCompare1.Text = "Paste or drag & drop a hashsum here to compare"

		BtnMoreCompare1.Text = "Compare "
		BtnMoreCompare1.Enabled = False
		BtnMoreClose.Text = "Close"

		LblMoreFileName.Text = FrmHashes.vGFileName


	End Sub

	Private Sub CboMore1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboMore1.SelectedIndexChanged

		If CboMore1.SelectedIndex = 0 Then
			'No algorythm selected
			txtMoreHash1.Text = ""
		Else
			txtMoreHash1.Text = vClsHash.get_hash(FrmHashes.vGFileName, CboMore1.SelectedItem.ToString)
			BtnMoreCompare1.Text = "Compare " & CboMore1.SelectedItem.ToString
			TxtMoreCompare1.Text = "Paste or drag & drop a hashsum here to compare"
			TxtMoreCompare1.BackColor = Color.White
		End If

		BtnMoreCompare1.Enabled = False

	End Sub

	Private Sub BtnMoreCompare1_Click(sender As Object, e As EventArgs) Handles BtnMoreCompare1.Click
		' compare calculated hash to comparison hash
		If txtMoreHash1.Text.Trim = TxtMoreCompare1.Text.Trim Then
			TxtMoreCompare1.BackColor = Color.Lime
		Else
			TxtMoreCompare1.BackColor = Color.Red
		End If
	End Sub

	Private Sub TxtMoreCompare1_MouseClick(sender As Object, e As MouseEventArgs) Handles TxtMoreCompare1.MouseClick
		' clear the "compare to" textbox on mouseclick
		TxtMoreCompare1.Text = ""
	End Sub

	Private Sub TxtMoreCompare1_TextChanged(sender As Object, e As EventArgs) Handles TxtMoreCompare1.TextChanged
		vstrMoreCompare1 = TxtMoreCompare1.Text.Trim
		If vstrMoreCompare1 <> "" And vstrMoreCompare1 <> "Paste or drag & drop MD5 here to compare" Then
			BtnMoreCompare1.Enabled = True
		Else
			BtnMoreCompare1.Enabled = False
			TxtMoreCompare1.BackColor = Color.White
		End If
	End Sub
	Private Sub TxtMoreCompare1_DragEnter(sender As Object, e As DragEventArgs) Handles TxtMoreCompare1.DragEnter
		' Change the mouse pointer
		e.Effect = DragDropEffects.All
	End Sub
	Private Sub TxtMoreCompare1_DragDrop(sender As Object, e As DragEventArgs) Handles TxtMoreCompare1.DragDrop
		' Set the textbox text to the text being dropped
		TxtMoreCompare1.Text = e.Data.GetData(DataFormats.Text)
	End Sub

	Private Sub TxtMoreCompare1_LostFocus(sender As Object, e As EventArgs) Handles TxtMoreCompare1.LostFocus
		If vstrMoreCompare1 = "" Then
			TxtMoreCompare1.Text = "Paste or drag & drop MD5 here to compare"
			BtnMoreCompare1.Enabled = False
		End If
	End Sub

	Private Sub BtnMoreClose_Click(sender As Object, e As EventArgs) Handles BtnMoreClose.Click
		Me.Close()
	End Sub
End Class