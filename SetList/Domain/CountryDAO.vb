Public Class CountryDAO
    Public ReadOnly Property Countries As Collection

    Public Sub New()
        Me.Countries = New Collection
    End Sub

    Public Function ReadAll() As Object
        Dim cou As Country
        Dim col, aux As Collection
        col = DBBroker.GetBroker().Read("SELECT * FROM Concerts ORDER BY idConcert")
        For Each aux In col
            c = New Concert(CInt(aux(1).ToString), CDate(aux(2).ToString), CInt(aux(3).ToString), CInt(aux(4).ToString))
            Me.Concerts.Add(c)
        Next
        Return Concerts
    End Function
End Class
