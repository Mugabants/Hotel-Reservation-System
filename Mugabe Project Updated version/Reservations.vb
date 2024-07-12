Public Class Reservations
    'Validation code to ensure that only text data is entered
    Private Sub TextData(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles FirstName.KeyPress, Surname.KeyPress
        If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then

            e.Handled = True
            MsgBox("Only Text data is allowed in this field", vbCritical)
        Else
            e.Handled = False

        End If

    End Sub
    'Validation code to ensure that only numerical data is entered
    Private Sub Numbers(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TotalDays.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            MsgBox("Only numberical data is allowed in this text box", vbCritical)
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub


    Private Sub btnRooms_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRooms.Click
        Roomss.Show()
        Me.Close()
    End Sub

    Private Sub Reservations_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Hotel_Reservation_DatabaseDataSet1.ROOMS' table. You can move, or remove it, as needed.
        Me.ROOMSTableAdapter.Fill(Me.Hotel_Reservation_DatabaseDataSet.ROOMS)
        'TODO: This line of code loads data into the 'Hotel_Reservation_DatabaseDataSet.RESERVATIONS' table. You can move, or remove it, as needed.
        Me.RESERVATIONSTableAdapter.Fill(Me.Hotel_Reservation_DatabaseDataSet.RESERVATIONS)

        'TODO: This line of code loads data into the 'Hotel_Reservation_DatabaseDataSet.RESERVATIONS' table. You can move, or remove it, as needed.
        Me.RESERVATIONSTableAdapter.Fill(Me.Hotel_Reservation_DatabaseDataSet.RESERVATIONS)

    End Sub

    Private Sub btnFirstRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirstRecord.Click
        RESERVATIONSBindingSource.MoveFirst() 'Goes to the first record in the database file
    End Sub

    Private Sub btnNextRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNextRecord.Click
        RESERVATIONSBindingSource.MoveNext() 'Goes to the next record in the database file
    End Sub

    Private Sub btnLastRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLastRecord.Click
        RESERVATIONSBindingSource.MoveLast() 'Goes to the last record in the database file
    End Sub

    Private Sub btnPreviousRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreviousRecord.Click
        RESERVATIONSBindingSource.MovePrevious() 'Goes to the previous record in the database file
    End Sub

    Private Sub BtnAddNewRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNewRecord.Click
        RESERVATIONSBindingSource.AddNew() 'Adds new record in the database file
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close() 'Closes form
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        RESERVATIONSBindingSource.RemoveCurrent() 'deletes current record in the database file
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If TotalDays.Text > 30 Then
            MsgBox("No Guest is allowed to stay at the hotel for that long, Please adjust the dates!", MsgBoxStyle.Critical)
        Else
            On Error GoTo SaveErr
            RESERVATIONSBindingSource.EndEdit()
            Me.RESERVATIONSTableAdapter.Update(Hotel_Reservation_DatabaseDataSet.RESERVATIONS) 'Updates database, and saves the records
            MsgBox("RECORD SAVED SUCCESSFULLY", MsgBoxStyle.Information)
SaveErr:
            Exit Sub
        End If
    End Sub

    Private Sub btnPayments_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPayments.Click
        Payments.Show() 'Opens payment form
        Me.Close()
    End Sub

    Private Sub RoomAvailabilityDataGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub ReservationsDataGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ReservationsDataGrid.CellContentClick

    End Sub

    Private Sub btnDays_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDays.Click
        Dim diff As Integer
        Dim StartDate, EndDate As Date
        StartDate = ArrivalDate.Text
        EndDate = LeavingDate.Text
        diff = (EndDate - StartDate).TotalDays 'calculates the number of days a guest will stay at the hotel
        TotalDays.Text = diff
    End Sub

    Private Sub RESERVATIONSBindingSource_CurrentChanged(sender As System.Object, e As System.EventArgs) Handles RESERVATIONSBindingSource.CurrentChanged

    End Sub

    Private Sub search_TextChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnLogout.Click
        Login.Show()
        Me.Close()
    End Sub


    Private Sub btnSearch_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Try
            Me.RESERVATIONSBindingSource.Filter = " [GuestID] ' " & search.Text & " ' "
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class
