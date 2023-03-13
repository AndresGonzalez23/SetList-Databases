Public Class Venue
    Private Property idVenue As Integer
    Private Property venueName As String
    Private Property venueCountry As String
    Private Property venueType As String
    Private vDao As VenueDAO

    Public Sub New()
        Me.vDao = New VenueDAO
    End Sub

    Public Sub New(id As Integer, vName As String, vCountry As String, vType As String)
        Me.vDao = New VenueDAO
        idVenue = id
        venueName = vName
        venueCountry = vCountry
        venueType = vType
    End Sub

    Public Function getidVenue() As Integer
        Return idVenue
    End Function
    Public Function getVenueName() As String
        Return venueName
    End Function
    Public Function getVenueCountry() As String
        Return venueCountry
    End Function
    Public Function getVenueType() As String
        Return venueType
    End Function
    Public Function setidVenue(id As Integer) As Integer
        idVenue = id
    End Function
    Public Function setVenueName(vName As String) As String
        venueName = vName
    End Function
    Public Function setVenueCountry(vCountry As String) As String
        venueCountry = vCountry
    End Function
    Public Function setVenueType(vType As String) As String
        venueType = vType
    End Function
End Class
