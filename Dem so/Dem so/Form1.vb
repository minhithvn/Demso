Public Class Form1
    Sub PlayBackgroundSoundFile1()
        My.Computer.Audio.Play("..\Debug\amthanh\1.wav", AudioPlayMode.BackgroundLoop)
    End Sub
    Sub PlayBackgroundSoundFile2()
        My.Computer.Audio.Play("..\Debug\amthanh\2.wav", AudioPlayMode.BackgroundLoop)
    End Sub
    Sub PlayBackgroundSoundFile3()
        My.Computer.Audio.Play("..\Debug\amthanh\3.wav", AudioPlayMode.BackgroundLoop)
    End Sub
    Sub PlayBackgroundSoundFile4()
        My.Computer.Audio.Play("..\Debug\amthanh\4.wav", AudioPlayMode.BackgroundLoop)
    End Sub
    Sub PlayBackgroundSoundFile5()
        My.Computer.Audio.Play("..\Debug\amthanh\5.wav", AudioPlayMode.BackgroundLoop)
    End Sub
    Sub PlayBackgroundSoundFile6()
        My.Computer.Audio.Play("..\Debug\amthanh\6.wav", AudioPlayMode.BackgroundLoop)
    End Sub
    Sub PlayBackgroundSoundFile7()
        My.Computer.Audio.Play("..\Debug\amthanh\7.wav", AudioPlayMode.BackgroundLoop)
    End Sub
    Sub PlayBackgroundSoundFile8()
        My.Computer.Audio.Play("..\Debug\amthanh\8.wav", AudioPlayMode.BackgroundLoop)
    End Sub
    Sub PlayBackgroundSoundFile9()
        My.Computer.Audio.Play("..\Debug\amthanh\9.wav", AudioPlayMode.BackgroundLoop)
    End Sub
    Sub PlayBackgroundSoundFile0()
        My.Computer.Audio.Play("..\Debug\amthanh\0.wav", AudioPlayMode.BackgroundLoop)
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim number2 As Array = {0, 6, 8, 3, 4, 5, 1, 7, 2, 9}
        Label1.Text = CStr(Int(Rnd() * 9))

        For Each y In number2

            If Label1.Text = "1" Then
                PlayBackgroundSoundFile1()
            ElseIf Label1.Text = "2" Then
                PlayBackgroundSoundFile2()
            ElseIf Label1.Text = "3" Then
                PlayBackgroundSoundFile3()
            ElseIf Label1.Text = "4" Then
                PlayBackgroundSoundFile4()
            ElseIf Label1.Text = "5" Then
                PlayBackgroundSoundFile5()
            ElseIf Label1.Text = "6" Then
                PlayBackgroundSoundFile6()
            ElseIf Label1.Text = "7" Then
                PlayBackgroundSoundFile7()
            ElseIf Label1.Text = "8" Then
                PlayBackgroundSoundFile8()
            ElseIf Label1.Text = "9" Then
                PlayBackgroundSoundFile9()
            ElseIf label1.Text = "0" Then
                PlayBackgroundSoundFile0()
            End If
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub


    'ElseIf y = 4 Then
    '            PlayBackgroundSoundFile4()
    '        ElseIf y = 5 Then
    '            PlayBackgroundSoundFile5()
    '        ElseIf y = 6 Then
    '            PlayBackgroundSoundFile6()
    '        ElseIf y = 7 Then
    '            PlayBackgroundSoundFile7()
    '        ElseIf y = 8 Then
    '            PlayBackgroundSoundFile8()
    '        ElseIf y = 9 Then
    '            PlayBackgroundSoundFile9()
End Class
