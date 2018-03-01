
Option Explicit On
Public Class frmQselector

    Private Sub cmdBeginTest_Click(sender As Object, e As EventArgs) Handles cmdBeginTest.Click

        TestFrm.Show()
        Me.Hide()
    End Sub

    Private Sub frmQselector_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboNumQs.Items.Add(five)
        cboNumQs.Items.Add(six)
        cboNumQs.Items.Add(seven)
        cboNumQs.Items.Add(eight)
        cboNumQs.Items.Add(nine)
        cboNumQs.Items.Add(ten)
        cboNumQs.SelectedIndex = 5 'displays 10 w/o moving it up
        cmdBeginTest.Select()
    End Sub
    Private Sub cboNumQs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNumQs.SelectedIndexChanged
        numSelectedQs = cboNumQs.SelectedItem()

    End Sub
End Class