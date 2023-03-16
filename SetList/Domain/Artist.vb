Public Class Artist
    Private Property IdArtist As Integer
    Private Property aName As String
    Private Property country As String
    Private Property image As String
    Private ReadOnly Property artistsDAO As ArtistDAO
    Private User As String
    Private favDate As Date
    Public Sub New()
        Me.artistsDAO = New ArtistDAO
    End Sub
    Public Sub New(id As Integer)
        Me.artistsDAO = New ArtistDAO
        Me.IdArtist = id
    End Sub
    Public Sub New(id As Integer, name As String, country As String, image As String)
        Me.artistsDAO = New ArtistDAO
        IdArtist = id
        aName = name
        Me.country = country
        Me.image = image
    End Sub
    Public Sub New(user As String, IdArtist As Integer, favDate As Date)
        Me.artistsDAO = artistsDAO
        Me.User = user
        Me.IdArtist = IdArtist
        Me.favDate = favDate
    End Sub
    Public Sub ReadArtist()
        Me.artistsDAO.Read(Me)
    End Sub
    Public Function GetIdArtist() As Integer
        Return IdArtist
    End Function
    Public Function GetImage() As String
        Return image
    End Function
    Public Function GetCountry() As String
        Return country
    End Function
    Public Function GetName() As String
        Return aName
    End Function
    Public Function GetUser() As String
        Return User
    End Function
    Public Function GetFavDate() As Date
        Return favDate
    End Function
    Public Function SetUser(user As String) As String
        Me.User = user
    End Function
    Public Function SetFavDate(favDate As Date) As Date
        Me.favDate = favDate
    End Function
    Public Function SetIdArtist(idArtsit As Integer) As Integer
        IdArtist = idArtsit
    End Function
    Public Function SetName(name As String) As String
        aName = name
    End Function
    Public Function SetImage(image As String) As String
        Me.image = image
    End Function
    Public Function SetCountry(country As String) As String
        Me.country = country
    End Function
    Public Function ReadAllFavArtists(path As String) As Object
        Return Me.artistsDAO.ReadAllFavArtists(path)
    End Function
    Public Function ReadAllArtists(path As String) As Object
        Return Me.artistsDAO.ReadAll(path)
    End Function
    Public Sub ReadAll()
        Me.artistsDAO.Read(Me)
    End Sub
    Public Function InsertArtist() As Integer
        Return Me.artistsDAO.Insert(Me)
    End Function
    Public Function InsertFav_Artist() As Integer
        Return Me.artistsDAO.InsertFav(Me)
    End Function
    Public Function DeleteFav_Artist() As Integer
        Return Me.artistsDAO.DeleteFav_Artist(Me)
    End Function
    Public Function UpdateArtist() As Integer
        Return Me.artistsDAO.Update(Me)
    End Function
    Public Function DeleteArtist() As Integer
        Return Me.artistsDAO.Delete(Me)
    End Function


End Class
