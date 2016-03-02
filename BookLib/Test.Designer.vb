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
        Dim AuthorIDLabel As System.Windows.Forms.Label
        Dim AuthorNameLabel As System.Windows.Forms.Label
        Dim AuthorSurnameLabel As System.Windows.Forms.Label
        Dim AuthorFullNameLabel As System.Windows.Forms.Label
        Dim BookIDLabel As System.Windows.Forms.Label
        Dim BookNameLabel As System.Windows.Forms.Label
        Dim AuthorIDLabel1 As System.Windows.Forms.Label
        Dim FileTypeIDLabel As System.Windows.Forms.Label
        Dim FileTypeIDLabel1 As System.Windows.Forms.Label
        Dim FileExtensionLabel As System.Windows.Forms.Label
        Dim FileTypeLabel As System.Windows.Forms.Label
        Me.FileSystemTree2 = New MasaSam.Forms.Controls.FileSystemTree()
        Me.AuthorIDTextBox = New System.Windows.Forms.TextBox()
        Me.AuthorNameTextBox = New System.Windows.Forms.TextBox()
        Me.AuthorSurnameTextBox = New System.Windows.Forms.TextBox()
        Me.AuthorFullNameTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BookIDTextBox = New System.Windows.Forms.TextBox()
        Me.BookNameTextBox = New System.Windows.Forms.TextBox()
        Me.AuthorIDTextBox1 = New System.Windows.Forms.TextBox()
        Me.FileTypeIDTextBox = New System.Windows.Forms.TextBox()
        Me.FileTypeIDTextBox1 = New System.Windows.Forms.TextBox()
        Me.FileExtensionTextBox = New System.Windows.Forms.TextBox()
        Me.FileTypeTextBox = New System.Windows.Forms.TextBox()
        Me.File_typesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BooklibDataSet = New BookLib.booklibDataSet()
        Me.BooksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AuthorsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AuthorsTableAdapter = New BookLib.booklibDataSetTableAdapters.authorsTableAdapter()
        Me.TableAdapterManager = New BookLib.booklibDataSetTableAdapters.TableAdapterManager()
        Me.BooksTableAdapter = New BookLib.booklibDataSetTableAdapters.booksTableAdapter()
        Me.File_typesTableAdapter = New BookLib.booklibDataSetTableAdapters.file_typesTableAdapter()
        AuthorIDLabel = New System.Windows.Forms.Label()
        AuthorNameLabel = New System.Windows.Forms.Label()
        AuthorSurnameLabel = New System.Windows.Forms.Label()
        AuthorFullNameLabel = New System.Windows.Forms.Label()
        BookIDLabel = New System.Windows.Forms.Label()
        BookNameLabel = New System.Windows.Forms.Label()
        AuthorIDLabel1 = New System.Windows.Forms.Label()
        FileTypeIDLabel = New System.Windows.Forms.Label()
        FileTypeIDLabel1 = New System.Windows.Forms.Label()
        FileExtensionLabel = New System.Windows.Forms.Label()
        FileTypeLabel = New System.Windows.Forms.Label()
        CType(Me.File_typesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BooklibDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BooksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AuthorsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AuthorIDLabel
        '
        AuthorIDLabel.AutoSize = True
        AuthorIDLabel.Location = New System.Drawing.Point(474, 45)
        AuthorIDLabel.Name = "AuthorIDLabel"
        AuthorIDLabel.Size = New System.Drawing.Size(55, 13)
        AuthorIDLabel.TabIndex = 3
        AuthorIDLabel.Text = "Author ID:"
        '
        'AuthorNameLabel
        '
        AuthorNameLabel.AutoSize = True
        AuthorNameLabel.Location = New System.Drawing.Point(474, 71)
        AuthorNameLabel.Name = "AuthorNameLabel"
        AuthorNameLabel.Size = New System.Drawing.Size(72, 13)
        AuthorNameLabel.TabIndex = 5
        AuthorNameLabel.Text = "Author Name:"
        '
        'AuthorSurnameLabel
        '
        AuthorSurnameLabel.AutoSize = True
        AuthorSurnameLabel.Location = New System.Drawing.Point(474, 97)
        AuthorSurnameLabel.Name = "AuthorSurnameLabel"
        AuthorSurnameLabel.Size = New System.Drawing.Size(86, 13)
        AuthorSurnameLabel.TabIndex = 7
        AuthorSurnameLabel.Text = "Author Surname:"
        '
        'AuthorFullNameLabel
        '
        AuthorFullNameLabel.AutoSize = True
        AuthorFullNameLabel.Location = New System.Drawing.Point(474, 123)
        AuthorFullNameLabel.Name = "AuthorFullNameLabel"
        AuthorFullNameLabel.Size = New System.Drawing.Size(91, 13)
        AuthorFullNameLabel.TabIndex = 9
        AuthorFullNameLabel.Text = "Author Full Name:"
        '
        'FileSystemTree2
        '
        Me.FileSystemTree2.FileExtensions = "*"
        Me.FileSystemTree2.Location = New System.Drawing.Point(12, 12)
        Me.FileSystemTree2.Name = "FileSystemTree2"
        Me.FileSystemTree2.RootDrive = Nothing
        Me.FileSystemTree2.Size = New System.Drawing.Size(359, 613)
        Me.FileSystemTree2.TabIndex = 2
        '
        'AuthorIDTextBox
        '
        Me.AuthorIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuthorsBindingSource, "AuthorID", True))
        Me.AuthorIDTextBox.Location = New System.Drawing.Point(571, 42)
        Me.AuthorIDTextBox.Name = "AuthorIDTextBox"
        Me.AuthorIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AuthorIDTextBox.TabIndex = 4
        '
        'AuthorNameTextBox
        '
        Me.AuthorNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuthorsBindingSource, "AuthorName", True))
        Me.AuthorNameTextBox.Location = New System.Drawing.Point(571, 68)
        Me.AuthorNameTextBox.Name = "AuthorNameTextBox"
        Me.AuthorNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AuthorNameTextBox.TabIndex = 6
        '
        'AuthorSurnameTextBox
        '
        Me.AuthorSurnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuthorsBindingSource, "AuthorSurname", True))
        Me.AuthorSurnameTextBox.Location = New System.Drawing.Point(571, 94)
        Me.AuthorSurnameTextBox.Name = "AuthorSurnameTextBox"
        Me.AuthorSurnameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AuthorSurnameTextBox.TabIndex = 8
        '
        'AuthorFullNameTextBox
        '
        Me.AuthorFullNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuthorsBindingSource, "AuthorFullName", True))
        Me.AuthorFullNameTextBox.Location = New System.Drawing.Point(571, 120)
        Me.AuthorFullNameTextBox.Name = "AuthorFullNameTextBox"
        Me.AuthorFullNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AuthorFullNameTextBox.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(477, 421)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(595, 421)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "save"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BookIDLabel
        '
        BookIDLabel.AutoSize = True
        BookIDLabel.Location = New System.Drawing.Point(476, 198)
        BookIDLabel.Name = "BookIDLabel"
        BookIDLabel.Size = New System.Drawing.Size(49, 13)
        BookIDLabel.TabIndex = 19
        BookIDLabel.Text = "Book ID:"
        '
        'BookIDTextBox
        '
        Me.BookIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BooksBindingSource, "BookID", True))
        Me.BookIDTextBox.Location = New System.Drawing.Point(549, 195)
        Me.BookIDTextBox.Name = "BookIDTextBox"
        Me.BookIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BookIDTextBox.TabIndex = 20
        '
        'BookNameLabel
        '
        BookNameLabel.AutoSize = True
        BookNameLabel.Location = New System.Drawing.Point(476, 224)
        BookNameLabel.Name = "BookNameLabel"
        BookNameLabel.Size = New System.Drawing.Size(66, 13)
        BookNameLabel.TabIndex = 21
        BookNameLabel.Text = "Book Name:"
        '
        'BookNameTextBox
        '
        Me.BookNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BooksBindingSource, "BookName", True))
        Me.BookNameTextBox.Location = New System.Drawing.Point(549, 221)
        Me.BookNameTextBox.Name = "BookNameTextBox"
        Me.BookNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BookNameTextBox.TabIndex = 22
        '
        'AuthorIDLabel1
        '
        AuthorIDLabel1.AutoSize = True
        AuthorIDLabel1.Location = New System.Drawing.Point(476, 250)
        AuthorIDLabel1.Name = "AuthorIDLabel1"
        AuthorIDLabel1.Size = New System.Drawing.Size(55, 13)
        AuthorIDLabel1.TabIndex = 23
        AuthorIDLabel1.Text = "Author ID:"
        '
        'AuthorIDTextBox1
        '
        Me.AuthorIDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BooksBindingSource, "AuthorID", True))
        Me.AuthorIDTextBox1.Location = New System.Drawing.Point(549, 247)
        Me.AuthorIDTextBox1.Name = "AuthorIDTextBox1"
        Me.AuthorIDTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.AuthorIDTextBox1.TabIndex = 24
        '
        'FileTypeIDLabel
        '
        FileTypeIDLabel.AutoSize = True
        FileTypeIDLabel.Location = New System.Drawing.Point(476, 276)
        FileTypeIDLabel.Name = "FileTypeIDLabel"
        FileTypeIDLabel.Size = New System.Drawing.Size(67, 13)
        FileTypeIDLabel.TabIndex = 25
        FileTypeIDLabel.Text = "File Type ID:"
        '
        'FileTypeIDTextBox
        '
        Me.FileTypeIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BooksBindingSource, "FileTypeID", True))
        Me.FileTypeIDTextBox.Location = New System.Drawing.Point(549, 273)
        Me.FileTypeIDTextBox.Name = "FileTypeIDTextBox"
        Me.FileTypeIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FileTypeIDTextBox.TabIndex = 26
        Me.FileTypeIDTextBox.Text = "13"
        '
        'FileTypeIDLabel1
        '
        FileTypeIDLabel1.AutoSize = True
        FileTypeIDLabel1.Location = New System.Drawing.Point(617, 329)
        FileTypeIDLabel1.Name = "FileTypeIDLabel1"
        FileTypeIDLabel1.Size = New System.Drawing.Size(67, 13)
        FileTypeIDLabel1.TabIndex = 26
        FileTypeIDLabel1.Text = "File Type ID:"
        '
        'FileTypeIDTextBox1
        '
        Me.FileTypeIDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.File_typesBindingSource, "FileTypeID", True))
        Me.FileTypeIDTextBox1.Location = New System.Drawing.Point(698, 326)
        Me.FileTypeIDTextBox1.Name = "FileTypeIDTextBox1"
        Me.FileTypeIDTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.FileTypeIDTextBox1.TabIndex = 27
        '
        'FileExtensionLabel
        '
        FileExtensionLabel.AutoSize = True
        FileExtensionLabel.Location = New System.Drawing.Point(617, 355)
        FileExtensionLabel.Name = "FileExtensionLabel"
        FileExtensionLabel.Size = New System.Drawing.Size(75, 13)
        FileExtensionLabel.TabIndex = 28
        FileExtensionLabel.Text = "File Extension:"
        '
        'FileExtensionTextBox
        '
        Me.FileExtensionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.File_typesBindingSource, "FileExtension", True))
        Me.FileExtensionTextBox.Location = New System.Drawing.Point(698, 352)
        Me.FileExtensionTextBox.Name = "FileExtensionTextBox"
        Me.FileExtensionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FileExtensionTextBox.TabIndex = 29
        '
        'FileTypeLabel
        '
        FileTypeLabel.AutoSize = True
        FileTypeLabel.Location = New System.Drawing.Point(617, 381)
        FileTypeLabel.Name = "FileTypeLabel"
        FileTypeLabel.Size = New System.Drawing.Size(53, 13)
        FileTypeLabel.TabIndex = 30
        FileTypeLabel.Text = "File Type:"
        '
        'FileTypeTextBox
        '
        Me.FileTypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.File_typesBindingSource, "FileType", True))
        Me.FileTypeTextBox.Location = New System.Drawing.Point(698, 378)
        Me.FileTypeTextBox.Name = "FileTypeTextBox"
        Me.FileTypeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FileTypeTextBox.TabIndex = 31
        '
        'File_typesBindingSource
        '
        Me.File_typesBindingSource.DataMember = "file_types"
        Me.File_typesBindingSource.DataSource = Me.BooklibDataSet
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
        'AuthorsBindingSource
        '
        Me.AuthorsBindingSource.DataMember = "authors"
        Me.AuthorsBindingSource.DataSource = Me.BooklibDataSet
        '
        'AuthorsTableAdapter
        '
        Me.AuthorsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.authorsTableAdapter = Me.AuthorsTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.booksTableAdapter = Nothing
        Me.TableAdapterManager.categoriesTableAdapter = Nothing
        Me.TableAdapterManager.file_typesTableAdapter = Nothing
        Me.TableAdapterManager.lib_controlTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = BookLib.booklibDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BooksTableAdapter
        '
        Me.BooksTableAdapter.ClearBeforeFill = True
        '
        'File_typesTableAdapter
        '
        Me.File_typesTableAdapter.ClearBeforeFill = True
        '
        'Test
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(939, 645)
        Me.Controls.Add(FileTypeIDLabel1)
        Me.Controls.Add(Me.FileTypeIDTextBox1)
        Me.Controls.Add(FileExtensionLabel)
        Me.Controls.Add(Me.FileExtensionTextBox)
        Me.Controls.Add(FileTypeLabel)
        Me.Controls.Add(Me.FileTypeTextBox)
        Me.Controls.Add(BookIDLabel)
        Me.Controls.Add(Me.BookIDTextBox)
        Me.Controls.Add(BookNameLabel)
        Me.Controls.Add(Me.BookNameTextBox)
        Me.Controls.Add(AuthorIDLabel1)
        Me.Controls.Add(Me.AuthorIDTextBox1)
        Me.Controls.Add(FileTypeIDLabel)
        Me.Controls.Add(Me.FileTypeIDTextBox)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(AuthorIDLabel)
        Me.Controls.Add(Me.AuthorIDTextBox)
        Me.Controls.Add(AuthorNameLabel)
        Me.Controls.Add(Me.AuthorNameTextBox)
        Me.Controls.Add(AuthorSurnameLabel)
        Me.Controls.Add(Me.AuthorSurnameTextBox)
        Me.Controls.Add(AuthorFullNameLabel)
        Me.Controls.Add(Me.AuthorFullNameTextBox)
        Me.Controls.Add(Me.FileSystemTree2)
        Me.Name = "Test"
        Me.Text = "Test"
        CType(Me.File_typesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BooklibDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BooksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AuthorsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FileSystemTree2 As MasaSam.Forms.Controls.FileSystemTree
    Friend WithEvents BooklibDataSet As booklibDataSet
    Friend WithEvents AuthorsBindingSource As BindingSource
    Friend WithEvents AuthorsTableAdapter As booklibDataSetTableAdapters.authorsTableAdapter
    Friend WithEvents TableAdapterManager As booklibDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AuthorIDTextBox As TextBox
    Friend WithEvents AuthorNameTextBox As TextBox
    Friend WithEvents AuthorSurnameTextBox As TextBox
    Friend WithEvents AuthorFullNameTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents BooksBindingSource As BindingSource
    Friend WithEvents BooksTableAdapter As booklibDataSetTableAdapters.booksTableAdapter
    Friend WithEvents BookIDTextBox As TextBox
    Friend WithEvents BookNameTextBox As TextBox
    Friend WithEvents AuthorIDTextBox1 As TextBox
    Friend WithEvents FileTypeIDTextBox As TextBox
    Friend WithEvents File_typesBindingSource As BindingSource
    Friend WithEvents File_typesTableAdapter As booklibDataSetTableAdapters.file_typesTableAdapter
    Friend WithEvents FileTypeIDTextBox1 As TextBox
    Friend WithEvents FileExtensionTextBox As TextBox
    Friend WithEvents FileTypeTextBox As TextBox
End Class
