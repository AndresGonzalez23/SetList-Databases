Public Class SetlistDAO
    Public ReadOnly Property Setlist As Collection

    Public Sub New()
        Me.Setlist = New Collection
    End Sub

    Public Function Insert(ByVal setlist As Setlist) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO setlists (Concert,Song,OrderInSetlist) VALUES (" & setlist.setlistConcerts & "," & setlist.setlistSongs & "," & setlist.OrderInSetlist & ");")
    End Function
    Public Function Update(ByVal setlist As Setlist) As Integer
        Return DBBroker.GetBroker.Change("UPDATE setlists SET Concert=" & setlist.setlistConcerts & " ,Song=" & setlist.setlistSongs & " ,OrderInSetList=" & setlist.OrderInSetlist & "WHERE Concert=" & setlist.setlistConcerts & ";")
    End Function
    Public Function Delete(ByVal setlist As Setlist) As Integer
        Return DBBroker.GetBroker.Change("DELETE FROM setlists WHERE Concert=" & setlist.setlistConcerts & " AND Song=" & setlist.setlistSongs & ";")
    End Function
End Class
