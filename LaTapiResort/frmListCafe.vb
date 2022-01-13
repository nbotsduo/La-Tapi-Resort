Public Class frmListCafe
    Private Sub CafeBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CafeBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CafeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.La_tapi_resortDataSet)

    End Sub

    Private Sub frmListCafe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'La_tapi_resortDataSet.Cafe' table. You can move, or remove it, as needed.
        Me.CafeTableAdapter.Fill(Me.La_tapi_resortDataSet.Cafe)
        CafeBindingNavigator.Visible = False
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
End Class