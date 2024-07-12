Public Class Payments

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        'This code calculates the amount that a guest is supposed to pay

        Dim num_days, totalpay, num_people As Double
        num_days = days.Text
        num_people = people.Text
        totalpay = (num_days * num_people) + 55
        TOTALAM.Text = totalpay
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close() 'closes the form
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        On Error GoTo SaveErr
        PAYMENTSBindingSource.EndEdit()
        PAYMENTSTableAdapter.Update(Hotel_Reservation_DatabaseDataSet.PAYMENTS) 'Updates Database
        MsgBox("Record saved successfully", MsgBoxStyle.OkOnly)

SaveErr:
        Exit Sub
    End Sub
    'Validation code to ensure that only numerical data is entered
    Private Sub Numbers(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TOTALAM.KeyPress, days.KeyPress, people.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            MsgBox("Only numberical data is allowed in this text box", vbCritical)
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub


    Private Sub Payments_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Hotel_Reservation_DatabaseDataSet.RESERVATIONS' table. You can move, or remove it, as needed.
        Me.RESERVATIONSTableAdapter.Fill(Me.Hotel_Reservation_DatabaseDataSet.RESERVATIONS)
        'TODO: This line of code loads data into the 'Hotel_Reservation_DatabaseDataSet.PAYMENTS' table. You can move, or remove it, as needed.
        Me.PAYMENTSTableAdapter.Fill(Me.Hotel_Reservation_DatabaseDataSet.PAYMENTS)

    End Sub

    Private Sub btnFirstRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirstRecord.Click
        PAYMENTSBindingSource.MoveFirst() 'Goes to first record in the database
    End Sub

    Private Sub btnNextRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNextRecord.Click
        PAYMENTSBindingSource.MoveNext() 'Goes to the next record in the database
    End Sub

    Private Sub btnLastRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLastRecord.Click
        PAYMENTSBindingSource.MoveLast() 'Goes to the last record in the database
    End Sub

    Private Sub btnPreviousRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreviousRecord.Click
        PAYMENTSBindingSource.MovePrevious() 'Goes to the previous record in the database
    End Sub

    Private Sub btnAddNewRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNewRecord.Click
        PAYMENTSBindingSource.AddNew() 'Allows user to add new record
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        PAYMENTSBindingSource.RemoveCurrent() 'deletes current record
    End Sub


    Private Sub DatePaid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DatePaid.TextChanged

    End Sub

    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click
        'code for search button in reservations form
        Try
            Me.PAYMENTSBindingSource.Filter = "[GuestID]' " & search.Text & " ' "
        Catch ex As Exception
            MsgBox("Record does not exist", vbCritical)
        End Try


    End Sub

    Private Sub btnLogout_Click(sender As System.Object, e As System.EventArgs) Handles btnLogout.Click
        Login.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnclear.Click
        search.Clear()
        Me.Show()
    End Sub
End Class