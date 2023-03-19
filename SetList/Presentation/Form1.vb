Imports System.Windows
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class Form1
    Private c As Country

    Public countries As Collection

    Private Sub btn_connection_Click(sender As Object, e As EventArgs) Handles btn_connection.Click
        Dim cAux As Country
        Me.c = New Country

        Try
            Me.c.ReadAllCountries()

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
        For Each cAux In Me.c.counDAO.Countries
            Me.lst_Countries.Items.Add(cAux.countryName)
        Next
        btn_insert_country.Enabled = True
        btn_delete_country.Enabled = True
        btn_update_country.Enabled = True

    End Sub

    Private Sub btn_insert_country_Click(sender As Object, e As EventArgs) Handles btn_insert_country.Click
        Dim countryNew As New Country
        If txtID.Text <> String.Empty And txtName.Text <> String.Empty Then
            countryNew = New Country
            countryNew.idCountry = txtID.Text
            countryNew.countryName = txtName.Text
            Try
                If countryNew.InsertCountry() <> 1 Then
                    MessageBox.Show("INSERT <> -1", "CUSTOM ERROR", MessageBoxButtons.OK)
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
            lst_Countries.Items.Add(countryNew.countryName)
        Else
            MessageBox.Show("Id and Name were empty, please fill those spaces", "Custom Error", MessageBoxButtons.OK)
        End If

    End Sub

    Private Sub btn_update_country_Click(sender As Object, e As EventArgs) Handles btn_update_country.Click

    End Sub

    Private Sub btn_delete_country_Click(sender As Object, e As EventArgs) Handles btn_delete_country.Click

    End Sub
End Class
