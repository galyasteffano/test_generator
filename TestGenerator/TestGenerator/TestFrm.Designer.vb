<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TestFrm
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
        Me.cmdNextQ = New System.Windows.Forms.Button()
        Me.optChoiceA = New System.Windows.Forms.RadioButton()
        Me.optChoiceB = New System.Windows.Forms.RadioButton()
        Me.optChoiceC = New System.Windows.Forms.RadioButton()
        Me.optChoiceD = New System.Windows.Forms.RadioButton()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.cmdHint = New System.Windows.Forms.Button()
        Me.lblQuestionImputMessage = New System.Windows.Forms.Label()
        Me.cmdFinished = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdNextQ
        '
        Me.cmdNextQ.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdNextQ.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdNextQ.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdNextQ.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNextQ.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdNextQ.Location = New System.Drawing.Point(385, 269)
        Me.cmdNextQ.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmdNextQ.Name = "cmdNextQ"
        Me.cmdNextQ.Size = New System.Drawing.Size(124, 41)
        Me.cmdNextQ.TabIndex = 1
        Me.cmdNextQ.Text = "Next Question"
        Me.cmdNextQ.UseVisualStyleBackColor = True
        '
        'optChoiceA
        '
        Me.optChoiceA.AutoSize = True
        Me.optChoiceA.Location = New System.Drawing.Point(82, 90)
        Me.optChoiceA.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.optChoiceA.Name = "optChoiceA"
        Me.optChoiceA.Size = New System.Drawing.Size(33, 21)
        Me.optChoiceA.TabIndex = 14
        Me.optChoiceA.Text = " "
        Me.optChoiceA.UseVisualStyleBackColor = True
        '
        'optChoiceB
        '
        Me.optChoiceB.AutoSize = True
        Me.optChoiceB.Location = New System.Drawing.Point(82, 126)
        Me.optChoiceB.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.optChoiceB.Name = "optChoiceB"
        Me.optChoiceB.Size = New System.Drawing.Size(17, 16)
        Me.optChoiceB.TabIndex = 13
        Me.optChoiceB.UseVisualStyleBackColor = True
        '
        'optChoiceC
        '
        Me.optChoiceC.AutoSize = True
        Me.optChoiceC.Location = New System.Drawing.Point(82, 162)
        Me.optChoiceC.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.optChoiceC.Name = "optChoiceC"
        Me.optChoiceC.Size = New System.Drawing.Size(17, 16)
        Me.optChoiceC.TabIndex = 12
        Me.optChoiceC.UseVisualStyleBackColor = True
        '
        'optChoiceD
        '
        Me.optChoiceD.AutoSize = True
        Me.optChoiceD.Location = New System.Drawing.Point(82, 198)
        Me.optChoiceD.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.optChoiceD.Name = "optChoiceD"
        Me.optChoiceD.Size = New System.Drawing.Size(17, 16)
        Me.optChoiceD.TabIndex = 11
        Me.optChoiceD.UseVisualStyleBackColor = True
        '
        'lblQuestion
        '
        Me.lblQuestion.AutoSize = True
        Me.lblQuestion.Location = New System.Drawing.Point(25, 52)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(65, 17)
        Me.lblQuestion.TabIndex = 10
        Me.lblQuestion.Text = "Question"
        '
        'cmdHint
        '
        Me.cmdHint.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cmdHint.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdHint.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdHint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdHint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHint.Location = New System.Drawing.Point(21, 269)
        Me.cmdHint.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmdHint.Name = "cmdHint"
        Me.cmdHint.Size = New System.Drawing.Size(124, 41)
        Me.cmdHint.TabIndex = 2
        Me.cmdHint.Text = "Hint"
        Me.cmdHint.UseVisualStyleBackColor = False
        '
        'lblQuestionImputMessage
        '
        Me.lblQuestionImputMessage.AutoSize = True
        Me.lblQuestionImputMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestionImputMessage.Location = New System.Drawing.Point(11, 7)
        Me.lblQuestionImputMessage.Name = "lblQuestionImputMessage"
        Me.lblQuestionImputMessage.Size = New System.Drawing.Size(198, 17)
        Me.lblQuestionImputMessage.TabIndex = 9
        Me.lblQuestionImputMessage.Text = "Select the correct answer:"
        '
        'cmdFinished
        '
        Me.cmdFinished.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFinished.Location = New System.Drawing.Point(385, 223)
        Me.cmdFinished.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmdFinished.Name = "cmdFinished"
        Me.cmdFinished.Size = New System.Drawing.Size(124, 41)
        Me.cmdFinished.TabIndex = 3
        Me.cmdFinished.Text = "Finished"
        Me.cmdFinished.UseVisualStyleBackColor = True
        Me.cmdFinished.Visible = False
        '
        'TestFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 319)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdFinished)
        Me.Controls.Add(Me.lblQuestionImputMessage)
        Me.Controls.Add(Me.lblQuestion)
        Me.Controls.Add(Me.optChoiceD)
        Me.Controls.Add(Me.optChoiceC)
        Me.Controls.Add(Me.optChoiceB)
        Me.Controls.Add(Me.optChoiceA)
        Me.Controls.Add(Me.cmdNextQ)
        Me.Controls.Add(Me.cmdHint)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TestFrm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "  gps wishes you good luck!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdNextQ As Button
    Friend WithEvents optChoiceA As RadioButton
    Friend WithEvents optChoiceB As RadioButton
    Friend WithEvents optChoiceC As RadioButton
    Friend WithEvents optChoiceD As RadioButton
    Friend WithEvents lblQuestion As Label
    Friend WithEvents cmdHint As Button
    Friend WithEvents lblQuestionImputMessage As Label
    Friend WithEvents cmdFinished As Button
End Class
