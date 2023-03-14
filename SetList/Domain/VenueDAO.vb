﻿Public Class VenueDAO
    Public ReadOnly Property Venues As Collection

    Public Sub New()
        Me.Venues = New Collection
    End Sub

    Public Function ReadAll() As Object
        Dim v As Venue
        Dim col, aux As Collection
        col = DBBroker.GetBroker().Read("SELECT * FROM Venues ORDER BY idVenue")
        For Each aux In col
            v = New Venue(CInt(aux(1).ToString), aux(2).ToString, aux(3).ToString, aux(4).ToString)
            Me.Venues.Add(v)
        Next
        Return Venues
    End Function

    Public Sub Read(ByRef v As Venue)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM Venues WHERE idVenue='" & v.getidVenue() & "';")
        For Each aux In col
            v.setVenueName(aux(2).ToString)
            v.setVenueCountry(aux(3).ToString)
            v.setVenueType(aux(4).ToString)
        Next
    End Sub

    Public Function Insert(ByVal v As Venue) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO Venues ([venueName],[venueCountry],[venueType]) VALUES ('" & v.getVenueName() & "','" & v.getVenueCountry() & "','" & v.getVenueType() & "','" & "');")
    End Function
    Public Function Update(ByVal v As Venue) As Integer
        Return DBBroker.GetBroker.Change("UPDATE Venues SET [venueName]='" & v.getVenueName() & "' ,[venueCountry]='" & v.getVenueCountry() & "' ,[venueType]='" & v.getVenueType() & "'WHERE idVenue=" & v.getidVenue & ";")
    End Function
    Public Function Delete(ByVal v As Venue) As Integer
        Return DBBroker.GetBroker.Change("DELETE FROM Venues WHERE idVenue=" & v.getidVenue() & ";")
    End Function
End Class