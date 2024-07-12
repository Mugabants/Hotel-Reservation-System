<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Managers_Menu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Managers_Menu))
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnEmployees = New System.Windows.Forms.Button()
        Me.btnRooms = New System.Windows.Forms.Button()
        Me.btnPayments = New System.Windows.Forms.Button()
        Me.btnReservations = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnExit.Location = New System.Drawing.Point(499, 91)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(102, 43)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnEmployees
        '
        Me.btnEmployees.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnEmployees.Location = New System.Drawing.Point(241, 159)
        Me.btnEmployees.Name = "btnEmployees"
        Me.btnEmployees.Size = New System.Drawing.Size(163, 43)
        Me.btnEmployees.TabIndex = 8
        Me.btnEmployees.Text = "EMPLOYEES"
        Me.btnEmployees.UseVisualStyleBackColor = False
        '
        'btnRooms
        '
        Me.btnRooms.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnRooms.Location = New System.Drawing.Point(55, 159)
        Me.btnRooms.Name = "btnRooms"
        Me.btnRooms.Size = New System.Drawing.Size(163, 43)
        Me.btnRooms.TabIndex = 7
        Me.btnRooms.Text = "ROOMS"
        Me.btnRooms.UseVisualStyleBackColor = False
        '
        'btnPayments
        '
        Me.btnPayments.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnPayments.Location = New System.Drawing.Point(241, 81)
        Me.btnPayments.Name = "btnPayments"
        Me.btnPayments.Size = New System.Drawing.Size(163, 43)
        Me.btnPayments.TabIndex = 6
        Me.btnPayments.Text = "PAYMENTS"
        Me.btnPayments.UseVisualStyleBackColor = False
        '
        'btnReservations
        '
        Me.btnReservations.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnReservations.Location = New System.Drawing.Point(55, 81)
        Me.btnReservations.Name = "btnReservations"
        Me.btnReservations.Size = New System.Drawing.Size(163, 43)
        Me.btnReservations.TabIndex = 5
        Me.btnReservations.Text = "RESERVATIONS"
        Me.btnReservations.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnLogout.Location = New System.Drawing.Point(499, 173)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(102, 43)
        Me.btnLogout.TabIndex = 10
        Me.btnLogout.Text = "LOGOUT"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'Managers_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(692, 314)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnEmployees)
        Me.Controls.Add(Me.btnRooms)
        Me.Controls.Add(Me.btnPayments)
        Me.Controls.Add(Me.btnReservations)
        Me.Name = "Managers_Menu"
        Me.Text = "Managers_Menu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnEmployees As System.Windows.Forms.Button
    Friend WithEvents btnRooms As System.Windows.Forms.Button
    Friend WithEvents btnPayments As System.Windows.Forms.Button
    Friend WithEvents btnReservations As System.Windows.Forms.Button
    Friend WithEvents btnLogout As System.Windows.Forms.Button
End Class
