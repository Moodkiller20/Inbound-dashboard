Public Class rtnDashboard
    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub refreshProgressBarBtn_Click_1(sender As Object, e As EventArgs) Handles refreshProgressBarBtn.Click
        'carryOverProgressBar.Minimum = 0
        'carryOverProgressBar.Maximum = 10000
        'carryOverProgressBar.Value = carryOverLbl.Text

        'previousDayProgressBar.Minimum = 0
        'previousDayProgressBar.Maximum = uphGoal.Text * rtnHours.Text
        ' previousDayProgressBar.Value = previousGoal.Text
        Me.Refresh()
        Application.Restart()
    End Sub

    Private Sub rtnDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ReturnCarryOverDataSet.Trailer' table. You can move, or remove it, as needed.
        Me.TrailerTableAdapter.Fill(Me.ReturnCarryOverDataSet.Trailer)


        If TrailerDataGridView.RowCount > 1 Then

            Dim sum As Integer = 0
            For index As Integer = 0 To TrailerDataGridView.RowCount - 1
                sum += Convert.ToInt32(TrailerDataGridView.Rows(index).Cells(5).Value)

            Next

            carryOverLbl.Text = sum
        End If





        carryOverProgressBar.Minimum = 0
        carryOverProgressBar.Maximum = 100000
        carryOverProgressBar.Value = carryOverLbl.Text


        previousDayProgressBar.Minimum = 0
        previousDayProgressBar.Maximum = uphGoal.Text * rtnHours.Text
        previousDayProgressBar.Value = previousGoal.Text
        loginForm.Hide()
    End Sub

    Private Sub recordTruckBtn_Click(sender As Object, e As EventArgs) Handles recordTruckBtn.Click

        recordTruckForm.Show()
    End Sub

    Private Sub recordGoal_Click(sender As Object, e As EventArgs) Handles recordGoal.Click
        recordEOsForm.Show()
    End Sub

    Private Sub viewDBtn_Click(sender As Object, e As EventArgs) Handles viewDBtn.Click
        viewDetailForm.Show()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub endSessionBtn_Click(sender As Object, e As EventArgs) Handles endSessionBtn.Click
        Application.Exit()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        editTrailer.Show()
    End Sub

    Private Sub TrailerBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TrailerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ReturnCarryOverDataSet)

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.TrailerTableAdapter.FillBy(Me.ReturnCarryOverDataSet.Trailer)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class