﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.txt_venueType = New System.Windows.Forms.TextBox()
        Me.btn_insertVenue = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_connection
        '
        Me.btn_connection.BackColor = System.Drawing.Color.Transparent
        Me.btn_connection.FlatAppearance.BorderSize = 0
        Me.btn_connection.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_connection.ForeColor = System.Drawing.Color.Transparent
        Me.btn_connection.Image = CType(resources.GetObject("btn_connection.Image"), System.Drawing.Image)
        Me.btn_connection.Location = New System.Drawing.Point(18, 870)
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
        Me.btn_insert_country.Location = New System.Drawing.Point(15, 240)
        Me.btn_insert_country.Name = "btn_insert_country"
        Me.btn_insert_country.Size = New System.Drawing.Size(108, 35)
        Me.btn_insert_country.TabIndex = 3
        Me.btn_insert_country.Text = "Insert Country"
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
        Me.btn_update_country.Location = New System.Drawing.Point(141, 240)
        Me.btn_update_country.Name = "btn_update_country"
        Me.btn_update_country.Size = New System.Drawing.Size(117, 35)
        Me.btn_update_country.TabIndex = 6
        Me.btn_update_country.Text = "Update Country"
        Me.btn_update_country.UseVisualStyleBackColor = True
        '
        'btn_delete_country
        '
        Me.btn_delete_country.Enabled = False
        Me.btn_delete_country.Location = New System.Drawing.Point(264, 240)
        Me.btn_delete_country.Name = "btn_delete_country"
        Me.btn_delete_country.Size = New System.Drawing.Size(108, 35)
        Me.btn_delete_country.TabIndex = 7
        Me.btn_delete_country.Text = "Delete Country"
        Me.btn_delete_country.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(67, 19)
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
        Me.btn_insertArtist.Location = New System.Drawing.Point(18, 242)
        Me.btn_insertArtist.Name = "btn_insertArtist"
        Me.btn_insertArtist.Size = New System.Drawing.Size(95, 43)
        Me.btn_insertArtist.TabIndex = 12
        Me.btn_insertArtist.Text = "Insert artist"
        Me.btn_insertArtist.UseVisualStyleBackColor = True
        '
        'btn_updateArtist
        '
        Me.btn_updateArtist.Enabled = False
        Me.btn_updateArtist.Location = New System.Drawing.Point(138, 242)
        Me.btn_updateArtist.Name = "btn_updateArtist"
        Me.btn_updateArtist.Size = New System.Drawing.Size(95, 43)
        Me.btn_updateArtist.TabIndex = 13
        Me.btn_updateArtist.Text = "Update Artist"
        Me.btn_updateArtist.UseVisualStyleBackColor = True
        '
        'btn_deleteArtist
        '
        Me.btn_deleteArtist.Enabled = False
        Me.btn_deleteArtist.Location = New System.Drawing.Point(239, 242)
        Me.btn_deleteArtist.Name = "btn_deleteArtist"
        Me.btn_deleteArtist.Size = New System.Drawing.Size(95, 43)
        Me.btn_deleteArtist.TabIndex = 14
        Me.btn_deleteArtist.Text = "Delete Artist"
        Me.btn_deleteArtist.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(91, 21)
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
        'txt_venueType
        '
        Me.txt_venueType.Location = New System.Drawing.Point(218, 196)
        Me.txt_venueType.Name = "txt_venueType"
        Me.txt_venueType.Size = New System.Drawing.Size(211, 22)
        Me.txt_venueType.TabIndex = 23
        '
        'btn_insertVenue
        '
        Me.btn_insertVenue.Enabled = False
        Me.btn_insertVenue.Location = New System.Drawing.Point(18, 236)
        Me.btn_insertVenue.Name = "btn_insertVenue"
        Me.btn_insertVenue.Size = New System.Drawing.Size(109, 44)
        Me.btn_insertVenue.TabIndex = 24
        Me.btn_insertVenue.Text = "Insertar venue" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btn_insertVenue.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.SetList.My.Resources.Resources.setlist
        Me.PictureBox1.Location = New System.Drawing.Point(596, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(263, 95)
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lst_venues)
        Me.Panel1.Controls.Add(Me.txt_venueName)
        Me.Panel1.Controls.Add(Me.btn_insertVenue)
        Me.Panel1.Controls.Add(Me.txt_venueCountry)
        Me.Panel1.Controls.Add(Me.txt_venueType)
        Me.Panel1.Location = New System.Drawing.Point(526, 138)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(461, 294)
        Me.Panel1.TabIndex = 26
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
        Me.Label1.Location = New System.Drawing.Point(81, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 32)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Venues"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gray
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lst_Countries)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.txtName)
        Me.Panel2.Controls.Add(Me.btn_insert_country)
        Me.Panel2.Controls.Add(Me.btn_update_country)
        Me.Panel2.Controls.Add(Me.btn_delete_country)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(25, 138)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(461, 294)
        Me.Panel2.TabIndex = 27
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Gray
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
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
        Me.Panel3.Size = New System.Drawing.Size(461, 294)
        Me.Panel3.TabIndex = 27
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1698, 932)
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
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
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
    Friend WithEvents txt_venueType As TextBox
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
End Class
