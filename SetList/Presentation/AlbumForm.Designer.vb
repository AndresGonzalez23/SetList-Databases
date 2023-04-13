<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlbumForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AlbumForm))
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lst_artists = New System.Windows.Forms.ListBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.btn_updateAlbum = New System.Windows.Forms.Button()
        Me.btn_deleteAlbum = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lst_albums = New System.Windows.Forms.ListBox()
        Me.txt_albumName = New System.Windows.Forms.TextBox()
        Me.btn_insertAlbum = New System.Windows.Forms.Button()
        Me.txt_albumYear = New System.Windows.Forms.TextBox()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Silver
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.lst_artists)
        Me.Panel4.Controls.Add(Me.PictureBox5)
        Me.Panel4.Controls.Add(Me.btn_updateAlbum)
        Me.Panel4.Controls.Add(Me.btn_deleteAlbum)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.Label12)
        Me.Panel4.Controls.Add(Me.Label13)
        Me.Panel4.Controls.Add(Me.lst_albums)
        Me.Panel4.Controls.Add(Me.txt_albumName)
        Me.Panel4.Controls.Add(Me.btn_insertAlbum)
        Me.Panel4.Controls.Add(Me.txt_albumYear)
        Me.Panel4.Location = New System.Drawing.Point(75, 64)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(678, 365)
        Me.Panel4.TabIndex = 31
        '
        'lst_artists
        '
        Me.lst_artists.FormattingEnabled = True
        Me.lst_artists.ItemHeight = 16
        Me.lst_artists.Location = New System.Drawing.Point(217, 153)
        Me.lst_artists.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lst_artists.Name = "lst_artists"
        Me.lst_artists.Size = New System.Drawing.Size(175, 132)
        Me.lst_artists.TabIndex = 29
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(28, 12)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(39, 38)
        Me.PictureBox5.TabIndex = 28
        Me.PictureBox5.TabStop = False
        '
        'btn_updateAlbum
        '
        Me.btn_updateAlbum.Enabled = False
        Me.btn_updateAlbum.Image = CType(resources.GetObject("btn_updateAlbum.Image"), System.Drawing.Image)
        Me.btn_updateAlbum.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_updateAlbum.Location = New System.Drawing.Point(281, 292)
        Me.btn_updateAlbum.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_updateAlbum.Name = "btn_updateAlbum"
        Me.btn_updateAlbum.Size = New System.Drawing.Size(111, 55)
        Me.btn_updateAlbum.TabIndex = 28
        Me.btn_updateAlbum.Text = "Update Album"
        Me.btn_updateAlbum.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_updateAlbum.UseVisualStyleBackColor = True
        '
        'btn_deleteAlbum
        '
        Me.btn_deleteAlbum.Enabled = False
        Me.btn_deleteAlbum.Image = CType(resources.GetObject("btn_deleteAlbum.Image"), System.Drawing.Image)
        Me.btn_deleteAlbum.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_deleteAlbum.Location = New System.Drawing.Point(486, 292)
        Me.btn_deleteAlbum.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_deleteAlbum.Name = "btn_deleteAlbum"
        Me.btn_deleteAlbum.Size = New System.Drawing.Size(120, 54)
        Me.btn_deleteAlbum.TabIndex = 26
        Me.btn_deleteAlbum.Text = "Delete Album"
        Me.btn_deleteAlbum.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_deleteAlbum.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Location = New System.Drawing.Point(212, 122)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 29)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Artist"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label11.Location = New System.Drawing.Point(418, 57)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(188, 29)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Year of Launch"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label12.Location = New System.Drawing.Point(212, 57)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(165, 29)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Album Name"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label13.Location = New System.Drawing.Point(81, 10)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(101, 29)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "Albums"
        '
        'lst_albums
        '
        Me.lst_albums.FormattingEnabled = True
        Me.lst_albums.ItemHeight = 16
        Me.lst_albums.Location = New System.Drawing.Point(19, 57)
        Me.lst_albums.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lst_albums.Name = "lst_albums"
        Me.lst_albums.Size = New System.Drawing.Size(175, 228)
        Me.lst_albums.TabIndex = 20
        '
        'txt_albumName
        '
        Me.txt_albumName.Location = New System.Drawing.Point(217, 90)
        Me.txt_albumName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_albumName.Name = "txt_albumName"
        Me.txt_albumName.Size = New System.Drawing.Size(160, 22)
        Me.txt_albumName.TabIndex = 21
        '
        'btn_insertAlbum
        '
        Me.btn_insertAlbum.Enabled = False
        Me.btn_insertAlbum.Image = CType(resources.GetObject("btn_insertAlbum.Image"), System.Drawing.Image)
        Me.btn_insertAlbum.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_insertAlbum.Location = New System.Drawing.Point(55, 293)
        Me.btn_insertAlbum.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_insertAlbum.Name = "btn_insertAlbum"
        Me.btn_insertAlbum.Size = New System.Drawing.Size(109, 54)
        Me.btn_insertAlbum.TabIndex = 24
        Me.btn_insertAlbum.Text = "Insertar Album"
        Me.btn_insertAlbum.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_insertAlbum.UseVisualStyleBackColor = True
        '
        'txt_albumYear
        '
        Me.txt_albumYear.Location = New System.Drawing.Point(423, 90)
        Me.txt_albumYear.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_albumYear.Name = "txt_albumYear"
        Me.txt_albumYear.Size = New System.Drawing.Size(160, 22)
        Me.txt_albumYear.TabIndex = 22
        '
        'AlbumForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SetList.My.Resources.Resources.Five_Simple_Editing_Tips_That_Will_Make_Your_Photos_Stand_Out
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "AlbumForm"
        Me.Text = "AlbumForm"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents btn_updateAlbum As Button
    Friend WithEvents btn_deleteAlbum As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lst_albums As ListBox
    Friend WithEvents txt_albumName As TextBox
    Friend WithEvents btn_insertAlbum As Button
    Friend WithEvents txt_albumYear As TextBox
    Friend WithEvents lst_artists As ListBox
End Class
