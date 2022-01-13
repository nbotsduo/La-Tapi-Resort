Public Class frmListHall
    Private Sub HallBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles HallBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.HallBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.La_tapi_resortDataSet)

    End Sub

    Private Sub frmListHall_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'La_tapi_resortDataSet.Hall' table. You can move, or remove it, as needed.
        Me.HallTableAdapter.Fill(Me.La_tapi_resortDataSet.Hall)
        HallBindingNavigator.Visible = False

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
End Class