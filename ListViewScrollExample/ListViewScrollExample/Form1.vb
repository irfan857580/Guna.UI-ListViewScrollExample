Public Class Form1

    Dim vScrollHelper As Guna.UI.Lib.ScrollBar.ListViewScrollHelper
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        vScrollHelper = New Guna.UI.Lib.ScrollBar.ListViewScrollHelper(ListView1, GunaVScrollBar1, True)
        Dim r As New Random
        For i As Integer = 0 To 40
            Dim l As ListViewItem = New ListViewItem
            l.Text = i
            l.SubItems.Add(r.Next(200000, 500000))
            l.SubItems.Add(r.Next(200000, 500000))
            l.SubItems.Add(r.Next(200000, 500000))
            l.SubItems.Add(r.Next(200000, 500000))
            l.SubItems.Add(r.Next(200000, 500000))
            ListView1.Items.Add(l)
        Next
        vScrollHelper.UpdateScrollBar()
    End Sub

    Private Sub ListView1_Resize(sender As Object, e As EventArgs) Handles ListView1.Resize
        If vScrollHelper IsNot Nothing Then vScrollHelper.UpdateScrollBar()
    End Sub
End Class
