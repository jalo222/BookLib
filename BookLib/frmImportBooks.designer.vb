<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImportBooks
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
        Dim AuthorFullNameLabel As System.Windows.Forms.Label
        Dim FileTypeIDLabel1 As System.Windows.Forms.Label
        Dim FileExtensionLabel As System.Windows.Forms.Label
        Dim FileTypeLabel As System.Windows.Forms.Label
        Dim BookIDLabel1 As System.Windows.Forms.Label
        Dim FileTypeIDLabel3 As System.Windows.Forms.Label
        Dim FileTypeIDLabel2 As System.Windows.Forms.Label
        Dim FileExtensionLabel1 As System.Windows.Forms.Label
        Dim FileTypeLabel1 As System.Windows.Forms.Label
        Me.FileSystemTree2 = New MasaSam.Forms.Controls.FileSystemTree()
        Me.txtBookName = New System.Windows.Forms.TextBox()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.txtBookRef = New System.Windows.Forms.TextBox()
        Me.txtCoverFileName = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.BooklibDataSet = New BookLib.booklibDataSet()
        Me.BooksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BooksTableAdapter = New BookLib.booklibDataSetTableAdapters.booksTableAdapter()
        Me.TableAdapterManager = New BookLib.booklibDataSetTableAdapters.TableAdapterManager()
        Me.AuthorsTableAdapter = New BookLib.booklibDataSetTableAdapters.authorsTableAdapter()
        Me.Book_coversTableAdapter = New BookLib.booklibDataSetTableAdapters.book_coversTableAdapter()
        Me.File_types_copyTableAdapter = New BookLib.booklibDataSetTableAdapters.file_types_copyTableAdapter()
        Me.File_typesTableAdapter = New BookLib.booklibDataSetTableAdapters.file_typesTableAdapter()
        Me.BookIDTextBox = New System.Windows.Forms.TextBox()
        Me.BookNameTextBox = New System.Windows.Forms.TextBox()
        Me.BookAuthorIDTextBox = New System.Windows.Forms.TextBox()
        Me.BookFileTypeIDTextBox = New System.Windows.Forms.TextBox()
        Me.AuthorsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AuthorIDTextBox = New System.Windows.Forms.TextBox()
        Me.AuthorNameTextBox = New System.Windows.Forms.TextBox()
        Me.AuthorSurnameTextBox = New System.Windows.Forms.TextBox()
        Me.AuthorFullNameTextBox = New System.Windows.Forms.TextBox()
        Me.File_typesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FileTypeIDBookTextBox = New System.Windows.Forms.TextBox()
        Me.FileExtensionBookTextBox = New System.Windows.Forms.TextBox()
        Me.FileTypeBookTextBox = New System.Windows.Forms.TextBox()
        Me.Book_coversBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CoverBookID = New System.Windows.Forms.TextBox()
        Me.CoverFileTypeID = New System.Windows.Forms.TextBox()
        Me.File_types_copyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FileTypeIDCoverTextBox = New System.Windows.Forms.TextBox()
        Me.FileExtensionCoverTextBox = New System.Windows.Forms.TextBox()
        Me.FileTypeTextBox = New System.Windows.Forms.TextBox()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        BookIDLabel = New System.Windows.Forms.Label()
        BookNameLabel = New System.Windows.Forms.Label()
        AuthorIDLabel = New System.Windows.Forms.Label()
        FileTypeIDLabel = New System.Windows.Forms.Label()
        AuthorIDLabel1 = New System.Windows.Forms.Label()
        AuthorNameLabel = New System.Windows.Forms.Label()
        AuthorSurnameLabel = New System.Windows.Forms.Label()
        AuthorFullNameLabel = New System.Windows.Forms.Label()
        FileTypeIDLabel1 = New System.Windows.Forms.Label()
        FileExtensionLabel = New System.Windows.Forms.Label()
        FileTypeLabel = New System.Windows.Forms.Label()
        BookIDLabel1 = New System.Windows.Forms.Label()
        FileTypeIDLabel3 = New System.Windows.Forms.Label()
        FileTypeIDLabel2 = New System.Windows.Forms.Label()
        FileExtensionLabel1 = New System.Windows.Forms.Label()
        FileTypeLabel1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BooklibDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BooksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AuthorsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.File_typesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Book_coversBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.File_types_copyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BookIDLabel
        '
        BookIDLabel.AutoSize = True
        BookIDLabel.Location = New System.Drawing.Point(404, 139)
        BookIDLabel.Name = "BookIDLabel"
        BookIDLabel.Size = New System.Drawing.Size(49, 13)
        BookIDLabel.TabIndex = 42
        BookIDLabel.Text = "Book ID:"
        '
        'BookNameLabel
        '
        BookNameLabel.AutoSize = True
        BookNameLabel.Location = New System.Drawing.Point(404, 165)
        BookNameLabel.Name = "BookNameLabel"
        BookNameLabel.Size = New System.Drawing.Size(66, 13)
        BookNameLabel.TabIndex = 44
        BookNameLabel.Text = "Book Name:"
        '
        'AuthorIDLabel
        '
        AuthorIDLabel.AutoSize = True
        AuthorIDLabel.Location = New System.Drawing.Point(404, 191)
        AuthorIDLabel.Name = "AuthorIDLabel"
        AuthorIDLabel.Size = New System.Drawing.Size(55, 13)
        AuthorIDLabel.TabIndex = 46
        AuthorIDLabel.Text = "Author ID:"
        '
        'FileTypeIDLabel
        '
        FileTypeIDLabel.AutoSize = True
        FileTypeIDLabel.Location = New System.Drawing.Point(404, 217)
        FileTypeIDLabel.Name = "FileTypeIDLabel"
        FileTypeIDLabel.Size = New System.Drawing.Size(67, 13)
        FileTypeIDLabel.TabIndex = 48
        FileTypeIDLabel.Text = "File Type ID:"
        '
        'AuthorIDLabel1
        '
        AuthorIDLabel1.AutoSize = True
        AuthorIDLabel1.Location = New System.Drawing.Point(431, 293)
        AuthorIDLabel1.Name = "AuthorIDLabel1"
        AuthorIDLabel1.Size = New System.Drawing.Size(55, 13)
        AuthorIDLabel1.TabIndex = 49
        AuthorIDLabel1.Text = "Author ID:"
        '
        'AuthorNameLabel
        '
        AuthorNameLabel.AutoSize = True
        AuthorNameLabel.Location = New System.Drawing.Point(431, 319)
        AuthorNameLabel.Name = "AuthorNameLabel"
        AuthorNameLabel.Size = New System.Drawing.Size(72, 13)
        AuthorNameLabel.TabIndex = 51
        AuthorNameLabel.Text = "Author Name:"
        '
        'AuthorSurnameLabel
        '
        AuthorSurnameLabel.AutoSize = True
        AuthorSurnameLabel.Location = New System.Drawing.Point(431, 345)
        AuthorSurnameLabel.Name = "AuthorSurnameLabel"
        AuthorSurnameLabel.Size = New System.Drawing.Size(86, 13)
        AuthorSurnameLabel.TabIndex = 53
        AuthorSurnameLabel.Text = "Author Surname:"
        '
        'AuthorFullNameLabel
        '
        AuthorFullNameLabel.AutoSize = True
        AuthorFullNameLabel.Location = New System.Drawing.Point(431, 371)
        AuthorFullNameLabel.Name = "AuthorFullNameLabel"
        AuthorFullNameLabel.Size = New System.Drawing.Size(91, 13)
        AuthorFullNameLabel.TabIndex = 55
        AuthorFullNameLabel.Text = "Author Full Name:"
        '
        'FileTypeIDLabel1
        '
        FileTypeIDLabel1.AutoSize = True
        FileTypeIDLabel1.Location = New System.Drawing.Point(373, 403)
        FileTypeIDLabel1.Name = "FileTypeIDLabel1"
        FileTypeIDLabel1.Size = New System.Drawing.Size(67, 13)
        FileTypeIDLabel1.TabIndex = 56
        FileTypeIDLabel1.Text = "File Type ID:"
        '
        'FileExtensionLabel
        '
        FileExtensionLabel.AutoSize = True
        FileExtensionLabel.Location = New System.Drawing.Point(373, 429)
        FileExtensionLabel.Name = "FileExtensionLabel"
        FileExtensionLabel.Size = New System.Drawing.Size(75, 13)
        FileExtensionLabel.TabIndex = 58
        FileExtensionLabel.Text = "File Extension:"
        '
        'FileTypeLabel
        '
        FileTypeLabel.AutoSize = True
        FileTypeLabel.Location = New System.Drawing.Point(373, 455)
        FileTypeLabel.Name = "FileTypeLabel"
        FileTypeLabel.Size = New System.Drawing.Size(53, 13)
        FileTypeLabel.TabIndex = 60
        FileTypeLabel.Text = "File Type:"
        '
        'BookIDLabel1
        '
        BookIDLabel1.AutoSize = True
        BookIDLabel1.Location = New System.Drawing.Point(571, 415)
        BookIDLabel1.Name = "BookIDLabel1"
        BookIDLabel1.Size = New System.Drawing.Size(49, 13)
        BookIDLabel1.TabIndex = 73
        BookIDLabel1.Text = "Book ID:"
        '
        'FileTypeIDLabel3
        '
        FileTypeIDLabel3.AutoSize = True
        FileTypeIDLabel3.Location = New System.Drawing.Point(571, 441)
        FileTypeIDLabel3.Name = "FileTypeIDLabel3"
        FileTypeIDLabel3.Size = New System.Drawing.Size(67, 13)
        FileTypeIDLabel3.TabIndex = 75
        FileTypeIDLabel3.Text = "File Type ID:"
        '
        'FileTypeIDLabel2
        '
        FileTypeIDLabel2.AutoSize = True
        FileTypeIDLabel2.Location = New System.Drawing.Point(829, 426)
        FileTypeIDLabel2.Name = "FileTypeIDLabel2"
        FileTypeIDLabel2.Size = New System.Drawing.Size(67, 13)
        FileTypeIDLabel2.TabIndex = 76
        FileTypeIDLabel2.Text = "File Type ID:"
        '
        'FileExtensionLabel1
        '
        FileExtensionLabel1.AutoSize = True
        FileExtensionLabel1.Location = New System.Drawing.Point(829, 452)
        FileExtensionLabel1.Name = "FileExtensionLabel1"
        FileExtensionLabel1.Size = New System.Drawing.Size(75, 13)
        FileExtensionLabel1.TabIndex = 78
        FileExtensionLabel1.Text = "File Extension:"
        '
        'FileTypeLabel1
        '
        FileTypeLabel1.AutoSize = True
        FileTypeLabel1.Location = New System.Drawing.Point(829, 478)
        FileTypeLabel1.Name = "FileTypeLabel1"
        FileTypeLabel1.Size = New System.Drawing.Size(53, 13)
        FileTypeLabel1.TabIndex = 80
        FileTypeLabel1.Text = "File Type:"
        '
        'FileSystemTree2
        '
        Me.FileSystemTree2.FileExtensions = "*"
        Me.FileSystemTree2.Location = New System.Drawing.Point(12, 12)
        Me.FileSystemTree2.Name = "FileSystemTree2"
        Me.FileSystemTree2.RootDrive = "C:\"
        Me.FileSystemTree2.Size = New System.Drawing.Size(359, 471)
        Me.FileSystemTree2.TabIndex = 2
        '
        'txtBookName
        '
        Me.txtBookName.Location = New System.Drawing.Point(395, 95)
        Me.txtBookName.Name = "txtBookName"
        Me.txtBookName.Size = New System.Drawing.Size(172, 20)
        Me.txtBookName.TabIndex = 37
        '
        'txtAuthor
        '
        Me.txtAuthor.Location = New System.Drawing.Point(388, 50)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(257, 20)
        Me.txtAuthor.TabIndex = 36
        '
        'txtBookRef
        '
        Me.txtBookRef.Location = New System.Drawing.Point(388, 12)
        Me.txtBookRef.Name = "txtBookRef"
        Me.txtBookRef.Size = New System.Drawing.Size(492, 20)
        Me.txtBookRef.TabIndex = 35
        '
        'txtCoverFileName
        '
        Me.txtCoverFileName.Location = New System.Drawing.Point(653, 50)
        Me.txtCoverFileName.Name = "txtCoverFileName"
        Me.txtCoverFileName.Size = New System.Drawing.Size(246, 20)
        Me.txtCoverFileName.TabIndex = 39
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(653, 76)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(246, 316)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(541, 488)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 41
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnImport
        '
        Me.btnImport.Location = New System.Drawing.Point(141, 488)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(75, 23)
        Me.btnImport.TabIndex = 40
        Me.btnImport.Text = "Import"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'BooklibDataSet
        '
        Me.BooklibDataSet.DataSetName = "booklibDataSet"
        Me.BooklibDataSet.EnforceConstraints = False
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
        Me.TableAdapterManager.book_coversTableAdapter = Me.Book_coversTableAdapter
        Me.TableAdapterManager.booksTableAdapter = Me.BooksTableAdapter
        Me.TableAdapterManager.categoriesTableAdapter = Nothing
        Me.TableAdapterManager.file_types_copyTableAdapter = Me.File_types_copyTableAdapter
        Me.TableAdapterManager.file_typesTableAdapter = Me.File_typesTableAdapter
        Me.TableAdapterManager.lib_controlTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = BookLib.booklibDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AuthorsTableAdapter
        '
        Me.AuthorsTableAdapter.ClearBeforeFill = True
        '
        'Book_coversTableAdapter
        '
        Me.Book_coversTableAdapter.ClearBeforeFill = True
        '
        'File_types_copyTableAdapter
        '
        Me.File_types_copyTableAdapter.ClearBeforeFill = True
        '
        'File_typesTableAdapter
        '
        Me.File_typesTableAdapter.ClearBeforeFill = True
        '
        'BookIDTextBox
        '
        Me.BookIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BooksBindingSource, "BookID", True))
        Me.BookIDTextBox.Location = New System.Drawing.Point(477, 136)
        Me.BookIDTextBox.Name = "BookIDTextBox"
        Me.BookIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BookIDTextBox.TabIndex = 43
        '
        'BookNameTextBox
        '
        Me.BookNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BooksBindingSource, "BookName", True))
        Me.BookNameTextBox.Location = New System.Drawing.Point(477, 162)
        Me.BookNameTextBox.Name = "BookNameTextBox"
        Me.BookNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BookNameTextBox.TabIndex = 45
        '
        'BookAuthorIDTextBox
        '
        Me.BookAuthorIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BooksBindingSource, "AuthorID", True))
        Me.BookAuthorIDTextBox.Location = New System.Drawing.Point(477, 188)
        Me.BookAuthorIDTextBox.Name = "BookAuthorIDTextBox"
        Me.BookAuthorIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BookAuthorIDTextBox.TabIndex = 47
        '
        'BookFileTypeIDTextBox
        '
        Me.BookFileTypeIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BooksBindingSource, "FileTypeID", True))
        Me.BookFileTypeIDTextBox.Location = New System.Drawing.Point(477, 214)
        Me.BookFileTypeIDTextBox.Name = "BookFileTypeIDTextBox"
        Me.BookFileTypeIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BookFileTypeIDTextBox.TabIndex = 49
        '
        'AuthorsBindingSource
        '
        Me.AuthorsBindingSource.DataMember = "authors"
        Me.AuthorsBindingSource.DataSource = Me.BooklibDataSet
        '
        'AuthorIDTextBox
        '
        Me.AuthorIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuthorsBindingSource, "AuthorID", True))
        Me.AuthorIDTextBox.Location = New System.Drawing.Point(528, 290)
        Me.AuthorIDTextBox.Name = "AuthorIDTextBox"
        Me.AuthorIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AuthorIDTextBox.TabIndex = 50
        '
        'AuthorNameTextBox
        '
        Me.AuthorNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuthorsBindingSource, "AuthorName", True))
        Me.AuthorNameTextBox.Location = New System.Drawing.Point(528, 316)
        Me.AuthorNameTextBox.Name = "AuthorNameTextBox"
        Me.AuthorNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AuthorNameTextBox.TabIndex = 52
        '
        'AuthorSurnameTextBox
        '
        Me.AuthorSurnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuthorsBindingSource, "AuthorSurname", True))
        Me.AuthorSurnameTextBox.Location = New System.Drawing.Point(528, 342)
        Me.AuthorSurnameTextBox.Name = "AuthorSurnameTextBox"
        Me.AuthorSurnameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AuthorSurnameTextBox.TabIndex = 54
        '
        'AuthorFullNameTextBox
        '
        Me.AuthorFullNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuthorsBindingSource, "AuthorFullName", True))
        Me.AuthorFullNameTextBox.Location = New System.Drawing.Point(528, 368)
        Me.AuthorFullNameTextBox.Name = "AuthorFullNameTextBox"
        Me.AuthorFullNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AuthorFullNameTextBox.TabIndex = 56
        '
        'File_typesBindingSource
        '
        Me.File_typesBindingSource.DataMember = "file_types"
        Me.File_typesBindingSource.DataSource = Me.BooklibDataSet
        '
        'FileTypeIDBookTextBox
        '
        Me.FileTypeIDBookTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.File_typesBindingSource, "FileTypeID", True))
        Me.FileTypeIDBookTextBox.Location = New System.Drawing.Point(454, 400)
        Me.FileTypeIDBookTextBox.Name = "FileTypeIDBookTextBox"
        Me.FileTypeIDBookTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FileTypeIDBookTextBox.TabIndex = 57
        '
        'FileExtensionBookTextBox
        '
        Me.FileExtensionBookTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.File_typesBindingSource, "FileExtension", True))
        Me.FileExtensionBookTextBox.Location = New System.Drawing.Point(454, 426)
        Me.FileExtensionBookTextBox.Name = "FileExtensionBookTextBox"
        Me.FileExtensionBookTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FileExtensionBookTextBox.TabIndex = 59
        '
        'FileTypeBookTextBox
        '
        Me.FileTypeBookTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.File_typesBindingSource, "FileType", True))
        Me.FileTypeBookTextBox.Location = New System.Drawing.Point(454, 452)
        Me.FileTypeBookTextBox.Name = "FileTypeBookTextBox"
        Me.FileTypeBookTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FileTypeBookTextBox.TabIndex = 61
        '
        'Book_coversBindingSource
        '
        Me.Book_coversBindingSource.DataMember = "book_covers"
        Me.Book_coversBindingSource.DataSource = Me.BooklibDataSet
        '
        'CoverBookID
        '
        Me.CoverBookID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Book_coversBindingSource, "BookID", True))
        Me.CoverBookID.Location = New System.Drawing.Point(644, 408)
        Me.CoverBookID.Name = "CoverBookID"
        Me.CoverBookID.Size = New System.Drawing.Size(100, 20)
        Me.CoverBookID.TabIndex = 74
        '
        'CoverFileTypeID
        '
        Me.CoverFileTypeID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Book_coversBindingSource, "FileTypeID", True))
        Me.CoverFileTypeID.Location = New System.Drawing.Point(644, 438)
        Me.CoverFileTypeID.Name = "CoverFileTypeID"
        Me.CoverFileTypeID.Size = New System.Drawing.Size(100, 20)
        Me.CoverFileTypeID.TabIndex = 76
        '
        'File_types_copyBindingSource
        '
        Me.File_types_copyBindingSource.DataMember = "file_types_copy"
        Me.File_types_copyBindingSource.DataSource = Me.BooklibDataSet
        '
        'FileTypeIDCoverTextBox
        '
        Me.FileTypeIDCoverTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.File_types_copyBindingSource, "FileTypeID", True))
        Me.FileTypeIDCoverTextBox.Location = New System.Drawing.Point(910, 423)
        Me.FileTypeIDCoverTextBox.Name = "FileTypeIDCoverTextBox"
        Me.FileTypeIDCoverTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FileTypeIDCoverTextBox.TabIndex = 77
        '
        'FileExtensionCoverTextBox
        '
        Me.FileExtensionCoverTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.File_types_copyBindingSource, "FileExtension", True))
        Me.FileExtensionCoverTextBox.Location = New System.Drawing.Point(910, 449)
        Me.FileExtensionCoverTextBox.Name = "FileExtensionCoverTextBox"
        Me.FileExtensionCoverTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FileExtensionCoverTextBox.TabIndex = 79
        '
        'FileTypeTextBox
        '
        Me.FileTypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.File_types_copyBindingSource, "FileType", True))
        Me.FileTypeTextBox.Location = New System.Drawing.Point(910, 475)
        Me.FileTypeTextBox.Name = "FileTypeTextBox"
        Me.FileTypeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FileTypeTextBox.TabIndex = 81
        '
        'TreeView1
        '
        Me.TreeView1.Location = New System.Drawing.Point(152, 120)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(258, 190)
        Me.TreeView1.TabIndex = 82
        '
        'frmImportBooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1030, 531)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(FileTypeIDLabel2)
        Me.Controls.Add(Me.FileTypeIDCoverTextBox)
        Me.Controls.Add(FileExtensionLabel1)
        Me.Controls.Add(Me.FileExtensionCoverTextBox)
        Me.Controls.Add(FileTypeLabel1)
        Me.Controls.Add(Me.FileTypeTextBox)
        Me.Controls.Add(BookIDLabel1)
        Me.Controls.Add(Me.CoverBookID)
        Me.Controls.Add(FileTypeIDLabel3)
        Me.Controls.Add(Me.CoverFileTypeID)
        Me.Controls.Add(FileTypeIDLabel1)
        Me.Controls.Add(Me.FileTypeIDBookTextBox)
        Me.Controls.Add(FileExtensionLabel)
        Me.Controls.Add(Me.FileExtensionBookTextBox)
        Me.Controls.Add(FileTypeLabel)
        Me.Controls.Add(Me.FileTypeBookTextBox)
        Me.Controls.Add(AuthorIDLabel1)
        Me.Controls.Add(Me.AuthorIDTextBox)
        Me.Controls.Add(AuthorNameLabel)
        Me.Controls.Add(Me.AuthorNameTextBox)
        Me.Controls.Add(AuthorSurnameLabel)
        Me.Controls.Add(Me.AuthorSurnameTextBox)
        Me.Controls.Add(AuthorFullNameLabel)
        Me.Controls.Add(Me.AuthorFullNameTextBox)
        Me.Controls.Add(BookIDLabel)
        Me.Controls.Add(Me.BookIDTextBox)
        Me.Controls.Add(BookNameLabel)
        Me.Controls.Add(Me.BookNameTextBox)
        Me.Controls.Add(AuthorIDLabel)
        Me.Controls.Add(Me.BookAuthorIDTextBox)
        Me.Controls.Add(FileTypeIDLabel)
        Me.Controls.Add(Me.BookFileTypeIDTextBox)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnImport)
        Me.Controls.Add(Me.txtCoverFileName)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtBookName)
        Me.Controls.Add(Me.txtAuthor)
        Me.Controls.Add(Me.txtBookRef)
        Me.Controls.Add(Me.FileSystemTree2)
        Me.Name = "frmImportBooks"
        Me.Text = "frmImportBooks"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BooklibDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BooksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AuthorsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.File_typesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Book_coversBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.File_types_copyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FileSystemTree2 As MasaSam.Forms.Controls.FileSystemTree
    Friend WithEvents txtBookName As TextBox
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents txtBookRef As TextBox
    Friend WithEvents txtCoverFileName As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnImport As Button
    Friend WithEvents BooklibDataSet As booklibDataSet
    Friend WithEvents BooksBindingSource As BindingSource
    Friend WithEvents BooksTableAdapter As booklibDataSetTableAdapters.booksTableAdapter
    Friend WithEvents TableAdapterManager As booklibDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AuthorsTableAdapter As booklibDataSetTableAdapters.authorsTableAdapter
    Friend WithEvents BookIDTextBox As TextBox
    Friend WithEvents BookNameTextBox As TextBox
    Friend WithEvents BookAuthorIDTextBox As TextBox
    Friend WithEvents BookFileTypeIDTextBox As TextBox
    Friend WithEvents AuthorsBindingSource As BindingSource
    Friend WithEvents File_typesTableAdapter As booklibDataSetTableAdapters.file_typesTableAdapter
    Friend WithEvents AuthorIDTextBox As TextBox
    Friend WithEvents AuthorNameTextBox As TextBox
    Friend WithEvents AuthorSurnameTextBox As TextBox
    Friend WithEvents AuthorFullNameTextBox As TextBox
    Friend WithEvents File_typesBindingSource As BindingSource
    Friend WithEvents FileTypeIDBookTextBox As TextBox
    Friend WithEvents FileExtensionBookTextBox As TextBox
    Friend WithEvents FileTypeBookTextBox As TextBox
    Friend WithEvents Book_coversBindingSource As BindingSource
    Friend WithEvents Book_coversTableAdapter As booklibDataSetTableAdapters.book_coversTableAdapter
    Friend WithEvents CoverBookID As TextBox
    Friend WithEvents CoverFileTypeID As TextBox
    Friend WithEvents File_types_copyBindingSource As BindingSource
    Friend WithEvents File_types_copyTableAdapter As booklibDataSetTableAdapters.file_types_copyTableAdapter
    Friend WithEvents FileTypeIDCoverTextBox As TextBox
    Friend WithEvents FileExtensionCoverTextBox As TextBox
    Friend WithEvents FileTypeTextBox As TextBox
    Friend WithEvents TreeView1 As TreeView
End Class
