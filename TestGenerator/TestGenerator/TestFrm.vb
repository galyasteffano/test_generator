Option Explicit On
Public Class TestFrm
    Dim btnClicked As Boolean
    Dim count As Integer = 0

    Private Sub TestFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'read all info from file and close it
        FileOpen(1, "test1.dat", OpenMode.Random,,, Len(test(0)))
        For index As Integer = 0 To MaxNoOfQuestions - 1
            FileGet(1, test(index))
        Next
        FileClose(1)

        currIndex = 0
        ShowQuestion(currIndex + 1)

        For h As Integer = 0 To 9
            userAnswers(h) = "*"
        Next
    End Sub

    Private Sub ShowQuestion(ByVal QuestionNumber As Integer)
        lblQuestion.Text = String.Format("{0}.{1}{2}", QuestionNumber, Space(5), test(QuestionNumber - 1).question)
        optChoiceA.Text = "A. " & test(QuestionNumber - 1).choiceA
        optChoiceB.Text = "B. " & test(QuestionNumber - 1).choiceB
        optChoiceC.Text = "C. " & test(QuestionNumber - 1).choiceC
        optChoiceD.Text = "D. " & test(QuestionNumber - 1).choiceD

        optChoiceA.Checked = False
        optChoiceB.Checked = False
        optChoiceC.Checked = False
        optChoiceD.Checked = False
    End Sub

    Private Sub btnNextQ_Click(sender As Object, e As EventArgs) Handles cmdNextQ.Click
        currIndex = currIndex + 1
        ShowQuestion(currIndex + 1)

        If (currIndex = numSelectedQs - 1) Then
            cmdNextQ.Visible = False
            cmdFinished.Top = cmdNextQ.Top
            cmdFinished.Visible = True
        End If
    End Sub

    Private Sub cmdFinished_Click(sender As Object, e As EventArgs) Handles cmdFinished.Click
        displayTestResults()
    End Sub

    Private Sub displayTestResults()
        Dim title = "Test Results"
        Dim testResults As String
        Dim correctAnswer As Double = 100 / numSelectedQs
        Dim wrongAnswer As Double = correctAnswer / 2
        Dim finalScore As Double = 0
        Dim roundFinalScore As Double = 0
        testResults = "Correct Answer" & Space(19) & "Your Answer" & vbNewLine & vbNewLine
        For index As Integer = 0 To numSelectedQs - 1
            testResults = testResults & Space(6) & test(index).correctAnswer & Space(50) & userAnswers(index) & vbNewLine
            If (test(index).correctAnswer = userAnswers(index)) Then
                finalScore = finalScore + correctAnswer

            Else
                If (userAnswers(index) <> "*") Then
                    finalScore = finalScore - wrongAnswer
                End If
            End If
        Next

        testResults = testResults & vbNewLine & "* indicates that you did not answer the question" & vbNewLine
        testResults = testResults & vbNewLine & vbNewLine & vbNewLine
        testResults = testResults & String.Format("Your score is: {0}", Math.Floor(finalScore))

        MsgBox(testResults, MsgBoxStyle.OkOnly, title)
        MainFrm.Show()
        Me.Hide()
    End Sub

    Private Sub optChoiceA_CheckedChanged(sender As Object, e As EventArgs) Handles optChoiceA.CheckedChanged
        If optChoiceA.Checked Then
            userAnswers(currIndex) = "A"
        End If
    End Sub

    Private Sub optChoiceB_CheckedChanged(sender As Object, e As EventArgs) Handles optChoiceB.CheckedChanged
        If optChoiceB.Checked Then
            userAnswers(currIndex) = "B"
        End If
    End Sub

    Private Sub optChoiceC_CheckedChanged(sender As Object, e As EventArgs) Handles optChoiceC.CheckedChanged
        If optChoiceC.Checked Then
            userAnswers(currIndex) = "C"
        End If
    End Sub

    Private Sub optChoiceD_CheckedChanged(sender As Object, e As EventArgs) Handles optChoiceD.CheckedChanged
        If optChoiceD.Checked Then
            userAnswers(currIndex) = "D"
        End If
    End Sub

    Private Sub cmdHint_Click(sender As Object, e As EventArgs) Handles cmdHint.Click
        frmHints.ShowDialog()
    End Sub

End Class
