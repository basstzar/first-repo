<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBrkingMath
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.lblEql = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblResource = New System.Windows.Forms.Label()
        Me.lblMrWhite = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblFail = New System.Windows.Forms.Label()
        Me.chkMute = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(91, 927)
        Me.Label1.Margin = New System.Windows.Forms.Padding(11, 0, 11, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(245, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Breaking Math"
        '
        'txtAnswer
        '
        Me.txtAnswer.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnswer.Location = New System.Drawing.Point(299, 74)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(75, 36)
        Me.txtAnswer.TabIndex = 2
        '
        'btnCalc
        '
        Me.btnCalc.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.Location = New System.Drawing.Point(230, 143)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(144, 43)
        Me.btnCalc.TabIndex = 3
        Me.btnCalc.Text = "Check Me!"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'lblEql
        '
        Me.lblEql.AutoSize = True
        Me.lblEql.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblEql.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblEql.Location = New System.Drawing.Point(249, 74)
        Me.lblEql.Name = "lblEql"
        Me.lblEql.Size = New System.Drawing.Size(32, 36)
        Me.lblEql.TabIndex = 4
        Me.lblEql.Text = "="
        '
        'lblResource
        '
        Me.lblResource.AllowDrop = True
        Me.lblResource.AutoSize = True
        Me.lblResource.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblResource.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblResource.Location = New System.Drawing.Point(138, 74)
        Me.lblResource.Name = "lblResource"
        Me.lblResource.Size = New System.Drawing.Size(86, 36)
        Me.lblResource.TabIndex = 6
        Me.lblResource.Text = "1 * 1"
        '
        'lblMrWhite
        '
        Me.lblMrWhite.AutoSize = True
        Me.lblMrWhite.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblMrWhite.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMrWhite.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblMrWhite.Location = New System.Drawing.Point(46, 13)
        Me.lblMrWhite.Name = "lblMrWhite"
        Me.lblMrWhite.Size = New System.Drawing.Size(258, 25)
        Me.lblMrWhite.TabIndex = 7
        Me.lblMrWhite.Text = """I Say When It's Over"""
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(414, 268)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 26)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblFail
        '
        Me.lblFail.AllowDrop = True
        Me.lblFail.AutoSize = True
        Me.lblFail.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblFail.Font = New System.Drawing.Font("Elephant", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFail.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblFail.Location = New System.Drawing.Point(159, 189)
        Me.lblFail.Name = "lblFail"
        Me.lblFail.Size = New System.Drawing.Size(277, 62)
        Me.lblFail.TabIndex = 9
        Me.lblFail.Text = "Epic Fail!"
        '
        'chkMute
        '
        Me.chkMute.AllowDrop = True
        Me.chkMute.AutoSize = True
        Me.chkMute.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMute.Location = New System.Drawing.Point(401, 13)
        Me.chkMute.Name = "chkMute"
        Me.chkMute.Size = New System.Drawing.Size(89, 19)
        Me.chkMute.TabIndex = 10
        Me.chkMute.Text = "Mute Audio"
        Me.chkMute.UseVisualStyleBackColor = True
        '
        'frmBrkingMath
        '
        Me.AcceptButton = Me.btnCalc
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(21.0!, 36.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.breakingmath.My.Resources.Resources.breaking_math_bg1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(494, 319)
        Me.Controls.Add(Me.chkMute)
        Me.Controls.Add(Me.lblFail)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblMrWhite)
        Me.Controls.Add(Me.lblResource)
        Me.Controls.Add(Me.lblEql)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.txtAnswer)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Modern No. 20", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(11, 9, 11, 9)
        Me.Name = "frmBrkingMath"
        Me.Text = "Breaking Math"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAnswer As System.Windows.Forms.TextBox
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents lblEql As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents lblResource As System.Windows.Forms.Label
    Friend WithEvents lblMrWhite As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblFail As System.Windows.Forms.Label
    Friend WithEvents chkMute As System.Windows.Forms.CheckBox

End Class
