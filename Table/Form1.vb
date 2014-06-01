Public Class Form1
    Dim randomValue As String
    Dim upper As Integer
    Dim lower As Integer
    Dim tc As Integer
    Dim c2 As Integer
    Dim c2_bak As Integer
    Dim y As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub peo_TextChanged(sender As Object, e As EventArgs) Handles peo.TextChanged
        If peo.Text = "" Then
            peo.Text = 0
        ElseIf peo.Text = " " Then
            peo.Text = 0
        End If
        lower = 1
        upper = peo.Text
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        wtf.Text = ""
        Randomize()
        randomValue = CInt(Math.Floor((upper - lower + 1) * Rnd())) + lower
        wtf.Text = randomValue
        If randomValue < 10 Then
            RichTextBox1.Text += "  " + "0" + randomValue
        Else
            RichTextBox1.Text += "  " + randomValue
        End If
        If tc = peo.Text - 1 Then
            tc = 0
            Timer1.Enabled = False
        Else
            tc = tc + 1
        End If
        If tc = column.Text * c2 Then
            RichTextBox1.Text += Chr(13)
            c2 = c2 + 1
        End If
    End Sub

    Private Sub column_TextChanged(sender As Object, e As EventArgs) Handles column.TextChanged
        c2 = 1
        c2_bak = c2
        y = column.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If upper > 0 Then
            If y <= 0 Then
                MessageBox.Show("인원수와 열수를 대입해주세요." + Chr(13) + "(정수만 할당해주세요.)")
            Else
                Dim result = MessageBox.Show("이미 산출된 값을 초기화한 후에" + Chr(13) + "진행 하시겠습니까?", "알림", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    c2 = c2_bak
                    RichTextBox1.Text = ""
                    Timer1.Enabled = True
                Else
                    Timer1.Enabled = True
                End If
            End If
        Else
            MessageBox.Show("인원수와 열수를 대입해주세요." + Chr(13) + "(정수만 할당해주세요.)")
        End If
    End Sub
End Class
