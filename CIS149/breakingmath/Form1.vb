Public Class frmBrkingMath
    Private Sub frmMesssage_Initialize()
        With frmMessage

            frmMessage.btnSubFormClose.DialogResult = DialogResult.OK



        End With

    End Sub



    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click
        Dim strProblem As String
        Dim myMessage As New frmMessage()

        myMessage.Show()

        lblFail.Visible = False


        strProblem = Global.breakingmath.My.Resources.txtProb9
        lblResource.Text = strProblem
        If txtAnswer.Text = "9" Then
            My.Computer.Audio.Play(My.Resources.BB_Yeah, AudioPlayMode.Background)
            frmMessage.ShowDialog()
            fixBox()
            'txtAnswer.Clear()
            'txtAnswer.Focus()
            strProblem = Global.breakingmath.My.Resources.txtProb12
            lblResource.Text = strProblem
            'lblResource.BackColor = Color.Transparent

        ElseIf txtAnswer.Text = "12" Then
            MessageBox.Show("Yeah Mr White!")
            txtAnswer.Clear()
            txtAnswer.Focus()
            strProblem = Global.breakingmath.My.Resources.txtProblem15
            lblResource.Text = strProblem
            lblResource.BackColor = Color.Transparent

        ElseIf txtAnswer.Text = "15" Then
            My.Computer.Audio.Play(My.Resources.BB_Yeah, AudioPlayMode.Background)
            txtAnswer.Clear()
            txtAnswer.Focus()
            lblMrWhite.Visible = True
            lblMrWhite.BackColor = Color.Transparent
            strProblem = Global.breakingmath.My.Resources.txtProblem18
            lblResource.Text = strProblem
            lblResource.BackColor = Color.Transparent
        ElseIf txtAnswer.Text = "18" Then
            txtAnswer.Clear()
            txtAnswer.Focus()
            lblMrWhite.Visible = False
        Else
            My.Computer.Audio.Play(My.Resources.BB_Fail, AudioPlayMode.Background)
            lblFail.Visible = True
            lblFail.ForeColor = Color.White
            lblFail.BackColor = Color.Transparent
            txtAnswer.Clear()
            txtAnswer.Focus()

        End If
        If chkMute.Checked = True Then
            My.Computer.Audio.Stop()

        End If
    End Sub

    Private Sub frmBrkingMath_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim strProblem As String
        strProblem = Global.breakingmath.My.Resources.txtProb9
        lblResource.Text = strProblem
        lblMrWhite.Visible = False
        lblFail.Visible = False
        lblEql.BackColor = Color.Transparent
        lblResource.BackColor = Color.Transparent
        chkMute.BackColor = Color.Transparent
        chkMute.ForeColor = Color.White















    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub fixBox()
        txtAnswer.Clear()
        txtAnswer.Focus()
        lblResource.BackColor = Color.Transparent


    End Sub




End Class

