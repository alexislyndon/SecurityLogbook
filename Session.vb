Imports System.IO
Module Session
    Dim FILE As String = "C:\SecurityLog\logs.txt"
    Dim Session_userid As Integer
    Dim sw As New StreamWriter(FILE, True)

    Public Sub logger(type As String)
        ' login, checkin, checkout, create user, 
        sw.Write(Date.Now.ToString("YYYY-MM-DD HH:MM:SS") & " | ")
        sw.Write(" userid: ")
    End Sub

    Public Sub cleansession()
        sw.WriteLine(Date.Now.ToString("YYYY-MM-DD HH:MM:SS") & " | " & Session_userid & ":logged out. ")

        Session_userid = Nothing
        sw.Dispose()
    End Sub
End Module
