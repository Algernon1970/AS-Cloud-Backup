Imports System.ComponentModel
Imports Ionic
Imports KBCsv


Public Class Form1
    Dim dircount As Integer = 0
    Dim uList As New List(Of String)
    Dim cuser As String = ""
    Dim bwrunning As Boolean = True
    Delegate Sub updateBox(ByVal myString As String)

    Dim updateboxdel As updateBox = New updateBox(AddressOf updateOutBox)

    Private Sub updateOutBox(ByVal myString As String)
        outBox.AppendText(myString)
    End Sub

    Private Sub csvLoaderButton_Click(sender As Object, e As EventArgs) Handles csvLoaderButton.Click
        Dim dr As DataRecord
        Dim res As DialogResult = csvBrowser.ShowDialog
        If res = DialogResult.OK Then
            csvLocationBox.Text = csvBrowser.FileName
            Using streamreader = New IO.StreamReader(csvBrowser.FileName)
                Using csvReader = New CsvReader(streamreader)
                    csvReader.ReadHeaderRecord()
                    While csvReader.HasMoreRecords
                        dr = csvReader.ReadDataRecord
                        uList.Add(dr("Username"))
                    End While
                End Using
            End Using
            usersProcessedLabel.Text = String.Format("{0} users to process", uList.Count)
        End If
    End Sub

    Private Sub backupLocationButton_Click(sender As Object, e As EventArgs) Handles backupLocationButton.Click
        Dim res As DialogResult = backupFolderBrowser.ShowDialog
        If res = DialogResult.OK Then
            backupLocationBox.Text = backupFolderBrowser.SelectedPath
        End If
    End Sub

    Private Function mapdrive(ByVal drive As String, ByVal path As String) As Boolean
        Dim nr As New NETRESOURCE
        nr.lpRemoteName = path
        nr.lpLocalName = drive
        nr.lpProvider = Nothing
        nr.dwType = &H1
        Dim res As Integer = mapper.WNetAddConnection2(nr, Nothing, Nothing, 0)
        If res = 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub unmapdrive(ByVal drive As String)
        mapper.WNetCancelConnection2(drive, 0, 1)
    End Sub

    Private Sub backupButton_Click(sender As Object, e As EventArgs) Handles backupButton.Click
        Dim bw As BackgroundWorker = New BackgroundWorker
        bw.WorkerSupportsCancellation = True
        bw.WorkerReportsProgress = True
        AddHandler bw.DoWork, AddressOf bw_dowork
        AddHandler bw.RunWorkerCompleted, AddressOf bw_finished

        If backupLocationBox.Text = "" Then
            MsgBox("Select backup location")
            Return
        End If

        If uList.Count = 0 Then
            MsgBox("Select some users")
            Return
        End If

        Dim ucount As Integer = 0
        backupButton.Enabled = False
        backupButton.BackColor = Color.Gray
        usersProcessedLabel.Text = String.Format("(0/{0})", uList.Count)
        For Each user As String In uList
            usersProcessedLabel.Text = String.Format("({0}/{1}) Processing....", ucount + 1, uList.Count)
            cuser = user
            'backupUser(user)
            bwrunning = True
            bw.RunWorkerAsync()
            While bwrunning
                Application.DoEvents()
                Threading.Thread.Sleep(50)
            End While
            ucount = ucount + 1
        Next

        backupButton.BackColor = Color.Crimson
        backupButton.Enabled = True

        usersProcessedLabel.Text = usersProcessedLabel.Text & " Finished."
    End Sub

    Private Sub bw_dowork()
        backupUser(cuser)
    End Sub

    Private Sub bw_finished()
        bwrunning = False
    End Sub

    Private Sub backupUser(ByVal uName As String)
        Try
            Dim url As String = String.Format("https://ashbyschool-my.sharepoint.com/personal/{0}_ashbyschool_org_uk/", uName)
            If mapdrive("Q:", url) Then
                Dim zipname As String = String.Format("{0}\{1}.zip", backupLocationBox.Text, uName)
                Dim zipfile As Zip.ZipFile = New Zip.ZipFile(zipname)
                Me.Invoke(updateboxdel, (String.Format("Zipping - {0}{1}", uName, vbCrLf)))
                zipfile.AddDirectory("Q:\Documents")
                zipfile.Save()
                zipfile.Dispose()
                unmapdrive("Q:")
            Else
                Me.Invoke(updateboxdel, String.Format("FAILED: Map {0}{1}", url, vbCrLf))
            End If
        Catch ex As Exception
            Me.Invoke(updateboxdel, ex.Message & vbCrLf & vbCrLf)
            unmapdrive("Q:")
        End Try

    End Sub



End Class
