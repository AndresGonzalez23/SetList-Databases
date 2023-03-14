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
            c.setDate(CDate(aux(2).ToString))
            c.setArtist(CInt(aux(3).ToString))
            c.setVenue(CInt(aux(4).ToString))
        Next
    End Sub


End Class

