Imports System.Web
Public Class IISHandler1
    Implements IHttpHandler

    ''' <summary>
    '''  Il gestore dovrà essere configurato nel file Web.config del 
    '''  Web e registrato con IIS prima di poter essere utilizzato. Per ulteriori informazioni
    '''  vedere il collegamento seguente: https://go.microsoft.com/?linkid=8101007
    ''' </summary>
#Region "Membri di IHttpHandler"

    Public ReadOnly Property IsReusable() As Boolean Implements IHttpHandler.IsReusable
        Get
            ' Restituisce false se non è possibile riutilizzare il gestore gestito per un'altra richiesta.
            ' È normalmente false se sono state mantenute informazioni sullo stato per richiesta.
            Return True
        End Get
    End Property

    Public Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest

        ' Scrivere qui l'implementazione del gestore.

    End Sub

#End Region

End Class
