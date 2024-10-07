' Program Name: Fitness Tracker App
' Date: September 23, 2024
' Author: K Bola
' Purpose: This program determines the total number of hours users have exercised in their lifetime
Public Class frmFitness
    Private Sub frmFitness_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblResult.Text = ""
        txtFirstName.Focus()
    End Sub
    Private Sub btnCalcHours_Click(sender As Object, e As EventArgs) Handles btnCalcHours.Click
        Dim strFirstName As String = txtFirstName.Text
        Dim birthMonth As Integer = CInt(txtBirthMonth.Text)
        Dim birthDay As Integer = CInt(txtBirthday.Text)
        Dim birthYear As Integer = CInt(txtBirthMonth.Text)
        Dim birthDate As New Date(birthYear, birthMonth, birthDay)
        Dim currentMonth As Integer = CInt(txtCurrentMonth.Text)
        Dim currentDay As Integer = CInt(txtCurrentDay.Text)
        Dim currentYear As Integer = CInt(txtCurrentYear.Text)
        Dim currentDate As New Date(currentYear, currentMonth, currentDay)
        Dim dbltotalDays As Double = (currentDate - birthDate).Days
        Const _cdblWeeklyExerciseHours As Double = 2.5
        Dim intDaysPerWeek As Integer = 7
        Dim dblDailyExerciseHours As Double = _cdblWeeklyExerciseHours / intDaysPerWeek
        Dim dblTotalExerciseHours As Double = dbltotalDays * dblDailyExerciseHours
        lblResult.Text = strFirstName & " has exercised approximately " & dblTotalExerciseHours.ToString("N") & vbCrLf & "hours in " & "lifetime."
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtFirstName.Clear()
        txtBirthday.Clear()
        txtBirthMonth.Clear()
        txtBirthYear.Clear()
        txtCurrentDay.Clear()
        txtCurrentMonth.Clear()
        txtCurrentYear.Clear()
        txtFirstName.Focus()
        lblResult.Text = ""
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
