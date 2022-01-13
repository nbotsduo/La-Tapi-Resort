Public Class frmListRoom
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub RoomBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles RoomBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.RoomBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.La_tapi_resortDataSet)

    End Sub

    Private Sub frmListRoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'La_tapi_resortDataSet.Room' table. You can move, or remove it, as needed.
        Me.RoomTableAdapter.Fill(Me.La_tapi_resortDataSet.Room)

    End Sub
End Class