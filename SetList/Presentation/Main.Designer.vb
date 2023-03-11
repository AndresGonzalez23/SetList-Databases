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
        Me.txt_album_name = New System.Windows.Forms.TextBox()
        Me.txt_country = New System.Windows.Forms.TextBox()
        Me.lst_setlist = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lst_concert
        '
        Me.lst_concert.FormattingEnabled = True
        Me.lst_concert.Location = New System.Drawing.Point(39, 32)
        Me.lst_concert.Name = "lst_concert"
        Me.lst_concert.Size = New System.Drawing.Size(476, 563)
        Me.lst_concert.TabIndex = 0
        '
        'txt_concert_name
        '
        Me.txt_concert_name.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_concert_name.Location = New System.Drawing.Point(603, 60)
        Me.txt_concert_name.Name = "txt_concert_name"
        Me.txt_concert_name.Size = New System.Drawing.Size(300, 33)
        Me.txt_concert_name.TabIndex = 1
        '
        'txt_artist_name
        '
        Me.txt_artist_name.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_artist_name.Location = New System.Drawing.Point(603, 150)
        Me.txt_artist_name.Name = "txt_artist_name"
        Me.txt_artist_name.Size = New System.Drawing.Size(300, 33)
        Me.txt_artist_name.TabIndex = 2
        '
        'txt_venues
        '
        Me.txt_venues.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_venues.Location = New System.Drawing.Point(603, 247)
        Me.txt_venues.Name = "txt_venues"
        Me.txt_venues.Size = New System.Drawing.Size(142, 33)
        Me.txt_venues.TabIndex = 3
        '
        'txt_album_name
        '
        Me.txt_album_name.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_album_name.Location = New System.Drawing.Point(605, 329)
        Me.txt_album_name.Name = "txt_album_name"
        Me.txt_album_name.Size = New System.Drawing.Size(300, 33)
        Me.txt_album_name.TabIndex = 4
        '
        'txt_country
        '
        Me.txt_country.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_country.Location = New System.Drawing.Point(761, 247)
        Me.txt_country.Name = "txt_country"
        Me.txt_country.Size = New System.Drawing.Size(142, 33)
        Me.txt_country.TabIndex = 5
        '
        'lst_setlist
        '
        Me.lst_setlist.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_setlist.FormattingEnabled = True
        Me.lst_setlist.ItemHeight = 25
        Me.lst_setlist.Location = New System.Drawing.Point(603, 416)
        Me.lst_setlist.Name = "lst_setlist"
        Me.lst_setlist.Size = New System.Drawing.Size(300, 179)
        Me.lst_setlist.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(38, 613)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(134, 50)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(215, 613)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(134, 50)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(395, 613)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(134, 50)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(569, 613)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(134, 50)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(769, 613)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(134, 50)
        Me.Button5.TabIndex = 11
        Me.Button5.Text = "Button5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(600, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 25)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "zdrgzyhz"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(764, 205)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 25)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "zdrgzyhz"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(600, 205)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 25)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "zdrgzyhz"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(600, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 25)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "zdrgzyhz"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(600, 301)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 25)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "zdrgzyhz"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(600, 377)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 25)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "zdrgzyhz"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SetList.My.Resources.Resources.Five_Simple_Editing_Tips_That_Will_Make_Your_Photos_Stand_Out
        Me.ClientSize = New System.Drawing.Size(1023, 680)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lst_setlist)
        Me.Controls.Add(Me.txt_country)
        Me.Controls.Add(Me.txt_album_name)
        Me.Controls.Add(Me.txt_venues)
        Me.Controls.Add(Me.txt_artist_name)
        Me.Controls.Add(Me.txt_concert_name)
        Me.Controls.Add(Me.lst_concert)
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
    Friend WithEvents txt_album_name As TextBox
    Friend WithEvents txt_country As TextBox
    Friend WithEvents lst_setlist As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
