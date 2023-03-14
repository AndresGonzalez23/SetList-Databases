<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.lst_concert = New System.Windows.Forms.ListBox()
        Me.txt_concert_name = New System.Windows.Forms.TextBox()
        Me.txt_artist_name = New System.Windows.Forms.TextBox()
        Me.txt_venues = New System.Windows.Forms.TextBox()
        Me.txt_venue = New System.Windows.Forms.TextBox()
        Me.txt_country = New System.Windows.Forms.TextBox()
        Me.lst_setlist = New System.Windows.Forms.ListBox()
        Me.btn_insert_concert = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_album = New System.Windows.Forms.TextBox()
        Me.btn_update_concert = New System.Windows.Forms.Button()
        Me.btn_delete_concert = New System.Windows.Forms.Button()
        Me.btn_clear_concert = New System.Windows.Forms.Button()
        Me.btn_more_information = New System.Windows.Forms.Button()
        Me.btn_app_statistics = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lst_concert
        '
        Me.lst_concert.FormattingEnabled = True
        Me.lst_concert.ItemHeight = 16
        Me.lst_concert.Location = New System.Drawing.Point(52, 39)
        Me.lst_concert.Margin = New System.Windows.Forms.Padding(4)
        Me.lst_concert.Name = "lst_concert"
        Me.lst_concert.Size = New System.Drawing.Size(470, 692)
        Me.lst_concert.TabIndex = 0
        '
        'txt_concert_name
        '
        Me.txt_concert_name.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_concert_name.Location = New System.Drawing.Point(637, 71)
        Me.txt_concert_name.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_concert_name.Name = "txt_concert_name"
        Me.txt_concert_name.Size = New System.Drawing.Size(399, 39)
        Me.txt_concert_name.TabIndex = 1
        '
        'txt_artist_name
        '
        Me.txt_artist_name.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_artist_name.Location = New System.Drawing.Point(637, 158)
        Me.txt_artist_name.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_artist_name.Name = "txt_artist_name"
        Me.txt_artist_name.Size = New System.Drawing.Size(399, 39)
        Me.txt_artist_name.TabIndex = 2
        '
        'txt_venues
        '
        Me.txt_venues.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_venues.Location = New System.Drawing.Point(637, 261)
        Me.txt_venues.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_venues.Name = "txt_venues"
        Me.txt_venues.Size = New System.Drawing.Size(169, 39)
        Me.txt_venues.TabIndex = 3
        '
        'txt_venue
        '
        Me.txt_venue.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_venue.Location = New System.Drawing.Point(637, 351)
        Me.txt_venue.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_venue.Name = "txt_venue"
        Me.txt_venue.Size = New System.Drawing.Size(399, 39)
        Me.txt_venue.TabIndex = 4
        '
        'txt_country
        '
        Me.txt_country.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_country.Location = New System.Drawing.Point(839, 261)
        Me.txt_country.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_country.Name = "txt_country"
        Me.txt_country.Size = New System.Drawing.Size(188, 39)
        Me.txt_country.TabIndex = 5
        '
        'lst_setlist
        '
        Me.lst_setlist.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_setlist.FormattingEnabled = True
        Me.lst_setlist.ItemHeight = 32
        Me.lst_setlist.Location = New System.Drawing.Point(637, 520)
        Me.lst_setlist.Margin = New System.Windows.Forms.Padding(4)
        Me.lst_setlist.Name = "lst_setlist"
        Me.lst_setlist.Size = New System.Drawing.Size(399, 196)
        Me.lst_setlist.TabIndex = 6
        '
        'btn_insert_concert
        '
        Me.btn_insert_concert.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_insert_concert.Image = Global.SetList.My.Resources.Resources.etapa
        Me.btn_insert_concert.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_insert_concert.Location = New System.Drawing.Point(1120, 35)
        Me.btn_insert_concert.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_insert_concert.Name = "btn_insert_concert"
        Me.btn_insert_concert.Size = New System.Drawing.Size(179, 96)
        Me.btn_insert_concert.TabIndex = 7
        Me.btn_insert_concert.Text = "INSERT"
        Me.btn_insert_concert.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_insert_concert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_insert_concert.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(637, 35)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 32)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Concert name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(833, 213)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 32)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Country"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(633, 213)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 32)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(633, 122)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(173, 32)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Artist name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(637, 315)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 32)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Venue"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(636, 484)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 32)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Setlists"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(637, 406)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 32)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Album"
        '
        'txt_album
        '
        Me.txt_album.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_album.Location = New System.Drawing.Point(639, 442)
        Me.txt_album.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_album.Name = "txt_album"
        Me.txt_album.Size = New System.Drawing.Size(399, 39)
        Me.txt_album.TabIndex = 18
        '
        'btn_update_concert
        '
        Me.btn_update_concert.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update_concert.Location = New System.Drawing.Point(1120, 152)
        Me.btn_update_concert.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_update_concert.Name = "btn_update_concert"
        Me.btn_update_concert.Size = New System.Drawing.Size(179, 62)
        Me.btn_update_concert.TabIndex = 20
        Me.btn_update_concert.Text = "UPDATE"
        Me.btn_update_concert.UseVisualStyleBackColor = True
        '
        'btn_delete_concert
        '
        Me.btn_delete_concert.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete_concert.Image = Global.SetList.My.Resources.Resources.trash1
        Me.btn_delete_concert.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_delete_concert.Location = New System.Drawing.Point(1120, 255)
        Me.btn_delete_concert.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_delete_concert.Name = "btn_delete_concert"
        Me.btn_delete_concert.Size = New System.Drawing.Size(179, 62)
        Me.btn_delete_concert.TabIndex = 21
        Me.btn_delete_concert.Text = "DELETE"
        Me.btn_delete_concert.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_delete_concert.UseVisualStyleBackColor = True
        '
        'btn_clear_concert
        '
        Me.btn_clear_concert.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear_concert.Location = New System.Drawing.Point(1120, 351)
        Me.btn_clear_concert.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_clear_concert.Name = "btn_clear_concert"
        Me.btn_clear_concert.Size = New System.Drawing.Size(179, 62)
        Me.btn_clear_concert.TabIndex = 22
        Me.btn_clear_concert.Text = "CLEAR"
        Me.btn_clear_concert.UseVisualStyleBackColor = True
        '
        'btn_more_information
        '
        Me.btn_more_information.Location = New System.Drawing.Point(1120, 520)
        Me.btn_more_information.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_more_information.Name = "btn_more_information"
        Me.btn_more_information.Size = New System.Drawing.Size(179, 62)
        Me.btn_more_information.TabIndex = 23
        Me.btn_more_information.Text = "Button5"
        Me.btn_more_information.UseVisualStyleBackColor = True
        '
        'btn_app_statistics
        '
        Me.btn_app_statistics.Location = New System.Drawing.Point(1120, 644)
        Me.btn_app_statistics.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_app_statistics.Name = "btn_app_statistics"
        Me.btn_app_statistics.Size = New System.Drawing.Size(179, 62)
        Me.btn_app_statistics.TabIndex = 24
        Me.btn_app_statistics.Text = "Button6"
        Me.btn_app_statistics.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SetList.My.Resources.Resources.Five_Simple_Editing_Tips_That_Will_Make_Your_Photos_Stand_Out
        Me.ClientSize = New System.Drawing.Size(1364, 837)
        Me.Controls.Add(Me.btn_app_statistics)
        Me.Controls.Add(Me.btn_more_information)
        Me.Controls.Add(Me.btn_clear_concert)
        Me.Controls.Add(Me.btn_delete_concert)
        Me.Controls.Add(Me.btn_update_concert)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_album)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_insert_concert)
        Me.Controls.Add(Me.lst_setlist)
        Me.Controls.Add(Me.txt_country)
        Me.Controls.Add(Me.txt_venue)
        Me.Controls.Add(Me.txt_venues)
        Me.Controls.Add(Me.txt_artist_name)
        Me.Controls.Add(Me.txt_concert_name)
        Me.Controls.Add(Me.lst_concert)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Main"
        Me.Text = "Main"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lst_concert As ListBox
    Friend WithEvents txt_concert_name As TextBox
    Friend WithEvents txt_artist_name As TextBox
    Friend WithEvents txt_venues As TextBox
    Friend WithEvents txt_venue As TextBox
    Friend WithEvents txt_country As TextBox
    Friend WithEvents lst_setlist As ListBox
    Friend WithEvents btn_insert_concert As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_album As TextBox
    Friend WithEvents btn_update_concert As Button
    Friend WithEvents btn_delete_concert As Button
    Friend WithEvents btn_clear_concert As Button
    Friend WithEvents btn_more_information As Button
    Friend WithEvents btn_app_statistics As Button
End Class
