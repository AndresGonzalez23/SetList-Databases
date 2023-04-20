Public Class OrderByForm

    Private artist As Artist
    Private Venue As Venue
    Private concert As Concert
    Private song As Song

    Public Function LoadInfo() As Boolean
        Dim aAux As Artist
        Dim vAux As Venue

        Me.artist = New Artist
        Me.Venue = New Venue

        Try
            Me.artist.ReadAllArtists()
            Me.Venue.ReadAllVenues()

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End Try

        For Each aAux In Me.artist.artistsDAO.Artists
            Me.lst_artist.Items.Add(aAux.artistName)
        Next
        For Each vAux In Me.Venue.vDao.Venues
            Me.lst_venues.Items.Add(vAux.venueName)
        Next
        Return True
    End Function

    Private Sub lst_artist_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_artist.SelectedIndexChanged
        Dim coAux As Concert
        Dim artistAuxiliar As New Artist
        Dim venueAuxiliar As New Venue

        lst_concerts.Items.Clear()
        lst_setlist.Items.Clear()

        If lst_artist.SelectedItem IsNot Nothing Then
            Me.artist = New Artist
            Me.concert = New Concert

            lst_concerts.Items.Clear()
            artist.artistName = lst_artist.SelectedItem.ToString
            artist.ReadArtistByName()
            concert.ArtistName = artist.IdArtist
            concert.ReadAllArtistsConcerts()

            For Each coAux In Me.concert.cDao.Concerts

                artistAuxiliar.IdArtist = coAux.ArtistName
                artistAuxiliar.ReadArtist()
                venueAuxiliar.idVenue = coAux.VenueName
                venueAuxiliar.ReadVenue()
                Me.lst_concerts.Items.Add(artistAuxiliar.artistName & "-" & venueAuxiliar.venueName)
            Next
        End If
    End Sub

    Private Sub lst_venues_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_venues.SelectedIndexChanged
        Dim coAux As Concert
        Dim artistAuxiliar As New Artist
        Dim venueAuxiliar As New Venue

        lst_concerts.Items.Clear()
        lst_setlist.Items.Clear()

        If lst_venues.SelectedItem IsNot Nothing Then
            Me.Venue = New Venue
            Me.concert = New Concert

            lst_concerts.Items.Clear()
            Venue.venueName = lst_venues.SelectedItem.ToString
            Venue.ReadVenueByName()
            concert.VenueName = Venue.idVenue
            concert.ReadAllVenueConcerts()

            For Each coAux In Me.concert.cDao.Concerts

                artistAuxiliar.IdArtist = coAux.ArtistName
                artistAuxiliar.ReadArtist()
                venueAuxiliar.idVenue = coAux.VenueName
                venueAuxiliar.ReadVenue()
                Me.lst_concerts.Items.Add(artistAuxiliar.artistName & "-" & venueAuxiliar.venueName)
            Next
        End If

    End Sub

    Private Sub lst_concerts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_concerts.SelectedIndexChanged
        Dim data As String : Dim separatedData() As String



        If lst_concerts.SelectedItem IsNot Nothing Then
            Me.concert = New Concert
            Me.artist = New Artist
            Me.Venue = New Venue
            Me.song = New Song

            lst_setlist.Items.Clear()
            data = lst_concerts.SelectedItem.ToString()
            separatedData = Data.Split("-"c)
            artist.artistName = separatedData(0)
            artist.ReadArtistByName()
            Venue.venueName = separatedData(1)
            Venue.ReadVenueByName()
            concert.ArtistName = artist.IdArtist
            concert.VenueName = Venue.idVenue
            concert.ReadConcertbyArtistAndVenue()

            concert.ReadSetlist()
            For Each setlistSong As Integer In concert.SetList
                Song.idSong = setlistSong
                Song.ReadSong()
                lst_setlist.Items.Add(song.songName)
            Next
        End If
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Dim ConcertsForm As New ConcertsForm
        ConcertsForm.Show()
        ConcertsForm.LoadInfo()
        Me.Hide()
    End Sub
End Class