Option Explicit On
Public Class frmHints

    Private Sub frmHints_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblHint.Text = test(currIndex).hint
    End Sub

    Private Sub cmdHintExit_Click(sender As Object, e As EventArgs) Handles cmdHintExit.Click
        If (currIndex = numSelectedQs) Then
            cmdHintExit.Select()
        End If
        Me.Hide()
    End Sub
End Class