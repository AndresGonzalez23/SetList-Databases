Public Class AlbumForm

    Private artist As Artist
    Private album As Album
    Private previousAlbum As Album

    Private albumArtist As Integer

    Public Sub LoadInfo()
        Dim albAux As Album
        Dim aAux As Artist

        Me.artist = New Artist
        Me.album = New Album
        Try
            Me.album.ReadAllAlbums()
            Me.artist.ReadAllArtists()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        For Each albAux In Me.album.albDAO.Albums
            Me.lst_albums.Items.Add(albAux.albumName)
        Next
        For Each aAux In Me.artist.artistsDAO.Artists
            Me.lst_artists.Items.Add(aAux.artistName)
        Next

        btn_insertAlbum.Enabled = True
    End Sub

    Private Sub lst_albums_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_albums.SelectedIndexChanged
        btn_deleteAlbum.Enabled = True
        btn_updateAlbum.Enabled = True

        If lst_albums.SelectedItem IsNot Nothing Then
            Try
                Me.album = New Album
                album.albumName = lst_albums.SelectedItem.ToString
                album.ReadAlbumByName()
                txt_albumName.Text = album.albumName
                txt_albumYear.Text = album.albumYear.ToString()
                Me.artist = New Artist
                artist.IdArtist = album.albumArtist
                artist.ReadArtist()

                For Each artista As String In lst_artists.Items
                    If artista.Contains(artist.artistName) Then
                        lst_artists.SelectedItem = artista
                        Exit For
                    End If
                Next

                Me.previousAlbum = New Album
                previousAlbum.albumName = txt_albumName.Text
                previousAlbum.ReadAlbumByName()

            Catch ex As Exception
                lst_albums.SelectedIndex = -1
            End Try
        End If
    End Sub

    Private Sub btn_insertAlbum_Click(sender As Object, e As EventArgs) Handles btn_insertAlbum.Click
        Dim albumNew As Album
        If txt_albumName.Text <> String.Empty And txt_albumYear.Text <> String.Empty Then
            albumNew = New Album
            albumNew.albumName = txt_albumName.Text
            albumNew.albumYear = Convert.ToInt32(txt_albumYear.Text)
            Me.artist = New Artist
            artist.artistName = lst_artists.SelectedItem.ToString
            artist.ReadArtistByName()
            albumNew.albumArtist = artist.GetIdArtist()

            Try
                If albumNew.InsertAlbum() <> 1 Then
                    MessageBox.Show("INSERT <> -1", "CUSTOM ERROR", MessageBoxButtons.OK)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
            lst_albums.Items.Add(albumNew.GetAlbumName)
        Else
            MessageBox.Show("Name, year or artist are empty please fill those spaces", "Custom Error", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub btn_updateAlbum_Click(sender As Object, e As EventArgs) Handles btn_updateAlbum.Click
        Me.album = New Album
        Dim UpdateAlbum = New Album
        Dim albAux As Album

        If MessageBox.Show("Are you sure? Do you want to update this album?", "Custom Error", MessageBoxButtons.YesNo) = DialogResult.No Then
            Exit Sub
        End If

        Try
            UpdateAlbum.albumName = txt_albumName.Text
            UpdateAlbum.albumYear = Convert.ToInt32(txt_albumYear.Text)
            Me.artist = New Artist
            artist.artistName = lst_artists.SelectedItem.ToString
            artist.ReadArtistByName()
            UpdateAlbum.albumArtist = artist.IdArtist
            UpdateAlbum.idAlbum = previousAlbum.GetIdAlbum()


            If txt_albumName.Text <> String.Empty And txt_albumYear.Text <> String.Empty Then
                Try
                    UpdateAlbum.UpdateAlbum()
                    MsgBox("Album Update Succesfully")
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End Try
                lst_albums.Items.Clear()
                album.ReadAllAlbums()
                For Each albAux In Me.album.albDAO.Albums
                    Me.lst_albums.Items.Add(albAux.albumName)
                Next

            Else
                MessageBox.Show("Unable to update information, all needed fields must be filled", "Custom Error", MessageBoxButtons.OK)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_deleteAlbum_Click(sender As Object, e As EventArgs) Handles btn_deleteAlbum.Click
        If MessageBox.Show("Are you sure? Do you want to delete permanetly this album?", "Custom Error", MessageBoxButtons.YesNo) = DialogResult.No Then
            Exit Sub
        End If

        If txt_albumName.Text <> String.Empty Then

            album.albumName = txt_albumName.Text
            album.ReadAlbumByName()

            If album.albumName <> txt_albumName.Text.Trim() Then
                MessageBox.Show("This is not the same name", "Custom Error", MessageBoxButtons.OK)
                Exit Sub
            End If
            Try
                If album.DeleteAlbum() <> 1 Then
                    MessageBox.Show("INSERT <> -1", "Custom Error", MessageBoxButtons.OK)
                End If
            Catch ex As Exception
                MessageBox.Show("Album deleted", ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try

            Me.lst_albums.Items.Remove(album.albumName)
        Else
            MessageBox.Show("Unable to delete information, all needed fields must be filled", "Custom Error", MessageBoxButtons.OK)
        End If
    End Sub


End Class