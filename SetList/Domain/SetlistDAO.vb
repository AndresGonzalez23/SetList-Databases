Public Class SetlistDAO
    Public ReadOnly Property Setlist As Collection

    Public Sub New()
        Me.Setlist = New Collection
    End Sub

    Public Function Insert(ByVal setlist As Setlist) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO setlists (Concert,Song,OrderInSetlist) VALUES (" & setlist.setlistConcerts & "," & setlist.setlistSongs & "," & setlist.OrderInSetlist & ");")
    End Function
End Class
