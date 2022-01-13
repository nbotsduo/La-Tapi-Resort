Imports System.Data.OleDb

Public Class frmBookHall

    Public Property conHall As New OleDbConnection
    Public Property username As String

    Private Sub frmBookHall_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Get Customer Information
        Dim strSql As String = "SELECT * FROM Customer WHERE [Cust_Username] ='" & username & "'"
        Dim strPath As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Naim\Documents\sem 5\vb\LaTapiResort\la_tapi_resort.accdb;"
        Dim odaGuest As New OleDb.OleDbDataAdapter(strSql, strPath)
        Dim guestValue As New DataTable
        odaGuest.Fill(guestValue)
        odaGuest.Dispose()

        'Get hall id
        strSql = "SELECT * FROM Hall WHERE [Hall_Name] ='" & cbType.SelectedItem.ToString() & "'"
        Dim odaHall As New OleDb.OleDbDataAdapter(strSql, strPath)
        Dim hallValue As New DataTable
        odaHall.Fill(hallValue)
        odaHall.Dispose()

        Try
            Dim sqlQuery As New OleDb.OleDbCommand
            sqlQuery.Connection = conHall
            sqlQuery.CommandText = "INSERT INTO Reservation([Reser_Type],[Reser_Name],[Reser_Qty],[Reser_Date],[Reser_Duration],[Cust_ID],[Room_ID],[Reser_AddReq],[Hall_ID],[Cafe_ID] )
                                    VALUES(@resType,@resName,@resQuantity,@resDate,@resDuration,@guestID,@roomID,@addReq,@hallID,@cafeID)"

            sqlQuery.Parameters.AddWithValue("@resType", "Hall")
            sqlQuery.Parameters.AddWithValue("@resName", cbType.SelectedItem.ToString())
            sqlQuery.Parameters.AddWithValue("@resQuantity", 1)
            sqlQuery.Parameters.AddWithValue("@resDate", dtHall.Value)
            sqlQuery.Parameters.AddWithValue("@resDuration", Convert.ToInt32(txtDurHall.Text))
            sqlQuery.Parameters.AddWithValue("@guestID", Convert.ToInt32(guestValue.Rows(0)("Cust_ID")))
            sqlQuery.Parameters.AddWithValue("@roomID", 0)


            '-----null--------------------
            sqlQuery.Parameters.AddWithValue("@addReq", txtReq.Text)
            sqlQuery.Parameters.AddWithValue("@hallID", Convert.ToInt32(hallValue.Rows(0)("Hall_ID")))
            sqlQuery.Parameters.AddWithValue("@cafeID", 0)

            MsgBox("Booking saved!", MsgBoxStyle.Information, "Done!")
            frmUserHome.Show()
            Me.Close()
            sqlQuery.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        cbType.Items.Clear()
        txtDurHall.Text = ""
        txtReq.Text = ""
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frmUserHome.Show()
        Me.Hide()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        frmUserHome.Show()
        Me.Hide()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        frmLogin.Show()
        Me.Hide()
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Application.Exit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmListHall.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frmEditHall.username = username
        frmEditHall.Show()
    End Sub
End Class