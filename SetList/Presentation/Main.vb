Public Class Main
    Private concert As Concert
    Private Sub lst_concert_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_concert.SelectedIndexChanged
        btnDelete.Enabled = True
        btnUpdate.Enabled = True
        If lst_concert.SelectedItem IsNot Nothing Then
            Try
                Me.p = New Person
                p.PersonID = lst_concert.SelectedItem.ToString
                p.ReadPerson()
                txtID.Text = p.PersonID
                txtName.Text = p.PersonName
            Catch ex As Exception
                lst_concert.SelectedIndex = -1
            End Try
        End If
    End Sub

    Private Sub btn_insert_concert_Click(sender As Object, e As EventArgs) Handles btn_insert_concert.Click
        If txtID.Text <> String.Empty And txtName.Text <> String.Empty Then
            concert = New Person(txtID.Text)
            concert.PersonName = txtName.Text
            Try
                If Me.concert.InsertConcert() <> 1 Then
                    MessageBox.Show("INSERT <> -1", "Custom Error", MessageBoxButtons.OK)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
            Me.lst_concert.Items.Add(concert.id)
        Else
            MessageBox.Show("Id and Name were empty, please fill those spaces", "Custom Error", MessageBoxButtons.OK)
        End If
    End Sub
End Class