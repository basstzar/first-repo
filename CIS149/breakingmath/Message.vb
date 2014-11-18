Public Class frmMessage


    Private Sub frmMessage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TopMost = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubFormClose.Click
        Me.Close()

    End Sub
End Class