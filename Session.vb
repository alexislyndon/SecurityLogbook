﻿Module Session
    Public s_uid As Integer

    Public Sub startsession(id As Integer)
        s_uid = id
    End Sub

    Public Sub endsession()
        s_uid = Nothing
    End Sub


End Module
