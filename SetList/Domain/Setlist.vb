Public Class Setlist
    Public Property setlistConcerts As Integer
    Public Property setlistSongs As Integer
    Public Property OrderInSetlist As Integer
    Public ReadOnly Property setDAO As SetlistDAO

    Public Sub New()
        Me.setDAO = New SetlistDAO
    End Sub

    Public Function InsertSetlist() As Integer
        Return Me.setDAO.Insert(Me)
    End Function


End Class
