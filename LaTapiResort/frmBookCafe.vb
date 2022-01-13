Imports System.Data.OleDb
Public Class frmBookCafe

    Public Property conCafe As New OleDbConnection
    Public Property username As String

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frmUserHome.Show()
        Me.Hide()
    End Sub

    Private Sub frmBookCafe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblName.Text = username

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Get Customer Information
        Dim strSql As String = "SELECT * FROM Customer WHERE [Cust_Username] ='" & username & "'"
        Dim strPath As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Naim\Documents\sem 5\vb\LaTapiResort\la_tapi_resort.accdb;"
        Dim odaGuest As New OleDb.OleDbDataAdapter(strSql, strPath)
        Dim guestValue As New DataTable
        odaGuest.Fill(guestValue)
        odaGuest.Dispose()

        'Get cafe id
        strSql = "SELECT * FROM Cafe WHERE [Cafe_Name] ='" & cbType.SelectedItem.ToString() & "'"
        Dim odaHall As New OleDb.OleDbDataAdapter(strSql, strPath)
        Dim hallValue As New DataTable
        odaHall.Fill(hallValue)
        odaHall.Dispose()

        Try
            Dim sqlQuery As New OleDb.OleDbCommand
            sqlQuery.Connection = conCafe
            sqlQuery.CommandText = "INSERT INTO Reservation([Reser_Type],[Reser_Name],[Reser_Qty],[Reser_Date],[Reser_Duration],[Cust_ID],[Room_ID],[Reser_AddReq],[Hall_ID],[Cafe_ID] )
                                    VALUES(@resType,@resName,@resQuantity,@resDate,@resDuration,@guestID,@roomID,@addReq,@hallID,@cafeID)"

            sqlQuery.Parameters.AddWithValue("@resType", "Cafe")
            sqlQuery.Parameters.AddWithValue("@resName", cbType.SelectedItem.ToString())
            sqlQuery.Parameters.AddWithValue("@resQuantity", txtQty.Text)
            sqlQuery.Parameters.AddWithValue("@resDate", dtHall.Value)
            sqlQuery.Parameters.AddWithValue("@resDuration", 0)
            sqlQuery.Parameters.AddWithValue("@guestID", Convert.ToInt32(guestValue.Rows(0)("Cust_ID")))
            sqlQuery.Parameters.AddWithValue("@roomID", 0)


            '-----null--------------------
            sqlQuery.Parameters.AddWithValue("@addReq", txtReq.Text)
            sqlQuery.Parameters.AddWithValue("@hallID", 0)
            sqlQuery.Parameters.AddWithValue("@cafeID", Convert.ToInt32(hallValue.Rows(0)("Cafe_ID")))

            MsgBox("Booking saved!", MsgBoxStyle.Information, "Done!")
            frmUserHome.Show()
            Me.Close()
            sqlQuery.Connection.Open()
            sqlQuery.Connection.Close()
            sqlQuery.ExecuteNonQuery()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        cbType.Items.Clear()

        txtReq.Text = ""
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        frmUserHome.Show()

        Me.Close()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        frmLogin.Show()
        Me.Close()
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Application.Exit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmListCafe.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frmEditCafe.username = username
        frmEditCafe.Show()
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
End Class