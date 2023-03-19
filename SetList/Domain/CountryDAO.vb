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

    Public Sub Read(ByRef country As Country)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM Country WHERE idCountry='" & country.GetIdCountry & "';")
        For Each aux In col
            country.SetCountryName(aux(2).ToString)
        Next
    End Sub

    Public Function Insert(ByVal country As Country) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO Country (idCountry,countryName) VALUES ('" & country.GetIdCountry() & "','" & country.GetCountryName() & "');")
    End Function

    Public Function Update(ByVal country As Country) As Integer
        Return DBBroker.GetBroker.Change("UPDATE Country SET idCountry='" & country.GetIdCountry() & "',countryName='" & country.GetCountryName() & "'WHERE idCountry=" & country.GetIdCountry() & ";")
    End Function

    Public Function Delete(ByVal country As Country) As Integer
        Return DBBroker.GetBroker.Change("DELETE FROM Country WHERE idCountry=" & country.GetIdCountry() & ";")
    End Function

End Class
