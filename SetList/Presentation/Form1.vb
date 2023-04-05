Imports System.Windows
Imports System.Globalization
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class Form1
    Private country As Country
    Private artist As Artist
    Private previousArtist As Artist
    Private previousVenue As Venue
    Private Venue As Venue
    Private concert As Concert
    Private previousConcert As Concert
    Public album As Album
    Public albumArtist As Integer
    Public idVenue As Integer
    Public previousAlbum As Album


    Private Sub btn_connection_Click(sender As Object, e As EventArgs) Handles btn_connection.Click
        Dim cAux As Country
        Dim coAux As Concert
        Dim aAux As Artist
        Dim vAux As Venue
        Dim albAux As Album
        Me.country = New Country
        Me.artist = New Artist
        Me.Venue = New Venue
        Me.album = New Album
        Me.concert = New Concert
        Try
            Me.country.ReadAllCountries()
            Me.artist.ReadAllArtists()
            Me.Venue.ReadAllVenues()
            Me.album.ReadAllAlbums()
            Me.concert.ReadAllConcert()
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
        For Each albAux In Me.album.albDAO.Albums
            Me.lst_albums.Items.Add(albAux.albumName)
        Next
        For Each coAux In Me.concert.cDao.Concerts
            Me.lst_concerts.Items.Add(coAux.ArtistName.ToString() & "-" & coAux.VenueName.ToString())
        Next
        btn_insert_country.Enabled = True
        btn_delete_country.Enabled = True
        btn_update_country.Enabled = True
        btn_insertArtist.Enabled = True
        btn_deleteArtist.Enabled = True
        btn_updateArtist.Enabled = True
        btn_insertVenue.Enabled = True
        btn_deleteVenue.Enabled = True
        btn_updateVenue.Enabled = True
        btn_insertAlbum.Enabled = True
        btn_updateAlbum.Enabled = True
        btn_deleteAlbum.Enabled = True
        btn_insertConcert.Enabled = True
        btn_connection.Enabled = False
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
                artist.ReadArtistByName()
                albumArtist = artist.IdArtist
                txt_artistName.Text = artist.artistName
                txt_artistCountry.Text = artist.GetCountry()
                Me.previousArtist = New Artist
                previousArtist.artistName = txt_artistName.Text
                previousArtist.ReadArtistByName()


                If txt_albumName.Text <> String.Empty And txt_albumYear.Text <> String.Empty Then
                    txt_albumArtist.Text = lst_artits.SelectedItem.ToString()
                End If

                If txt_venueConcert.Text <> String.Empty Then
                    txt_artistConcert.Text = lst_artits.SelectedItem.ToString()
                End If

            Catch ex As Exception
                lst_artits.SelectedIndex = -1
            End Try
        End If
    End Sub

    Private Sub lst_albums_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_albums.SelectedIndexChanged
        btn_deleteAlbum.Enabled = True
        btn_updateAlbum.Enabled = True
        If lst_albums.SelectedItem IsNot Nothing Then
            Try
                Me.album = New Album
                album.albumName = lst_albums.SelectedItem.ToString
                album.ReadAlbumByName()
                txt_albumName.Text = album.albumName
                txt_albumYear.Text = album.albumYear.ToString()
                txt_albumArtist.Text = album.albumArtist.ToString()
                Me.previousAlbum = New Album
                previousAlbum.albumName = txt_albumName.Text
                previousAlbum.ReadAlbumByName()

            Catch ex As Exception
                lst_albums.SelectedIndex = -1
            End Try
        End If
    End Sub

    Private Sub lst_venues_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_venues.SelectedIndexChanged

        If lst_venues.SelectedItem IsNot Nothing Then
            Try
                Me.Venue = New Venue
                Venue.venueName = lst_venues.SelectedItem.ToString
                Venue.ReadVenueByName()
                idVenue = Venue.idVenue
                txt_venueName.Text = Venue.venueName
                txt_venueCountry.Text = Venue.GetVenueCountry()
                cmb_venuesType.Text = Venue.GetVenueType()
                Me.previousVenue = New Venue
                previousVenue.venueName = txt_venueName.Text
                previousVenue.ReadVenueByName()

                txt_venueConcert.Text = lst_venues.SelectedItem.ToString()

            Catch ex As Exception
                lst_venues.SelectedIndex = -1
            End Try
        End If
    End Sub

    Private Sub lst_concerts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_concerts.SelectedIndexChanged
        Dim data As String : Dim separatedData() As String

        If lst_concerts.SelectedItem IsNot Nothing Then
            Me.concert = New Concert
            data = lst_concerts.SelectedItem.ToString()
            separatedData = data.Split("-"c)
            concert.ArtistName = Convert.ToInt32(separatedData(0))
            concert.VenueName = Convert.ToInt32(separatedData(1))
            concert.ReadConcertbyArtistAndVenue()
            txt_dateConcert.Value = concert.GetDate()
            txt_artistConcert.Text = concert.GetArtist().ToString()
            txt_venueConcert.Text = concert.GetVenue().ToString()
            Me.previousConcert = New Concert
            data = lst_concerts.SelectedItem.ToString()
            separatedData = data.Split("-"c)
            previousConcert.ArtistName = Convert.ToInt32(separatedData(0))
            previousConcert.VenueName = Convert.ToInt32(separatedData(1))
            previousConcert.ReadConcertbyArtistAndVenue()

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
            UpdateArtist.artistName = txt_artistName.Text
            countryNameNew = txt_artistCountry.Text
            UpdateArtist.artistCountry = countryNameNew.Substring(0, 3)
            UpdateArtist.IdArtist = previousArtist.GetIdArtist()

            If txt_artistName.Text <> String.Empty Then
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
            artist.ReadArtistByName()
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
        If txt_venueName.Text <> String.Empty And cmb_venuesType.SelectedItem.ToString <> String.Empty Then
            venueNew = New Venue
            venueNew.venueName = txt_venueName.Text
            countryVenueNew = txt_venueCountry.Text
            venueNew.venueCountry = countryVenueNew.Substring(0, 3)
            venueNew.venueType = cmb_venuesType.SelectedItem.ToString

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

    Private Sub btn_updateVenue_Click(sender As Object, e As EventArgs) Handles btn_updateVenue.Click
        Me.Venue = New Venue
        Dim UpdateVenue = New Venue : Dim countryNameNew As String

        If MessageBox.Show("Are you sure? Do you want to update this venue?", "Custom Error", MessageBoxButtons.YesNo) = DialogResult.No Then
            Exit Sub
        End If

        Try
            UpdateVenue.venueName = txt_venueName.Text
            countryNameNew = txt_venueCountry.Text
            UpdateVenue.venueCountry = countryNameNew.Substring(0, 3)
            UpdateVenue.venueType = cmb_venuesType.SelectedItem.ToString
            UpdateVenue.idVenue = previousVenue.GetidVenue()


            If txt_venueName.Text <> String.Empty Then
                Try
                    UpdateVenue.UpdateVenue()
                    MsgBox("Venue Update Succesfully")
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End Try
            Else
                MessageBox.Show("Unable to update information, all needed fields must be filled", "Custom Error", MessageBoxButtons.OK)
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btn_deleteVenue_Click(sender As Object, e As EventArgs) Handles btn_deleteVenue.Click

        If MessageBox.Show("Are you sure? Do you want to delete permanetly this country?", "Custom Error", MessageBoxButtons.YesNo) = DialogResult.No Then
            Exit Sub
        End If
        If txt_venueName.Text <> String.Empty Then

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

    Private Sub btn_insertAlbum_Click(sender As Object, e As EventArgs) Handles btn_insertAlbum.Click
        Dim albumNew As Album
        If txt_albumName.Text <> String.Empty And txt_albumYear.Text <> String.Empty Then
            albumNew = New Album
            albumNew.albumName = txt_albumName.Text
            albumNew.albumYear = Convert.ToInt32(txt_albumYear.Text)
            albumNew.albumArtist = albumArtist

            Try
                If albumNew.InsertAlbum() <> 1 Then
                    MessageBox.Show("INSERT <> -1", "CUSTOM ERROR", MessageBoxButtons.OK)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
            lst_albums.Items.Add(albumNew.GetAlbumName)
        Else
            MessageBox.Show("name, year or artist are empty please fill those spaces", "Custom Error", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub btn_updateAlbum_Click(sender As Object, e As EventArgs) Handles btn_updateAlbum.Click
        Me.album = New Album
        Dim UpdateAlbum = New Album

        If MessageBox.Show("Are you sure? Do you want to update this album?", "Custom Error", MessageBoxButtons.YesNo) = DialogResult.No Then
            Exit Sub
        End If

        Try
            UpdateAlbum.albumName = txt_albumName.Text
            UpdateAlbum.albumYear = Convert.ToInt32(txt_albumYear.Text)
            UpdateAlbum.albumArtist = albumArtist
            UpdateAlbum.idAlbum = previousAlbum.GetIdAlbum()


            If txt_albumName.Text <> String.Empty Then
                Try
                    UpdateAlbum.UpdateAlbum()
                    MsgBox("Album Update Succesfully")
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End Try
            Else
                MessageBox.Show("Unable to update information, all needed fields must be filled", "Custom Error", MessageBoxButtons.OK)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_deleteAlbum_Click(sender As Object, e As EventArgs) Handles btn_deleteAlbum.Click
        If MessageBox.Show("Are you sure? Do you want to delete permanetly this album?", "Custom Error", MessageBoxButtons.YesNo) = DialogResult.No Then
            Exit Sub
        End If

        If txt_albumName.Text <> String.Empty Then

            album.albumName = txt_albumName.Text
            album.ReadAlbumByName()

            If album.albumName <> txt_albumName.Text.Trim() Then
                MessageBox.Show("This is not the same name", "Custom Error", MessageBoxButtons.OK)
                Exit Sub
            End If
            Try
                If album.DeleteAlbum() <> 1 Then
                    MessageBox.Show("INSERT <> -1", "Custom Error", MessageBoxButtons.OK)
                End If
            Catch ex As Exception
                MessageBox.Show("Album deleted", ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try

            Me.lst_albums.Items.Remove(album.albumName)
        Else
            MessageBox.Show("Unable to delete information, all needed fields must be filled", "Custom Error", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub btn_insertConcert_Click(sender As Object, e As EventArgs) Handles btn_insertConcert.Click
        Dim concertNew As Concert
        If txt_artistConcert.Text <> String.Empty And txt_venueConcert.Text <> String.Empty And txt_dateConcert.Value.ToString <> String.Empty Then
            concertNew = New Concert
            concertNew.ArtistName = albumArtist
            concertNew.VenueName = idVenue
            concertNew.concertDate = txt_dateConcert.Value.Date

            Try
                If concertNew.InsertConcert() <> 1 Then
                    MessageBox.Show("INSERT <> -1", "CUSTOM ERROR", MessageBoxButtons.OK)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
            lst_concerts.Items.Add(concertNew.GetArtist() & "-" & concertNew.GetVenue)
        Else
            MessageBox.Show("Id and Name were empty, please fill those spaces", "Custom Error", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub btn_updateConcert_Click(sender As Object, e As EventArgs) Handles btn_updateConcert.Click

    End Sub

    Private Sub btn_deleteConcert_Click(sender As Object, e As EventArgs) Handles btn_deleteConcert.Click

    End Sub


End Class
