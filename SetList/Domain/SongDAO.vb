Public Class SongDAO
    Public ReadOnly Property Songs As Collection

    Public Sub New()
        Me.Songs = New Collection
    End Sub

    Public Function ReadAll(path As String) As Object
        Dim s As Song
        Dim col, aux As Collection
        col = DBBroker.GetBroker().Read("SELECT * FROM Songs ORDER BY IdSong")
        For Each aux In col
            s = New Song(CInt(aux(1)))
            s.SetName(aux(2).ToString)
            s.SetAlbum(CInt(aux(3)))
            s.SetLength(CInt(aux(4)))
            Me.Songs.Add(s)
        Next
        Return Songs
    End Function

    Public Function Insert(ByVal s As Song) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO Songs ([sName],Album,length) VALUES ('" & s.GetName() & "','" & s.GetAlbum() & "','" & s.GetLength() & "');")
    End Function
    Public Function Update(ByVal s As Song) As Integer
        Return DBBroker.GetBroker.Change("UPDATE Songs SET sName='" & s.GetName() & "' ,Album='" & s.GetAlbum() & "' ,length='" & s.GetLength() & "'WHERE IdSong=" & s.GetIdSong() & ";")
    End Function
    Public Function Delete(ByVal s As Song) As Integer
        Return DBBroker.GetBroker.Change("DELETE FROM Songs WHERE IdSong=" & s.GetIdSong() & ";")
    End Function

End Class
