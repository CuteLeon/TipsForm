Imports System.ComponentModel

Public Class TipsControler
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TipsForm.PopupTips(Me, TextBox1.Text, Int(ComboBox1.Text), TextBox2.Text)
        'GC.Collect()
    End Sub

    Private Sub TipsControler_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        TipsForm.Close()
    End Sub

    Private Sub TipsControler_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 0
    End Sub
End Class