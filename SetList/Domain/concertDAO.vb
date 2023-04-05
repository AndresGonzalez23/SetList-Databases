﻿Public Class ConcertDAO
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
        col = DBBroker.GetBroker.Read("SELECT * FROM Concerts WHERE idConcert='" & concert.GetConcert() & "';")
        For Each aux In col
            concert.SetArtist(Convert.ToInt32(aux(2).ToString))
            concert.SetVenue(Convert.ToInt32(aux(3).ToString))
            concert.SetDate(CDate(aux(4).ToString))
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
    Public Function Update(ByVal concert As Concert) As Integer
        Return DBBroker.GetBroker.Change("UPDATE Concerts SET [concertDate]='" & concert.GetDate & "' ,[Artist]='" & concert.GetArtist() & "' ,[Venue]='" & concert.GetVenue() & "'WHERE idConcert=" & concert.GetConcert() & ";")
    End Function
    Public Function Delete(ByVal concert As Concert) As Integer
        Return DBBroker.GetBroker.Change("DELETE FROM Concerts WHERE idConcert=" & concert.GetConcert() & ";")
    End Function
End Class

