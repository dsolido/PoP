Public Class Informazioni_utente

    Public tipo_connessione As String
    Public Property Connessione() As String
        Get
            Return tipo_connessione
        End Get
        Set(ByVal Value As String)
            tipo_connessione = Value
        End Set
    End Property


End Class
