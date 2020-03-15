<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTV
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTV))
        Me.webTV = New System.Windows.Forms.WebBrowser()
        Me.pbTV9 = New System.Windows.Forms.PictureBox()
        Me.pbTV5 = New System.Windows.Forms.PictureBox()
        Me.pbBayonNews = New System.Windows.Forms.PictureBox()
        Me.pbBayonTV = New System.Windows.Forms.PictureBox()
        Me.pbCNC = New System.Windows.Forms.PictureBox()
        Me.pbMYTV = New System.Windows.Forms.PictureBox()
        Me.pbTVK = New System.Windows.Forms.PictureBox()
        Me.pbRHM = New System.Windows.Forms.PictureBox()
        Me.pbTV3 = New System.Windows.Forms.PictureBox()
        Me.pbTV11 = New System.Windows.Forms.PictureBox()
        Me.pbCTN = New System.Windows.Forms.PictureBox()
        Me.pbHM = New System.Windows.Forms.PictureBox()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        CType(Me.pbTV9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbTV5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBayonNews, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBayonTV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCNC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbMYTV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbTVK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbRHM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbTV3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbTV11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCTN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbHM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'webTV
        '
        Me.webTV.Location = New System.Drawing.Point(-1, -1)
        Me.webTV.MinimumSize = New System.Drawing.Size(20, 20)
        Me.webTV.Name = "webTV"
        Me.webTV.ScrollBarsEnabled = False
        Me.webTV.Size = New System.Drawing.Size(739, 440)
        Me.webTV.TabIndex = 0
        '
        'pbTV9
        '
        Me.pbTV9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbTV9.Image = Global.music_player_new.My.Resources.Resources.tv9_channel
        Me.pbTV9.Location = New System.Drawing.Point(863, 336)
        Me.pbTV9.Name = "pbTV9"
        Me.pbTV9.Size = New System.Drawing.Size(113, 102)
        Me.pbTV9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbTV9.TabIndex = 12
        Me.pbTV9.TabStop = False
        '
        'pbTV5
        '
        Me.pbTV5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbTV5.Image = Global.music_player_new.My.Resources.Resources.tv5_channel
        Me.pbTV5.Location = New System.Drawing.Point(744, 337)
        Me.pbTV5.Name = "pbTV5"
        Me.pbTV5.Size = New System.Drawing.Size(113, 102)
        Me.pbTV5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbTV5.TabIndex = 11
        Me.pbTV5.TabStop = False
        '
        'pbBayonNews
        '
        Me.pbBayonNews.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbBayonNews.Image = Global.music_player_new.My.Resources.Resources.bayon_tv_news_channel
        Me.pbBayonNews.Location = New System.Drawing.Point(982, 228)
        Me.pbBayonNews.Name = "pbBayonNews"
        Me.pbBayonNews.Size = New System.Drawing.Size(113, 102)
        Me.pbBayonNews.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbBayonNews.TabIndex = 10
        Me.pbBayonNews.TabStop = False
        '
        'pbBayonTV
        '
        Me.pbBayonTV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbBayonTV.Image = Global.music_player_new.My.Resources.Resources.bayon_tv_channel
        Me.pbBayonTV.Location = New System.Drawing.Point(863, 228)
        Me.pbBayonTV.Name = "pbBayonTV"
        Me.pbBayonTV.Size = New System.Drawing.Size(113, 102)
        Me.pbBayonTV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbBayonTV.TabIndex = 9
        Me.pbBayonTV.TabStop = False
        '
        'pbCNC
        '
        Me.pbCNC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbCNC.Image = Global.music_player_new.My.Resources.Resources.cnc_channel
        Me.pbCNC.Location = New System.Drawing.Point(982, 120)
        Me.pbCNC.Name = "pbCNC"
        Me.pbCNC.Size = New System.Drawing.Size(113, 102)
        Me.pbCNC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbCNC.TabIndex = 8
        Me.pbCNC.TabStop = False
        '
        'pbMYTV
        '
        Me.pbMYTV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbMYTV.Image = Global.music_player_new.My.Resources.Resources.mytv_channel
        Me.pbMYTV.Location = New System.Drawing.Point(863, 120)
        Me.pbMYTV.Name = "pbMYTV"
        Me.pbMYTV.Size = New System.Drawing.Size(113, 102)
        Me.pbMYTV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbMYTV.TabIndex = 7
        Me.pbMYTV.TabStop = False
        '
        'pbTVK
        '
        Me.pbTVK.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbTVK.Image = Global.music_player_new.My.Resources.Resources.tvk_channel
        Me.pbTVK.Location = New System.Drawing.Point(982, 12)
        Me.pbTVK.Name = "pbTVK"
        Me.pbTVK.Size = New System.Drawing.Size(113, 102)
        Me.pbTVK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbTVK.TabIndex = 6
        Me.pbTVK.TabStop = False
        '
        'pbRHM
        '
        Me.pbRHM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbRHM.Image = Global.music_player_new.My.Resources.Resources.RasmeyHangMeasHDTV
        Me.pbRHM.Location = New System.Drawing.Point(863, 12)
        Me.pbRHM.Name = "pbRHM"
        Me.pbRHM.Size = New System.Drawing.Size(113, 102)
        Me.pbRHM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbRHM.TabIndex = 5
        Me.pbRHM.TabStop = False
        '
        'pbTV3
        '
        Me.pbTV3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbTV3.Image = Global.music_player_new.My.Resources.Resources.tv3_channel
        Me.pbTV3.Location = New System.Drawing.Point(982, 336)
        Me.pbTV3.Name = "pbTV3"
        Me.pbTV3.Size = New System.Drawing.Size(113, 102)
        Me.pbTV3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbTV3.TabIndex = 4
        Me.pbTV3.TabStop = False
        '
        'pbTV11
        '
        Me.pbTV11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbTV11.Image = Global.music_player_new.My.Resources.Resources.apsara_tv_channel
        Me.pbTV11.Location = New System.Drawing.Point(744, 228)
        Me.pbTV11.Name = "pbTV11"
        Me.pbTV11.Size = New System.Drawing.Size(113, 102)
        Me.pbTV11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbTV11.TabIndex = 3
        Me.pbTV11.TabStop = False
        '
        'pbCTN
        '
        Me.pbCTN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbCTN.Image = Global.music_player_new.My.Resources.Resources.ctn_channel
        Me.pbCTN.Location = New System.Drawing.Point(744, 120)
        Me.pbCTN.Name = "pbCTN"
        Me.pbCTN.Size = New System.Drawing.Size(113, 102)
        Me.pbCTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbCTN.TabIndex = 2
        Me.pbCTN.TabStop = False
        '
        'pbHM
        '
        Me.pbHM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbHM.Image = Global.music_player_new.My.Resources.Resources.hang_meas_hdtv_channel
        Me.pbHM.Location = New System.Drawing.Point(744, 12)
        Me.pbHM.Name = "pbHM"
        Me.pbHM.Size = New System.Drawing.Size(113, 102)
        Me.pbHM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbHM.TabIndex = 1
        Me.pbHM.TabStop = False
        '
        'lblInfo
        '
        Me.lblInfo.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.ForeColor = System.Drawing.Color.Red
        Me.lblInfo.Location = New System.Drawing.Point(161, 458)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblInfo.Size = New System.Drawing.Size(1053, 23)
        Me.lblInfo.TabIndex = 13
        Me.lblInfo.Text = "Please click on the TV channel to watch. សូមចុចលើប៉ុស្តិ៍ទូរទស្សន៏ដើម្បីមើល។" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " "
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 30
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = Global.music_player_new.My.Resources.Resources.PNN
        Me.PictureBox1.Location = New System.Drawing.Point(1101, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(113, 102)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Image = Global.music_player_new.My.Resources.Resources.seatv_channel
        Me.PictureBox2.Location = New System.Drawing.Point(1101, 120)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(113, 102)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox3.Image = Global.music_player_new.My.Resources.Resources.etv_channel
        Me.PictureBox3.Location = New System.Drawing.Point(1101, 228)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(113, 102)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 16
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.music_player_new.My.Resources.Resources.Shutdown_64px
        Me.PictureBox4.Location = New System.Drawing.Point(-1, 445)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(61, 49)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 17
        Me.PictureBox4.TabStop = False
        '
        'frmTV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1221, 495)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.pbTV9)
        Me.Controls.Add(Me.pbTV5)
        Me.Controls.Add(Me.pbBayonNews)
        Me.Controls.Add(Me.pbBayonTV)
        Me.Controls.Add(Me.pbCNC)
        Me.Controls.Add(Me.pbMYTV)
        Me.Controls.Add(Me.pbTVK)
        Me.Controls.Add(Me.pbRHM)
        Me.Controls.Add(Me.pbTV3)
        Me.Controls.Add(Me.pbTV11)
        Me.Controls.Add(Me.pbCTN)
        Me.Controls.Add(Me.pbHM)
        Me.Controls.Add(Me.webTV)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTV"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        CType(Me.pbTV9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbTV5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBayonNews, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBayonTV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCNC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbMYTV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbTVK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbRHM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbTV3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbTV11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCTN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbHM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents webTV As WebBrowser
    Friend WithEvents pbHM As PictureBox
    Friend WithEvents pbCTN As PictureBox
    Friend WithEvents pbTV11 As PictureBox
    Friend WithEvents pbTV3 As PictureBox
    Friend WithEvents pbRHM As PictureBox
    Friend WithEvents pbTVK As PictureBox
    Friend WithEvents pbCNC As PictureBox
    Friend WithEvents pbMYTV As PictureBox
    Friend WithEvents pbBayonNews As PictureBox
    Friend WithEvents pbBayonTV As PictureBox
    Friend WithEvents pbTV9 As PictureBox
    Friend WithEvents pbTV5 As PictureBox
    Friend WithEvents lblInfo As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
End Class
