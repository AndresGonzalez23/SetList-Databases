Imports System.Windows
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class Form1
    Private country As Country
    Private artist As Artist

    Public countries As Collection

    Private Sub btn_connection_Click(sender As Object, e As EventArgs) Handles btn_connection.Click
        Dim cAux As Country
        Dim aAux As Artist
        Me.country = New Country
        Me.artist = New Artist
        Try
            Me.country.ReadAllCountries()
            Me.artist.ReadAllArtists()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
        For Each cAux In Me.country.counDAO.Countries
            Me.lst_Countries.Items.Add(cAux.idCountry)

            Me.cb_ArtistCountry.Items.Add(cAux.idCountry)
        Next
        For Each aAux In Me.artist.artistsDAO.Artists
            Me.lst_artits.Items.Add(aAux.artistName)
        Next
        btn_insert_country.Enabled = True
        btn_delete_country.Enabled = True
        btn_update_country.Enabled = True
        btn_insertArtist.Enabled = True
        btn_deleteArtist.Enabled = True
        btn_updateArtist.Enabled = True
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

    Private Sub lst_artits_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_artits.SelectedIndexChanged

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
            cb_ArtistCountry.Items.Add(countryNew.idCountry)
        Else
            MessageBox.Show("Id and Name were empty, please fill those spaces", "Custom Error", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub btn_update_country_Click(sender As Object, e As EventArgs) Handles btn_update_country.Click
        Me.country = New Country
        Dim CountryUpdate = New Country

        If MessageBox.Show("Are you sure? Do you want to update this country?", "Custom Error", MessageBoxButtons.YesNo) = DialogResult.No Then
            Exit Sub
        End If

        Try
            country.idCountry = txtID.Text
            country.countryName = txtName.Text

            If txtID.Text <> String.Empty And txtName.Text <> String.Empty Then
                CountryUpdate.SetIdCountry(country.GetIdCountry)
                CountryUpdate.SetCountryName(country.GetCountryName)
                Try
                    CountryUpdate.UpdateCountry()
                    MsgBox("Country Updated succesfully")
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End Try
            Else
                MessageBox.Show("Unable to update information, all needed fields must be filled", "Custom Error", MessageBoxButtons.OK)
            End If

        Catch ex As Exception

        End Try

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
            Me.cb_ArtistCountry.Items.Remove(country.idCountry)

        Else
            MessageBox.Show("Unable to delete information, all needed fields must be filled", "Custom Error", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub btn_insertArtist_Click(sender As Object, e As EventArgs) Handles btn_insertArtist.Click
        Dim artistNew As Artist
        If txt_artistName.Text <> String.Empty And cb_ArtistCountry.SelectedIndex.ToString <> String.Empty Then
            artistNew = New Artist
            artistNew.artistName = txt_artistName.Text
            artistNew.artistCountry = cb_ArtistCountry.Text

            Try
                If artistNew.InsertArtist() <> 1 Then
                    MessageBox.Show("INSERT <> -1", "CUSTOM ERROR", MessageBoxButtons.OK)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
            lst_artits.Items.Add(artistNew.GetName)
        Else
            MessageBox.Show("Id and Name were empty, please fill those spaces", "Custom Error", MessageBoxButtons.OK)
        End If

    End Sub

    Private Sub btn_updateArtist_Click(sender As Object, e As EventArgs) Handles btn_updateArtist.Click

    End Sub


End Class
