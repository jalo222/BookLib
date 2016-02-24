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
        Dim AuthorNameLabel As System.Windows.Forms.Label
        Dim AuthorSurnameLabel As System.Windows.Forms.Label
        Dim BookNameLabel As System.Windows.Forms.Label
        Dim FileTypeIDLabel As System.Windows.Forms.Label
        Dim FileExtensionLabel As System.Windows.Forms.Label
        Dim FileTypeLabel As System.Windows.Forms.Label
        Dim AuthorIDLabel As System.Windows.Forms.Label
        Dim AuthorIDLabel1 As System.Windows.Forms.Label
        Dim AuthorNameLabel1 As System.Windows.Forms.Label
        Dim AuthorSurnameLabel1 As System.Windows.Forms.Label
        Me.FileSystemTree2 = New MasaSam.Forms.Controls.FileSystemTree()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtCoverFileName = New System.Windows.Forms.TextBox()
        Me.txtBookRef = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BooklibDataSet = New BookLib.booklibDataSet()
        Me.AuthorsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AuthorsTableAdapter = New BookLib.booklibDataSetTableAdapters.authorsTableAdapter()
        Me.TableAdapterManager = New BookLib.booklibDataSetTableAdapters.TableAdapterManager()
        Me.BooksTableAdapter = New BookLib.booklibDataSetTableAdapters.booksTableAdapter()
        Me.File_typesTableAdapter = New BookLib.booklibDataSetTableAdapters.file_typesTableAdapter()
        Me.txtAuthorName = New System.Windows.Forms.TextBox()
        Me.txtAuthorSurname = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.AuthorIDTextBox = New System.Windows.Forms.TextBox()
        Me.BooksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtBookName = New System.Windows.Forms.TextBox()
        Me.v_FirstName = New System.Windows.Forms.TextBox()
        Me.v_Surname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFileTypeID = New System.Windows.Forms.TextBox()
        Me.File_typesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtFileExtension = New System.Windows.Forms.TextBox()
        Me.txtFileType = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.v_FileType = New System.Windows.Forms.TextBox()
        Me.AuthorNameTextBox = New System.Windows.Forms.TextBox()
        Me.AuthorSurnameTextBox = New System.Windows.Forms.TextBox()
        Me.BooksBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AuthorIDComboBox = New System.Windows.Forms.ComboBox()
        Me.AuthorsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        AuthorNameLabel = New System.Windows.Forms.Label()
        AuthorSurnameLabel = New System.Windows.Forms.Label()
        BookNameLabel = New System.Windows.Forms.Label()
        FileTypeIDLabel = New System.Windows.Forms.Label()
        FileExtensionLabel = New System.Windows.Forms.Label()
        FileTypeLabel = New System.Windows.Forms.Label()
        AuthorIDLabel = New System.Windows.Forms.Label()
        AuthorIDLabel1 = New System.Windows.Forms.Label()
        AuthorNameLabel1 = New System.Windows.Forms.Label()
        AuthorSurnameLabel1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.BooklibDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AuthorsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.BooksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.File_typesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.BooksBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AuthorsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AuthorNameLabel
        '
        AuthorNameLabel.AutoSize = True
        AuthorNameLabel.Location = New System.Drawing.Point(11, 41)
        AuthorNameLabel.Name = "AuthorNameLabel"
        AuthorNameLabel.Size = New System.Drawing.Size(72, 13)
        AuthorNameLabel.TabIndex = 20
        AuthorNameLabel.Text = "Author Name:"
        '
        'AuthorSurnameLabel
        '
        AuthorSurnameLabel.AutoSize = True
        AuthorSurnameLabel.Location = New System.Drawing.Point(1, 67)
        AuthorSurnameLabel.Name = "AuthorSurnameLabel"
        AuthorSurnameLabel.Size = New System.Drawing.Size(86, 13)
        AuthorSurnameLabel.TabIndex = 21
        AuthorSurnameLabel.Text = "Author Surname:"
        '
        'BookNameLabel
        '
        BookNameLabel.AutoSize = True
        BookNameLabel.Location = New System.Drawing.Point(384, 65)
        BookNameLabel.Name = "BookNameLabel"
        BookNameLabel.Size = New System.Drawing.Size(66, 13)
        BookNameLabel.TabIndex = 23
        BookNameLabel.Text = "Book Name:"
        '
        'FileTypeIDLabel
        '
        FileTypeIDLabel.AutoSize = True
        FileTypeIDLabel.Location = New System.Drawing.Point(17, 21)
        FileTypeIDLabel.Name = "FileTypeIDLabel"
        FileTypeIDLabel.Size = New System.Drawing.Size(67, 13)
        FileTypeIDLabel.TabIndex = 28
        FileTypeIDLabel.Text = "File Type ID:"
        '
        'FileExtensionLabel
        '
        FileExtensionLabel.AutoSize = True
        FileExtensionLabel.Location = New System.Drawing.Point(28, 52)
        FileExtensionLabel.Name = "FileExtensionLabel"
        FileExtensionLabel.Size = New System.Drawing.Size(56, 13)
        FileExtensionLabel.TabIndex = 29
        FileExtensionLabel.Text = "Extension:"
        '
        'FileTypeLabel
        '
        FileTypeLabel.AutoSize = True
        FileTypeLabel.Location = New System.Drawing.Point(33, 82)
        FileTypeLabel.Name = "FileTypeLabel"
        FileTypeLabel.Size = New System.Drawing.Size(53, 13)
        FileTypeLabel.TabIndex = 30
        FileTypeLabel.Text = "File Type:"
        '
        'AuthorIDLabel
        '
        AuthorIDLabel.AutoSize = True
        AuthorIDLabel.Location = New System.Drawing.Point(28, 15)
        AuthorIDLabel.Name = "AuthorIDLabel"
        AuthorIDLabel.Size = New System.Drawing.Size(55, 13)
        AuthorIDLabel.TabIndex = 22
        AuthorIDLabel.Text = "Author ID:"
        '
        'FileSystemTree2
        '
        Me.FileSystemTree2.FileExtensions = "*"
        Me.FileSystemTree2.Location = New System.Drawing.Point(12, 13)
        Me.FileSystemTree2.Name = "FileSystemTree2"
        Me.FileSystemTree2.RootDrive = Nothing
        Me.FileSystemTree2.Size = New System.Drawing.Size(359, 613)
        Me.FileSystemTree2.TabIndex = 1
        '
        'btnImport
        '
        Me.btnImport.Location = New System.Drawing.Point(81, 632)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(75, 23)
        Me.btnImport.TabIndex = 2
        Me.btnImport.Text = "Import"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(880, 114)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(246, 316)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(481, 632)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtCoverFileName
        '
        Me.txtCoverFileName.Location = New System.Drawing.Point(880, 88)
        Me.txtCoverFileName.Name = "txtCoverFileName"
        Me.txtCoverFileName.Size = New System.Drawing.Size(246, 20)
        Me.txtCoverFileName.TabIndex = 5
        '
        'txtBookRef
        '
        Me.txtBookRef.Location = New System.Drawing.Point(69, 5)
        Me.txtBookRef.Name = "txtBookRef"
        Me.txtBookRef.Size = New System.Drawing.Size(669, 20)
        Me.txtBookRef.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Book"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Label2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(386, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Author"
        '
        'txtAuthor
        '
        Me.txtAuthor.Location = New System.Drawing.Point(448, 88)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(416, 20)
        Me.txtAuthor.TabIndex = 12
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtBookRef)
        Me.Panel1.Location = New System.Drawing.Point(377, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(749, 35)
        Me.Panel1.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(0, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Label7"
        '
        'BooklibDataSet
        '
        Me.BooklibDataSet.DataSetName = "booklibDataSet"
        Me.BooklibDataSet.EnforceConstraints = False
        Me.BooklibDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AuthorsBindingSource
        '
        Me.AuthorsBindingSource.AllowNew = True
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
        Me.TableAdapterManager.booksTableAdapter = Me.BooksTableAdapter
        Me.TableAdapterManager.categoriesTableAdapter = Nothing
        Me.TableAdapterManager.file_typesTableAdapter = Me.File_typesTableAdapter
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
        'txtAuthorName
        '
        Me.txtAuthorName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuthorsBindingSource, "AuthorName", True))
        Me.txtAuthorName.Location = New System.Drawing.Point(89, 38)
        Me.txtAuthorName.Name = "txtAuthorName"
        Me.txtAuthorName.Size = New System.Drawing.Size(310, 20)
        Me.txtAuthorName.TabIndex = 21
        '
        'txtAuthorSurname
        '
        Me.txtAuthorSurname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuthorsBindingSource, "AuthorSurname", True))
        Me.txtAuthorSurname.Location = New System.Drawing.Point(89, 64)
        Me.txtAuthorSurname.Name = "txtAuthorSurname"
        Me.txtAuthorSurname.Size = New System.Drawing.Size(310, 20)
        Me.txtAuthorSurname.TabIndex = 22
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(AuthorIDLabel)
        Me.Panel2.Controls.Add(Me.AuthorIDTextBox)
        Me.Panel2.Controls.Add(Me.txtAuthorSurname)
        Me.Panel2.Controls.Add(AuthorSurnameLabel)
        Me.Panel2.Controls.Add(AuthorNameLabel)
        Me.Panel2.Controls.Add(Me.txtAuthorName)
        Me.Panel2.Location = New System.Drawing.Point(448, 158)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(425, 129)
        Me.Panel2.TabIndex = 23
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.AuthorIDComboBox)
        Me.Panel3.Controls.Add(AuthorIDLabel1)
        Me.Panel3.Controls.Add(AuthorNameLabel1)
        Me.Panel3.Controls.Add(Me.AuthorNameTextBox)
        Me.Panel3.Controls.Add(AuthorSurnameLabel1)
        Me.Panel3.Controls.Add(Me.AuthorSurnameTextBox)
        Me.Panel3.Location = New System.Drawing.Point(-2, -2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(423, 127)
        Me.Panel3.TabIndex = 24
        '
        'AuthorIDTextBox
        '
        Me.AuthorIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuthorsBindingSource, "AuthorID", True))
        Me.AuthorIDTextBox.Location = New System.Drawing.Point(89, 12)
        Me.AuthorIDTextBox.Name = "AuthorIDTextBox"
        Me.AuthorIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AuthorIDTextBox.TabIndex = 23
        '
        'BooksBindingSource
        '
        Me.BooksBindingSource.DataMember = "books"
        Me.BooksBindingSource.DataSource = Me.BooklibDataSet
        '
        'txtBookName
        '
        Me.txtBookName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BooksBindingSource, "BookName", True))
        Me.txtBookName.Location = New System.Drawing.Point(452, 62)
        Me.txtBookName.Name = "txtBookName"
        Me.txtBookName.Size = New System.Drawing.Size(412, 20)
        Me.txtBookName.TabIndex = 24
        '
        'v_FirstName
        '
        Me.v_FirstName.Location = New System.Drawing.Point(448, 115)
        Me.v_FirstName.Name = "v_FirstName"
        Me.v_FirstName.Size = New System.Drawing.Size(134, 20)
        Me.v_FirstName.TabIndex = 25
        '
        'v_Surname
        '
        Me.v_Surname.Location = New System.Drawing.Point(706, 114)
        Me.v_Surname.Name = "v_Surname"
        Me.v_Surname.Size = New System.Drawing.Size(158, 20)
        Me.v_Surname.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(387, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "First Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(607, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Surname"
        '
        'txtFileTypeID
        '
        Me.txtFileTypeID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.File_typesBindingSource, "FileTypeID", True))
        Me.txtFileTypeID.Location = New System.Drawing.Point(92, 14)
        Me.txtFileTypeID.Name = "txtFileTypeID"
        Me.txtFileTypeID.Size = New System.Drawing.Size(38, 20)
        Me.txtFileTypeID.TabIndex = 29
        '
        'File_typesBindingSource
        '
        Me.File_typesBindingSource.DataMember = "file_types"
        Me.File_typesBindingSource.DataSource = Me.BooklibDataSet
        '
        'txtFileExtension
        '
        Me.txtFileExtension.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.File_typesBindingSource, "FileExtension", True))
        Me.txtFileExtension.Location = New System.Drawing.Point(92, 49)
        Me.txtFileExtension.Name = "txtFileExtension"
        Me.txtFileExtension.Size = New System.Drawing.Size(60, 20)
        Me.txtFileExtension.TabIndex = 30
        '
        'txtFileType
        '
        Me.txtFileType.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.File_typesBindingSource, "FileType", True))
        Me.txtFileType.Location = New System.Drawing.Point(92, 79)
        Me.txtFileType.Name = "txtFileType"
        Me.txtFileType.Size = New System.Drawing.Size(310, 20)
        Me.txtFileType.TabIndex = 31
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.txtFileType)
        Me.Panel4.Controls.Add(Me.txtFileTypeID)
        Me.Panel4.Controls.Add(FileTypeIDLabel)
        Me.Panel4.Controls.Add(FileTypeLabel)
        Me.Panel4.Controls.Add(Me.txtFileExtension)
        Me.Panel4.Controls.Add(FileExtensionLabel)
        Me.Panel4.Location = New System.Drawing.Point(447, 288)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(417, 111)
        Me.Panel4.TabIndex = 33
        '
        'v_FileType
        '
        Me.v_FileType.Location = New System.Drawing.Point(448, 141)
        Me.v_FileType.Name = "v_FileType"
        Me.v_FileType.Size = New System.Drawing.Size(82, 20)
        Me.v_FileType.TabIndex = 35
        '
        'AuthorIDLabel1
        '
        AuthorIDLabel1.AutoSize = True
        AuthorIDLabel1.Location = New System.Drawing.Point(39, 22)
        AuthorIDLabel1.Name = "AuthorIDLabel1"
        AuthorIDLabel1.Size = New System.Drawing.Size(55, 13)
        AuthorIDLabel1.TabIndex = 0
        AuthorIDLabel1.Text = "Author ID:"
        '
        'AuthorNameLabel1
        '
        AuthorNameLabel1.AutoSize = True
        AuthorNameLabel1.Location = New System.Drawing.Point(39, 49)
        AuthorNameLabel1.Name = "AuthorNameLabel1"
        AuthorNameLabel1.Size = New System.Drawing.Size(72, 13)
        AuthorNameLabel1.TabIndex = 2
        AuthorNameLabel1.Text = "Author Name:"
        '
        'AuthorNameTextBox
        '
        Me.AuthorNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuthorsBindingSource, "AuthorName", True))
        Me.AuthorNameTextBox.Location = New System.Drawing.Point(131, 46)
        Me.AuthorNameTextBox.Name = "AuthorNameTextBox"
        Me.AuthorNameTextBox.Size = New System.Drawing.Size(121, 20)
        Me.AuthorNameTextBox.TabIndex = 3
        '
        'AuthorSurnameLabel1
        '
        AuthorSurnameLabel1.AutoSize = True
        AuthorSurnameLabel1.Location = New System.Drawing.Point(39, 75)
        AuthorSurnameLabel1.Name = "AuthorSurnameLabel1"
        AuthorSurnameLabel1.Size = New System.Drawing.Size(86, 13)
        AuthorSurnameLabel1.TabIndex = 4
        AuthorSurnameLabel1.Text = "Author Surname:"
        '
        'AuthorSurnameTextBox
        '
        Me.AuthorSurnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuthorsBindingSource, "AuthorSurname", True))
        Me.AuthorSurnameTextBox.Location = New System.Drawing.Point(131, 72)
        Me.AuthorSurnameTextBox.Name = "AuthorSurnameTextBox"
        Me.AuthorSurnameTextBox.Size = New System.Drawing.Size(121, 20)
        Me.AuthorSurnameTextBox.TabIndex = 5
        '
        'BooksBindingSource1
        '
        Me.BooksBindingSource1.DataMember = "FB_Author"
        Me.BooksBindingSource1.DataSource = Me.AuthorsBindingSource
        '
        'AuthorIDComboBox
        '
        Me.AuthorIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BooksBindingSource1, "AuthorID", True))
        Me.AuthorIDComboBox.DataSource = Me.AuthorsBindingSource1
        Me.AuthorIDComboBox.DisplayMember = "AuthorName"
        Me.AuthorIDComboBox.FormattingEnabled = True
        Me.AuthorIDComboBox.Location = New System.Drawing.Point(131, 15)
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
        'frmImportBooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1162, 675)
        Me.Controls.Add(Me.v_FileType)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.v_Surname)
        Me.Controls.Add(Me.v_FirstName)
        Me.Controls.Add(BookNameLabel)
        Me.Controls.Add(Me.txtBookName)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtAuthor)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCoverFileName)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnImport)
        Me.Controls.Add(Me.FileSystemTree2)
        Me.Name = "frmImportBooks"
        Me.Text = "frmImportBooks"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BooklibDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AuthorsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.BooksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.File_typesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.BooksBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AuthorsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FileSystemTree2 As MasaSam.Forms.Controls.FileSystemTree
    Friend WithEvents btnImport As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnSave As Button
    Friend WithEvents txtCoverFileName As TextBox
    Friend WithEvents txtBookRef As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents BooklibDataSet As booklibDataSet
    Friend WithEvents AuthorsBindingSource As BindingSource
    Friend WithEvents AuthorsTableAdapter As booklibDataSetTableAdapters.authorsTableAdapter
    Friend WithEvents TableAdapterManager As booklibDataSetTableAdapters.TableAdapterManager
    Friend WithEvents txtAuthorName As TextBox
    Friend WithEvents txtAuthorSurname As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BooksTableAdapter As booklibDataSetTableAdapters.booksTableAdapter
    Friend WithEvents BooksBindingSource As BindingSource
    Friend WithEvents txtBookName As TextBox
    Friend WithEvents v_FirstName As TextBox
    Friend WithEvents v_Surname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtFileTypeID As TextBox
    Friend WithEvents File_typesBindingSource As BindingSource
    Friend WithEvents File_typesTableAdapter As booklibDataSetTableAdapters.file_typesTableAdapter
    Friend WithEvents txtFileExtension As TextBox
    Friend WithEvents txtFileType As TextBox
    Friend WithEvents AuthorIDTextBox As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents v_FileType As TextBox
    Friend WithEvents AuthorNameTextBox As TextBox
    Friend WithEvents AuthorSurnameTextBox As TextBox
    Friend WithEvents AuthorIDComboBox As ComboBox
    Friend WithEvents BooksBindingSource1 As BindingSource
    Friend WithEvents AuthorsBindingSource1 As BindingSource
End Class
