'Program Name: Galaxy Hotel Occupancy Calculator
' Author:       David Brungardt
'Date:          12/10/2017
' Purpose:      The Galaxy Hotel Occupancy Calculator program
'               allows the user to enter the number of occupied
'               and unoccupied rooms for each floor (up to 7) in
'               the Galaxy Hotel. It then calculates the occupancy
'               rate, and displays the total rooms, occupied rooms
'               unoccupied rooms, and the occupancy rate.

Option Strict On


Public Class frmGalaxyHotel
    Private Sub frmGalaxyHotel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblHeading.Click

    End Sub


    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        ' the mnuClear click event clears the ListBox object and
        ' hides the occupancy rate label, total rooms label, 
        ' occupied rooms label, and unoccupied rooms label. It 
        ' also enables the calculate occupancy button.

        lstGalaxyHotelOccupancy.Items.Clear()
        lblOccupancyRate.Visible = False
        lblTotalRooms.Visible = False
        lblOccupiedRooms.Visible = False
        lblVacantRooms.Visible = False
        btnOccupancyRate.Enabled = True
        btnOccupancyRate.Focus()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        ' the mnuExit clik event closes the window and exits the application

        Close()

    End Sub

    Private Sub btnOccupancyRate_Click(sender As Object, e As EventArgs) Handles btnOccupancyRate.Click
        'This loop allows the user to enter the number of occupied roomas and 
        ' the number of vacant rooms at the Galaxy Hotel for up to 7 floors.
        ' It then calculates and displays the occupancy rate by dividing the 
        'total occupied rooms by the total vacant rooms.

        'Declare and initialize variables

        Dim strOccupiedRooms As String
        Dim decOccupiedRooms As Decimal
        Dim decTotalOccupiedRooms As Decimal = 0D
        Dim strVacantRooms As String
        Dim decVacantRooms As Decimal
        Dim decTotalVacantRooms As Decimal = 0D
        Dim decTotalRooms As Decimal = 0D
        Dim decOccupancyRate As Decimal = 0D

        Dim strInputMessageOccupied As String = "Enter a value for the number of occupied rooms on floor #"
        Dim strInputMessageVacant As String = "Enter a value for the number of vacant rooms on floor #"
        Dim strInputHeading As String = "Occupancy"
        Dim strNormalMessageOccupied As String = "Enter a value for the number of occupied rooms on floor #"
        Dim strNormalMessageVacant As String = "Enter a value for the number of vacant rooms on floor #"
        Dim strNonNumericErrorOccupied As String = "Enter a numeric value for the number of occupied rooms on floor #"
        Dim strNonNumericErrorVacant As String = "Error - Enter a numeric value for the number of vacant rooms on floor #"
        Dim strNegativeErrorOccupied As String = "Error - Enter a positive value for the number of occupied rooms on floor #"
        Dim strNegativeErrorVacant As String = "Error - Enter a positive value for the number of occupied rooms on floor #"

        ' Declare and initialize loop variables
        Dim strCancelClicked As String = ""
        Dim intMaxNumberOfEntriesOccupied As Integer = 7
        Dim intMaxNumberOfEntriesVacant As Integer = 7
        Dim intNumberOfEntriesOccupied As Integer = 1
        Dim intNumberOfEntriesVacant As Integer = 1

        'This loop allows the user to enter the number of occupied
        ' and vacant rooms on each floor of the Galaxy Hotel. 
        ' The loop terminates when the user has entered 7 values
        ' for occupied and 7 values for vacant or when the user
        ' clicks the Cancel button or the Close button in the InputBox.

        strOccupiedRooms = InputBox(strInputMessageOccupied & intNumberOfEntriesOccupied, strInputHeading, "")
        strVacantRooms = InputBox(strInputMessageVacant & intNumberOfEntriesVacant, strInputHeading, "")


        Do Until intNumberOfEntriesOccupied > intMaxNumberOfEntriesOccupied And intNumberOfEntriesVacant > intMaxNumberOfEntriesVacant Or strOccupiedRooms = strCancelClicked Or strVacantRooms = strCancelClicked

            If IsNumeric(strOccupiedRooms) Then
                decOccupiedRooms = Convert.ToDecimal(strOccupiedRooms)

                If decOccupiedRooms > 0 Then

                    If IsNumeric(strVacantRooms) Then
                        decVacantRooms = Convert.ToDecimal(strVacantRooms)

                        If decVacantRooms > 0 Then
                            lstGalaxyHotelOccupancy.Items.Add(decOccupiedRooms & " Occupied  " & decVacantRooms & "  Vacant")
                            decTotalOccupiedRooms += decOccupiedRooms
                            intNumberOfEntriesOccupied += 1
                            decTotalVacantRooms += decVacantRooms
                            intNumberOfEntriesVacant += 1

                        Else
                            strInputMessageVacant = strNegativeErrorVacant
                        End If

                    Else
                        strInputMessageVacant = strNonNumericErrorVacant
                    End If

                Else
                    strInputMessageOccupied = strNegativeErrorOccupied
                End If

            Else
                strInputMessageOccupied = strNonNumericErrorOccupied
            End If

            If intNumberOfEntriesOccupied <= intMaxNumberOfEntriesOccupied Then
                strOccupiedRooms = InputBox(strInputMessageOccupied & intNumberOfEntriesOccupied, strInputHeading, "")
                If intNumberOfEntriesVacant <= intMaxNumberOfEntriesVacant Then
                    strVacantRooms = InputBox(strInputMessageVacant & intNumberOfEntriesVacant, strInputHeading, "")
                End If
            End If
        Loop

        'Calculates and displays total occupied rooms, total vacant rooms, and occupancy rate for Galaxy Hotel

        If intNumberOfEntriesOccupied > 1 Then
            If intNumberOfEntriesVacant > 1 Then
                lblOccupiedRooms.Visible = True
                lblVacantRooms.Visible = True
                lblTotalRooms.Visible = True
                lblOccupancyRate.Visible = True
                decTotalRooms = decTotalOccupiedRooms + decTotalVacantRooms
                decOccupancyRate = (decTotalOccupiedRooms / decTotalRooms) * 100D
                lblOccupiedRooms.Text = "Occupied Rooms: " &
                    decTotalOccupiedRooms
                lblVacantRooms.Text = "Vacant Rooms: " &
                    decTotalVacantRooms
                lblTotalRooms.Text = "Total Rooms: " &
                    decTotalRooms
                lblOccupancyRate.Text = "Occupancy Rate: " &
                    decOccupancyRate.ToString("F1") & "%"
            Else
                MsgBox("No room value entered")

            End If

        Else
            MsgBox("No room value entered")
        End If

        ' Disables the btnOccupancyRate
        btnOccupancyRate.Enabled = False




    End Sub
End Class
