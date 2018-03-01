''' <summary>
''' Author:Jacob Dainard
''' Project Name: AverageUnitsShipped
''' Date: 06-Feb-2018
''' Description: Application that stores number of units sold per day into array 
''' this is done for 7 days
''' </summary>
Public Class frmLab1
    Dim units As Integer    'variable to store user input
    Dim day As Integer      'variable that stores what day it is
    Dim weeklyUnits(6) As Integer   'array that stors the units for each day
    Dim average As Decimal  'variable is used to store the average of the array




    Private Sub frmLab1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaximizeBox = False 'when the form is loaded the maximize box will not show at the top right of window
        MinimizeBox = False 'when the form is loaded the minimize box will not show at the top right of window
        day = 0 ' day is set to zero

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close() 'exit button closes the form and application
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        tbUnits.Focus()
        'data validation 
        If (Integer.TryParse(tbUnits.Text, units)) = False Then 'stores user input in units
            MessageBox.Show("Error units entered not acceptable")
            'if units are not numeric will show error message
        ElseIf (Integer.TryParse(tbUnits.Text, units)) = True Then 'if units are numeric will increase day
            day = day + 1
            lblDay.Text = day 'updates day display to show increased number
        End If

        'main if chain
        If (day = 1) Then 'checks to see if day is 1
            weeklyUnits(0) = units 'store units into array for day 1
            tbDisplay.Text = tbDisplay.Text & weeklyUnits(0) & vbNewLine
            'gets Text from textbox before then displays units then newline
        ElseIf (day = 2) Then 'checks to see if day is 2
            weeklyUnits(1) = units 'store units into array for day 2
            tbDisplay.Text = tbDisplay.Text & weeklyUnits(1) & vbNewLine
            'gets Text from textbox before then displays units then newline
        ElseIf (day = 3) Then 'checks to see if day is 3
            weeklyUnits(2) = units 'store units into array for day 3
            tbDisplay.Text = tbDisplay.Text & weeklyUnits(2) & vbNewLine
            'gets Text from textbox before then displays units then newline
        ElseIf (day = 4) Then 'checks to see if day is 4
            weeklyUnits(3) = units 'store units into array for day 4
            tbDisplay.Text = tbDisplay.Text & weeklyUnits(3) & vbNewLine
            'gets Text from textbox before then displays units then newline
        ElseIf (day = 5) Then 'checks to see if day is 5
            weeklyUnits(4) = units 'store units into array for day 5
            tbDisplay.Text = tbDisplay.Text & weeklyUnits(4) & vbNewLine
            'gets Text from textbox before then displays units then newline
        ElseIf (day = 6) Then 'checks to see if day is 6
            weeklyUnits(5) = units 'store units into array for day 6
            tbDisplay.Text = tbDisplay.Text & weeklyUnits(5) & vbNewLine
            'gets Text from textbox before then displays units then newline
        ElseIf (day = 7) Then 'checks to see if day is 7
            weeklyUnits(6) = units 'store units into array for day 7
            tbDisplay.Text = tbDisplay.Text & weeklyUnits(6) & vbNewLine
            'gets Text from textbox before then displays units then newline
        ElseIf (day > 7) Then 'if the day goes over 7 it will display error message
            MessageBox.Show("7 days are over")
            day = 7 'set the days back to 7 so it cant increase anymore
            lblDay.Text = day 'updates day label
            btnEnter.Enabled = False 'makes enter button not enabled so it cant be clicked any more
        End If

        'calculations
        average = weeklyUnits.Average 'using the averge method bulit in with arrays
        'store array average in varible average
        lblAverageDisplay.Text = average 'displays average



    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'reset button
        day = 0 'makes the day zero
        tbDisplay.Clear() 'clear all text from the display textbox
        tbUnits.Clear()     'clear all text from the user input textbox
        lblAverageDisplay.Text = "" 'changes text is dislay average label to have blank text
        btnEnter.Enabled = True 'make enter button able to click again

    End Sub
End Class
