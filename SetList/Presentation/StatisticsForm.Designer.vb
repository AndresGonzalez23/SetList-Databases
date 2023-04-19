<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StatisticsForm
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
        Me.lst_artists = New System.Windows.Forms.ListBox()
        Me.lst_moreSinged = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_searchSql1 = New System.Windows.Forms.Button()
        Me.lst_songs = New System.Windows.Forms.ListBox()
        Me.btn_Query4 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lst_artistsAlbum = New System.Windows.Forms.ListBox()
        Me.lst_albums = New System.Windows.Forms.ListBox()
        Me.btn_searchSql2 = New System.Windows.Forms.Button()
        Me.btn_Query3 = New System.Windows.Forms.Button()
        Me.lst_Query3 = New System.Windows.Forms.ListBox()
        Me.txt_StartDate = New System.Windows.Forms.DateTimePicker()
        Me.txt_endDate = New System.Windows.Forms.DateTimePicker()
        Me.lst_artistDates = New System.Windows.Forms.ListBox()
        Me.btn_Query5 = New System.Windows.Forms.Button()
        Me.txt_startDateQ6 = New System.Windows.Forms.DateTimePicker()
        Me.txt_endDateQ6 = New System.Windows.Forms.DateTimePicker()
        Me.lst_countries = New System.Windows.Forms.ListBox()
        Me.btn_Query6 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lst_artists
        '
        Me.lst_artists.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_artists.FormattingEnabled = True
        Me.lst_artists.ItemHeight = 20
        Me.lst_artists.Location = New System.Drawing.Point(218, 86)
        Me.lst_artists.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lst_artists.Name = "lst_artists"
        Me.lst_artists.Size = New System.Drawing.Size(150, 124)
        Me.lst_artists.TabIndex = 10
        '
        'lst_moreSinged
        '
        Me.lst_moreSinged.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_moreSinged.FormattingEnabled = True
        Me.lst_moreSinged.ItemHeight = 20
        Me.lst_moreSinged.Location = New System.Drawing.Point(387, 86)
        Me.lst_moreSinged.Name = "lst_moreSinged"
        Me.lst_moreSinged.Size = New System.Drawing.Size(150, 124)
        Me.lst_moreSinged.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(53, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(315, 60)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Songs performed the most times" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "by an artist  throughout all his/her " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "concerts"
        '
        'btn_searchSql1
        '
        Me.btn_searchSql1.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_searchSql1.Location = New System.Drawing.Point(57, 157)
        Me.btn_searchSql1.Name = "btn_searchSql1"
        Me.btn_searchSql1.Size = New System.Drawing.Size(114, 41)
        Me.btn_searchSql1.TabIndex = 13
        Me.btn_searchSql1.Text = "Search"
        Me.btn_searchSql1.UseVisualStyleBackColor = True
        '
        'lst_songs
        '
        Me.lst_songs.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_songs.FormattingEnabled = True
        Me.lst_songs.ItemHeight = 16
        Me.lst_songs.Location = New System.Drawing.Point(733, 66)
        Me.lst_songs.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lst_songs.Name = "lst_songs"
        Me.lst_songs.Size = New System.Drawing.Size(581, 164)
        Me.lst_songs.TabIndex = 14
        '
        'btn_Query4
        '
        Me.btn_Query4.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Query4.Location = New System.Drawing.Point(1200, 235)
        Me.btn_Query4.Name = "btn_Query4"
        Me.btn_Query4.Size = New System.Drawing.Size(114, 41)
        Me.btn_Query4.TabIndex = 15
        Me.btn_Query4.Text = "Search"
        Me.btn_Query4.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(729, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(371, 40)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Complete Information of the songs " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "that have been performed the most times"
        '
        'lst_artistsAlbum
        '
        Me.lst_artistsAlbum.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_artistsAlbum.FormattingEnabled = True
        Me.lst_artistsAlbum.ItemHeight = 20
        Me.lst_artistsAlbum.Location = New System.Drawing.Point(218, 330)
        Me.lst_artistsAlbum.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lst_artistsAlbum.Name = "lst_artistsAlbum"
        Me.lst_artistsAlbum.Size = New System.Drawing.Size(150, 124)
        Me.lst_artistsAlbum.TabIndex = 17
        '
        'lst_albums
        '
        Me.lst_albums.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_albums.FormattingEnabled = True
        Me.lst_albums.ItemHeight = 20
        Me.lst_albums.Location = New System.Drawing.Point(387, 330)
        Me.lst_albums.Name = "lst_albums"
        Me.lst_albums.Size = New System.Drawing.Size(150, 124)
        Me.lst_albums.TabIndex = 18
        '
        'btn_searchSql2
        '
        Me.btn_searchSql2.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_searchSql2.Location = New System.Drawing.Point(57, 403)
        Me.btn_searchSql2.Name = "btn_searchSql2"
        Me.btn_searchSql2.Size = New System.Drawing.Size(114, 41)
        Me.btn_searchSql2.TabIndex = 19
        Me.btn_searchSql2.Text = "Search"
        Me.btn_searchSql2.UseVisualStyleBackColor = True
        '
        'btn_Query3
        '
        Me.btn_Query3.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Query3.Location = New System.Drawing.Point(57, 594)
        Me.btn_Query3.Name = "btn_Query3"
        Me.btn_Query3.Size = New System.Drawing.Size(114, 41)
        Me.btn_Query3.TabIndex = 20
        Me.btn_Query3.Text = "Search"
        Me.btn_Query3.UseVisualStyleBackColor = True
        '
        'lst_Query3
        '
        Me.lst_Query3.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_Query3.FormattingEnabled = True
        Me.lst_Query3.ItemHeight = 20
        Me.lst_Query3.Location = New System.Drawing.Point(218, 553)
        Me.lst_Query3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lst_Query3.Name = "lst_Query3"
        Me.lst_Query3.Size = New System.Drawing.Size(319, 124)
        Me.lst_Query3.TabIndex = 21
        '
        'txt_StartDate
        '
        Me.txt_StartDate.CalendarFont = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_StartDate.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_StartDate.Location = New System.Drawing.Point(701, 330)
        Me.txt_StartDate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_StartDate.Name = "txt_StartDate"
        Me.txt_StartDate.Size = New System.Drawing.Size(207, 28)
        Me.txt_StartDate.TabIndex = 33
        '
        'txt_endDate
        '
        Me.txt_endDate.CalendarFont = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_endDate.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_endDate.Location = New System.Drawing.Point(701, 389)
        Me.txt_endDate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_endDate.Name = "txt_endDate"
        Me.txt_endDate.Size = New System.Drawing.Size(207, 28)
        Me.txt_endDate.TabIndex = 34
        '
        'lst_artistDates
        '
        Me.lst_artistDates.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_artistDates.FormattingEnabled = True
        Me.lst_artistDates.ItemHeight = 20
        Me.lst_artistDates.Location = New System.Drawing.Point(966, 320)
        Me.lst_artistDates.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lst_artistDates.Name = "lst_artistDates"
        Me.lst_artistDates.Size = New System.Drawing.Size(150, 124)
        Me.lst_artistDates.TabIndex = 35
        '
        'btn_Query5
        '
        Me.btn_Query5.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Query5.Location = New System.Drawing.Point(744, 445)
        Me.btn_Query5.Name = "btn_Query5"
        Me.btn_Query5.Size = New System.Drawing.Size(114, 41)
        Me.btn_Query5.TabIndex = 36
        Me.btn_Query5.Text = "Search"
        Me.btn_Query5.UseVisualStyleBackColor = True
        '
        'txt_startDateQ6
        '
        Me.txt_startDateQ6.CalendarFont = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_startDateQ6.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_startDateQ6.Location = New System.Drawing.Point(701, 553)
        Me.txt_startDateQ6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_startDateQ6.Name = "txt_startDateQ6"
        Me.txt_startDateQ6.Size = New System.Drawing.Size(207, 28)
        Me.txt_startDateQ6.TabIndex = 37
        '
        'txt_endDateQ6
        '
        Me.txt_endDateQ6.CalendarFont = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_endDateQ6.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_endDateQ6.Location = New System.Drawing.Point(701, 629)
        Me.txt_endDateQ6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_endDateQ6.Name = "txt_endDateQ6"
        Me.txt_endDateQ6.Size = New System.Drawing.Size(207, 28)
        Me.txt_endDateQ6.TabIndex = 38
        '
        'lst_countries
        '
        Me.lst_countries.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_countries.FormattingEnabled = True
        Me.lst_countries.ItemHeight = 20
        Me.lst_countries.Location = New System.Drawing.Point(966, 553)
        Me.lst_countries.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lst_countries.Name = "lst_countries"
        Me.lst_countries.Size = New System.Drawing.Size(232, 124)
        Me.lst_countries.TabIndex = 39
        '
        'btn_Query6
        '
        Me.btn_Query6.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Query6.Location = New System.Drawing.Point(744, 677)
        Me.btn_Query6.Name = "btn_Query6"
        Me.btn_Query6.Size = New System.Drawing.Size(114, 41)
        Me.btn_Query6.TabIndex = 40
        Me.btn_Query6.Text = "Search"
        Me.btn_Query6.UseVisualStyleBackColor = True
        '
        'StatisticsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SetList.My.Resources.Resources.Five_Simple_Editing_Tips_That_Will_Make_Your_Photos_Stand_Out
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1382, 753)
        Me.Controls.Add(Me.btn_Query6)
        Me.Controls.Add(Me.lst_countries)
        Me.Controls.Add(Me.txt_endDateQ6)
        Me.Controls.Add(Me.txt_startDateQ6)
        Me.Controls.Add(Me.btn_Query5)
        Me.Controls.Add(Me.lst_artistDates)
        Me.Controls.Add(Me.txt_endDate)
        Me.Controls.Add(Me.txt_StartDate)
        Me.Controls.Add(Me.lst_Query3)
        Me.Controls.Add(Me.btn_Query3)
        Me.Controls.Add(Me.btn_searchSql2)
        Me.Controls.Add(Me.lst_albums)
        Me.Controls.Add(Me.lst_artistsAlbum)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_Query4)
        Me.Controls.Add(Me.lst_songs)
        Me.Controls.Add(Me.btn_searchSql1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lst_moreSinged)
        Me.Controls.Add(Me.lst_artists)
        Me.Name = "StatisticsForm"
        Me.Text = "StatisticsForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lst_artists As ListBox
    Friend WithEvents lst_moreSinged As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_searchSql1 As Button
    Friend WithEvents lst_songs As ListBox
    Friend WithEvents btn_Query4 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lst_artistsAlbum As ListBox
    Friend WithEvents lst_albums As ListBox
    Friend WithEvents btn_searchSql2 As Button
    Friend WithEvents btn_Query3 As Button
    Friend WithEvents lst_Query3 As ListBox
    Friend WithEvents txt_StartDate As DateTimePicker
    Friend WithEvents txt_endDate As DateTimePicker
    Friend WithEvents lst_artistDates As ListBox
    Friend WithEvents btn_Query5 As Button
    Friend WithEvents txt_startDateQ6 As DateTimePicker
    Friend WithEvents txt_endDateQ6 As DateTimePicker
    Friend WithEvents lst_countries As ListBox
    Friend WithEvents btn_Query6 As Button
End Class
