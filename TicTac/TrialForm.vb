Public Class TrialForm
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub TrialForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        If My.Settings.AppStat = "Trial Version" Then
            If My.Settings.LoadCount < 0 Then
                SerialKey.ShowDialog()
            End If

            Me.Text = My.Settings.AppStat & " : Count - " & My.Settings.LoadCount
            My.Settings.LoadCount -= 1
            My.Settings.Save()

        Else
            Me.Text = My.Settings.AppStat
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.ShowDialog()
        Me.Dispose()
    End Sub
End Class