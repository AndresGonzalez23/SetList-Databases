Public Class StatisticsForm
    Private artist As Artist
    Private song As Song
    Private previousArtist As Artist
    Private country As Country
    Private album As Album
    Private artistCountry As Country
    Public albumArtist As Integer

    Public Sub LoadInfo()
        Dim aAux As Artist
        Dim couAux As Country

        Me.artist = New Artist
        Me.country = New Country
        Try
            Me.artist.ReadAllArtists()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        For Each aAux In Me.artist.artistsDAO.Artists
            Me.lst_artists.Items.Add(aAux.artistName)
        Next

    End Sub

    Private Sub btn_searchSql1_Click(sender As Object, e As EventArgs) Handles btn_searchSql1.Click
        Dim list As New Collection

        Me.artist = New Artist
        If lst_artists.SelectedItem IsNot Nothing Then
            artist.artistName = lst_artists.SelectedItem.ToString
            artist.ReadArtistByName()

            list = CType(artist.Query1(), Collection)

            For Each songName In list
                lst_moreSinged.Items.Add(songName)
            Next

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_Query4.Click
        Dim list As New Collection
        Dim sonAux As New Song
        Me.song = New Song
        Me.album = New Album

        list = CType(song.Query4(), Collection)

        For Each songName In list
            sonAux.songName = songName.ToString
            sonAux.ReadSongByName()
            album.idAlbum = sonAux.songAlbum
            album.ReadAlbum()

            lst_songs.Items.Add("ID: " & sonAux.idSong & " Name: " & sonAux.songName & " Length: " & sonAux.songLength & " Album: " & album.albumName & " Song Order: " & sonAux.songOrder)
        Next

    End Sub
End Class