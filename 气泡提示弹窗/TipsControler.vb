Public Class TipsControler
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not TipsForm.Visible Then TipsForm.Show()
        TipsForm.PopupTips(TextBox1.Text, Int(ComboBox1.Text), TextBox2.Text)
        'GC.Collect()
    End Sub

    Private Sub TipsControler_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 0
    End Sub
End Class