﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Dim AuthorIDLabel1 As System.Windows.Forms.Label
        Dim AuthorIDLabel As System.Windows.Forms.Label
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
        Me.AuthorIDTextBox = New System.Windows.Forms.TextBox()
        Me.BooksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtBookName = New System.Windows.Forms.TextBox()
        Me.v_FirstName = New System.Windows.Forms.TextBox()
        Me.v_Surname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.FileTypeIDTextBox = New System.Windows.Forms.TextBox()
        Me.File_typesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.File_typesTableAdapter = New BookLib.booklibDataSetTableAdapters.file_typesTableAdapter()
        Me.FileExtensionTextBox = New System.Windows.Forms.TextBox()
        Me.FileTypeTextBox = New System.Windows.Forms.TextBox()
        Me.txtBookAuthID = New System.Windows.Forms.TextBox()
        AuthorNameLabel = New System.Windows.Forms.Label()
        AuthorSurnameLabel = New System.Windows.Forms.Label()
        BookNameLabel = New System.Windows.Forms.Label()
        FileTypeIDLabel = New System.Windows.Forms.Label()
        FileExtensionLabel = New System.Windows.Forms.Label()
        FileTypeLabel = New System.Windows.Forms.Label()
        AuthorIDLabel1 = New System.Windows.Forms.Label()
        AuthorIDLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.BooklibDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AuthorsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.BooksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.File_typesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        FileTypeIDLabel.Location = New System.Drawing.Point(375, 275)
        FileTypeIDLabel.Name = "FileTypeIDLabel"
        FileTypeIDLabel.Size = New System.Drawing.Size(67, 13)
        FileTypeIDLabel.TabIndex = 28
        FileTypeIDLabel.Text = "File Type ID:"
        '
        'FileExtensionLabel
        '
        FileExtensionLabel.AutoSize = True
        FileExtensionLabel.Location = New System.Drawing.Point(384, 310)
        FileExtensionLabel.Name = "FileExtensionLabel"
        FileExtensionLabel.Size = New System.Drawing.Size(56, 13)
        FileExtensionLabel.TabIndex = 29
        FileExtensionLabel.Text = "Extension:"
        '
        'FileTypeLabel
        '
        FileTypeLabel.AutoSize = True
        FileTypeLabel.Location = New System.Drawing.Point(522, 310)
        FileTypeLabel.Name = "FileTypeLabel"
        FileTypeLabel.Size = New System.Drawing.Size(53, 13)
        FileTypeLabel.TabIndex = 30
        FileTypeLabel.Text = "File Type:"
        '
        'AuthorIDLabel1
        '
        AuthorIDLabel1.AutoSize = True
        AuthorIDLabel1.Location = New System.Drawing.Point(387, 144)
        AuthorIDLabel1.Name = "AuthorIDLabel1"
        AuthorIDLabel1.Size = New System.Drawing.Size(55, 13)
        AuthorIDLabel1.TabIndex = 31
        AuthorIDLabel1.Text = "Author ID:"
        AuthorIDLabel1.Visible = False
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
        Me.Label4.Visible = False
        '
        'txtAuthor
        '
        Me.txtAuthor.Location = New System.Drawing.Point(448, 88)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(416, 20)
        Me.txtAuthor.TabIndex = 12
        Me.txtAuthor.Visible = False
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
        Me.Panel2.Controls.Add(AuthorIDLabel)
        Me.Panel2.Controls.Add(Me.AuthorIDTextBox)
        Me.Panel2.Controls.Add(Me.txtAuthorSurname)
        Me.Panel2.Controls.Add(AuthorSurnameLabel)
        Me.Panel2.Controls.Add(AuthorNameLabel)
        Me.Panel2.Controls.Add(Me.txtAuthorName)
        Me.Panel2.Location = New System.Drawing.Point(448, 158)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(423, 108)
        Me.Panel2.TabIndex = 23
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
        Me.v_FirstName.Visible = False
        '
        'v_Surname
        '
        Me.v_Surname.Location = New System.Drawing.Point(706, 114)
        Me.v_Surname.Name = "v_Surname"
        Me.v_Surname.Size = New System.Drawing.Size(158, 20)
        Me.v_Surname.TabIndex = 26
        Me.v_Surname.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(387, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "First Name"
        Me.Label3.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(607, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Surname"
        Me.Label5.Visible = False
        '
        'FileTypeIDTextBox
        '
        Me.FileTypeIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BooksBindingSource, "FileTypeID", True))
        Me.FileTypeIDTextBox.Location = New System.Drawing.Point(448, 272)
        Me.FileTypeIDTextBox.Name = "FileTypeIDTextBox"
        Me.FileTypeIDTextBox.Size = New System.Drawing.Size(38, 20)
        Me.FileTypeIDTextBox.TabIndex = 29
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
        'FileExtensionTextBox
        '
        Me.FileExtensionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.File_typesBindingSource, "FileExtension", True))
        Me.FileExtensionTextBox.Location = New System.Drawing.Point(448, 307)
        Me.FileExtensionTextBox.Name = "FileExtensionTextBox"
        Me.FileExtensionTextBox.Size = New System.Drawing.Size(60, 20)
        Me.FileExtensionTextBox.TabIndex = 30
        '
        'FileTypeTextBox
        '
        Me.FileTypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.File_typesBindingSource, "FileType", True))
        Me.FileTypeTextBox.Location = New System.Drawing.Point(581, 307)
        Me.FileTypeTextBox.Name = "FileTypeTextBox"
        Me.FileTypeTextBox.Size = New System.Drawing.Size(268, 20)
        Me.FileTypeTextBox.TabIndex = 31
        '
        'txtBookAuthID
        '
        Me.txtBookAuthID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BooksBindingSource, "AuthorID", True))
        Me.txtBookAuthID.Location = New System.Drawing.Point(448, 141)
        Me.txtBookAuthID.Name = "txtBookAuthID"
        Me.txtBookAuthID.Size = New System.Drawing.Size(100, 20)
        Me.txtBookAuthID.TabIndex = 32
        Me.txtBookAuthID.Visible = False
        '
        'frmImportBooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1162, 675)
        Me.Controls.Add(AuthorIDLabel1)
        Me.Controls.Add(Me.txtBookAuthID)
        Me.Controls.Add(FileTypeLabel)
        Me.Controls.Add(Me.FileTypeTextBox)
        Me.Controls.Add(FileExtensionLabel)
        Me.Controls.Add(Me.FileExtensionTextBox)
        Me.Controls.Add(FileTypeIDLabel)
        Me.Controls.Add(Me.FileTypeIDTextBox)
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
        CType(Me.BooksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.File_typesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents FileTypeIDTextBox As TextBox
    Friend WithEvents File_typesBindingSource As BindingSource
    Friend WithEvents File_typesTableAdapter As booklibDataSetTableAdapters.file_typesTableAdapter
    Friend WithEvents FileExtensionTextBox As TextBox
    Friend WithEvents FileTypeTextBox As TextBox
    Friend WithEvents txtBookAuthID As TextBox
    Friend WithEvents AuthorIDTextBox As TextBox
End Class
