Imports System.Data.OleDb
Public Class frmEditCafe

    Public Property username As String
    Public Property conCafe As New OleDbConnection
    Public Property id As Integer

    Private Sub ReservationBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ReservationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.La_tapi_resortDataSet)

    End Sub

    Private Sub ReservationBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles ReservationBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ReservationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.La_tapi_resortDataSet)

    End Sub

    Private Sub frmEditCafe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strsql As String = "SELECT * FROM Customer WHERE [Cust_Username] ='" & username & "'"
        Dim strPath As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Naim\Documents\sem 5\vb\LaTapiResort\la_tapi_resort.accdb;"
        Dim odaID As New OleDb.OleDbDataAdapter(strsql, strPath)
        Dim datValue As New DataTable

        odaID.Fill(datValue)
        odaID.Dispose()
        Dim Id As Integer
        Id = Convert.ToInt32(datValue.Rows(0)("Cust_ID"))


        'TODO: This line of code loads data into the 'La_tapi_resortDataSet.Reservation' table. You can move, or remove it, as needed.
        Me.ReservationTableAdapter.Fill(Me.La_tapi_resortDataSet.Reservation)
        Me.ReservationBindingSource.Filter = "Reser_Type= 'Cafe' AND Cust_ID=" & Id
        'Me.ReservationBindingSource.Filter = "Cust_ID=" & gID


        ReservationBindingNavigator.Visible = False


    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        frmBookCafe.Show()
        Me.Close()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        BindingNavigatorMoveNextItem.PerformClick()
    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        BindingNavigatorMovePreviousItem.PerformClick()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.Validate()
        Me.ReservationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.La_tapi_resortDataSet)
        MessageBox.Show("The record has been updated.")
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Me.ReservationBindingSource.RemoveCurrent()
        Me.TableAdapterManager.UpdateAll(Me.La_tapi_resortDataSet)
        MessageBox.Show("The record has been deleted.")
    End Sub


End Class