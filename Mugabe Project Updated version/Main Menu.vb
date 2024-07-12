Public Class Main_Menu

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub btnPayments_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPayments.Click
        Payments.Show()
    End Sub
    Private Sub btnRooms_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRooms.Click
        Roomss.Show()
    End Sub
    Private Sub btnResevations_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReservations.Click
        Reservations.Show()
    End Sub
End Class