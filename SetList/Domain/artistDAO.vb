Public Class ArtistDAO
    Public ReadOnly Property Artists As Collection

    Public Sub New()
        Me.Artists = New Collection
    End Sub

    Public Function ReadAll() As Object
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

    Public Sub Read(ByRef ar As Artist)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM Artists WHERE ArtistName='" & ar.GetName() & "';")
        For Each aux In col
            ar.SetName(aux(2).ToString)
            ar.SetCountry(aux(3).ToString)
        Next
    End Sub

    Public Function Insert(ByVal ar As Artist) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO Artists (artistName, artistCountry) VALUES ('" & ar.GetName() & "' ,(SELECT idCountry FROM country WHERE idCountry='" & ar.GetCountry() & "'));")
    End Function

    Public Function Update(ByVal ar As Artist) As Integer
        'Return DBBroker.GetBroker.Change("UPDATE Artists SET ArtistName='" & ar.GetName() & "', ArtistCountry = (SELECT idCountry FROM Country WHERE CountryName = '" & countryName & "') WHERE idArtist=" & ar.GetIdArtist & ";")

    End Function

    Public Function Delete(ByVal ar As Artist) As Integer
        Return DBBroker.GetBroker.Change("DELETE FROM Artists WHERE ArtistName='" & ar.artistName() & "';")
    End Function

End Class