Public Class Form1
    Dim player1, player2 As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("XOXO By Di ka! Ka Graduate")
        player1 = InputBox("Isurat pangaran sa player 1", "Pangaran sa Player 1")
        player2 = InputBox("Isurat pangaran sa player 2", "Pangaran sa Player 2")
        If player1 = "" Then
            player1 = "Player 1"
            player2 = "Player 2"
        End If
        Label1.Text = player1 + Label1.Text
        Label2.Text = player2 + Label2.Text
        Label3.Text = player1 + Label3.Text
        Label4.Text = player2 + Label4.Text
        Label2.Visible = False
    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If Label1.Visible = True Then
            btn1.Text = "O"
            txt_chk()
            Label1.Visible = False
            Label2.Visible = True
            GoTo 50000
        End If

        If Label2.Visible = True Then
            btn1.Text = "X"
            txt_chk()
            Label1.Visible = True
            Label2.Visible = False
            GoTo 50000
        End If
50000:  btn1.Enabled = False
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If Label1.Visible = True Then
            btn2.Text = "O"
            txt_chk()
            Label1.Visible = False
            Label2.Visible = True
            GoTo 50000
        End If

        If Label2.Visible = True Then
            btn2.Text = "X"
            txt_chk()
            Label1.Visible = True
            Label2.Visible = False
            GoTo 50000
        End If
50000:  btn1.Enabled = False
    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If Label1.Visible = True Then
            btn3.Text = "O"
            txt_chk()
            Label1.Visible = False
            Label2.Visible = True
            GoTo 50000
        End If

        If Label2.Visible = True Then
            btn3.Text = "X"
            txt_chk()
            Label1.Visible = True
            Label2.Visible = False
            GoTo 50000
        End If
50000:  btn1.Enabled = False
    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If Label1.Visible = True Then
            btn4.Text = "O"
            txt_chk()
            Label1.Visible = False
            Label2.Visible = True
            GoTo 50000
        End If

        If Label2.Visible = True Then
            btn4.Text = "X"
            txt_chk()
            Label1.Visible = True
            Label2.Visible = False
            GoTo 50000
        End If
50000:  btn1.Enabled = False
    End Sub

    Private Sub Btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        If Label1.Visible = True Then
            btn5.Text = "O"
            txt_chk()
            Label1.Visible = False
            Label2.Visible = True
            GoTo 50000
        End If

        If Label2.Visible = True Then
            btn5.Text = "X"
            txt_chk()
            Label1.Visible = True
            Label2.Visible = False
            GoTo 50000
        End If
50000:  btn1.Enabled = False
    End Sub

    Private Sub Btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        If Label1.Visible = True Then
            btn6.Text = "O"
            txt_chk()
            Label1.Visible = False
            Label2.Visible = True
            GoTo 50000
        End If

        If Label2.Visible = True Then
            btn6.Text = "X"
            txt_chk()
            Label1.Visible = True
            Label2.Visible = False
            GoTo 50000
        End If
50000:  btn1.Enabled = False
    End Sub

    Private Sub Btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        If Label1.Visible = True Then
            btn7.Text = "O"
            txt_chk()
            Label1.Visible = False
            Label2.Visible = True
            GoTo 50000
        End If

        If Label2.Visible = True Then
            btn7.Text = "X"
            txt_chk()
            Label1.Visible = True
            Label2.Visible = False
            GoTo 50000
        End If
50000:  btn1.Enabled = False
    End Sub

    Private Sub Btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        If Label1.Visible = True Then
            btn8.Text = "O"
            txt_chk()
            Label1.Visible = False
            Label2.Visible = True
            GoTo 50000
        End If

        If Label2.Visible = True Then
            btn8.Text = "X"
            txt_chk()
            Label1.Visible = True
            Label2.Visible = False
            GoTo 50000
        End If
50000:  btn1.Enabled = False
    End Sub

    Private Sub Btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        If Label1.Visible = True Then
            btn9.Text = "O"
            txt_chk()
            Label1.Visible = False
            Label2.Visible = True
            GoTo 50000
        End If

        If Label2.Visible = True Then
            btn9.Text = "X"
            txt_chk()
            Label1.Visible = True
            Label2.Visible = False
            GoTo 50000
        End If
50000:  btn1.Enabled = False
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        btn1.Text = ""
        btn1.Enabled = True
        btn2.Text = ""
        btn2.Enabled = True
        btn3.Text = ""
        btn3.Enabled = True
        btn4.Text = ""
        btn4.Enabled = True
        btn5.Text = ""
        btn5.Enabled = True
        btn6.Text = ""
        btn6.Enabled = True
        btn7.Text = ""
        btn7.Enabled = True
        btn8.Text = ""
        btn8.Enabled = True
        btn9.Text = ""
        btn9.Enabled = True
    End Sub

    Private Sub txt_chk()
        'Player 2's Win Chances
        If btn1.Text = "X" And btn2.Text = "X" And btn3.Text = "X" Then
            MsgBox("Wow Congrats " & player2 & ", You Win", MsgBoxStyle.Information, "Win")
            Label6.Text += 1
            btn1.Enabled = False
            btn2.Enabled = False
            btn3.Enabled = False
            btn4.Enabled = False
            btn5.Enabled = False
            btn6.Enabled = False
            btn7.Enabled = False
            btn8.Enabled = False
            btn9.Enabled = False
        ElseIf (btn1.Text = "X" And btn5.Text = "X" And btn9.Text = "X") Then
            MsgBox("Wow Congrats " & player2 & ", You Win", MsgBoxStyle.Information, "Win")
            Label6.Text += 1
            btn1.Enabled = False
            btn2.Enabled = False
            btn3.Enabled = False
            btn4.Enabled = False
            btn5.Enabled = False
            btn6.Enabled = False
            btn7.Enabled = False
            btn8.Enabled = False
            btn9.Enabled = False
        ElseIf (btn1.Text = "X" And btn4.Text = "X" And btn7.Text = "X") Then
            MsgBox("Wow Congrats " & player2 & ", You Win", MsgBoxStyle.Information, "Win")
            Label6.Text += 1
            btn1.Enabled = False
            btn2.Enabled = False
            btn3.Enabled = False
            btn4.Enabled = False
            btn5.Enabled = False
            btn6.Enabled = False
            btn7.Enabled = False
            btn8.Enabled = False
            btn9.Enabled = False
        ElseIf (btn2.Text = "X" And btn5.Text = "X" And btn8.Text = "X") Then
            MsgBox("Wow Congrats " & player2 & ", You Win", MsgBoxStyle.Information, "Win")
            Label6.Text += 1
            btn1.Enabled = False
            btn2.Enabled = False
            btn3.Enabled = False
            btn4.Enabled = False
            btn5.Enabled = False
            btn6.Enabled = False
            btn7.Enabled = False
            btn8.Enabled = False
            btn9.Enabled = False
        ElseIf (btn3.Text = "X" And btn6.Text = "X" And btn9.Text = "X") Then
            MsgBox("Wow Congrats " & player2 & ", You Win", MsgBoxStyle.Information, "Win")
            Label6.Text += 1
            btn1.Enabled = False
            btn2.Enabled = False
            btn3.Enabled = False
            btn4.Enabled = False
            btn5.Enabled = False
            btn6.Enabled = False
            btn7.Enabled = False
            btn8.Enabled = False
            btn9.Enabled = False
        ElseIf (btn4.Text = "X" And btn5.Text = "X" And btn6.Text = "X") Then
            MsgBox("Wow Congrats " & player2 & ", You Win", MsgBoxStyle.Information, "Win")
            Label6.Text += 1
            btn1.Enabled = False
            btn2.Enabled = False
            btn3.Enabled = False
            btn4.Enabled = False
            btn5.Enabled = False
            btn6.Enabled = False
            btn7.Enabled = False
            btn8.Enabled = False
            btn9.Enabled = False
        ElseIf (btn7.Text = "X" And btn8.Text = "X" And btn9.Text = "X") Then
            MsgBox("Wow Congrats " & player2 & ", You Win", MsgBoxStyle.Information, "Win")
            Label6.Text += 1
            btn1.Enabled = False
            btn2.Enabled = False
            btn3.Enabled = False
            btn4.Enabled = False
            btn5.Enabled = False
            btn6.Enabled = False
            btn7.Enabled = False
            btn8.Enabled = False
            btn9.Enabled = False
        ElseIf (btn3.Text = "X" And btn5.Text = "X" And btn7.Text = "X") Then
            MsgBox("Wow Congrats " & player2 & ", You Win", MsgBoxStyle.Information, "Win")
            Label6.Text += 1
            btn1.Enabled = False
            btn2.Enabled = False
            btn3.Enabled = False
            btn4.Enabled = False
            btn5.Enabled = False
            btn6.Enabled = False
            btn7.Enabled = False
            btn8.Enabled = False
            btn9.Enabled = False
        End If
        'Player 1's Win Chances
        If btn1.Text = "O" And btn2.Text = "O" And btn3.Text = "O" Then
            MsgBox("Wow Congrats " & player1 & ", You Win", MsgBoxStyle.Information, "Win")
            Label5.Text += 1
            btn1.Enabled = False
            btn2.Enabled = False
            btn3.Enabled = False
            btn4.Enabled = False
            btn5.Enabled = False
            btn6.Enabled = False
            btn7.Enabled = False
            btn8.Enabled = False
            btn9.Enabled = False
        ElseIf (btn1.Text = "O" And btn5.Text = "O" And btn9.Text = "O") Then
            MsgBox("Wow Congrats " & player1 & ", You Win", MsgBoxStyle.Information, "Win")
            Label5.Text += 1
            btn1.Enabled = False
            btn2.Enabled = False
            btn3.Enabled = False
            btn4.Enabled = False
            btn5.Enabled = False
            btn6.Enabled = False
            btn7.Enabled = False
            btn8.Enabled = False
            btn9.Enabled = False
        ElseIf (btn1.Text = "O" And btn4.Text = "O" And btn7.Text = "O") Then
            MsgBox("Wow Congrats " & player1 & ", You Win", MsgBoxStyle.Information, "Win")
            Label5.Text += 1
            btn1.Enabled = False
            btn2.Enabled = False
            btn3.Enabled = False
            btn4.Enabled = False
            btn5.Enabled = False
            btn6.Enabled = False
            btn7.Enabled = False
            btn8.Enabled = False
            btn9.Enabled = False
        ElseIf (btn2.Text = "O" And btn5.Text = "O" And btn8.Text = "O") Then
            MsgBox("Wow Congrats " & player1 & ", You Win", MsgBoxStyle.Information, "Win")
            Label5.Text += 1
            btn1.Enabled = False
            btn2.Enabled = False
            btn3.Enabled = False
            btn4.Enabled = False
            btn5.Enabled = False
            btn6.Enabled = False
            btn7.Enabled = False
            btn8.Enabled = False
            btn9.Enabled = False
        ElseIf (btn3.Text = "O" And btn6.Text = "O" And btn9.Text = "O") Then
            MsgBox("Wow Congrats " & player1 & ", You Win", MsgBoxStyle.Information, "Win")
            Label5.Text += 1
            btn1.Enabled = False
            btn2.Enabled = False
            btn3.Enabled = False
            btn4.Enabled = False
            btn5.Enabled = False
            btn6.Enabled = False
            btn7.Enabled = False
            btn8.Enabled = False
            btn9.Enabled = False
        ElseIf (btn4.Text = "O" And btn5.Text = "O" And btn6.Text = "O") Then
            MsgBox("Wow Congrats " & player1 & ", You Win", MsgBoxStyle.Information, "Win")
            Label5.Text += 1
            btn1.Enabled = False
            btn2.Enabled = False
            btn3.Enabled = False
            btn4.Enabled = False
            btn5.Enabled = False
            btn6.Enabled = False
            btn7.Enabled = False
            btn8.Enabled = False
            btn9.Enabled = False
        ElseIf (btn7.Text = "O" And btn8.Text = "O" And btn9.Text = "O") Then
            MsgBox("Wow Congrats " & player1 & ", You Win", MsgBoxStyle.Information, "Win")
            Label5.Text += 1
            btn1.Enabled = False
            btn2.Enabled = False
            btn3.Enabled = False
            btn4.Enabled = False
            btn5.Enabled = False
            btn6.Enabled = False
            btn7.Enabled = False
            btn8.Enabled = False
            btn9.Enabled = False
        ElseIf (btn3.Text = "O" And btn5.Text = "O" And btn7.Text = "O") Then
            MsgBox("Wow Congrats " & player1 & ", You Win", MsgBoxStyle.Information, "Win")
            Label5.Text += 1
            btn1.Enabled = False
            btn2.Enabled = False
            btn3.Enabled = False
            btn4.Enabled = False
            btn5.Enabled = False
            btn6.Enabled = False
            btn7.Enabled = False
            btn8.Enabled = False
            btn9.Enabled = False
        End If
    End Sub
End Class
