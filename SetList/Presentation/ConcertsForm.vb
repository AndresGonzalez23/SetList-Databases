Public Class ConcertsForm

    Private artist As Artist
    Private Venue As Venue
    Private concert As Concert
    Private previousConcert As Concert
    Private song As Song
    Private album As Album


    Public Sub LoadInfo()
        Dim coAux As Concert
        Dim aAux As Artist
        Dim vAux As Venue

        Me.artist = New Artist
        Me.Venue = New Venue
        Me.concert = New Concert

        Try
            Me.artist.ReadAllArtists()
            Me.Venue.ReadAllVenues()
            Me.concert.ReadAllConcert()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        For Each aAux In Me.artist.artistsDAO.Artists
            Me.lst_artists.Items.Add(aAux.artistName)
        Next
        For Each vAux In Me.Venue.vDao.Venues
            Me.lst_venues.Items.Add(vAux.venueName)
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

        btn_insertConcert.Enabled = True
    End Sub

    Private Sub lst_concerts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_concerts.SelectedIndexChanged
        Dim data As String : Dim separatedData() As String

        btn_updateConcert.Enabled = True
        btn_deleteConcert.Enabled = True
        lst_concertSetlist.Items.Clear()

        If lst_concerts.SelectedItem IsNot Nothing Then
            Me.concert = New Concert
            Me.artist = New Artist
            Me.Venue = New Venue
            Me.song = New Song

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

            For Each artista As String In lst_artists.Items
                If artista.Contains(artist.artistName) Then
                    lst_artists.SelectedItem = artista
                    Exit For
                End If
            Next

            For Each concertVenue As String In lst_venues.Items
                If concertVenue.Contains(Venue.venueName) Then
                    lst_venues.SelectedItem = concertVenue
                    Exit For
                End If
            Next

            concert.ReadSetlist()
            For Each setlistSong As Integer In concert.SetList
                song.idSong = setlistSong
                song.ReadSong()
                lst_concertSetlist.Items.Add(song.songName)
            Next


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
        btn_addSong.Enabled = True
        btn_removeSong.Enabled = False
    End Sub

    Private Sub lst_concertSetlist_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_concertSetlist.SelectedIndexChanged
        btn_removeSong.Enabled = True
    End Sub

    Private Sub lst_artists_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_artists.SelectedIndexChanged
        Dim albAux As Album
        Dim sonAux As Song

        Me.artist = New Artist
        Me.album = New Album
        Me.song = New Song

        btn_addSong.Enabled = False
        lst_concertSetlist.Items.Clear()
        lst_songs.Items.Clear()
        artist.artistName = lst_artists.SelectedItem.ToString
        artist.ReadArtistByName()

        Try
            album.albumArtist = artist.IdArtist
            album.ReadAllAlbumsArtist()

            For Each albAux In Me.album.albDAO.Albums
                song.songAlbum = albAux.idAlbum
                song.ReadAllAlbumSongs()
                For Each sonAux In Me.song.sonDAO.Songs
                    song.songName = sonAux.songName
                    Me.lst_songs.Items.Add(song.songName)
                Next
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        EliminateDuplicateSongs(Me.lst_songs)

    End Sub

    Public Sub EliminateDuplicateSongs(ByRef listbox As ListBox)
        Dim items As New List(Of String)
        For Each item As String In listbox.Items
            items.Add(item)
        Next

        For i As Integer = items.Count - 1 To 0 Step -1
            If listbox.Items.IndexOf(items(i)) <> i Then
                listbox.Items.RemoveAt(i)
            End If
        Next
    End Sub

    Private Sub btn_insertConcert_Click(sender As Object, e As EventArgs) Handles btn_insertConcert.Click
        Dim concertNew As Concert
        Me.artist = New Artist
        Me.Venue = New Venue
        Me.song = New Song

        If lst_artists.SelectedIndex <> -1 And lst_venues.SelectedIndex <> -1 And txt_dateConcert.Value.ToString <> String.Empty And lst_concertSetlist.Items.Count > 0 Then
            concertNew = New Concert
            artist.artistName = lst_artists.SelectedItem.ToString
            artist.ReadArtistByName()
            concertNew.ArtistName = artist.IdArtist
            Venue.venueName = lst_venues.SelectedItem.ToString
            Venue.ReadVenueByName()
            concertNew.VenueName = Venue.idVenue
            concertNew.concertDate = txt_dateConcert.Value.Date

            For Each cancion As String In lst_concertSetlist.Items
                song.songName = cancion
                song.ReadSongByName()
                concertNew.SetList.Add(song.idSong)
            Next

            Try
                If concertNew.InsertConcert() <> 1 Then
                    MessageBox.Show("INSERT <> -1", "CUSTOM ERROR", MessageBoxButtons.OK)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
            concertNew.ReadConcertbyArtistAndVenue()
            concertNew.InsertConcertSetlist()
            lst_concerts.Items.Add(artist.artistName & "-" & Venue.venueName)
        Else
            MessageBox.Show("Artist, Venue or Setlist is not selected or fulfilled, please fill those spaces", "Custom Error", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub btn_updateConcert_Click(sender As Object, e As EventArgs) Handles btn_updateConcert.Click
        Me.concert = New Concert
        Dim UpdateConcert As New Concert : Dim coAux As Concert
        Me.artist = New Artist
        Me.Venue = New Venue
        Me.song = New Song

        If MessageBox.Show("Are you sure? Do you want to update this concert?", "Custom Error", MessageBoxButtons.YesNo) = DialogResult.No Then
            Exit Sub
        End If

        Try
            UpdateConcert = New Concert
            UpdateConcert.concertDate = txt_dateConcert.Value.Date
            artist.artistName = lst_artists.SelectedItem.ToString
            artist.ReadArtistByName()
            UpdateConcert.ArtistName = artist.IdArtist
            Venue.venueName = lst_venues.SelectedItem.ToString
            Venue.ReadVenueByName()
            UpdateConcert.VenueName = Venue.idVenue
            UpdateConcert.idConcert = previousConcert.idConcert

            If lst_artists.SelectedIndex <> -1 And lst_venues.SelectedIndex <> -1 And txt_dateConcert.Value.ToString <> String.Empty Then
                Try
                    UpdateConcert.UpdateConcert()
                    MsgBox("Album Update Succesfully")
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End Try

                lst_concerts.Items.Clear()
                concert.ReadAllConcert()
                For Each coAux In Me.concert.cDao.Concerts
                    Me.artist = New Artist
                    Me.Venue = New Venue
                    artist.IdArtist = coAux.ArtistName
                    artist.ReadArtist()
                    Venue.idVenue = coAux.VenueName
                    Venue.ReadVenue()
                    Me.lst_concerts.Items.Add(artist.artistName & "-" & Venue.venueName)
                Next

                UpdateConcert.DeleteConcertSetlist()
                For Each cancion As String In lst_concertSetlist.Items
                    song.songName = cancion
                    song.ReadSongByName()
                    UpdateConcert.SetList.Add(song.idSong)
                Next
                UpdateConcert.InsertConcertSetlist()
                UpdateConcert.ReadSetlist()
                lst_concertSetlist.Items.Clear()

                For Each setlistSong As Integer In UpdateConcert.SetList
                    song.idSong = setlistSong
                    song.ReadSong()
                    lst_concertSetlist.Items.Add(song.songName)
                Next

            Else
                MessageBox.Show("Unable to update information, all needed fields must be filled", "Custom Error", MessageBoxButtons.OK)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_deleteConcert_Click(sender As Object, e As EventArgs) Handles btn_deleteConcert.Click
        Me.concert = New Concert
        Me.artist = New Artist
        Me.Venue = New Venue

        If MessageBox.Show("Are you sure? Do you want to delete permanetly this concert?", "Custom Error", MessageBoxButtons.YesNo) = DialogResult.No Then
            Exit Sub
        End If
        If lst_artists.SelectedIndex <> -1 And lst_venues.SelectedIndex <> -1 And txt_dateConcert.Value.ToString <> String.Empty Then
            artist.artistName = lst_artists.SelectedItem.ToString
            artist.ReadArtistByName()
            concert.ArtistName = artist.IdArtist
            Venue.venueName = lst_venues.SelectedItem.ToString
            Venue.ReadVenueByName()
            concert.VenueName = Venue.idVenue
            concert.ReadConcertbyArtistAndVenue()

            concert.DeleteConcertSetlist()
            lst_concertSetlist.Items.Clear()

            If artist.artistName <> lst_artists.SelectedItem.ToString And Venue.venueName <> lst_venues.SelectedItem.ToString Then
                MessageBox.Show("This is not the same concert", "Custom Error", MessageBoxButtons.OK)
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

    Private Sub btn_addSong_Click(sender As Object, e As EventArgs) Handles btn_addSong.Click

        If Not lst_concertSetlist.Items.Contains(lst_songs.SelectedItem.ToString) Then
            lst_concertSetlist.Items.Add(lst_songs.SelectedItem.ToString)
        Else
            MsgBox("This song is already on the list")
        End If

    End Sub

    Private Sub btn_removeSong_Click(sender As Object, e As EventArgs) Handles btn_removeSong.Click
        lst_concertSetlist.Items.Remove(lst_concertSetlist.SelectedItem.ToString)
    End Sub


End Class