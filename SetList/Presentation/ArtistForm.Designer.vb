﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ArtistForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ArtistForm))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lst_Countries = New System.Windows.Forms.ListBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lst_artists = New System.Windows.Forms.ListBox()
        Me.btn_insertArtist = New System.Windows.Forms.Button()
        Me.btn_updateArtist = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_deleteArtist = New System.Windows.Forms.Button()
        Me.txt_artistName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Silver
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.lst_Countries)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.lst_artists)
        Me.Panel3.Controls.Add(Me.btn_insertArtist)
        Me.Panel3.Controls.Add(Me.btn_updateArtist)
        Me.Panel3.Controls.Add(Me.btn_deleteArtist)
        Me.Panel3.Controls.Add(Me.txt_artistName)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Location = New System.Drawing.Point(108, 66)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(568, 354)
        Me.Panel3.TabIndex = 28
        '
        'lst_Countries
        '
        Me.lst_Countries.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_Countries.FormattingEnabled = True
        Me.lst_Countries.ItemHeight = 25
        Me.lst_Countries.Location = New System.Drawing.Point(200, 136)
        Me.lst_Countries.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lst_Countries.Name = "lst_Countries"
        Me.lst_Countries.Size = New System.Drawing.Size(175, 179)
        Me.lst_Countries.TabIndex = 29
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(309, 19)
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
        Me.Label4.Location = New System.Drawing.Point(195, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 29)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Country"
        '
        'lst_artists
        '
        Me.lst_artists.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_artists.FormattingEnabled = True
        Me.lst_artists.ItemHeight = 25
        Me.lst_artists.Location = New System.Drawing.Point(19, 25)
        Me.lst_artists.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lst_artists.Name = "lst_artists"
        Me.lst_artists.Size = New System.Drawing.Size(150, 304)
        Me.lst_artists.TabIndex = 9
        '
        'btn_insertArtist
        '
        Me.btn_insertArtist.Enabled = False
        Me.btn_insertArtist.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_insertArtist.Image = CType(resources.GetObject("btn_insertArtist.Image"), System.Drawing.Image)
        Me.btn_insertArtist.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_insertArtist.Location = New System.Drawing.Point(418, 25)
        Me.btn_insertArtist.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_insertArtist.Name = "btn_insertArtist"
        Me.btn_insertArtist.Size = New System.Drawing.Size(90, 55)
        Me.btn_insertArtist.TabIndex = 12
        Me.btn_insertArtist.Text = "ADD"
        Me.btn_insertArtist.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_insertArtist.UseVisualStyleBackColor = True
        '
        'btn_updateArtist
        '
        Me.btn_updateArtist.Enabled = False
        Me.btn_updateArtist.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_updateArtist.Image = CType(resources.GetObject("btn_updateArtist.Image"), System.Drawing.Image)
        Me.btn_updateArtist.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_updateArtist.Location = New System.Drawing.Point(418, 104)
        Me.btn_updateArtist.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_updateArtist.Name = "btn_updateArtist"
        Me.btn_updateArtist.Size = New System.Drawing.Size(90, 55)
        Me.btn_updateArtist.TabIndex = 13
        Me.btn_updateArtist.Text = "UPDATE"
        Me.btn_updateArtist.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_updateArtist.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(357, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 41)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Artists"
        '
        'btn_deleteArtist
        '
        Me.btn_deleteArtist.Enabled = False
        Me.btn_deleteArtist.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_deleteArtist.Image = CType(resources.GetObject("btn_deleteArtist.Image"), System.Drawing.Image)
        Me.btn_deleteArtist.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_deleteArtist.Location = New System.Drawing.Point(418, 197)
        Me.btn_deleteArtist.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_deleteArtist.Name = "btn_deleteArtist"
        Me.btn_deleteArtist.Size = New System.Drawing.Size(90, 55)
        Me.btn_deleteArtist.TabIndex = 14
        Me.btn_deleteArtist.Text = "DELETE"
        Me.btn_deleteArtist.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_deleteArtist.UseVisualStyleBackColor = True
        '
        'txt_artistName
        '
        Me.txt_artistName.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_artistName.Location = New System.Drawing.Point(200, 62)
        Me.txt_artistName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_artistName.Name = "txt_artistName"
        Me.txt_artistName.Size = New System.Drawing.Size(175, 32)
        Me.txt_artistName.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(195, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 29)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Name"
        '
        'ArtistForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SetList.My.Resources.Resources.Five_Simple_Editing_Tips_That_Will_Make_Your_Photos_Stand_Out
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ArtistForm"
        Me.Text = "Artist"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lst_artists As ListBox
    Friend WithEvents btn_insertArtist As Button
    Friend WithEvents btn_updateArtist As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_deleteArtist As Button
    Friend WithEvents txt_artistName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lst_Countries As ListBox
End Class
