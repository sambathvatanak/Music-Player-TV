Public Class frmAbout
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim m As Media_Player = New TV(New Music(New PlainRadio()))

        Dim str As String = ""
        'MessageBox.Show(m.Description)
        lblDecorator.Text = m.Description

    End Sub
End Class