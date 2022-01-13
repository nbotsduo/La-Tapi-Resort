Public Class frmHall

    Public Property admin_hall As String

    Private Sub HallBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles HallBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.HallBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.La_tapi_resortDataSet)

    End Sub

    Private Sub frmHall_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'La_tapi_resortDataSet.Hall' table. You can move, or remove it, as needed.
        Me.HallTableAdapter.Fill(Me.La_tapi_resortDataSet.Hall)
        'Hide database navigator  
        HallBindingNavigator.Visible = False

        btnSave.Enabled = False

    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        BindingNavigatorMovePreviousItem.PerformClick()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        BindingNavigatorMoveNextItem.PerformClick()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        frmAdminHome.AdminName = admin_hall
        frmAdminHome.Show()
        Me.Close()
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Me.HallBindingSource.RemoveCurrent()
        Me.TableAdapterManager.UpdateAll(Me.La_tapi_resortDataSet)
        MsgBox("Record has been deleted",, "Deleted")
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Me.HallBindingSource.AddNew()
        btnSave.Enabled = True
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.Validate()
        Me.HallBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.La_tapi_resortDataSet)
        MsgBox("Record has been saved",, "Saved")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        frmAdminHome.Show()
        Me.Hide()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        frmLogin.Show()
        Me.Hide()
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Application.Exit()
    End Sub
End Class