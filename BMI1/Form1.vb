Public Class Form1

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
                e.Handled = False
            Case 8, 13, 46
                e.Handled = False

            Case Else
                e.Handled = True
                MessageBox.Show("สามารถกดได้แค่ตัวเลข")
        End Select

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Height As Integer
        Dim bmi As Single
        Dim weight As Integer

        Height = TextBox1.Text
        weight = TextBox2.Text
        bmi = weight / ((Height / 100) ^ 2)
        TextBox3.Text = bmi.ToString("#0.00")
        If bmi < 18.5 Then
            TextBox4.Text = (" ผอม ")
        ElseIf bmi <= 22.9 Then
            TextBox4.Text = (" ปานกลาง ")
        ElseIf bmi <= 24.9 Then
            TextBox4.Text = (" ท้วม")
        ElseIf bmi <= 29.9 Then
            TextBox4.Text = (" โรคอ้วน ")
        Else
            TextBox4.Text = (" อ้วนอันตราย ")
        End If

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub


    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
                e.Handled = False
            Case 8, 13, 46
                e.Handled = False

            Case Else
                e.Handled = True
                MessageBox.Show("สามารถกดได้แค่ตัวเลข")
        End Select


    End Sub


    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        Select Case Asc(e.KeyChar)
            Case 0 To 0
                e.Handled = False
            Case 8, 13, 46
                e.Handled = False

            Case Else
                e.Handled = True
                MessageBox.Show("ผิดพลาด")
        End Select

    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        Select Case Asc(e.KeyChar)
            Case 0 To 0
                e.Handled = False
            Case 8, 13, 46
                e.Handled = False

            Case Else
                e.Handled = True
                MessageBox.Show("ผิดพลาด")
        End Select
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub
End Class

