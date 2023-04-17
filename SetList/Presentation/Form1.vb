Imports System.Windows
Imports System.Globalization
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar
Imports SetList.CountryForm
Imports SetList.ArtistForm
Imports SetList.VenueForm
Imports SetList.SongsForm
Imports SetList.AlbumForm
Imports SetList.ConcertsForm
Imports SetList.StatisticsForm

Public Class Form1

    Private Sub btn_openCountries_Click(sender As Object, e As EventArgs) Handles btn_openCountries.Click
        Dim countryForm As New CountryForm

        countryForm.LoadInfo()
        countryForm.Show()
    End Sub

    Private Sub btn_openArtists_Click(sender As Object, e As EventArgs) Handles btn_openArtists.Click
        Dim artistForm As New ArtistForm

        artistForm.LoadInfo()
        artistForm.Show()
    End Sub

    Private Sub btn_openVenues_Click(sender As Object, e As EventArgs) Handles btn_openVenues.Click
        Dim venueForm As New VenueForm

        venueForm.LoadInfo()
        venueForm.Show()
    End Sub

    Private Sub btn_openAlbums_Click(sender As Object, e As EventArgs) Handles btn_openAlbums.Click
        Dim albumForm As New AlbumForm

        albumForm.LoadInfo()
        albumForm.Show()
    End Sub

    Private Sub btn_openSongs_Click(sender As Object, e As EventArgs) Handles btn_openSongs.Click
        Dim songsForm As New SongsForm

        songsForm.LoadInfo()
        songsForm.Show()
    End Sub

    Private Sub btn_openConcerts_Click(sender As Object, e As EventArgs) Handles btn_openConcerts.Click
        Dim concertsForm As New ConcertsForm

        concertsForm.LoadInfo()
        concertsForm.Show()
    End Sub

    Private Sub btn_Statistics_Click(sender As Object, e As EventArgs) Handles btn_Statistics.Click
        Dim statisticsForm As New StatisticsForm

        statisticsForm.Show()

    End Sub
End Class
