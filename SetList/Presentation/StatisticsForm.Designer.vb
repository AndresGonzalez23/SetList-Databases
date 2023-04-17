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
        Me.SuspendLayout()
        '
        'lst_artists
        '
        Me.lst_artists.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_artists.FormattingEnabled = True
        Me.lst_artists.ItemHeight = 20
        Me.lst_artists.Location = New System.Drawing.Point(22, 11)
        Me.lst_artists.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lst_artists.Name = "lst_artists"
        Me.lst_artists.Size = New System.Drawing.Size(150, 124)
        Me.lst_artists.TabIndex = 10
        '
        'lst_moreSinged
        '
        Me.lst_moreSinged.FormattingEnabled = True
        Me.lst_moreSinged.ItemHeight = 16
        Me.lst_moreSinged.Location = New System.Drawing.Point(619, 11)
        Me.lst_moreSinged.Name = "lst_moreSinged"
        Me.lst_moreSinged.Size = New System.Drawing.Size(150, 132)
        Me.lst_moreSinged.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(215, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(346, 40)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Songs performed the most times by an artist " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "throughout all his/her concerts"
        '
        'btn_searchSql1
        '
        Me.btn_searchSql1.Location = New System.Drawing.Point(447, 82)
        Me.btn_searchSql1.Name = "btn_searchSql1"
        Me.btn_searchSql1.Size = New System.Drawing.Size(114, 41)
        Me.btn_searchSql1.TabIndex = 13
        Me.btn_searchSql1.Text = "Search"
        Me.btn_searchSql1.UseVisualStyleBackColor = True
        '
        'StatisticsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SetList.My.Resources.Resources.Five_Simple_Editing_Tips_That_Will_Make_Your_Photos_Stand_Out
        Me.ClientSize = New System.Drawing.Size(800, 450)
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
End Class
