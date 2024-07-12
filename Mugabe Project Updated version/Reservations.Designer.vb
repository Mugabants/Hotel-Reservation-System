<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reservations
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reservations))
        Me.btnRooms = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnLastRecord = New System.Windows.Forms.Button()
        Me.btnFirstRecord = New System.Windows.Forms.Button()
        Me.btnAddNewRecord = New System.Windows.Forms.Button()
        Me.btnNextRecord = New System.Windows.Forms.Button()
        Me.btnPreviousRecord = New System.Windows.Forms.Button()
        Me.LeavingDate = New System.Windows.Forms.TextBox()
        Me.RESERVATIONSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Hotel_Reservation_DatabaseDataSet = New WindowsApplication1.Hotel_Reservation_DatabaseDataSet()
        Me.ArrivalDate = New System.Windows.Forms.TextBox()
        Me.Surname = New System.Windows.Forms.TextBox()
        Me.FirstName = New System.Windows.Forms.TextBox()
        Me.GuestID = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ReservationsDataGrid = New System.Windows.Forms.DataGridView()
        Me.GuestIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SurnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateOfArrivalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateOfDepartureDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumberOfDaysDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReservationTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomNumber = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Employee = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnPayments = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TotalDays = New System.Windows.Forms.TextBox()
        Me.btnDays = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ROOMSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GuestIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomNumberDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RESERVATIONSTableAdapter = New WindowsApplication1.Hotel_Reservation_DatabaseDataSetTableAdapters.RESERVATIONSTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.Hotel_Reservation_DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.ROOMSTableAdapter = New WindowsApplication1.Hotel_Reservation_DatabaseDataSetTableAdapters.ROOMSTableAdapter()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.search = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        CType(Me.RESERVATIONSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hotel_Reservation_DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReservationsDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ROOMSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRooms
        '
        Me.btnRooms.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnRooms.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRooms.Location = New System.Drawing.Point(422, 377)
        Me.btnRooms.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRooms.Name = "btnRooms"
        Me.btnRooms.Size = New System.Drawing.Size(189, 46)
        Me.btnRooms.TabIndex = 52
        Me.btnRooms.Text = "Reserve Room"
        Me.btnRooms.UseVisualStyleBackColor = False
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.LightSeaGreen
        Me.BtnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.Location = New System.Drawing.Point(300, 503)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(103, 28)
        Me.BtnClose.TabIndex = 51
        Me.BtnClose.Text = "CLOSE"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(189, 503)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(103, 28)
        Me.btnDelete.TabIndex = 50
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(78, 503)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(103, 28)
        Me.btnSave.TabIndex = 49
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnLastRecord
        '
        Me.btnLastRecord.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnLastRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLastRecord.Location = New System.Drawing.Point(189, 467)
        Me.btnLastRecord.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLastRecord.Name = "btnLastRecord"
        Me.btnLastRecord.Size = New System.Drawing.Size(103, 28)
        Me.btnLastRecord.TabIndex = 48
        Me.btnLastRecord.Text = "LAST"
        Me.btnLastRecord.UseVisualStyleBackColor = False
        '
        'btnFirstRecord
        '
        Me.btnFirstRecord.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnFirstRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFirstRecord.Location = New System.Drawing.Point(189, 395)
        Me.btnFirstRecord.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFirstRecord.Name = "btnFirstRecord"
        Me.btnFirstRecord.Size = New System.Drawing.Size(103, 28)
        Me.btnFirstRecord.TabIndex = 47
        Me.btnFirstRecord.Text = "FIRST"
        Me.btnFirstRecord.UseVisualStyleBackColor = False
        '
        'btnAddNewRecord
        '
        Me.btnAddNewRecord.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnAddNewRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNewRecord.Location = New System.Drawing.Point(189, 431)
        Me.btnAddNewRecord.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddNewRecord.Name = "btnAddNewRecord"
        Me.btnAddNewRecord.Size = New System.Drawing.Size(103, 28)
        Me.btnAddNewRecord.TabIndex = 46
        Me.btnAddNewRecord.Text = "ADD NEW"
        Me.btnAddNewRecord.UseVisualStyleBackColor = False
        '
        'btnNextRecord
        '
        Me.btnNextRecord.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnNextRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNextRecord.Location = New System.Drawing.Point(300, 431)
        Me.btnNextRecord.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNextRecord.Name = "btnNextRecord"
        Me.btnNextRecord.Size = New System.Drawing.Size(91, 28)
        Me.btnNextRecord.TabIndex = 45
        Me.btnNextRecord.Text = "NEXT"
        Me.btnNextRecord.UseVisualStyleBackColor = False
        '
        'btnPreviousRecord
        '
        Me.btnPreviousRecord.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnPreviousRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreviousRecord.Location = New System.Drawing.Point(78, 431)
        Me.btnPreviousRecord.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPreviousRecord.Name = "btnPreviousRecord"
        Me.btnPreviousRecord.Size = New System.Drawing.Size(103, 28)
        Me.btnPreviousRecord.TabIndex = 44
        Me.btnPreviousRecord.Text = "PREVIOUS"
        Me.btnPreviousRecord.UseVisualStyleBackColor = False
        '
        'LeavingDate
        '
        Me.LeavingDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RESERVATIONSBindingSource, "Date of Departure", True))
        Me.LeavingDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LeavingDate.Location = New System.Drawing.Point(189, 271)
        Me.LeavingDate.Margin = New System.Windows.Forms.Padding(4)
        Me.LeavingDate.Name = "LeavingDate"
        Me.LeavingDate.Size = New System.Drawing.Size(160, 22)
        Me.LeavingDate.TabIndex = 43
        '
        'RESERVATIONSBindingSource
        '
        Me.RESERVATIONSBindingSource.DataMember = "RESERVATIONS"
        Me.RESERVATIONSBindingSource.DataSource = Me.Hotel_Reservation_DatabaseDataSet
        '
        'Hotel_Reservation_DatabaseDataSet
        '
        Me.Hotel_Reservation_DatabaseDataSet.DataSetName = "Hotel_Reservation_DatabaseDataSet"
        Me.Hotel_Reservation_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ArrivalDate
        '
        Me.ArrivalDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RESERVATIONSBindingSource, "Date of Arrival", True))
        Me.ArrivalDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ArrivalDate.Location = New System.Drawing.Point(189, 239)
        Me.ArrivalDate.Margin = New System.Windows.Forms.Padding(4)
        Me.ArrivalDate.Name = "ArrivalDate"
        Me.ArrivalDate.Size = New System.Drawing.Size(160, 22)
        Me.ArrivalDate.TabIndex = 40
        '
        'Surname
        '
        Me.Surname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RESERVATIONSBindingSource, "Surname", True))
        Me.Surname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Surname.Location = New System.Drawing.Point(189, 207)
        Me.Surname.Margin = New System.Windows.Forms.Padding(4)
        Me.Surname.Name = "Surname"
        Me.Surname.Size = New System.Drawing.Size(160, 22)
        Me.Surname.TabIndex = 39
        '
        'FirstName
        '
        Me.FirstName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RESERVATIONSBindingSource, "FirstName", True))
        Me.FirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstName.Location = New System.Drawing.Point(189, 137)
        Me.FirstName.Margin = New System.Windows.Forms.Padding(4)
        Me.FirstName.Name = "FirstName"
        Me.FirstName.Size = New System.Drawing.Size(160, 22)
        Me.FirstName.TabIndex = 38
        '
        'GuestID
        '
        Me.GuestID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Hotel_Reservation_DatabaseDataSet, "RESERVATIONS.Guest ID", True))
        Me.GuestID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GuestID.Location = New System.Drawing.Point(189, 102)
        Me.GuestID.Margin = New System.Windows.Forms.Padding(4)
        Me.GuestID.Name = "GuestID"
        Me.GuestID.Size = New System.Drawing.Size(160, 22)
        Me.GuestID.TabIndex = 37
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(397, 185)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 16)
        Me.Label10.TabIndex = 36
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(29, 274)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(133, 16)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "DEPARTURE DATE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(29, 239)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 16)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "ARRIVAL DATE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 207)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 16)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "SURNAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 137)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 16)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "FIRST NAME"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 102)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 16)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "GUEST ID"
        '
        'ReservationsDataGrid
        '
        Me.ReservationsDataGrid.AutoGenerateColumns = False
        Me.ReservationsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ReservationsDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.GuestIDDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.SurnameDataGridViewTextBoxColumn, Me.DateOfArrivalDataGridViewTextBoxColumn, Me.DateOfDepartureDataGridViewTextBoxColumn, Me.RoomNumberDataGridViewTextBoxColumn, Me.EmployeeIDDataGridViewTextBoxColumn, Me.NumberOfDaysDataGridViewTextBoxColumn, Me.ReservationTypeDataGridViewTextBoxColumn})
        Me.ReservationsDataGrid.DataSource = Me.RESERVATIONSBindingSource
        Me.ReservationsDataGrid.Location = New System.Drawing.Point(367, 72)
        Me.ReservationsDataGrid.Margin = New System.Windows.Forms.Padding(4)
        Me.ReservationsDataGrid.Name = "ReservationsDataGrid"
        Me.ReservationsDataGrid.Size = New System.Drawing.Size(740, 176)
        Me.ReservationsDataGrid.TabIndex = 53
        '
        'GuestIDDataGridViewTextBoxColumn
        '
        Me.GuestIDDataGridViewTextBoxColumn.DataPropertyName = "Guest ID"
        Me.GuestIDDataGridViewTextBoxColumn.HeaderText = "Guest ID"
        Me.GuestIDDataGridViewTextBoxColumn.Name = "GuestIDDataGridViewTextBoxColumn"
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        '
        'SurnameDataGridViewTextBoxColumn
        '
        Me.SurnameDataGridViewTextBoxColumn.DataPropertyName = "Surname"
        Me.SurnameDataGridViewTextBoxColumn.HeaderText = "Surname"
        Me.SurnameDataGridViewTextBoxColumn.Name = "SurnameDataGridViewTextBoxColumn"
        '
        'DateOfArrivalDataGridViewTextBoxColumn
        '
        Me.DateOfArrivalDataGridViewTextBoxColumn.DataPropertyName = "Date of Arrival"
        Me.DateOfArrivalDataGridViewTextBoxColumn.HeaderText = "Date of Arrival"
        Me.DateOfArrivalDataGridViewTextBoxColumn.Name = "DateOfArrivalDataGridViewTextBoxColumn"
        '
        'DateOfDepartureDataGridViewTextBoxColumn
        '
        Me.DateOfDepartureDataGridViewTextBoxColumn.DataPropertyName = "Date of Departure"
        Me.DateOfDepartureDataGridViewTextBoxColumn.HeaderText = "Date of Departure"
        Me.DateOfDepartureDataGridViewTextBoxColumn.Name = "DateOfDepartureDataGridViewTextBoxColumn"
        '
        'RoomNumberDataGridViewTextBoxColumn
        '
        Me.RoomNumberDataGridViewTextBoxColumn.DataPropertyName = "Room Number"
        Me.RoomNumberDataGridViewTextBoxColumn.HeaderText = "Room Number"
        Me.RoomNumberDataGridViewTextBoxColumn.Name = "RoomNumberDataGridViewTextBoxColumn"
        '
        'EmployeeIDDataGridViewTextBoxColumn
        '
        Me.EmployeeIDDataGridViewTextBoxColumn.DataPropertyName = "Employee ID"
        Me.EmployeeIDDataGridViewTextBoxColumn.HeaderText = "Employee ID"
        Me.EmployeeIDDataGridViewTextBoxColumn.Name = "EmployeeIDDataGridViewTextBoxColumn"
        '
        'NumberOfDaysDataGridViewTextBoxColumn
        '
        Me.NumberOfDaysDataGridViewTextBoxColumn.DataPropertyName = "Number of days"
        Me.NumberOfDaysDataGridViewTextBoxColumn.HeaderText = "Number of days"
        Me.NumberOfDaysDataGridViewTextBoxColumn.Name = "NumberOfDaysDataGridViewTextBoxColumn"
        '
        'ReservationTypeDataGridViewTextBoxColumn
        '
        Me.ReservationTypeDataGridViewTextBoxColumn.DataPropertyName = "Reservation Type"
        Me.ReservationTypeDataGridViewTextBoxColumn.HeaderText = "Reservation Type"
        Me.ReservationTypeDataGridViewTextBoxColumn.Name = "ReservationTypeDataGridViewTextBoxColumn"
        '
        'RoomNumber
        '
        Me.RoomNumber.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RESERVATIONSBindingSource, "Room Number", True))
        Me.RoomNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoomNumber.Location = New System.Drawing.Point(189, 309)
        Me.RoomNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.RoomNumber.Name = "RoomNumber"
        Me.RoomNumber.Size = New System.Drawing.Size(160, 22)
        Me.RoomNumber.TabIndex = 55
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(29, 312)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 16)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "ROOM NUMBER"
        '
        'Employee
        '
        Me.Employee.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RESERVATIONSBindingSource, "Employee ID", True))
        Me.Employee.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Employee.Location = New System.Drawing.Point(32, 35)
        Me.Employee.Margin = New System.Windows.Forms.Padding(4)
        Me.Employee.Name = "Employee"
        Me.Employee.Size = New System.Drawing.Size(220, 22)
        Me.Employee.TabIndex = 56
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(34, 15)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 16)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "EMPLOYEE ID"
        '
        'btnPayments
        '
        Me.btnPayments.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnPayments.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayments.Location = New System.Drawing.Point(422, 431)
        Me.btnPayments.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPayments.Name = "btnPayments"
        Me.btnPayments.Size = New System.Drawing.Size(189, 46)
        Me.btnPayments.TabIndex = 58
        Me.btnPayments.Text = "Payment"
        Me.btnPayments.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(29, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 16)
        Me.Label7.TabIndex = 60
        Me.Label7.Text = "number of days"
        '
        'TotalDays
        '
        Me.TotalDays.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RESERVATIONSBindingSource, "Number of days", True))
        Me.TotalDays.Location = New System.Drawing.Point(189, 76)
        Me.TotalDays.Name = "TotalDays"
        Me.TotalDays.Size = New System.Drawing.Size(160, 22)
        Me.TotalDays.TabIndex = 61
        '
        'btnDays
        '
        Me.btnDays.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnDays.Location = New System.Drawing.Point(176, 361)
        Me.btnDays.Name = "btnDays"
        Me.btnDays.Size = New System.Drawing.Size(131, 28)
        Me.btnDays.TabIndex = 62
        Me.btnDays.Text = "Calculate Days"
        Me.btnDays.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(29, 175)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(144, 16)
        Me.Label9.TabIndex = 63
        Me.Label9.Text = "RESERVATION TYPE"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.RESERVATIONSBindingSource, "Reservation Type", True))
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RESERVATIONSBindingSource, "Reservation Type", True))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Over-Night", "Conferencing", "Hall"})
        Me.ComboBox1.Location = New System.Drawing.Point(189, 175)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(160, 24)
        Me.ComboBox1.TabIndex = 64
        '
        'ROOMSBindingSource
        '
        Me.ROOMSBindingSource.DataMember = "ROOMS"
        Me.ROOMSBindingSource.DataSource = Me.Hotel_Reservation_DatabaseDataSet
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.GuestIDDataGridViewTextBoxColumn1, Me.RoomNumberDataGridViewTextBoxColumn1})
        Me.DataGridView1.DataSource = Me.ROOMSBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(641, 262)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(244, 241)
        Me.DataGridView1.TabIndex = 65
        '
        'GuestIDDataGridViewTextBoxColumn1
        '
        Me.GuestIDDataGridViewTextBoxColumn1.DataPropertyName = "GuestID"
        Me.GuestIDDataGridViewTextBoxColumn1.HeaderText = "GuestID"
        Me.GuestIDDataGridViewTextBoxColumn1.Name = "GuestIDDataGridViewTextBoxColumn1"
        '
        'RoomNumberDataGridViewTextBoxColumn1
        '
        Me.RoomNumberDataGridViewTextBoxColumn1.DataPropertyName = "Room Number"
        Me.RoomNumberDataGridViewTextBoxColumn1.HeaderText = "Room Number"
        Me.RoomNumberDataGridViewTextBoxColumn1.Name = "RoomNumberDataGridViewTextBoxColumn1"
        '
        'RESERVATIONSTableAdapter
        '
        Me.RESERVATIONSTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EMPLOYEESTableAdapter = Nothing
        Me.TableAdapterManager.PAYMENTSTableAdapter = Nothing
        Me.TableAdapterManager.RESERVATIONSTableAdapter = Me.RESERVATIONSTableAdapter
        Me.TableAdapterManager.ROOMSTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.Hotel_Reservation_DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ROOMSTableAdapter
        '
        Me.ROOMSTableAdapter.ClearBeforeFill = True
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(980, 541)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(106, 46)
        Me.btnLogout.TabIndex = 66
        Me.btnLogout.Text = "LogOut"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(824, 26)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(31, 27)
        Me.Button1.TabIndex = 78
        Me.Button1.UseVisualStyleBackColor = True
        '
        'search
        '
        Me.search.Location = New System.Drawing.Point(523, 26)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(169, 22)
        Me.search.TabIndex = 77
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(698, 26)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(120, 27)
        Me.btnSearch.TabIndex = 76
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Reservations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1370, 643)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.search)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnDays)
        Me.Controls.Add(Me.TotalDays)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnPayments)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Employee)
        Me.Controls.Add(Me.RoomNumber)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ReservationsDataGrid)
        Me.Controls.Add(Me.btnRooms)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnLastRecord)
        Me.Controls.Add(Me.btnFirstRecord)
        Me.Controls.Add(Me.btnAddNewRecord)
        Me.Controls.Add(Me.btnNextRecord)
        Me.Controls.Add(Me.btnPreviousRecord)
        Me.Controls.Add(Me.LeavingDate)
        Me.Controls.Add(Me.ArrivalDate)
        Me.Controls.Add(Me.Surname)
        Me.Controls.Add(Me.FirstName)
        Me.Controls.Add(Me.GuestID)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Reservations"
        Me.Text = "Reservations"
        CType(Me.RESERVATIONSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hotel_Reservation_DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReservationsDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ROOMSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRooms As System.Windows.Forms.Button
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnLastRecord As System.Windows.Forms.Button
    Friend WithEvents btnFirstRecord As System.Windows.Forms.Button
    Friend WithEvents btnAddNewRecord As System.Windows.Forms.Button
    Friend WithEvents btnNextRecord As System.Windows.Forms.Button
    Friend WithEvents btnPreviousRecord As System.Windows.Forms.Button
    Friend WithEvents LeavingDate As System.Windows.Forms.TextBox
    Friend WithEvents ArrivalDate As System.Windows.Forms.TextBox
    Friend WithEvents Surname As System.Windows.Forms.TextBox
    Friend WithEvents FirstName As System.Windows.Forms.TextBox
    Friend WithEvents GuestID As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ReservationsDataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents RoomNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Hotel_Reservation_DatabaseDataSet As WindowsApplication1.Hotel_Reservation_DatabaseDataSet
    Friend WithEvents RESERVATIONSTableAdapter As WindowsApplication1.Hotel_Reservation_DatabaseDataSetTableAdapters.RESERVATIONSTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.Hotel_Reservation_DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Employee As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnPayments As System.Windows.Forms.Button
    Friend WithEvents ROOMSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ROOMSTableAdapter As WindowsApplication1.Hotel_Reservation_DatabaseDataSetTableAdapters.ROOMSTableAdapter
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TotalDays As System.Windows.Forms.TextBox
    Friend WithEvents btnDays As System.Windows.Forms.Button
    Friend WithEvents RESERVATIONSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents search As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents GuestIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SurnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateOfArrivalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateOfDepartureDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RoomNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmployeeIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumberOfDaysDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReservationTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GuestIDDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RoomNumberDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
