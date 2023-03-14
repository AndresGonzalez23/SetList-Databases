Public Class Concert
    Private Property idConcert As Integer
    Private Property concertDate As Date
    Private Property Artist As Integer
    Private Property Venue As Integer
    Private cDao As ConcertDAO

    Public Sub New()
        Me.cDao = New ConcertDAO
    End Sub

    Public Sub New(id As Integer, conDate As Date, artist As Integer, venue As Integer)
        Me.cDao = New ConcertDAO
        idConcert = id
        concertDate = conDate
        Me.Artist = artist
        Me.Venue = venue
    End Sub

    Public Function getArtist() As Integer
        Return Artist
    End Function
    Public Function getConcert() As Integer
        Return idConcert
    End Function
    Public Function getDate() As Date
        Return concertDate
    End Function
    Public Function getVenue() As Integer
        Return Venue
    End Function
    Public Function setIdConcert(id As Integer) As Integer
        idConcert = id
    End Function
    Public Function setDate(conDate As Date) As Date
        concertDate = conDate
    End Function
    Public Function setArtist(artist As Integer) As Integer
        Me.Artist = artist
    End Function
    Public Function setVenue(venue As Integer) As Integer
        Me.Venue = venue
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
