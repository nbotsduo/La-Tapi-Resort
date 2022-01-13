
Imports System.Data.OleDb
Public Class frmLogin

    Dim Admin_Username As String

    '------------User Login----------
    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click

        Dim con As New OleDbConnection
        Dim username As String

        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Naim\Documents\sem 5\vb\LaTapiResort\la_tapi_resort.accdb;"
        con.Open()
        frmBookHall.conHall = con
        frmBookRoom.conRoom = con
        frmBookCafe.conCafe = con
        frmEditCafe.conCafe = con
        frmEditHall.conHall = con
        frmEditRoom.conRoom = con
        Dim logincmd As OleDbCommand = New OleDbCommand("Select * from Customer where [Cust_Username]='" & txtUsername.Text & "' and [Cust_Password]='" & txtPassword.Text & "'", con)

        Dim loginrd As OleDbDataReader = logincmd.ExecuteReader

        If (loginrd.Read() = True) Then
            username = txtUsername.Text
            frmUserHome.username = username
            frmBookRoom.username = username
            frmBookHall.username = username
            frmBookCafe.username = username
            frmEditCafe.username = username
            frmEditHall.username = username
            frmEditRoom.username = username

            Dim gID As Integer
            'Get Customer Information
            Dim strSql As String = "SELECT * FROM Customer WHERE [Cust_Username] ='" & username & "'"
            Dim odaGuest As New OleDb.OleDbDataAdapter(strSql, con)
            Dim guestValue As New DataTable
            odaGuest.Fill(guestValue)
            odaGuest.Dispose()
            gID = guestValue.Rows(0)("Cust_ID")

            'frmEditRoom.id = gID
            frmEditHall.id = gID
            frmEditCafe.id = gID
            frmBookRoom.id = gID

            Me.Hide()
            frmUserHome.Show()
            'logincmd.Dispose()
            'con.Dispose()
            txtUsername.Clear()
            txtPassword.Clear()
            MsgBox("Login Successfull",, username)
        Else
            MsgBox("Login Failed!", MsgBoxStyle.Critical)

        End If


    End Sub


    '----------Admin Login-------------------
    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click

        'Dim pass As New frmAdminHome
        Dim con2 As New OleDbConnection

        con2.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Naim\Documents\sem 5\vb\LaTapiResort\la_tapi_resort.accdb;"
        con2.Open()

        Dim logincmd As OleDbCommand = New OleDbCommand("Select * from Admin where [Admin_Username]='" & txtUsername.Text & "' and [Admin_Password]='" & txtPassword.Text & "'", con2)

        Dim loginrd As OleDbDataReader = logincmd.ExecuteReader

        Admin_Username = txtUsername.Text


        If (loginrd.Read() = True) Then


            frmAdminHome.AdminName = Admin_Username
            frmAdminHome.Show()
            Me.Hide()
            txtUsername.Clear()
            txtPassword.Clear()
            MsgBox("Login Successfull", MsgBoxStyle.Information)
            logincmd.Dispose()

        Else
            MsgBox("Login Failed!", MsgBoxStyle.Critical)

        End If

    End Sub

    Private Sub lblRegister_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblRegister.LinkClicked

        frmReg.Show()
        Me.Hide()
    End Sub
End Class
