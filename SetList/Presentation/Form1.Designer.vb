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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_connection = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_artistCountry = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(291, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(726, 53)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "WELCOME TO OUR APLICATION"
        '
        'btn_connection
        '
        Me.btn_connection.BackColor = System.Drawing.Color.Transparent
        Me.btn_connection.FlatAppearance.BorderSize = 0
        Me.btn_connection.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_connection.ForeColor = System.Drawing.Color.Transparent
        Me.btn_connection.Image = CType(resources.GetObject("btn_connection.Image"), System.Drawing.Image)
        Me.btn_connection.Location = New System.Drawing.Point(19, 775)
        Me.btn_connection.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_connection.Name = "btn_connection"
        Me.btn_connection.Size = New System.Drawing.Size(443, 49)
        Me.btn_connection.TabIndex = 0
        Me.btn_connection.Text = "Connect to database"
        Me.btn_connection.UseVisualStyleBackColor = False
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(231, 165)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(231, 22)
        Me.txtID.TabIndex = 2
        '
        'btn_insert_country
        '
        Me.btn_insert_country.Enabled = False
        Me.btn_insert_country.Location = New System.Drawing.Point(19, 313)
        Me.btn_insert_country.Name = "btn_insert_country"
        Me.btn_insert_country.Size = New System.Drawing.Size(108, 35)
        Me.btn_insert_country.TabIndex = 3
        Me.btn_insert_country.Text = "Insert Country"
        Me.btn_insert_country.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(231, 240)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(231, 22)
        Me.txtName.TabIndex = 4
        '
        'lst_Countries
        '
        Me.lst_Countries.FormattingEnabled = True
        Me.lst_Countries.ItemHeight = 16
        Me.lst_Countries.Location = New System.Drawing.Point(19, 145)
        Me.lst_Countries.Name = "lst_Countries"
        Me.lst_Countries.Size = New System.Drawing.Size(191, 148)
        Me.lst_Countries.TabIndex = 5
        '
        'btn_update_country
        '
        Me.btn_update_country.Enabled = False
        Me.btn_update_country.Location = New System.Drawing.Point(345, 313)
        Me.btn_update_country.Name = "btn_update_country"
        Me.btn_update_country.Size = New System.Drawing.Size(117, 35)
        Me.btn_update_country.TabIndex = 6
        Me.btn_update_country.Text = "Update Country"
        Me.btn_update_country.UseVisualStyleBackColor = True
        '
        'btn_delete_country
        '
        Me.btn_delete_country.Enabled = False
        Me.btn_delete_country.Location = New System.Drawing.Point(186, 313)
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
        Me.Label2.Location = New System.Drawing.Point(14, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 32)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Country"
        '
        'lst_artits
        '
        Me.lst_artits.FormattingEnabled = True
        Me.lst_artits.ItemHeight = 16
        Me.lst_artits.Location = New System.Drawing.Point(19, 485)
        Me.lst_artits.Name = "lst_artits"
        Me.lst_artits.Size = New System.Drawing.Size(191, 148)
        Me.lst_artits.TabIndex = 9
        '
        'txt_artistName
        '
        Me.txt_artistName.Location = New System.Drawing.Point(231, 485)
        Me.txt_artistName.Name = "txt_artistName"
        Me.txt_artistName.Size = New System.Drawing.Size(231, 22)
        Me.txt_artistName.TabIndex = 10
        '
        'btn_insertArtist
        '
        Me.btn_insertArtist.Enabled = False
        Me.btn_insertArtist.Location = New System.Drawing.Point(19, 661)
        Me.btn_insertArtist.Name = "btn_insertArtist"
        Me.btn_insertArtist.Size = New System.Drawing.Size(95, 43)
        Me.btn_insertArtist.TabIndex = 12
        Me.btn_insertArtist.Text = "Insert artist"
        Me.btn_insertArtist.UseVisualStyleBackColor = True
        '
        'btn_updateArtist
        '
        Me.btn_updateArtist.Enabled = False
        Me.btn_updateArtist.Location = New System.Drawing.Point(186, 661)
        Me.btn_updateArtist.Name = "btn_updateArtist"
        Me.btn_updateArtist.Size = New System.Drawing.Size(95, 43)
        Me.btn_updateArtist.TabIndex = 13
        Me.btn_updateArtist.Text = "Update Artist"
        Me.btn_updateArtist.UseVisualStyleBackColor = True
        '
        'btn_deleteArtist
        '
        Me.btn_deleteArtist.Enabled = False
        Me.btn_deleteArtist.Location = New System.Drawing.Point(367, 661)
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
        Me.Label3.Location = New System.Drawing.Point(19, 435)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 32)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Artists"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(226, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 32)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Siglas"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(226, 207)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(208, 32)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Country name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(226, 450)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(173, 32)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Artist name"
        '
        'txt_artistCountry
        '
        Me.txt_artistCountry.Location = New System.Drawing.Point(231, 551)
        Me.txt_artistCountry.Name = "txt_artistCountry"
        Me.txt_artistCountry.Size = New System.Drawing.Size(230, 22)
        Me.txt_artistCountry.TabIndex = 19
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1364, 837)
        Me.Controls.Add(Me.txt_artistCountry)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_deleteArtist)
        Me.Controls.Add(Me.btn_updateArtist)
        Me.Controls.Add(Me.btn_insertArtist)
        Me.Controls.Add(Me.txt_artistName)
        Me.Controls.Add(Me.lst_artits)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_delete_country)
        Me.Controls.Add(Me.btn_update_country)
        Me.Controls.Add(Me.lst_Countries)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btn_insert_country)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_connection)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btn_connection As Button
    Friend WithEvents txtID As TextBox
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
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_artistCountry As TextBox
End Class
