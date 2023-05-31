Public Class SerialKey

    Private Sub SerialKey_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'KLSAW-SKDOS-124SS
        If My.Settings.SerialKey = TextBox1.Text Then
            My.Settings.AppStat = "Full Version"
            My.Settings.Save()
            Me.Close()
        Else
            MsgBox("Invalid Serial Key", vbCritical + MessageBoxButtons.OKCancel)
        End If
    End Sub
End Class