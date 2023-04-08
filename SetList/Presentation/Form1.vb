Imports System.Windows
Imports System.Globalization
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class Form1
    Private country As Country
    Private artistCountry As Country
    Private venueCountry As Country
    Private artist As Artist
    Private albumCreator As Artist
    Private concertArtist As Artist
    Private previousArtist As Artist
    Private previousVenue As Venue
    Private Venue As Venue
    Private concertVenue As Venue
    Private concert As Concert
    Private previousConcert As Concert
    Public album As Album
    Public albumArtist As Integer
    Public songAlbum As Integer
    Public idVenue As Integer
    Public previousAlbum As Album
    Private song As Song
    Private previousSong As Song


    Private Sub btn_connection_Click(sender As Object, e As EventArgs) Handles btn_connection.Click
        Dim cAux As Country
        Dim coAux As Concert
        Dim aAux As Artist
        Dim vAux As Venue
        Dim albAux As Album
        Dim sonAux As Song
        Me.country = New Country
        Me.artist = New Artist
        Me.Venue = New Venue
        Me.album = New Album
        Me.concert = New Concert
        Me.song = New Song
        Try
            Me.country.ReadAllCountries()
            Me.artist.ReadAllArtists()
            Me.Venue.ReadAllVenues()
            Me.album.ReadAllAlbums()
            Me.concert.ReadAllConcert()
            Me.song.ReadAllSongs()
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
            Me.artist = New Artist
            Me.Venue = New Venue
            artist.IdArtist = coAux.ArtistName
            artist.ReadArtist()
            Venue.idVenue = coAux.VenueName
            Venue.ReadVenue()
            Me.lst_concerts.Items.Add(artist.artistName & "-" & Venue.venueName)
        Next
        For Each sonAux In Me.song.sonDAO.Songs
            Me.lst_songs.Items.Add(sonAux.songName)
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
        btn_updateConcert.Enabled = True
        btn_deleteConcert.Enabled = True
        btn_insertSong.Enabled = True
        btn_updateSong.Enabled = True
        btn_deleteSong.Enabled = True
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
                Me.artistCountry = New Country
                artistCountry.idCountry = artist.artistCountry
                artistCountry.ReadCountry()
                txt_artistCountry.Text = artistCountry.countryName
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
                songAlbum = album.idAlbum
                txt_albumName.Text = album.albumName
                txt_albumYear.Text = album.albumYear.ToString()
                Me.albumCreator = New Artist
                albumCreator.IdArtist = album.GetAlbumArtist()
                albumCreator.ReadArtist()
                txt_albumArtist.Text = albumCreator.artistName
                Me.previousAlbum = New Album
                previousAlbum.albumName = txt_albumName.Text
                previousAlbum.ReadAlbumByName()

                If txt_songName.Text <> String.Empty And txt_songLength.Text <> String.Empty Then
                    txt_songAlbum.Text = lst_albums.SelectedItem.ToString()
                End If

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
                Me.venueCountry = New Country
                venueCountry.idCountry = Venue.venueCountry
                venueCountry.ReadCountry()
                txt_venueCountry.Text = venueCountry.countryName
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
            Me.artist = New Artist
            Me.Venue = New Venue
            data = lst_concerts.SelectedItem.ToString()
            separatedData = data.Split("-"c)
            artist.artistName = separatedData(0)
            artist.ReadArtistByName()
            Venue.venueName = separatedData(1)
            Venue.ReadVenueByName()
            concert.ArtistName = artist.IdArtist
            concert.VenueName = Venue.idVenue
            concert.ReadConcertbyArtistAndVenue()
            txt_dateConcert.Value = concert.GetDate()
            Me.concertArtist = New Artist
            concertArtist.IdArtist = concert.ArtistName
            concertArtist.ReadArtist()
            txt_artistConcert.Text = concertArtist.artistName
            Me.concertVenue = New Venue
            concertVenue.idVenue = concert.VenueName
            concertVenue.ReadVenue()
            txt_venueConcert.Text = concertVenue.venueName
            Me.previousConcert = New Concert
            data = lst_concerts.SelectedItem.ToString()
            separatedData = data.Split("-"c)
            artist.artistName = separatedData(0)
            artist.ReadArtistByName()
            Venue.venueName = separatedData(1)
            Venue.ReadVenueByName()
            previousConcert.ArtistName = artist.IdArtist
            previousConcert.VenueName = Venue.idVenue
            previousConcert.ReadConcertbyArtistAndVenue()

        End If
    End Sub

    Private Sub lst_songs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_songs.SelectedIndexChanged
        btn_deleteSong.Enabled = True
        btn_updateSong.Enabled = True
        If lst_songs.SelectedItem IsNot Nothing Then
            Try
                Me.song = New Song
                song.songName = lst_songs.SelectedItem.ToString
                song.ReadSongByName()
                txt_songName.Text = song.songName
                txt_songLength.Text = song.songLength.ToString()
                Me.album = New Album
                album.idAlbum = song.songAlbum
                album.ReadAlbum()
                txt_songAlbum.Text = album.albumName
                txt_songOrder.Text = song.songOrder.ToString()
                Me.previousSong = New Song
                previousSong.songName = txt_songName.Text
                previousSong.ReadSongByName()

            Catch ex As Exception
                lst_songs.SelectedIndex = -1
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
            Me.artist = New Artist
            Me.Venue = New Venue
            concertNew.ArtistName = albumArtist
            artist.IdArtist = concertNew.ArtistName
            artist.ReadArtist()
            concertNew.VenueName = idVenue
            Venue.idVenue = concertNew.VenueName
            Venue.ReadVenue()
            concertNew.concertDate = txt_dateConcert.Value.Date

            Try
                If concertNew.InsertConcert() <> 1 Then
                    MessageBox.Show("INSERT <> -1", "CUSTOM ERROR", MessageBoxButtons.OK)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
            lst_concerts.Items.Add(artist.artistName & "-" & Venue.venueName)
        Else
            MessageBox.Show("Id and Name were empty, please fill those spaces", "Custom Error", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub btn_updateConcert_Click(sender As Object, e As EventArgs) Handles btn_updateConcert.Click
        Me.concert = New Concert
        Dim UpdateConcert = New Concert
        Me.artist = New Artist
        Me.Venue = New Venue

        If MessageBox.Show("Are you sure? Do you want to update this concert?", "Custom Error", MessageBoxButtons.YesNo) = DialogResult.No Then
            Exit Sub
        End If

        Try
            UpdateConcert = New Concert
            UpdateConcert.concertDate = txt_dateConcert.Value.Date
            Venue.venueName = txt_venueConcert.Text
            Venue.ReadVenueByName()
            UpdateConcert.VenueName = Venue.idVenue
            artist.artistName = txt_artistConcert.Text
            artist.ReadArtistByName()
            UpdateConcert.ArtistName = artist.IdArtist
            UpdateConcert.idConcert = previousConcert.idConcert

            If txt_artistConcert.Text <> String.Empty And txt_venueConcert.Text <> String.Empty Then
                Try
                    UpdateConcert.UpdateConcert()
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

    Private Sub btn_deleteConcert_Click(sender As Object, e As EventArgs) Handles btn_deleteConcert.Click
        If MessageBox.Show("Are you sure? Do you want to delete permanetly this concert?", "Custom Error", MessageBoxButtons.YesNo) = DialogResult.No Then
            Exit Sub
        End If
        If txt_artistConcert.Text <> String.Empty And txt_venueConcert.Text <> String.Empty Then
            Me.concert = New Concert
            Me.artist = New Artist
            artist.artistName = txt_artistConcert.Text
            artist.ReadArtistByName()
            Me.Venue = New Venue
            Venue.venueName = txt_venueConcert.Text
            Venue.ReadVenueByName()
            concert.ArtistName = artist.IdArtist
            concert.VenueName = Venue.idVenue
            concert.ReadConcertbyArtistAndVenue()
            If artist.artistName <> txt_artistConcert.Text And Venue.venueName <> txt_venueConcert.Text Then
                MessageBox.Show("This is not the same date", "Custom Error", MessageBoxButtons.OK)
                Exit Sub
            End If
            Try
                If concert.DeleteConcert() <> 1 Then
                    MessageBox.Show("INSERT <> -1", "Custom Error", MessageBoxButtons.OK)
                End If
            Catch ex As Exception
                MessageBox.Show("Concert deleted", ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try

            Me.lst_concerts.Items.Remove(artist.artistName & "-" & Venue.venueName)
        Else
            MessageBox.Show("Unable to delete information, all needed fields must be filled", "Custom Error", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub btn_insertSong_Click(sender As Object, e As EventArgs) Handles btn_insertSong.Click
        Dim songNew As Song
        If txt_songName.Text <> String.Empty And txt_songLength.Text <> String.Empty And txt_songOrder.Text <> String.Empty Then
            songNew = New Song
            songNew.songName = txt_songName.Text
            songNew.songLength = Convert.ToInt32(txt_songLength.Text)
            songNew.songAlbum = songAlbum
            songNew.songOrder = Convert.ToInt32(txt_songOrder.Text)

            Try
                If songNew.InsertSong() <> 1 Then
                    MessageBox.Show("INSERT <> -1", "CUSTOM ERROR", MessageBoxButtons.OK)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
            lst_songs.Items.Add(songNew.GetSongName)
        Else
            MessageBox.Show("name, length, album or order is empty please fill those spaces", "Custom Error", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub btn_updateSong_Click(sender As Object, e As EventArgs) Handles btn_updateSong.Click
        Me.song = New Song
        Dim UpdateSong = New Song

        If MessageBox.Show("Are you sure? Do you want to update this song?", "Custom Error", MessageBoxButtons.YesNo) = DialogResult.No Then
            Exit Sub
        End If

        Try
            UpdateSong.songName = txt_songName.Text
            UpdateSong.songLength = Convert.ToInt32(txt_songLength.Text)
            UpdateSong.songAlbum = songAlbum
            UpdateSong.songOrder = Convert.ToInt32(txt_songOrder.Text)
            UpdateSong.idSong = previousSong.GetIdSong()

            If txt_songName.Text <> String.Empty Then
                Try
                    UpdateSong.UpdateSong()
                    MsgBox("Song Update Succesfull")
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End Try
            Else
                MessageBox.Show("Unable to update information, all needed fields must be filled", "Custom Error", MessageBoxButtons.OK)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_deleteSong_Click(sender As Object, e As EventArgs) Handles btn_deleteSong.Click
        If MessageBox.Show("Are you sure? Do you want to delete permanetly this song?", "Custom Error", MessageBoxButtons.YesNo) = DialogResult.No Then
            Exit Sub
        End If

        If txt_songName.Text <> String.Empty Then
            song.songName = txt_songName.Text
            song.ReadSongByName()

            If song.songName <> txt_songName.Text.Trim() Then
                MessageBox.Show("This is not the same name", "Custom Error", MessageBoxButtons.OK)
                Exit Sub
            End If
            Try
                If song.DeleteSong() <> 1 Then
                    MessageBox.Show("INSERT <> -1", "Custom Error", MessageBoxButtons.OK)
                End If
            Catch ex As Exception
                MessageBox.Show("Song deleted", ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try

            Me.lst_songs.Items.Remove(song.songName)
        Else
            MessageBox.Show("Unable to delete information, all needed fields must be filled", "Custom Error", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub btn_setlist_Click(sender As Object, e As EventArgs) Handles btn_setlist.Click
        Dim main As New Main() 'Crea una nueva instancia del formulario 2
        main.Show() 'Muestra el formulario 2
        Me.Hide() 'Oculta el formulario actual
    End Sub
End Class
