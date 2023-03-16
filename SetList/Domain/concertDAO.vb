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
            concert = New Concert(CInt(aux(1).ToString), CDate(aux(2).ToString), CInt(aux(3).ToString), CInt(aux(4).ToString))
            Me.Concerts.Add(concert)
        Next
        Return Concerts
    End Function

    Public Sub Read(ByRef concert As Concert)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM Concerts WHERE idConcert='" & concert.GetConcert() & "';")
        For Each aux In col
            concert.SetDate(CDate(aux(2).ToString))
            concert.SetArtist(CInt(aux(3).ToString))
            concert.SetVenue(CInt(aux(4).ToString))
        Next
    End Sub

    Public Function Insert(ByVal concert As Concert) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO Concerts ([concertDate],[Artist],[Venue]) VALUES ('" & concert.GetDate() & "','" & concert.GetArtist & "','" & concert.GetVenue & "','" & "');")
    End Function
    Public Function Update(ByVal concert As Concert) As Integer
        Return DBBroker.GetBroker.Change("UPDATE Concerts SET [concertDate]='" & concert.GetDate & "' ,[Artist]='" & concert.GetArtist() & "' ,[Venue]='" & concert.GetVenue() & "'WHERE idConcert=" & concert.GetConcert() & ";")
    End Function
    Public Function Delete(ByVal concert As Concert) As Integer
        Return DBBroker.GetBroker.Change("DELETE FROM Concerts WHERE idVenue=" & concert.GetArtist() & ";")
    End Function
End Class

