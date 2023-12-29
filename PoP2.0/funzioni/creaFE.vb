Imports System.Text
Imports System.IO
Imports System.Xml
Imports System.Xml.Serialization


Module creaFE
    Dim BS_righe As BindingSource
    Dim Path As String

    Public Sub nuova(ByVal trasmittente As DataRow, ByVal Fattura As DataTable, ByVal righe As DataTable, ByVal Percorso As String)
        Path = Percorso
        BS_righe = New BindingSource
        Dim rg_prestatore As DS_FE.DT_aziendaRow
        Dim rg_trasmittente As DS_FE.DT_trasmittenteRow


        rg_trasmittente = DirectCast(trasmittente, DS_FE.DT_trasmittenteRow)

        Using az As New DS_FETableAdapters.TA_azienda
            Using rg As New DS_FE.DT_aziendaDataTable
                az.Fill(rg)
                rg_prestatore = DirectCast(rg.First, DataRow)
            End Using
        End Using
        'Using Az As New DS_FETableAdapters.TA_trasmittente
        '    Using rg As New DS_FE.DT_trasmittenteDataTable
        '        Az.Fill(rg)
        '        rg_trasmittente = DirectCast(rg.First, DataRow)
        '    End Using
        'End Using

        BS_righe.DataMember = righe.TableName
        BS_righe.DataSource = righe

        Dim RGFat As DS_FE.DT_fatturaFERow
        If Fattura.Rows.Count < 1 Then
            MsgBox("Problemi nel caricare la fattura. Verifica i dati del cliente o della Fattura", MsgBoxStyle.OkOnly)
            Return
        End If
        RGFat = Fattura.Rows(0)
        Dim f As funzioni
        ScriveXML(rg_trasmittente, rg_prestatore, RGFat, 0)
        BS_righe.Dispose()

    End Sub
    Public Sub ScriveXML(ByVal dati_trasm As DataRow, ByVal dati_prest As DataRow, ByVal dati_cessa As DataRow, Optional ByRef numeroFatte As Integer = 0) ' dati trasmittente,prestatore,cessionario

        Dim dtras As DS_FE.DT_trasmittenteRow
        dtras = dati_trasm
        Dim dcess As DS_FE.DT_fatturaFERow
        dcess = dati_cessa
        Dim dpres As DS_FE.DT_aziendaRow
        dpres = dati_prest
        Dim id_cessionario As Object    ' identificativo cessionario
        Dim Progressivo As Integer
        If dcess.Is_114_codicedestinatarioNull Then
            'se non è presente il codicedestinatario salta
            dcess._114_codicedestinatario = ""
            'Return
        Else
            id_cessionario = (TryCast(dcess._114_codicedestinatario, String))
            Dim s_prog As Object = dcess.fat_num_da.Split("/").First

            Progressivo = CType(s_prog, Integer)
            'Progressivo = recupera_prog(dcess.fat_data.Year, dcess.fat_num_da)
            numeroFatte += 1
        End If
        'inizio creazione
        Dim nodoPrincipale As New FatturaElettronica()
        Dim overviewIntestazione As New FatturaElettronicaHeader()
        Dim datiTrasmissione As New DatiTrasmissione()
        Dim idTrasmittente As New IdTrasmittente()

        '@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
        idTrasmittente.IdPaese = dtras.idPaese
        idTrasmittente.IdCodice = dtras.idCodice
        datiTrasmissione.IdTrasmittente = idTrasmittente

        datiTrasmissione.ProgressivoInvio = Progressivo.ToString.PadLeft(6, "0") ' inserire il numero progressivo di trasmissione
        If dcess.pa Then
            datiTrasmissione.FormatoTrasmissione = "FPA12"  'codice FPR12 per Privati e FPA12 per PA
        Else
            datiTrasmissione.FormatoTrasmissione = "FPR12"  'codice FPR12 per Privati e FPA12 per PA
        End If
        'identifica se è presente il codice destinatario o la pec
        If id_cessionario = Nothing Then
            id_cessionario = "0000000"
        End If
        If id_cessionario.ToString = "0000000" Or id_cessionario.ToString.Length < 7 Then
            datiTrasmissione.CodiceDestinatario = "0000000"
            If dcess.Is_116_pecdestinatarioNull Then
                dcess._116_pecdestinatario = "nulla"
                If MsgBox("manca il codice destinatario e la PEC " & dcess.societa & " è un privato?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    Return
                End If


            End If
            'If dcess._116_pecdestinatario.Length = 0 Then
            '    MsgBox("non posso proseguire, manca il codice destinatario o la PEC")
            '    Return
            'End If
            datiTrasmissione.CodiceDestinatario = id_cessionario
            If dcess._116_pecdestinatario.Contains("@") Then
                datiTrasmissione.PECDestinatario = dcess._116_pecdestinatario
            Else
                'datiTrasmissione.PECDestinatario = ""
            End If

        Else
            'se il codice destinatario non é a 0
            datiTrasmissione.CodiceDestinatario = id_cessionario
        End If


        Dim ContattiTrasmittente As New ContattiTrasmittente()
        ContattiTrasmittente.Telefono = dtras.Telefono
        ContattiTrasmittente.Email = dtras.Email
        datiTrasmissione.ContattiTrasmittente = ContattiTrasmittente
        'Scrivi XML
        overviewIntestazione.DatiTrasmissione = datiTrasmissione
        '@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
        ' Blocco 1.2 Cedente Prestatore
        Dim cedentePrestatore As New CedentePrestatore()
        Dim datiAnagrafici As New DatiAnagrafici()
        '   Blocco 1.2.1
        Dim idFiscaleIVA As New IdFiscaleIVA()
        idFiscaleIVA.IdPaese = dpres.Nazione.Substring(0, 2).ToUpper
        idFiscaleIVA.IdCodice = dpres.partita_IVA
        datiAnagrafici.IdFiscaleIVA = idFiscaleIVA
        idFiscaleIVA = Nothing
        '       Blocco 1.2.1.3
        Dim anagrafica As New Anagrafica()
        anagrafica.Denominazione = dpres.ragione_sociale

        datiAnagrafici.Anagrafica = anagrafica
        datiAnagrafici.RegimeFiscale = "RF01" ' RF01 ordinario / RF18 Altro
        '
        cedentePrestatore.DatiAnagrafici = datiAnagrafici
        '   Blocco 1.2.2
        Dim sede As New Sede()
        sede.Indirizzo = Split(dpres.indirizzo_leg, ",").First
        sede.NumeroCivico = Split(dpres.indirizzo_leg, ",").Last
        sede.CAP = dpres.cap_leg
        sede.Comune = dpres.localita_leg
        sede.Provincia = dpres.provincia_leg.ToUpper.Substring(0, 2)
        sede.Nazione = dpres.Nazione.ToUpper.Substring(0, 2).ToUpper
        '
        cedentePrestatore.Sede = sede

        '   Blocco 1.2.3
        Dim stabileOrganizzazione As New StabileOrganizzazione()
        stabileOrganizzazione.Indirizzo = Split(dpres.indirizzo_ope, ",").First
        stabileOrganizzazione.NumeroCivico = Split(dpres.indirizzo_ope, ",").Last
        stabileOrganizzazione.CAP = dpres.cap_ope
        stabileOrganizzazione.Comune = dpres.localita_ope
        stabileOrganizzazione.Provincia = dpres.provincia_ope.ToUpper.Substring(0, 2)
        stabileOrganizzazione.Nazione = dpres.Nazione.ToUpper.Substring(0, 2).ToUpper
        '
        cedentePrestatore.StabileOrganizzazione = stabileOrganizzazione
        ''   Blocco 1.2.4
        Dim iscrizionerea As New IscrizioneREA
        iscrizionerea.Ufficio = "MI"
        iscrizionerea.NumeroREA = dpres.cciaa
        iscrizionerea.CapitaleSociale = ControllaeFormattaNumeri(dpres.capitale_cap)
        iscrizionerea.SocioUnico = "SM"
        iscrizionerea.StatoLiquidazione = "LN"
        '
        cedentePrestatore.IscrizioneREA = iscrizionerea
        'Scrivi XML

        overviewIntestazione.CedentePrestatore = cedentePrestatore
        '@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
        'Blocco 1.4 Cessionaria Committente
        Dim cessionarioCommittente As New CessionarioCommittente()
        '   Blocco 1.4.1 Dati anagrafici CESSIONARIO (Cliente)
        Dim datiAnagraficiCommittente As New DatiAnagrafici()
        '       Blocco 1.4.1.1
        'se è un condominio o se è una onlus o altro, non crea la riga IVA
        Dim datiRitenuta As New DatiRitenuta()

        If dcess.condomino = 0 And dcess.l_mobile = 0 Then
            idFiscaleIVA = New IdFiscaleIVA()
            idFiscaleIVA.IdPaese = "IT"
            idFiscaleIVA.IdCodice = dcess.partitaiva
            datiAnagraficiCommittente.IdFiscaleIVA = idFiscaleIVA
        End If
        'Blocco 1.4.1.2  ' se il codice fiscale è presente
        'Se è un privato carica il codicefiscale
        If dcess.cf.Length > 0 And dcess.l_mobile = 1 Then
            datiAnagraficiCommittente.CodiceFiscale = dcess.cf
        End If
        '       Blocco 1.4.1.3
        Dim anagraficaCommittente As New Anagrafica()
        anagraficaCommittente.Denominazione = dcess.societa
        datiAnagraficiCommittente.Anagrafica = anagraficaCommittente
        cessionarioCommittente.DatiAnagrafici = datiAnagraficiCommittente

        'Blocco 1.4.2
        Dim sedeCommittente As New Sede()
        sedeCommittente.Indirizzo = dcess.address

        sedeCommittente.CAP = dcess.postalcode
        sedeCommittente.Comune = dcess.city
        sedeCommittente.Provincia = dcess._region.ToUpper.Substring(0, 2)
        sedeCommittente.Nazione = If(dcess.state <> "", dcess.state.Substring(0, 2).ToUpper, "IT")
        cessionarioCommittente.Sede = sedeCommittente
        'Blocco 1.4.3   Solo se non si ha uno stabile in italia
        'Blocco 1.4.4   Rappresentante Fiscale
        'Scrivi XML
        overviewIntestazione.CessionarioCommittente = cessionarioCommittente
        overviewIntestazione.SoggettoEmittente = "CC"   ' cessionario / committente
        'Chiude il blocco 1.4

        '@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
        'Scrivi XML nodo FatturaElettronicaHeader 

        '@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
        'Chiude il blocco Intestazione

        '@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
        'apre il blocco 2   Corpo Fattura
        Dim overviewCorpo As New FatturaElettronicaBody()
        'Blocco 2.1
        ' il blocco 2.1 è stato spostato più avanti per poter inserire il totale documento

        '@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ò   Cicla con Distinzione per codici IVA
        'Blocco 2.2 DatiBeniServizi
        Dim datiBeniServizi As New DatiBeniServizi()
        Dim totalePagamento As Decimal = 0
        Dim TotaleRitenuta As Decimal = 0
        Using ta_IVA As New DS_FETableAdapters.TA_sommaFE
            Using dt_IVA As New DS_FE.DT_sommeFEDataTable
                ta_IVA.FillByIDFattura(dt_IVA, dcess.fat_num_da)
                Dim rg_IVA As DS_FE.DT_sommeFERow
                Dim listaLinee As New List(Of DettaglioLinee)()
                For Each rg_IVA In dt_IVA.Rows
                    Dim nRiga As Integer = 0
                    Dim dt_rg As DS_FE.DT_righeFERow
                    BS_righe.Filter = String.Format("cfa_fa_num = '{0}' and cod_iva = {1} ", dcess.fat_num_da, rg_IVA.cfa_rc)
                    If BS_righe.Count <= 0 Then
                        MsgBox("Nessuna corrispondenza")
                        Return
                    End If
                    For Each det_righe In BS_righe  'scorre le righe che soddisfano lo stesso criterio di codice iva
                        nRiga += 1
                        'Blocco 2.2.1
                        Dim dettaglioLinee As New DettaglioLinee()
                        dt_rg = DirectCast(det_righe, DataRowView).Row
                        dettaglioLinee.NumeroLinea = nRiga
                        dettaglioLinee.Descrizione = dt_rg.cfa_des
                        dettaglioLinee.Quantita = ControllaeFormattaNumeri(dt_rg.cfa_quanti)
                        dettaglioLinee.PrezzoUnitario = ControllaeFormattaNumeri(dt_rg.cfa_prezzo)
                        'se è presente uno sconto, valorizza questi campi
                        Dim scontoApplicato As Decimal = 0
                        If dt_rg.cfa_sconto <> 0 Then
                            Dim scontoemaggiorazione As New ScontoMaggiorazione
                            scontoemaggiorazione.Percentuale = ControllaeFormattaNumeri(dt_rg.cfa_sconto)
                            scontoemaggiorazione.Tipo = "SC"
                            'imposta l'importo dello sconto
                            scontoemaggiorazione.Importo = ControllaeFormattaNumeri((dt_rg.cfa_prezzo * dt_rg.cfa_sconto) / 100)
                            dettaglioLinee.ScontoMaggiorazione = scontoemaggiorazione
                            scontoApplicato = ((dt_rg.cfa_prezzo * dt_rg.cfa_sconto) / 100)
                        End If
                        dettaglioLinee.PrezzoTotale = ControllaeFormattaNumeri(dt_rg.cfa_quanti * (dt_rg.cfa_prezzo - scontoApplicato))
                        If dt_rg.cod_FE.Trim.Length <> 0 Then
                            If dt_rg.cod_FE = "S" Then
                                'dettaglioLinee.Natura = "" 'impostare N6 se reverse Charge
                            Else
                                dettaglioLinee.Natura = dt_rg.cod_FE
                            End If
                        End If
                        dettaglioLinee.AliquotaIVA = ControllaeFormattaNumeri(dt_rg.valoreiva)
                        listaLinee.Add(dettaglioLinee)
                    Next
                Next
                datiBeniServizi.DettaglioLinee = listaLinee


                '@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ò   
                'Blocco 2.2.2 riepilogo per tipo di IVA
                Dim listaRiepilogo As New List(Of DatiRiepilogo)()

                Dim Riep As DS_FE.DT_sommeFERow
                'Dim c As Integer = BS_sommaFE.Count
                For Each det_riep In dt_IVA  'scorre le righe che soddisfano lo stesso criterio di codice iva
                    Dim datiRiepilogo As New DatiRiepilogo()
                    Riep = det_riep
                    Dim valoreRiepilogoIVA As Decimal
                    valoreRiepilogoIVA = Math.Round(Riep.imposta, 2)
                    Select Case Riep.cod_FE
                        Case "S"    'se è previsto lo split payement
                            datiRiepilogo.EsigibilitaIVA = "S"
                            datiRiepilogo.RiferimentoNormativo = Riep.descrizione
                            totalePagamento = totalePagamento + Riep.scontato

                        Case Else
                            datiRiepilogo.EsigibilitaIVA = "I"
                            If Riep.cod_FE.Trim() <> "" Then
                                datiRiepilogo.Natura = Riep.cod_FE
                            End If
                            datiRiepilogo.RiferimentoNormativo = Riep.descrizione
                            totalePagamento = totalePagamento + Riep.scontato + Riep.imposta
                    End Select
                    ' effettua la somma complessiva dei valori della fattura

                    If dcess.condomino = 1 Then
                        TotaleRitenuta = Riep.scontato / 100 * 4
                        datiRitenuta.TipoRitenuta = "RT01"
                        datiRitenuta.AliquotaRitenuta = ControllaeFormattaNumeri(4.0)
                        datiRitenuta.ImportoRitenuta = ControllaeFormattaNumeri(TotaleRitenuta)
                        datiRitenuta.CausalePagamento = "W"
                    End If

                    datiRiepilogo.ImponibileImporto = ControllaeFormattaNumeri(Riep.scontato)
                    datiRiepilogo.Imposta = ControllaeFormattaNumeri(Riep.imposta)
                    datiRiepilogo.AliquotaIVA = ControllaeFormattaNumeri(Riep.valoreiva)
                    listaRiepilogo.Add(datiRiepilogo)
                    'chiude il nodo beni e servizi
                Next
                datiBeniServizi.DatiRiepilogo = listaRiepilogo
                overviewCorpo.DatiBeniServizi = datiBeniServizi

            End Using
        End Using
        'Dati generali inserito ora per poter avere il totale pagamento
        Dim datiGenerali As New DatiGenerali()
        'Blocco 2.1.1
        Dim datiGeneraliDocumento As New DatiGeneraliDocumento()
        If dcess.fat_nc = 1 Then
            datiGeneraliDocumento.TipoDocumento = "TD04"    'TD01 Fattura / TD04 Nota di credito
        Else
            datiGeneraliDocumento.TipoDocumento = "TD01"    ' TD01 Fattura / TD04 Nota di credito
        End If
        If dcess.condomino = 1 Then
            datiGeneraliDocumento.DatiRitenuta = datiRitenuta
        End If
        datiGeneraliDocumento.ImportoTotaleDocumento = ControllaeFormattaNumeri(totalePagamento)
        datiGeneraliDocumento.Divisa = "EUR"

        Dim datadoc As DateTime = dcess.fat_data
        datiGeneraliDocumento.Data = datadoc.ToString("yyyy-MM-dd")

        datiGeneraliDocumento.Numero = dcess.fat_num_da
        'datiGeneraliDocumento.Art73 = "NO"  'TODO da valutare
        datiGenerali.DatiGeneraliDocumento = datiGeneraliDocumento
        overviewCorpo.DatiGenerali = datiGenerali

        '@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ se si utilizza il contratto pubblico con numero CIG
        '''''''Dim datiContratto As New DatiContratto()
        '''''''datiContratto.RiferimentoNumeroLinea = "1"
        '''''''datiContratto.IdDocumento = "123"
        '''''''datiContratto.Data = "2012-09-01"
        '''''''datiContratto.NumItem = "5"
        '''''''datiContratto.CodiceCUP = "123abc"
        '''''''datiContratto.CodiceCIG = "456def"
        '''''''Dim listDatiContratto As New List(Of DatiContratto)()
        '''''''listDatiContratto.Add(datiContratto)
        '''''''datiGenerali.DatiContratto = listDatiContratto
        'Blocco 2.4 Pagamento
        Dim datipagamento As New DatiPagamento
        datipagamento.CondizioniPagamento = "TP02"
        Dim dettaglipagamento As New DettaglioPagamento
        'dettaglipagamento.ABI = ""
        'dettaglipagamento.CAB = ""
        'dettaglipagamento.BIC = ""
        Dim banca As String = dcess.bancaappog.Replace(".", "").Replace(" ", "").Replace("IBAN", "").TrimEnd
        If banca.Length() <> 27 And banca.Length() > 0 Then
            MsgBox("Verificare codice IBAN " & Chr(13) &
                " " & banca & Chr(13) &
                   "per il cliente " & Chr(13) &
                   dcess.societa & " la fattura non verrà creata")
            Return
        ElseIf banca.Length = 27 Then
            dettaglipagamento.IBAN = banca
            'Dettaglio da quando decorrono i termini di pagamento
        ElseIf banca.Length = 0 Then

        End If
        dettaglipagamento.DataRiferimentoTerminiPagamento = datadoc.ToString("yyyy-MM-dd")
        ' Termine del pagamento
        dettaglipagamento.DataScadenzaPagamento = dcess.fat_scad.ToString("yyyy-MM-dd")
        If dcess.condomino = 1 Then
            dettaglipagamento.ImportoPagamento = ControllaeFormattaNumeri(totalePagamento - TotaleRitenuta)
        Else
            dettaglipagamento.ImportoPagamento = ControllaeFormattaNumeri(totalePagamento)
        End If
        datipagamento.DettaglioPagamento = dettaglipagamento
        dettaglipagamento.Beneficiario = dpres.ragione_sociale
        dettaglipagamento.ModalitaPagamento = dcess.modalitaFE  'imposta il tipo di pagamento
        '@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ Chiude i Pagamenti
        overviewCorpo.DatiPagamento = datipagamento

        Dim Datiintermediario As New TerzoIntermediarioOSoggettoEmittente
        datiAnagrafici = New DatiAnagrafici
        anagrafica = New Anagrafica()
        idFiscaleIVA = New IdFiscaleIVA
        anagrafica.Denominazione = dtras.Nominativo
        datiAnagrafici.Anagrafica = anagrafica
        idFiscaleIVA.IdCodice = dtras.idCodice
        idFiscaleIVA.IdPaese = dtras.idPaese
        datiAnagrafici.IdFiscaleIVA = idFiscaleIVA
        Datiintermediario.DatiAnagrafici = datiAnagrafici
        '@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ Dati intermediario che invia la fattura

        nodoPrincipale.FatturaElettronicaHeader = overviewIntestazione
        nodoPrincipale.FatturaElettronicaBody = overviewCorpo
        '@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ Chiude il nodo Fattura
        'Scrivi XML

        Dim XmlRoot As New XmlRootAttribute()
        XmlRoot.Namespace = "http://ivaservizi.agenziaentrate.gov.it/docs/xsd/fatture/v1.2"
        Dim myxmlAttribute As XmlAttributes = New XmlAttributes
        myxmlAttribute.XmlRoot = XmlRoot
        Dim xmlAttributeOverrides As XmlAttributeOverrides = New XmlAttributeOverrides
        xmlAttributeOverrides.Add(GetType(FatturaElettronica), myxmlAttribute)
        ' in case you want to remove prefix from members
        Dim emptyNsAttribute As New XmlAttributes()
        Dim xElementoVuoto As New XmlElementAttribute()
        xElementoVuoto.Namespace = ""
        emptyNsAttribute.XmlElements.Add(xElementoVuoto)
        xmlAttributeOverrides.Add(GetType(FatturaElettronica), "FatturaElettronicaHeader", emptyNsAttribute)
        xmlAttributeOverrides.Add(GetType(FatturaElettronica), "FatturaElettronicaBody", emptyNsAttribute)
        ' if you actual library type contains more members, then you have to list all of them
        If dcess.pa Then
            nodoPrincipale.versione = "FPA12"
        Else
            nodoPrincipale.versione = "FPR12"
        End If
        Dim ser As New XmlSerializer(nodoPrincipale.[GetType](), xmlAttributeOverrides)
        Dim ns As New XmlSerializerNamespaces()
        ns.Add("ds", "http://www.w3.org/2000/09/xmldsig#")

        ns.Add("p", "http://ivaservizi.agenziaentrate.gov.it/docs/xsd/fatture/v1.2")
        ns.Add("xis", "http://www.w3.org/2001/XMLSchema-instance")

        'crea il nome del file con IT _ numero ID trasmittente _ numero progressivo e lo salva dove hai deciso di memorizzare le informazioni
        Dim NomeFile As String = dpres.Nazione.Substring(0, 2).ToUpper & dpres.partita_IVA.Replace(".", "") & "_" & Progressivo.ToString.PadLeft(5, "0")
        Dim percorso As String = Path & "//" & NomeFile & ".xml"
        Dim file As System.IO.FileStream = System.IO.File.Create(percorso)
        ser.Serialize(New StreamWriter(file, New System.Text.UTF8Encoding()), nodoPrincipale, ns)
        file.Close()
        ' genera il file XSD
        'GeneraXMLfileXSD(NomeFile)
        System.IO.File.Delete(NomeFile & ".xml")
        System.IO.File.Copy(percorso, NomeFile & ".xml")
        System.Diagnostics.Process.Start(NomeFile & ".xml")
    End Sub
End Module
