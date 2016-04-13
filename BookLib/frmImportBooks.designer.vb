<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmImportBooks
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
        Dim FileTypeIDLabel1 As System.Windows.Forms.Label
        Dim FileExtensionLabel As System.Windows.Forms.Label
        Dim FileTypeLabel As System.Windows.Forms.Label
        Dim BookIDLabel As System.Windows.Forms.Label
        Dim BookNameLabel As System.Windows.Forms.Label
        Dim FileTypeIDLabel As System.Windows.Forms.Label
        Dim AuthorIDLabel1 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim FileTypeIDLabel2 As System.Windows.Forms.Label
        Dim FileExtensionLabel1 As System.Windows.Forms.Label
        Dim FileTypeLabel1 As System.Windows.Forms.Label
        Dim BookIDLabel1 As System.Windows.Forms.Label
        Dim FileTypeIDLabel3 As System.Windows.Forms.Label
        Dim AuthorNameLabel As System.Windows.Forms.Label
        Dim AuthorSurnameLabel As System.Windows.Forms.Label
        Dim AuthorFullNameLabel As System.Windows.Forms.Label
        Me.txtBookRef = New System.Windows.Forms.TextBox()
        Me.Book_coversBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BooklibDataSet = New BookLib.booklibDataSet()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.BooksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AuthorsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.File_typesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FileExtensionBookTextBox = New System.Windows.Forms.TextBox()
        Me.FileTypeBookTextBox = New System.Windows.Forms.TextBox()
        Me.File_types_copyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.BooksTableAdapter = New BookLib.booklibDataSetTableAdapters.booksTableAdapter()
        Me.TableAdapterManager = New BookLib.booklibDataSetTableAdapters.TableAdapterManager()
        Me.AuthorsTableAdapter = New BookLib.booklibDataSetTableAdapters.authorsTableAdapter()
        Me.Book_coversTableAdapter = New BookLib.booklibDataSetTableAdapters.book_coversTableAdapter()
        Me.File_types_copyTableAdapter = New BookLib.booklibDataSetTableAdapters.file_types_copyTableAdapter()
        Me.File_typesTableAdapter = New BookLib.booklibDataSetTableAdapters.file_typesTableAdapter()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BookIDTextBox = New System.Windows.Forms.TextBox()
        Me.BookNameTextBox = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpgBookList = New System.Windows.Forms.TabPage()
        Me.tpgSummary = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.AuthorSurnameTextBox = New System.Windows.Forms.TextBox()
        Me.CoverBookID = New System.Windows.Forms.TextBox()
        Me.AuthorIDTextBox = New System.Windows.Forms.TextBox()
        Me.AuthorFullNameTextBox = New System.Windows.Forms.TextBox()
        Me.CoverFileTypeID = New System.Windows.Forms.TextBox()
        Me.AuthorNameTextBox = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtBook = New System.Windows.Forms.TextBox()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FileTypeIDCoverTextBox = New System.Windows.Forms.TextBox()
        Me.FileExtensionCoverTextBox = New System.Windows.Forms.TextBox()
        Me.FileTypeTextBox = New System.Windows.Forms.TextBox()
        Me.txtCoverFileName = New System.Windows.Forms.TextBox()
        FileTypeIDLabel1 = New System.Windows.Forms.Label()
        FileExtensionLabel = New System.Windows.Forms.Label()
        FileTypeLabel = New System.Windows.Forms.Label()
        BookIDLabel = New System.Windows.Forms.Label()
        BookNameLabel = New System.Windows.Forms.Label()
        FileTypeIDLabel = New System.Windows.Forms.Label()
        AuthorIDLabel1 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        FileTypeIDLabel2 = New System.Windows.Forms.Label()
        FileExtensionLabel1 = New System.Windows.Forms.Label()
        FileTypeLabel1 = New System.Windows.Forms.Label()
        BookIDLabel1 = New System.Windows.Forms.Label()
        FileTypeIDLabel3 = New System.Windows.Forms.Label()
        AuthorNameLabel = New System.Windows.Forms.Label()
        AuthorSurnameLabel = New System.Windows.Forms.Label()
        AuthorFullNameLabel = New System.Windows.Forms.Label()
        CType(Me.Book_coversBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BooklibDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BooksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AuthorsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.File_typesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.File_types_copyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.tpgBookList.SuspendLayout()
        Me.tpgSummary.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FileTypeIDLabel1
        '
        FileTypeIDLabel1.AutoSize = True
        FileTypeIDLabel1.Location = New System.Drawing.Point(14, 116)
        FileTypeIDLabel1.Name = "FileTypeIDLabel1"
        FileTypeIDLabel1.Size = New System.Drawing.Size(67, 13)
        FileTypeIDLabel1.TabIndex = 56
        FileTypeIDLabel1.Text = "File Type ID:"
        '
        'FileExtensionLabel
        '
        FileExtensionLabel.AutoSize = True
        FileExtensionLabel.Location = New System.Drawing.Point(93, 117)
        FileExtensionLabel.Name = "FileExtensionLabel"
        FileExtensionLabel.Size = New System.Drawing.Size(75, 13)
        FileExtensionLabel.TabIndex = 58
        FileExtensionLabel.Text = "File Extension:"
        '
        'FileTypeLabel
        '
        FileTypeLabel.AutoSize = True
        FileTypeLabel.Location = New System.Drawing.Point(207, 114)
        FileTypeLabel.Name = "FileTypeLabel"
        FileTypeLabel.Size = New System.Drawing.Size(53, 13)
        FileTypeLabel.TabIndex = 60
        FileTypeLabel.Text = "File Type:"
        FileTypeLabel.Visible = False
        '
        'BookIDLabel
        '
        BookIDLabel.AutoSize = True
        BookIDLabel.Location = New System.Drawing.Point(14, 23)
        BookIDLabel.Name = "BookIDLabel"
        BookIDLabel.Size = New System.Drawing.Size(49, 13)
        BookIDLabel.TabIndex = 125
        BookIDLabel.Text = "Book ID:"
        '
        'BookNameLabel
        '
        BookNameLabel.AutoSize = True
        BookNameLabel.Location = New System.Drawing.Point(11, 68)
        BookNameLabel.Name = "BookNameLabel"
        BookNameLabel.Size = New System.Drawing.Size(66, 13)
        BookNameLabel.TabIndex = 127
        BookNameLabel.Text = "Book Name:"
        '
        'FileTypeIDLabel
        '
        FileTypeIDLabel.AutoSize = True
        FileTypeIDLabel.Location = New System.Drawing.Point(101, 23)
        FileTypeIDLabel.Name = "FileTypeIDLabel"
        FileTypeIDLabel.Size = New System.Drawing.Size(67, 13)
        FileTypeIDLabel.TabIndex = 131
        FileTypeIDLabel.Text = "File Type ID:"
        '
        'AuthorIDLabel1
        '
        AuthorIDLabel1.AutoSize = True
        AuthorIDLabel1.Location = New System.Drawing.Point(22, 22)
        AuthorIDLabel1.Name = "AuthorIDLabel1"
        AuthorIDLabel1.Size = New System.Drawing.Size(55, 13)
        AuthorIDLabel1.TabIndex = 133
        AuthorIDLabel1.Text = "Author ID:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(16, 118)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(66, 13)
        Label1.TabIndex = 146
        Label1.Text = "Book Name:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(402, 119)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(72, 13)
        Label3.TabIndex = 147
        Label3.Text = "Author Name:"
        '
        'FileTypeIDLabel2
        '
        FileTypeIDLabel2.AutoSize = True
        FileTypeIDLabel2.Location = New System.Drawing.Point(825, 267)
        FileTypeIDLabel2.Name = "FileTypeIDLabel2"
        FileTypeIDLabel2.Size = New System.Drawing.Size(67, 13)
        FileTypeIDLabel2.TabIndex = 146
        FileTypeIDLabel2.Text = "File Type ID:"
        '
        'FileExtensionLabel1
        '
        FileExtensionLabel1.AutoSize = True
        FileExtensionLabel1.Location = New System.Drawing.Point(825, 293)
        FileExtensionLabel1.Name = "FileExtensionLabel1"
        FileExtensionLabel1.Size = New System.Drawing.Size(75, 13)
        FileExtensionLabel1.TabIndex = 149
        FileExtensionLabel1.Text = "File Extension:"
        '
        'FileTypeLabel1
        '
        FileTypeLabel1.AutoSize = True
        FileTypeLabel1.Location = New System.Drawing.Point(825, 319)
        FileTypeLabel1.Name = "FileTypeLabel1"
        FileTypeLabel1.Size = New System.Drawing.Size(53, 13)
        FileTypeLabel1.TabIndex = 151
        FileTypeLabel1.Text = "File Type:"
        '
        'BookIDLabel1
        '
        BookIDLabel1.AutoSize = True
        BookIDLabel1.Location = New System.Drawing.Point(63, 213)
        BookIDLabel1.Name = "BookIDLabel1"
        BookIDLabel1.Size = New System.Drawing.Size(49, 13)
        BookIDLabel1.TabIndex = 143
        BookIDLabel1.Text = "Book ID:"
        '
        'FileTypeIDLabel3
        '
        FileTypeIDLabel3.AutoSize = True
        FileTypeIDLabel3.Location = New System.Drawing.Point(63, 239)
        FileTypeIDLabel3.Name = "FileTypeIDLabel3"
        FileTypeIDLabel3.Size = New System.Drawing.Size(67, 13)
        FileTypeIDLabel3.TabIndex = 145
        FileTypeIDLabel3.Text = "File Type ID:"
        '
        'AuthorNameLabel
        '
        AuthorNameLabel.AutoSize = True
        AuthorNameLabel.Location = New System.Drawing.Point(22, 66)
        AuthorNameLabel.Name = "AuthorNameLabel"
        AuthorNameLabel.Size = New System.Drawing.Size(72, 13)
        AuthorNameLabel.TabIndex = 154
        AuthorNameLabel.Text = "Author Name:"
        '
        'AuthorSurnameLabel
        '
        AuthorSurnameLabel.AutoSize = True
        AuthorSurnameLabel.Location = New System.Drawing.Point(22, 113)
        AuthorSurnameLabel.Name = "AuthorSurnameLabel"
        AuthorSurnameLabel.Size = New System.Drawing.Size(86, 13)
        AuthorSurnameLabel.TabIndex = 156
        AuthorSurnameLabel.Text = "Author Surname:"
        '
        'AuthorFullNameLabel
        '
        AuthorFullNameLabel.AutoSize = True
        AuthorFullNameLabel.Location = New System.Drawing.Point(22, 162)
        AuthorFullNameLabel.Name = "AuthorFullNameLabel"
        AuthorFullNameLabel.Size = New System.Drawing.Size(91, 13)
        AuthorFullNameLabel.TabIndex = 158
        AuthorFullNameLabel.Text = "Author Full Name:"
        '
        'txtBookRef
        '
        Me.txtBookRef.Location = New System.Drawing.Point(147, 12)
        Me.txtBookRef.Name = "txtBookRef"
        Me.txtBookRef.Size = New System.Drawing.Size(492, 20)
        Me.txtBookRef.TabIndex = 35
        '
        'Book_coversBindingSource
        '
        Me.Book_coversBindingSource.DataMember = "book_covers"
        Me.Book_coversBindingSource.DataSource = Me.BooklibDataSet
        '
        'BooklibDataSet
        '
        Me.BooklibDataSet.DataSetName = "booklibDataSet"
        Me.BooklibDataSet.EnforceConstraints = False
        Me.BooklibDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.btnImport.Location = New System.Drawing.Point(56, 415)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(75, 23)
        Me.btnImport.TabIndex = 40
        Me.btnImport.Text = "Import"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'BooksBindingSource
        '
        Me.BooksBindingSource.DataMember = "books"
        Me.BooksBindingSource.DataSource = Me.BooklibDataSet
        '
        'AuthorsBindingSource
        '
        Me.AuthorsBindingSource.DataMember = "authors"
        Me.AuthorsBindingSource.DataSource = Me.BooklibDataSet
        '
        'File_typesBindingSource
        '
        Me.File_typesBindingSource.DataMember = "file_types"
        Me.File_typesBindingSource.DataSource = Me.BooklibDataSet
        '
        'FileExtensionBookTextBox
        '
        Me.FileExtensionBookTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.File_typesBindingSource, "FileExtension", True))
        Me.FileExtensionBookTextBox.Location = New System.Drawing.Point(93, 130)
        Me.FileExtensionBookTextBox.Name = "FileExtensionBookTextBox"
        Me.FileExtensionBookTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FileExtensionBookTextBox.TabIndex = 59
        '
        'FileTypeBookTextBox
        '
        Me.FileTypeBookTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.File_typesBindingSource, "FileType", True))
        Me.FileTypeBookTextBox.Location = New System.Drawing.Point(210, 130)
        Me.FileTypeBookTextBox.Name = "FileTypeBookTextBox"
        Me.FileTypeBookTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FileTypeBookTextBox.TabIndex = 61
        Me.FileTypeBookTextBox.Visible = False
        '
        'File_types_copyBindingSource
        '
        Me.File_types_copyBindingSource.DataMember = "file_types_copy"
        Me.File_types_copyBindingSource.DataSource = Me.BooklibDataSet
        '
        'TreeView1
        '
        Me.TreeView1.Location = New System.Drawing.Point(56, 36)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(791, 372)
        Me.TreeView1.TabIndex = 82
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
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.Book_coversBindingSource, "Cover_Image", True))
        Me.PictureBox1.Location = New System.Drawing.Point(772, 52)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(246, 316)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 84
        Me.PictureBox1.TabStop = False
        '
        'BookIDTextBox
        '
        Me.BookIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BooksBindingSource, "BookID", True))
        Me.BookIDTextBox.Location = New System.Drawing.Point(14, 39)
        Me.BookIDTextBox.Name = "BookIDTextBox"
        Me.BookIDTextBox.Size = New System.Drawing.Size(64, 20)
        Me.BookIDTextBox.TabIndex = 126
        '
        'BookNameTextBox
        '
        Me.BookNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BooksBindingSource, "BookName", True))
        Me.BookNameTextBox.Location = New System.Drawing.Point(14, 83)
        Me.BookNameTextBox.Name = "BookNameTextBox"
        Me.BookNameTextBox.Size = New System.Drawing.Size(327, 20)
        Me.BookNameTextBox.TabIndex = 128
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpgBookList)
        Me.TabControl1.Controls.Add(Me.tpgSummary)
        Me.TabControl1.Location = New System.Drawing.Point(35, 1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1085, 481)
        Me.TabControl1.TabIndex = 141
        '
        'tpgBookList
        '
        Me.tpgBookList.Controls.Add(Me.TreeView1)
        Me.tpgBookList.Controls.Add(Me.btnImport)
        Me.tpgBookList.Location = New System.Drawing.Point(4, 22)
        Me.tpgBookList.Name = "tpgBookList"
        Me.tpgBookList.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgBookList.Size = New System.Drawing.Size(1077, 455)
        Me.tpgBookList.TabIndex = 0
        Me.tpgBookList.Text = "BookList"
        Me.tpgBookList.UseVisualStyleBackColor = True
        '
        'tpgSummary
        '
        Me.tpgSummary.Controls.Add(Me.Panel3)
        Me.tpgSummary.Controls.Add(Me.Panel2)
        Me.tpgSummary.Controls.Add(Label3)
        Me.tpgSummary.Controls.Add(Label1)
        Me.tpgSummary.Controls.Add(Me.txtBook)
        Me.tpgSummary.Controls.Add(Me.txtAuthor)
        Me.tpgSummary.Controls.Add(Me.Panel1)
        Me.tpgSummary.Controls.Add(Me.PictureBox1)
        Me.tpgSummary.Location = New System.Drawing.Point(4, 22)
        Me.tpgSummary.Name = "tpgSummary"
        Me.tpgSummary.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgSummary.Size = New System.Drawing.Size(1077, 455)
        Me.tpgSummary.TabIndex = 1
        Me.tpgSummary.Text = "Summary"
        Me.tpgSummary.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Silver
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.AuthorSurnameTextBox)
        Me.Panel3.Controls.Add(Me.CoverBookID)
        Me.Panel3.Controls.Add(Me.AuthorIDTextBox)
        Me.Panel3.Controls.Add(AuthorIDLabel1)
        Me.Panel3.Controls.Add(AuthorNameLabel)
        Me.Panel3.Controls.Add(Me.AuthorFullNameTextBox)
        Me.Panel3.Controls.Add(AuthorFullNameLabel)
        Me.Panel3.Controls.Add(Me.CoverFileTypeID)
        Me.Panel3.Controls.Add(Me.AuthorNameTextBox)
        Me.Panel3.Controls.Add(FileTypeIDLabel3)
        Me.Panel3.Controls.Add(BookIDLabel1)
        Me.Panel3.Controls.Add(AuthorSurnameLabel)
        Me.Panel3.Location = New System.Drawing.Point(405, 161)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(341, 267)
        Me.Panel3.TabIndex = 149
        '
        'AuthorSurnameTextBox
        '
        Me.AuthorSurnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuthorsBindingSource, "AuthorSurname", True))
        Me.AuthorSurnameTextBox.Location = New System.Drawing.Point(25, 129)
        Me.AuthorSurnameTextBox.Name = "AuthorSurnameTextBox"
        Me.AuthorSurnameTextBox.Size = New System.Drawing.Size(293, 20)
        Me.AuthorSurnameTextBox.TabIndex = 157
        '
        'CoverBookID
        '
        Me.CoverBookID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Book_coversBindingSource, "BookID", True))
        Me.CoverBookID.Location = New System.Drawing.Point(136, 206)
        Me.CoverBookID.Name = "CoverBookID"
        Me.CoverBookID.Size = New System.Drawing.Size(100, 20)
        Me.CoverBookID.TabIndex = 144
        '
        'AuthorIDTextBox
        '
        Me.AuthorIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuthorsBindingSource, "AuthorID", True))
        Me.AuthorIDTextBox.Location = New System.Drawing.Point(25, 38)
        Me.AuthorIDTextBox.Name = "AuthorIDTextBox"
        Me.AuthorIDTextBox.Size = New System.Drawing.Size(52, 20)
        Me.AuthorIDTextBox.TabIndex = 153
        '
        'AuthorFullNameTextBox
        '
        Me.AuthorFullNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuthorsBindingSource, "AuthorFullName", True))
        Me.AuthorFullNameTextBox.Location = New System.Drawing.Point(25, 178)
        Me.AuthorFullNameTextBox.Name = "AuthorFullNameTextBox"
        Me.AuthorFullNameTextBox.Size = New System.Drawing.Size(293, 20)
        Me.AuthorFullNameTextBox.TabIndex = 159
        '
        'CoverFileTypeID
        '
        Me.CoverFileTypeID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Book_coversBindingSource, "FileTypeID", True))
        Me.CoverFileTypeID.Location = New System.Drawing.Point(136, 236)
        Me.CoverFileTypeID.Name = "CoverFileTypeID"
        Me.CoverFileTypeID.Size = New System.Drawing.Size(100, 20)
        Me.CoverFileTypeID.TabIndex = 147
        '
        'AuthorNameTextBox
        '
        Me.AuthorNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuthorsBindingSource, "AuthorName", True))
        Me.AuthorNameTextBox.Location = New System.Drawing.Point(25, 82)
        Me.AuthorNameTextBox.Name = "AuthorNameTextBox"
        Me.AuthorNameTextBox.Size = New System.Drawing.Size(293, 20)
        Me.AuthorNameTextBox.TabIndex = 155
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(FileTypeIDLabel1)
        Me.Panel2.Controls.Add(FileExtensionLabel)
        Me.Panel2.Controls.Add(BookNameLabel)
        Me.Panel2.Controls.Add(FileTypeLabel)
        Me.Panel2.Controls.Add(Me.BookIDTextBox)
        Me.Panel2.Controls.Add(FileTypeIDLabel)
        Me.Panel2.Controls.Add(BookIDLabel)
        Me.Panel2.Controls.Add(Me.BookNameTextBox)
        Me.Panel2.Controls.Add(Me.FileExtensionBookTextBox)
        Me.Panel2.Controls.Add(Me.FileTypeBookTextBox)
        Me.Panel2.Location = New System.Drawing.Point(18, 160)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(360, 269)
        Me.Panel2.TabIndex = 148
        '
        'txtBook
        '
        Me.txtBook.Location = New System.Drawing.Point(18, 134)
        Me.txtBook.Name = "txtBook"
        Me.txtBook.Size = New System.Drawing.Size(360, 20)
        Me.txtBook.TabIndex = 145
        '
        'txtAuthor
        '
        Me.txtAuthor.Location = New System.Drawing.Point(405, 135)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(341, 20)
        Me.txtAuthor.TabIndex = 144
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGray
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtBookRef)
        Me.Panel1.Location = New System.Drawing.Point(33, 17)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(690, 50)
        Me.Panel1.TabIndex = 143
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 142
        Me.Label2.Text = "Book Entry"
        '
        'FileTypeIDCoverTextBox
        '
        Me.FileTypeIDCoverTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.File_types_copyBindingSource, "FileTypeID", True))
        Me.FileTypeIDCoverTextBox.Location = New System.Drawing.Point(906, 264)
        Me.FileTypeIDCoverTextBox.Name = "FileTypeIDCoverTextBox"
        Me.FileTypeIDCoverTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FileTypeIDCoverTextBox.TabIndex = 148
        '
        'FileExtensionCoverTextBox
        '
        Me.FileExtensionCoverTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.File_types_copyBindingSource, "FileExtension", True))
        Me.FileExtensionCoverTextBox.Location = New System.Drawing.Point(906, 290)
        Me.FileExtensionCoverTextBox.Name = "FileExtensionCoverTextBox"
        Me.FileExtensionCoverTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FileExtensionCoverTextBox.TabIndex = 150
        '
        'FileTypeTextBox
        '
        Me.FileTypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.File_types_copyBindingSource, "FileType", True))
        Me.FileTypeTextBox.Location = New System.Drawing.Point(906, 316)
        Me.FileTypeTextBox.Name = "FileTypeTextBox"
        Me.FileTypeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FileTypeTextBox.TabIndex = 152
        '
        'txtCoverFileName
        '
        Me.txtCoverFileName.Location = New System.Drawing.Point(801, 371)
        Me.txtCoverFileName.Name = "txtCoverFileName"
        Me.txtCoverFileName.Size = New System.Drawing.Size(246, 20)
        Me.txtCoverFileName.TabIndex = 142
        '
        'frmImportBooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1428, 531)
        Me.Controls.Add(FileTypeIDLabel2)
        Me.Controls.Add(Me.FileTypeIDCoverTextBox)
        Me.Controls.Add(FileExtensionLabel1)
        Me.Controls.Add(Me.FileExtensionCoverTextBox)
        Me.Controls.Add(FileTypeLabel1)
        Me.Controls.Add(Me.FileTypeTextBox)
        Me.Controls.Add(Me.txtCoverFileName)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnSave)
        Me.Name = "frmImportBooks"
        Me.Text = "frmImportBooks"
        CType(Me.Book_coversBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BooklibDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BooksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AuthorsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.File_typesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.File_types_copyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.tpgBookList.ResumeLayout(False)
        Me.tpgSummary.ResumeLayout(False)
        Me.tpgSummary.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtBookRef As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnImport As Button
    Friend WithEvents BooklibDataSet As booklibDataSet
    Friend WithEvents BooksBindingSource As BindingSource
    Friend WithEvents BooksTableAdapter As booklibDataSetTableAdapters.booksTableAdapter
    Friend WithEvents TableAdapterManager As booklibDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AuthorsTableAdapter As booklibDataSetTableAdapters.authorsTableAdapter
    Friend WithEvents AuthorsBindingSource As BindingSource
    Friend WithEvents File_typesTableAdapter As booklibDataSetTableAdapters.file_typesTableAdapter
    Friend WithEvents File_typesBindingSource As BindingSource
    Friend WithEvents FileExtensionBookTextBox As TextBox
    Friend WithEvents FileTypeBookTextBox As TextBox
    Friend WithEvents Book_coversBindingSource As BindingSource
    Friend WithEvents Book_coversTableAdapter As booklibDataSetTableAdapters.book_coversTableAdapter
    Friend WithEvents File_types_copyBindingSource As BindingSource
    Friend WithEvents File_types_copyTableAdapter As booklibDataSetTableAdapters.file_types_copyTableAdapter
    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BookIDTextBox As TextBox
    Friend WithEvents BookNameTextBox As TextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tpgBookList As TabPage
    Friend WithEvents tpgSummary As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents txtBook As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents AuthorSurnameTextBox As TextBox
    Friend WithEvents CoverBookID As TextBox
    Friend WithEvents AuthorIDTextBox As TextBox
    Friend WithEvents AuthorFullNameTextBox As TextBox
    Friend WithEvents CoverFileTypeID As TextBox
    Friend WithEvents AuthorNameTextBox As TextBox
    Friend WithEvents FileTypeIDCoverTextBox As TextBox
    Friend WithEvents FileExtensionCoverTextBox As TextBox
    Friend WithEvents FileTypeTextBox As TextBox
    Friend WithEvents txtCoverFileName As TextBox
End Class
