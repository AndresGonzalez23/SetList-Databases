<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btn_connection = New System.Windows.Forms.Button()
        Me.btn_insert_country = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lst_Countries = New System.Windows.Forms.ListBox()
        Me.btn_update_country = New System.Windows.Forms.Button()
        Me.btn_delete_country = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lst_artits = New System.Windows.Forms.ListBox()
        Me.txt_artistName = New System.Windows.Forms.TextBox()
        Me.btn_insertArtist = New System.Windows.Forms.Button()
        Me.btn_updateArtist = New System.Windows.Forms.Button()
        Me.btn_deleteArtist = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_artistCountry = New System.Windows.Forms.TextBox()
        Me.lst_venues = New System.Windows.Forms.ListBox()
        Me.txt_venueName = New System.Windows.Forms.TextBox()
        Me.txt_venueCountry = New System.Windows.Forms.TextBox()
        Me.btn_insertVenue = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.cmb_venuesType = New System.Windows.Forms.ComboBox()
        Me.btn_updateVenue = New System.Windows.Forms.Button()
        Me.btn_deleteVenue = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txt_albumArtist = New System.Windows.Forms.TextBox()
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
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txt_setlistOrder = New System.Windows.Forms.TextBox()
        Me.lst_concertSetlist = New System.Windows.Forms.ListBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btn_deleteConcert = New System.Windows.Forms.Button()
        Me.btn_updateConcert = New System.Windows.Forms.Button()
        Me.btn_insertConcert = New System.Windows.Forms.Button()
        Me.txt_dateConcert = New System.Windows.Forms.DateTimePicker()
        Me.txt_venueConcert = New System.Windows.Forms.TextBox()
        Me.txt_artistConcert = New System.Windows.Forms.TextBox()
        Me.lst_concerts = New System.Windows.Forms.ListBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.txt_songOrder = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txt_songAlbum = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txt_songLength = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txt_songName = New System.Windows.Forms.TextBox()
        Me.btn_deleteSong = New System.Windows.Forms.Button()
        Me.btn_updateSong = New System.Windows.Forms.Button()
        Me.btn_insertSong = New System.Windows.Forms.Button()
        Me.lst_songs = New System.Windows.Forms.ListBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btn_setlist = New System.Windows.Forms.Button()
        Me.btn_Statistics = New System.Windows.Forms.Button()
        Me.btn_insertSongInSetlist = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_connection
        '
        Me.btn_connection.BackColor = System.Drawing.Color.Transparent
        Me.btn_connection.FlatAppearance.BorderSize = 0
        Me.btn_connection.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_connection.ForeColor = System.Drawing.Color.Transparent
        Me.btn_connection.Image = CType(resources.GetObject("btn_connection.Image"), System.Drawing.Image)
        Me.btn_connection.Location = New System.Drawing.Point(981, 780)
        Me.btn_connection.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_connection.Name = "btn_connection"
        Me.btn_connection.Size = New System.Drawing.Size(443, 49)
        Me.btn_connection.TabIndex = 0
        Me.btn_connection.Text = "Connect to database"
        Me.btn_connection.UseVisualStyleBackColor = False
        '
        'btn_insert_country
        '
        Me.btn_insert_country.Enabled = False
        Me.btn_insert_country.Image = CType(resources.GetObject("btn_insert_country.Image"), System.Drawing.Image)
        Me.btn_insert_country.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_insert_country.Location = New System.Drawing.Point(19, 224)
        Me.btn_insert_country.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_insert_country.Name = "btn_insert_country"
        Me.btn_insert_country.Size = New System.Drawing.Size(108, 50)
        Me.btn_insert_country.TabIndex = 3
        Me.btn_insert_country.Text = "Add country"
        Me.btn_insert_country.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_insert_country.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(219, 66)
        Me.txtName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(201, 22)
        Me.txtName.TabIndex = 4
        '
        'lst_Countries
        '
        Me.lst_Countries.FormattingEnabled = True
        Me.lst_Countries.ItemHeight = 16
        Me.lst_Countries.Location = New System.Drawing.Point(19, 66)
        Me.lst_Countries.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lst_Countries.Name = "lst_Countries"
        Me.lst_Countries.Size = New System.Drawing.Size(175, 132)
        Me.lst_Countries.TabIndex = 5
        '
        'btn_update_country
        '
        Me.btn_update_country.Enabled = False
        Me.btn_update_country.Image = CType(resources.GetObject("btn_update_country.Image"), System.Drawing.Image)
        Me.btn_update_country.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_update_country.Location = New System.Drawing.Point(145, 224)
        Me.btn_update_country.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_update_country.Name = "btn_update_country"
        Me.btn_update_country.Size = New System.Drawing.Size(125, 50)
        Me.btn_update_country.TabIndex = 6
        Me.btn_update_country.Text = "Update Country"
        Me.btn_update_country.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_update_country.UseVisualStyleBackColor = True
        '
        'btn_delete_country
        '
        Me.btn_delete_country.Enabled = False
        Me.btn_delete_country.Image = CType(resources.GetObject("btn_delete_country.Image"), System.Drawing.Image)
        Me.btn_delete_country.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_delete_country.Location = New System.Drawing.Point(289, 224)
        Me.btn_delete_country.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_delete_country.Name = "btn_delete_country"
        Me.btn_delete_country.Size = New System.Drawing.Size(132, 50)
        Me.btn_delete_country.TabIndex = 7
        Me.btn_delete_country.Text = "Delete Country"
        Me.btn_delete_country.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_delete_country.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(67, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 29)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Country"
        '
        'lst_artits
        '
        Me.lst_artits.FormattingEnabled = True
        Me.lst_artits.ItemHeight = 16
        Me.lst_artits.Location = New System.Drawing.Point(19, 57)
        Me.lst_artits.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lst_artits.Name = "lst_artits"
        Me.lst_artits.Size = New System.Drawing.Size(175, 148)
        Me.lst_artits.TabIndex = 9
        '
        'txt_artistName
        '
        Me.txt_artistName.Location = New System.Drawing.Point(219, 82)
        Me.txt_artistName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_artistName.Name = "txt_artistName"
        Me.txt_artistName.Size = New System.Drawing.Size(211, 22)
        Me.txt_artistName.TabIndex = 10
        '
        'btn_insertArtist
        '
        Me.btn_insertArtist.Enabled = False
        Me.btn_insertArtist.Image = CType(resources.GetObject("btn_insertArtist.Image"), System.Drawing.Image)
        Me.btn_insertArtist.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_insertArtist.Location = New System.Drawing.Point(19, 236)
        Me.btn_insertArtist.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_insertArtist.Name = "btn_insertArtist"
        Me.btn_insertArtist.Size = New System.Drawing.Size(107, 49)
        Me.btn_insertArtist.TabIndex = 12
        Me.btn_insertArtist.Text = "Insert artist"
        Me.btn_insertArtist.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_insertArtist.UseVisualStyleBackColor = True
        '
        'btn_updateArtist
        '
        Me.btn_updateArtist.Enabled = False
        Me.btn_updateArtist.Image = CType(resources.GetObject("btn_updateArtist.Image"), System.Drawing.Image)
        Me.btn_updateArtist.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_updateArtist.Location = New System.Drawing.Point(131, 236)
        Me.btn_updateArtist.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_updateArtist.Name = "btn_updateArtist"
        Me.btn_updateArtist.Size = New System.Drawing.Size(125, 49)
        Me.btn_updateArtist.TabIndex = 13
        Me.btn_updateArtist.Text = "Update Artist"
        Me.btn_updateArtist.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_updateArtist.UseVisualStyleBackColor = True
        '
        'btn_deleteArtist
        '
        Me.btn_deleteArtist.Enabled = False
        Me.btn_deleteArtist.Image = CType(resources.GetObject("btn_deleteArtist.Image"), System.Drawing.Image)
        Me.btn_deleteArtist.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_deleteArtist.Location = New System.Drawing.Point(261, 236)
        Me.btn_deleteArtist.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_deleteArtist.Name = "btn_deleteArtist"
        Me.btn_deleteArtist.Size = New System.Drawing.Size(132, 49)
        Me.btn_deleteArtist.TabIndex = 14
        Me.btn_deleteArtist.Text = "Delete Artist"
        Me.btn_deleteArtist.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_deleteArtist.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(91, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 29)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Artists"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(217, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 29)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(217, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 29)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Name"
        '
        'txt_artistCountry
        '
        Me.txt_artistCountry.Location = New System.Drawing.Point(219, 174)
        Me.txt_artistCountry.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_artistCountry.Name = "txt_artistCountry"
        Me.txt_artistCountry.Size = New System.Drawing.Size(211, 22)
        Me.txt_artistCountry.TabIndex = 19
        '
        'lst_venues
        '
        Me.lst_venues.FormattingEnabled = True
        Me.lst_venues.ItemHeight = 16
        Me.lst_venues.Location = New System.Drawing.Point(19, 66)
        Me.lst_venues.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lst_venues.Name = "lst_venues"
        Me.lst_venues.Size = New System.Drawing.Size(175, 132)
        Me.lst_venues.TabIndex = 20
        '
        'txt_venueName
        '
        Me.txt_venueName.Location = New System.Drawing.Point(219, 66)
        Me.txt_venueName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_venueName.Name = "txt_venueName"
        Me.txt_venueName.Size = New System.Drawing.Size(211, 22)
        Me.txt_venueName.TabIndex = 21
        '
        'txt_venueCountry
        '
        Me.txt_venueCountry.Location = New System.Drawing.Point(219, 129)
        Me.txt_venueCountry.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_venueCountry.Name = "txt_venueCountry"
        Me.txt_venueCountry.Size = New System.Drawing.Size(211, 22)
        Me.txt_venueCountry.TabIndex = 22
        '
        'btn_insertVenue
        '
        Me.btn_insertVenue.Enabled = False
        Me.btn_insertVenue.Image = CType(resources.GetObject("btn_insertVenue.Image"), System.Drawing.Image)
        Me.btn_insertVenue.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_insertVenue.Location = New System.Drawing.Point(19, 236)
        Me.btn_insertVenue.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_insertVenue.Name = "btn_insertVenue"
        Me.btn_insertVenue.Size = New System.Drawing.Size(109, 44)
        Me.btn_insertVenue.TabIndex = 24
        Me.btn_insertVenue.Text = "Insertar venue" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btn_insertVenue.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_insertVenue.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(599, 12)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(357, 95)
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.cmb_venuesType)
        Me.Panel1.Controls.Add(Me.btn_updateVenue)
        Me.Panel1.Controls.Add(Me.btn_deleteVenue)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lst_venues)
        Me.Panel1.Controls.Add(Me.txt_venueName)
        Me.Panel1.Controls.Add(Me.btn_insertVenue)
        Me.Panel1.Controls.Add(Me.txt_venueCountry)
        Me.Panel1.Location = New System.Drawing.Point(499, 138)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(442, 294)
        Me.Panel1.TabIndex = 26
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(28, 6)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(39, 38)
        Me.PictureBox4.TabIndex = 28
        Me.PictureBox4.TabStop = False
        '
        'cmb_venuesType
        '
        Me.cmb_venuesType.FormattingEnabled = True
        Me.cmb_venuesType.Items.AddRange(New Object() {"HALL", "PAVILION", "STADIUM", "FESTIVAL"})
        Me.cmb_venuesType.Location = New System.Drawing.Point(219, 196)
        Me.cmb_venuesType.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmb_venuesType.Name = "cmb_venuesType"
        Me.cmb_venuesType.Size = New System.Drawing.Size(211, 24)
        Me.cmb_venuesType.TabIndex = 29
        '
        'btn_updateVenue
        '
        Me.btn_updateVenue.Enabled = False
        Me.btn_updateVenue.Image = CType(resources.GetObject("btn_updateVenue.Image"), System.Drawing.Image)
        Me.btn_updateVenue.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_updateVenue.Location = New System.Drawing.Point(133, 236)
        Me.btn_updateVenue.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_updateVenue.Name = "btn_updateVenue"
        Me.btn_updateVenue.Size = New System.Drawing.Size(111, 44)
        Me.btn_updateVenue.TabIndex = 28
        Me.btn_updateVenue.Text = "Update venue"
        Me.btn_updateVenue.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_updateVenue.UseVisualStyleBackColor = True
        '
        'btn_deleteVenue
        '
        Me.btn_deleteVenue.Enabled = False
        Me.btn_deleteVenue.Image = CType(resources.GetObject("btn_deleteVenue.Image"), System.Drawing.Image)
        Me.btn_deleteVenue.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_deleteVenue.Location = New System.Drawing.Point(251, 236)
        Me.btn_deleteVenue.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_deleteVenue.Name = "btn_deleteVenue"
        Me.btn_deleteVenue.Size = New System.Drawing.Size(120, 44)
        Me.btn_deleteVenue.TabIndex = 26
        Me.btn_deleteVenue.Text = "Delete venue"
        Me.btn_deleteVenue.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_deleteVenue.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(212, 161)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 29)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Type"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(212, 96)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 29)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Country"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(212, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 29)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(81, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 29)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Venues"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.lst_Countries)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.txtName)
        Me.Panel2.Controls.Add(Me.btn_insert_country)
        Me.Panel2.Controls.Add(Me.btn_update_country)
        Me.Panel2.Controls.Add(Me.btn_delete_country)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(25, 138)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(441, 294)
        Me.Panel2.TabIndex = 27
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(29, 14)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(31, 33)
        Me.PictureBox2.TabIndex = 28
        Me.PictureBox2.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Silver
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.PictureBox3)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.lst_artits)
        Me.Panel3.Controls.Add(Me.btn_insertArtist)
        Me.Panel3.Controls.Add(Me.btn_updateArtist)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.txt_artistCountry)
        Me.Panel3.Controls.Add(Me.btn_deleteArtist)
        Me.Panel3.Controls.Add(Me.txt_artistName)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Location = New System.Drawing.Point(25, 464)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(441, 294)
        Me.Panel3.TabIndex = 27
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(29, 18)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(40, 31)
        Me.PictureBox3.TabIndex = 28
        Me.PictureBox3.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(221, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 29)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Country"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Silver
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.txt_albumArtist)
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
        Me.Panel4.Location = New System.Drawing.Point(499, 464)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(442, 294)
        Me.Panel4.TabIndex = 30
        '
        'txt_albumArtist
        '
        Me.txt_albumArtist.Location = New System.Drawing.Point(217, 182)
        Me.txt_albumArtist.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_albumArtist.Name = "txt_albumArtist"
        Me.txt_albumArtist.Size = New System.Drawing.Size(211, 22)
        Me.txt_albumArtist.TabIndex = 29
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
        Me.btn_updateAlbum.Location = New System.Drawing.Point(133, 225)
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
        Me.btn_deleteAlbum.Location = New System.Drawing.Point(251, 226)
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
        Me.Label10.Location = New System.Drawing.Point(212, 149)
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
        Me.Label11.Location = New System.Drawing.Point(213, 82)
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
        Me.Label12.Location = New System.Drawing.Point(212, 12)
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
        Me.lst_albums.Size = New System.Drawing.Size(175, 148)
        Me.lst_albums.TabIndex = 20
        '
        'txt_albumName
        '
        Me.txt_albumName.Location = New System.Drawing.Point(217, 48)
        Me.txt_albumName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_albumName.Name = "txt_albumName"
        Me.txt_albumName.Size = New System.Drawing.Size(211, 22)
        Me.txt_albumName.TabIndex = 21
        '
        'btn_insertAlbum
        '
        Me.btn_insertAlbum.Enabled = False
        Me.btn_insertAlbum.Image = CType(resources.GetObject("btn_insertAlbum.Image"), System.Drawing.Image)
        Me.btn_insertAlbum.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_insertAlbum.Location = New System.Drawing.Point(19, 226)
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
        Me.txt_albumYear.Location = New System.Drawing.Point(217, 122)
        Me.txt_albumYear.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_albumYear.Name = "txt_albumYear"
        Me.txt_albumYear.Size = New System.Drawing.Size(211, 22)
        Me.txt_albumYear.TabIndex = 22
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Silver
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.btn_insertSongInSetlist)
        Me.Panel5.Controls.Add(Me.txt_setlistOrder)
        Me.Panel5.Controls.Add(Me.lst_concertSetlist)
        Me.Panel5.Controls.Add(Me.Label19)
        Me.Panel5.Controls.Add(Me.Label18)
        Me.Panel5.Controls.Add(Me.Label16)
        Me.Panel5.Controls.Add(Me.Label15)
        Me.Panel5.Controls.Add(Me.btn_deleteConcert)
        Me.Panel5.Controls.Add(Me.btn_updateConcert)
        Me.Panel5.Controls.Add(Me.btn_insertConcert)
        Me.Panel5.Controls.Add(Me.txt_dateConcert)
        Me.Panel5.Controls.Add(Me.txt_venueConcert)
        Me.Panel5.Controls.Add(Me.txt_artistConcert)
        Me.Panel5.Controls.Add(Me.lst_concerts)
        Me.Panel5.Controls.Add(Me.PictureBox6)
        Me.Panel5.Controls.Add(Me.Label17)
        Me.Panel5.Location = New System.Drawing.Point(1437, 138)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(439, 620)
        Me.Panel5.TabIndex = 31
        '
        'txt_setlistOrder
        '
        Me.txt_setlistOrder.Location = New System.Drawing.Point(206, 312)
        Me.txt_setlistOrder.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_setlistOrder.Name = "txt_setlistOrder"
        Me.txt_setlistOrder.Size = New System.Drawing.Size(207, 22)
        Me.txt_setlistOrder.TabIndex = 37
        '
        'lst_concertSetlist
        '
        Me.lst_concertSetlist.FormattingEnabled = True
        Me.lst_concertSetlist.ItemHeight = 16
        Me.lst_concertSetlist.Location = New System.Drawing.Point(31, 312)
        Me.lst_concertSetlist.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lst_concertSetlist.Name = "lst_concertSetlist"
        Me.lst_concertSetlist.Size = New System.Drawing.Size(151, 228)
        Me.lst_concertSetlist.TabIndex = 36
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label19.Location = New System.Drawing.Point(24, 59)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(153, 25)
        Me.Label19.TabIndex = 35
        Me.Label19.Text = "Artist - Venue"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label18.Location = New System.Drawing.Point(201, 44)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(69, 29)
        Me.Label18.TabIndex = 34
        Me.Label18.Text = "Date"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label16.Location = New System.Drawing.Point(201, 164)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(86, 29)
        Me.Label16.TabIndex = 30
        Me.Label16.Text = "Venue"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label15.Location = New System.Drawing.Point(201, 101)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(76, 29)
        Me.Label15.TabIndex = 30
        Me.Label15.Text = "Artist"
        '
        'btn_deleteConcert
        '
        Me.btn_deleteConcert.Enabled = False
        Me.btn_deleteConcert.Image = CType(resources.GetObject("btn_deleteConcert.Image"), System.Drawing.Image)
        Me.btn_deleteConcert.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_deleteConcert.Location = New System.Drawing.Point(289, 236)
        Me.btn_deleteConcert.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_deleteConcert.Name = "btn_deleteConcert"
        Me.btn_deleteConcert.Size = New System.Drawing.Size(123, 44)
        Me.btn_deleteConcert.TabIndex = 30
        Me.btn_deleteConcert.Text = "Delete concert"
        Me.btn_deleteConcert.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_deleteConcert.UseVisualStyleBackColor = True
        '
        'btn_updateConcert
        '
        Me.btn_updateConcert.Enabled = False
        Me.btn_updateConcert.Image = CType(resources.GetObject("btn_updateConcert.Image"), System.Drawing.Image)
        Me.btn_updateConcert.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_updateConcert.Location = New System.Drawing.Point(160, 236)
        Me.btn_updateConcert.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_updateConcert.Name = "btn_updateConcert"
        Me.btn_updateConcert.Size = New System.Drawing.Size(123, 44)
        Me.btn_updateConcert.TabIndex = 30
        Me.btn_updateConcert.Text = "Update Concert"
        Me.btn_updateConcert.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_updateConcert.UseVisualStyleBackColor = True
        '
        'btn_insertConcert
        '
        Me.btn_insertConcert.Enabled = False
        Me.btn_insertConcert.Image = Global.SetList.My.Resources.Resources.plus__1_
        Me.btn_insertConcert.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_insertConcert.Location = New System.Drawing.Point(31, 236)
        Me.btn_insertConcert.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_insertConcert.Name = "btn_insertConcert"
        Me.btn_insertConcert.Size = New System.Drawing.Size(123, 44)
        Me.btn_insertConcert.TabIndex = 33
        Me.btn_insertConcert.Text = "Insert Concert"
        Me.btn_insertConcert.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_insertConcert.UseVisualStyleBackColor = True
        '
        'txt_dateConcert
        '
        Me.txt_dateConcert.Location = New System.Drawing.Point(205, 76)
        Me.txt_dateConcert.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_dateConcert.Name = "txt_dateConcert"
        Me.txt_dateConcert.Size = New System.Drawing.Size(207, 22)
        Me.txt_dateConcert.TabIndex = 32
        '
        'txt_venueConcert
        '
        Me.txt_venueConcert.Location = New System.Drawing.Point(205, 194)
        Me.txt_venueConcert.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_venueConcert.Name = "txt_venueConcert"
        Me.txt_venueConcert.Size = New System.Drawing.Size(207, 22)
        Me.txt_venueConcert.TabIndex = 31
        '
        'txt_artistConcert
        '
        Me.txt_artistConcert.Location = New System.Drawing.Point(205, 133)
        Me.txt_artistConcert.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_artistConcert.Name = "txt_artistConcert"
        Me.txt_artistConcert.Size = New System.Drawing.Size(207, 22)
        Me.txt_artistConcert.TabIndex = 30
        '
        'lst_concerts
        '
        Me.lst_concerts.FormattingEnabled = True
        Me.lst_concerts.ItemHeight = 16
        Me.lst_concerts.Location = New System.Drawing.Point(31, 85)
        Me.lst_concerts.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lst_concerts.Name = "lst_concerts"
        Me.lst_concerts.Size = New System.Drawing.Size(151, 132)
        Me.lst_concerts.TabIndex = 29
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(28, 12)
        Me.PictureBox6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(39, 38)
        Me.PictureBox6.TabIndex = 28
        Me.PictureBox6.TabStop = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label17.Location = New System.Drawing.Point(73, 14)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(119, 29)
        Me.Label17.TabIndex = 18
        Me.Label17.Text = "Concerts"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Silver
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.txt_songOrder)
        Me.Panel6.Controls.Add(Me.Label23)
        Me.Panel6.Controls.Add(Me.txt_songAlbum)
        Me.Panel6.Controls.Add(Me.Label22)
        Me.Panel6.Controls.Add(Me.txt_songLength)
        Me.Panel6.Controls.Add(Me.Label21)
        Me.Panel6.Controls.Add(Me.Label20)
        Me.Panel6.Controls.Add(Me.txt_songName)
        Me.Panel6.Controls.Add(Me.btn_deleteSong)
        Me.Panel6.Controls.Add(Me.btn_updateSong)
        Me.Panel6.Controls.Add(Me.btn_insertSong)
        Me.Panel6.Controls.Add(Me.lst_songs)
        Me.Panel6.Controls.Add(Me.PictureBox7)
        Me.Panel6.Controls.Add(Me.Label14)
        Me.Panel6.Location = New System.Drawing.Point(981, 464)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(439, 294)
        Me.Panel6.TabIndex = 34
        '
        'txt_songOrder
        '
        Me.txt_songOrder.Location = New System.Drawing.Point(205, 196)
        Me.txt_songOrder.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_songOrder.Name = "txt_songOrder"
        Me.txt_songOrder.Size = New System.Drawing.Size(207, 22)
        Me.txt_songOrder.TabIndex = 30
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label23.Location = New System.Drawing.Point(207, 174)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(81, 58)
        Me.Label23.TabIndex = 39
        Me.Label23.Text = "Order" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txt_songAlbum
        '
        Me.txt_songAlbum.Location = New System.Drawing.Point(205, 148)
        Me.txt_songAlbum.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_songAlbum.Name = "txt_songAlbum"
        Me.txt_songAlbum.Size = New System.Drawing.Size(207, 22)
        Me.txt_songAlbum.TabIndex = 31
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label22.Location = New System.Drawing.Point(207, 122)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(88, 87)
        Me.Label22.TabIndex = 38
        Me.Label22.Text = "Album" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txt_songLength
        '
        Me.txt_songLength.Location = New System.Drawing.Point(205, 96)
        Me.txt_songLength.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_songLength.Name = "txt_songLength"
        Me.txt_songLength.Size = New System.Drawing.Size(207, 22)
        Me.txt_songLength.TabIndex = 35
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label21.Location = New System.Drawing.Point(207, 69)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(94, 58)
        Me.Label21.TabIndex = 37
        Me.Label21.Text = "Length" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label20.Location = New System.Drawing.Point(207, 12)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(82, 29)
        Me.Label20.TabIndex = 36
        Me.Label20.Text = "Name" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txt_songName
        '
        Me.txt_songName.Location = New System.Drawing.Point(205, 42)
        Me.txt_songName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_songName.Name = "txt_songName"
        Me.txt_songName.Size = New System.Drawing.Size(207, 22)
        Me.txt_songName.TabIndex = 34
        '
        'btn_deleteSong
        '
        Me.btn_deleteSong.Enabled = False
        Me.btn_deleteSong.Image = CType(resources.GetObject("btn_deleteSong.Image"), System.Drawing.Image)
        Me.btn_deleteSong.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_deleteSong.Location = New System.Drawing.Point(289, 236)
        Me.btn_deleteSong.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_deleteSong.Name = "btn_deleteSong"
        Me.btn_deleteSong.Size = New System.Drawing.Size(123, 44)
        Me.btn_deleteSong.TabIndex = 30
        Me.btn_deleteSong.Text = "Delete Song"
        Me.btn_deleteSong.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_deleteSong.UseVisualStyleBackColor = True
        '
        'btn_updateSong
        '
        Me.btn_updateSong.Enabled = False
        Me.btn_updateSong.Image = CType(resources.GetObject("btn_updateSong.Image"), System.Drawing.Image)
        Me.btn_updateSong.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_updateSong.Location = New System.Drawing.Point(160, 236)
        Me.btn_updateSong.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_updateSong.Name = "btn_updateSong"
        Me.btn_updateSong.Size = New System.Drawing.Size(123, 44)
        Me.btn_updateSong.TabIndex = 30
        Me.btn_updateSong.Text = "Update Song"
        Me.btn_updateSong.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_updateSong.UseVisualStyleBackColor = True
        '
        'btn_insertSong
        '
        Me.btn_insertSong.Enabled = False
        Me.btn_insertSong.Image = Global.SetList.My.Resources.Resources.plus__1_
        Me.btn_insertSong.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_insertSong.Location = New System.Drawing.Point(31, 236)
        Me.btn_insertSong.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_insertSong.Name = "btn_insertSong"
        Me.btn_insertSong.Size = New System.Drawing.Size(123, 44)
        Me.btn_insertSong.TabIndex = 33
        Me.btn_insertSong.Text = "Insert Song"
        Me.btn_insertSong.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_insertSong.UseVisualStyleBackColor = True
        '
        'lst_songs
        '
        Me.lst_songs.FormattingEnabled = True
        Me.lst_songs.ItemHeight = 16
        Me.lst_songs.Location = New System.Drawing.Point(31, 69)
        Me.lst_songs.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lst_songs.Name = "lst_songs"
        Me.lst_songs.Size = New System.Drawing.Size(151, 148)
        Me.lst_songs.TabIndex = 29
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox7.Image = Global.SetList.My.Resources.Resources.music
        Me.PictureBox7.Location = New System.Drawing.Point(31, 18)
        Me.PictureBox7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(39, 38)
        Me.PictureBox7.TabIndex = 28
        Me.PictureBox7.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label14.Location = New System.Drawing.Point(81, 18)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(87, 29)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "Songs"
        '
        'btn_setlist
        '
        Me.btn_setlist.Location = New System.Drawing.Point(499, 775)
        Me.btn_setlist.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_setlist.Name = "btn_setlist"
        Me.btn_setlist.Size = New System.Drawing.Size(441, 54)
        Me.btn_setlist.TabIndex = 35
        Me.btn_setlist.Text = "setlist" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btn_setlist.UseVisualStyleBackColor = True
        '
        'btn_Statistics
        '
        Me.btn_Statistics.Location = New System.Drawing.Point(25, 775)
        Me.btn_Statistics.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Statistics.Name = "btn_Statistics"
        Me.btn_Statistics.Size = New System.Drawing.Size(441, 54)
        Me.btn_Statistics.TabIndex = 36
        Me.btn_Statistics.Text = "Statistics" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btn_Statistics.UseVisualStyleBackColor = True
        '
        'btn_insertSongInSetlist
        '
        Me.btn_insertSongInSetlist.Enabled = False
        Me.btn_insertSongInSetlist.Image = Global.SetList.My.Resources.Resources.plus__1_
        Me.btn_insertSongInSetlist.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_insertSongInSetlist.Location = New System.Drawing.Point(290, 360)
        Me.btn_insertSongInSetlist.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_insertSongInSetlist.Name = "btn_insertSongInSetlist"
        Me.btn_insertSongInSetlist.Size = New System.Drawing.Size(123, 44)
        Me.btn_insertSongInSetlist.TabIndex = 38
        Me.btn_insertSongInSetlist.Text = "Insert Song in Setlist"
        Me.btn_insertSongInSetlist.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_insertSongInSetlist.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1900, 1031)
        Me.Controls.Add(Me.btn_Statistics)
        Me.Controls.Add(Me.btn_setlist)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_connection)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1918, 1078)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1918, 1078)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_connection As Button
    Friend WithEvents btn_insert_country As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents lst_Countries As ListBox
    Friend WithEvents btn_update_country As Button
    Friend WithEvents btn_delete_country As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lst_artits As ListBox
    Friend WithEvents txt_artistName As TextBox
    Friend WithEvents btn_insertArtist As Button
    Friend WithEvents btn_updateArtist As Button
    Friend WithEvents btn_deleteArtist As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_artistCountry As TextBox
    Friend WithEvents lst_venues As ListBox
    Friend WithEvents txt_venueName As TextBox
    Friend WithEvents txt_venueCountry As TextBox
    Friend WithEvents btn_insertVenue As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btn_deleteVenue As Button
    Friend WithEvents btn_updateVenue As Button
    Friend WithEvents cmb_venuesType As ComboBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txt_albumArtist As TextBox
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
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txt_dateConcert As DateTimePicker
    Friend WithEvents txt_venueConcert As TextBox
    Friend WithEvents txt_artistConcert As TextBox
    Friend WithEvents lst_concerts As ListBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btn_insertConcert As Button
    Friend WithEvents btn_deleteConcert As Button
    Friend WithEvents btn_updateConcert As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents txt_songLength As TextBox
    Friend WithEvents txt_songName As TextBox
    Friend WithEvents btn_deleteSong As Button
    Friend WithEvents btn_updateSong As Button
    Friend WithEvents btn_insertSong As Button
    Friend WithEvents txt_songAlbum As TextBox
    Friend WithEvents txt_songOrder As TextBox
    Friend WithEvents lst_songs As ListBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents btn_setlist As Button
    Friend WithEvents btn_Statistics As Button
    Friend WithEvents txt_setlistOrder As TextBox
    Friend WithEvents lst_concertSetlist As ListBox
    Friend WithEvents btn_insertSongInSetlist As Button
End Class
