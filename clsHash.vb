Imports System.Collections.ObjectModel
Imports System.Management.Automation
Imports System.Management.Automation.Runspaces

Public Class ClsHash
	Public Function get_hash(filename As String, algorithm As String) As String

		Dim vstrHash As String

		' change cursor to busy
		FrmHashes.Cursor = Cursors.WaitCursor

		' powershell command
		Dim vstrScriptText As String
		vstrScriptText = "certutil -hashfile" + " '" + filename + "' " + algorithm

		' create Powershell runspace
		Dim MyRunSpace As Runspace = RunspaceFactory.CreateRunspace()

		' open it
		MyRunSpace.Open()

		' create a pipeline and feed it the script text
		Dim MyPipeline As Pipeline = MyRunSpace.CreatePipeline()

		MyPipeline.Commands.AddScript(vstrScriptText)

		' execute the script
		Dim hashresults As Collection(Of PSObject) = MyPipeline.Invoke()

		' close the runspace
		MyRunSpace.Close()

		' if there is an error the result will contain 2 objects (lines)
		' if there is no error the result will contain 3 objects (lines), the 2nd is the hash
		If hashresults.Count = 2 Then
			vstrHash = "The file is in use by another application. Please close it or choose another file and try again."
		Else
			vstrHash = hashresults(1).ToString()
		End If

		' change cursor to normal when finished
		FrmHashes.Cursor = Cursors.Default

		' return the results of the script 
		Return vstrHash

	End Function
End Class
