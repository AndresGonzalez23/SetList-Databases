﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StatisticsForm))
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lst_artists
        '
        Me.lst_artists.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_artists.FormattingEnabled = True
        Me.lst_artists.Location = New System.Drawing.Point(33, 54)
        Me.lst_artists.Margin = New System.Windows.Forms.Padding(2)
        Me.lst_artists.Name = "lst_artists"
        Me.lst_artists.Size = New System.Drawing.Size(144, 134)
        Me.lst_artists.TabIndex = 10
        '
        'lst_moreSinged
        '
        Me.lst_moreSinged.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_moreSinged.FormattingEnabled = True
        Me.lst_moreSinged.Location = New System.Drawing.Point(199, 54)
        Me.lst_moreSinged.Margin = New System.Windows.Forms.Padding(2)
        Me.lst_moreSinged.Name = "lst_moreSinged"
        Me.lst_moreSinged.Size = New System.Drawing.Size(160, 134)
        Me.lst_moreSinged.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(30, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(315, 32)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Songs performed the most times by an artist  " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "throughout all his/her concerts"
        '
        'btn_searchSql1
        '
        Me.btn_searchSql1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_searchSql1.Image = CType(resources.GetObject("btn_searchSql1.Image"), System.Drawing.Image)
        Me.btn_searchSql1.Location = New System.Drawing.Point(374, 149)
        Me.btn_searchSql1.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_searchSql1.Name = "btn_searchSql1"
        Me.btn_searchSql1.Size = New System.Drawing.Size(105, 37)
        Me.btn_searchSql1.TabIndex = 13
        Me.btn_searchSql1.Text = "Search"
        Me.btn_searchSql1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_searchSql1.UseVisualStyleBackColor = True
        '
        'lst_songs
        '
        Me.lst_songs.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_songs.FormattingEnabled = True
        Me.lst_songs.ItemHeight = 16
        Me.lst_songs.Location = New System.Drawing.Point(499, 54)
        Me.lst_songs.Margin = New System.Windows.Forms.Padding(2)
        Me.lst_songs.Name = "lst_songs"
        Me.lst_songs.Size = New System.Drawing.Size(332, 132)
        Me.lst_songs.TabIndex = 14
        '
        'btn_Query4
        '
        Me.btn_Query4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Query4.Image = CType(resources.GetObject("btn_Query4.Image"), System.Drawing.Image)
        Me.btn_Query4.Location = New System.Drawing.Point(842, 149)
        Me.btn_Query4.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_Query4.Name = "btn_Query4"
        Me.btn_Query4.Size = New System.Drawing.Size(105, 37)
        Me.btn_Query4.TabIndex = 15
        Me.btn_Query4.Text = "Search"
        Me.btn_Query4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Query4.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(501, 16)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(349, 32)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Complete Information of the songs that have been " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "performed the most times"
        '
        'lst_artistsAlbum
        '
        Me.lst_artistsAlbum.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_artistsAlbum.FormattingEnabled = True
        Me.lst_artistsAlbum.Location = New System.Drawing.Point(33, 235)
        Me.lst_artistsAlbum.Margin = New System.Windows.Forms.Padding(2)
        Me.lst_artistsAlbum.Name = "lst_artistsAlbum"
        Me.lst_artistsAlbum.Size = New System.Drawing.Size(144, 108)
        Me.lst_artistsAlbum.TabIndex = 17
        '
        'lst_albums
        '
        Me.lst_albums.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_albums.FormattingEnabled = True
        Me.lst_albums.Location = New System.Drawing.Point(199, 235)
        Me.lst_albums.Margin = New System.Windows.Forms.Padding(2)
        Me.lst_albums.Name = "lst_albums"
        Me.lst_albums.Size = New System.Drawing.Size(160, 108)
        Me.lst_albums.TabIndex = 18
        '
        'btn_searchSql2
        '
        Me.btn_searchSql2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_searchSql2.Image = CType(resources.GetObject("btn_searchSql2.Image"), System.Drawing.Image)
        Me.btn_searchSql2.Location = New System.Drawing.Point(363, 306)
        Me.btn_searchSql2.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_searchSql2.Name = "btn_searchSql2"
        Me.btn_searchSql2.Size = New System.Drawing.Size(105, 37)
        Me.btn_searchSql2.TabIndex = 19
        Me.btn_searchSql2.Text = "Search"
        Me.btn_searchSql2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_searchSql2.UseVisualStyleBackColor = True
        '
        'btn_Query3
        '
        Me.btn_Query3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Query3.Image = CType(resources.GetObject("btn_Query3.Image"), System.Drawing.Image)
        Me.btn_Query3.Location = New System.Drawing.Point(363, 457)
        Me.btn_Query3.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_Query3.Name = "btn_Query3"
        Me.btn_Query3.Size = New System.Drawing.Size(105, 37)
        Me.btn_Query3.TabIndex = 20
        Me.btn_Query3.Text = "Search"
        Me.btn_Query3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Query3.UseVisualStyleBackColor = True
        '
        'lst_Query3
        '
        Me.lst_Query3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_Query3.FormattingEnabled = True
        Me.lst_Query3.Location = New System.Drawing.Point(33, 399)
        Me.lst_Query3.Margin = New System.Windows.Forms.Padding(2)
        Me.lst_Query3.Name = "lst_Query3"
        Me.lst_Query3.Size = New System.Drawing.Size(326, 95)
        Me.lst_Query3.TabIndex = 21
        '
        'txt_StartDate
        '
        Me.txt_StartDate.CalendarFont = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_StartDate.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_StartDate.Location = New System.Drawing.Point(499, 234)
        Me.txt_StartDate.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_StartDate.Name = "txt_StartDate"
        Me.txt_StartDate.Size = New System.Drawing.Size(128, 21)
        Me.txt_StartDate.TabIndex = 33
        '
        'txt_endDate
        '
        Me.txt_endDate.CalendarFont = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_endDate.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_endDate.Location = New System.Drawing.Point(702, 236)
        Me.txt_endDate.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_endDate.Name = "txt_endDate"
        Me.txt_endDate.Size = New System.Drawing.Size(129, 21)
        Me.txt_endDate.TabIndex = 34
        '
        'lst_artistDates
        '
        Me.lst_artistDates.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_artistDates.FormattingEnabled = True
        Me.lst_artistDates.Location = New System.Drawing.Point(499, 261)
        Me.lst_artistDates.Margin = New System.Windows.Forms.Padding(2)
        Me.lst_artistDates.Name = "lst_artistDates"
        Me.lst_artistDates.Size = New System.Drawing.Size(332, 82)
        Me.lst_artistDates.TabIndex = 35
        '
        'btn_Query5
        '
        Me.btn_Query5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Query5.Image = Global.SetList.My.Resources.Resources.buscar
        Me.btn_Query5.Location = New System.Drawing.Point(842, 293)
        Me.btn_Query5.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_Query5.Name = "btn_Query5"
        Me.btn_Query5.Size = New System.Drawing.Size(105, 37)
        Me.btn_Query5.TabIndex = 36
        Me.btn_Query5.Text = "Search"
        Me.btn_Query5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Query5.UseVisualStyleBackColor = True
        '
        'txt_startDateQ6
        '
        Me.txt_startDateQ6.CalendarFont = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_startDateQ6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_startDateQ6.Location = New System.Drawing.Point(499, 400)
        Me.txt_startDateQ6.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_startDateQ6.Name = "txt_startDateQ6"
        Me.txt_startDateQ6.Size = New System.Drawing.Size(128, 21)
        Me.txt_startDateQ6.TabIndex = 37
        '
        'txt_endDateQ6
        '
        Me.txt_endDateQ6.CalendarFont = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_endDateQ6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_endDateQ6.Location = New System.Drawing.Point(702, 400)
        Me.txt_endDateQ6.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_endDateQ6.Name = "txt_endDateQ6"
        Me.txt_endDateQ6.Size = New System.Drawing.Size(129, 21)
        Me.txt_endDateQ6.TabIndex = 38
        '
        'lst_countries
        '
        Me.lst_countries.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_countries.FormattingEnabled = True
        Me.lst_countries.Location = New System.Drawing.Point(499, 425)
        Me.lst_countries.Margin = New System.Windows.Forms.Padding(2)
        Me.lst_countries.Name = "lst_countries"
        Me.lst_countries.Size = New System.Drawing.Size(332, 69)
        Me.lst_countries.TabIndex = 39
        '
        'btn_Query6
        '
        Me.btn_Query6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Query6.Image = CType(resources.GetObject("btn_Query6.Image"), System.Drawing.Image)
        Me.btn_Query6.Location = New System.Drawing.Point(842, 457)
        Me.btn_Query6.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_Query6.Name = "btn_Query6"
        Me.btn_Query6.Size = New System.Drawing.Size(105, 37)
        Me.btn_Query6.TabIndex = 40
        Me.btn_Query6.Text = "Search"
        Me.btn_Query6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Query6.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lst_albums)
        Me.Panel1.Controls.Add(Me.btn_Query4)
        Me.Panel1.Controls.Add(Me.btn_searchSql2)
        Me.Panel1.Controls.Add(Me.lst_songs)
        Me.Panel1.Controls.Add(Me.lst_artistsAlbum)
        Me.Panel1.Controls.Add(Me.btn_searchSql1)
        Me.Panel1.Controls.Add(Me.btn_Query3)
        Me.Panel1.Controls.Add(Me.lst_artists)
        Me.Panel1.Controls.Add(Me.lst_moreSinged)
        Me.Panel1.Controls.Add(Me.lst_Query3)
        Me.Panel1.Controls.Add(Me.btn_Query6)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lst_countries)
        Me.Panel1.Controls.Add(Me.lst_artistDates)
        Me.Panel1.Controls.Add(Me.txt_endDateQ6)
        Me.Panel1.Controls.Add(Me.txt_StartDate)
        Me.Panel1.Controls.Add(Me.txt_startDateQ6)
        Me.Panel1.Controls.Add(Me.txt_endDate)
        Me.Panel1.Controls.Add(Me.btn_Query5)
        Me.Panel1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(57, 66)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(971, 523)
        Me.Panel1.TabIndex = 41
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(30, 365)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(351, 32)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Artists who have ever performed a complete album " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "in a concert"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(32, 201)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(327, 32)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Ordered list of albums performed the most times" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "by an artist." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(501, 218)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 16)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Start date" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(699, 218)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 16)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "End date" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(501, 201)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(164, 16)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Most concerts by artist"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(496, 365)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(190, 16)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "Most concerts by countries"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(496, 382)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 16)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "Start date" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(699, 382)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 16)
        Me.Label10.TabIndex = 48
        Me.Label10.Text = "End date" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Verdana", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label14.Location = New System.Drawing.Point(470, 22)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(154, 32)
        Me.Label14.TabIndex = 42
        Me.Label14.Text = "Statistics"
        '
        'btn_back
        '
        Me.btn_back.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.Image = Global.SetList.My.Resources.Resources.volver__1_
        Me.btn_back.Location = New System.Drawing.Point(57, 6)
        Me.btn_back.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(136, 55)
        Me.btn_back.TabIndex = 55
        Me.btn_back.Text = "BACK"
        Me.btn_back.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'StatisticsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SetList.My.Resources.Resources.Five_Simple_Editing_Tips_That_Will_Make_Your_Photos_Stand_Out
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1074, 612)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "StatisticsForm"
        Me.Text = "StatisticsForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents btn_back As Button
End Class
