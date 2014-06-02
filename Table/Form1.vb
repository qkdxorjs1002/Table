Public Class Form1
    Dim i As Integer, j As Integer
    Dim randomValue As String
    Dim upper As Integer
    Dim lower As Integer
    Dim tc As String
    Dim c2 As Integer
    Dim c2_bak As Integer
    Dim y As Integer
    Dim tick As Integer

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

    Private Sub column_TextChanged(sender As Object, e As EventArgs) Handles column.TextChanged
        If column.Text = "" Then
            column.Text = 0
        ElseIf column.Text = " " Then
            column.Text = 0
        End If
        c2 = 1
        c2_bak = c2
        y = column.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If upper > 0 Then
            If y <= 0 Then
                MessageBox.Show("인원수와 열수를 대입해주세요." + Chr(13) + "(1000 이내의 정수만 할당해주세요.)")
            Else
                Dim result = MessageBox.Show("이미 산출된 값을 초기화한 후에" + Chr(13) + "진행 하시겠습니까?", "알림", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    tick = 0
                    c2 = c2_bak
                    RichTextBox1.Text = ""
                End If
                Randomize()
                For count1 = 1 To upper
                    randomValue = CInt(Int((upper * Rnd()) + 1))
                    If randomValue < 10 Then
                        RichTextBox1.Text += "  " + "00" + randomValue
                    ElseIf 10 <= randomValue < 100 Then
                        RichTextBox1.Text += "  " + "0" + randomValue
                    ElseIf randomValue >= 100 Then
                        RichTextBox1.Text += "  " + randomValue
                    End If
                    tick = tick + 1
                    If tick = column.Text * c2 Then
                        RichTextBox1.Text += Chr(13)
                        c2 = c2 + 1
                    End If
                Next
            End If
        Else
            MessageBox.Show("인원수와 열수를 대입해주세요." + Chr(13) + "(1000 이내의 정수만 할당해주세요.)")
        End If
    End Sub
End Class
