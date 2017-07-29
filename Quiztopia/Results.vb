Public Class Results

    Private Sub Results_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label2.Text = Question1.score & " / 20"

        If Question1.score > 15 Then
            Label4.Text = "You sure do know alot! :D"
        End If
        If Question1.score < 15 Then
            Label4.Text = "You have the average knowledge. Great job!"
        End If
        If Question1.score < 10 Then
            Label4.Text = "Sadly, you got a low score. Better luck next time!"
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Question1.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class