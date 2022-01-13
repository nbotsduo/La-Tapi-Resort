<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmhotel
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
        Dim Room_IDLabel As System.Windows.Forms.Label
        Dim Room_NameLabel As System.Windows.Forms.Label
        Dim Room_PriceLabel As System.Windows.Forms.Label
        Dim Room_DescLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmhotel))
        Me.RoomBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.La_tapi_resortDataSet = New LaTapiResort.la_tapi_resortDataSet()
        Me.RoomTableAdapter = New LaTapiResort.la_tapi_resortDataSetTableAdapters.RoomTableAdapter()
        Me.TableAdapterManager = New LaTapiResort.la_tapi_resortDataSetTableAdapters.TableAdapterManager()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.RoomBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.RoomBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Room_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Room_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Room_PriceTextBox = New System.Windows.Forms.TextBox()
        Me.Room_DescTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Room_IDLabel = New System.Windows.Forms.Label()
        Room_NameLabel = New System.Windows.Forms.Label()
        Room_PriceLabel = New System.Windows.Forms.Label()
        Room_DescLabel = New System.Windows.Forms.Label()
        CType(Me.RoomBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.La_tapi_resortDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.RoomBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RoomBindingNavigator.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Room_IDLabel
        '
        Room_IDLabel.AutoSize = True
        Room_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Room_IDLabel.Location = New System.Drawing.Point(27, 33)
        Room_IDLabel.Name = "Room_IDLabel"
        Room_IDLabel.Size = New System.Drawing.Size(88, 24)
        Room_IDLabel.TabIndex = 0
        Room_IDLabel.Text = "Room ID:"
        '
        'Room_NameLabel
        '
        Room_NameLabel.AutoSize = True
        Room_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Room_NameLabel.Location = New System.Drawing.Point(27, 74)
        Room_NameLabel.Name = "Room_NameLabel"
        Room_NameLabel.Size = New System.Drawing.Size(122, 24)
        Room_NameLabel.TabIndex = 2
        Room_NameLabel.Text = "Room Name:"
        '
        'Room_PriceLabel
        '
        Room_PriceLabel.AutoSize = True
        Room_PriceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Room_PriceLabel.Location = New System.Drawing.Point(27, 119)
        Room_PriceLabel.Name = "Room_PriceLabel"
        Room_PriceLabel.Size = New System.Drawing.Size(119, 48)
        Room_PriceLabel.TabIndex = 4
        Room_PriceLabel.Text = "Room Price: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(RM)"
        '
        'Room_DescLabel
        '
        Room_DescLabel.AutoSize = True
        Room_DescLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Room_DescLabel.Location = New System.Drawing.Point(371, 33)
        Room_DescLabel.Name = "Room_DescLabel"
        Room_DescLabel.Size = New System.Drawing.Size(104, 48)
        Room_DescLabel.TabIndex = 6
        Room_DescLabel.Text = "Room     :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Description"
        '
        'RoomBindingSource
        '
        Me.RoomBindingSource.DataMember = "Room"
        Me.RoomBindingSource.DataSource = Me.La_tapi_resortDataSet
        '
        'La_tapi_resortDataSet
        '
        Me.La_tapi_resortDataSet.DataSetName = "la_tapi_resortDataSet"
        Me.La_tapi_resortDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RoomTableAdapter
        '
        Me.RoomTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AdminTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CafeTableAdapter = Nothing
        Me.TableAdapterManager.CustomerTableAdapter = Nothing
        Me.TableAdapterManager.HallTableAdapter = Nothing
        'Me.TableAdapterManager.PaymentTableAdapter = Nothing
        Me.TableAdapterManager.ReservationTableAdapter = Nothing
        Me.TableAdapterManager.RoomTableAdapter = Me.RoomTableAdapter
        Me.TableAdapterManager.UpdateOrder = LaTapiResort.la_tapi_resortDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnSave)
        Me.GroupBox2.Controls.Add(Me.btnDel)
        Me.GroupBox2.Controls.Add(Me.btnAdd)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(19, 311)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(300, 118)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Editor"
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(165, 34)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(110, 32)
        Me.btnSave.TabIndex = 23
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDel
        '
        Me.btnDel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDel.Location = New System.Drawing.Point(31, 80)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(110, 32)
        Me.btnDel.TabIndex = 22
        Me.btnDel.Text = "Delete"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(31, 34)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(110, 32)
        Me.btnAdd.TabIndex = 21
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnNext)
        Me.GroupBox3.Controls.Add(Me.btnPrev)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(478, 345)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(299, 84)
        Me.GroupBox3.TabIndex = 21
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
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
        'RoomBindingNavigatorSaveItem
        '
        Me.RoomBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RoomBindingNavigatorSaveItem.Image = CType(resources.GetObject("RoomBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.RoomBindingNavigatorSaveItem.Name = "RoomBindingNavigatorSaveItem"
        Me.RoomBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.RoomBindingNavigatorSaveItem.Text = "Save Data"
        '
        'RoomBindingNavigator
        '
        Me.RoomBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.RoomBindingNavigator.BindingSource = Me.RoomBindingSource
        Me.RoomBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.RoomBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.RoomBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.RoomBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.RoomBindingNavigatorSaveItem})
        Me.RoomBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.RoomBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.RoomBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.RoomBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.RoomBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.RoomBindingNavigator.Name = "RoomBindingNavigator"
        Me.RoomBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.RoomBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.RoomBindingNavigator.TabIndex = 19
        Me.RoomBindingNavigator.Text = "BindingNavigator1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Location = New System.Drawing.Point(0, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 59)
        Me.Panel1.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(5, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(237, 40)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Room Manager"
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
        'Room_IDTextBox
        '
        Me.Room_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RoomBindingSource, "Room_ID", True))
        Me.Room_IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Room_IDTextBox.Location = New System.Drawing.Point(155, 30)
        Me.Room_IDTextBox.Name = "Room_IDTextBox"
        Me.Room_IDTextBox.Size = New System.Drawing.Size(64, 29)
        Me.Room_IDTextBox.TabIndex = 1
        '
        'Room_NameTextBox
        '
        Me.Room_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RoomBindingSource, "Room_Name", True))
        Me.Room_NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Room_NameTextBox.Location = New System.Drawing.Point(155, 71)
        Me.Room_NameTextBox.Name = "Room_NameTextBox"
        Me.Room_NameTextBox.Size = New System.Drawing.Size(196, 29)
        Me.Room_NameTextBox.TabIndex = 3
        '
        'Room_PriceTextBox
        '
        Me.Room_PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RoomBindingSource, "Room_Price", True))
        Me.Room_PriceTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Room_PriceTextBox.Location = New System.Drawing.Point(155, 119)
        Me.Room_PriceTextBox.Name = "Room_PriceTextBox"
        Me.Room_PriceTextBox.Size = New System.Drawing.Size(145, 29)
        Me.Room_PriceTextBox.TabIndex = 5
        '
        'Room_DescTextBox
        '
        Me.Room_DescTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RoomBindingSource, "Room_Desc", True))
        Me.Room_DescTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Room_DescTextBox.Location = New System.Drawing.Point(491, 30)
        Me.Room_DescTextBox.Multiline = True
        Me.Room_DescTextBox.Name = "Room_DescTextBox"
        Me.Room_DescTextBox.Size = New System.Drawing.Size(228, 133)
        Me.Room_DescTextBox.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Room_DescLabel)
        Me.GroupBox1.Controls.Add(Me.Room_DescTextBox)
        Me.GroupBox1.Controls.Add(Room_PriceLabel)
        Me.GroupBox1.Controls.Add(Me.Room_PriceTextBox)
        Me.GroupBox1.Controls.Add(Room_NameLabel)
        Me.GroupBox1.Controls.Add(Me.Room_NameTextBox)
        Me.GroupBox1.Controls.Add(Room_IDLabel)
        Me.GroupBox1.Controls.Add(Me.Room_IDTextBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(758, 180)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Room Details"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem1, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 25)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 24
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem1
        '
        Me.FileToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.LogOutToolStripMenuItem1, Me.ExitToolStripMenuItem2})
        Me.FileToolStripMenuItem1.Name = "FileToolStripMenuItem1"
        Me.FileToolStripMenuItem1.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem1.Text = "File"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'LogOutToolStripMenuItem1
        '
        Me.LogOutToolStripMenuItem1.Name = "LogOutToolStripMenuItem1"
        Me.LogOutToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.LogOutToolStripMenuItem1.Text = "Log Out"
        '
        'ExitToolStripMenuItem2
        '
        Me.ExitToolStripMenuItem2.Name = "ExitToolStripMenuItem2"
        Me.ExitToolStripMenuItem2.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem2.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Location = New System.Drawing.Point(0, 86)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(797, 219)
        Me.Panel2.TabIndex = 25
        '
        'frmhotel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.RoomBindingNavigator)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frmhotel"
        Me.Text = "Room Management"
        CType(Me.RoomBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.La_tapi_resortDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.RoomBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RoomBindingNavigator.ResumeLayout(False)
        Me.RoomBindingNavigator.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents La_tapi_resortDataSet As la_tapi_resortDataSet
    Friend WithEvents RoomBindingSource As BindingSource
    Friend WithEvents RoomTableAdapter As la_tapi_resortDataSetTableAdapters.RoomTableAdapter
    Friend WithEvents TableAdapterManager As la_tapi_resortDataSetTableAdapters.TableAdapterManager
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnDel As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrev As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents RoomBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents RoomBindingNavigator As BindingNavigator
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Room_IDTextBox As TextBox
    Friend WithEvents Room_NameTextBox As TextBox
    Friend WithEvents Room_PriceTextBox As TextBox
    Friend WithEvents Room_DescTextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Panel2 As Panel
    Friend WithEvents FileToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
End Class
