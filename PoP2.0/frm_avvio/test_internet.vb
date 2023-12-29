Imports System.Runtime.InteropServices

Public Class StatoConnessione

    <DllImport("wininet.dll")>
    Private Shared Function InternetGetConnectedState(ByRef Description As Integer, ByVal ReservedValue As Integer) As Boolean
    End Function

    Public Sub New()
    End Sub

    Public Shared Function ConnessioneInternet() As Boolean
        Dim Desc As Integer
        Return InternetGetConnectedState(Desc, 0)
    End Function
End Class