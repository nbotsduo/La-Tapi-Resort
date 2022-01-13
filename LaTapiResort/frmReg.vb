Imports System.Data.OleDb
Public Class frmReg
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        frmLogin.Show()
        Me.Close()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Try
            Dim con As New OleDbConnection


            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Naim\Documents\sem 5\vb\LaTapiResort\la_tapi_resort.accdb;"
            con.Open()
            Dim sqlQuery As New OleDb.OleDbCommand
            sqlQuery.Connection = con
            sqlQuery.CommandText = "INSERT INTO Customer([Cust_Name],[Cust_IC],[Cust_Nationality],[Cust_Username],[Cust_Password],[Cust_Email])
                                    VALUES(@custName,@custIC,@custNat,@custUser,@custPass,@custEmail)"

            sqlQuery.Parameters.AddWithValue("@custName", txtName.Text)
            sqlQuery.Parameters.AddWithValue("@custIC", txtIC.Text)
            sqlQuery.Parameters.AddWithValue("@custNat", txtNationality.Text)
            sqlQuery.Parameters.AddWithValue("@custUser", txtUsername.Text)
            sqlQuery.Parameters.AddWithValue("@custPass", txtPassword.Text)
            sqlQuery.Parameters.AddWithValue("@custEmail", txtEmail.Text)


            MsgBox("Registration Complete! Please login", MsgBoxStyle.Information, "Done!")
            frmLogin.Show()
            Me.Close()
            sqlQuery.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class