Imports System.IO
Imports System.Windows.Forms.FolderBrowserDialog
Imports WMPLib

Public Class Form1
    Dim str As String = "play"
    Dim currenttrack As Integer = 0
    Dim lsbTempo As New ListBox
    Dim mode As String = "repeat"
    Dim com As String = "play"
    Public Sub Duration()
        Dim Duration As String
        Dim wmp As WMPLib.WindowsMediaPlayer = New WMPLib.WindowsMediaPlayer
        Dim media As WMPLib.IWMPMedia = wmp.newMedia(lsbTempo.SelectedItem.ToString())
        If media IsNot Nothing Then
            Duration = media.durationString
            lblDuration.Text = Duration
        End If
    End Sub
    Public Sub Play()

        Try
            If str.Equals("play") Then
                If lsbFile.Items.Count > 0 Then
                    If lsbFile.SelectedIndex >= 0 Then
                        lsbTempo.SelectedIndex = lsbFile.SelectedIndex
                        lsbTempo.SelectedItem = lsbFile.SelectedItem
                        wmPlayer.URL = lsbTempo.SelectedItem.ToString()
                        currenttrack = lsbTempo.SelectedIndex
                        ' wmPlayer.Ctlcontrols.currentPosition = time
                        wmPlayer.Ctlcontrols.play()
                        Duration()
                        Timer2.Start()
                        pbPlay.Image = My.Resources.Pause_32px
                        str = "pause"
                        'com = "pause"
                    Else
                        lsbFile.SelectedIndex = 0
                        lsbTempo.SelectedIndex = lsbFile.SelectedIndex
                        lsbTempo.SelectedItem = lsbFile.SelectedItem
                        wmPlayer.URL = lsbTempo.SelectedItem.ToString()
                        currenttrack = lsbTempo.SelectedIndex
                        'wmPlayer.Ctlcontrols.currentPosition = time
                        wmPlayer.Ctlcontrols.play()
                        Duration()
                        Timer2.Start()
                        pbPlay.Image = My.Resources.Pause_32px
                        str = "pause"
                    End If
                Else
                    Return
                End If
            Else
                'time = wmPlayer.Ctlcontrols.currentPosition
                wmPlayer.Ctlcontrols.pause()
                pbPlay.Image = My.Resources.Google_Play_32px_1
                str = "play"
                com = "con"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub Play1()

        Try
            If str.Equals("play") Then
                If lsbTempo.Items.Count > 0 Then
                    wmPlayer.Ctlcontrols.play()
                    Duration()
                    Timer2.Start()
                    pbPlay.Image = My.Resources.Pause_32px
                    str = "pause"
                    'com = "pause"
                Else
                    Return
                End If
            Else
                    'time = wmPlayer.Ctlcontrols.currentPosition
                    wmPlayer.Ctlcontrols.pause()
                pbPlay.Image = My.Resources.Google_Play_32px_1
                str = "play"
                com = "con"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub NextSong()
        Try
            If currenttrack = lsbTempo.Items.Count - 1 Then
                wmPlayer.URL = lsbTempo.Items(0)
                currenttrack = 0
            Else
                wmPlayer.URL = lsbTempo.Items(currenttrack + 1)
                currenttrack += 1
            End If
            lsbFile.SelectedIndex = currenttrack
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub Previous()
        Try
            If currenttrack = 0 Then
                wmPlayer.URL = lsbTempo.Items(lsbTempo.Items.Count - 1)
                currenttrack = lsbTempo.Items.Count - 1
            Else
                wmPlayer.URL = lsbTempo.Items(currenttrack - 1)
                currenttrack -= 1
            End If
            lsbFile.SelectedIndex = currenttrack
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    'Public Sub UpdatePlayer()
    '    With tbLength
    '        .Maximum = CInt(wmPlayer.currentMedia.duration)
    '        .Minimum = 0
    '        .Value = CInt(wmPlayer.controls.currentPosition())
    '    End With
    'End Sub
    Private Sub tbVolume_Scroll(sender As Object, e As EventArgs) Handles tbVolume.Scroll
        wmPlayer.settings.volume = tbVolume.Value
        If tbVolume.Value = "0" Then
            pbSound.Image = My.Resources.Mute_32px
        Else
            pbSound.Image = My.Resources.Medium_Volume_32px
        End If
    End Sub

    Private Sub pbPlay_Click(sender As Object, e As EventArgs) Handles pbPlay.Click
        If com = "play" Then
            Play()
        Else
            Play1()
        End If
    End Sub

    Private Sub pbPrevious_Click(sender As Object, e As EventArgs) Handles pbPrevious.Click
        Previous()
    End Sub

    Private Sub pbNext_Click(sender As Object, e As EventArgs) Handles pbNext.Click
        NextSong()
    End Sub

    Private Sub lblBrowse_Click(sender As Object, e As EventArgs) Handles lblBrowse.Click
        '// select all item in one folder
        'Dim folder = New FolderBrowserDialog
        'If folder.ShowDialog() = DialogResult.OK Then
        '    Dim path = folder.SelectedPath.ToString()
        '    'Dim str As String() = path.Split(New Char() {"\"})
        '    For Each file As String In My.Computer.FileSystem.GetFiles(path, Microsoft.VisualBasic.FileIO.SearchOption.SearchTopLevelOnly, "*.mp3")
        '        lsbFile.Items.Add(file)
        '    Next
        'End 

        Dim open As New OpenFileDialog
        Try
            open.Title = "Open Music"
            open.FileName = ""
            open.Multiselect = True
            open.Filter = "Mp3 Files (*.mp3)|*.mp3|All Files (*.*)|*.*"
            If open.ShowDialog = DialogResult.OK Then
                For Each track As String In open.FileNames
                    lsbTempo.Items.Add(track)
                Next
                For Each trackname As String In open.SafeFileNames
                    lsbFile.Items.Add(trackname)
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'MessageBox.Show(lsbFile.Items.Count)
    End Sub

    Private Sub lblBrowse_MouseHover(sender As Object, e As EventArgs) Handles lblBrowse.MouseHover
        lblBrowse.Cursor = Cursors.Hand
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lsbFile.ItemHeight = 200
        tbVolume.Value = wmPlayer.settings.volume

        'tbLength.Minimum = 0
        tbLength.Minimum = 0
        ' Timer2.Interval = 100
        'UpdatePlayer()
        Panel5.Visible = False
        Panel7.Visible = False
    End Sub

    Private Sub lsbFile_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsbFile.SelectedIndexChanged
        'Try
        '    lsbTempo.SelectedIndex = lsbFile.SelectedIndex
        '    lsbTempo.SelectedItem = (lsbFile.SelectedItem)
        '    wmPlayer.URL = lsbTempo.SelectedItem.ToString()
        '    currenttrack = lsbTempo.SelectedIndex

        '    str = "play"
        '    If str.Equals("play") Then
        '        ' wmPlayer.Ctlcontrols.play()
        '        pbPlay.Image = My.Resources.Pause_32px
        '        str = "pause"
        '    Else
        '        'wmPlayer.Ctlcontrols.pause()
        '        pbPlay.Image = My.Resources.Google_Play_32px_1
        '        str = "play"
        '    End If

        '    Dim Duration As String
        '    Dim wmp As WMPLib.WindowsMediaPlayer = New WMPLib.WindowsMediaPlayer
        '    Dim media As WMPLib.IWMPMedia = wmp.newMedia(lsbTempo.SelectedItem.ToString())
        '    If media IsNot Nothing Then
        '        Duration = media.durationString
        '        lblDuration.Text = Duration
        '    End If

        '    'tbLength.Maximum = Integer.Parse(wmPlayer.Ctlcontrols.currentItem.duration)
        '    'tbLength.Minimum = 0
        '    'UpdatePlayer()
        '    wmp.close()
        '    Timer2.Start()
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If wmPlayer.playState = WMPLib.WMPPlayState.wmppsStopped Then
            Try
                NextSong()
            Catch ex As Exception
                wmPlayer.URL = ""
            End Try
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Try
            tbLength.Maximum = CInt(wmPlayer.currentMedia.duration.ToString()) + 1
            'MessageBox.Show(CInt(wmPlayer.currentMedia.duration.ToString()))
            ''Label1.Text = AxWindowsMediaPlayer1.currentMedia.durationString
            lblCurDuration.Text = wmPlayer.Ctlcontrols.currentPositionString
            tbLength.Value = CInt(wmPlayer.Ctlcontrols.currentPosition)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub tbLength_Scroll(sender As Object, e As EventArgs) Handles tbLength.Scroll
        wmPlayer.Ctlcontrols.pause()
        wmPlayer.Ctlcontrols.currentPosition = CDbl(tbLength.Value)
        System.Threading.Thread.Sleep(300)
        wmPlayer.Ctlcontrols.play()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles PictureBox17.Click
        If mode = "repeat" Then
            'playnew = True
            PictureBox17.Image = My.Resources.Repeat_32px_1
            wmPlayer.settings.setMode("Loop", True)
            mode = "none"
        Else
            PictureBox17.Image = My.Resources.Repeat_32px
            wmPlayer.settings.setMode("Loop", False)
            mode = "repeat"
            'playnew = False
        End If
    End Sub

    Private Sub wmPlayer_PlayStateChange_1(sender As Object, e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent) Handles wmPlayer.PlayStateChange

        'Dim playnew As Boolean = False
        'Select Case wmPlayer.playState
        '    Case 10
        '        If playnew Then
        '            lsbTempo.SelectedIndex = lsbFile.SelectedIndex
        '            lsbTempo.SelectedItem = lsbFile.SelectedItem
        '            wmPlayer.URL = lsbTempo.SelectedItem.ToString()
        '            currenttrack = lsbTempo.SelectedIndex
        '            wmPlayer.Ctlcontrols.play()
        '        End If
        '    Case 8
        '        playnew = False
        '        If mode = "repeat" Then
        '            wmPlayer.URL = lsbFile.Items(currenttrack)
        '            playnew = True
        '        Else
        '            wmPlayer.URL = lsbFile.Items(currenttrack + 1)
        '        End If

        'End Select
    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        tbVolSetting.Value = wmPlayer.settings.balance
        Panel4.Visible = False
        Panel7.Visible = False
        Panel5.Visible = True

    End Sub
    Private Sub PictureBox18_Click(sender As Object, e As EventArgs) Handles PictureBox18.Click
        Panel5.Visible = False
        Panel7.Visible = False
        Panel4.Visible = True
    End Sub

    Private Sub tbVolSetting_Scroll(sender As Object, e As EventArgs) Handles tbVolSetting.Scroll
        wmPlayer.settings.balance = tbVolSetting.Value
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        tbVolSetting.Value = 0
        wmPlayer.settings.balance = 0
    End Sub

    Private Sub Panel4_DragDrop(sender As Object, e As DragEventArgs) Handles Panel4.DragDrop
        Try
            If e.Data.GetDataPresent(DataFormats.FileDrop) Then
                Dim myfile() As String
                Dim i As Integer
                myfile = e.Data.GetData(DataFormats.FileDrop)
                For i = 0 To myfile.Length - 1
                    lsbTempo.Items.Add(myfile(i))
                    Dim FileInfo As New FileInfo(myfile(i))
                    lsbFile.Items.Add(FileInfo.Name)
                Next
                'Dim j As Integer
                'For j = 0 To myfile.Length - 1
                '    Dim FileInfo As New FileInfo(myfile(j))
                '    lsbFile.Items.Add(FileInfo.Name)
                'Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Panel4_DragEnter(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles Panel4.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.All
        End If
    End Sub

    Private Sub PictureBox19_Click(sender As Object, e As EventArgs)
        lsbFile.Items.Clear()
        lsbTempo.Items.Clear()
    End Sub

    Private Sub txtSearch_KeyUp(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyUp
        If lsbFile.Items.Count > 0 Then
            Dim count As Integer = (lsbFile.Items.Count - 1)
            Dim words As String
            For a = 0 To count
                words = lsbFile.Items.Item(a)
                If InStr(words.ToLower, txtSearch.Text.ToLower) Then
                    lsbFile.SelectedItem = words
                End If
            Next
        Else
            Return
        End If
    End Sub

    Private Sub lsbFile_DoubleClick(sender As Object, e As EventArgs) Handles lsbFile.DoubleClick
        Try
            lsbTempo.SelectedIndex = lsbFile.SelectedIndex
            lsbTempo.SelectedItem = lsbFile.SelectedItem
            wmPlayer.URL = lsbTempo.SelectedItem.ToString()
            currenttrack = lsbTempo.SelectedIndex

            str = "play"
            If str.Equals("play") Then
                ' wmPlayer.Ctlcontrols.play()
                pbPlay.Image = My.Resources.Pause_32px
                str = "pause"
            Else
                'wmPlayer.Ctlcontrols.pause()
                pbPlay.Image = My.Resources.Google_Play_32px_1
                str = "play"
            End If

            Dim Duration As String
            Dim wmp As WMPLib.WindowsMediaPlayer = New WMPLib.WindowsMediaPlayer
            Dim media As WMPLib.IWMPMedia = wmp.newMedia(lsbTempo.SelectedItem.ToString())
            If media IsNot Nothing Then
                Duration = media.durationString
                lblDuration.Text = Duration
            End If

            'tbLength.Maximum = Integer.Parse(wmPlayer.Ctlcontrols.currentItem.duration)
            'tbLength.Minimum = 0
            'UpdatePlayer()
            wmp.close()
            Timer2.Start()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim frm As New frmTV
        If My.Computer.Network.IsAvailable Then
            frm.Show()
        Else
            MessageBox.Show("អ្នកចាំបាច់ត្រូវតែមាន​ Internet សំរាប់ការទស្សនាទូរទស្សន៏" & vbTab & vbTab & "You must have internet connection to watch TV", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Panel7_Paint(sender As Object, e As PaintEventArgs) Handles Panel7.Paint

    End Sub

    Private Sub rdbRNK_CheckedChanged(sender As Object, e As EventArgs) Handles rdbSarika.CheckedChanged
        Try
            lblProcess.ForeColor = Color.Red
            'lblProcess.Visible = True
            webRadio.Navigate("http://www.liveonlineradio.net/cambodia/sarika-fm.htm")
            ' lblProcess.Visible = False
            'Timer3.Enabled = True
            lblProcess.ForeColor = Color.White
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        lblProcess.Visible = False
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        If My.Computer.Network.IsAvailable Then
            Panel5.Visible = False
            Panel4.Visible = False
            Panel3.Visible = False
            Panel7.Visible = True
            lblProcess.Visible = False
            wmPlayer.Ctlcontrols.pause()
            str = "pause"
            Play()
        Else
            MessageBox.Show("អ្នកចាំបាច់ត្រូវតែមាន​ Internet សំរាប់ការស្តាប់វិទ្យុ" & vbTab & vbTab & "You must have internet to listen to the radio", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles rpmDaunPenh.CheckedChanged
        webRadio.Navigate("http://www.liveonlineradio.net/cambodia/daunpenh-efm.htm")
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles rpmRadioCam.CheckedChanged
        webRadio.Navigate("http://www.liveonlineradio.net/cambodia/radio-cambodia.htm")
    End Sub

    Private Sub rptRNKAM_CheckedChanged(sender As Object, e As EventArgs) Handles rptRNKAM.CheckedChanged
        webRadio.Navigate("http://www.liveonlineradio.net/cambodia/rnk.htm")
    End Sub

    Private Sub rptRNKFM_CheckedChanged(sender As Object, e As EventArgs) Handles rptRNKFM.CheckedChanged
        webRadio.Navigate("http://www.liveonlineradio.net/cambodia/rnk-fm.htm")
    End Sub

    Private Sub rdbVayoFM_CheckedChanged(sender As Object, e As EventArgs) Handles rdbVayoFM.CheckedChanged
        webRadio.Navigate("http://www.liveonlineradio.net/cambodia/vayo-fm.htm")
    End Sub

    Private Sub rdbWomanRad_CheckedChanged(sender As Object, e As EventArgs) Handles rdbWomanRad.CheckedChanged
        webRadio.Navigate("http://www.liveonlineradio.net/cambodia/womens-radio-fm102.htm")
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        lblProcess.Left = lblProcess.Left - 3
    End Sub

    Private Sub rdbSarika_ForeColorChanged(sender As Object, e As EventArgs) Handles rdbSarika.ForeColorChanged
        'If rdbSarika.ForeColor = Color.Red Then
        '    lblProcess.Visible = True
        'Else
        '    lblProcess.Visible = False
        'End If
    End Sub

    Private Sub PictureBox19_Click_1(sender As Object, e As EventArgs) Handles PictureBox19.Click
        Panel5.Visible = False
        Panel4.Visible = True
        Panel7.Visible = False
        Panel3.Visible = True
        'lblProcess.Visible = False
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Panel5.Visible = False
        Panel4.Visible = True
        Panel7.Visible = False
        Panel3.Visible = True
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        lsbFile.Items.Clear()
        lsbTempo.Items.Clear()
        str = "pause"
        'Dim pl As IWMPPlaylistArray = wmPlayer.playlistCollection.getByName("myplaylist")
        'If pl.count > 0 Then
        '    Dim p As IWMPPlaylist = pl.Item(0)
        '    wmPlayer.playlistCollection.remove(pl)
        'End If
        wmPlayer.URL = ""
        'Dim firstMedia As WMPLib.IWMPMedia3 = wmPlayer.mediaCollection.getAll().Item(-1)
        'wmPlayer.currentMedia = firstMedia
        'com = "play"
        Play1()
        'pbPlay.Enabled = False
        'pbNext.Enabled = False
        'pbPrevious.Enabled = False
        lblDuration.Text = " "
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        Dim frm As New frmAbout
        frm.Show()
    End Sub

    Private Sub lsbFile_MouseDown(sender As Object, e As MouseEventArgs) Handles lsbFile.MouseDown
        If e.Button = MouseButtons.Right Then
            ContextMenuStrip1.Show(MousePosition)
        End If
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class
