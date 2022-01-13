Public Class frmhotel

    Public Property admin_hotel As String
    Dim index As Integer = 0
    Private Sub RoomBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles RoomBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.RoomBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.La_tapi_resortDataSet)

    End Sub

    Private Sub frmhotel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'La_tapi_resortDataSet.Room' table. You can move, or remove it, as needed.
        Me.RoomTableAdapter.Fill(Me.La_tapi_resortDataSet.Room)
        'Hide database navigator  
        RoomBindingNavigator.Visible = False
        'btnSave.Enabled = False
    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        BindingNavigatorMovePreviousItem.PerformClick()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        BindingNavigatorMoveNextItem.PerformClick()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Me.RoomBindingSource.AddNew()
        btnSave.Enabled = True
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.Validate()
        Me.RoomBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.La_tapi_resortDataSet)
        MsgBox("Record has been saved",, "Saved")
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Me.RoomBindingSource.RemoveCurrent()
        Me.TableAdapterManager.UpdateAll(Me.La_tapi_resortDataSet)
        MsgBox("Record has been deleted",, "Deleted")
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        frmAdminHome.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        frmAdminHome.AdminName = admin_hotel
        frmAdminHome.Show()
        Me.Close()
    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        frmAdminHome.AdminName = admin_hotel
        Me.Close()
        frmAdminHome.Show()

    End Sub

    Private Sub LogOutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem1.Click
        frmLogin.Show()
        Me.Hide()
    End Sub

    Private Sub ExitToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem2.Click
        Application.Exit()
    End Sub
End Class