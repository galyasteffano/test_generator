Option Explicit On
Module ControlModule
    Public ten As Integer = 10
    Public nine As Integer = 9
    Public eight As Integer = 8
    Public seven As Integer = 7
    Public six As Integer = 6
    Public five As Integer = 5

    Public numSelectedQs = 0        'stores the number of questions user wants to answer
    Public currIndex = 0            'keep track of the current question

    Structure testQuestion
        <VBFixedString(100)> Public question As String
        <VBFixedString(30)> Public choiceA As String
        <VBFixedString(30)> Public choiceB As String
        <VBFixedString(30)> Public choiceC As String
        <VBFixedString(30)> Public choiceD As String
        <VBFixedString(1)> Public correctAnswer As String
        <VBFixedString(55)> Public hint As String
    End Structure

    Public Const MaxNoOfQuestions = 10
    Public test(MaxNoOfQuestions - 1) As testQuestion
    Public userAnswers(MaxNoOfQuestions) As String       'save user's answers
End Module
