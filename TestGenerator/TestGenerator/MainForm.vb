'Galya Stefanova
'# 1440
'CIS 400 /Project 10



Option Explicit On
Public Class MainFrm
    Private TestStarted As Boolean
    Private started As Boolean

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Application.Exit()
    End Sub

    Private Sub cmdTakeTest_Click(sender As Object, e As EventArgs) Handles cmdTakeTest.Click
        If TestStarted Then

            MessageBox.Show("You already took the test!", "Testing error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            frmQselector.Show()
            Me.Hide()
            TestStarted = True
        End If
    End Sub

    Private Sub cmdWord_Click(sender As Object, e As EventArgs) Handles cmdWord.Click
        If started Then
            MessageBox.Show("You already took the test!", "Testing error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim startTest As New ProcessStartInfo("GettysburgAddress.docx")
            startTest.WindowStyle = ProcessWindowStyle.Maximized
            Process.Start(startTest)
            started = True
        End If


    End Sub

    Private Sub MainFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TestStarted = False
    End Sub
End Class
