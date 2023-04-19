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
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_clean = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lst_artists = New System.Windows.Forms.ListBox()
        Me.btn_deleteAlbum = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btn_updateAlbum = New System.Windows.Forms.Button()
        Me.lst_albums = New System.Windows.Forms.ListBox()
        Me.btn_insertAlbum = New System.Windows.Forms.Button()
        Me.txt_albumYear = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_albumName = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Silver
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.btn_back)
        Me.Panel4.Controls.Add(Me.btn_clean)
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
        Me.Panel4.Location = New System.Drawing.Point(98, 74)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(889, 494)
        Me.Panel4.TabIndex = 31
        '
        'btn_back
        '
        Me.btn_back.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.Image = Global.SetList.My.Resources.Resources.volver__1_
        Me.btn_back.Location = New System.Drawing.Point(32, 427)
        Me.btn_back.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(132, 57)
        Me.btn_back.TabIndex = 32
        Me.btn_back.Text = "BACK"
        Me.btn_back.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'btn_clean
        '
        Me.btn_clean.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clean.Image = Global.SetList.My.Resources.Resources.escoba__2_
        Me.btn_clean.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_clean.Location = New System.Drawing.Point(661, 412)
        Me.btn_clean.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_clean.Name = "btn_clean"
        Me.btn_clean.Size = New System.Drawing.Size(132, 57)
        Me.btn_clean.TabIndex = 31
        Me.btn_clean.Text = "CLEAN"
        Me.btn_clean.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_clean.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(26, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 32)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Albums"
        '
        'lst_artists
        '
        Me.lst_artists.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_artists.FormattingEnabled = True
        Me.lst_artists.ItemHeight = 25
        Me.lst_artists.Location = New System.Drawing.Point(242, 69)
        Me.lst_artists.Margin = New System.Windows.Forms.Padding(2)
        Me.lst_artists.Name = "lst_artists"
        Me.lst_artists.Size = New System.Drawing.Size(186, 354)
        Me.lst_artists.TabIndex = 29
        '
        'btn_deleteAlbum
        '
        Me.btn_deleteAlbum.Enabled = False
        Me.btn_deleteAlbum.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_deleteAlbum.Image = CType(resources.GetObject("btn_deleteAlbum.Image"), System.Drawing.Image)
        Me.btn_deleteAlbum.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_deleteAlbum.Location = New System.Drawing.Point(518, 412)
        Me.btn_deleteAlbum.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_deleteAlbum.Name = "btn_deleteAlbum"
        Me.btn_deleteAlbum.Size = New System.Drawing.Size(136, 57)
        Me.btn_deleteAlbum.TabIndex = 26
        Me.btn_deleteAlbum.Text = "DELETE"
        Me.btn_deleteAlbum.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_deleteAlbum.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Location = New System.Drawing.Point(238, 31)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 32)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Artist"
        '
        'btn_updateAlbum
        '
        Me.btn_updateAlbum.Enabled = False
        Me.btn_updateAlbum.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_updateAlbum.Image = CType(resources.GetObject("btn_updateAlbum.Image"), System.Drawing.Image)
        Me.btn_updateAlbum.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_updateAlbum.Location = New System.Drawing.Point(661, 323)
        Me.btn_updateAlbum.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_updateAlbum.Name = "btn_updateAlbum"
        Me.btn_updateAlbum.Size = New System.Drawing.Size(132, 55)
        Me.btn_updateAlbum.TabIndex = 28
        Me.btn_updateAlbum.Text = "UPDATE"
        Me.btn_updateAlbum.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_updateAlbum.UseVisualStyleBackColor = True
        '
        'lst_albums
        '
        Me.lst_albums.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_albums.FormattingEnabled = True
        Me.lst_albums.ItemHeight = 25
        Me.lst_albums.Location = New System.Drawing.Point(31, 69)
        Me.lst_albums.Margin = New System.Windows.Forms.Padding(2)
        Me.lst_albums.Name = "lst_albums"
        Me.lst_albums.Size = New System.Drawing.Size(186, 354)
        Me.lst_albums.TabIndex = 20
        '
        'btn_insertAlbum
        '
        Me.btn_insertAlbum.Enabled = False
        Me.btn_insertAlbum.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_insertAlbum.Image = CType(resources.GetObject("btn_insertAlbum.Image"), System.Drawing.Image)
        Me.btn_insertAlbum.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_insertAlbum.Location = New System.Drawing.Point(518, 323)
        Me.btn_insertAlbum.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_insertAlbum.Name = "btn_insertAlbum"
        Me.btn_insertAlbum.Size = New System.Drawing.Size(136, 55)
        Me.btn_insertAlbum.TabIndex = 24
        Me.btn_insertAlbum.Text = "ADD"
        Me.btn_insertAlbum.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_insertAlbum.UseVisualStyleBackColor = True
        '
        'txt_albumYear
        '
        Me.txt_albumYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_albumYear.Location = New System.Drawing.Point(518, 203)
        Me.txt_albumYear.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_albumYear.Name = "txt_albumYear"
        Me.txt_albumYear.Size = New System.Drawing.Size(275, 31)
        Me.txt_albumYear.TabIndex = 22
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label11.Location = New System.Drawing.Point(512, 158)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(216, 32)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Year of Launch"
        '
        'txt_albumName
        '
        Me.txt_albumName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_albumName.Location = New System.Drawing.Point(518, 112)
        Me.txt_albumName.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_albumName.Name = "txt_albumName"
        Me.txt_albumName.Size = New System.Drawing.Size(275, 31)
        Me.txt_albumName.TabIndex = 21
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label12.Location = New System.Drawing.Point(512, 69)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(188, 32)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Album Name"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Verdana", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label13.Location = New System.Drawing.Point(492, 9)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(225, 59)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "Albums"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.SetList.My.Resources.Resources.album
        Me.PictureBox1.Location = New System.Drawing.Point(423, 22)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 30)
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'AlbumForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SetList.My.Resources.Resources.Five_Simple_Editing_Tips_That_Will_Make_Your_Photos_Stand_Out
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1074, 612)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Label13)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "AlbumForm"
        Me.Text = "Album"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_clean As Button
    Friend WithEvents btn_back As Button
End Class
