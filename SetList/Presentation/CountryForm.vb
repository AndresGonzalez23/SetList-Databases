Public Class CountryForm

    Private country As Country


    Public Sub LoadInfo()
        Dim cAux As Country
        Me.country = New Country
        Try
            Me.country.ReadAllCountries()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        For Each cAux In Me.country.counDAO.Countries
            Me.lst_Countries.Items.Add(cAux.countryName)
        Next
        btn_insert_country.Enabled = True

    End Sub

    Private Sub lst_Countries_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_Countries.SelectedIndexChanged
        btn_delete_country.Enabled = True
        btn_update_country.Enabled = True
        If lst_Countries.SelectedItem IsNot Nothing Then
            Try
                Me.country = New Country
                country.idCountry = lst_Countries.SelectedItem.ToString.Substring(0, 3)
                country.ReadCountry()
                txtName.Text = country.countryName

            Catch ex As Exception
                lst_Countries.SelectedIndex = -1
            End Try
        End If
    End Sub

    Private Sub btn_insert_country_Click(sender As Object, e As EventArgs) Handles btn_insert_country.Click
        Dim countryNew As New Country
        Dim thirdChar As String
        Dim auxCountryName As String

        If txtName.Text <> String.Empty Then
            countryNew = New Country
            countryNew.countryName = txtName.Text
            auxCountryName = txtName.Text
            thirdChar = auxCountryName.Substring(0, 3)
            countryNew.idCountry = thirdChar.ToUpper

            Try
                If countryNew.InsertCountry() <> 1 Then
                    MessageBox.Show("INSERT <> -1", "CUSTOM ERROR", MessageBoxButtons.OK)
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
            lst_Countries.Items.Add(countryNew.countryName)
            txtName.Clear()

        Else
            MessageBox.Show("Id and Name were empty, please fill those spaces", "Custom Error", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub btn_update_country_Click(sender As Object, e As EventArgs) Handles btn_update_country.Click
        Me.country = New Country
        Dim CountryUpdate = New Country
        Dim cAux As Country
        If MessageBox.Show("Are you sure? Do you want to update this country?", "Custom Error", MessageBoxButtons.YesNo) = DialogResult.No Then
            Exit Sub
        End If
        Try
            Me.country = New Country
            country.countryName = lst_Countries.SelectedItem.ToString
            country.ReadCountryByName()

            If txtName.Text <> String.Empty Then
                CountryUpdate.idCountry = txtName.Text.Substring(0, 3)
                CountryUpdate.countryName = txtName.Text
                Try
                    country.DeleteCountry()
                    CountryUpdate.InsertCountry()
                    MsgBox("Country Updated succesfully")

                Catch ex As Exception
                    MessageBox.Show("This country is part of a concert and cannot be updated")
                End Try

                lst_Countries.Items.Clear()
                country.ReadAllCountries()

                For Each cAux In Me.country.counDAO.Countries
                    Me.lst_Countries.Items.Add(cAux.countryName)
                Next

            Else
                MessageBox.Show("Unable to update information, all needed fields must be filled", "Custom Error", MessageBoxButtons.OK)
            End If

        Catch ex As Exception
            MessageBox.Show("This country is part of a concert and cannot be updated")
        End Try

    End Sub

    Private Sub btn_delete_country_Click(sender As Object, e As EventArgs) Handles btn_delete_country.Click

        If MessageBox.Show("Are you sure? Do you want to delete permanetly this country?", "Custom Error", MessageBoxButtons.YesNo) = DialogResult.No Then
            Exit Sub
        End If
        If txtName.Text <> String.Empty Then
            Me.country = New Country

            Country.countryName = txtName.Text
            country.ReadCountryByName()
            If Country.countryName <> txtName.Text.Trim() Then
                MessageBox.Show("This is not the same name", "Custom Error", MessageBoxButtons.OK)
                Exit Sub
            End If
            Try
                If Country.DeleteCountry() <> 1 Then
                    MessageBox.Show("INSERT <> -1", "Custom Error", MessageBoxButtons.OK)
                End If
            Catch ex As Exception
                MessageBox.Show("Country deleted", ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
            Me.lst_Countries.Items.Remove(country.countryName)
            txtName.Clear()

        Else
            MessageBox.Show("Unable to delete information, all needed fields must be filled", "Custom Error", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub btn_clean_Click(sender As Object, e As EventArgs) Handles btn_clean.Click
        txtName.Clear()

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Dim Form1 As New Main
        Form1.Show()
        Me.Hide()
    End Sub
End Class