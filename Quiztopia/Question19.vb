Public Class Question19
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Question1.score -= 1
        MessageBox.Show("You are incorrect! :(", "Quiztopia", MessageBoxButtons.OK)
        Question20.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Question1.score -= 1
        MessageBox.Show("You are incorrect! :(", "Quiztopia", MessageBoxButtons.OK)
        Question20.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Question1.score -= 1
        MessageBox.Show("You are incorrect! :(", "Quiztopia", MessageBoxButtons.OK)
        Question20.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        MessageBox.Show("You are correct! :)", "Quiztopia", MessageBoxButtons.OK)
        Question20.Show()
        Me.Hide()
    End Sub
End Class