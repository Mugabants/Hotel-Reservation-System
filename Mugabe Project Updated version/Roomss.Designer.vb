<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Roomss
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Roomss))
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnAddNewRecord = New System.Windows.Forms.Button()
        Me.btnPreviousRecord = New System.Windows.Forms.Button()
        Me.btnNextRecord = New System.Windows.Forms.Button()
        Me.btnLastRecord = New System.Windows.Forms.Button()
        Me.btnFirstRecord = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ROOMSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Hotel_Reservation_DatabaseDataSet = New WindowsApplication1.Hotel_Reservation_DatabaseDataSet()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.RoomReservationDataGrid = New System.Windows.Forms.DataGridView()
        Me.RoomCapacity = New System.Windows.Forms.TextBox()
        Me.RoomNumber = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ROOMSTableAdapter = New WindowsApplication1.Hotel_Reservation_DatabaseDataSetTableAdapters.ROOMSTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.Hotel_Reservation_DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.GuestID = New System.Windows.Forms.TextBox()
        Me.Availability = New System.Windows.Forms.ComboBox()
        Me.btnReservations = New System.Windows.Forms.Button()
        Me.RESERVATIONSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RESERVATIONSTableAdapter = New WindowsApplication1.Hotel_Reservation_DatabaseDataSetTableAdapters.RESERVATIONSTableAdapter()
        Me.RESERVATIONSDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.RoomNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomCapacityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AvailabilityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GuestIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.ROOMSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hotel_Reservation_DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoomReservationDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RESERVATIONSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RESERVATIONSDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Silver
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(263, 368)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(91, 32)
        Me.btnSave.TabIndex = 59
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnAddNewRecord
        '
        Me.btnAddNewRecord.BackColor = System.Drawing.Color.Silver
        Me.btnAddNewRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNewRecord.Location = New System.Drawing.Point(162, 298)
        Me.btnAddNewRecord.Name = "btnAddNewRecord"
        Me.btnAddNewRecord.Size = New System.Drawing.Size(91, 25)
        Me.btnAddNewRecord.TabIndex = 58
        Me.btnAddNewRecord.Text = "ADD NEW"
        Me.btnAddNewRecord.UseVisualStyleBackColor = False
        '
        'btnPreviousRecord
        '
        Me.btnPreviousRecord.BackColor = System.Drawing.Color.Silver
        Me.btnPreviousRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreviousRecord.Location = New System.Drawing.Point(65, 298)
        Me.btnPreviousRecord.Name = "btnPreviousRecord"
        Me.btnPreviousRecord.Size = New System.Drawing.Size(91, 25)
        Me.btnPreviousRecord.TabIndex = 57
        Me.btnPreviousRecord.Text = "PREVIOUS"
        Me.btnPreviousRecord.UseVisualStyleBackColor = False
        '
        'btnNextRecord
        '
        Me.btnNextRecord.BackColor = System.Drawing.Color.Silver
        Me.btnNextRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNextRecord.Location = New System.Drawing.Point(263, 298)
        Me.btnNextRecord.Name = "btnNextRecord"
        Me.btnNextRecord.Size = New System.Drawing.Size(91, 25)
        Me.btnNextRecord.TabIndex = 56
        Me.btnNextRecord.Text = "NEXT"
        Me.btnNextRecord.UseVisualStyleBackColor = False
        '
        'btnLastRecord
        '
        Me.btnLastRecord.BackColor = System.Drawing.Color.Silver
        Me.btnLastRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLastRecord.Location = New System.Drawing.Point(162, 327)
        Me.btnLastRecord.Name = "btnLastRecord"
        Me.btnLastRecord.Size = New System.Drawing.Size(91, 25)
        Me.btnLastRecord.TabIndex = 55
        Me.btnLastRecord.Text = "LAST"
        Me.btnLastRecord.UseVisualStyleBackColor = False
        '
        'btnFirstRecord
        '
        Me.btnFirstRecord.BackColor = System.Drawing.Color.Silver
        Me.btnFirstRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFirstRecord.Location = New System.Drawing.Point(162, 269)
        Me.btnFirstRecord.Name = "btnFirstRecord"
        Me.btnFirstRecord.Size = New System.Drawing.Size(91, 25)
        Me.btnFirstRecord.TabIndex = 54
        Me.btnFirstRecord.Text = "FIRST"
        Me.btnFirstRecord.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(56, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 16)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "GUEST ID"
        '
        'ROOMSBindingSource
        '
        Me.ROOMSBindingSource.DataMember = "ROOMS"
        Me.ROOMSBindingSource.DataSource = Me.Hotel_Reservation_DatabaseDataSet
        '
        'Hotel_Reservation_DatabaseDataSet
        '
        Me.Hotel_Reservation_DatabaseDataSet.DataSetName = "Hotel_Reservation_DatabaseDataSet"
        Me.Hotel_Reservation_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Silver
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(65, 368)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(91, 32)
        Me.btnClose.TabIndex = 51
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'RoomReservationDataGrid
        '
        Me.RoomReservationDataGrid.AutoGenerateColumns = False
        Me.RoomReservationDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RoomReservationDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RoomNumberDataGridViewTextBoxColumn, Me.RoomCapacityDataGridViewTextBoxColumn, Me.AvailabilityDataGridViewTextBoxColumn, Me.GuestIDDataGridViewTextBoxColumn})
        Me.RoomReservationDataGrid.DataSource = Me.ROOMSBindingSource
        Me.RoomReservationDataGrid.Location = New System.Drawing.Point(399, 57)
        Me.RoomReservationDataGrid.Name = "RoomReservationDataGrid"
        Me.RoomReservationDataGrid.Size = New System.Drawing.Size(444, 207)
        Me.RoomReservationDataGrid.TabIndex = 49
        '
        'RoomCapacity
        '
        Me.RoomCapacity.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ROOMSBindingSource, "Room Capacity", True))
        Me.RoomCapacity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoomCapacity.Location = New System.Drawing.Point(193, 100)
        Me.RoomCapacity.Name = "RoomCapacity"
        Me.RoomCapacity.Size = New System.Drawing.Size(175, 22)
        Me.RoomCapacity.TabIndex = 48
        '
        'RoomNumber
        '
        Me.RoomNumber.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ROOMSBindingSource, "Room Number", True))
        Me.RoomNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoomNumber.Location = New System.Drawing.Point(193, 57)
        Me.RoomNumber.Name = "RoomNumber"
        Me.RoomNumber.Size = New System.Drawing.Size(175, 22)
        Me.RoomNumber.TabIndex = 47
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(50, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 16)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "AVAILABILITY"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(50, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 16)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "ROOM CAPACITY"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(50, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 16)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "ROOM NUMBER"
        '
        'ROOMSTableAdapter
        '
        Me.ROOMSTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EMPLOYEESTableAdapter = Nothing
        Me.TableAdapterManager.PAYMENTSTableAdapter = Nothing
        Me.TableAdapterManager.RESERVATIONSTableAdapter = Nothing
        Me.TableAdapterManager.ROOMSTableAdapter = Me.ROOMSTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.Hotel_Reservation_DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Silver
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(162, 368)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(91, 32)
        Me.btnDelete.TabIndex = 60
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'GuestID
        '
        Me.GuestID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ROOMSBindingSource, "GuestID", True))
        Me.GuestID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GuestID.Location = New System.Drawing.Point(193, 188)
        Me.GuestID.Name = "GuestID"
        Me.GuestID.Size = New System.Drawing.Size(175, 22)
        Me.GuestID.TabIndex = 52
        '
        'Availability
        '
        Me.Availability.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Availability.FormattingEnabled = True
        Me.Availability.Items.AddRange(New Object() {"YES", "NO"})
        Me.Availability.Location = New System.Drawing.Point(193, 143)
        Me.Availability.Name = "Availability"
        Me.Availability.Size = New System.Drawing.Size(175, 24)
        Me.Availability.TabIndex = 61
        '
        'btnReservations
        '
        Me.btnReservations.BackColor = System.Drawing.Color.Silver
        Me.btnReservations.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReservations.Location = New System.Drawing.Point(416, 316)
        Me.btnReservations.Name = "btnReservations"
        Me.btnReservations.Size = New System.Drawing.Size(113, 36)
        Me.btnReservations.TabIndex = 62
        Me.btnReservations.Text = "Reservations"
        Me.btnReservations.UseVisualStyleBackColor = False
        '
        'RESERVATIONSBindingSource
        '
        Me.RESERVATIONSBindingSource.DataMember = "RESERVATIONS"
        Me.RESERVATIONSBindingSource.DataSource = Me.Hotel_Reservation_DatabaseDataSet
        '
        'RESERVATIONSTableAdapter
        '
        Me.RESERVATIONSTableAdapter.ClearBeforeFill = True
        '
        'RESERVATIONSDataGridView
        '
        Me.RESERVATIONSDataGridView.AutoGenerateColumns = False
        Me.RESERVATIONSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RESERVATIONSDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn6})
        Me.RESERVATIONSDataGridView.DataSource = Me.RESERVATIONSBindingSource
        Me.RESERVATIONSDataGridView.Location = New System.Drawing.Point(574, 280)
        Me.RESERVATIONSDataGridView.Name = "RESERVATIONSDataGridView"
        Me.RESERVATIONSDataGridView.Size = New System.Drawing.Size(249, 220)
        Me.RESERVATIONSDataGridView.TabIndex = 62
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Guest ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Guest ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Room Number"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Room Number"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Silver
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(416, 434)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(113, 36)
        Me.btnLogout.TabIndex = 63
        Me.btnLogout.Text = "LogOut"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'RoomNumberDataGridViewTextBoxColumn
        '
        Me.RoomNumberDataGridViewTextBoxColumn.DataPropertyName = "Room Number"
        Me.RoomNumberDataGridViewTextBoxColumn.HeaderText = "Room Number"
        Me.RoomNumberDataGridViewTextBoxColumn.Name = "RoomNumberDataGridViewTextBoxColumn"
        '
        'RoomCapacityDataGridViewTextBoxColumn
        '
        Me.RoomCapacityDataGridViewTextBoxColumn.DataPropertyName = "Room Capacity"
        Me.RoomCapacityDataGridViewTextBoxColumn.HeaderText = "Room Capacity"
        Me.RoomCapacityDataGridViewTextBoxColumn.Name = "RoomCapacityDataGridViewTextBoxColumn"
        '
        'AvailabilityDataGridViewTextBoxColumn
        '
        Me.AvailabilityDataGridViewTextBoxColumn.DataPropertyName = "Availability"
        Me.AvailabilityDataGridViewTextBoxColumn.HeaderText = "Availability"
        Me.AvailabilityDataGridViewTextBoxColumn.Name = "AvailabilityDataGridViewTextBoxColumn"
        '
        'GuestIDDataGridViewTextBoxColumn
        '
        Me.GuestIDDataGridViewTextBoxColumn.DataPropertyName = "GuestID"
        Me.GuestIDDataGridViewTextBoxColumn.HeaderText = "GuestID"
        Me.GuestIDDataGridViewTextBoxColumn.Name = "GuestIDDataGridViewTextBoxColumn"
        '
        'Roomss
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(979, 551)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.RESERVATIONSDataGridView)
        Me.Controls.Add(Me.btnReservations)
        Me.Controls.Add(Me.Availability)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnAddNewRecord)
        Me.Controls.Add(Me.btnPreviousRecord)
        Me.Controls.Add(Me.btnNextRecord)
        Me.Controls.Add(Me.btnLastRecord)
        Me.Controls.Add(Me.btnFirstRecord)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GuestID)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.RoomReservationDataGrid)
        Me.Controls.Add(Me.RoomCapacity)
        Me.Controls.Add(Me.RoomNumber)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Roomss"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Roomss"
        CType(Me.ROOMSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hotel_Reservation_DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoomReservationDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RESERVATIONSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RESERVATIONSDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnAddNewRecord As System.Windows.Forms.Button
    Friend WithEvents btnPreviousRecord As System.Windows.Forms.Button
    Friend WithEvents btnNextRecord As System.Windows.Forms.Button
    Friend WithEvents btnLastRecord As System.Windows.Forms.Button
    Friend WithEvents btnFirstRecord As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents RoomReservationDataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents RoomCapacity As System.Windows.Forms.TextBox
    Friend WithEvents RoomNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Hotel_Reservation_DatabaseDataSet As WindowsApplication1.Hotel_Reservation_DatabaseDataSet
    Friend WithEvents ROOMSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ROOMSTableAdapter As WindowsApplication1.Hotel_Reservation_DatabaseDataSetTableAdapters.ROOMSTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.Hotel_Reservation_DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents GuestID As System.Windows.Forms.TextBox
    Friend WithEvents Availability As System.Windows.Forms.ComboBox
    Friend WithEvents btnReservations As System.Windows.Forms.Button
    Friend WithEvents RESERVATIONSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RESERVATIONSTableAdapter As WindowsApplication1.Hotel_Reservation_DatabaseDataSetTableAdapters.RESERVATIONSTableAdapter
    Friend WithEvents RESERVATIONSDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents RoomNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RoomCapacityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AvailabilityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GuestIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
