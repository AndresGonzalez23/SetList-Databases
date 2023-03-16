Public Class Country
    Private Property idCountry As String
    Private Property countryName As String

    Private couDao As CountryDAO

    Public Sub New()
        Me.couDao = New CountryDAO
    End Sub

    Public Sub New(idCou As String, couName As String)
        Me.couDao = New CountryDAO
        idCountry = idCou
        countryName = couName
    End Sub

    Public Function GetIdCountry() As String
        Return idCountry
    End Function

    Public Function GetCountryName() As String
        Return countryName
    End Function

    Public Function SetIdCountry(idCou As String) As String
        idCountry = idCou
    End Function

    Public Function SetCountryName(couName As String) As String
        countryName = couName
    End Function

End Class
