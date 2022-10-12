Imports System.Data.OleDb
Imports System.Data
Public Class recordTruckForm
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

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

    Private Sub recordTruckBtn_Click(sender As Object, e As EventArgs) Handles recordTruckBtn.Click
        MsgBox("You are already in ")
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
            MsgBox("            Record Truck")
        End If

    End Sub

    Private Sub viewDBtn_Click(sender As Object, e As EventArgs) Handles viewDBtn.Click
        'Varial to store yes or no answer
        Dim answer As Integer
        answer = MsgBox("Do you want to close this View ?", vbQuestion + vbYesNo + vbDefaultButton2, "Message Box Title")
        'if yes ? close current window then open new one
        If answer = vbYes Then
            Me.Close()
            viewDetailForm.Show()
            'if no stay on current window
        Else
            MsgBox("            Record Truck")
        End If

    End Sub

    Private Sub recordTruckForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ReturnCarryOverDataSet.Trailer' table. You can move, or remove it, as needed.
        Me.TrailerTableAdapter.Fill(Me.ReturnCarryOverDataSet.Trailer)
        'TODO: This line of code loads data into the 'AppData.truck' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'RecordTruck1DataSet.truck' table. You can move, or remove it, as needed.

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            TrailerBindingSource.EndEdit()
            TrailerTableAdapter.Update(ReturnCarryOverDataSet.Trailer)
            Dim ppe As Double
            Dim carton As Double
            'carton = Val("0" + Carton_CountTextBox.Text)
            'ppe = 1.7
            'Units_CountTextBox.Text = carton * ppe
            'Label1.Text = carton * ppe
            MessageBox.Show("Data Saved")
        Catch ex As Exception
            MessageBox.Show("Error occured while Saving Data")
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        TrailerBindingSource.AddNew()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TrailerBindingSource.RemoveCurrent()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "" Then
            Staging_AreaTextBox.Text = ""
        Else
            Staging_AreaTextBox.Text = ComboBox1.Text
        End If
    End Sub

    Private Sub Carton_CountTextBox_TextChanged(sender As Object, e As EventArgs) Handles Carton_CountTextBox.TextChanged
        Dim ppe As Double
        Dim carton As Double
        carton = Val("0" + Carton_CountTextBox.Text)
        ppe = 1.7
        Units_CountTextBox.Text = carton * ppe


    End Sub
End Class