Public Class Managers_Menu

    Private Sub btnReservation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReservations.Click
        Reservations.Show()
        Me.Close()
    End Sub

    Private Sub btnRooms_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRooms.Click
        Roomss.Show()
        Me.Close()
    End Sub

    Private Sub btnPayments_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPayments.Click
        Payments.Show()
        Me.Close()
    End Sub

    Private Sub btnEmployees_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmployees.Click
        Employees.Show()
        Me.Close()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogout.Click
        Login.Show()
        Me.Close()
    End Sub
End Class