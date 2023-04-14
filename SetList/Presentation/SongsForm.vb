﻿Public Class SongsForm

    Private song As Song
    Private previousSong As Song
    Private album As Album

    Public Sub LoadInfo()
        Dim albAux As Album
        Dim sonAux As Song

        Me.song = New Song
        Me.album = New Album
        Try
            Me.album.ReadAllAlbums()
            Me.song.ReadAllSongs()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        For Each albAux In Me.album.albDAO.Albums
            Me.lst_albums.Items.Add(albAux.albumName)
        Next
        For Each sonAux In Me.song.sonDAO.Songs
            Me.lst_songs.Items.Add(sonAux.songName)
        Next

        btn_insertSong.Enabled = True
    End Sub

    Private Sub lst_songs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_songs.SelectedIndexChanged
        btn_deleteSong.Enabled = True
        btn_updateSong.Enabled = True
        If lst_songs.SelectedItem IsNot Nothing Then
            Try
                Me.song = New Song
                song.songName = lst_songs.SelectedItem.ToString
                song.ReadSongByName()
                txt_songName.Text = song.songName
                txt_songLength.Text = song.songLength.ToString()
                Me.album = New Album
                album.idAlbum = song.songAlbum
                album.ReadAlbum()

                For Each albumSong As String In lst_albums.Items
                    If albumSong.Contains(album.albumName) Then
                        lst_albums.SelectedItem = albumSong
                        Exit For
                    End If
                Next

                txt_songOrder.Text = song.songOrder.ToString()
                Me.previousSong = New Song
                previousSong.songName = txt_songName.Text
                previousSong.ReadSongByName()

            Catch ex As Exception
                lst_songs.SelectedIndex = -1
            End Try
        End If
    End Sub

    Private Sub btn_insertSong_Click(sender As Object, e As EventArgs) Handles btn_insertSong.Click
        Dim songNew As Song

        If txt_songName.Text <> String.Empty And txt_songLength.Text <> String.Empty And txt_songOrder.Text <> String.Empty Then
            songNew = New Song
            songNew.songName = txt_songName.Text
            songNew.songLength = Convert.ToInt32(txt_songLength.Text)
            Me.album = New Album
            album.albumName = lst_albums.SelectedItem.ToString
            album.ReadAlbumByName()
            songNew.songAlbum = album.idAlbum
            songNew.songOrder = Convert.ToInt32(txt_songOrder.Text)

            Try
                If songNew.InsertSong() <> 1 Then
                    MessageBox.Show("INSERT <> -1", "CUSTOM ERROR", MessageBoxButtons.OK)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
            lst_songs.Items.Add(songNew.GetSongName)
        Else
            MessageBox.Show("name, length, album or order is empty please fill those spaces", "Custom Error", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub btn_updateSong_Click(sender As Object, e As EventArgs) Handles btn_updateSong.Click
        Me.song = New Song
        Dim UpdateSong = New Song : Dim sonAux As Song

        If MessageBox.Show("Are you sure? Do you want to update this song?", "Custom Error", MessageBoxButtons.YesNo) = DialogResult.No Then
            Exit Sub
        End If

        Try
            UpdateSong.songName = txt_songName.Text
            UpdateSong.songLength = Convert.ToInt32(txt_songLength.Text)
            Me.album = New Album
            album.albumName = lst_albums.SelectedItem.ToString
            album.ReadAlbumByName()
            UpdateSong.songAlbum = album.idAlbum
            UpdateSong.songOrder = Convert.ToInt32(txt_songOrder.Text)
            UpdateSong.idSong = previousSong.GetIdSong()

            If txt_songName.Text <> String.Empty Then
                Try
                    UpdateSong.UpdateSong()
                    MsgBox("Song Update Succesfull")
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End Try
                lst_songs.Items.Clear()
                song.ReadAllSongs()

                For Each sonAux In Me.song.sonDAO.Songs
                    Me.lst_songs.Items.Add(sonAux.songName)
                Next

            Else
                MessageBox.Show("Unable to update information, all needed fields must be filled", "Custom Error", MessageBoxButtons.OK)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_deleteSong_Click(sender As Object, e As EventArgs) Handles btn_deleteSong.Click
        If MessageBox.Show("Are you sure? Do you want to delete permanetly this song?", "Custom Error", MessageBoxButtons.YesNo) = DialogResult.No Then
            Exit Sub
        End If

        If txt_songName.Text <> String.Empty Then
            song.songName = txt_songName.Text
            song.ReadSongByName()

            If song.songName <> txt_songName.Text.Trim() Then
                MessageBox.Show("This is not the same name", "Custom Error", MessageBoxButtons.OK)
                Exit Sub
            End If
            Try
                If song.DeleteSong() <> 1 Then
                    MessageBox.Show("INSERT <> -1", "Custom Error", MessageBoxButtons.OK)
                End If
            Catch ex As Exception
                MessageBox.Show("Song deleted", ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try

            Me.lst_songs.Items.Remove(song.songName)
        Else
            MessageBox.Show("Unable to delete information, all needed fields must be filled", "Custom Error", MessageBoxButtons.OK)
        End If
    End Sub

End Class