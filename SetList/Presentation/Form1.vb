Imports System.Windows
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class Form1
    Private country As Country
    Private artist As Artist

    Public countries As Collection

    Private Sub btn_connection_Click(sender As Object, e As EventArgs) Handles btn_connection.Click
        Dim cAux As Country
        Me.country = New Country

        Try
            Me.country.ReadAllCountries()

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
        For Each cAux In Me.country.counDAO.Countries
            Me.lst_Countries.Items.Add(cAux.idCountry)
        Next
        btn_insert_country.Enabled = True
        btn_delete_country.Enabled = True
        btn_update_country.Enabled = True
    End Sub


    Private Sub lst_Countries_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_Countries.SelectedIndexChanged
        btn_delete_country.Enabled = True
        btn_update_country.Enabled = True
        If lst_Countries.SelectedItem IsNot Nothing Then
            Try
                Me.country = New Country
                country.idCountry = lst_Countries.SelectedItem.ToString
                country.ReadCountry()
                txtID.Text = country.idCountry
                txtName.Text = country.countryName
            Catch ex As Exception
                lst_Countries.SelectedIndex = -1
            End Try
        End If
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
            lst_Countries.Items.Add(countryNew.idCountry)
        Else
            MessageBox.Show("Id and Name were empty, please fill those spaces", "Custom Error", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub btn_update_country_Click(sender As Object, e As EventArgs) Handles btn_update_country.Click
        Me.country = New Country
        country.idCountry = lst_Countries.SelectedItem.ToString
        country.ReadCountry()
        If country.countryName = txtName.Text Then
            MessageBox.Show("You're not changing a thing", "Custom Error", MessageBoxButtons.OK)
        Else
            country.countryName = txtName.Text
        End If
        country.UpdateCountry()
        MessageBox.Show("UPDATE!!! Stop clicking, please", "Custom Error", MessageBoxButtons.OK)
    End Sub


    Private Sub btn_delete_country_Click(sender As Object, e As EventArgs) Handles btn_delete_country.Click

        If MessageBox.Show("Are you sure? Do you want to delete permanetly this country?", "Custom Error", MessageBoxButtons.YesNo) = DialogResult.No Then
            Exit Sub
        End If
        If txtID.Text <> String.Empty And txtName.Text <> String.Empty Then
            Me.country = New Country
            country.idCountry = txtID.Text
            country.countryName = txtName.Text
            country.ReadCountry()
            If country.countryName <> txtName.Text.Trim() Then
                MessageBox.Show("This is not the same name", "Custom Error", MessageBoxButtons.OK)
                Exit Sub
            End If
            Try
                If country.DeleteCountry() <> 1 Then
                    MessageBox.Show("INSERT <> -1", "Custom Error", MessageBoxButtons.OK)
                End If
            Catch ex As Exception
                MessageBox.Show("Country deleted", ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
            Me.lst_Countries.Items.Remove(country.idCountry)


        Else
            MessageBox.Show("Unable to delete information, all needed fields must be filled", "Custom Error", MessageBoxButtons.OK)
        End If
    End Sub


End Class
