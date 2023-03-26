Imports System.Windows
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class Form1
    Private country As Country
    Private artist As Artist
    Private Venue As Venue
    Public countries As Collection
    Public venues As Collection

    Private Sub btn_connection_Click(sender As Object, e As EventArgs) Handles btn_connection.Click
        Dim cAux As Country
        Dim aAux As Artist
        Dim vAux As Venue
        Me.country = New Country
        Me.artist = New Artist
        Me.Venue = New Venue
        Try
            Me.country.ReadAllCountries()
            Me.artist.ReadAllArtists()
            Me.Venue.ReadAllVenues()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
        For Each cAux In Me.country.counDAO.Countries
            Me.lst_Countries.Items.Add(cAux.countryName)
        Next
        For Each aAux In Me.artist.artistsDAO.Artists

            Me.lst_artits.Items.Add(aAux.artistName)
        Next
        For Each vAux In Me.Venue.vDao.Venues

            Me.lst_venues.Items.Add(vAux.venueName)
        Next
        btn_insert_country.Enabled = True
        btn_delete_country.Enabled = True
        btn_update_country.Enabled = True
        btn_insertArtist.Enabled = True
        btn_deleteArtist.Enabled = True
        btn_updateArtist.Enabled = True
        btn_insertVenue.Enabled = True
        btn_deleteVenue.Enabled = True
    End Sub


    Private Sub lst_Countries_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_Countries.SelectedIndexChanged
        btn_delete_country.Enabled = True
        btn_update_country.Enabled = True
        If lst_Countries.SelectedItem IsNot Nothing Then
            Try
                Me.country = New Country
                country.idCountry = lst_Countries.SelectedItem.ToString.Substring(0, 3)
                country.ReadCountry()
                txtName.Text = country.countryName
                If txt_artistName.Text <> String.Empty Then
                    txt_artistCountry.Text = lst_Countries.SelectedItem.ToString()
                End If

                If txt_venueName.Text <> String.Empty Then
                    txt_venueCountry.Text = lst_Countries.SelectedItem.ToString()
                End If

            Catch ex As Exception
                lst_Countries.SelectedIndex = -1
            End Try
        End If
    End Sub

    Private Sub lst_artits_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_artits.SelectedIndexChanged
        btn_deleteArtist.Enabled = True
        btn_updateArtist.Enabled = True

        If lst_artits.SelectedItem IsNot Nothing Then
            Try
                Me.artist = New Artist
                artist.artistName = lst_artits.SelectedItem.ToString
                artist.ReadArtist()
                txt_artistName.Text = artist.artistName
                txt_artistCountry.Text = artist.GetCountry()

            Catch ex As Exception
                lst_artits.SelectedIndex = -1
            End Try
        End If
    End Sub

    Private Sub lst_venues_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_venues.SelectedIndexChanged

        If lst_venues.SelectedItem IsNot Nothing Then
            Try
                Me.Venue = New Venue
                Venue.venueName = lst_venues.SelectedItem.ToString
                Venue.ReadVenue()
                txt_venueName.Text = Venue.venueName
                txt_venueCountry.Text = Venue.GetVenueCountry()
                txt_venueType.Text = Venue.GetVenueType()


            Catch ex As Exception
                lst_venues.SelectedIndex = -1
            End Try
        End If
    End Sub

    Private Sub btn_insert_country_Click(sender As Object, e As EventArgs) Handles btn_insert_country.Click
        Dim countryNew As New Country
        Dim thirdChar As String
        Dim auxCountryName As String
        If txtName.Text <> String.Empty Then
            countryNew = New Country
            countryNew.countryName = txtName.Text
            auxCountryName = txtName.Text
            thirdChar = auxCountryName.Substring(0, 3)
            countryNew.idCountry = thirdChar
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
        Me.country = New Country
        Dim CountryUpdate = New Country
        If MessageBox.Show("Are you sure? Do you want to update this country?", "Custom Error", MessageBoxButtons.YesNo) = DialogResult.No Then
            Exit Sub
        End If
        Try
            country.countryName = txtName.Text
            If txtName.Text <> String.Empty Then
                CountryUpdate.SetIdCountry(country.countryName.Substring(0, 3))
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
        If txtName.Text <> String.Empty Then
            Me.country = New Country

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
            Me.lst_Countries.Items.Remove(country.countryName)

        Else
            MessageBox.Show("Unable to delete information, all needed fields must be filled", "Custom Error", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub btn_insertArtist_Click(sender As Object, e As EventArgs) Handles btn_insertArtist.Click
        Dim artistNew As Artist : Dim countryNameNew As String
        If txt_artistName.Text <> String.Empty And txt_artistCountry.Text <> String.Empty Then
            artistNew = New Artist
            artistNew.artistName = txt_artistName.Text
            countryNameNew = txt_artistCountry.Text
            artistNew.artistCountry = countryNameNew.Substring(0, 3)

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
        Me.artist = New Artist
        Dim UpdateArtist = New Artist : Dim countryNameNew As String

        If MessageBox.Show("Are you sure? Do you want to update this country?", "Custom Error", MessageBoxButtons.YesNo) = DialogResult.No Then
            Exit Sub
        End If

        Try
            artist.artistName = txt_artistName.Text
            countryNameNew = txt_artistCountry.Text
            artist.artistCountry = countryNameNew.Substring(0, 3)

            If txt_artistName.Text <> String.Empty Then
                UpdateArtist.SetName(artist.artistName)
                UpdateArtist.SetCountry(artist.artistCountry)
                Try
                    UpdateArtist.UpdateArtist()
                    MsgBox("Artist Update Succesfully")
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End Try
            Else
                MessageBox.Show("Unable to update information, all needed fields must be filled", "Custom Error", MessageBoxButtons.OK)
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btn_deleteArtist_Click(sender As Object, e As EventArgs) Handles btn_deleteArtist.Click
        If MessageBox.Show("Are you sure? Do you want to delete permanetly this country?", "Custom Error", MessageBoxButtons.YesNo) = DialogResult.No Then
            Exit Sub
        End If
        If txt_artistName.Text <> String.Empty Then
            Me.artist = New Artist
            artist.artistName = txt_artistName.Text
            artist.ReadArtist()
            If artist.artistName <> txt_artistName.Text.Trim() Then
                MessageBox.Show("This is not the same name", "Custom Error", MessageBoxButtons.OK)
                Exit Sub
            End If
            Try
                If artist.DeleteArtist() <> 1 Then
                    MessageBox.Show("INSERT <> -1", "Custom Error", MessageBoxButtons.OK)
                End If
            Catch ex As Exception
                MessageBox.Show("Artist deleted", ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
            Me.lst_artits.Items.Remove(artist.artistName)
        Else
            MessageBox.Show("Unable to delete information, all needed fields must be filled", "Custom Error", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub btn_venueInsertar_Click(sender As Object, e As EventArgs) Handles btn_insertVenue.Click
        Dim venueNew As Venue : Dim countryVenueNew As String
        If txt_venueName.Text <> String.Empty And txt_venueType.Text <> String.Empty Then
            venueNew = New Venue
            venueNew.venueName = txt_venueName.Text
            countryVenueNew = txt_venueCountry.Text
            venueNew.venueCountry = countryVenueNew.Substring(0, 3)
            venueNew.venueType = txt_venueType.Text

            Try
                If venueNew.InsertVenue() <> 1 Then
                    MessageBox.Show("INSERT <> -1", "CUSTOM ERROR", MessageBoxButtons.OK)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
            lst_venues.Items.Add(venueNew.GetVenueName)
        Else
            MessageBox.Show("name, country or type are empty please fill those spaces", "Custom Error", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub btn_deleteVenue_Click(sender As Object, e As EventArgs) Handles btn_deleteVenue.Click
        If MessageBox.Show("Are you sure? Do you want to delete permanetly this country?", "Custom Error", MessageBoxButtons.YesNo) = DialogResult.No Then
            Exit Sub
        End If
        If txt_venueName.Text <> String.Empty Then
            Me.Venue = New Venue
            Venue.venueName = txt_venueName.Text
            Venue.ReadVenue()
            If Venue.venueName <> txt_venueName.Text.Trim() Then
                MessageBox.Show("This is not the same name", "Custom Error", MessageBoxButtons.OK)
                Exit Sub
            End If
            Try
                If Venue.DeleteVenue() <> 1 Then
                    MessageBox.Show("INSERT <> -1", "Custom Error", MessageBoxButtons.OK)
                End If
            Catch ex As Exception
                MessageBox.Show("Venue deleted", ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try

            Me.lst_venues.Items.Remove(Venue.venueName)
        Else
            MessageBox.Show("Unable to delete information, all needed fields must be filled", "Custom Error", MessageBoxButtons.OK)
        End If
    End Sub


End Class
