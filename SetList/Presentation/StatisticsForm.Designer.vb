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
        'StatisticsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SetList.My.Resources.Resources.Five_Simple_Editing_Tips_That_Will_Make_Your_Photos_Stand_Out
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1382, 753)
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
End Class
