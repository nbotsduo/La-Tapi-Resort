<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEditHall
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Reser_NameLabel As System.Windows.Forms.Label
        Dim Reser_DurationLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Reser_DateLabel As System.Windows.Forms.Label
        Dim Reser_AddReqLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditHall))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Reser_AddReqTextBox = New System.Windows.Forms.TextBox()
        Me.ReservationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.La_tapi_resortDataSet = New LaTapiResort.la_tapi_resortDataSet()
        Me.Reser_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Reser_DurationTextBox = New System.Windows.Forms.TextBox()
        Me.Reser_NameComboBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ReservationBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ReservationBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ReservationTableAdapter = New LaTapiResort.la_tapi_resortDataSetTableAdapters.ReservationTableAdapter()
        Me.TableAdapterManager = New LaTapiResort.la_tapi_resortDataSetTableAdapters.TableAdapterManager()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Reser_NameLabel = New System.Windows.Forms.Label()
        Reser_DurationLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Reser_DateLabel = New System.Windows.Forms.Label()
        Reser_AddReqLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ReservationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.La_tapi_resortDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ReservationBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ReservationBindingNavigator.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Reser_NameLabel
        '
        Reser_NameLabel.AutoSize = True
        Reser_NameLabel.Location = New System.Drawing.Point(18, 42)
        Reser_NameLabel.Name = "Reser_NameLabel"
        Reser_NameLabel.Size = New System.Drawing.Size(103, 24)
        Reser_NameLabel.TabIndex = 0
        Reser_NameLabel.Text = "Hall Name:"
        '
        'Reser_DurationLabel
        '
        Reser_DurationLabel.AutoSize = True
        Reser_DurationLabel.Location = New System.Drawing.Point(18, 91)
        Reser_DurationLabel.Name = "Reser_DurationLabel"
        Reser_DurationLabel.Size = New System.Drawing.Size(85, 24)
        Reser_DurationLabel.TabIndex = 2
        Reser_DurationLabel.Text = "Duration:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(226, 94)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(40, 24)
        Label1.TabIndex = 4
        Label1.Text = "day"
        '
        'Reser_DateLabel
        '
        Reser_DateLabel.AutoSize = True
        Reser_DateLabel.Location = New System.Drawing.Point(18, 142)
        Reser_DateLabel.Name = "Reser_DateLabel"
        Reser_DateLabel.Size = New System.Drawing.Size(53, 24)
        Reser_DateLabel.TabIndex = 5
        Reser_DateLabel.Text = "Date:"
        '
        'Reser_AddReqLabel
        '
        Reser_AddReqLabel.AutoSize = True
        Reser_AddReqLabel.Location = New System.Drawing.Point(428, 42)
        Reser_AddReqLabel.Name = "Reser_AddReqLabel"
        Reser_AddReqLabel.Size = New System.Drawing.Size(98, 48)
        Reser_AddReqLabel.TabIndex = 7
        Reser_AddReqLabel.Text = "Additional:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Request" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Location = New System.Drawing.Point(0, 31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 59)
        Me.Panel1.TabIndex = 47
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(5, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(246, 40)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Hall Reservation"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(737, 4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(51, 46)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 24
        Me.PictureBox3.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox1.Controls.Add(Reser_AddReqLabel)
        Me.GroupBox1.Controls.Add(Me.Reser_AddReqTextBox)
        Me.GroupBox1.Controls.Add(Reser_DateLabel)
        Me.GroupBox1.Controls.Add(Me.Reser_DateDateTimePicker)
        Me.GroupBox1.Controls.Add(Label1)
        Me.GroupBox1.Controls.Add(Reser_DurationLabel)
        Me.GroupBox1.Controls.Add(Me.Reser_DurationTextBox)
        Me.GroupBox1.Controls.Add(Reser_NameLabel)
        Me.GroupBox1.Controls.Add(Me.Reser_NameComboBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(18, 102)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(770, 203)
        Me.GroupBox1.TabIndex = 46
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Hall Details"
        '
        'Reser_AddReqTextBox
        '
        Me.Reser_AddReqTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReservationBindingSource, "Reser_AddReq", True))
        Me.Reser_AddReqTextBox.Location = New System.Drawing.Point(527, 39)
        Me.Reser_AddReqTextBox.Multiline = True
        Me.Reser_AddReqTextBox.Name = "Reser_AddReqTextBox"
        Me.Reser_AddReqTextBox.Size = New System.Drawing.Size(237, 139)
        Me.Reser_AddReqTextBox.TabIndex = 8
        '
        'ReservationBindingSource
        '
        Me.ReservationBindingSource.DataMember = "Reservation"
        Me.ReservationBindingSource.DataSource = Me.La_tapi_resortDataSet
        '
        'La_tapi_resortDataSet
        '
        Me.La_tapi_resortDataSet.DataSetName = "la_tapi_resortDataSet"
        Me.La_tapi_resortDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Reser_DateDateTimePicker
        '
        Me.Reser_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ReservationBindingSource, "Reser_Date", True))
        Me.Reser_DateDateTimePicker.Location = New System.Drawing.Point(145, 138)
        Me.Reser_DateDateTimePicker.Name = "Reser_DateDateTimePicker"
        Me.Reser_DateDateTimePicker.Size = New System.Drawing.Size(251, 29)
        Me.Reser_DateDateTimePicker.TabIndex = 6
        '
        'Reser_DurationTextBox
        '
        Me.Reser_DurationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReservationBindingSource, "Reser_Duration", True))
        Me.Reser_DurationTextBox.Location = New System.Drawing.Point(145, 91)
        Me.Reser_DurationTextBox.Name = "Reser_DurationTextBox"
        Me.Reser_DurationTextBox.Size = New System.Drawing.Size(70, 29)
        Me.Reser_DurationTextBox.TabIndex = 3
        '
        'Reser_NameComboBox
        '
        Me.Reser_NameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReservationBindingSource, "Reser_Name", True))
        Me.Reser_NameComboBox.FormattingEnabled = True
        Me.Reser_NameComboBox.Items.AddRange(New Object() {"Menanti Bunga Hall ", "Taming Sari", "Cempaka"})
        Me.Reser_NameComboBox.Location = New System.Drawing.Point(145, 39)
        Me.Reser_NameComboBox.Name = "Reser_NameComboBox"
        Me.Reser_NameComboBox.Size = New System.Drawing.Size(251, 32)
        Me.Reser_NameComboBox.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnNext)
        Me.GroupBox3.Controls.Add(Me.btnPrev)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(461, 336)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(299, 84)
        Me.GroupBox3.TabIndex = 45
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Navigation"
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(164, 34)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(110, 32)
        Me.btnNext.TabIndex = 22
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrev
        '
        Me.btnPrev.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrev.Location = New System.Drawing.Point(31, 34)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(110, 32)
        Me.btnPrev.TabIndex = 21
        Me.btnPrev.Text = "Previous"
        Me.btnPrev.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnSave)
        Me.GroupBox2.Controls.Add(Me.btnDel)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(29, 346)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(300, 74)
        Me.GroupBox2.TabIndex = 44
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Editor"
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(31, 28)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(110, 32)
        Me.btnSave.TabIndex = 23
        Me.btnSave.Text = "Update"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDel
        '
        Me.btnDel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDel.Location = New System.Drawing.Point(169, 28)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(110, 32)
        Me.btnDel.TabIndex = 22
        Me.btnDel.Text = "Delete"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel2.Location = New System.Drawing.Point(0, 87)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 233)
        Me.Panel2.TabIndex = 48
        '
        'ReservationBindingNavigator
        '
        Me.ReservationBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ReservationBindingNavigator.BindingSource = Me.ReservationBindingSource
        Me.ReservationBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ReservationBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ReservationBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ReservationBindingNavigatorSaveItem})
        Me.ReservationBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ReservationBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ReservationBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ReservationBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ReservationBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ReservationBindingNavigator.Name = "ReservationBindingNavigator"
        Me.ReservationBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ReservationBindingNavigator.Size = New System.Drawing.Size(802, 25)
        Me.ReservationBindingNavigator.TabIndex = 49
        Me.ReservationBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ReservationBindingNavigatorSaveItem
        '
        Me.ReservationBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ReservationBindingNavigatorSaveItem.Image = CType(resources.GetObject("ReservationBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ReservationBindingNavigatorSaveItem.Name = "ReservationBindingNavigatorSaveItem"
        Me.ReservationBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ReservationBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ReservationTableAdapter
        '
        Me.ReservationTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AdminTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CafeTableAdapter = Nothing
        Me.TableAdapterManager.CustomerTableAdapter = Nothing
        Me.TableAdapterManager.HallTableAdapter = Nothing
        Me.TableAdapterManager.ReservationTableAdapter = Me.ReservationTableAdapter
        Me.TableAdapterManager.RoomTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = LaTapiResort.la_tapi_resortDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 25)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(802, 24)
        Me.MenuStrip1.TabIndex = 50
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.LogOutToolStripMenuItem, Me.ExitToolStripMenuItem1})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.ExitToolStripMenuItem.Text = "Home"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(117, 22)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'frmEditHall
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(802, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.ReservationBindingNavigator)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frmEditHall"
        Me.Text = "Edit Hall"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ReservationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.La_tapi_resortDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.ReservationBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ReservationBindingNavigator.ResumeLayout(False)
        Me.ReservationBindingNavigator.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrev As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDel As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents La_tapi_resortDataSet As la_tapi_resortDataSet
    Friend WithEvents ReservationBindingSource As BindingSource
    Friend WithEvents ReservationTableAdapter As la_tapi_resortDataSetTableAdapters.ReservationTableAdapter
    Friend WithEvents TableAdapterManager As la_tapi_resortDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ReservationBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ReservationBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Reser_NameComboBox As ComboBox
    Friend WithEvents Reser_DurationTextBox As TextBox
    Friend WithEvents Reser_AddReqTextBox As TextBox
    Friend WithEvents Reser_DateDateTimePicker As DateTimePicker
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
End Class
