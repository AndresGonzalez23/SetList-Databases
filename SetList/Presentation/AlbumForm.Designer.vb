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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lst_artists = New System.Windows.Forms.ListBox()
        Me.btn_updateAlbum = New System.Windows.Forms.Button()
        Me.btn_deleteAlbum = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lst_albums = New System.Windows.Forms.ListBox()
        Me.txt_albumName = New System.Windows.Forms.TextBox()
        Me.btn_insertAlbum = New System.Windows.Forms.Button()
        Me.txt_albumYear = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Silver
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.lst_artists)
        Me.Panel4.Controls.Add(Me.btn_deleteAlbum)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.btn_updateAlbum)
        Me.Panel4.Controls.Add(Me.lst_albums)
        Me.Panel4.Controls.Add(Me.btn_insertAlbum)
        Me.Panel4.Controls.Add(Me.txt_albumYear)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.txt_albumName)
        Me.Panel4.Controls.Add(Me.Label12)
        Me.Panel4.Location = New System.Drawing.Point(108, 66)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(582, 354)
        Me.Panel4.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(13, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 25)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Albums"
        '
        'lst_artists
        '
        Me.lst_artists.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_artists.FormattingEnabled = True
        Me.lst_artists.ItemHeight = 25
        Me.lst_artists.Location = New System.Drawing.Point(190, 47)
        Me.lst_artists.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lst_artists.Name = "lst_artists"
        Me.lst_artists.Size = New System.Drawing.Size(150, 279)
        Me.lst_artists.TabIndex = 29
        '
        'btn_updateAlbum
        '
        Me.btn_updateAlbum.Enabled = False
        Me.btn_updateAlbum.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_updateAlbum.Image = CType(resources.GetObject("btn_updateAlbum.Image"), System.Drawing.Image)
        Me.btn_updateAlbum.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_updateAlbum.Location = New System.Drawing.Point(450, 190)
        Me.btn_updateAlbum.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_updateAlbum.Name = "btn_updateAlbum"
        Me.btn_updateAlbum.Size = New System.Drawing.Size(90, 55)
        Me.btn_updateAlbum.TabIndex = 28
        Me.btn_updateAlbum.Text = "UPDATE"
        Me.btn_updateAlbum.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_updateAlbum.UseVisualStyleBackColor = True
        '
        'btn_deleteAlbum
        '
        Me.btn_deleteAlbum.Enabled = False
        Me.btn_deleteAlbum.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_deleteAlbum.Image = CType(resources.GetObject("btn_deleteAlbum.Image"), System.Drawing.Image)
        Me.btn_deleteAlbum.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_deleteAlbum.Location = New System.Drawing.Point(354, 271)
        Me.btn_deleteAlbum.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_deleteAlbum.Name = "btn_deleteAlbum"
        Me.btn_deleteAlbum.Size = New System.Drawing.Size(90, 55)
        Me.btn_deleteAlbum.TabIndex = 26
        Me.btn_deleteAlbum.Text = "DELETE"
        Me.btn_deleteAlbum.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_deleteAlbum.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Location = New System.Drawing.Point(185, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 25)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Artist"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label11.Location = New System.Drawing.Point(349, 107)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(161, 25)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Year of Launch"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label12.Location = New System.Drawing.Point(349, 20)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(141, 25)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Album Name"
        '
        'lst_albums
        '
        Me.lst_albums.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_albums.FormattingEnabled = True
        Me.lst_albums.ItemHeight = 25
        Me.lst_albums.Location = New System.Drawing.Point(18, 47)
        Me.lst_albums.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lst_albums.Name = "lst_albums"
        Me.lst_albums.Size = New System.Drawing.Size(150, 279)
        Me.lst_albums.TabIndex = 20
        '
        'txt_albumName
        '
        Me.txt_albumName.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_albumName.Location = New System.Drawing.Point(354, 52)
        Me.txt_albumName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_albumName.Name = "txt_albumName"
        Me.txt_albumName.Size = New System.Drawing.Size(186, 32)
        Me.txt_albumName.TabIndex = 21
        '
        'btn_insertAlbum
        '
        Me.btn_insertAlbum.Enabled = False
        Me.btn_insertAlbum.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_insertAlbum.Image = CType(resources.GetObject("btn_insertAlbum.Image"), System.Drawing.Image)
        Me.btn_insertAlbum.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_insertAlbum.Location = New System.Drawing.Point(354, 190)
        Me.btn_insertAlbum.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_insertAlbum.Name = "btn_insertAlbum"
        Me.btn_insertAlbum.Size = New System.Drawing.Size(90, 55)
        Me.btn_insertAlbum.TabIndex = 24
        Me.btn_insertAlbum.Text = "ADD"
        Me.btn_insertAlbum.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_insertAlbum.UseVisualStyleBackColor = True
        '
        'txt_albumYear
        '
        Me.txt_albumYear.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_albumYear.Location = New System.Drawing.Point(354, 138)
        Me.txt_albumYear.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_albumYear.Name = "txt_albumYear"
        Me.txt_albumYear.Size = New System.Drawing.Size(186, 32)
        Me.txt_albumYear.TabIndex = 22
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Verdana", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label13.Location = New System.Drawing.Point(325, 9)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(140, 40)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "Albums"
        '
        'AlbumForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SetList.My.Resources.Resources.Five_Simple_Editing_Tips_That_Will_Make_Your_Photos_Stand_Out
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Label13)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AlbumForm"
        Me.Text = "Album"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel4 As Panel
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
    Friend WithEvents Label1 As Label
End Class
