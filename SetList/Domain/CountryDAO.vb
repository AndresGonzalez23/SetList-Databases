Public Class CountryDAO
    Public ReadOnly Property Countries As Collection

    Public Sub New()
        Me.Countries = New Collection
    End Sub

    Public Function ReadAll() As Object
        Dim country As Country
        Dim col, aux As Collection
        col = DBBroker.GetBroker().Read("SELECT * FROM Country ORDER BY idCountry")
        For Each aux In col
            country = New Country(aux(1).ToString, aux(2).ToString)
            Me.Countries.Add(country)
        Next
        Return Countries
    End Function
End Class
