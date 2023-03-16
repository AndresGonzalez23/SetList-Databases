Public Class ArtistDAO
    Public ReadOnly Property Artists As Collection

    Public Sub New()
        Me.Artists = New Collection
    End Sub

    Public Function ReadAll(path As String) As Object
        Dim ar As Artist
        Dim col, aux As Collection
        col = DBBroker.GetBroker().Read("SELECT * FROM Artists ORDER BY IdArtist")
        For Each aux In col
            ar = New Artist(CInt(aux(1).ToString))
            ar.SetName(aux(2).ToString)
            ar.SetCountry(aux(3).ToString)
            Me.Artists.Add(ar)
        Next
        Return Artists
    End Function

    Public Function ReadAllFavArtists(path As String) As Object
        Dim ar As Artist
        Dim fa As New Collection
        Dim col, aux As Collection
        col = DBBroker.GetBroker().Read("SELECT * FROM Fav_Artists ORDER BY user")
        For Each aux In col
            ar = New Artist()
            ar.SetUser(aux(1).ToString)
            ar.setIdArtist(CInt(aux(2).ToString))
            ar.SetFavDate(CDate(aux(3).ToString))
            fa.Add(ar)
        Next
        Return fa
    End Function

    Public Sub Read(ByRef ar As Artist)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM Artists WHERE IdArtist='" & ar.GetIdArtist() & "';")
        For Each aux In col
            ar.SetName(aux(2).ToString)
            ar.SetCountry(aux(3).ToString)
        Next
    End Sub

    Public Function InsertFav(ByVal s As Artist) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO Fav_Artists VALUES ('" & s.GetUser() & "', '" & s.GetIdArtist() & "', '" & s.GetFavDate() & "');")
    End Function
    Public Function Insert(ByVal ar As Artist) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO Artists ([aName],country,[image]) VALUES ('" & ar.GetName() & "','" & ar.GetCountry() & "',);")
    End Function
    Public Function Update(ByVal ar As Artist) As Integer
        Return DBBroker.GetBroker.Change("UPDATE Artists SET aName='" & ar.GetName() & "' ,country='" & ar.GetCountry() & "' ,[image]='" & "'WHERE IdArtist=" & ar.GetIdArtist() & ";")
    End Function
    Public Function Delete(ByVal ar As Artist) As Integer
        Return DBBroker.GetBroker.Change("DELETE FROM Artists WHERE IdArtist=" & ar.GetIdArtist() & ";")
    End Function
    Public Function DeleteFav_Artist(ByVal ar As Artist) As Integer
        Return DBBroker.GetBroker.Change("DELETE FROM Fav_Artists WHERE artist=" & ar.GetIdArtist() & ";")
    End Function


End Class
