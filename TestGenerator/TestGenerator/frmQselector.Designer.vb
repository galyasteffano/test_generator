<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQselector
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
        Me.cboNumQs = New System.Windows.Forms.ComboBox()
        Me.lblInfo5 = New System.Windows.Forms.Label()
        Me.cmdBeginTest = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cboNumQs
        '
        Me.cboNumQs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNumQs.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboNumQs.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNumQs.FormattingEnabled = True
        Me.cboNumQs.Location = New System.Drawing.Point(151, 91)
        Me.cboNumQs.Name = "cboNumQs"
        Me.cboNumQs.Size = New System.Drawing.Size(76, 28)
        Me.cboNumQs.TabIndex = 0
        '
        'lblInfo5
        '
        Me.lblInfo5.AutoSize = True
        Me.lblInfo5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo5.Location = New System.Drawing.Point(26, 18)
        Me.lblInfo5.Name = "lblInfo5"
        Me.lblInfo5.Size = New System.Drawing.Size(306, 36)
        Me.lblInfo5.TabIndex = 1
        Me.lblInfo5.Text = "Select the number of questions for your" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " test: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'cmdBeginTest
        '
        Me.cmdBeginTest.BackColor = System.Drawing.SystemColors.Control
        Me.cmdBeginTest.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdBeginTest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdBeginTest.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdBeginTest.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBeginTest.Location = New System.Drawing.Point(114, 174)
        Me.cmdBeginTest.Name = "cmdBeginTest"
        Me.cmdBeginTest.Size = New System.Drawing.Size(148, 44)
        Me.cmdBeginTest.TabIndex = 1
        Me.cmdBeginTest.Text = "Begin Test"
        Me.cmdBeginTest.UseVisualStyleBackColor = False
        '
        'frmQselector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 253)
        Me.Controls.Add(Me.cmdBeginTest)
        Me.Controls.Add(Me.lblInfo5)
        Me.Controls.Add(Me.cboNumQs)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmQselector"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Number of Questions?"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboNumQs As ComboBox
    Friend WithEvents lblInfo5 As Label
    Friend WithEvents cmdBeginTest As Button
End Class
