<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHints
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
        Me.cmdHintExit = New System.Windows.Forms.Button()
        Me.lblHint = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdHintExit
        '
        Me.cmdHintExit.BackColor = System.Drawing.SystemColors.Control
        Me.cmdHintExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdHintExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdHintExit.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdHintExit.Location = New System.Drawing.Point(135, 163)
        Me.cmdHintExit.Name = "cmdHintExit"
        Me.cmdHintExit.Size = New System.Drawing.Size(194, 47)
        Me.cmdHintExit.TabIndex = 0
        Me.cmdHintExit.Text = "Thank you"
        Me.cmdHintExit.UseVisualStyleBackColor = False
        '
        'lblHint
        '
        Me.lblHint.AutoSize = True
        Me.lblHint.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHint.ForeColor = System.Drawing.Color.Fuchsia
        Me.lblHint.Location = New System.Drawing.Point(57, 72)
        Me.lblHint.Name = "lblHint"
        Me.lblHint.Size = New System.Drawing.Size(0, 24)
        Me.lblHint.TabIndex = 1
        '
        'frmHints
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 238)
        Me.Controls.Add(Me.lblHint)
        Me.Controls.Add(Me.cmdHintExit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmHints"
        Me.ShowIcon = False
        Me.Text = "Hint"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdHintExit As Button
    Friend WithEvents lblHint As Label
End Class
