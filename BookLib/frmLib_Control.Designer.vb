﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLib_Control
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
        Dim Lib_Control_IDLabel As System.Windows.Forms.Label
        Dim New_Book_DirLabel As System.Windows.Forms.Label
        Dim Reviewed_Book_DirLabel As System.Windows.Forms.Label
        Dim ComputerNameLabel As System.Windows.Forms.Label
        Dim No_Image_FileLabel As System.Windows.Forms.Label
        Me.BooklibDataSet = New BookLib.booklibDataSet()
        Me.Lib_controlBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Lib_controlTableAdapter = New BookLib.booklibDataSetTableAdapters.lib_controlTableAdapter()
        Me.TableAdapterManager = New BookLib.booklibDataSetTableAdapters.TableAdapterManager()
        Me.Lib_Control_IDTextBox = New System.Windows.Forms.TextBox()
        Me.New_Book_DirTextBox = New System.Windows.Forms.TextBox()
        Me.Reviewed_Book_DirTextBox = New System.Windows.Forms.TextBox()
        Me.btnBrowseNewDir = New System.Windows.Forms.Button()
        Me.btnBrowseReviewDir = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.ComputerNameTextBox = New System.Windows.Forms.TextBox()
        Me.No_Image_FileTextBox = New System.Windows.Forms.TextBox()
        Me.btnBrowseNoFile = New System.Windows.Forms.Button()
        Lib_Control_IDLabel = New System.Windows.Forms.Label()
        New_Book_DirLabel = New System.Windows.Forms.Label()
        Reviewed_Book_DirLabel = New System.Windows.Forms.Label()
        ComputerNameLabel = New System.Windows.Forms.Label()
        No_Image_FileLabel = New System.Windows.Forms.Label()
        CType(Me.BooklibDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lib_controlBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lib_Control_IDLabel
        '
        Lib_Control_IDLabel.AutoSize = True
        Lib_Control_IDLabel.Location = New System.Drawing.Point(63, 48)
        Lib_Control_IDLabel.Name = "Lib_Control_IDLabel"
        Lib_Control_IDLabel.Size = New System.Drawing.Size(74, 13)
        Lib_Control_IDLabel.TabIndex = 1
        Lib_Control_IDLabel.Text = "Lib Control ID:"
        '
        'New_Book_DirLabel
        '
        New_Book_DirLabel.AutoSize = True
        New_Book_DirLabel.Location = New System.Drawing.Point(35, 88)
        New_Book_DirLabel.Name = "New_Book_DirLabel"
        New_Book_DirLabel.Size = New System.Drawing.Size(76, 13)
        New_Book_DirLabel.TabIndex = 3
        New_Book_DirLabel.Text = "New Book Dir:"
        '
        'Reviewed_Book_DirLabel
        '
        Reviewed_Book_DirLabel.AutoSize = True
        Reviewed_Book_DirLabel.Location = New System.Drawing.Point(35, 142)
        Reviewed_Book_DirLabel.Name = "Reviewed_Book_DirLabel"
        Reviewed_Book_DirLabel.Size = New System.Drawing.Size(102, 13)
        Reviewed_Book_DirLabel.TabIndex = 5
        Reviewed_Book_DirLabel.Text = "Reviewed Book Dir:"
        '
        'ComputerNameLabel
        '
        ComputerNameLabel.AutoSize = True
        ComputerNameLabel.Location = New System.Drawing.Point(221, 48)
        ComputerNameLabel.Name = "ComputerNameLabel"
        ComputerNameLabel.Size = New System.Drawing.Size(86, 13)
        ComputerNameLabel.TabIndex = 12
        ComputerNameLabel.Text = "Computer Name:"
        '
        'BooklibDataSet
        '
        Me.BooklibDataSet.DataSetName = "booklibDataSet"
        Me.BooklibDataSet.EnforceConstraints = False
        Me.BooklibDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Lib_controlBindingSource
        '
        Me.Lib_controlBindingSource.DataMember = "lib_control"
        Me.Lib_controlBindingSource.DataSource = Me.BooklibDataSet
        '
        'Lib_controlTableAdapter
        '
        Me.Lib_controlTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.authorsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.book_coversTableAdapter = Nothing
        Me.TableAdapterManager.booksTableAdapter = Nothing
        Me.TableAdapterManager.categoriesTableAdapter = Nothing
        Me.TableAdapterManager.file_types_copyTableAdapter = Nothing
        Me.TableAdapterManager.file_typesTableAdapter = Nothing
        Me.TableAdapterManager.lib_controlTableAdapter = Me.Lib_controlTableAdapter
        Me.TableAdapterManager.UpdateOrder = BookLib.booklibDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Lib_Control_IDTextBox
        '
        Me.Lib_Control_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Lib_controlBindingSource, "Lib_Control_ID", True))
        Me.Lib_Control_IDTextBox.Location = New System.Drawing.Point(143, 45)
        Me.Lib_Control_IDTextBox.Name = "Lib_Control_IDTextBox"
        Me.Lib_Control_IDTextBox.Size = New System.Drawing.Size(28, 20)
        Me.Lib_Control_IDTextBox.TabIndex = 2
        '
        'New_Book_DirTextBox
        '
        Me.New_Book_DirTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Lib_controlBindingSource, "New_Book_Dir", True))
        Me.New_Book_DirTextBox.Location = New System.Drawing.Point(143, 85)
        Me.New_Book_DirTextBox.Name = "New_Book_DirTextBox"
        Me.New_Book_DirTextBox.Size = New System.Drawing.Size(450, 20)
        Me.New_Book_DirTextBox.TabIndex = 4
        '
        'Reviewed_Book_DirTextBox
        '
        Me.Reviewed_Book_DirTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Lib_controlBindingSource, "Reviewed_Book_Dir", True))
        Me.Reviewed_Book_DirTextBox.Location = New System.Drawing.Point(143, 139)
        Me.Reviewed_Book_DirTextBox.Name = "Reviewed_Book_DirTextBox"
        Me.Reviewed_Book_DirTextBox.Size = New System.Drawing.Size(450, 20)
        Me.Reviewed_Book_DirTextBox.TabIndex = 6
        '
        'btnBrowseNewDir
        '
        Me.btnBrowseNewDir.Location = New System.Drawing.Point(599, 85)
        Me.btnBrowseNewDir.Name = "btnBrowseNewDir"
        Me.btnBrowseNewDir.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowseNewDir.TabIndex = 7
        Me.btnBrowseNewDir.Text = "Browse"
        Me.btnBrowseNewDir.UseVisualStyleBackColor = True
        '
        'btnBrowseReviewDir
        '
        Me.btnBrowseReviewDir.Location = New System.Drawing.Point(599, 139)
        Me.btnBrowseReviewDir.Name = "btnBrowseReviewDir"
        Me.btnBrowseReviewDir.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowseReviewDir.TabIndex = 8
        Me.btnBrowseReviewDir.Text = "Browse"
        Me.btnBrowseReviewDir.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(246, 262)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(391, 261)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'ComputerNameTextBox
        '
        Me.ComputerNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Lib_controlBindingSource, "ComputerName", True))
        Me.ComputerNameTextBox.Location = New System.Drawing.Point(313, 45)
        Me.ComputerNameTextBox.Name = "ComputerNameTextBox"
        Me.ComputerNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ComputerNameTextBox.TabIndex = 13
        '
        'No_Image_FileLabel
        '
        No_Image_FileLabel.AutoSize = True
        No_Image_FileLabel.Location = New System.Drawing.Point(51, 190)
        No_Image_FileLabel.Name = "No_Image_FileLabel"
        No_Image_FileLabel.Size = New System.Drawing.Size(75, 13)
        No_Image_FileLabel.TabIndex = 13
        No_Image_FileLabel.Text = "No Image File:"
        '
        'No_Image_FileTextBox
        '
        Me.No_Image_FileTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Lib_controlBindingSource, "No_Image_File", True))
        Me.No_Image_FileTextBox.Location = New System.Drawing.Point(143, 187)
        Me.No_Image_FileTextBox.Name = "No_Image_FileTextBox"
        Me.No_Image_FileTextBox.Size = New System.Drawing.Size(450, 20)
        Me.No_Image_FileTextBox.TabIndex = 14
        '
        'btnBrowseNoFile
        '
        Me.btnBrowseNoFile.Location = New System.Drawing.Point(599, 185)
        Me.btnBrowseNoFile.Name = "btnBrowseNoFile"
        Me.btnBrowseNoFile.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowseNoFile.TabIndex = 15
        Me.btnBrowseNoFile.Text = "Browse"
        Me.btnBrowseNoFile.UseVisualStyleBackColor = True
        '
        'frmLib_Control
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 317)
        Me.Controls.Add(Me.btnBrowseNoFile)
        Me.Controls.Add(No_Image_FileLabel)
        Me.Controls.Add(Me.No_Image_FileTextBox)
        Me.Controls.Add(ComputerNameLabel)
        Me.Controls.Add(Me.ComputerNameTextBox)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnBrowseReviewDir)
        Me.Controls.Add(Me.btnBrowseNewDir)
        Me.Controls.Add(Reviewed_Book_DirLabel)
        Me.Controls.Add(Me.Reviewed_Book_DirTextBox)
        Me.Controls.Add(New_Book_DirLabel)
        Me.Controls.Add(Me.New_Book_DirTextBox)
        Me.Controls.Add(Lib_Control_IDLabel)
        Me.Controls.Add(Me.Lib_Control_IDTextBox)
        Me.Name = "frmLib_Control"
        Me.Text = "Lib_Control"
        CType(Me.BooklibDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lib_controlBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BooklibDataSet As booklibDataSet
    Friend WithEvents Lib_controlBindingSource As BindingSource
    Friend WithEvents Lib_controlTableAdapter As booklibDataSetTableAdapters.lib_controlTableAdapter
    Friend WithEvents TableAdapterManager As booklibDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Lib_Control_IDTextBox As TextBox
    Friend WithEvents New_Book_DirTextBox As TextBox
    Friend WithEvents Reviewed_Book_DirTextBox As TextBox
    Friend WithEvents btnBrowseNewDir As Button
    Friend WithEvents btnBrowseReviewDir As Button
    Friend WithEvents FolderBrowserDialog As FolderBrowserDialog
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents ComputerNameTextBox As TextBox
    Friend WithEvents No_Image_FileTextBox As TextBox
    Friend WithEvents btnBrowseNoFile As Button
End Class
