<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMessage
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
        Me.btnSubFormClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSubFormClose
        '
        Me.btnSubFormClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSubFormClose.Location = New System.Drawing.Point(197, 227)
        Me.btnSubFormClose.Name = "btnSubFormClose"
        Me.btnSubFormClose.Size = New System.Drawing.Size(75, 23)
        Me.btnSubFormClose.TabIndex = 0
        Me.btnSubFormClose.Text = "OK"
        Me.btnSubFormClose.UseVisualStyleBackColor = True
        '
        'frmMessage
        '
        Me.AcceptButton = Me.btnSubFormClose
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnSubFormClose
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSubFormClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMessage"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Correct Answer"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSubFormClose As System.Windows.Forms.Button
End Class
