Public Class SongDAO
    Public ReadOnly Property Songs As Collection

    Public Sub New()
        Me.Songs = New Collection
    End Sub

    Public Function ReadAll() As Object
        Dim so As Song
        Dim col, aux As Collection
        col = DBBroker.GetBroker().Read("SELECT * FROM Songs ORDER BY idSong")
        For Each aux In col
            so = New Song(Convert.ToInt32(aux(1).ToString))
            so.SetSongName(aux(2).ToString)
            so.songLength = Convert.ToInt32(aux(3).ToString)
            so.songAlbum = Convert.ToInt32(aux(1).ToString)
            so.songOrder = Convert.ToInt32(aux(5).ToString)
            Me.Songs.Add(so)
        Next
        Return Songs
    End Function

    Public Sub Read(ByRef so As Song)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM Songs WHERE idSong='" & so.GetIdSong() & "';")
        For Each aux In col
            so.SetSongName(aux(2).ToString)
            so.songLength = Convert.ToInt32(aux(3).ToString)
            so.songAlbum = Convert.ToInt32(aux(4).ToString)
            so.songOrder = Convert.ToInt32(aux(5).ToString)
        Next
    End Sub

    Public Sub ReadByName(ByRef so As Song)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM Songs WHERE SongName='" & so.GetSongName() & "';")
        For Each aux In col
            so.idSong = Convert.ToInt32(aux(1).ToString)
            so.SetSongName(aux(2).ToString)
            so.songLength = Convert.ToInt32(aux(3).ToString)
            so.songAlbum = Convert.ToInt32(aux(4).ToString)
            so.songOrder = Convert.ToInt32(aux(5).ToString)
        Next
    End Sub

    Public Function Insert(ByVal so As Song) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO Songs (SongName, SongLength, Album, SongOrder) VALUES ('" & so.GetSongName() & "' ," & so.GetSongLength() & "," & so.GetSongAlbum() & "," & so.GetSongOrder() & ");")
    End Function

    Public Function Update(ByVal so As Song) As Integer
        Return DBBroker.GetBroker.Change("UPDATE Songs SET SongName='" & so.GetSongName() & "', SongLength=" & so.GetSongLength() & ", Album=" & so.GetSongAlbum() & ", SongOrder=" & so.GetSongOrder() & " " & "WHERE idSong=" & so.GetIdSong() & ";")

    End Function

    Public Function Delete(ByVal so As Song) As Integer
        Return DBBroker.GetBroker.Change("DELETE FROM Songs WHERE SongName='" & so.GetSongName() & "';")
    End Function

End Class