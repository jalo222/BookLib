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
        Dim AuthorIDLabel1 As System.Windows.Forms.Label
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
        Me.txtAuthorName = New System.Windows.Forms.TextBox()
        Me.txtAuthorSurname = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BooksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BookNameTextBox = New System.Windows.Forms.TextBox()
        Me.v_FirstName = New System.Windows.Forms.TextBox()
        Me.v_Surname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.File_typesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.File_typesTableAdapter = New BookLib.booklibDataSetTableAdapters.file_typesTableAdapter()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.BooksBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AuthorIDComboBox = New System.Windows.Forms.ComboBox()
        Me.AuthorsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        AuthorNameLabel = New System.Windows.Forms.Label()
        AuthorSurnameLabel = New System.Windows.Forms.Label()
        BookNameLabel = New System.Windows.Forms.Label()
        AuthorIDLabel1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.BooklibDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AuthorsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.BooksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.File_typesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.BooklibDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AuthorsBindingSource
        '
        Me.AuthorsBindingSource.AllowNew = False
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
        Me.TableAdapterManager.book_coversTableAdapter = Nothing
        Me.TableAdapterManager.booksTableAdapter = Me.BooksTableAdapter
        Me.TableAdapterManager.categoriesTableAdapter = Nothing
        Me.TableAdapterManager.file_typesTableAdapter = Nothing
        Me.TableAdapterManager.lib_controlTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = BookLib.booklibDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BooksTableAdapter
        '
        Me.BooksTableAdapter.ClearBeforeFill = True
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
        Me.txtAuthorSurname.Location = New System.Drawing.Point(89, 64)
        Me.txtAuthorSurname.Name = "txtAuthorSurname"
        Me.txtAuthorSurname.Size = New System.Drawing.Size(310, 20)
        Me.txtAuthorSurname.TabIndex = 22
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(AuthorIDLabel1)
        Me.Panel2.Controls.Add(Me.AuthorIDComboBox)
        Me.Panel2.Controls.Add(Me.txtAuthorSurname)
        Me.Panel2.Controls.Add(AuthorSurnameLabel)
        Me.Panel2.Controls.Add(AuthorNameLabel)
        Me.Panel2.Controls.Add(Me.txtAuthorName)
        Me.Panel2.Location = New System.Drawing.Point(448, 158)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(423, 108)
        Me.Panel2.TabIndex = 23
        '
        'BooksBindingSource
        '
        Me.BooksBindingSource.DataMember = "books"
        Me.BooksBindingSource.DataSource = Me.BooklibDataSet
        '
        'BookNameTextBox
        '
        Me.BookNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BooksBindingSource, "BookName", True))
        Me.BookNameTextBox.Location = New System.Drawing.Point(452, 62)
        Me.BookNameTextBox.Name = "BookNameTextBox"
        Me.BookNameTextBox.Size = New System.Drawing.Size(412, 20)
        Me.BookNameTextBox.TabIndex = 24
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
        'File_typesBindingSource
        '
        Me.File_typesBindingSource.DataMember = "file_types"
        Me.File_typesBindingSource.DataSource = Me.BooklibDataSet
        '
        'File_typesTableAdapter
        '
        Me.File_typesTableAdapter.ClearBeforeFill = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(458, 277)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 95)
        Me.ListBox1.TabIndex = 29
        Me.ListBox1.ValueMember = "AuthorID"
        '
        'BooksBindingSource1
        '
        Me.BooksBindingSource1.DataMember = "FB_Author"
        Me.BooksBindingSource1.DataSource = Me.AuthorsBindingSource
        '
        'AuthorIDLabel1
        '
        AuthorIDLabel1.AutoSize = True
        AuthorIDLabel1.Location = New System.Drawing.Point(28, 14)
        AuthorIDLabel1.Name = "AuthorIDLabel1"
        AuthorIDLabel1.Size = New System.Drawing.Size(55, 13)
        AuthorIDLabel1.TabIndex = 22
        AuthorIDLabel1.Text = "Author ID:"
        '
        'AuthorIDComboBox
        '
        Me.AuthorIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BooksBindingSource1, "AuthorID", True))
        Me.AuthorIDComboBox.DataSource = Me.AuthorsBindingSource1
        Me.AuthorIDComboBox.DisplayMember = "AuthorName"
        Me.AuthorIDComboBox.FormattingEnabled = True
        Me.AuthorIDComboBox.Location = New System.Drawing.Point(89, 11)
        Me.AuthorIDComboBox.Name = "AuthorIDComboBox"
        Me.AuthorIDComboBox.Size = New System.Drawing.Size(121, 21)
        Me.AuthorIDComboBox.TabIndex = 23
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
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.v_Surname)
        Me.Controls.Add(Me.v_FirstName)
        Me.Controls.Add(BookNameLabel)
        Me.Controls.Add(Me.BookNameTextBox)
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
        CType(Me.BooksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.File_typesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents BookNameTextBox As TextBox
    Friend WithEvents v_FirstName As TextBox
    Friend WithEvents v_Surname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents File_typesBindingSource As BindingSource
    Friend WithEvents File_typesTableAdapter As booklibDataSetTableAdapters.file_typesTableAdapter
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents AuthorIDComboBox As ComboBox
    Friend WithEvents BooksBindingSource1 As BindingSource
    Friend WithEvents AuthorsBindingSource1 As BindingSource
End Class
