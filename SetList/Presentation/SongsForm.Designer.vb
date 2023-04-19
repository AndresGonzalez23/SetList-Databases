<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SongsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SongsForm))
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btn_clean = New System.Windows.Forms.Button()
        Me.lst_albums = New System.Windows.Forms.ListBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txt_songOrder = New System.Windows.Forms.TextBox()
        Me.lst_songs = New System.Windows.Forms.ListBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txt_songLength = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txt_songName = New System.Windows.Forms.TextBox()
        Me.btn_deleteSong = New System.Windows.Forms.Button()
        Me.btn_updateSong = New System.Windows.Forms.Button()
        Me.btn_insertSong = New System.Windows.Forms.Button()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.Panel6.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Silver
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.btn_back)
        Me.Panel6.Controls.Add(Me.btn_clean)
        Me.Panel6.Controls.Add(Me.lst_albums)
        Me.Panel6.Controls.Add(Me.Label22)
        Me.Panel6.Controls.Add(Me.txt_songOrder)
        Me.Panel6.Controls.Add(Me.lst_songs)
        Me.Panel6.Controls.Add(Me.Label23)
        Me.Panel6.Controls.Add(Me.txt_songLength)
        Me.Panel6.Controls.Add(Me.Label21)
        Me.Panel6.Controls.Add(Me.Label20)
        Me.Panel6.Controls.Add(Me.txt_songName)
        Me.Panel6.Controls.Add(Me.btn_deleteSong)
        Me.Panel6.Controls.Add(Me.btn_updateSong)
        Me.Panel6.Controls.Add(Me.btn_insertSong)
        Me.Panel6.Location = New System.Drawing.Point(98, 74)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(889, 494)
        Me.Panel6.TabIndex = 35
        '
        'btn_clean
        '
        Me.btn_clean.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clean.Image = Global.SetList.My.Resources.Resources.escoba__2_
        Me.btn_clean.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_clean.Location = New System.Drawing.Point(725, 422)
        Me.btn_clean.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_clean.Name = "btn_clean"
        Me.btn_clean.Size = New System.Drawing.Size(136, 55)
        Me.btn_clean.TabIndex = 53
        Me.btn_clean.Text = "CLEAN"
        Me.btn_clean.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_clean.UseVisualStyleBackColor = True
        '
        'lst_albums
        '
        Me.lst_albums.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_albums.FormattingEnabled = True
        Me.lst_albums.ItemHeight = 25
        Me.lst_albums.Location = New System.Drawing.Point(561, 55)
        Me.lst_albums.Margin = New System.Windows.Forms.Padding(2)
        Me.lst_albums.Name = "lst_albums"
        Me.lst_albums.Size = New System.Drawing.Size(300, 279)
        Me.lst_albums.TabIndex = 40
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label22.Location = New System.Drawing.Point(556, 16)
        Me.Label22.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(78, 25)
        Me.Label22.TabIndex = 38
        Me.Label22.Text = "Album" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txt_songOrder
        '
        Me.txt_songOrder.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_songOrder.Location = New System.Drawing.Point(259, 283)
        Me.txt_songOrder.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_songOrder.Name = "txt_songOrder"
        Me.txt_songOrder.Size = New System.Drawing.Size(272, 33)
        Me.txt_songOrder.TabIndex = 30
        '
        'lst_songs
        '
        Me.lst_songs.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_songs.FormattingEnabled = True
        Me.lst_songs.ItemHeight = 25
        Me.lst_songs.Location = New System.Drawing.Point(32, 32)
        Me.lst_songs.Margin = New System.Windows.Forms.Padding(2)
        Me.lst_songs.Name = "lst_songs"
        Me.lst_songs.Size = New System.Drawing.Size(209, 379)
        Me.lst_songs.TabIndex = 29
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label23.Location = New System.Drawing.Point(256, 245)
        Me.Label23.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(73, 25)
        Me.Label23.TabIndex = 39
        Me.Label23.Text = "Order"
        '
        'txt_songLength
        '
        Me.txt_songLength.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_songLength.Location = New System.Drawing.Point(260, 171)
        Me.txt_songLength.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_songLength.Name = "txt_songLength"
        Me.txt_songLength.Size = New System.Drawing.Size(272, 33)
        Me.txt_songLength.TabIndex = 35
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label21.Location = New System.Drawing.Point(255, 133)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(84, 25)
        Me.Label21.TabIndex = 37
        Me.Label21.Text = "Length"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label20.Location = New System.Drawing.Point(255, 32)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(74, 25)
        Me.Label20.TabIndex = 36
        Me.Label20.Text = "Name" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txt_songName
        '
        Me.txt_songName.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_songName.Location = New System.Drawing.Point(259, 59)
        Me.txt_songName.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_songName.Name = "txt_songName"
        Me.txt_songName.Size = New System.Drawing.Size(272, 33)
        Me.txt_songName.TabIndex = 34
        '
        'btn_deleteSong
        '
        Me.btn_deleteSong.Enabled = False
        Me.btn_deleteSong.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_deleteSong.Image = CType(resources.GetObject("btn_deleteSong.Image"), System.Drawing.Image)
        Me.btn_deleteSong.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_deleteSong.Location = New System.Drawing.Point(561, 422)
        Me.btn_deleteSong.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_deleteSong.Name = "btn_deleteSong"
        Me.btn_deleteSong.Size = New System.Drawing.Size(136, 55)
        Me.btn_deleteSong.TabIndex = 30
        Me.btn_deleteSong.Text = "DELETE"
        Me.btn_deleteSong.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_deleteSong.UseVisualStyleBackColor = True
        '
        'btn_updateSong
        '
        Me.btn_updateSong.Enabled = False
        Me.btn_updateSong.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_updateSong.Image = CType(resources.GetObject("btn_updateSong.Image"), System.Drawing.Image)
        Me.btn_updateSong.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_updateSong.Location = New System.Drawing.Point(725, 345)
        Me.btn_updateSong.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_updateSong.Name = "btn_updateSong"
        Me.btn_updateSong.Size = New System.Drawing.Size(136, 55)
        Me.btn_updateSong.TabIndex = 30
        Me.btn_updateSong.Text = "UPDATE"
        Me.btn_updateSong.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_updateSong.UseVisualStyleBackColor = True
        '
        'btn_insertSong
        '
        Me.btn_insertSong.Enabled = False
        Me.btn_insertSong.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_insertSong.Image = Global.SetList.My.Resources.Resources.plus__1_
        Me.btn_insertSong.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_insertSong.Location = New System.Drawing.Point(561, 345)
        Me.btn_insertSong.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_insertSong.Name = "btn_insertSong"
        Me.btn_insertSong.Size = New System.Drawing.Size(136, 55)
        Me.btn_insertSong.TabIndex = 33
        Me.btn_insertSong.Text = "ADD"
        Me.btn_insertSong.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_insertSong.UseVisualStyleBackColor = True
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox7.Image = Global.SetList.My.Resources.Resources.music
        Me.PictureBox7.Location = New System.Drawing.Point(230, 11)
        Me.PictureBox7.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(29, 31)
        Me.PictureBox7.TabIndex = 28
        Me.PictureBox7.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Verdana", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label14.Location = New System.Drawing.Point(263, 9)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(107, 32)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "Songs"
        '
        'btn_back
        '
        Me.btn_back.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.Image = Global.SetList.My.Resources.Resources.volver__1_
        Me.btn_back.Location = New System.Drawing.Point(32, 422)
        Me.btn_back.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(136, 55)
        Me.btn_back.TabIndex = 54
        Me.btn_back.Text = "BACK"
        Me.btn_back.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'SongsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SetList.My.Resources.Resources.Five_Simple_Editing_Tips_That_Will_Make_Your_Photos_Stand_Out
        Me.ClientSize = New System.Drawing.Size(1074, 612)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.PictureBox7)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "SongsForm"
        Me.Text = "Songs"
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel6 As Panel
    Friend WithEvents txt_songOrder As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents txt_songLength As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents txt_songName As TextBox
    Friend WithEvents btn_deleteSong As Button
    Friend WithEvents btn_updateSong As Button
    Friend WithEvents btn_insertSong As Button
    Friend WithEvents lst_songs As ListBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Label14 As Label
    Friend WithEvents lst_albums As ListBox
    Friend WithEvents btn_clean As Button
    Friend WithEvents btn_back As Button
End Class
