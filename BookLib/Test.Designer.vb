<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Test
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
        Dim BookIDLabel As System.Windows.Forms.Label
        Dim BookNameLabel As System.Windows.Forms.Label
        Dim AuthorIDLabel As System.Windows.Forms.Label
        Dim FileTypeIDLabel As System.Windows.Forms.Label
        Dim AuthorIDLabel1 As System.Windows.Forms.Label
        Dim AuthorNameLabel As System.Windows.Forms.Label
        Dim AuthorSurnameLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Test))
        Me.BooklibDataSet = New BookLib.booklibDataSet()
        Me.BooksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BooksTableAdapter = New BookLib.booklibDataSetTableAdapters.booksTableAdapter()
        Me.TableAdapterManager = New BookLib.booklibDataSetTableAdapters.TableAdapterManager()
        Me.AuthorsTableAdapter = New BookLib.booklibDataSetTableAdapters.authorsTableAdapter()
        Me.BooksBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.BooksBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.BookIDTextBox = New System.Windows.Forms.TextBox()
        Me.BookNameTextBox = New System.Windows.Forms.TextBox()
        Me.AuthorIDComboBox = New System.Windows.Forms.ComboBox()
        Me.AuthorsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FileTypeIDTextBox = New System.Windows.Forms.TextBox()
        Me.AuthorsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AuthorIDComboBox1 = New System.Windows.Forms.ComboBox()
        Me.AuthorsBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AuthorNameTextBox = New System.Windows.Forms.TextBox()
        Me.AuthorSurnameTextBox = New System.Windows.Forms.TextBox()
        BookIDLabel = New System.Windows.Forms.Label()
        BookNameLabel = New System.Windows.Forms.Label()
        AuthorIDLabel = New System.Windows.Forms.Label()
        FileTypeIDLabel = New System.Windows.Forms.Label()
        AuthorIDLabel1 = New System.Windows.Forms.Label()
        AuthorNameLabel = New System.Windows.Forms.Label()
        AuthorSurnameLabel = New System.Windows.Forms.Label()
        CType(Me.BooklibDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BooksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BooksBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BooksBindingNavigator.SuspendLayout()
        CType(Me.AuthorsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AuthorsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AuthorsBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BookIDLabel
        '
        BookIDLabel.AutoSize = True
        BookIDLabel.Location = New System.Drawing.Point(91, 52)
        BookIDLabel.Name = "BookIDLabel"
        BookIDLabel.Size = New System.Drawing.Size(49, 13)
        BookIDLabel.TabIndex = 1
        BookIDLabel.Text = "Book ID:"
        '
        'BookNameLabel
        '
        BookNameLabel.AutoSize = True
        BookNameLabel.Location = New System.Drawing.Point(91, 78)
        BookNameLabel.Name = "BookNameLabel"
        BookNameLabel.Size = New System.Drawing.Size(66, 13)
        BookNameLabel.TabIndex = 3
        BookNameLabel.Text = "Book Name:"
        '
        'AuthorIDLabel
        '
        AuthorIDLabel.AutoSize = True
        AuthorIDLabel.Location = New System.Drawing.Point(91, 104)
        AuthorIDLabel.Name = "AuthorIDLabel"
        AuthorIDLabel.Size = New System.Drawing.Size(55, 13)
        AuthorIDLabel.TabIndex = 5
        AuthorIDLabel.Text = "Author ID:"
        '
        'FileTypeIDLabel
        '
        FileTypeIDLabel.AutoSize = True
        FileTypeIDLabel.Location = New System.Drawing.Point(91, 131)
        FileTypeIDLabel.Name = "FileTypeIDLabel"
        FileTypeIDLabel.Size = New System.Drawing.Size(67, 13)
        FileTypeIDLabel.TabIndex = 7
        FileTypeIDLabel.Text = "File Type ID:"
        '
        'AuthorIDLabel1
        '
        AuthorIDLabel1.AutoSize = True
        AuthorIDLabel1.Location = New System.Drawing.Point(114, 190)
        AuthorIDLabel1.Name = "AuthorIDLabel1"
        AuthorIDLabel1.Size = New System.Drawing.Size(55, 13)
        AuthorIDLabel1.TabIndex = 9
        AuthorIDLabel1.Text = "Author ID:"
        '
        'AuthorNameLabel
        '
        AuthorNameLabel.AutoSize = True
        AuthorNameLabel.Location = New System.Drawing.Point(114, 217)
        AuthorNameLabel.Name = "AuthorNameLabel"
        AuthorNameLabel.Size = New System.Drawing.Size(72, 13)
        AuthorNameLabel.TabIndex = 11
        AuthorNameLabel.Text = "Author Name:"
        '
        'AuthorSurnameLabel
        '
        AuthorSurnameLabel.AutoSize = True
        AuthorSurnameLabel.Location = New System.Drawing.Point(114, 243)
        AuthorSurnameLabel.Name = "AuthorSurnameLabel"
        AuthorSurnameLabel.Size = New System.Drawing.Size(86, 13)
        AuthorSurnameLabel.TabIndex = 13
        AuthorSurnameLabel.Text = "Author Surname:"
        '
        'BooklibDataSet
        '
        Me.BooklibDataSet.DataSetName = "booklibDataSet"
        Me.BooklibDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BooksBindingSource
        '
        Me.BooksBindingSource.DataMember = "books"
        Me.BooksBindingSource.DataSource = Me.BooklibDataSet
        '
        'BooksTableAdapter
        '
        Me.BooksTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.authorsTableAdapter = Me.AuthorsTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.booksTableAdapter = Me.BooksTableAdapter
        Me.TableAdapterManager.categoriesTableAdapter = Nothing
        Me.TableAdapterManager.file_typesTableAdapter = Nothing
        Me.TableAdapterManager.lib_controlTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = BookLib.booklibDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AuthorsTableAdapter
        '
        Me.AuthorsTableAdapter.ClearBeforeFill = True
        '
        'BooksBindingNavigator
        '
        Me.BooksBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BooksBindingNavigator.BindingSource = Me.BooksBindingSource
        Me.BooksBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.BooksBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BooksBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.BooksBindingNavigatorSaveItem})
        Me.BooksBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.BooksBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BooksBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BooksBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BooksBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BooksBindingNavigator.Name = "BooksBindingNavigator"
        Me.BooksBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.BooksBindingNavigator.Size = New System.Drawing.Size(447, 25)
        Me.BooksBindingNavigator.TabIndex = 0
        Me.BooksBindingNavigator.Text = "BindingNavigator1"
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
        'BooksBindingNavigatorSaveItem
        '
        Me.BooksBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BooksBindingNavigatorSaveItem.Image = CType(resources.GetObject("BooksBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.BooksBindingNavigatorSaveItem.Name = "BooksBindingNavigatorSaveItem"
        Me.BooksBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.BooksBindingNavigatorSaveItem.Text = "Save Data"
        '
        'BookIDTextBox
        '
        Me.BookIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BooksBindingSource, "BookID", True))
        Me.BookIDTextBox.Location = New System.Drawing.Point(164, 49)
        Me.BookIDTextBox.Name = "BookIDTextBox"
        Me.BookIDTextBox.Size = New System.Drawing.Size(121, 20)
        Me.BookIDTextBox.TabIndex = 2
        '
        'BookNameTextBox
        '
        Me.BookNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BooksBindingSource, "BookName", True))
        Me.BookNameTextBox.Location = New System.Drawing.Point(164, 75)
        Me.BookNameTextBox.Name = "BookNameTextBox"
        Me.BookNameTextBox.Size = New System.Drawing.Size(121, 20)
        Me.BookNameTextBox.TabIndex = 4
        '
        'AuthorIDComboBox
        '
        Me.AuthorIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BooksBindingSource, "AuthorID", True))
        Me.AuthorIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.AuthorsBindingSource1, "AuthorID", True))
        Me.AuthorIDComboBox.DataSource = Me.AuthorsBindingSource1
        Me.AuthorIDComboBox.DisplayMember = "AuthorName"
        Me.AuthorIDComboBox.FormattingEnabled = True
        Me.AuthorIDComboBox.Location = New System.Drawing.Point(164, 101)
        Me.AuthorIDComboBox.Name = "AuthorIDComboBox"
        Me.AuthorIDComboBox.Size = New System.Drawing.Size(121, 21)
        Me.AuthorIDComboBox.TabIndex = 6
        Me.AuthorIDComboBox.ValueMember = "AuthorID"
        '
        'AuthorsBindingSource1
        '
        Me.AuthorsBindingSource1.DataMember = "authors"
        Me.AuthorsBindingSource1.DataSource = Me.BooklibDataSet
        '
        'FileTypeIDTextBox
        '
        Me.FileTypeIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BooksBindingSource, "FileTypeID", True))
        Me.FileTypeIDTextBox.Location = New System.Drawing.Point(164, 128)
        Me.FileTypeIDTextBox.Name = "FileTypeIDTextBox"
        Me.FileTypeIDTextBox.Size = New System.Drawing.Size(121, 20)
        Me.FileTypeIDTextBox.TabIndex = 8
        '
        'AuthorsBindingSource
        '
        Me.AuthorsBindingSource.DataMember = "authors"
        Me.AuthorsBindingSource.DataSource = Me.BooklibDataSet
        '
        'AuthorIDComboBox1
        '
        Me.AuthorIDComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.AuthorsBindingSource, "AuthorID", True))
        Me.AuthorIDComboBox1.DataSource = Me.AuthorsBindingSource2
        Me.AuthorIDComboBox1.DisplayMember = "AuthorName"
        Me.AuthorIDComboBox1.FormattingEnabled = True
        Me.AuthorIDComboBox1.Location = New System.Drawing.Point(206, 187)
        Me.AuthorIDComboBox1.Name = "AuthorIDComboBox1"
        Me.AuthorIDComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.AuthorIDComboBox1.TabIndex = 10
        Me.AuthorIDComboBox1.ValueMember = "AuthorID"
        '
        'AuthorsBindingSource2
        '
        Me.AuthorsBindingSource2.DataMember = "authors"
        Me.AuthorsBindingSource2.DataSource = Me.BooklibDataSet
        '
        'AuthorNameTextBox
        '
        Me.AuthorNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuthorsBindingSource, "AuthorName", True))
        Me.AuthorNameTextBox.Location = New System.Drawing.Point(206, 214)
        Me.AuthorNameTextBox.Name = "AuthorNameTextBox"
        Me.AuthorNameTextBox.Size = New System.Drawing.Size(121, 20)
        Me.AuthorNameTextBox.TabIndex = 12
        '
        'AuthorSurnameTextBox
        '
        Me.AuthorSurnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuthorsBindingSource, "AuthorSurname", True))
        Me.AuthorSurnameTextBox.Location = New System.Drawing.Point(206, 240)
        Me.AuthorSurnameTextBox.Name = "AuthorSurnameTextBox"
        Me.AuthorSurnameTextBox.Size = New System.Drawing.Size(121, 20)
        Me.AuthorSurnameTextBox.TabIndex = 14
        '
        'Test
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 280)
        Me.Controls.Add(AuthorIDLabel1)
        Me.Controls.Add(Me.AuthorIDComboBox1)
        Me.Controls.Add(AuthorNameLabel)
        Me.Controls.Add(Me.AuthorNameTextBox)
        Me.Controls.Add(AuthorSurnameLabel)
        Me.Controls.Add(Me.AuthorSurnameTextBox)
        Me.Controls.Add(BookIDLabel)
        Me.Controls.Add(Me.BookIDTextBox)
        Me.Controls.Add(BookNameLabel)
        Me.Controls.Add(Me.BookNameTextBox)
        Me.Controls.Add(AuthorIDLabel)
        Me.Controls.Add(Me.AuthorIDComboBox)
        Me.Controls.Add(FileTypeIDLabel)
        Me.Controls.Add(Me.FileTypeIDTextBox)
        Me.Controls.Add(Me.BooksBindingNavigator)
        Me.Name = "Test"
        Me.Text = "Test"
        CType(Me.BooklibDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BooksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BooksBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BooksBindingNavigator.ResumeLayout(False)
        Me.BooksBindingNavigator.PerformLayout()
        CType(Me.AuthorsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AuthorsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AuthorsBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BooklibDataSet As booklibDataSet
    Friend WithEvents BooksBindingSource As BindingSource
    Friend WithEvents BooksTableAdapter As booklibDataSetTableAdapters.booksTableAdapter
    Friend WithEvents TableAdapterManager As booklibDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BooksBindingNavigator As BindingNavigator
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
    Friend WithEvents BooksBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents AuthorsTableAdapter As booklibDataSetTableAdapters.authorsTableAdapter
    Friend WithEvents BookIDTextBox As TextBox
    Friend WithEvents BookNameTextBox As TextBox
    Friend WithEvents AuthorIDComboBox As ComboBox
    Friend WithEvents FileTypeIDTextBox As TextBox
    Friend WithEvents AuthorsBindingSource As BindingSource
    Friend WithEvents AuthorsBindingSource1 As BindingSource
    Friend WithEvents AuthorIDComboBox1 As ComboBox
    Friend WithEvents AuthorNameTextBox As TextBox
    Friend WithEvents AuthorSurnameTextBox As TextBox
    Friend WithEvents AuthorsBindingSource2 As BindingSource
End Class
