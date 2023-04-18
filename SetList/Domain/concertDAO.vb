Public Class ConcertDAO
    Public ReadOnly Property Concerts As Collection

    Public Sub New()
        Me.Concerts = New Collection
    End Sub

    Public Function ReadAll() As Object
        Dim concert As Concert
        Dim col, aux As Collection
        col = DBBroker.GetBroker().Read("SELECT * FROM Concerts ORDER BY idConcert")
        For Each aux In col
            concert = New Concert(Convert.ToInt32(aux(1).ToString), Convert.ToInt32(aux(2).ToString), Convert.ToInt32(aux(3).ToString), CDate(aux(4).ToString))
            Me.Concerts.Add(concert)
        Next
        Return Concerts
    End Function

    Public Sub Read(ByRef concert As Concert)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM Concerts WHERE idConcert='" & concert.idConcert & "';")
        For Each aux In col
            concert.SetArtist(Convert.ToInt32(aux(2).ToString))
            concert.SetVenue(Convert.ToInt32(aux(3).ToString))
            concert.SetDate(CDate(aux(4).ToString))
        Next
    End Sub

    Public Function ReadAllArtistConcerts(ByRef concert As Concert) As Object
        Dim co As Concert
        Dim col, aux As Collection
        col = DBBroker.GetBroker().Read("SELECT * FROM Concerts WHERE Artist=" & concert.ArtistName & ";")
        For Each aux In col
            co = New Concert(Convert.ToInt32(aux(1).ToString))
            co.ArtistName = Convert.ToInt32(aux(2).ToString)
            co.VenueName = Convert.ToInt32(aux(3).ToString)
            co.concertDate = CDate(aux(4).ToString)
            Me.Concerts.Add(co)
        Next
        Return Concerts
    End Function

    Public Function ReadAllVenueConcerts(ByRef concert As Concert) As Object
        Dim co As Concert
        Dim col, aux As Collection
        col = DBBroker.GetBroker().Read("SELECT * FROM Concerts WHERE Venue=" & concert.VenueName & ";")
        For Each aux In col
            co = New Concert(Convert.ToInt32(aux(1).ToString))
            co.ArtistName = Convert.ToInt32(aux(2).ToString)
            co.VenueName = Convert.ToInt32(aux(3).ToString)
            co.concertDate = CDate(aux(4).ToString)
            Me.Concerts.Add(co)
        Next
        Return Concerts
    End Function

    Public Sub ReadSetlist(ByRef concert As Concert)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM setlists WHERE Concert=" & concert.idConcert & " ORDER BY OrderInSetlist;")
        For Each aux In col
            concert.SetList.Add(Convert.ToInt32(aux(2).ToString))
        Next
    End Sub

    Public Sub ReadByArtistAndVenue(ByRef concert As Concert)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM Concerts WHERE Artist='" & concert.GetArtist() & "' AND Venue= '" & concert.GetVenue() & "';")
        For Each aux In col
            concert.SetIdConcert(Convert.ToInt32(aux(1).ToString))
            concert.SetArtist(Convert.ToInt32(aux(2).ToString))
            concert.SetVenue(Convert.ToInt32(aux(3).ToString))
            concert.SetDate(CDate(aux(4).ToString))
        Next
    End Sub

    Public Function Insert(ByVal concert As Concert) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO Concerts (Artist, Venue, ConcertDate) VALUES (" & concert.GetArtist() & " ," & concert.GetVenue & ",'" & concert.GetDate.ToString("yyyy/MM/dd") & "');")
    End Function

    Public Function InsertSetlist(ByVal concert As Concert) As Integer
        For i As Integer = 1 To concert.SetList.Count
            Dim songToInsert As Integer = Convert.ToInt32(concert.SetList.Item(i))
            DBBroker.GetBroker.Change("INSERT INTO setlists (Concert,Song,OrderInSetlist) VALUES (" & concert.idConcert & "," & songToInsert & "," & i & ");")
        Next
    End Function

    Public Function Update(ByVal concert As Concert) As Integer
        Return DBBroker.GetBroker.Change("UPDATE Concerts SET ConcertDate='" & concert.GetDate.ToString("yyyy/MM/dd") & "' ,Artist='" & concert.GetArtist() & "' ,Venue='" & concert.GetVenue() & "'WHERE idConcert=" & concert.GetConcert() & ";")
    End Function

    Public Function Delete(ByVal concert As Concert) As Integer
        Return DBBroker.GetBroker.Change("DELETE FROM Concerts WHERE idConcert=" & concert.GetConcert() & ";")
    End Function

    Public Function DeteleSetlist(ByVal concert As Concert) As Integer
        Return DBBroker.GetBroker.Change("DELETE FROM setlists WHERE Concert=" & concert.idConcert & ";")
    End Function

    Public Function Query3(count As Integer) As Object
        Dim nameAlbum As String
        Dim albumsOnConcert As New Collection : Dim aux As Collection
        Dim col As Collection = DBBroker.GetBroker().Read("SELECT DISTINCT ar.ArtistName FROM artists ar, albums al, songs s, setlists st, concerts c 
                                                           WHERE(al.Artist = ar.idArtist AND al.idAlbum = s.Album AND st.Song = s.idSong AND st.Concert = c.idConcert AND " & count & " = (SELECT COUNT(*) FROM songs WHERE al.idAlbum = s.idAlbum);")

        For Each aux In col
            nameAlbum = aux(1).ToString
            albumsOnConcert.Add(nameAlbum)
        Next
        Return albumsOnConcert
    End Function

End Class

