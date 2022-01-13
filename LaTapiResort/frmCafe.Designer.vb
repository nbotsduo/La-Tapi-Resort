<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCafe
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
        Dim Cafe_IDLabel As System.Windows.Forms.Label
        Dim Cafe_NameLabel As System.Windows.Forms.Label
        Dim Cafe_PackageLabel As System.Windows.Forms.Label
        Dim Cafe_PriceLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCafe))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Cafe_PriceTextBox = New System.Windows.Forms.TextBox()
        Me.CafeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.La_tapi_resortDataSet = New LaTapiResort.la_tapi_resortDataSet()
        Me.Cafe_PackageTextBox = New System.Windows.Forms.TextBox()
        Me.Cafe_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Cafe_IDTextBox = New System.Windows.Forms.TextBox()
        Me.CafeTableAdapter = New LaTapiResort.la_tapi_resortDataSetTableAdapters.CafeTableAdapter()
        Me.TableAdapterManager = New LaTapiResort.la_tapi_resortDataSetTableAdapters.TableAdapterManager()
        Me.CafeBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.CafeBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StandardModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Cafe_IDLabel = New System.Windows.Forms.Label()
        Cafe_NameLabel = New System.Windows.Forms.Label()
        Cafe_PackageLabel = New System.Windows.Forms.Label()
        Cafe_PriceLabel = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.CafeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.La_tapi_resortDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CafeBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CafeBindingNavigator.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cafe_IDLabel
        '
        Cafe_IDLabel.AutoSize = True
        Cafe_IDLabel.Location = New System.Drawing.Point(27, 47)
        Cafe_IDLabel.Name = "Cafe_IDLabel"
        Cafe_IDLabel.Size = New System.Drawing.Size(75, 24)
        Cafe_IDLabel.TabIndex = 0
        Cafe_IDLabel.Text = "Cafe ID:"
        '
        'Cafe_NameLabel
        '
        Cafe_NameLabel.AutoSize = True
        Cafe_NameLabel.Location = New System.Drawing.Point(27, 104)
        Cafe_NameLabel.Name = "Cafe_NameLabel"
        Cafe_NameLabel.Size = New System.Drawing.Size(109, 24)
        Cafe_NameLabel.TabIndex = 2
        Cafe_NameLabel.Text = "Cafe Name:"
        '
        'Cafe_PackageLabel
        '
        Cafe_PackageLabel.AutoSize = True
        Cafe_PackageLabel.Location = New System.Drawing.Point(396, 47)
        Cafe_PackageLabel.Name = "Cafe_PackageLabel"
        Cafe_PackageLabel.Size = New System.Drawing.Size(131, 24)
        Cafe_PackageLabel.TabIndex = 4
        Cafe_PackageLabel.Text = "Cafe Package:"
        '
        'Cafe_PriceLabel
        '
        Cafe_PriceLabel.AutoSize = True
        Cafe_PriceLabel.Location = New System.Drawing.Point(396, 101)
        Cafe_PriceLabel.Name = "Cafe_PriceLabel"
        Cafe_PriceLabel.Size = New System.Drawing.Size(101, 24)
        Cafe_PriceLabel.TabIndex = 6
        Cafe_PriceLabel.Text = "Cafe Price:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnSave)
        Me.GroupBox2.Controls.Add(Me.btnDel)
        Me.GroupBox2.Controls.Add(Me.btnAdd)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(19, 320)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(300, 118)
        Me.GroupBox2.TabIndex = 25
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
        Me.GroupBox3.Location = New System.Drawing.Point(478, 348)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(299, 84)
        Me.GroupBox3.TabIndex = 26
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
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox1.Controls.Add(Cafe_PriceLabel)
        Me.GroupBox1.Controls.Add(Me.Cafe_PriceTextBox)
        Me.GroupBox1.Controls.Add(Cafe_PackageLabel)
        Me.GroupBox1.Controls.Add(Me.Cafe_PackageTextBox)
        Me.GroupBox1.Controls.Add(Cafe_NameLabel)
        Me.GroupBox1.Controls.Add(Me.Cafe_NameTextBox)
        Me.GroupBox1.Controls.Add(Cafe_IDLabel)
        Me.GroupBox1.Controls.Add(Me.Cafe_IDTextBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(19, 96)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(769, 184)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cafe Details"
        '
        'Cafe_PriceTextBox
        '
        Me.Cafe_PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CafeBindingSource, "Cafe_Price", True))
        Me.Cafe_PriceTextBox.Location = New System.Drawing.Point(533, 98)
        Me.Cafe_PriceTextBox.Name = "Cafe_PriceTextBox"
        Me.Cafe_PriceTextBox.Size = New System.Drawing.Size(132, 29)
        Me.Cafe_PriceTextBox.TabIndex = 7
        '
        'CafeBindingSource
        '
        Me.CafeBindingSource.DataMember = "Cafe"
        Me.CafeBindingSource.DataSource = Me.La_tapi_resortDataSet
        '
        'La_tapi_resortDataSet
        '
        Me.La_tapi_resortDataSet.DataSetName = "la_tapi_resortDataSet"
        Me.La_tapi_resortDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Cafe_PackageTextBox
        '
        Me.Cafe_PackageTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CafeBindingSource, "Cafe_Package", True))
        Me.Cafe_PackageTextBox.Location = New System.Drawing.Point(533, 44)
        Me.Cafe_PackageTextBox.Name = "Cafe_PackageTextBox"
        Me.Cafe_PackageTextBox.Size = New System.Drawing.Size(200, 29)
        Me.Cafe_PackageTextBox.TabIndex = 5
        '
        'Cafe_NameTextBox
        '
        Me.Cafe_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CafeBindingSource, "Cafe_Name", True))
        Me.Cafe_NameTextBox.Location = New System.Drawing.Point(142, 101)
        Me.Cafe_NameTextBox.Name = "Cafe_NameTextBox"
        Me.Cafe_NameTextBox.Size = New System.Drawing.Size(195, 29)
        Me.Cafe_NameTextBox.TabIndex = 3
        '
        'Cafe_IDTextBox
        '
        Me.Cafe_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CafeBindingSource, "Cafe_ID", True))
        Me.Cafe_IDTextBox.Location = New System.Drawing.Point(142, 42)
        Me.Cafe_IDTextBox.Name = "Cafe_IDTextBox"
        Me.Cafe_IDTextBox.Size = New System.Drawing.Size(114, 29)
        Me.Cafe_IDTextBox.TabIndex = 1
        '
        'CafeTableAdapter
        '
        Me.CafeTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AdminTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CafeTableAdapter = Me.CafeTableAdapter
        Me.TableAdapterManager.CustomerTableAdapter = Nothing
        Me.TableAdapterManager.HallTableAdapter = Nothing
        'Me.TableAdapterManager.PaymentTableAdapter = Nothing
        Me.TableAdapterManager.ReservationTableAdapter = Nothing
        Me.TableAdapterManager.RoomTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = LaTapiResort.la_tapi_resortDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CafeBindingNavigator
        '
        Me.CafeBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CafeBindingNavigator.BindingSource = Me.CafeBindingSource
        Me.CafeBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CafeBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CafeBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CafeBindingNavigatorSaveItem})
        Me.CafeBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CafeBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CafeBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CafeBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CafeBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CafeBindingNavigator.Name = "CafeBindingNavigator"
        Me.CafeBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CafeBindingNavigator.Size = New System.Drawing.Size(801, 25)
        Me.CafeBindingNavigator.TabIndex = 28
        Me.CafeBindingNavigator.Text = "BindingNavigator1"
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
        'CafeBindingNavigatorSaveItem
        '
        Me.CafeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CafeBindingNavigatorSaveItem.Image = CType(resources.GetObject("CafeBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CafeBindingNavigatorSaveItem.Name = "CafeBindingNavigatorSaveItem"
        Me.CafeBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CafeBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Location = New System.Drawing.Point(1, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 59)
        Me.Panel1.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(5, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(215, 40)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Cafe Manager"
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
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 25)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(801, 24)
        Me.MenuStrip1.TabIndex = 30
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
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "Home"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TableModeToolStripMenuItem, Me.StandardModeToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'TableModeToolStripMenuItem
        '
        Me.TableModeToolStripMenuItem.Name = "TableModeToolStripMenuItem"
        Me.TableModeToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.TableModeToolStripMenuItem.Text = "Table Mode"
        '
        'StandardModeToolStripMenuItem
        '
        Me.StandardModeToolStripMenuItem.Name = "StandardModeToolStripMenuItem"
        Me.StandardModeToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.StandardModeToolStripMenuItem.Text = "Standard Mode"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel2.Location = New System.Drawing.Point(1, 81)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 233)
        Me.Panel2.TabIndex = 31
        '
        'frmCafe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.CafeBindingNavigator)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frmCafe"
        Me.Text = "Cafe Management"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.CafeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.La_tapi_resortDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CafeBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CafeBindingNavigator.ResumeLayout(False)
        Me.CafeBindingNavigator.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDel As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrev As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents La_tapi_resortDataSet As la_tapi_resortDataSet
    Friend WithEvents CafeBindingSource As BindingSource
    Friend WithEvents CafeTableAdapter As la_tapi_resortDataSetTableAdapters.CafeTableAdapter
    Friend WithEvents TableAdapterManager As la_tapi_resortDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CafeBindingNavigator As BindingNavigator
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
    Friend WithEvents CafeBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Cafe_PriceTextBox As TextBox
    Friend WithEvents Cafe_PackageTextBox As TextBox
    Friend WithEvents Cafe_NameTextBox As TextBox
    Friend WithEvents Cafe_IDTextBox As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TableModeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StandardModeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PageSetupDialog1 As PageSetupDialog
    Friend WithEvents Panel2 As Panel
End Class
