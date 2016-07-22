<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.csvLocationBox = New System.Windows.Forms.TextBox()
        Me.csvLoaderButton = New System.Windows.Forms.Button()
        Me.backupLocationBox = New System.Windows.Forms.TextBox()
        Me.backupLocationButton = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.backupButton = New System.Windows.Forms.Button()
        Me.outBox = New System.Windows.Forms.RichTextBox()
        Me.csvBrowser = New System.Windows.Forms.OpenFileDialog()
        Me.backupFolderBrowser = New System.Windows.Forms.FolderBrowserDialog()
        Me.usersProcessedLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'csvLocationBox
        '
        Me.csvLocationBox.Location = New System.Drawing.Point(51, 27)
        Me.csvLocationBox.Name = "csvLocationBox"
        Me.csvLocationBox.Size = New System.Drawing.Size(229, 20)
        Me.csvLocationBox.TabIndex = 0
        '
        'csvLoaderButton
        '
        Me.csvLoaderButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.csvLoaderButton.Location = New System.Drawing.Point(286, 27)
        Me.csvLoaderButton.Name = "csvLoaderButton"
        Me.csvLoaderButton.Size = New System.Drawing.Size(104, 20)
        Me.csvLoaderButton.TabIndex = 1
        Me.csvLoaderButton.Text = "CSV"
        Me.csvLoaderButton.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.csvLoaderButton.UseVisualStyleBackColor = True
        '
        'backupLocationBox
        '
        Me.backupLocationBox.Location = New System.Drawing.Point(51, 53)
        Me.backupLocationBox.Name = "backupLocationBox"
        Me.backupLocationBox.Size = New System.Drawing.Size(229, 20)
        Me.backupLocationBox.TabIndex = 2
        '
        'backupLocationButton
        '
        Me.backupLocationButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backupLocationButton.Location = New System.Drawing.Point(286, 53)
        Me.backupLocationButton.Name = "backupLocationButton"
        Me.backupLocationButton.Size = New System.Drawing.Size(104, 20)
        Me.backupLocationButton.TabIndex = 3
        Me.backupLocationButton.Text = "Backup Directory"
        Me.backupLocationButton.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.backupLocationButton.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 553)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(860, 22)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'backupButton
        '
        Me.backupButton.BackColor = System.Drawing.Color.Crimson
        Me.backupButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backupButton.Location = New System.Drawing.Point(726, 27)
        Me.backupButton.Name = "backupButton"
        Me.backupButton.Size = New System.Drawing.Size(104, 46)
        Me.backupButton.TabIndex = 5
        Me.backupButton.Text = "Backup"
        Me.backupButton.UseVisualStyleBackColor = False
        '
        'outBox
        '
        Me.outBox.Location = New System.Drawing.Point(51, 100)
        Me.outBox.Name = "outBox"
        Me.outBox.Size = New System.Drawing.Size(654, 433)
        Me.outBox.TabIndex = 6
        Me.outBox.Text = ""
        '
        'csvBrowser
        '
        Me.csvBrowser.DefaultExt = "csv"
        Me.csvBrowser.FileName = "users.csv"
        Me.csvBrowser.Filter = "Comma seperated values|*.csv|All files|*.*"
        Me.csvBrowser.InitialDirectory = "n:\"
        Me.csvBrowser.Title = "Browse for User List."
        '
        'backupFolderBrowser
        '
        Me.backupFolderBrowser.Description = "Folder to place Backups"
        Me.backupFolderBrowser.SelectedPath = "N:\"
        '
        'usersProcessedLabel
        '
        Me.usersProcessedLabel.AutoSize = True
        Me.usersProcessedLabel.Location = New System.Drawing.Point(12, 558)
        Me.usersProcessedLabel.Name = "usersProcessedLabel"
        Me.usersProcessedLabel.Size = New System.Drawing.Size(116, 13)
        Me.usersProcessedLabel.TabIndex = 9
        Me.usersProcessedLabel.Text = "(0/0) Users Processed."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(860, 575)
        Me.Controls.Add(Me.usersProcessedLabel)
        Me.Controls.Add(Me.outBox)
        Me.Controls.Add(Me.backupButton)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.backupLocationButton)
        Me.Controls.Add(Me.backupLocationBox)
        Me.Controls.Add(Me.csvLoaderButton)
        Me.Controls.Add(Me.csvLocationBox)
        Me.Name = "Form1"
        Me.Text = "AS Cloud Backup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents csvLocationBox As TextBox
    Friend WithEvents csvLoaderButton As Button
    Friend WithEvents backupLocationBox As TextBox
    Friend WithEvents backupLocationButton As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents copyProgressBar As ToolStripProgressBar
    Friend WithEvents copyStatusLabel As ToolStripStatusLabel
    Friend WithEvents backupButton As Button
    Friend WithEvents outBox As RichTextBox
    Friend WithEvents csvBrowser As OpenFileDialog
    Friend WithEvents backupFolderBrowser As FolderBrowserDialog
    Friend WithEvents usersProcessedLabel As Label
End Class
