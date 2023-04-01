Public Class Concert
    Private Property idConcert As Integer
    Public Property concertDate As String
    Public Property ArtistName As String
    Public Property VenueName As String
    Private cDao As ConcertDAO

    Public Sub New()
        Me.cDao = New ConcertDAO
    End Sub

    Public Sub New(id As Integer, conDate As String, artist As String, venue As String)
        Me.cDao = New ConcertDAO
        idConcert = id
        concertDate = conDate
        Me.ArtistName = artist
        Me.VenueName = venue
    End Sub



    Public Function GetArtist() As Integer
        Return ArtistName
    End Function
    Public Function GetConcert() As Integer
        Return idConcert
    End Function
    Public Function GetDate() As String
        Return concertDate
    End Function
    Public Function GetVenue() As String
        Return VenueName
    End Function
    Public Function SetIdConcert(id As Integer) As Integer
        idConcert = id
    End Function
    Public Function SetDate(conDate As String) As String
        concertDate = conDate
    End Function
    Public Function SetArtist(artist As String) As String
        Me.ArtistName = artist
    End Function
    Public Function SetVenue(venue As String) As String
        Me.VenueName = venue
    End Function
    Public Function ReadAllConcert(path As String) As Object
        Return Me.cDao.ReadAll()
    End Function
    Public Function InsertVenue() As Integer
        Return Me.cDao.Insert(Me)
    End Function
    Public Function DeleteVenue() As Integer
        Return Me.cDao.Delete(Me)
    End Function
    Public Function UpdateVenue() As Integer
        Return Me.cDao.Update(Me)
    End Function
End Class
