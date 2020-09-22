Public Class WinFormControlsForm


    Private Sub ExitButton1_Click(sender As Object, e As EventArgs) Handles ExitButton1.Click
        Me.Close()
    End Sub

    Private Sub GoButton2_Click(sender As Object, e As EventArgs) Handles GoButton2.Click

        ExamplePictureBox1.BackgroundImage = My.Resources.logo
        ExamplePictureBox1.BackgroundImageLayout = ImageLayout.Zoom






    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        ' If ExamplePictureBox1.Visible = False Then
        ' ExamplePictureBox1.Show()
        'ExitButton1.Enabled = False

        ' Else
        ' ExamplePictureBox1.Hide()
        'ExitButton1.Enabled = True



        ' End If
        '

        'If RadioButton6.Checked = True Then

        'ExamplePictureBox1.BackColor = System.Drawing.SystemColors.Desktop

        'Else

        'ExamplePictureBox1.BackColor = System.Drawing.SystemColors.control

        'End If

    End Sub
End Class
