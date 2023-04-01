<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txt_albumArtist = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_connection
        '
        Me.btn_connection.BackColor = System.Drawing.Color.Transparent
        Me.btn_connection.FlatAppearance.BorderSize = 0
        Me.btn_connection.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_connection.ForeColor = System.Drawing.Color.Transparent
        Me.btn_connection.Image = CType(resources.GetObject("btn_connection.Image"), System.Drawing.Image)
        Me.btn_connection.Location = New System.Drawing.Point(981, 759)
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
        Me.btn_insert_country.Image = Global.SetList.My.Resources.Resources.plus__1_
        Me.btn_insert_country.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_insert_country.Location = New System.Drawing.Point(18, 224)
        Me.btn_insert_country.Name = "btn_insert_country"
        Me.btn_insert_country.Size = New System.Drawing.Size(108, 51)
        Me.btn_insert_country.TabIndex = 3
        Me.btn_insert_country.Text = "Add country"
        Me.btn_insert_country.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_insert_country.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(218, 67)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(202, 22)
        Me.txtName.TabIndex = 4
        '
        'lst_Countries
        '
        Me.lst_Countries.FormattingEnabled = True
        Me.lst_Countries.ItemHeight = 16
        Me.lst_Countries.Location = New System.Drawing.Point(15, 54)
        Me.lst_Countries.Name = "lst_Countries"
        Me.lst_Countries.Size = New System.Drawing.Size(175, 164)
        Me.lst_Countries.TabIndex = 5
        '
        'btn_update_country
        '
        Me.btn_update_country.Enabled = False
        Me.btn_update_country.Image = Global.SetList.My.Resources.Resources.update__1_
        Me.btn_update_country.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_update_country.Location = New System.Drawing.Point(130, 224)
        Me.btn_update_country.Name = "btn_update_country"
        Me.btn_update_country.Size = New System.Drawing.Size(125, 51)
        Me.btn_update_country.TabIndex = 6
        Me.btn_update_country.Text = "Update Country"
        Me.btn_update_country.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_update_country.UseVisualStyleBackColor = True
        '
        'btn_delete_country
        '
        Me.btn_delete_country.Enabled = False
        Me.btn_delete_country.Image = Global.SetList.My.Resources.Resources.delete__1_
        Me.btn_delete_country.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_delete_country.Location = New System.Drawing.Point(261, 224)
        Me.btn_delete_country.Name = "btn_delete_country"
        Me.btn_delete_country.Size = New System.Drawing.Size(132, 51)
        Me.btn_delete_country.TabIndex = 7
        Me.btn_delete_country.Text = "Delete Country"
        Me.btn_delete_country.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_delete_country.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(67, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 32)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Country"
        '
        'lst_artits
        '
        Me.lst_artits.FormattingEnabled = True
        Me.lst_artits.ItemHeight = 16
        Me.lst_artits.Location = New System.Drawing.Point(18, 56)
        Me.lst_artits.Name = "lst_artits"
        Me.lst_artits.Size = New System.Drawing.Size(175, 148)
        Me.lst_artits.TabIndex = 9
        '
        'txt_artistName
        '
        Me.txt_artistName.Location = New System.Drawing.Point(218, 83)
        Me.txt_artistName.Name = "txt_artistName"
        Me.txt_artistName.Size = New System.Drawing.Size(211, 22)
        Me.txt_artistName.TabIndex = 10
        '
        'btn_insertArtist
        '
        Me.btn_insertArtist.Enabled = False
        Me.btn_insertArtist.Image = Global.SetList.My.Resources.Resources.plus__1_
        Me.btn_insertArtist.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_insertArtist.Location = New System.Drawing.Point(18, 236)
        Me.btn_insertArtist.Name = "btn_insertArtist"
        Me.btn_insertArtist.Size = New System.Drawing.Size(106, 49)
        Me.btn_insertArtist.TabIndex = 12
        Me.btn_insertArtist.Text = "Insert artist"
        Me.btn_insertArtist.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_insertArtist.UseVisualStyleBackColor = True
        '
        'btn_updateArtist
        '
        Me.btn_updateArtist.Enabled = False
        Me.btn_updateArtist.Image = Global.SetList.My.Resources.Resources.update__1_
        Me.btn_updateArtist.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_updateArtist.Location = New System.Drawing.Point(130, 236)
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
        Me.btn_deleteArtist.Image = Global.SetList.My.Resources.Resources.delete__1_
        Me.btn_deleteArtist.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_deleteArtist.Location = New System.Drawing.Point(261, 236)
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
        Me.Label3.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(91, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 32)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Artists"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(217, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 32)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(217, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 32)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Name"
        '
        'txt_artistCountry
        '
        Me.txt_artistCountry.Location = New System.Drawing.Point(218, 174)
        Me.txt_artistCountry.Name = "txt_artistCountry"
        Me.txt_artistCountry.Size = New System.Drawing.Size(211, 22)
        Me.txt_artistCountry.TabIndex = 19
        '
        'lst_venues
        '
        Me.lst_venues.FormattingEnabled = True
        Me.lst_venues.ItemHeight = 16
        Me.lst_venues.Location = New System.Drawing.Point(18, 50)
        Me.lst_venues.Name = "lst_venues"
        Me.lst_venues.Size = New System.Drawing.Size(175, 164)
        Me.lst_venues.TabIndex = 20
        '
        'txt_venueName
        '
        Me.txt_venueName.Location = New System.Drawing.Point(218, 67)
        Me.txt_venueName.Name = "txt_venueName"
        Me.txt_venueName.Size = New System.Drawing.Size(211, 22)
        Me.txt_venueName.TabIndex = 21
        '
        'txt_venueCountry
        '
        Me.txt_venueCountry.Location = New System.Drawing.Point(218, 129)
        Me.txt_venueCountry.Name = "txt_venueCountry"
        Me.txt_venueCountry.Size = New System.Drawing.Size(211, 22)
        Me.txt_venueCountry.TabIndex = 22
        '
        'btn_insertVenue
        '
        Me.btn_insertVenue.Enabled = False
        Me.btn_insertVenue.Image = Global.SetList.My.Resources.Resources.plus__1_
        Me.btn_insertVenue.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_insertVenue.Location = New System.Drawing.Point(18, 236)
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
        Me.PictureBox1.Image = Global.SetList.My.Resources.Resources.setlist
        Me.PictureBox1.Location = New System.Drawing.Point(599, 12)
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
        Me.Panel1.Location = New System.Drawing.Point(570, 138)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(522, 294)
        Me.Panel1.TabIndex = 26
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = Global.SetList.My.Resources.Resources.puntero_del_mapa
        Me.PictureBox4.Location = New System.Drawing.Point(28, 6)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(39, 38)
        Me.PictureBox4.TabIndex = 28
        Me.PictureBox4.TabStop = False
        '
        'cmb_venuesType
        '
        Me.cmb_venuesType.FormattingEnabled = True
        Me.cmb_venuesType.Items.AddRange(New Object() {"HALL", "PAVILION", "STADIUM", "FESTIVAL"})
        Me.cmb_venuesType.Location = New System.Drawing.Point(218, 196)
        Me.cmb_venuesType.Name = "cmb_venuesType"
        Me.cmb_venuesType.Size = New System.Drawing.Size(211, 24)
        Me.cmb_venuesType.TabIndex = 29
        '
        'btn_updateVenue
        '
        Me.btn_updateVenue.Image = Global.SetList.My.Resources.Resources.update__1_
        Me.btn_updateVenue.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_updateVenue.Location = New System.Drawing.Point(133, 236)
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
        Me.btn_deleteVenue.Image = Global.SetList.My.Resources.Resources.delete__1_
        Me.btn_deleteVenue.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_deleteVenue.Location = New System.Drawing.Point(250, 236)
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
        Me.Label9.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(212, 161)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 32)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Type"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(212, 96)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(123, 32)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Country"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(212, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 32)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(81, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 32)
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
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(522, 294)
        Me.Panel2.TabIndex = 27
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.SetList.My.Resources.Resources.countries
        Me.PictureBox2.Location = New System.Drawing.Point(30, 14)
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
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(522, 294)
        Me.Panel3.TabIndex = 27
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.SetList.My.Resources.Resources.cantante
        Me.PictureBox3.Location = New System.Drawing.Point(30, 19)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(40, 31)
        Me.PictureBox3.TabIndex = 28
        Me.PictureBox3.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(222, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 32)
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
        Me.Panel4.Location = New System.Drawing.Point(570, 464)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(522, 294)
        Me.Panel4.TabIndex = 30
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Image = Global.SetList.My.Resources.Resources.puntero_del_mapa
        Me.PictureBox5.Location = New System.Drawing.Point(28, 6)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(39, 38)
        Me.PictureBox5.TabIndex = 28
        Me.PictureBox5.TabStop = False
        '
        'btn_updateAlbum
        '
        Me.btn_updateAlbum.Image = Global.SetList.My.Resources.Resources.update__1_
        Me.btn_updateAlbum.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_updateAlbum.Location = New System.Drawing.Point(133, 236)
        Me.btn_updateAlbum.Name = "btn_updateAlbum"
        Me.btn_updateAlbum.Size = New System.Drawing.Size(111, 44)
        Me.btn_updateAlbum.TabIndex = 28
        Me.btn_updateAlbum.Text = "Update Album"
        Me.btn_updateAlbum.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_updateAlbum.UseVisualStyleBackColor = True
        '
        'btn_deleteAlbum
        '
        Me.btn_deleteAlbum.Enabled = False
        Me.btn_deleteAlbum.Image = Global.SetList.My.Resources.Resources.delete__1_
        Me.btn_deleteAlbum.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_deleteAlbum.Location = New System.Drawing.Point(250, 236)
        Me.btn_deleteAlbum.Name = "btn_deleteAlbum"
        Me.btn_deleteAlbum.Size = New System.Drawing.Size(120, 44)
        Me.btn_deleteAlbum.TabIndex = 26
        Me.btn_deleteAlbum.Text = "Delete Album"
        Me.btn_deleteAlbum.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_deleteAlbum.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Location = New System.Drawing.Point(212, 161)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 32)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Artist"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label11.Location = New System.Drawing.Point(212, 96)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(216, 32)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Year of Launch"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label12.Location = New System.Drawing.Point(212, 32)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(188, 32)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Album Name"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label13.Location = New System.Drawing.Point(81, 10)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(114, 32)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "Albums"
        '
        'lst_albums
        '
        Me.lst_albums.FormattingEnabled = True
        Me.lst_albums.ItemHeight = 16
        Me.lst_albums.Location = New System.Drawing.Point(18, 50)
        Me.lst_albums.Name = "lst_albums"
        Me.lst_albums.Size = New System.Drawing.Size(175, 164)
        Me.lst_albums.TabIndex = 20
        '
        'txt_albumName
        '
        Me.txt_albumName.Location = New System.Drawing.Point(218, 67)
        Me.txt_albumName.Name = "txt_albumName"
        Me.txt_albumName.Size = New System.Drawing.Size(211, 22)
        Me.txt_albumName.TabIndex = 21
        '
        'btn_insertAlbum
        '
        Me.btn_insertAlbum.Enabled = False
        Me.btn_insertAlbum.Image = Global.SetList.My.Resources.Resources.plus__1_
        Me.btn_insertAlbum.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_insertAlbum.Location = New System.Drawing.Point(18, 236)
        Me.btn_insertAlbum.Name = "btn_insertAlbum"
        Me.btn_insertAlbum.Size = New System.Drawing.Size(109, 44)
        Me.btn_insertAlbum.TabIndex = 24
        Me.btn_insertAlbum.Text = "Insertar Album"
        Me.btn_insertAlbum.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_insertAlbum.UseVisualStyleBackColor = True
        '
        'txt_albumYear
        '
        Me.txt_albumYear.Location = New System.Drawing.Point(218, 129)
        Me.txt_albumYear.Name = "txt_albumYear"
        Me.txt_albumYear.Size = New System.Drawing.Size(211, 22)
        Me.txt_albumYear.TabIndex = 22
        '
        'txt_albumArtist
        '
        Me.txt_albumArtist.Location = New System.Drawing.Point(217, 196)
        Me.txt_albumArtist.Name = "txt_albumArtist"
        Me.txt_albumArtist.Size = New System.Drawing.Size(211, 22)
        Me.txt_albumArtist.TabIndex = 29
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1782, 953)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_connection)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
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
End Class
