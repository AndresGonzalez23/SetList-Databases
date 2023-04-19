﻿Public Class StatisticsForm
    Private artist As Artist
    Private song As Song
    Private previousArtist As Artist
    Private country As Country
    Private concert As Concert
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
            Me.lst_artistsAlbum.Items.Add(aAux.artistName)
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

    Private Sub btn_searchSql2_Click(sender As Object, e As EventArgs) Handles btn_searchSql2.Click
        Dim list As New Collection
        Dim albAux As New Album
        Me.artist = New Artist

        If lst_artistsAlbum.SelectedItem IsNot Nothing Then
            artist.artistName = lst_artistsAlbum.SelectedItem.ToString
            artist.ReadArtistByName()

            list = CType(artist.Query2(), Collection)

            For Each albName In list
                lst_albums.Items.Add(albName)
            Next

        End If

    End Sub

    Private Sub btn_Query3_Click(sender As Object, e As EventArgs) Handles btn_Query3.Click
        Dim coAux As Concert
        Dim concertAuxiliar As New Concert
        Dim count As Integer

        Me.concert = New Concert

        concert.ReadAllConcert()
        For Each coAux In Me.concert.cDao.Concerts
            concertAuxiliar.idConcert = coAux.idConcert
            concertAuxiliar.ReadConcert()
            concertAuxiliar.ReadSetlist()
            count = concertAuxiliar.SetList.Count



        Next
    End Sub

    Private Sub btn_Query5_Click(sender As Object, e As EventArgs) Handles btn_Query5.Click
        Dim list As Collection
        Dim startDate As Date : Dim endDate As Date
        Me.artist = New Artist

        If txt_StartDate.Value.ToString <> String.Empty And txt_endDate.Value.ToString <> String.Empty Then
            startDate = txt_StartDate.Value.Date
            endDate = txt_endDate.Value.Date

            list = CType(artist.Query5(startDate, endDate), Collection)

            For Each artistName In list
                lst_artistDates.Items.Add(artistName)
            Next
        End If
    End Sub

    Private Sub btn_Query6_Click(sender As Object, e As EventArgs) Handles btn_Query6.Click
        Dim list As Collection
        Dim startDate As Date : Dim endDate As Date
        Me.country = New Country

        If txt_startDateQ6.Value.ToString <> String.Empty And txt_endDateQ6.Value.ToString <> String.Empty Then
            startDate = txt_startDateQ6.Value.Date
            endDate = txt_endDateQ6.Value.Date

            list = CType(country.Query6(startDate, endDate), Collection)

            For Each countryName In list
                lst_countries.Items.Add(countryName)
            Next
        End If
    End Sub
End Class