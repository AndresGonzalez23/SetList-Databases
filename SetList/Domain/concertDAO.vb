Public Class ConcertDAO
    Public ReadOnly Property Concerts As Collection

    Public Sub New()
        Me.Concerts = New Collection
    End Sub

    Public Function ReadAll() As Object
        Dim c As Concert
        Dim col, aux As Collection
        col = DBBroker.GetBroker().Read("SELECT * FROM Concerts ORDER BY idConcert")
        For Each aux In col
            c = New Concert(CInt(aux(1).ToString), CDate(aux(2).ToString), CInt(aux(3).ToString), CInt(aux(4).ToString))
            Me.Concerts.Add(c)
        Next
        Return Concerts
    End Function

    Public Sub Read(ByRef c As Concert)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM Concerts WHERE idConcert='" & c.getConcert() & "';")
        For Each aux In col
            c.SetDate(CDate(aux(2).ToString))
            c.SetArtist(CInt(aux(3).ToString))
            c.SetVenue(CInt(aux(4).ToString))
        Next
    End Sub

    Public Function Insert(ByVal c As Concert) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO Concerts ([concertDate],[Artist],[Venue]) VALUES ('" & c.GetDate() & "','" & c.GetArtist & "','" & c.GetVenue & "','" & "');")
    End Function
    Public Function Update(ByVal c As Concert) As Integer
        Return DBBroker.GetBroker.Change("UPDATE Concerts SET [concertDate]='" & c.GetDate & "' ,[Artist]='" & c.GetArtist() & "' ,[Venue]='" & c.GetVenue() & "'WHERE idConcert=" & c.GetConcert() & ";")
    End Function
    Public Function Delete(ByVal c As Concert) As Integer
        Return DBBroker.GetBroker.Change("DELETE FROM Concerts WHERE idVenue=" & c.GetArtist() & ";")
    End Function
End Class

