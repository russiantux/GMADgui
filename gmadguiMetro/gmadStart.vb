Imports System.IO

Public Class gmadStart
    Dim gmadsGood = My.Settings.gmadGood
    Dim gmadVersionO As String
    Dim gamdVersion1 As String
    Dim gmadcurrentVer As String
    Dim gmaFile As String
    Dim folPath As String
    Dim folPathC As String
    Dim foldPathC1 As String
    Dim gmadGood As Boolean

    Dim gmaSelcGood As Boolean
    Dim foldSelcGood1 As Boolean
    Dim foldSelcGood2 As Boolean
    Dim foldSelecGood3 As Boolean


    ' settings and versions '
    Private Sub WarningShow()
        If (My.Settings.gmadGood = False) Then
            Warningpic1.Visible = True
            warningPic2.Visible = True
            warningtxt1.Visible = True
            warningtxt2.Visible = True
            gmadGood = False
        End If
        If (My.Settings.gmadGood = True) Then
            Warningpic1.Visible = False
            warningPic2.Visible = False
            warningtxt1.Visible = False
            warningtxt2.Visible = False
            gmadGood = True

        End If
    End Sub
    Private Sub gmadStart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not Directory.Exists("/GMADgui/config/") Then
            Directory.CreateDirectory("/GMADgui/config/")
        End If

        If Not File.Exists("/GMADgui/config/version.txt") Then
            My.Computer.Network.DownloadFile(
               "https://raw.githubusercontent.com/russiantux/GMADgui/master/version.txt",
               "/GMADgui/config/version.txt")
        End If


        gmadVersionO = My.Computer.FileSystem.ReadAllText("/GMADgui/config/version.txt")
        latestVer.Text = gmadVersionO
        WarningShow()
        gmadSettingPath.Text = My.Settings.gmadLoc
        If (String.Equals(gmadcurrentVer, gmadVersionO) = True) Then
            latestVer.ForeColor = Color.Red
        Else
            latestVer.ForeColor = Color.Green
        End If
    End Sub

    Private Sub MetroButton8_Click(sender As Object, e As EventArgs) Handles MetroButton8.Click
        Dim gmadStream As Stream = Nothing
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.InitialDirectory = "c:\"
        openFileDialog1.Filter = "gmad.exe (gmad.exe)|gmad.exe"
        openFileDialog1.FilterIndex = 2
        openFileDialog1.RestoreDirectory = True
        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                gmadStream = openFileDialog1.OpenFile()
                If (gmadStream IsNot Nothing) Then
                    gmadSettingPath.Text = openFileDialog1.FileName.ToString
                    My.Settings.gmadLoc = openFileDialog1.FileName.ToString
                    My.Settings.gmadGood = True
                    My.Settings.Save()

                End If
            Catch Ex As Exception
                MessageBox.Show("Cannot read file from disk. Original error: " & Ex.Message)
            Finally
                ' Check this again, since we need to make sure we didn't throw an exception on open.
                If (gmadStream IsNot Nothing) Then
                    gmadStream.Close()
                End If
            End Try
        End If
    End Sub

    Private Sub MetroButton7_Click(sender As Object, e As EventArgs) Handles MetroButton7.Click
        My.Settings.gmadGood = False
        gmadSettingPath.Text = " "
        My.Settings.gmadLoc = " "
    End Sub

    ' gma extraction '
    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles extractBut1.Click
        Dim gmaStream As Stream = Nothing
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.InitialDirectory = "c:\"
        openFileDialog1.Filter = ".gma Files (*.gma)|*.gma"
        openFileDialog1.FilterIndex = 2
        openFileDialog1.RestoreDirectory = True
        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                gmaStream = openFileDialog1.OpenFile()
                If (gmaStream IsNot Nothing) Then
                    gmaBox1.Text = openFileDialog1.FileName.ToString
                    gmaFile = openFileDialog1.FileName.ToString
                    gmaSelcGood = True
                End If
            Catch Ex As Exception
                MessageBox.Show("Cannot read file from disk. Original error: " & Ex.Message)
            Finally
                ' Check this again, since we need to make sure we didn't throw an exception on open.
                If (gmaStream IsNot Nothing) Then
                    gmaStream.Close()
                End If
            End Try
        End If
    End Sub
    ' gma & folder selection '
    Private Sub extractBut2_Click(sender As Object, e As EventArgs) Handles extractBut2.Click
        Dim folStream As Stream = Nothing
        Dim openFileDialogfol As New FolderBrowserDialog()

        If openFileDialogfol.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                openFileDialogfol.RootFolder = Environment.SpecialFolder.MyComputer
                folPath1.Text = openFileDialogfol.SelectedPath.ToString
                folPath = openFileDialogfol.SelectedPath.ToString
                extractProg1.Value = 0
                foldSelcGood1 = True
            Catch Ex As Exception
                MessageBox.Show("Cannot read file from disk. Original error: " & Ex.Message)
            Finally
                ' Check this again, since we need to make sure we didn't throw an exception on open.
                If (folStream IsNot Nothing) Then
                    folStream.Close()
                End If
            End Try
        End If
    End Sub
    ' extraction process '
    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles ExtractBut.Click
        If (gmadGood = True) Then
            If (gmaSelcGood = True) Then
                If (foldSelcGood1 = True) Then
                    Dim gmad As New ProcessStartInfo()
                    gmad.FileName = My.Settings.gmadLoc
                    gmad.Arguments = "extract -file " + gmaFile + " -out " + folPath
                    Process.Start(gmad)
                    extractProg1.Value = 100
                End If

            End If
        End If
    End Sub
    ' Compress section '



    ' folder selction'

    Private Sub MetroButton6_Click(sender As Object, e As EventArgs) Handles MetroButton6.Click
        Dim folStream As Stream = Nothing
        Dim openFileDialogfol As New FolderBrowserDialog()

        If openFileDialogfol.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                openFileDialogfol.RootFolder = Environment.SpecialFolder.MyComputer
                folSelcBox.Text = openFileDialogfol.SelectedPath.ToString
                folPathC = openFileDialogfol.SelectedPath.ToString
                foldSelcGood2 = True
            Catch Ex As Exception
                MessageBox.Show("Cannot read file from disk. Original error: " & Ex.Message)
            Finally
                ' Check this again, since we need to make sure we didn't throw an exception on open.
                If (folStream IsNot Nothing) Then
                    folStream.Close()
                End If
            End Try
        End If
    End Sub


    ' folder selection '
    Private Sub MetroButton5_Click(sender As Object, e As EventArgs) Handles MetroButton5.Click
        Dim folStream As Stream = Nothing
        Dim openFileDialogfol As New FolderBrowserDialog()

        If openFileDialogfol.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                openFileDialogfol.RootFolder = Environment.SpecialFolder.MyComputer
                folSelcBox1.Text = openFileDialogfol.SelectedPath.ToString
                foldPathC1 = openFileDialogfol.SelectedPath.ToString
                compressProg.Value = 0
                foldSelecGood3 = True
            Catch Ex As Exception
                MessageBox.Show("Cannot read file from disk. Original error: " & Ex.Message)
            Finally
                ' Check this again, since we need to make sure we didn't throw an exception on open.
                If (folStream IsNot Nothing) Then
                    folStream.Close()
                End If
            End Try
        End If
    End Sub

    'compressing'
    Private Sub MetroButton4_Click(sender As Object, e As EventArgs) Handles MetroButton4.Click
        If (gmadGood = True) Then
            If (foldSelcGood2 = True) Then
                If (foldSelecGood3 = True) Then
                    If (addonjsonMake.Checked = True) Then
                        addonjsonMaker.Show()
                    End If

                    If (addonjsonMake.Checked = False) Then


                        Dim gmadC As New ProcessStartInfo()
                        gmadC.FileName = My.Settings.gmadLoc
                        gmadC.Arguments = "create -folder " + folPathC + " -out " + foldPathC1
                        Process.Start(gmadC)
                        compressProg.Value = 100
                    End If
                End If
            End If
        End If
    End Sub


End Class
