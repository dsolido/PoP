Imports MySql.Data.MySqlClient
Imports System.Threading
Imports System.Security.Cryptography
Imports System.IO
Imports System.Text
Imports System.Security.AccessControl
Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports System.Text.RegularExpressions


Module dsolidofunc

    Friend Function ritornainiziofinemese(ByVal Periodo As DateTime) As Array
        Dim a(1) As Date
        a(0) = DateSerial(Periodo.Year, Periodo.Month, 1)
        a(1) = DateSerial(Periodo.Year, Periodo.Month + 1, 0)
        Return a
    End Function
    Public Structure ConteggioTotaleAssenze
        Private _id As Integer
        Private _localita As String
        Private _totale As Decimal
        Public Property Id() As Integer
            Get
                Return _id
            End Get
            Set(ByVal value As Integer)
                _id = value
            End Set
        End Property
        Public Property Localita() As String
            Get
                Return _localita
            End Get
            Set(ByVal value As String)
                _localita = value
            End Set
        End Property
        Public Property Totale() As Decimal
            Get
                Return _totale
            End Get
            Set(ByVal value As Decimal)
                _totale = value
            End Set
        End Property
        Public Sub New(ByRef id As Integer, ByRef localita As String, ByRef totale As Decimal)
            _id = id
            _localita = localita
            _totale = totale
        End Sub
    End Structure
    Friend Function Array_search(ByVal key As Integer, ByVal mioArray As Integer()) As Integer
        Dim i As Integer
        'iterazione nell'array
        If IsNothing(mioArray) Then
            Return -1
        End If
        For i = 0 To mioArray.Count - 1
            If mioArray(i) = key Then
                Return i
            End If
        Next
        Return -1
    End Function
    Public Function TempoStringaCorta(ByVal tt As TimeSpan) As String

        Dim risp As String
        risp = tt.Hours.ToString.PadLeft(2, "0") & ":" & tt.Minutes.ToString.PadLeft(2, "0")
        Return risp

    End Function
    Public Function EliminaCaratteriSpeciali(ByRef Testo As String, Optional SenzaSpazi As Boolean = False) As String
        Dim Valore As String
        Try
            If SenzaSpazi Then
                Valore = Regex.Replace(Testo, "[^\w\.@-]", "")
                Valore = (Testo.Replace(Chr(34), String.Empty).Replace("#", String.Empty).Replace("\""", String.Empty).Replace(".", "_").Replace("°", "_").Replace("%", "_").Replace("&", "e").Replace("-", "_").Replace("'", "").Replace("é", "e").Replace("à", "a").Replace("ò", "o").Replace("ù", "u").Replace("ì", "i").Replace("è", "e"))
            Else
                Valore = Regex.Replace(Testo, "[^\w\.@-]", "")
                Valore = (Testo.Replace(Chr(34), String.Empty).Replace("#", String.Empty).Replace("\""", String.Empty).Replace(" ", "_").Replace(".", "_").Replace("°", "_").Replace("%", "_").Replace("&", "e").Replace("-", "_").Replace("'", "").Replace("é", "e").Replace("à", "a").Replace("ò", "o").Replace("ù", "u").Replace("ì", "i").Replace("è", "e"))
            End If

        Catch ex As Exception
            Return ("nessunaConversione")
        End Try

        Return Valore
    End Function
    Function TryDecimale(ByVal obj As String) As Decimal
        Dim resp As Decimal
        Dim v = Decimal.TryParse(obj, resp)
        Return resp
    End Function

    Friend Function Array_push(arr, vars)
        ' Dimensiono le variabili interne alla funzione
        Dim k, newelem, newarrsize
        ' Verifico se arr è una array
        If IsArray(arr) Then
            ' Verifico che vars non sia vuoto
            If Len(vars) > 0 Then
                ' Verifico se vars ospita una o più virgole e quindi
                ' se è uno solo o un elenco di elementi.
                ' Se è un solo elemento...
                If InStr(vars, ",") = False Then
                    ' Incremento di uno il numero di elementi
                    newarrsize = CInt(UBound(arr) + 1)
                    ReDim Preserve arr(newarrsize)
                    ' Aggiungo in coda il nuovo elemento
                    arr(newarrsize) = vars
                    ' Se vars è un elenco di elementi...
                Else
                    ' Definisco un contatore interno con valore di partenza
                    ' pari al numero di elementi dell'array originale + 1
                    k = (UBound(arr) + 1)
                    ' Creo una array con tutti i nuovi elementi da aggiungere
                    newelem = Split(vars, ",")
                    ' Incremento il numero di elementi per contenere quelli nuovi
                    newarrsize = CInt(UBound(arr) + UBound(newelem) + 1)
                    ReDim Preserve arr(newarrsize)
                    ' Ciclo i nuovi elementi per aggiungerli all'array originale
                    For Each elem In newelem
                        arr(k) = Trim(elem)
                        k = k + 1
                    Next
                End If
            End If
            Array_push = arr
            ' Se arr non è una array la nostra funzione restituisce false
        Else
            Array_push = False
        End If
    End Function
    Friend Function Propper(input As String) As String
        If String.IsNullOrEmpty(input) Then
            Throw New ArgumentException("Stringa nulla o vuota")
        Else
            Dim s1 As String = input.First().ToString().ToUpper()
            Dim s2 As String = String.Join("", input.Skip(1)).ToLower
            Dim rit As String = s1 & s2
            Return (rit)
        End If
    End Function
    Friend Function G_CambiaColore(Optional LBTMP As Object = Nothing) As Task
        Select Case True
            Case Not IsNothing(LBTMP)
                Dim oldTX As String = LBTMP.Text
                LBTMP.BackColor = Color.GreenYellow
                'LBTMP.Text = "Caricando..."
                System.Windows.Forms.Application.DoEvents()
                System.Threading.Thread.Sleep(100)
                LBTMP.BackColor = Color.LightBlue
                LBTMP.Text = oldTX
        End Select

        Return Task.CompletedTask
    End Function
    Friend Function ProperCase(ByVal Testo As String) As String
        Dim sb As New System.Text.StringBuilder()
        For Each s As String In Testo.Split(New Char() {" "c})
            If sb.Length <> 0 Then
                sb.Append(" ")
            End If
            If s.Length > 0 Then
                sb.Append(s.Substring(0, 1).ToUpper())
                If s.Length > 1 Then
                    sb.Append(s.Substring(1).ToLower())
                End If
            End If
        Next
        Return sb.ToString()
    End Function
    Friend Function controlla_form_aperto(ByVal form As Form)
        Dim oForm As Form
        Dim attivo As Boolean = False
        For Each oForm In System.Windows.Forms.Application.OpenForms
            If oForm.Name = form.Name Then
                attivo = True
            End If
        Next
        Return (attivo)
    End Function
    Function MSGButton(ByVal attendi As Boolean, ByRef Tasto As ToolStripButton, ByVal Optional messaggio As String = "", Optional visibile As Boolean = Nothing)
        'Attiva o disattiva un pulsante sulla barra dove indica le informazioni
        If attendi Then
            Tasto.BackColor = Color.Orange
            Tasto.Visible = True
            If messaggio = "" Then messaggio = "ATTENDI"
            Tasto.Text = messaggio
            Tasto.Image = My.Resources.Resources.allerta48
        Else

            If messaggio = "" Then messaggio = "Annulla"
            Tasto.Text = messaggio
            If visibile = True Then
                Tasto.BackColor = Color.GreenYellow
                Tasto.Image = My.Resources.Resources.ricicla48
                Tasto.Visible = True  ' visualizza il pulsante Annulla
            Else
                Tasto.BackColor = Color.DimGray
                Tasto.Image = My.Resources.Resources.ricicla48
                Tasto.Visible = False ' nasconde il pulsante di annullamento
            End If

        End If
        Return Tasto
    End Function
    Friend Function PausaperVisualizzazione(ByVal Optional tempo As Integer = 1)    'refresh dello schermo
        System.Windows.Forms.Application.DoEvents()
        Thread.Sleep(tempo)
        Return True
    End Function

    Friend Function legge_informazioni(nome_app As String, nome_utente As String) As DataRow
        Using dt As New DS_servizioTableAdapters.TA_info_pop2
            Using ta As New DS_servizio.DT_info_pop2DataTable
                IIf(IsNothing(nome_utente), GlobalVarPOP.G_nomeutente, nome_utente)
                dt.FillByUtenteApp(ta, nome_app, nome_utente)
                If ta.Rows.Count < 1 Then
                    Return Nothing
                Else
                    For Each tt In ta
                        Console.WriteLine(tt.mese & "-" & tt.anno)
                    Next
                    Return ta.Rows(0)


                End If

            End Using
        End Using
    End Function
    Friend Function memorizza_informazioni(nome_app As String, numero_riga As Integer, nome_utente As String, nome_ri As Array) As Boolean
        Try
            Using ta As New DS_servizioTableAdapters.TA_info_pop2

                IIf(IsNothing(nome_utente), GlobalVarPOP.G_nomeutente, nome_utente)
                Dim OldID As Integer = 0
                Try
                    OldID = ta.SQ_esiste(nome_app, nome_utente)
                Catch ex As Exception

                End Try
                Dim N_riga As Integer
                Try
                    N_riga = nome_ri(2) ' EQUIVALE ALL' ID DELLA TABELLA
                Catch ex As Exception
                    N_riga = 0
                End Try
                Dim S_mese As Integer
                Dim S_anno As Integer

                Try ' prova a vedere se l' Array popolato e lo riempe in caso contrario con il mese odierno
                    S_mese = nome_ri(3)
                Catch ex As Exception
                    S_mese = Now.Month
                End Try
                Try
                    S_anno = nome_ri(4)
                Catch ex As Exception
                    S_anno = Now.Year()
                End Try

                Dim S_DT As String = nome_ri(0)
                Dim S_id As String = nome_ri(1)

                Dim stringaID
                Try
                    stringaID = nome_ri(5)
                Catch ex As Exception
                    stringaID = ""
                End Try
                If OldID > 0 Then
                    ta.QR_modifica(nome_app, numero_riga, nome_utente, 0, S_DT, S_id, N_riga, stringaID, S_mese, S_anno, OldID)
                    'modifica delle infomraizoni esistenti con i dati aggionrati per maschera e dataset
#If DEBUG Then
                    Console.WriteLine("aggiornamento riuscito")
#End If
                    'memorizza delle nuove informazioni del database e della maschera
                Else
                    ta.QR_inserisce(Now(), nome_app, numero_riga, nome_utente, 0, S_DT, S_id, N_riga, stringaID, S_mese, S_anno)
#If DEBUG Then
                    Console.WriteLine("inserimento riuscito")
#End If
                End If
            End Using
            Return True
#Disable Warning CA1031 ' Non rilevare tipi di eccezione generali
        Catch ex As Exception
#Enable Warning CA1031 ' Non rilevare tipi di eccezione generali
            Return False
        End Try
    End Function

    Public Function AggiornaComboPeriodo(ByRef cbM As ToolStripComboBox, ByRef cbA As ToolStripComboBox)
        cbA.Items.AddRange(GlobalVarPOP.G_aAnno)
        cbM.Items.AddRange(GlobalVarPOP.G_amese)
        cbM.SelectedIndex = Integer.Parse(GlobalVarPOP.GPeriodo.Split("-").Last) - 1                      'idem per il mese
        cbA.SelectedItem = GlobalVarPOP.GPeriodo.Split("-").First
        Return True
    End Function


    Friend Function ritorna_mese(n_mese As Integer)
        Dim a_mese() As String = {"Gennaio", "Febbraio", "Marzo", "Aprile", "Maggio", "Giugno", "Luglio", "Agosto", "Settembre",
                                "Ottobre", "Novembre", "Dicembre"}
        Return a_mese(If(n_mese <= 0, 1, n_mese) - 1)
    End Function
    Friend Function ConvertToTime(value As String) As TimeSpan
        Dim convertedDate As TimeSpan
        Dim DataConvertita As DateTime
        Dim TempoVuoto As New TimeSpan(0, 0, 0)
        Try
            DataConvertita = Convert.ToDateTime(value)
            convertedDate = DataConvertita.TimeOfDay
            Return (convertedDate)
        Catch e As FormatException
            Return (TempoVuoto)
        End Try
    End Function
    Friend Function TtoD(value As TimeSpan) As DateTime
        'Dim convertedDate As TimeSpan
        Dim S_tmp As String
        S_tmp = value.ToString
        Dim DataConvertita As DateTime
        Dim TempoVuoto As New DateTime(1900, 1, 1, 0, 0, 0)
        Try
            DataConvertita = "1900-01-01 " & S_tmp
            Return (DataConvertita)
        Catch e As FormatException
            Return (TempoVuoto)
        End Try
    End Function
    Public Function ControllaeFormattaNumeri(ByVal dato As Object) As String
        'Dim tipo As CultureInfo = CultureInfo.CreateSpecificCulture("en-US")
        If dato = Nothing Then
            Return "0.00"
        End If
        If dato = 0 Then
            Return "0.00"
        End If
        dato = CType(dato, Decimal)
        dato = Format(dato, "N2")
        'elimina i punti dalle migliaia
        dato = dato.ToString.Replace(".", "")
        'sostituisce il punto alla virgola
        dato = dato.ToString.Replace(",", ".")
        'dato = String.Format(dato, "#########.##", tipo)

        Return dato
    End Function

    Friend Function DataMysql(value As DateTime) As String
        Dim S_tmp As String
        S_tmp = value.Year.ToString & "/" & value.Month.ToString & "/" & value.Day.ToString
        Return (S_tmp)
    End Function
    Friend Function CambiaColore(Optional LBTMP As Label = Nothing, Optional TX As TextBox = Nothing, Optional TTX As ToolStripTextBox = Nothing)
        Select Case True
            Case Not IsNothing(TTX)
                TTX.BackColor = System.Drawing.Color.DarkRed
                System.Windows.Forms.Application.DoEvents()
                System.Threading.Thread.Sleep(100)
                'Task.Delay(1000).ConfigureAwait(False) ' due secondi
                TTX.BackColor = System.Drawing.SystemColors.Control
            Case Not IsNothing(LBTMP)
                Dim oldTX As String = LBTMP.Text
                LBTMP.BackColor = System.Drawing.Color.GreenYellow
                TX.BackColor = System.Drawing.Color.DarkRed
                LBTMP.Text = "Caricando..."
                System.Windows.Forms.Application.DoEvents()
                System.Threading.Thread.Sleep(100)
                LBTMP.BackColor = System.Drawing.SystemColors.Control
                LBTMP.Text = oldTX
                TX.BackColor = System.Drawing.SystemColors.Control
            Case IsNothing(LBTMP)
                System.Windows.Forms.Application.DoEvents()
                System.Threading.Thread.Sleep(100)
                'Await Task.Delay(1000).ConfigureAwait(False) ' due secondi
        End Select
        Return True
    End Function
    Public Function CriptoSHA(ByVal filePath As String) As String
        Dim shastring As String
        Using sha As SHA1CryptoServiceProvider = New SHA1CryptoServiceProvider ' declare sha as a new SHA1CryptoServiceProvider
            Using f As FileStream = New FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)
                'f = New FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)
                sha.ComputeHash(f)
                Dim hash As Byte() = sha.Hash
                Dim buff As StringBuilder = New StringBuilder
                Dim hashByte As Byte
                For Each hashByte In hash
                    buff.Append(String.Format("{0:X2}", hashByte))
                Next
                shastring = buff.ToString()
                buff.Clear()
            End Using
        End Using
        Return shastring.ToLower

    End Function
    Function GenerateFileMD5(ByVal filePath As String)
        Dim md5string As String
        Using md5 As MD5CryptoServiceProvider = New MD5CryptoServiceProvider

            Using f As FileStream = New FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)
                'f = New FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)
                md5.ComputeHash(f)
                f.Close()
                Dim hash As Byte() = md5.Hash
                Dim buff As StringBuilder = New StringBuilder
                Dim hashByte As Byte
                f.Dispose()
                md5.Dispose()
                For Each hashByte In hash
                    buff.Append(String.Format("{0:X2}", hashByte))
                Next
                md5string = buff.ToString()
            End Using
        End Using

        Return md5string.ToLower
    End Function
    Public Sub impostaPermessiFile(ByVal path As String, ByVal account As String)
        Try
            'apro il file
            Using fs As New FileStream(path, FileMode.Open, FileAccess.ReadWrite)
                'recupero la lista di accessi
                Dim _fileSecurity As FileSecurity = fs.GetAccessControl()
                'creo una nuova regola dicendogli che l'utente può leggere ed eseguire
                Dim fsnewRule As New FileSystemAccessRule(account, FileSystemRights.ReadAndExecute, AccessControlType.Allow)
                'applico la regola al file
                _fileSecurity.AddAccessRule(fsnewRule)
                File.SetAccessControl(path, _fileSecurity)
            End Using

#Disable Warning CA1031 ' Non rilevare tipi di eccezione generali
        Catch ex As Exception
#Enable Warning CA1031 ' Non rilevare tipi di eccezione generali
            Console.WriteLine(ex.Message)

        End Try
    End Sub

    'Questa Funzione restituisce una tabella per gestire i giorni di ferie
    'Utilizzata da frmDipendenti
    'Utilizzata da frmDipendentiFerie
    '
    '
    Friend Function NewDToremese() As DataTable 'Crea una DT e la popola con i valori passati dal bindingsource
        Dim Ute As DataTable = New DataTable
        Ute.Namespace = "TABtmpUte"
        Dim CliRow As DataRow
        Dim colonna As DataColumn
        colonna = New DataColumn
        colonna.ColumnName = "id_utente"
        colonna.DataType = Type.GetType("System.Int32")
        Ute.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "id_cliente"
        colonna.DataType = Type.GetType("System.Int32")
        Ute.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "id_dettaglio"
        colonna.DataType = Type.GetType("System.Int32")
        Ute.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "anagrafica"
        colonna.DataType = Type.GetType("System.String")
        Ute.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "societa"
        colonna.DataType = Type.GetType("System.String")
        Ute.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "dettaglio"
        colonna.DataType = Type.GetType("System.String")
        Ute.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "lun"
        colonna.DataType = Type.GetType("System.Decimal")
        Ute.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "mar"
        colonna.DataType = Type.GetType("System.Decimal")
        Ute.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "mer"
        colonna.DataType = Type.GetType("System.Decimal")
        Ute.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "gio"
        colonna.DataType = Type.GetType("System.Decimal")
        Ute.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "ven"
        colonna.DataType = Type.GetType("System.Decimal")
        Ute.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "sab"
        colonna.DataType = Type.GetType("System.Decimal")
        Ute.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "dom"
        colonna.DataType = Type.GetType("System.Decimal")
        Ute.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "idtipoSost"
        colonna.DataType = Type.GetType("System.Int32")
        Ute.Columns.Add(colonna)

        Return Ute
    End Function
    Friend Function NewDToremeseCliente() As DataTable 'Crea una DT e la popola con i valori passati dal Datatable
        Dim Cli As DataTable = New DataTable
        Cli.Namespace = "TABtmpCli"
        Dim CliRow As DataRow
        Dim colonna As DataColumn
        colonna = New DataColumn
        colonna.ColumnName = "ordine"
        colonna.DataType = Type.GetType("System.Int32")
        Cli.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "id_utente"
        colonna.DataType = Type.GetType("System.Int32")
        Cli.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "id_cliente"
        colonna.DataType = Type.GetType("System.Int32")
        Cli.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "id_dettaglio"
        colonna.DataType = Type.GetType("System.Int32")
        Cli.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "anagrafica"
        colonna.DataType = Type.GetType("System.String")
        Cli.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "societa"
        colonna.DataType = Type.GetType("System.String")
        Cli.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "dettaglio"
        colonna.DataType = Type.GetType("System.String")
        Cli.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "lun"
        colonna.DataType = Type.GetType("System.Decimal")
        Cli.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "olun"
        colonna.DataType = Type.GetType("System.String")
        Cli.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "mar"
        colonna.DataType = Type.GetType("System.Decimal")
        Cli.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "omar"
        colonna.DataType = Type.GetType("System.String")
        Cli.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "mer"
        colonna.DataType = Type.GetType("System.Decimal")
        Cli.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "omer"
        colonna.DataType = Type.GetType("System.String")
        Cli.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "gio"
        colonna.DataType = Type.GetType("System.Decimal")
        Cli.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "ogio"
        colonna.DataType = Type.GetType("System.String")
        Cli.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "ven"
        colonna.DataType = Type.GetType("System.Decimal")
        Cli.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "oven"
        colonna.DataType = Type.GetType("System.String")
        Cli.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "sab"
        colonna.DataType = Type.GetType("System.Decimal")
        Cli.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "osab"
        colonna.DataType = Type.GetType("System.String")
        Cli.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "dom"
        colonna.DataType = Type.GetType("System.Decimal")
        Cli.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "odom"
        colonna.DataType = Type.GetType("System.String")
        Cli.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "idtipoSost"
        colonna.DataType = Type.GetType("System.Int32")
        Cli.Columns.Add(colonna)

        Return Cli
    End Function
    '
    'Funzione che carica le ore pianificate del dipendente
    'chiamata da frmDipendenti
    'chiamata da frmDipendentiFerie
    '
    Friend Function CaricaDatiOreDipendente(ByRef cli As DataTable, ByRef bstmp As BindingSource)
        'Dim rgWeb As DataRow 'DS_utenti.DT_orariRow
        Dim CliRow As DataRow
        If Not IsNothing(bstmp) Then
            For Each hg In bstmp
                CliRow = cli.NewRow
                CliRow("id_utente") = hg("id_dip")
                CliRow("anagrafica") = hg("anagrafica")
                CliRow("id_cliente") = 0
                CliRow("societa") = ""
                CliRow("id_dettaglio") = hg("id_des")
                CliRow("dettaglio") = hg("locazione")
                CliRow("lun") = TimeSpan.Parse(hg("T_lu")).TotalHours
                CliRow("mar") = TimeSpan.Parse(hg("T_ma")).TotalHours
                CliRow("mer") = TimeSpan.Parse(hg("T_me")).TotalHours
                CliRow("gio") = TimeSpan.Parse(hg("T_gi")).TotalHours
                CliRow("ven") = TimeSpan.Parse(hg("T_ve")).TotalHours
                CliRow("sab") = TimeSpan.Parse(hg("T_sa")).TotalHours
                CliRow("dom") = TimeSpan.Parse(hg("T_do")).TotalHours
                CliRow("idtipoSost") = 0
                cli.Rows.Add(CliRow)
            Next
        End If
        Return cli
    End Function
    Friend Function CaricaDatiOreCliente(ByRef cli As DataTable, ByRef bsTmp As BindingSource)
        'Dim rgWeb As DS_clienti.DT_orariRow
        Dim CliRow As DataRow
        If Not IsNothing(bsTmp) Then
            For Each hg In bsTmp
                CliRow = cli.NewRow
                CliRow("ordine") = 1
                CliRow("id_utente") = hg(".id_dip")
                CliRow("anagrafica") = hg("anagrafica")
                CliRow("id_cliente") = hg("id_cli")
                CliRow("societa") = hg("societa")
                CliRow("id_dettaglio") = hg("id_des")
                CliRow("dettaglio") = hg("locazione")
                CliRow("lun") = TimeSpan.Parse(hg("T_lu")).TotalHours
                CliRow("olun") = String.Format("{0} | {1}", hg("lu_i"), hg("lu_u"))
                CliRow("mar") = TimeSpan.Parse(hg("T_ma")).TotalHours
                CliRow("omar") = String.Format("{0} | {1}", hg("ma_i"), hg("ma_u"))
                CliRow("mer") = TimeSpan.Parse(hg("T_me")).TotalHours
                CliRow("omer") = String.Format("{0} | {1}", hg("me_i"), hg("me_u"))
                CliRow("gio") = TimeSpan.Parse(hg("T_gi")).TotalHours
                CliRow("ogio") = String.Format("{0} | {1}", hg("gi_i"), hg("gi_u"))
                CliRow("ven") = TimeSpan.Parse(hg("T_ve")).TotalHours
                CliRow("oven") = String.Format("{0} | {1}", hg("ve_i"), hg("ve_u"))
                CliRow("sab") = TimeSpan.Parse(hg("T_sa")).TotalHours
                CliRow("osab") = String.Format("{0} | {1}", hg("sa_i"), hg("sa_u"))
                CliRow("dom") = TimeSpan.Parse(hg("T_do")).TotalHours
                CliRow("odom") = String.Format("{0} | {1}", hg("do_i"), hg("do_u"))
                cli.Rows.Add(CliRow)
            Next
        End If
        Return cli
    End Function

    '
    'Funzione che carica i dettagli delle sostituzioni
    'Chiamata da frmDipendenti
    'chiamata da frmDipendentiFerie
    '
    Friend Function CaricaDettagliSostituzioni(ByRef DT As DataTable, ByVal dtSost As DataTable) As DataTable

        Dim riganuova As DataRow = DT.NewRow
        Dim ListaOrari
        'Ordina la tabella per cliente e Giorno
        ListaOrari = dtSost.AsEnumerable().GroupBy(Function(row) New With {
                Key .id_utente = row.Field(Of Int32)("iddip"),
                Key .anagrafica = row.Field(Of String)("anagrafica"),
                Key .id_dettaglio = row.Field(Of Int32)("iddes"),
                Key .dettaglio = row.Field(Of String)("locazione")
                }).ToList
        For Each hg In ListaOrari

            Dim nuovaRiga As DataRow
            nuovaRiga = DT.NewRow
            nuovaRiga("id_utente") = hg.key.id_utente
            nuovaRiga("anagrafica") = hg.key.anagrafica
            nuovaRiga("id_dettaglio") = hg.key.id_dettaglio
            nuovaRiga("dettaglio") = hg.key.dettaglio
            nuovaRiga("id_cliente") = 0
            nuovaRiga("societa") = ""

            nuovaRiga("lun") = 0
            nuovaRiga("mar") = 0
            nuovaRiga("mer") = 0
            nuovaRiga("gio") = 0
            nuovaRiga("ven") = 0
            nuovaRiga("sab") = 0
            nuovaRiga("dom") = 0
            nuovaRiga("idtipoSost") = 1
            'AssegnaTotaleOreperGiornoSettimana(hhg.data, hhg.ing, hhg.usc, 6)
            DT.Rows.Add(nuovaRiga)

        Next
        Return DT
    End Function
    '
    '
    'Funzione che carica le ore da contratto del dipendente
    'Chiamata da frmDipendenti
    'chiamata da frmDipendentiFerie
    'bisogna passargli la tabella creata precedentemente e il binding delle ore da contratto
    '
    Friend Function CalcolaOraridaContrattoDipendenti(ByRef Cli As DataTable, ByRef bs As BindingSource) As DataTable


        '
        'Carica i dati relativi al programma orario

        If bs.Count <= 0 Then
            '
            'Ritorna la tabella Vuota
            '
            Return Cli
        End If
        '
        '
        'Definisce ListaOrari come nuova tabella di Cli
        Dim ListaOrari = Cli.AsEnumerable().GroupBy(Function(row) New With {
            Key .id_utente = row.Field(Of Int32)("id_utente"),
            Key .anagrafica = row.Field(Of String)("anagrafica"),
            Key .id_dettaglio = row.Field(Of Int32)("id_dettaglio"),
            Key .dettaglio = row.Field(Of String)("dettaglio"),
            Key .idTipoSost = row.Field(Of Int32)("idtipoSost")
        })

        Dim CliRaggruppata = Cli.Clone()

        'Memorizza in Cliraggruppata i valori di Listaorari le chiavi di raggruppamento sono dettaglio cliente e Dipendente
        For Each grp In ListaOrari
            CliRaggruppata.Rows.Add(grp.Key.id_utente, 0, grp.Key.id_dettaglio,
                                        grp.Key.anagrafica, "", grp.Key.dettaglio,
                                        grp.Sum(Function(row) row.Field(Of Decimal)("lun")),
                                        grp.Sum(Function(row) row.Field(Of Decimal)("mar")),
                                        grp.Sum(Function(row) row.Field(Of Decimal)("mer")),
                                        grp.Sum(Function(row) row.Field(Of Decimal)("gio")),
                                        grp.Sum(Function(row) row.Field(Of Decimal)("ven")),
                                        grp.Sum(Function(row) row.Field(Of Decimal)("sab")),
                                        grp.Sum(Function(row) row.Field(Of Decimal)("dom")),
                                        grp.Key.idTipoSost)
        Next

        'Definisce una nuova listaorari1 
        Dim ListaOrari1 = Cli.AsEnumerable().GroupBy(Function(row) New With {
            Key .id_cliente = row.Field(Of Int32)("id_cliente")
        })
        'Aggiunge in Cliraggruppata i valori di ListaOrari1 (la chiave di raggruppamento è id_cliente)
        Dim TabellaOrdinata As New DataTable
        TabellaOrdinata = OrdinaTabella(CliRaggruppata, "dettaglio ASC, anagrafica ASC")

        Return TabellaOrdinata
    End Function
    '
    '
    'Funzione che ordina una tabella
    '
    'Chiamata da frmDipendenti
    'chiamata da frmDipendentiFerie
    'passare tabella e campo per la quale ordinarla, ritorna una tabella ordinata
    '
    Friend Function OrdinaTabella(ByVal tabella As DataTable, ByVal Campo As String) As DataTable
        Dim view As DataView = tabella.DefaultView
        view.Sort = Campo
        Return view.ToTable()
    End Function
    '
    'Funzione che rilascia il totale tra l'ingresso e l'uscita della tabella piano di lavoro
    '
    'Chiamata da frmDipendenti
    'chiamata da frmDipendentiFerie
    'passare tabella, il giorno per il quale si vuole il totale e il dettaglio cliente
    '
    Friend Function AssegnaTotaleOreperGiornoSettimana(ByVal dt As DataTable, ByVal Giorno As DateTime, ByVal idDes As Integer) As Decimal

        Dim bs As New BindingSource
        bs.DataSource = dt
        bs.Filter = String.Format("data = '{0}' AND iddes = {1}", Giorno.Year.ToString + "/" + Giorno.Month.ToString + "/" + Giorno.Day.ToString + " 00:00:00", idDes)
        If bs.Count > 0 Then
            Dim riga As DataRow = DirectCast(bs.Current, DataRowView).Row
            AssegnaTotaleOreperGiornoSettimana = riga("usc").TotalHours - riga("ing").TotalHours
        Else
            AssegnaTotaleOreperGiornoSettimana = 0
        End If
        Return AssegnaTotaleOreperGiornoSettimana
    End Function

    Public Class DataGridViewRolloverCell
        Inherits DataGridViewTextBoxCell
        Private _identifico As Integer

        Protected Overrides Sub Paint(
            ByVal graphics As Graphics,
            ByVal clipBounds As Rectangle,
            ByVal cellBounds As Rectangle,
            ByVal rowIndex As Integer,
            ByVal elementState As DataGridViewElementStates,
            ByVal value As Object,
            ByVal formattedValue As Object,
            ByVal errorText As String,
            ByVal cellStyle As DataGridViewCellStyle,
            ByVal advancedBorderStyle As DataGridViewAdvancedBorderStyle,
            ByVal paintParts As DataGridViewPaintParts)

            ' Call the base class method to paint the default cell appearance.
            MyBase.Paint(graphics, clipBounds, cellBounds, rowIndex, elementState,
                value, formattedValue, errorText, cellStyle,
                advancedBorderStyle, paintParts)

            ' Retrieve the client location of the mouse pointer.
            Dim cursorPosition As Point =
                Me.DataGridView.PointToClient(Cursor.Position)

            ' If the mouse pointer is over the current cell, draw a custom border.
            If cellBounds.Contains(cursorPosition) Then
                Dim newRect As New Rectangle(cellBounds.X + 1,
                    cellBounds.Y + 1, cellBounds.Width - 4,
                    cellBounds.Height - 4)
                graphics.DrawRectangle(Pens.Red, newRect)
            End If

        End Sub
        Overloads Property TagX As Integer
            Get
                Return _identifico
            End Get
            Set(value As Integer)
                _identifico = value
            End Set
        End Property

        ' Force the cell to repaint itself when the mouse pointer enters it.
        Protected Overrides Sub OnMouseEnter(ByVal rowIndex As Integer)
            Me.DataGridView.InvalidateCell(Me)
        End Sub

        ' Force the cell to repaint itself when the mouse pointer leaves it.
        Protected Overrides Sub OnMouseLeave(ByVal rowIndex As Integer)
            Me.DataGridView.InvalidateCell(Me)
        End Sub

    End Class


    Public Function ApprossimaOrario(ByVal ora As TimeSpan, ByVal Approssimazione As Decimal) As TimeSpan
        Dim I, ExitVal As Integer

        'tengo salvati i minuti
        Dim minuti As Integer = ora.Minutes
        ExitVal = minuti
        Dim Resto As Integer = minuti Mod Approssimazione

        Select Case Resto
            Case > 0
                For I = Approssimazione To 60 Step Approssimazione
                    If minuti < I - Approssimazione Then
                        ExitVal = I - Approssimazione
                        Exit For
                    ElseIf minuti > (I - Approssimazione) And minuti < I Then
                        If minuti > (I - (Approssimazione / 2)) And minuti < I Then
                            ExitVal = I ' se è più vicino al numero finale
                            Exit For
                        Else
                            ExitVal = I - Approssimazione 'se è più vicino al numero iniziale
                            Exit For
                        End If
                    End If
                Next I
        End Select
        minuti = ExitVal
        'ritorno l'orario approssimato
        ApprossimaOrario = New TimeSpan(ora.Hours, minuti, 0)
    End Function
    Public Function ConvertToDateTime(value As String) As TimeSpan
        Dim convertedDate As TimeSpan
        Dim DataConvertita As DateTime
        Dim TempoVuoto As New TimeSpan(0, 0, 0)
        Try
            DataConvertita = Convert.ToDateTime(value)
            convertedDate = DataConvertita.TimeOfDay
            Console.WriteLine("'{0}' converts to {1}.", value, convertedDate)
            Return (convertedDate)

        Catch e As FormatException
            Console.WriteLine("'{0}' is not in the proper format.", value)
            Return (TempoVuoto)

        End Try
    End Function
    Public Function Rimodella_e_memorizza_Immagine(ByVal source As String, ByVal destination As String, ByVal altezza As Integer, ByVal larghezza As Integer, ByVal qualita As Integer) As Boolean
        Try
            Dim bmp1 As New Bitmap(source)
            Dim valori(1) As Integer
            valori(0) = bmp1.Width
            valori(1) = bmp1.Height

            Dim maxValue As Integer = valori.Max()
            Dim destinationX As Integer
            Dim destinationY As Integer
            Select Case maxValue
                Case valori(0)
                    'Larghezza fissa
                    destinationX = larghezza
                    destinationY = CInt((destinationX / valori(0) * valori(1)))
                Case valori(1)
                    'Altezza fissa
                    destinationY = altezza
                    destinationX = CInt((destinationY / valori(1) * valori(0)))

            End Select


            Dim bmp2 As New Bitmap(destinationX, destinationY, PixelFormat.Format24bppRgb)
            Dim g As Graphics = Graphics.FromImage(bmp2)
            g.InterpolationMode = InterpolationMode.HighQualityBicubic
            g.DrawImage(bmp1, 0, 0, bmp2.Width, bmp2.Height)
            g.Dispose()

            Dim jgpEncoder As ImageCodecInfo = GetEncoder(ImageFormat.Jpeg)
            Dim myEncoder As System.Drawing.Imaging.Encoder = System.Drawing.Imaging.Encoder.Quality
            Dim myEncoderParameters As New EncoderParameters(1)
            Dim myEncoderParameter As New EncoderParameter(myEncoder, qualita)
            myEncoderParameters.Param(0) = myEncoderParameter
            bmp2.Save(destination, jgpEncoder, myEncoderParameters)
            bmp1.Dispose()
            bmp2.Dispose()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Friend Function GetEncoder(ByVal format As ImageFormat) As ImageCodecInfo

        Dim codecs As ImageCodecInfo() = ImageCodecInfo.GetImageEncoders()
        Dim codec As ImageCodecInfo
        For Each codec In codecs
            If codec.FormatID = format.Guid Then
                Return codec
            End If
        Next codec
        Return Nothing

    End Function


End Module
