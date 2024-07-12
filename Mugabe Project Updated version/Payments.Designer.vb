<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Payments
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Payments))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GuestID = New System.Windows.Forms.TextBox()
        Me.PAYMENTSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Hotel_Reservation_DatabaseDataSet = New WindowsApplication1.Hotel_Reservation_DatabaseDataSet()
        Me.DatePaid = New System.Windows.Forms.TextBox()
        Me.receipts = New System.Windows.Forms.TextBox()
        Me.TOTALAM = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnAddNewRecord = New System.Windows.Forms.Button()
        Me.btnPreviousRecord = New System.Windows.Forms.Button()
        Me.btnNextRecord = New System.Windows.Forms.Button()
        Me.btnLastRecord = New System.Windows.Forms.Button()
        Me.btnFirstRecord = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GuestIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReceiptNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountPaidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatePaidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumberOfPeopleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumberOfDaysDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentMethodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.people = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.days = New System.Windows.Forms.TextBox()
        Me.PAYMENTSTableAdapter = New WindowsApplication1.Hotel_Reservation_DatabaseDataSetTableAdapters.PAYMENTSTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.Hotel_Reservation_DatabaseDataSetTableAdapters.TableAdapterManager()
        Me.search = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.GuestIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumberOfDaysDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReservationTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RESERVATIONSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RESERVATIONSTableAdapter = New WindowsApplication1.Hotel_Reservation_DatabaseDataSetTableAdapters.RESERVATIONSTableAdapter()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbpaymentmethod = New System.Windows.Forms.ComboBox()
        Me.Btnclear = New System.Windows.Forms.Button()
        CType(Me.PAYMENTSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hotel_Reservation_DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RESERVATIONSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "DATE PAID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(47, 218)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 13)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "AMOUNT TO BE PAID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "GUEST ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 13)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "RECEIPT NUMBER"
        '
        'GuestID
        '
        Me.GuestID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PAYMENTSBindingSource, "GuestID", True))
        Me.GuestID.Location = New System.Drawing.Point(190, 87)
        Me.GuestID.Name = "GuestID"
        Me.GuestID.Size = New System.Drawing.Size(150, 20)
        Me.GuestID.TabIndex = 41
        '
        'PAYMENTSBindingSource
        '
        Me.PAYMENTSBindingSource.DataMember = "PAYMENTS"
        Me.PAYMENTSBindingSource.DataSource = Me.Hotel_Reservation_DatabaseDataSet
        '
        'Hotel_Reservation_DatabaseDataSet
        '
        Me.Hotel_Reservation_DatabaseDataSet.DataSetName = "Hotel_Reservation_DatabaseDataSet"
        Me.Hotel_Reservation_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DatePaid
        '
        Me.DatePaid.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PAYMENTSBindingSource, "Date Paid", True))
        Me.DatePaid.Location = New System.Drawing.Point(190, 170)
        Me.DatePaid.Name = "DatePaid"
        Me.DatePaid.Size = New System.Drawing.Size(150, 20)
        Me.DatePaid.TabIndex = 40
        '
        'receipts
        '
        Me.receipts.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PAYMENTSBindingSource, "Receipt Number", True))
        Me.receipts.Location = New System.Drawing.Point(190, 61)
        Me.receipts.Name = "receipts"
        Me.receipts.Size = New System.Drawing.Size(150, 20)
        Me.receipts.TabIndex = 39
        '
        'TOTALAM
        '
        Me.TOTALAM.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PAYMENTSBindingSource, "Amount Paid", True))
        Me.TOTALAM.Location = New System.Drawing.Point(190, 218)
        Me.TOTALAM.Name = "TOTALAM"
        Me.TOTALAM.Size = New System.Drawing.Size(150, 20)
        Me.TOTALAM.TabIndex = 38
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnCalculate.Location = New System.Drawing.Point(161, 283)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(132, 23)
        Me.btnCalculate.TabIndex = 37
        Me.btnCalculate.Text = "COST CALCULATE"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnClose.Location = New System.Drawing.Point(287, 424)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(109, 31)
        Me.btnClose.TabIndex = 53
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnDelete.Location = New System.Drawing.Point(161, 423)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(109, 31)
        Me.btnDelete.TabIndex = 52
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnSave.Location = New System.Drawing.Point(46, 425)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(109, 30)
        Me.btnSave.TabIndex = 51
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnAddNewRecord
        '
        Me.btnAddNewRecord.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnAddNewRecord.Location = New System.Drawing.Point(163, 349)
        Me.btnAddNewRecord.Name = "btnAddNewRecord"
        Me.btnAddNewRecord.Size = New System.Drawing.Size(109, 31)
        Me.btnAddNewRecord.TabIndex = 50
        Me.btnAddNewRecord.Text = "ADD NEW"
        Me.btnAddNewRecord.UseVisualStyleBackColor = False
        '
        'btnPreviousRecord
        '
        Me.btnPreviousRecord.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnPreviousRecord.Location = New System.Drawing.Point(39, 349)
        Me.btnPreviousRecord.Name = "btnPreviousRecord"
        Me.btnPreviousRecord.Size = New System.Drawing.Size(109, 31)
        Me.btnPreviousRecord.TabIndex = 49
        Me.btnPreviousRecord.Text = "PREVIOUS"
        Me.btnPreviousRecord.UseVisualStyleBackColor = False
        '
        'btnNextRecord
        '
        Me.btnNextRecord.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnNextRecord.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnNextRecord.Location = New System.Drawing.Point(287, 349)
        Me.btnNextRecord.Name = "btnNextRecord"
        Me.btnNextRecord.Size = New System.Drawing.Size(109, 31)
        Me.btnNextRecord.TabIndex = 48
        Me.btnNextRecord.Text = "NEXT"
        Me.btnNextRecord.UseVisualStyleBackColor = False
        '
        'btnLastRecord
        '
        Me.btnLastRecord.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnLastRecord.Location = New System.Drawing.Point(163, 386)
        Me.btnLastRecord.Name = "btnLastRecord"
        Me.btnLastRecord.Size = New System.Drawing.Size(109, 31)
        Me.btnLastRecord.TabIndex = 47
        Me.btnLastRecord.Text = "LAST"
        Me.btnLastRecord.UseVisualStyleBackColor = False
        '
        'btnFirstRecord
        '
        Me.btnFirstRecord.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnFirstRecord.Location = New System.Drawing.Point(161, 312)
        Me.btnFirstRecord.Name = "btnFirstRecord"
        Me.btnFirstRecord.Size = New System.Drawing.Size(109, 31)
        Me.btnFirstRecord.TabIndex = 46
        Me.btnFirstRecord.Text = "FIRST"
        Me.btnFirstRecord.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.GuestIDDataGridViewTextBoxColumn, Me.ReceiptNumberDataGridViewTextBoxColumn, Me.AmountPaidDataGridViewTextBoxColumn, Me.DatePaidDataGridViewTextBoxColumn, Me.NumberOfPeopleDataGridViewTextBoxColumn, Me.NumberOfDaysDataGridViewTextBoxColumn, Me.PaymentMethodDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PAYMENTSBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(357, 29)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(650, 209)
        Me.DataGridView1.TabIndex = 54
        '
        'GuestIDDataGridViewTextBoxColumn
        '
        Me.GuestIDDataGridViewTextBoxColumn.DataPropertyName = "GuestID"
        Me.GuestIDDataGridViewTextBoxColumn.HeaderText = "GuestID"
        Me.GuestIDDataGridViewTextBoxColumn.Name = "GuestIDDataGridViewTextBoxColumn"
        '
        'ReceiptNumberDataGridViewTextBoxColumn
        '
        Me.ReceiptNumberDataGridViewTextBoxColumn.DataPropertyName = "Receipt Number"
        Me.ReceiptNumberDataGridViewTextBoxColumn.HeaderText = "Receipt Number"
        Me.ReceiptNumberDataGridViewTextBoxColumn.Name = "ReceiptNumberDataGridViewTextBoxColumn"
        '
        'AmountPaidDataGridViewTextBoxColumn
        '
        Me.AmountPaidDataGridViewTextBoxColumn.DataPropertyName = "Amount Paid"
        Me.AmountPaidDataGridViewTextBoxColumn.HeaderText = "Amount Paid"
        Me.AmountPaidDataGridViewTextBoxColumn.Name = "AmountPaidDataGridViewTextBoxColumn"
        '
        'DatePaidDataGridViewTextBoxColumn
        '
        Me.DatePaidDataGridViewTextBoxColumn.DataPropertyName = "Date Paid"
        Me.DatePaidDataGridViewTextBoxColumn.HeaderText = "Date Paid"
        Me.DatePaidDataGridViewTextBoxColumn.Name = "DatePaidDataGridViewTextBoxColumn"
        '
        'NumberOfPeopleDataGridViewTextBoxColumn
        '
        Me.NumberOfPeopleDataGridViewTextBoxColumn.DataPropertyName = "Number of people"
        Me.NumberOfPeopleDataGridViewTextBoxColumn.HeaderText = "Number of people"
        Me.NumberOfPeopleDataGridViewTextBoxColumn.Name = "NumberOfPeopleDataGridViewTextBoxColumn"
        '
        'NumberOfDaysDataGridViewTextBoxColumn
        '
        Me.NumberOfDaysDataGridViewTextBoxColumn.DataPropertyName = "Number of Days"
        Me.NumberOfDaysDataGridViewTextBoxColumn.HeaderText = "Number of Days"
        Me.NumberOfDaysDataGridViewTextBoxColumn.Name = "NumberOfDaysDataGridViewTextBoxColumn"
        '
        'PaymentMethodDataGridViewTextBoxColumn
        '
        Me.PaymentMethodDataGridViewTextBoxColumn.DataPropertyName = "Payment Method"
        Me.PaymentMethodDataGridViewTextBoxColumn.HeaderText = "Payment Method"
        Me.PaymentMethodDataGridViewTextBoxColumn.Name = "PaymentMethodDataGridViewTextBoxColumn"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(47, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 13)
        Me.Label5.TabIndex = 56
        Me.Label5.Text = "NUMBER OF PEOPLE"
        '
        'people
        '
        Me.people.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PAYMENTSBindingSource, "Number of people", True))
        Me.people.Location = New System.Drawing.Point(190, 144)
        Me.people.Name = "people"
        Me.people.Size = New System.Drawing.Size(150, 20)
        Me.people.TabIndex = 55
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(47, 113)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 20)
        Me.Label6.TabIndex = 58
        Me.Label6.Text = "NUMBER OF DAYS"
        '
        'days
        '
        Me.days.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PAYMENTSBindingSource, "Number of people", True))
        Me.days.Location = New System.Drawing.Point(190, 113)
        Me.days.Name = "days"
        Me.days.Size = New System.Drawing.Size(150, 20)
        Me.days.TabIndex = 57
        '
        'PAYMENTSTableAdapter
        '
        Me.PAYMENTSTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EMPLOYEESTableAdapter = Nothing
        Me.TableAdapterManager.PAYMENTSTableAdapter = Me.PAYMENTSTableAdapter
        Me.TableAdapterManager.RESERVATIONSTableAdapter = Nothing
        Me.TableAdapterManager.ROOMSTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.Hotel_Reservation_DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'search
        '
        Me.search.Location = New System.Drawing.Point(12, 12)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(169, 20)
        Me.search.TabIndex = 66
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(187, 12)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(120, 27)
        Me.btnSearch.TabIndex = 65
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.GuestIDDataGridViewTextBoxColumn1, Me.RoomNumberDataGridViewTextBoxColumn, Me.NumberOfDaysDataGridViewTextBoxColumn1, Me.ReservationTypeDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.RESERVATIONSBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(417, 267)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(440, 150)
        Me.DataGridView2.TabIndex = 67
        '
        'GuestIDDataGridViewTextBoxColumn1
        '
        Me.GuestIDDataGridViewTextBoxColumn1.DataPropertyName = "Guest ID"
        Me.GuestIDDataGridViewTextBoxColumn1.HeaderText = "Guest ID"
        Me.GuestIDDataGridViewTextBoxColumn1.Name = "GuestIDDataGridViewTextBoxColumn1"
        '
        'RoomNumberDataGridViewTextBoxColumn
        '
        Me.RoomNumberDataGridViewTextBoxColumn.DataPropertyName = "Room Number"
        Me.RoomNumberDataGridViewTextBoxColumn.HeaderText = "Room Number"
        Me.RoomNumberDataGridViewTextBoxColumn.Name = "RoomNumberDataGridViewTextBoxColumn"
        '
        'NumberOfDaysDataGridViewTextBoxColumn1
        '
        Me.NumberOfDaysDataGridViewTextBoxColumn1.DataPropertyName = "Number of days"
        Me.NumberOfDaysDataGridViewTextBoxColumn1.HeaderText = "Number of days"
        Me.NumberOfDaysDataGridViewTextBoxColumn1.Name = "NumberOfDaysDataGridViewTextBoxColumn1"
        '
        'ReservationTypeDataGridViewTextBoxColumn
        '
        Me.ReservationTypeDataGridViewTextBoxColumn.DataPropertyName = "Reservation Type"
        Me.ReservationTypeDataGridViewTextBoxColumn.HeaderText = "Reservation Type"
        Me.ReservationTypeDataGridViewTextBoxColumn.Name = "ReservationTypeDataGridViewTextBoxColumn"
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
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(915, 437)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(92, 31)
        Me.btnLogout.TabIndex = 68
        Me.btnLogout.Text = "LogOut"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(47, 194)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 13)
        Me.Label7.TabIndex = 70
        Me.Label7.Text = "Payment Method"
        '
        'cmbpaymentmethod
        '
        Me.cmbpaymentmethod.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PAYMENTSBindingSource, "Payment Method", True))
        Me.cmbpaymentmethod.FormattingEnabled = True
        Me.cmbpaymentmethod.Items.AddRange(New Object() {"Cash", "Credit Card", "Eco-Cash"})
        Me.cmbpaymentmethod.Location = New System.Drawing.Point(189, 194)
        Me.cmbpaymentmethod.Name = "cmbpaymentmethod"
        Me.cmbpaymentmethod.Size = New System.Drawing.Size(150, 21)
        Me.cmbpaymentmethod.TabIndex = 71
        '
        'Btnclear
        '
        Me.Btnclear.Location = New System.Drawing.Point(313, 12)
        Me.Btnclear.Name = "Btnclear"
        Me.Btnclear.Size = New System.Drawing.Size(31, 27)
        Me.Btnclear.TabIndex = 72
        Me.Btnclear.UseVisualStyleBackColor = True
        '
        'Payments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1111, 480)
        Me.Controls.Add(Me.Btnclear)
        Me.Controls.Add(Me.cmbpaymentmethod)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.search)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.days)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.people)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnAddNewRecord)
        Me.Controls.Add(Me.btnPreviousRecord)
        Me.Controls.Add(Me.btnNextRecord)
        Me.Controls.Add(Me.btnLastRecord)
        Me.Controls.Add(Me.btnFirstRecord)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GuestID)
        Me.Controls.Add(Me.DatePaid)
        Me.Controls.Add(Me.receipts)
        Me.Controls.Add(Me.TOTALAM)
        Me.Controls.Add(Me.btnCalculate)
        Me.Name = "Payments"
        Me.Text = "Payments"
        CType(Me.PAYMENTSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hotel_Reservation_DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RESERVATIONSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GuestID As System.Windows.Forms.TextBox
    Friend WithEvents DatePaid As System.Windows.Forms.TextBox
    Friend WithEvents receipts As System.Windows.Forms.TextBox
    Friend WithEvents TOTALAM As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnAddNewRecord As System.Windows.Forms.Button
    Friend WithEvents btnPreviousRecord As System.Windows.Forms.Button
    Friend WithEvents btnNextRecord As System.Windows.Forms.Button
    Friend WithEvents btnLastRecord As System.Windows.Forms.Button
    Friend WithEvents btnFirstRecord As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents people As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents days As System.Windows.Forms.TextBox
    Friend WithEvents Hotel_Reservation_DatabaseDataSet As WindowsApplication1.Hotel_Reservation_DatabaseDataSet
    Friend WithEvents PAYMENTSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PAYMENTSTableAdapter As WindowsApplication1.Hotel_Reservation_DatabaseDataSetTableAdapters.PAYMENTSTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.Hotel_Reservation_DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents search As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents RESERVATIONSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RESERVATIONSTableAdapter As WindowsApplication1.Hotel_Reservation_DatabaseDataSetTableAdapters.RESERVATIONSTableAdapter
    Friend WithEvents GuestIDDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RoomNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumberOfDaysDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReservationTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbpaymentmethod As System.Windows.Forms.ComboBox
    Friend WithEvents Btnclear As System.Windows.Forms.Button
    Friend WithEvents GuestIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReceiptNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AmountPaidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatePaidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumberOfPeopleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumberOfDaysDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PaymentMethodDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
