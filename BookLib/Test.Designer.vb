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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Test))
        Dim FileTypeIDLabel1 As System.Windows.Forms.Label
        Me.BooklibDataSet = New BookLib.booklibDataSet()
        Me.BooksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BooksTableAdapter = New BookLib.booklibDataSetTableAdapters.booksTableAdapter()
        Me.TableAdapterManager = New BookLib.booklibDataSetTableAdapters.TableAdapterManager()
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
        Me.AuthorsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AuthorsTableAdapter = New BookLib.booklibDataSetTableAdapters.authorsTableAdapter()
        Me.FileTypeIDComboBox = New System.Windows.Forms.ComboBox()
        Me.File_typesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.File_typesTableAdapter = New BookLib.booklibDataSetTableAdapters.file_typesTableAdapter()
        BookIDLabel = New System.Windows.Forms.Label()
        BookNameLabel = New System.Windows.Forms.Label()
        AuthorIDLabel = New System.Windows.Forms.Label()
        FileTypeIDLabel1 = New System.Windows.Forms.Label()
        CType(Me.BooklibDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BooksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BooksBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BooksBindingNavigator.SuspendLayout()
        CType(Me.AuthorsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.File_typesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BookIDLabel
        '
        BookIDLabel.AutoSize = True
        BookIDLabel.Location = New System.Drawing.Point(170, 46)
        BookIDLabel.Name = "BookIDLabel"
        BookIDLabel.Size = New System.Drawing.Size(49, 13)
        BookIDLabel.TabIndex = 1
        BookIDLabel.Text = "Book ID:"
        '
        'BookNameLabel
        '
        BookNameLabel.AutoSize = True
        BookNameLabel.Location = New System.Drawing.Point(170, 72)
        BookNameLabel.Name = "BookNameLabel"
        BookNameLabel.Size = New System.Drawing.Size(66, 13)
        BookNameLabel.TabIndex = 3
        BookNameLabel.Text = "Book Name:"
        '
        'AuthorIDLabel
        '
        AuthorIDLabel.AutoSize = True
        AuthorIDLabel.Location = New System.Drawing.Point(170, 98)
        AuthorIDLabel.Name = "AuthorIDLabel"
        AuthorIDLabel.Size = New System.Drawing.Size(55, 13)
        AuthorIDLabel.TabIndex = 5
        AuthorIDLabel.Text = "Author ID:"
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
        Me.TableAdapterManager.authorsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.book_coversTableAdapter = Nothing
        Me.TableAdapterManager.booksTableAdapter = Me.BooksTableAdapter
        Me.TableAdapterManager.categoriesTableAdapter = Nothing
        Me.TableAdapterManager.file_typesTableAdapter = Nothing
        Me.TableAdapterManager.lib_controlTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = BookLib.booklibDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        Me.BooksBindingNavigator.Size = New System.Drawing.Size(529, 25)
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
        Me.BookIDTextBox.Location = New System.Drawing.Point(243, 43)
        Me.BookIDTextBox.Name = "BookIDTextBox"
        Me.BookIDTextBox.Size = New System.Drawing.Size(121, 20)
        Me.BookIDTextBox.TabIndex = 2
        '
        'BookNameTextBox
        '
        Me.BookNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BooksBindingSource, "BookName", True))
        Me.BookNameTextBox.Location = New System.Drawing.Point(243, 69)
        Me.BookNameTextBox.Name = "BookNameTextBox"
        Me.BookNameTextBox.Size = New System.Drawing.Size(121, 20)
        Me.BookNameTextBox.TabIndex = 4
        '
        'AuthorIDComboBox
        '
        Me.AuthorIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BooksBindingSource, "AuthorID", True))
        Me.AuthorIDComboBox.DataSource = Me.AuthorsBindingSource
        Me.AuthorIDComboBox.DisplayMember = "AuthorName"
        Me.AuthorIDComboBox.FormattingEnabled = True
        Me.AuthorIDComboBox.Location = New System.Drawing.Point(243, 95)
        Me.AuthorIDComboBox.Name = "AuthorIDComboBox"
        Me.AuthorIDComboBox.Size = New System.Drawing.Size(121, 21)
        Me.AuthorIDComboBox.TabIndex = 6
        Me.AuthorIDComboBox.ValueMember = "AuthorID"
        '
        'AuthorsBindingSource
        '
        Me.AuthorsBindingSource.DataMember = "authors"
        Me.AuthorsBindingSource.DataSource = Me.BooklibDataSet
        '
        'AuthorsTableAdapter
        '
        Me.AuthorsTableAdapter.ClearBeforeFill = True
        '
        'FileTypeIDLabel1
        '
        FileTypeIDLabel1.AutoSize = True
        FileTypeIDLabel1.Location = New System.Drawing.Point(170, 125)
        FileTypeIDLabel1.Name = "FileTypeIDLabel1"
        FileTypeIDLabel1.Size = New System.Drawing.Size(67, 13)
        FileTypeIDLabel1.TabIndex = 8
        FileTypeIDLabel1.Text = "File Type ID:"
        '
        'FileTypeIDComboBox
        '
        Me.FileTypeIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BooksBindingSource, "FileTypeID", True))
        Me.FileTypeIDComboBox.DataSource = Me.File_typesBindingSource
        Me.FileTypeIDComboBox.DisplayMember = "FileExtension"
        Me.FileTypeIDComboBox.FormattingEnabled = True
        Me.FileTypeIDComboBox.Location = New System.Drawing.Point(243, 122)
        Me.FileTypeIDComboBox.Name = "FileTypeIDComboBox"
        Me.FileTypeIDComboBox.Size = New System.Drawing.Size(121, 21)
        Me.FileTypeIDComboBox.TabIndex = 9
        Me.FileTypeIDComboBox.ValueMember = "FileTypeID"
        '
        'File_typesBindingSource
        '
        Me.File_typesBindingSource.DataMember = "file_types"
        Me.File_typesBindingSource.DataSource = Me.BooklibDataSet
        '
        'File_typesTableAdapter
        '
        Me.File_typesTableAdapter.ClearBeforeFill = True
        '
        'Test
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 288)
        Me.Controls.Add(FileTypeIDLabel1)
        Me.Controls.Add(Me.FileTypeIDComboBox)
        Me.Controls.Add(BookIDLabel)
        Me.Controls.Add(Me.BookIDTextBox)
        Me.Controls.Add(BookNameLabel)
        Me.Controls.Add(Me.BookNameTextBox)
        Me.Controls.Add(AuthorIDLabel)
        Me.Controls.Add(Me.AuthorIDComboBox)
        Me.Controls.Add(Me.BooksBindingNavigator)
        Me.Name = "Test"
        Me.Text = "Test"
        CType(Me.BooklibDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BooksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BooksBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BooksBindingNavigator.ResumeLayout(False)
        Me.BooksBindingNavigator.PerformLayout()
        CType(Me.AuthorsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.File_typesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents BookIDTextBox As TextBox
    Friend WithEvents BookNameTextBox As TextBox
    Friend WithEvents AuthorIDComboBox As ComboBox
    Friend WithEvents AuthorsBindingSource As BindingSource
    Friend WithEvents AuthorsTableAdapter As booklibDataSetTableAdapters.authorsTableAdapter
    Friend WithEvents FileTypeIDComboBox As ComboBox
    Friend WithEvents File_typesBindingSource As BindingSource
    Friend WithEvents File_typesTableAdapter As booklibDataSetTableAdapters.file_typesTableAdapter
End Class
