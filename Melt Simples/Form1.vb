Imports System.IO
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim RASFDRHTWA As String = (System.Reflection.Assembly.GetExecutingAssembly().Location)
        Dim FZWKXSTXQU As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
        Me.Hide()
        Visible = False
        If System.IO.File.Exists(FZWKXSTXQU + "\x.bat") Then
            Kill(FZWKXSTXQU + "\x.bat")
        Else : System.IO.File.Exists(FZWKXSTXQU + "\x.bat")
        End If
        Dim UBÇTBTFYTV As New StreamWriter(FZWKXSTXQU + "\x.bat")
        UBÇTBTFYTV.Write("@echo off" & vbNewLine & "del " + RASFDRHTWA & vbNewLine & "del /a " + RASFDRHTWA)
        UBÇTBTFYTV.Close()
        UBÇTBTFYTV.Dispose()
        System.Diagnostics.Process.Start(FZWKXSTXQU + "\x.bat")
        End
    End Sub
End Class
