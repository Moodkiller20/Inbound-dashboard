Public Class recordEOsForm

    Private Sub recordTruckBtn_Click(sender As Object, e As EventArgs) Handles recordTruckBtn.Click
        'Varial to store yes or no answer
        Dim answer As Integer
        answer = MsgBox("Do you want to close this View ?", vbQuestion + vbYesNo + vbDefaultButton2, "Message Box Title")
        'if yes ? close current window hen open new one
        If answer = vbYes Then
            Me.Close()
            recordTruckForm.Show()
            'if no stay on current window
        Else
            MsgBox("            Record EOS")
        End If


    End Sub

    Private Sub recordGoal_Click(sender As Object, e As EventArgs) Handles recordGoal.Click
        MsgBox("You are already in")

    End Sub

    Private Sub viewDBtn_Click(sender As Object, e As EventArgs) Handles viewDBtn.Click
        'Varial to store yes or no answer
        Dim answer As Integer
        answer = MsgBox("Do you want to close this View ?", vbQuestion + vbYesNo + vbDefaultButton2, "Message Box Title")
        'if yes ? close current window hen open new one
        If answer = vbYes Then
            Me.Close()
            viewDetailForm.Show()
            'if no stay on current window
        Else
            MsgBox("            Record EOS")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Varial to store yes or no answer
        Dim answer As Integer
        answer = MsgBox("Do you want to cancel ?", vbQuestion + vbYesNo + vbDefaultButton2, "Message Box Title")
        'if yes ? close current window hen open new one
        If answer = vbYes Then
            Me.Close()

            'if no stay on current window
        Else
            MsgBox("            Record EOS")
        End If
    End Sub
End Class