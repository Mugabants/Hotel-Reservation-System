Public Class Employees

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub


    Private Sub Employees_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Hotel_Reservation_DatabaseDataSet.EMPLOYEES' table. You can move, or remove it, as needed.
        Me.EMPLOYEESTableAdapter.Fill(Me.Hotel_Reservation_DatabaseDataSet.EMPLOYEES)

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        On Error GoTo SaveErr
        EMPLOYEESBindingSource1.EndEdit()
        EMPLOYEESTableAdapter.Update(Hotel_Reservation_DatabaseDataSet.EMPLOYEES)
        MsgBox("RECORD SAVED SUCCESSFULLY", MsgBoxStyle.Information)
SaveErr:
        Exit Sub
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFirst.Click
        EMPLOYEESBindingSource1.MoveFirst()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNext.Click
        EMPLOYEESBindingSource1.MoveNext()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        EMPLOYEESBindingSource1.MoveLast()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevious.Click
        EMPLOYEESBindingSource1.MovePrevious()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNew.Click
        EMPLOYEESBindingSource1.AddNew()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        EMPLOYEESBindingSource1.RemoveCurrent()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim DV As New DataView
        DV.RowFilter = String.Format("FirstName like '%{0}%'", FirstName.Text)
        DataGridView1.DataSource = DV
    End Sub

    Private Sub DataGridView1_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.DataGridView1.Rows(e.RowIndex)
            employeeID.Text = row.Cells("EmployeeID").Value.ToString
            FirstName.Text = row.Cells("FirstName").Value.ToString
            surname.Text = row.Cells("Surname").Value.ToString
        End If
    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        EMPLOYEESBindingSource1.Filter = "FirstName like '%{0}%'" & FirstName.Text
        DataGridView1.DataSource = Hotel_Reservation_DatabaseDataSet
    End Sub

    Private Sub btnLogout_Click(sender As System.Object, e As System.EventArgs) Handles btnLogout.Click
        Login.Show()
        Me.Close()
    End Sub
End Class