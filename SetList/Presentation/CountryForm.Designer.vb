﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CountryForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CountryForm))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_clean = New System.Windows.Forms.Button()
        Me.lst_Countries = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btn_insert_country = New System.Windows.Forms.Button()
        Me.btn_update_country = New System.Windows.Forms.Button()
        Me.btn_delete_country = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btn_clean)
        Me.Panel2.Controls.Add(Me.lst_Countries)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.txtName)
        Me.Panel2.Controls.Add(Me.btn_insert_country)
        Me.Panel2.Controls.Add(Me.btn_update_country)
        Me.Panel2.Controls.Add(Me.btn_delete_country)
        Me.Panel2.Location = New System.Drawing.Point(108, 66)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(568, 354)
        Me.Panel2.TabIndex = 28
        '
        'btn_clean
        '
        Me.btn_clean.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clean.Image = Global.SetList.My.Resources.Resources.escoba__2_
        Me.btn_clean.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_clean.Location = New System.Drawing.Point(333, 193)
        Me.btn_clean.Name = "btn_clean"
        Me.btn_clean.Size = New System.Drawing.Size(92, 55)
        Me.btn_clean.TabIndex = 52
        Me.btn_clean.Text = "CLEAN"
        Me.btn_clean.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_clean.UseVisualStyleBackColor = True
        '
        'lst_Countries
        '
        Me.lst_Countries.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_Countries.FormattingEnabled = True
        Me.lst_Countries.ItemHeight = 20
        Me.lst_Countries.Location = New System.Drawing.Point(19, 18)
        Me.lst_Countries.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lst_Countries.Name = "lst_Countries"
        Me.lst_Countries.Size = New System.Drawing.Size(175, 304)
        Me.lst_Countries.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(217, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 29)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Name"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(219, 49)
        Me.txtName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(201, 32)
        Me.txtName.TabIndex = 4
        '
        'btn_insert_country
        '
        Me.btn_insert_country.Enabled = False
        Me.btn_insert_country.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_insert_country.Image = CType(resources.GetObject("btn_insert_country.Image"), System.Drawing.Image)
        Me.btn_insert_country.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_insert_country.Location = New System.Drawing.Point(219, 112)
        Me.btn_insert_country.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_insert_country.Name = "btn_insert_country"
        Me.btn_insert_country.Size = New System.Drawing.Size(92, 55)
        Me.btn_insert_country.TabIndex = 3
        Me.btn_insert_country.Text = "ADD"
        Me.btn_insert_country.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_insert_country.UseVisualStyleBackColor = True
        '
        'btn_update_country
        '
        Me.btn_update_country.Enabled = False
        Me.btn_update_country.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update_country.Image = CType(resources.GetObject("btn_update_country.Image"), System.Drawing.Image)
        Me.btn_update_country.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_update_country.Location = New System.Drawing.Point(333, 112)
        Me.btn_update_country.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_update_country.Name = "btn_update_country"
        Me.btn_update_country.Size = New System.Drawing.Size(92, 55)
        Me.btn_update_country.TabIndex = 6
        Me.btn_update_country.Text = "UPDATE"
        Me.btn_update_country.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_update_country.UseVisualStyleBackColor = True
        '
        'btn_delete_country
        '
        Me.btn_delete_country.Enabled = False
        Me.btn_delete_country.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete_country.Image = CType(resources.GetObject("btn_delete_country.Image"), System.Drawing.Image)
        Me.btn_delete_country.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_delete_country.Location = New System.Drawing.Point(222, 193)
        Me.btn_delete_country.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_delete_country.Name = "btn_delete_country"
        Me.btn_delete_country.Size = New System.Drawing.Size(92, 55)
        Me.btn_delete_country.TabIndex = 7
        Me.btn_delete_country.Text = "DELETE"
        Me.btn_delete_country.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_delete_country.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(305, 11)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(31, 33)
        Me.PictureBox2.TabIndex = 28
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(342, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 40)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Country"
        '
        'CountryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SetList.My.Resources.Resources.Five_Simple_Editing_Tips_That_Will_Make_Your_Photos_Stand_Out
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CountryForm"
        Me.Text = "Country"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lst_Countries As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents btn_insert_country As Button
    Friend WithEvents btn_update_country As Button
    Friend WithEvents btn_delete_country As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_clean As Button
End Class
