Public Class Roomss

    Private Sub Roomss_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Hotel_Reservation_DatabaseDataSet.RESERVATIONS' table. You can move, or remove it, as needed.
        Me.RESERVATIONSTableAdapter.Fill(Me.Hotel_Reservation_DatabaseDataSet.RESERVATIONS)
        'TODO: This line of code loads data into the 'Hotel_Reservation_DatabaseDataSet.ROOMS' table. You can move, or remove it, as needed.
        Me.ROOMSTableAdapter.Fill(Me.Hotel_Reservation_DatabaseDataSet.ROOMS)

    End Sub
    'Validation code to ensure that only numerical data is entered
    Private Sub MumericalData(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles RoomCapacity.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            MsgBox("Only numberical data is allowed in this field", vbCritical)
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        On Error GoTo SaveErr
        ROOMSBindingSource.EndEdit()
        ROOMSTableAdapter.Update(Hotel_Reservation_DatabaseDataSet.ROOMS)
        MessageBox.Show("RECORD SAVED SUCCESSFULLY")
SaveErr:
        Exit Sub
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnPreviousRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreviousRecord.Click
        ROOMSBindingSource.MovePrevious()
    End Sub

    Private Sub btnNextRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNextRecord.Click
        ROOMSBindingSource.MoveNext()
    End Sub

    Private Sub btnFirstRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirstRecord.Click
        ROOMSBindingSource.MoveFirst()
    End Sub

    Private Sub btnLastRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLastRecord.Click
        ROOMSBindingSource.MoveLast()
    End Sub

    Private Sub btnAddNewRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNewRecord.Click
        ROOMSBindingSource.AddNew()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        ROOMSBindingSource.RemoveCurrent()
    End Sub

    Private Sub btnReservations_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReservations.Click
        Reservations.Show()
        Me.Close()
    End Sub

    Private Sub RoomReservationsDataGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles RoomReservationDataGrid.CellContentClick

    End Sub

    Private Sub btnLogout_Click(sender As System.Object, e As System.EventArgs) Handles btnLogout.Click
        Login.Show()
        Me.Close()
    End Sub
End Class