
Imports System.Data.OleDb
Public Class frmAdminHome

    Public Property AdminName As String


    Private Sub frmAdminHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblPass.Text = "Hello " & AdminName
        Dim strPath As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Naim\Documents\sem 5\vb\LaTapiResort\la_tapi_resort.accdb;"
        Dim strSql As String = "SELECT * FROM Admin WHERE [Admin_Username] ='" & AdminName & "'"
        Dim odaAdmin As New OleDb.OleDbDataAdapter(strSql, strPath)
        Dim datValue As New DataTable
        'lbl10.text = AdminName
        odaAdmin.Fill(datValue)
        odaAdmin.Dispose()

        txtName.Text = Convert.ToString(datValue.Rows(0)("Admin_Name"))
        txtID.Text = Convert.ToInt32(datValue.Rows(0)("Admin_ID"))
        txtPosition.Text = Convert.ToString(datValue.Rows(0)("Admin_Position"))
        txtName.Enabled = False
        txtID.Enabled = False
        txtPosition.Enabled = False

        lblDate.Text = FormatDateTime(Now, DateFormat.ShortDate)
        lblTime.Text = TimeOfDay.ToString("h:mm:ss tt")

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmhotel.admin_hotel = AdminName
        frmhotel.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        frmLogin.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmHall.admin_hall = AdminName
        frmHall.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frmCafe.admin_cafe = AdminName
        frmCafe.Show()
        Me.Close()
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Application.Exit()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        frmLogin.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles PictureBox2.Click
        frmLogin.Show()
        Me.Close()
    End Sub


End Class