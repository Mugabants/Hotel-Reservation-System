<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_Menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_Menu))
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnRooms = New System.Windows.Forms.Button()
        Me.btnPayments = New System.Windows.Forms.Button()
        Me.btnReservations = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.BackgroundImage = CType(resources.GetObject("btnExit.BackgroundImage"), System.Drawing.Image)
        Me.btnExit.Location = New System.Drawing.Point(500, 138)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(141, 51)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnRooms
        '
        Me.btnRooms.BackgroundImage = CType(resources.GetObject("btnRooms.BackgroundImage"), System.Drawing.Image)
        Me.btnRooms.Location = New System.Drawing.Point(66, 209)
        Me.btnRooms.Name = "btnRooms"
        Me.btnRooms.Size = New System.Drawing.Size(193, 36)
        Me.btnRooms.TabIndex = 7
        Me.btnRooms.Text = "ROOMS"
        Me.btnRooms.UseVisualStyleBackColor = True
        '
        'btnPayments
        '
        Me.btnPayments.BackgroundImage = CType(resources.GetObject("btnPayments.BackgroundImage"), System.Drawing.Image)
        Me.btnPayments.Location = New System.Drawing.Point(66, 138)
        Me.btnPayments.Name = "btnPayments"
        Me.btnPayments.Size = New System.Drawing.Size(193, 36)
        Me.btnPayments.TabIndex = 6
        Me.btnPayments.Text = "PAYMENTS"
        Me.btnPayments.UseVisualStyleBackColor = True
        '
        'btnReservations
        '
        Me.btnReservations.BackgroundImage = CType(resources.GetObject("btnReservations.BackgroundImage"), System.Drawing.Image)
        Me.btnReservations.Location = New System.Drawing.Point(66, 64)
        Me.btnReservations.Name = "btnReservations"
        Me.btnReservations.Size = New System.Drawing.Size(193, 36)
        Me.btnReservations.TabIndex = 5
        Me.btnReservations.Text = "RESERVATIONS"
        Me.btnReservations.UseVisualStyleBackColor = True
        '
        'Main_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(734, 436)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnRooms)
        Me.Controls.Add(Me.btnPayments)
        Me.Controls.Add(Me.btnReservations)
        Me.Name = "Main_Menu"
        Me.Text = "Main_Menu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnRooms As System.Windows.Forms.Button
    Friend WithEvents btnPayments As System.Windows.Forms.Button
    Friend WithEvents btnReservations As System.Windows.Forms.Button
End Class
