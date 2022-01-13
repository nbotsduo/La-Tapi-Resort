Imports System.Data.OleDb
Public Class frmUserHome

    Public Property username As String
    Public Property connUser As New OleDbConnection

    Private Sub frmUserHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitle.Text = "Welcome " & username

        Dim strCon As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Naim\Documents\sem 5\vb\LaTapiResort\la_tapi_resort.accdb;"
        Dim strSql As String = "SELECT * FROM Customer WHERE [Cust_Username] ='" & username & "'"
        Dim odaUser As New OleDb.OleDbDataAdapter(strSql, strCon)
        Dim datValue As New DataTable
        odaUser.Fill(datValue)
        odaUser.Dispose()

        lblName.Text = datValue.Rows(0)("Cust_Name")
        lblIC.Text = datValue.Rows(0)("Cust_IC")
        lblNat.Text = datValue.Rows(0)("Cust_Nationality")
        lblmail.Text = datValue.Rows(0)("Cust_Email")
        lblUser.Text = datValue.Rows(0)("Cust_Username")

        lblDate.Text = FormatDateTime(Now, DateFormat.ShortDate)
        lblTime.Text = TimeOfDay.ToString("h:mm:ss tt")
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        frmBookHall.username = username
        frmBookHall.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        frmLogin.Show()
        Me.Close()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        frmLogin.Show()
        'username = ""
        Me.Close()
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frmBookRoom.username = username
        frmBookRoom.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        frmBookCafe.username = username
        frmBookCafe.Show()
        Me.Hide()
    End Sub


End Class