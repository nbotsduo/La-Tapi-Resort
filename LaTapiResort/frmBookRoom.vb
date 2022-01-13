Imports System.Data.OleDb

Public Class frmBookRoom

    Public Property conRoom As New OleDbConnection
    Public Property username As String
    Public Property id As Integer

    Private Sub frmBookRoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmEditRoom.id = id

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frmUserHome.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Get Customer Information
        Dim strSql As String = "SELECT * FROM Customer WHERE [Cust_Username] ='" & username & "'"
        Dim strPath As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Naim\Documents\sem 5\vb\LaTapiResort\la_tapi_resort.accdb;"
        Dim odaGuest As New OleDb.OleDbDataAdapter(strSql, strPath)
        Dim guestValue As New DataTable
        odaGuest.Fill(guestValue)
        odaGuest.Dispose()

        'Get room id
        strSql = "SELECT * FROM Room WHERE [Room_Name] ='" & cbType.SelectedItem.ToString() & "'"
        Dim odaRoom As New OleDb.OleDbDataAdapter(strSql, strPath)
        Dim roomValue As New DataTable
        odaRoom.Fill(roomValue)
        odaRoom.Dispose()

        Try
            Dim sqlQuery As New OleDb.OleDbCommand
            sqlQuery.Connection = conRoom
            sqlQuery.CommandText = "INSERT INTO Reservation([Reser_Type],[Reser_Name],[Reser_Qty],[Reser_Date],[Reser_Duration],[Cust_ID],[Room_ID],[Reser_AddReq],[Hall_ID],[Cafe_ID] )
                                    VALUES(@resType,@resName,@resQuantity,@resDate,@resDuration,@guestID,@roomID,@addReq,@hallID,@cafeID)"

            sqlQuery.Parameters.AddWithValue("@resType", "Room")
            sqlQuery.Parameters.AddWithValue("@resName", cbType.SelectedItem.ToString())
            sqlQuery.Parameters.AddWithValue("@resQuantity", Convert.ToInt32(txtQty.Text))
            sqlQuery.Parameters.AddWithValue("@resDate", dtHall.Value)
            sqlQuery.Parameters.AddWithValue("@resDuration", Convert.ToInt32(txtDurHall.Text))
            sqlQuery.Parameters.AddWithValue("@guestID", Convert.ToInt32(guestValue.Rows(0)("Cust_ID")))
            sqlQuery.Parameters.AddWithValue("@roomID", Convert.ToInt32(roomValue.Rows(0)("Room_ID")))


            '-----null--------------------
            sqlQuery.Parameters.AddWithValue("@addReq", txtReq.Text)
            sqlQuery.Parameters.AddWithValue("@hallID", 0)
            sqlQuery.Parameters.AddWithValue("@cafeID", 0)

            MsgBox("Booking saved!", MsgBoxStyle.Information, "Done!")
            cbType.Items.Clear()
            txtDurHall.Text = ""
            txtQty.Text = ""
            txtReq.Text = ""
            frmUserHome.Show()
            Me.Close()
            sqlQuery.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frmEditRoom.username = username
        frmEditRoom.Show()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmListRoom.Show()
    End Sub
End Class