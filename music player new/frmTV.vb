Public Class frmTV
    Private Sub pbHM_Click(sender As Object, e As EventArgs) Handles pbHM.Click
        Try
            webTV.DocumentText = My.Resources.RHM
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub frmTV_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblInfo.Left = lblInfo.Left - (1)

        If lblInfo.Left < 0 - lblInfo.Size.Width Then
            lblInfo.Left = 578
        End If
    End Sub
    Private Sub pbRHM_Click(sender As Object, e As EventArgs) Handles pbRHM.Click
        Try
            webTV.DocumentText = My.Resources.RHM
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub pbTVK_Click(sender As Object, e As EventArgs) Handles pbTVK.Click
        Try
            webTV.DocumentText = My.Resources.TVK
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub pbCTN_Click(sender As Object, e As EventArgs) Handles pbCTN.Click
        Try
            webTV.DocumentText = My.Resources.CTN
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub pbMYTV_Click(sender As Object, e As EventArgs) Handles pbMYTV.Click
        Try
            webTV.DocumentText = My.Resources.mytv
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub pbCNC_Click(sender As Object, e As EventArgs) Handles pbCNC.Click
        Try
            webTV.DocumentText = My.Resources.CNC
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub pbTV11_Click(sender As Object, e As EventArgs) Handles pbTV11.Click
        Try
            webTV.DocumentText = My.Resources.apsata
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub pbBayonTV_Click(sender As Object, e As EventArgs) Handles pbBayonTV.Click
        Try
            webTV.DocumentText = My.Resources.bayonEnter
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub pbBayonNews_Click(sender As Object, e As EventArgs) Handles pbBayonNews.Click
        Try
            webTV.DocumentText = My.Resources.Bayon
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub pbTV3_Click(sender As Object, e As EventArgs) Handles pbTV3.Click
        Try
            webTV.DocumentText = My.Resources.TV3
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub pbTV5_Click(sender As Object, e As EventArgs) Handles pbTV5.Click
        Try
            webTV.DocumentText = My.Resources.TV5
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub pbTV9_Click(sender As Object, e As EventArgs) Handles pbTV9.Click
        Try
            webTV.DocumentText = My.Resources.TV9
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Try
            webTV.DocumentText = My.Resources.PNN1
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        Try
            webTV.DocumentText = My.Resources.seatv
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Try
            webTV.DocumentText = My.Resources.ETV
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.Close()
    End Sub
End Class