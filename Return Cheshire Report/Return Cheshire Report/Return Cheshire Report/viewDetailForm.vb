Public Class viewDetailForm



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
            MsgBox("            View Report")
        End If
    End Sub

    Private Sub recordGoal_Click(sender As Object, e As EventArgs) Handles recordGoal.Click
        'Varial to store yes or no answer
        Dim answer As Integer
        answer = MsgBox("Do you want to close this View ?", vbQuestion + vbYesNo + vbDefaultButton2, "Message Box Title")
        'if yes ? close current window hen open new one
        If answer = vbYes Then
            Me.Close()
            recordEOsForm.Show()
            'if no stay on current window
        Else
            MsgBox("            View Report")
        End If

    End Sub

    Private Sub viewDBtn_Click(sender As Object, e As EventArgs) Handles viewDBtn.Click
        MsgBox("You are already in ")

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub viewDetailForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ReturnCarryOverDataSet.Trailer' table. You can move, or remove it, as needed.
        Me.TrailerTableAdapter.Fill(Me.ReturnCarryOverDataSet.Trailer)
        'TODO: This line of code loads data into the 'ReturnCarryOverDataSet.employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me.ReturnCarryOverDataSet.employee)


        If TrailerDataGridView.RowCount > 1 Then

            Dim sum As Integer = 0
            For index As Integer = 0 To TrailerDataGridView.RowCount - 1
                sum += Convert.ToInt32(TrailerDataGridView.Rows(index).Cells(6).Value)

            Next

            Label6.Text = sum
        End If







    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class