﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Il codice è stato generato da uno strumento.
'     Versione runtime:4.0.30319.42000
'
'     Le modifiche apportate a questo file possono provocare un comportamento non corretto e andranno perse se
'     il codice viene rigenerato.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My

    'NOTA: questo file è generato automaticamente e non può essere modificato direttamente. Per apportare modifiche
    ' o se vengono rilevati errori di compilazione nel file, passare a Creazione progetti
    ' (aprire le proprietà del progetto o fare doppio clic sul nodo Progetti personali in
    ' Esplora soluzioni) e apportare le modifiche nella scheda Applicazione.
    '
    Partial Friend Class MyApplication

        <Global.System.Diagnostics.DebuggerStepThroughAttribute()>
        Public Sub New()
            MyBase.New(Global.Microsoft.VisualBasic.ApplicationServices.AuthenticationMode.ApplicationDefined)
            Me.IsSingleInstance = False
            Me.EnableVisualStyles = False
            Me.SaveMySettingsOnExit = True
            Me.ShutDownStyle = Global.Microsoft.VisualBasic.ApplicationServices.ShutdownMode.AfterAllFormsClose
        End Sub

#If DEBUG Then
        <Global.System.Diagnostics.DebuggerStepThroughAttribute()>
        Protected Overrides Sub OnCreateMainForm()
            Me.MainForm = Global.PoP2._0.Frm_login
        End Sub


#Else
        <Global.System.Diagnostics.DebuggerStepThroughAttribute()>
        Protected Overrides Sub OnCreateMainForm()
            Me.MainForm = Global.PoP2._0.Frm_login
        End Sub
        <Global.System.Diagnostics.DebuggerStepThroughAttribute()>  _
        Protected Overrides Sub OnCreateSplashScreen()
            Me.SplashScreen = Global.PoP2._0.frmSplash
        End Sub

#End If

    End Class
End Namespace
