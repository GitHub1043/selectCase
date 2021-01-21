Public Class Form1
    Dim intDay As Integer = 1

    Private Sub btnIfNext_Click(sender As Object, e As EventArgs) Handles btnIfNext.Click
        intDay = intDay + 1

        If (intDay = 8) Then
            intDay = 1
        End If

        If (intDay = 1) Then
            lblDay.Text = "Day: Monday"
            lblWeekday.Text = "Weekday"
        ElseIf (intDay = 2) Then
            lblDay.Text = "Day: Tuesday"
            lblWeekday.Text = "Weekday"
        ElseIf (intDay = 3) Then
            lblDay.Text = "Day: Wednesday"
            lblWeekday.Text = "Weekday"
        ElseIf (intDay = 4) Then
            lblDay.Text = "Day: Thursday"
            lblWeekday.Text = "Weekday"
        ElseIf (intDay = 5) Then
            lblDay.Text = "Day: Friday"
            lblWeekday.Text = "Weekday"
        ElseIf (intDay = 6) Then
            lblDay.Text = "Day: Saturday"
            lblWeekday.Text = "Weekday"
        ElseIf (intDay = 7) Then
            lblDay.Text = "Day: Sunday"
            lblWeekday.Text = "Weekday"
        End If

    End Sub

    Private Sub btnSelectNext_Click(sender As Object, e As EventArgs) Handles btnSelectNext.Click
        intDay = intDay + 1

        'Select Case
        ' usually used for list of options

        intDay = intDay Mod 7 + 1

        Select Case intDay
            Case 1
                lblDay.Text = "Day: Monday"
            Case 2
                lblDay.Text = "Day: Tuesday"
            Case 3
                lblDay.Text = "Day: Wednesday"
            Case 4
                lblDay.Text = "Day: Thursday"
            Case 5
                lblDay.Text = "Day: Friday"
            Case 6
                lblDay.Text = "Day: Saturday"
            Case 7
                lblDay.Text = "Day: Sunday"
        End Select

        Select Case intDay
            Case 6, 7 ' cases listed
                lblWeekday.Text = "Weekend"
            Case Is <= 5 ' works / looks like an if statment
                lblWeekday.Text = "Weekday"
        End Select

    End Sub
End Class
