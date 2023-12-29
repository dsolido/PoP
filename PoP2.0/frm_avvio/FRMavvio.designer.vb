<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frmavvio
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmavvio))
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Gestione Dipendenti")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Anagrafica Clienti")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Gestione Ordini")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Prodotti e Attrezzature")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Anagrafica Fornitori")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Ordini Remoti")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Macchinari")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Magazzino", New System.Windows.Forms.TreeNode() {TreeNode3, TreeNode4, TreeNode5, TreeNode6, TreeNode7})
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Fatturazione")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Fatturazione Elettronica")
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Autofatturazione Elettronica", 36, 36)
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Generazione Automatica Fatture", 25, 2)
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Scadenziario Pagamenti  Fatture", 28, 30)
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Redditività Cliente")
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Analisi Ordini Clienti per Fattura", 2, 2)
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Analizza Andamento Azienda", 1, 1)
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Contabilitá", New System.Windows.Forms.TreeNode() {TreeNode9, TreeNode10, TreeNode11, TreeNode12, TreeNode13, TreeNode14, TreeNode15, TreeNode16})
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Separazione PDF")
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Pubblica Fatture in Rete")
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Riepilogo Presenze")
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Gestione documentale", 18, 24, New System.Windows.Forms.TreeNode() {TreeNode18, TreeNode19, TreeNode20})
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Piano Ferie e permessi", 35, 35)
        Dim TreeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Ricerca Personale")
        Dim TreeNode24 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Autorizza Ferie Dipendente", 15, 15)
        Dim TreeNode25 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Verifiche posizioni GPS", 38, 38)
        Dim TreeNode26 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Gestione Dipendenti", New System.Windows.Forms.TreeNode() {TreeNode22, TreeNode23, TreeNode24, TreeNode25})
        Dim TreeNode27 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("IOP istruzioni Operative", 36, 36)
        Dim TreeNode28 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Elenco Istruzioni", 37, 37)
        Dim TreeNode29 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Elenco Prodotti/Attrezzi/DPI", 6, 6)
        Dim TreeNode30 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Controllo Qualita Clienti", 11, 31)
        Dim TreeNode31 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Report Esito Sondaggio")
        Dim TreeNode32 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ISO 9001", 37, 37, New System.Windows.Forms.TreeNode() {TreeNode27, TreeNode28, TreeNode29, TreeNode30, TreeNode31})
        Dim TreeNode33 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Credenziali di accesso")
        Dim TreeNode34 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Codici avviamento Postale")
        Dim TreeNode35 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tipo di Formazione")
        Dim TreeNode36 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Remota")
        Dim TreeNode37 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Locale")
        Dim TreeNode38 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Connessione", New System.Windows.Forms.TreeNode() {TreeNode36, TreeNode37})
        Dim TreeNode39 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Genera Calendario")
        Dim TreeNode40 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Impostazioni di sistema", New System.Windows.Forms.TreeNode() {TreeNode33, TreeNode34, TreeNode35, TreeNode38, TreeNode39})
        Dim TreeNode41 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Preventivazione", 16, 16)
        Dim TreeNode42 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Termina")
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Listaimmagini = New System.Windows.Forms.ImageList(Me.components)
        Me.MNS_menu_tendina = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TerminaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApplicativiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DipendentiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnagraficaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InserimentoPresenzeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PianoDiLavoroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNU_letteredipendenti = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNUControllaLePresenzeMenisili = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestioneSostituzioneFerieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnagraficaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PianoDiLavoroToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RiepilogoPresenzeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedditivitàToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MagazzinoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrdiniToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProdottiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FornitoriToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategorieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MacchinariToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContabilitaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FatturazioneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrimaNotaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImpostazioniToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CredenzialiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettaggioVariabiliToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FinestraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreditiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AiutiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_credenziali = New System.Windows.Forms.Button()
        Me.informazioniAvvio = New System.Windows.Forms.ToolTip(Me.components)
        Me.TX_nomegiorno = New System.Windows.Forms.TextBox()
        Me.TX_dataoggi = New System.Windows.Forms.TextBox()
        Me.BT_avanti = New System.Windows.Forms.Button()
        Me.BT_stampa = New System.Windows.Forms.Button()
        Me.BT_nuovo = New System.Windows.Forms.Button()
        Me.BT_oggi = New System.Windows.Forms.Button()
        Me.BT_indietro = New System.Windows.Forms.Button()
        Me.BT_termina = New System.Windows.Forms.Button()
        Me.STS_informazioni = New System.Windows.Forms.StatusStrip()
        Me.STS_user = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STS_dipendenti = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STS_clienti = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STS_materiale = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STS_contabilita = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STS_impostazioni = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Spazio = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Etichetta_rete = New System.Windows.Forms.ToolStripStatusLabel()
        Me.immagini_menu = New System.Windows.Forms.ImageList(Me.components)
        Me.TX_avvio = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.menu_principale = New System.Windows.Forms.TreeView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tvSegnalazioniClienti = New System.Windows.Forms.TreeView()
        Me.btFeriePresenti = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LL_ordiniweb = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TL_controlloAgenda = New System.Windows.Forms.TableLayoutPanel()
        Me.tblinserimentoPeriodoLavoro = New System.Windows.Forms.TableLayoutPanel()
        Me.cmbMese = New System.Windows.Forms.ComboBox()
        Me.cmbAnno = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.PClock = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbAzienda = New System.Windows.Forms.Label()
        Me.CBazienda = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.DG_giorno = New System.Windows.Forms.DataGridView()
        Me.CAgendaID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_data = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_Ora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_sostituto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_Assente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_locazione = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_note = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_iddip = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_IDsost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_IDcli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGWCsostidraggruppamento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGWCsostidconfermato = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LB_assenti = New System.Windows.Forms.Label()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.BT_agenda = New System.Windows.Forms.Button()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MNS_menu_tendina.SuspendLayout()
        Me.STS_informazioni.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TL_controlloAgenda.SuspendLayout()
        Me.tblinserimentoPeriodoLavoro.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.PClock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        CType(Me.DG_giorno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel8.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'Listaimmagini
        '
        Me.Listaimmagini.ImageStream = CType(resources.GetObject("Listaimmagini.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.Listaimmagini.TransparentColor = System.Drawing.Color.Transparent
        Me.Listaimmagini.Images.SetKeyName(0, "connessioneon.ico")
        Me.Listaimmagini.Images.SetKeyName(1, "collegamentowebgest.ico")
        Me.Listaimmagini.Images.SetKeyName(2, "freccia48sx.png")
        Me.Listaimmagini.Images.SetKeyName(3, "freccia48dx.png")
        Me.Listaimmagini.Images.SetKeyName(4, "ominoditosu.png")
        Me.Listaimmagini.Images.SetKeyName(5, "omino_stampa48.png")
        Me.Listaimmagini.Images.SetKeyName(6, "omino_scrive.png")
        Me.Listaimmagini.Images.SetKeyName(7, "ominotermina48.png")
        '
        'MNS_menu_tendina
        '
        Me.MNS_menu_tendina.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MNS_menu_tendina.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ApplicativiToolStripMenuItem, Me.ImpostazioniToolStripMenuItem, Me.FinestraToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.MNS_menu_tendina.Location = New System.Drawing.Point(0, 0)
        Me.MNS_menu_tendina.Name = "MNS_menu_tendina"
        Me.MNS_menu_tendina.Padding = New System.Windows.Forms.Padding(3, 1, 0, 1)
        Me.MNS_menu_tendina.Size = New System.Drawing.Size(1062, 24)
        Me.MNS_menu_tendina.TabIndex = 1
        Me.MNS_menu_tendina.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TerminaToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 22)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'TerminaToolStripMenuItem
        '
        Me.TerminaToolStripMenuItem.Name = "TerminaToolStripMenuItem"
        Me.TerminaToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.TerminaToolStripMenuItem.Text = "Termina"
        '
        'ApplicativiToolStripMenuItem
        '
        Me.ApplicativiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DipendentiToolStripMenuItem, Me.ClientiToolStripMenuItem, Me.MagazzinoToolStripMenuItem, Me.ContabilitaToolStripMenuItem})
        Me.ApplicativiToolStripMenuItem.Name = "ApplicativiToolStripMenuItem"
        Me.ApplicativiToolStripMenuItem.Size = New System.Drawing.Size(75, 22)
        Me.ApplicativiToolStripMenuItem.Text = "Applicativi"
        '
        'DipendentiToolStripMenuItem
        '
        Me.DipendentiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AnagraficaToolStripMenuItem, Me.InserimentoPresenzeToolStripMenuItem, Me.PianoDiLavoroToolStripMenuItem, Me.MNU_letteredipendenti, Me.MNUControllaLePresenzeMenisili, Me.GestioneSostituzioneFerieToolStripMenuItem})
        Me.DipendentiToolStripMenuItem.Name = "DipendentiToolStripMenuItem"
        Me.DipendentiToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.DipendentiToolStripMenuItem.Text = "Dipendenti"
        '
        'AnagraficaToolStripMenuItem
        '
        Me.AnagraficaToolStripMenuItem.Name = "AnagraficaToolStripMenuItem"
        Me.AnagraficaToolStripMenuItem.Size = New System.Drawing.Size(263, 22)
        Me.AnagraficaToolStripMenuItem.Text = "Anagrafica"
        '
        'InserimentoPresenzeToolStripMenuItem
        '
        Me.InserimentoPresenzeToolStripMenuItem.Name = "InserimentoPresenzeToolStripMenuItem"
        Me.InserimentoPresenzeToolStripMenuItem.Size = New System.Drawing.Size(263, 22)
        Me.InserimentoPresenzeToolStripMenuItem.Text = "Inserimento Presenze"
        '
        'PianoDiLavoroToolStripMenuItem
        '
        Me.PianoDiLavoroToolStripMenuItem.Name = "PianoDiLavoroToolStripMenuItem"
        Me.PianoDiLavoroToolStripMenuItem.Size = New System.Drawing.Size(263, 22)
        Me.PianoDiLavoroToolStripMenuItem.Text = "Piano di lavoro"
        '
        'MNU_letteredipendenti
        '
        Me.MNU_letteredipendenti.Name = "MNU_letteredipendenti"
        Me.MNU_letteredipendenti.Size = New System.Drawing.Size(263, 22)
        Me.MNU_letteredipendenti.Text = "Crea Lettere in serie per i dipendenti"
        '
        'MNUControllaLePresenzeMenisili
        '
        Me.MNUControllaLePresenzeMenisili.Name = "MNUControllaLePresenzeMenisili"
        Me.MNUControllaLePresenzeMenisili.Size = New System.Drawing.Size(263, 22)
        Me.MNUControllaLePresenzeMenisili.Text = "Controlla le presenze mensili"
        '
        'GestioneSostituzioneFerieToolStripMenuItem
        '
        Me.GestioneSostituzioneFerieToolStripMenuItem.Name = "GestioneSostituzioneFerieToolStripMenuItem"
        Me.GestioneSostituzioneFerieToolStripMenuItem.Size = New System.Drawing.Size(263, 22)
        Me.GestioneSostituzioneFerieToolStripMenuItem.Text = "Gestione Sostituzione Ferie"
        '
        'ClientiToolStripMenuItem
        '
        Me.ClientiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AnagraficaToolStripMenuItem1, Me.PianoDiLavoroToolStripMenuItem1, Me.RiepilogoPresenzeToolStripMenuItem, Me.RedditivitàToolStripMenuItem})
        Me.ClientiToolStripMenuItem.Name = "ClientiToolStripMenuItem"
        Me.ClientiToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.ClientiToolStripMenuItem.Text = "Clienti"
        '
        'AnagraficaToolStripMenuItem1
        '
        Me.AnagraficaToolStripMenuItem1.Name = "AnagraficaToolStripMenuItem1"
        Me.AnagraficaToolStripMenuItem1.Size = New System.Drawing.Size(173, 22)
        Me.AnagraficaToolStripMenuItem1.Text = "Anagrafica"
        '
        'PianoDiLavoroToolStripMenuItem1
        '
        Me.PianoDiLavoroToolStripMenuItem1.Name = "PianoDiLavoroToolStripMenuItem1"
        Me.PianoDiLavoroToolStripMenuItem1.Size = New System.Drawing.Size(173, 22)
        Me.PianoDiLavoroToolStripMenuItem1.Text = "Piano di Lavoro"
        '
        'RiepilogoPresenzeToolStripMenuItem
        '
        Me.RiepilogoPresenzeToolStripMenuItem.Name = "RiepilogoPresenzeToolStripMenuItem"
        Me.RiepilogoPresenzeToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.RiepilogoPresenzeToolStripMenuItem.Text = "Riepilogo Presenze"
        '
        'RedditivitàToolStripMenuItem
        '
        Me.RedditivitàToolStripMenuItem.Name = "RedditivitàToolStripMenuItem"
        Me.RedditivitàToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.RedditivitàToolStripMenuItem.Text = "Redditività"
        '
        'MagazzinoToolStripMenuItem
        '
        Me.MagazzinoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OrdiniToolStripMenuItem, Me.ProdottiToolStripMenuItem, Me.FornitoriToolStripMenuItem, Me.CategorieToolStripMenuItem, Me.MacchinariToolStripMenuItem})
        Me.MagazzinoToolStripMenuItem.Name = "MagazzinoToolStripMenuItem"
        Me.MagazzinoToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.MagazzinoToolStripMenuItem.Text = "Magazzino"
        '
        'OrdiniToolStripMenuItem
        '
        Me.OrdiniToolStripMenuItem.Name = "OrdiniToolStripMenuItem"
        Me.OrdiniToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.OrdiniToolStripMenuItem.Text = "Ordini"
        '
        'ProdottiToolStripMenuItem
        '
        Me.ProdottiToolStripMenuItem.Name = "ProdottiToolStripMenuItem"
        Me.ProdottiToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.ProdottiToolStripMenuItem.Text = "Prodotti"
        '
        'FornitoriToolStripMenuItem
        '
        Me.FornitoriToolStripMenuItem.Name = "FornitoriToolStripMenuItem"
        Me.FornitoriToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.FornitoriToolStripMenuItem.Text = "Fornitori"
        '
        'CategorieToolStripMenuItem
        '
        Me.CategorieToolStripMenuItem.Name = "CategorieToolStripMenuItem"
        Me.CategorieToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.CategorieToolStripMenuItem.Text = "Categorie"
        '
        'MacchinariToolStripMenuItem
        '
        Me.MacchinariToolStripMenuItem.Name = "MacchinariToolStripMenuItem"
        Me.MacchinariToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.MacchinariToolStripMenuItem.Text = "Macchinari"
        '
        'ContabilitaToolStripMenuItem
        '
        Me.ContabilitaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FatturazioneToolStripMenuItem, Me.PrimaNotaToolStripMenuItem})
        Me.ContabilitaToolStripMenuItem.Name = "ContabilitaToolStripMenuItem"
        Me.ContabilitaToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.ContabilitaToolStripMenuItem.Text = "Contabilita"
        '
        'FatturazioneToolStripMenuItem
        '
        Me.FatturazioneToolStripMenuItem.Name = "FatturazioneToolStripMenuItem"
        Me.FatturazioneToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.FatturazioneToolStripMenuItem.Text = "Fatturazione"
        '
        'PrimaNotaToolStripMenuItem
        '
        Me.PrimaNotaToolStripMenuItem.Name = "PrimaNotaToolStripMenuItem"
        Me.PrimaNotaToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.PrimaNotaToolStripMenuItem.Text = "Prima Nota"
        '
        'ImpostazioniToolStripMenuItem
        '
        Me.ImpostazioniToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CredenzialiToolStripMenuItem, Me.SettaggioVariabiliToolStripMenuItem})
        Me.ImpostazioniToolStripMenuItem.Name = "ImpostazioniToolStripMenuItem"
        Me.ImpostazioniToolStripMenuItem.Size = New System.Drawing.Size(87, 22)
        Me.ImpostazioniToolStripMenuItem.Text = "Impostazioni"
        '
        'CredenzialiToolStripMenuItem
        '
        Me.CredenzialiToolStripMenuItem.Name = "CredenzialiToolStripMenuItem"
        Me.CredenzialiToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.CredenzialiToolStripMenuItem.Text = "Credenziali"
        '
        'SettaggioVariabiliToolStripMenuItem
        '
        Me.SettaggioVariabiliToolStripMenuItem.Name = "SettaggioVariabiliToolStripMenuItem"
        Me.SettaggioVariabiliToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.SettaggioVariabiliToolStripMenuItem.Text = "Settaggio variabili"
        '
        'FinestraToolStripMenuItem
        '
        Me.FinestraToolStripMenuItem.Name = "FinestraToolStripMenuItem"
        Me.FinestraToolStripMenuItem.Size = New System.Drawing.Size(60, 22)
        Me.FinestraToolStripMenuItem.Text = "Finestra"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreditiToolStripMenuItem, Me.AiutiToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(24, 22)
        Me.ToolStripMenuItem1.Text = "?"
        '
        'CreditiToolStripMenuItem
        '
        Me.CreditiToolStripMenuItem.Name = "CreditiToolStripMenuItem"
        Me.CreditiToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.CreditiToolStripMenuItem.Text = "Crediti"
        '
        'AiutiToolStripMenuItem
        '
        Me.AiutiToolStripMenuItem.Name = "AiutiToolStripMenuItem"
        Me.AiutiToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.AiutiToolStripMenuItem.Text = "Aiuto"
        '
        'btn_credenziali
        '
        Me.btn_credenziali.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_credenziali.FlatAppearance.BorderSize = 0
        Me.btn_credenziali.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_credenziali.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_credenziali.ImageKey = "(nessuno)"
        Me.btn_credenziali.Location = New System.Drawing.Point(12, 230)
        Me.btn_credenziali.Name = "btn_credenziali"
        Me.btn_credenziali.Size = New System.Drawing.Size(100, 100)
        Me.btn_credenziali.TabIndex = 6
        Me.btn_credenziali.Text = "Credenziali"
        Me.btn_credenziali.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_credenziali.UseVisualStyleBackColor = True
        '
        'informazioniAvvio
        '
        Me.informazioniAvvio.AutoPopDelay = 5000
        Me.informazioniAvvio.InitialDelay = 500
        Me.informazioniAvvio.ReshowDelay = 100
        '
        'TX_nomegiorno
        '
        Me.TX_nomegiorno.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TX_nomegiorno.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TX_nomegiorno.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TX_nomegiorno.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.TX_nomegiorno.Location = New System.Drawing.Point(1, 36)
        Me.TX_nomegiorno.Margin = New System.Windows.Forms.Padding(1)
        Me.TX_nomegiorno.Name = "TX_nomegiorno"
        Me.TX_nomegiorno.Size = New System.Drawing.Size(200, 22)
        Me.TX_nomegiorno.TabIndex = 199
        Me.TX_nomegiorno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.informazioniAvvio.SetToolTip(Me.TX_nomegiorno, "Inserisci la data da visualizzare")
        '
        'TX_dataoggi
        '
        Me.TX_dataoggi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TX_dataoggi.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TX_dataoggi.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TX_dataoggi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TX_dataoggi.Location = New System.Drawing.Point(1, 15)
        Me.TX_dataoggi.Margin = New System.Windows.Forms.Padding(1)
        Me.TX_dataoggi.Name = "TX_dataoggi"
        Me.TX_dataoggi.Size = New System.Drawing.Size(200, 19)
        Me.TX_dataoggi.TabIndex = 200
        Me.TX_dataoggi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.informazioniAvvio.SetToolTip(Me.TX_dataoggi, "Inserisci la data da visualizzare")
        '
        'BT_avanti
        '
        Me.BT_avanti.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BT_avanti.FlatAppearance.BorderSize = 0
        Me.BT_avanti.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_avanti.Image = CType(resources.GetObject("BT_avanti.Image"), System.Drawing.Image)
        Me.BT_avanti.Location = New System.Drawing.Point(390, 77)
        Me.BT_avanti.Margin = New System.Windows.Forms.Padding(2)
        Me.BT_avanti.Name = "BT_avanti"
        Me.BT_avanti.Size = New System.Drawing.Size(192, 71)
        Me.BT_avanti.TabIndex = 1
        Me.BT_avanti.Tag = "1"
        Me.informazioniAvvio.SetToolTip(Me.BT_avanti, "Vai un giorno avanti")
        Me.BT_avanti.UseVisualStyleBackColor = True
        '
        'BT_stampa
        '
        Me.BT_stampa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BT_stampa.FlatAppearance.BorderSize = 0
        Me.BT_stampa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_stampa.ImageIndex = 5
        Me.BT_stampa.ImageList = Me.Listaimmagini
        Me.BT_stampa.Location = New System.Drawing.Point(391, 3)
        Me.BT_stampa.Name = "BT_stampa"
        Me.BT_stampa.Size = New System.Drawing.Size(190, 69)
        Me.BT_stampa.TabIndex = 0
        Me.informazioniAvvio.SetToolTip(Me.BT_stampa, "Stampa elenco")
        Me.BT_stampa.UseVisualStyleBackColor = True
        '
        'BT_nuovo
        '
        Me.BT_nuovo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BT_nuovo.FlatAppearance.BorderSize = 0
        Me.BT_nuovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_nuovo.ImageIndex = 6
        Me.BT_nuovo.ImageList = Me.Listaimmagini
        Me.BT_nuovo.Location = New System.Drawing.Point(197, 3)
        Me.BT_nuovo.Name = "BT_nuovo"
        Me.BT_nuovo.Size = New System.Drawing.Size(188, 69)
        Me.BT_nuovo.TabIndex = 1
        Me.informazioniAvvio.SetToolTip(Me.BT_nuovo, "Inserisce nuova assenza")
        Me.BT_nuovo.UseVisualStyleBackColor = True
        '
        'BT_oggi
        '
        Me.BT_oggi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BT_oggi.FlatAppearance.BorderSize = 0
        Me.BT_oggi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_oggi.Image = CType(resources.GetObject("BT_oggi.Image"), System.Drawing.Image)
        Me.BT_oggi.Location = New System.Drawing.Point(196, 77)
        Me.BT_oggi.Margin = New System.Windows.Forms.Padding(2)
        Me.BT_oggi.Name = "BT_oggi"
        Me.BT_oggi.Size = New System.Drawing.Size(190, 71)
        Me.BT_oggi.TabIndex = 4
        Me.informazioniAvvio.SetToolTip(Me.BT_oggi, "Torna ad oggi")
        Me.BT_oggi.UseVisualStyleBackColor = True
        '
        'BT_indietro
        '
        Me.BT_indietro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BT_indietro.FlatAppearance.BorderSize = 0
        Me.BT_indietro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_indietro.Image = CType(resources.GetObject("BT_indietro.Image"), System.Drawing.Image)
        Me.BT_indietro.Location = New System.Drawing.Point(2, 77)
        Me.BT_indietro.Margin = New System.Windows.Forms.Padding(2)
        Me.BT_indietro.Name = "BT_indietro"
        Me.BT_indietro.Size = New System.Drawing.Size(190, 71)
        Me.BT_indietro.TabIndex = 0
        Me.BT_indietro.Tag = "-1"
        Me.informazioniAvvio.SetToolTip(Me.BT_indietro, "Vai un giorno indietro")
        Me.BT_indietro.UseVisualStyleBackColor = True
        '
        'BT_termina
        '
        Me.BT_termina.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BT_termina.AutoSize = True
        Me.BT_termina.BackgroundImage = CType(resources.GetObject("BT_termina.BackgroundImage"), System.Drawing.Image)
        Me.BT_termina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BT_termina.FlatAppearance.BorderSize = 0
        Me.BT_termina.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_termina.Location = New System.Drawing.Point(593, 3)
        Me.BT_termina.Name = "BT_termina"
        Me.BT_termina.Size = New System.Drawing.Size(142, 150)
        Me.BT_termina.TabIndex = 204
        Me.informazioniAvvio.SetToolTip(Me.BT_termina, "Termina l'Applicazione")
        Me.BT_termina.UseVisualStyleBackColor = True
        '
        'STS_informazioni
        '
        Me.STS_informazioni.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.STS_informazioni.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.STS_user, Me.STS_dipendenti, Me.STS_clienti, Me.STS_materiale, Me.STS_contabilita, Me.STS_impostazioni, Me.Spazio, Me.Etichetta_rete})
        Me.STS_informazioni.Location = New System.Drawing.Point(0, 759)
        Me.STS_informazioni.Name = "STS_informazioni"
        Me.STS_informazioni.Size = New System.Drawing.Size(1062, 22)
        Me.STS_informazioni.TabIndex = 9
        Me.STS_informazioni.Text = "StatusStrip1"
        '
        'STS_user
        '
        Me.STS_user.Name = "STS_user"
        Me.STS_user.Size = New System.Drawing.Size(78, 17)
        Me.STS_user.Text = "Nome Utente"
        '
        'STS_dipendenti
        '
        Me.STS_dipendenti.Name = "STS_dipendenti"
        Me.STS_dipendenti.Size = New System.Drawing.Size(80, 17)
        Me.STS_dipendenti.Text = "F2 Dipendenti"
        '
        'STS_clienti
        '
        Me.STS_clienti.Name = "STS_clienti"
        Me.STS_clienti.Size = New System.Drawing.Size(56, 17)
        Me.STS_clienti.Text = "F3 Clienti"
        '
        'STS_materiale
        '
        Me.STS_materiale.Name = "STS_materiale"
        Me.STS_materiale.Size = New System.Drawing.Size(71, 17)
        Me.STS_materiale.Text = "F4 Materiale"
        '
        'STS_contabilita
        '
        Me.STS_contabilita.Name = "STS_contabilita"
        Me.STS_contabilita.Size = New System.Drawing.Size(80, 17)
        Me.STS_contabilita.Text = "F5 Contabilitá"
        '
        'STS_impostazioni
        '
        Me.STS_impostazioni.Name = "STS_impostazioni"
        Me.STS_impostazioni.Size = New System.Drawing.Size(90, 17)
        Me.STS_impostazioni.Text = "F9 Impostazioni"
        '
        'Spazio
        '
        Me.Spazio.Name = "Spazio"
        Me.Spazio.Size = New System.Drawing.Size(541, 17)
        Me.Spazio.Spring = True
        '
        'Etichetta_rete
        '
        Me.Etichetta_rete.BackColor = System.Drawing.Color.PaleGreen
        Me.Etichetta_rete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Etichetta_rete.BorderStyle = System.Windows.Forms.Border3DStyle.Etched
        Me.Etichetta_rete.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Etichetta_rete.Name = "Etichetta_rete"
        Me.Etichetta_rete.Size = New System.Drawing.Size(51, 17)
        Me.Etichetta_rete.Text = "Versione"
        Me.Etichetta_rete.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'immagini_menu
        '
        Me.immagini_menu.ImageStream = CType(resources.GetObject("immagini_menu.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.immagini_menu.TransparentColor = System.Drawing.Color.Silver
        Me.immagini_menu.Images.SetKeyName(0, "aggiunge.ico")
        Me.immagini_menu.Images.SetKeyName(1, "contabilita_menu")
        Me.immagini_menu.Images.SetKeyName(2, "fatturazione_avvio")
        Me.immagini_menu.Images.SetKeyName(3, "presenze_avvio")
        Me.immagini_menu.Images.SetKeyName(4, "riunioni.png")
        Me.immagini_menu.Images.SetKeyName(5, "elimina.png")
        Me.immagini_menu.Images.SetKeyName(6, "prodotti_avvio")
        Me.immagini_menu.Images.SetKeyName(7, "prodotti_menu")
        Me.immagini_menu.Images.SetKeyName(8, "credenziali_menu")
        Me.immagini_menu.Images.SetKeyName(9, "credenziali_accesso")
        Me.immagini_menu.Images.SetKeyName(10, "clienti_anagrafica")
        Me.immagini_menu.Images.SetKeyName(11, "clienti_menu")
        Me.immagini_menu.Images.SetKeyName(12, "dipendenti_menu")
        Me.immagini_menu.Images.SetKeyName(13, "dipednenti_avvio")
        Me.immagini_menu.Images.SetKeyName(14, "ricarca_avvio")
        Me.immagini_menu.Images.SetKeyName(15, "ricarca_menu")
        Me.immagini_menu.Images.SetKeyName(16, "impostazioni_spento")
        Me.immagini_menu.Images.SetKeyName(17, "impostazioni_menu")
        Me.immagini_menu.Images.SetKeyName(18, "impostazioni_avvio")
        Me.immagini_menu.Images.SetKeyName(19, "dipendenti_formazione_avvio")
        Me.immagini_menu.Images.SetKeyName(20, "ordini_avvio")
        Me.immagini_menu.Images.SetKeyName(21, "ordni_menu")
        Me.immagini_menu.Images.SetKeyName(22, "ordni_spento")
        Me.immagini_menu.Images.SetKeyName(23, "termina.png")
        Me.immagini_menu.Images.SetKeyName(24, "omino_presenze.ico")
        Me.immagini_menu.Images.SetKeyName(25, "omino_scrive.png")
        Me.immagini_menu.Images.SetKeyName(26, "omino_carta.png")
        Me.immagini_menu.Images.SetKeyName(27, "omino_orario.png")
        Me.immagini_menu.Images.SetKeyName(28, "omino_incassi.png")
        Me.immagini_menu.Images.SetKeyName(29, "omino_iphone.png")
        Me.immagini_menu.Images.SetKeyName(30, "omino_soldi.png")
        Me.immagini_menu.Images.SetKeyName(31, "omino_cliente.png")
        Me.immagini_menu.Images.SetKeyName(32, "ominotermina48.png")
        Me.immagini_menu.Images.SetKeyName(33, "omino48agenda.png")
        Me.immagini_menu.Images.SetKeyName(34, "collegamento.png")
        Me.immagini_menu.Images.SetKeyName(35, "vacanza.jpeg")
        Me.immagini_menu.Images.SetKeyName(36, "sicurezza3.png")
        Me.immagini_menu.Images.SetKeyName(37, "Iso9001.png")
        Me.immagini_menu.Images.SetKeyName(38, "omino_rete.png")
        '
        'TX_avvio
        '
        Me.TX_avvio.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TX_avvio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TX_avvio.Location = New System.Drawing.Point(0, 733)
        Me.TX_avvio.Name = "TX_avvio"
        Me.TX_avvio.Size = New System.Drawing.Size(1062, 26)
        Me.TX_avvio.TabIndex = 24
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.Label4, 0, 3)
        Me.TableLayoutPanel4.Controls.Add(Me.menu_principale, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label3, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.tvSegnalazioniClienti, 0, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.btFeriePresenti, 0, 6)
        Me.TableLayoutPanel4.Controls.Add(Me.Label5, 0, 5)
        Me.TableLayoutPanel4.Controls.Add(Me.LL_ordiniweb, 0, 4)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 7
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(306, 700)
        Me.TableLayoutPanel4.TabIndex = 199
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label4.Location = New System.Drawing.Point(3, 576)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(300, 22)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Ordini"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'menu_principale
        '
        Me.menu_principale.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.menu_principale.ImageIndex = 8
        Me.menu_principale.ImageList = Me.immagini_menu
        Me.menu_principale.Location = New System.Drawing.Point(3, 3)
        Me.menu_principale.Name = "menu_principale"
        TreeNode1.ImageKey = "dipendenti_menu"
        TreeNode1.Name = "nd_dipendenti"
        TreeNode1.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode1.SelectedImageKey = "dipednenti_avvio"
        TreeNode1.Text = "Gestione Dipendenti"
        TreeNode2.ImageKey = "clienti_menu"
        TreeNode2.Name = "nd_cli_anagrafica"
        TreeNode2.SelectedImageKey = "omino_cliente.png"
        TreeNode2.Text = "Anagrafica Clienti"
        TreeNode3.ImageKey = "ordini_avvio"
        TreeNode3.Name = "nd_mag_ordini2"
        TreeNode3.SelectedImageKey = "ordni_menu"
        TreeNode3.Text = "Gestione Ordini"
        TreeNode4.ImageKey = "prodotti_avvio"
        TreeNode4.Name = "nd_mag_prodotti2"
        TreeNode4.SelectedImageKey = "prodotti_menu"
        TreeNode4.Text = "Prodotti e Attrezzature"
        TreeNode5.ImageKey = "prodotti_menu"
        TreeNode5.Name = "nd_mag_fornitori"
        TreeNode5.SelectedImageKey = "prodotti_menu"
        TreeNode5.Text = "Anagrafica Fornitori"
        TreeNode6.ImageKey = "ordni_spento"
        TreeNode6.Name = "nd_mag_ordiniWeb"
        TreeNode6.SelectedImageIndex = 21
        TreeNode6.Text = "Ordini Remoti"
        TreeNode7.ImageKey = "presenze_avvio"
        TreeNode7.Name = "nd_mag_macchinari"
        TreeNode7.SelectedImageIndex = 3
        TreeNode7.Tag = "Avvia la gestione dei Macchinari"
        TreeNode7.Text = "Macchinari"
        TreeNode8.ImageKey = "ordni_menu"
        TreeNode8.Name = "nd_magazzino"
        TreeNode8.SelectedImageKey = "ordni_menu"
        TreeNode8.Text = "Magazzino"
        TreeNode9.ImageKey = "omino_carta.png"
        TreeNode9.Name = "nd_con_fatture"
        TreeNode9.SelectedImageKey = "fatturazione_avvio"
        TreeNode9.Text = "Fatturazione"
        TreeNode10.ImageKey = "omino_carta.png"
        TreeNode10.Name = "nd_con_fattelettronica"
        TreeNode10.SelectedImageKey = "omino_soldi.png"
        TreeNode10.Text = "Fatturazione Elettronica"
        TreeNode11.ImageIndex = 36
        TreeNode11.Name = "ndautofatturazione"
        TreeNode11.SelectedImageIndex = 36
        TreeNode11.Text = "Autofatturazione Elettronica"
        TreeNode11.ToolTipText = "Gestione delle fatture estere"
        TreeNode12.ImageIndex = 25
        TreeNode12.Name = "nd_con_generafatture"
        TreeNode12.SelectedImageIndex = 2
        TreeNode12.Text = "Generazione Automatica Fatture"
        TreeNode12.ToolTipText = "Genera le fatture del mese richiesto"
        TreeNode13.ImageIndex = 28
        TreeNode13.Name = "nd_con_scadenze"
        TreeNode13.SelectedImageIndex = 30
        TreeNode13.Text = "Scadenziario Pagamenti  Fatture"
        TreeNode13.ToolTipText = "Verifica i pagamenti e le scadenze"
        TreeNode14.ImageKey = "omino_incassi.png"
        TreeNode14.Name = "nd_cli_red"
        TreeNode14.SelectedImageKey = "omino_soldi.png"
        TreeNode14.Text = "Redditività Cliente"
        TreeNode14.ToolTipText = "Calcola la redditività del cliente"
        TreeNode15.ImageIndex = 2
        TreeNode15.Name = "nd_con_analisiordiniperfattura"
        TreeNode15.SelectedImageIndex = 2
        TreeNode15.Text = "Analisi Ordini Clienti per Fattura"
        TreeNode16.ImageIndex = 1
        TreeNode16.Name = "nd_con_analizzaazienda"
        TreeNode16.SelectedImageIndex = 1
        TreeNode16.Text = "Analizza Andamento Azienda"
        TreeNode17.ImageKey = "contabilita_menu"
        TreeNode17.Name = "nd_contabilita"
        TreeNode17.SelectedImageKey = "contabilita_menu"
        TreeNode17.Text = "Contabilitá"
        TreeNode18.ImageKey = "omino_carta.png"
        TreeNode18.Name = "nd_generaPDF"
        TreeNode18.SelectedImageKey = "ricarca_avvio"
        TreeNode18.Text = "Separazione PDF"
        TreeNode18.ToolTipText = "Suddivide i pdf in base a ricerche"
        TreeNode19.ImageKey = "omino_cliente.png"
        TreeNode19.Name = "ndFatPublicazione"
        TreeNode19.SelectedImageKey = "dipendenti_formazione_avvio"
        TreeNode19.Text = "Pubblica Fatture in Rete"
        TreeNode20.ImageKey = "omino48agenda.png"
        TreeNode20.Name = "ND_cli_riepilogo_ore"
        TreeNode20.SelectedImageIndex = 33
        TreeNode20.Text = "Riepilogo Presenze"
        TreeNode21.ImageIndex = 18
        TreeNode21.Name = "nd_www"
        TreeNode21.SelectedImageIndex = 24
        TreeNode21.Text = "Gestione documentale"
        TreeNode22.ImageIndex = 35
        TreeNode22.Name = "nd_dip_ferie"
        TreeNode22.SelectedImageIndex = 35
        TreeNode22.Text = "Piano Ferie e permessi"
        TreeNode23.ImageKey = "ricarca_avvio"
        TreeNode23.Name = "ndRicercaPersonale"
        TreeNode23.SelectedImageIndex = 15
        TreeNode23.Text = "Ricerca Personale"
        TreeNode24.ImageIndex = 15
        TreeNode24.Name = "ndAutorizzaFerie"
        TreeNode24.SelectedImageIndex = 15
        TreeNode24.Text = "Autorizza Ferie Dipendente"
        TreeNode25.ImageIndex = 38
        TreeNode25.Name = "ndAssegnaGPS"
        TreeNode25.SelectedImageIndex = 38
        TreeNode25.Text = "Verifiche posizioni GPS"
        TreeNode26.ImageKey = "vacanza.jpeg"
        TreeNode26.Name = "nd_sostituzioni"
        TreeNode26.SelectedImageKey = "vacanza.jpeg"
        TreeNode26.Text = "Gestione Dipendenti"
        TreeNode27.ImageIndex = 36
        TreeNode27.Name = "ndIOP"
        TreeNode27.SelectedImageIndex = 36
        TreeNode27.Text = "IOP istruzioni Operative"
        TreeNode28.ImageIndex = 37
        TreeNode28.Name = "ndIstruzioni"
        TreeNode28.SelectedImageIndex = 37
        TreeNode28.Text = "Elenco Istruzioni"
        TreeNode29.ImageIndex = 6
        TreeNode29.Name = "ndDescrizioneProdotti"
        TreeNode29.SelectedImageIndex = 6
        TreeNode29.Text = "Elenco Prodotti/Attrezzi/DPI"
        TreeNode30.ImageIndex = 11
        TreeNode30.Name = "ndCQclienti"
        TreeNode30.SelectedImageIndex = 31
        TreeNode30.Text = "Controllo Qualita Clienti"
        TreeNode31.Name = "ndReportQualita"
        TreeNode31.Text = "Report Esito Sondaggio"
        TreeNode32.ImageIndex = 37
        TreeNode32.Name = "ndISO9001"
        TreeNode32.SelectedImageIndex = 37
        TreeNode32.Text = "ISO 9001"
        TreeNode33.ImageKey = "credenziali_accesso"
        TreeNode33.Name = "nd_imp_accesso"
        TreeNode33.SelectedImageKey = "credenziali_accesso"
        TreeNode33.Text = "Credenziali di accesso"
        TreeNode34.ImageKey = "impostazioni_avvio"
        TreeNode34.Name = "nd_imp_cap"
        TreeNode34.SelectedImageKey = "impostazioni_avvio"
        TreeNode34.Text = "Codici avviamento Postale"
        TreeNode35.ImageKey = "impostazioni_avvio"
        TreeNode35.Name = "nd_imp_tipo_formazione"
        TreeNode35.SelectedImageKey = "impostazioni_avvio"
        TreeNode35.Text = "Tipo di Formazione"
        TreeNode36.Name = "nd_imp_con_remota"
        TreeNode36.Text = "Remota"
        TreeNode37.Name = "nd_imp_con_locale"
        TreeNode37.Text = "Locale"
        TreeNode38.Name = "nd_imp_net"
        TreeNode38.Text = "Connessione"
        TreeNode38.ToolTipText = "imposta la connessione se locale o in rete"
        TreeNode39.ImageKey = "impostazioni_avvio"
        TreeNode39.Name = "nd_imp_calendario"
        TreeNode39.SelectedImageKey = "impostazioni_avvio"
        TreeNode39.Text = "Genera Calendario"
        TreeNode40.ImageKey = "impostazioni_menu"
        TreeNode40.Name = "nd_impostazioni"
        TreeNode40.SelectedImageKey = "impostazioni_menu"
        TreeNode40.Text = "Impostazioni di sistema"
        TreeNode41.ImageIndex = 16
        TreeNode41.Name = "ndPreventivazione"
        TreeNode41.SelectedImageIndex = 16
        TreeNode41.Text = "Preventivazione"
        TreeNode42.ImageKey = "ominotermina48.png"
        TreeNode42.Name = "nd_termina"
        TreeNode42.SelectedImageKey = "ominotermina48.png"
        TreeNode42.Text = "Termina"
        Me.menu_principale.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode8, TreeNode17, TreeNode21, TreeNode26, TreeNode32, TreeNode40, TreeNode41, TreeNode42})
        Me.menu_principale.SelectedImageIndex = 8
        Me.menu_principale.Size = New System.Drawing.Size(300, 468)
        Me.menu_principale.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label3.Location = New System.Drawing.Point(3, 474)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(300, 22)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Segnalazioni"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tvSegnalazioniClienti
        '
        Me.tvSegnalazioniClienti.Location = New System.Drawing.Point(3, 499)
        Me.tvSegnalazioniClienti.Name = "tvSegnalazioniClienti"
        Me.tvSegnalazioniClienti.Size = New System.Drawing.Size(300, 74)
        Me.tvSegnalazioniClienti.TabIndex = 1
        '
        'btFeriePresenti
        '
        Me.btFeriePresenti.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btFeriePresenti.AutoSize = True
        Me.btFeriePresenti.Location = New System.Drawing.Point(3, 663)
        Me.btFeriePresenti.Name = "btFeriePresenti"
        Me.btFeriePresenti.Size = New System.Drawing.Size(300, 34)
        Me.btFeriePresenti.TabIndex = 0
        Me.btFeriePresenti.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label5.Location = New System.Drawing.Point(3, 638)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(300, 22)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Ferie e permessi"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LL_ordiniweb
        '
        Me.LL_ordiniweb.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LL_ordiniweb.AutoSize = True
        Me.LL_ordiniweb.Location = New System.Drawing.Point(3, 601)
        Me.LL_ordiniweb.Name = "LL_ordiniweb"
        Me.LL_ordiniweb.Size = New System.Drawing.Size(300, 34)
        Me.LL_ordiniweb.TabIndex = 28
        Me.LL_ordiniweb.Text = "WebOrdini"
        Me.LL_ordiniweb.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.38389!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.61611!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel4, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel1, 1, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 27)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 706.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1062, 706)
        Me.TableLayoutPanel2.TabIndex = 198
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TL_controlloAgenda, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel5, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel8, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(313, 1)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(1)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 162.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(748, 704)
        Me.TableLayoutPanel1.TabIndex = 197
        '
        'TL_controlloAgenda
        '
        Me.TL_controlloAgenda.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TL_controlloAgenda.ColumnCount = 5
        Me.TL_controlloAgenda.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.06053!))
        Me.TL_controlloAgenda.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.45659!))
        Me.TL_controlloAgenda.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.21727!))
        Me.TL_controlloAgenda.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.173158!))
        Me.TL_controlloAgenda.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.09244!))
        Me.TL_controlloAgenda.Controls.Add(Me.tblinserimentoPeriodoLavoro, 0, 0)
        Me.TL_controlloAgenda.Controls.Add(Me.TableLayoutPanel3, 2, 0)
        Me.TL_controlloAgenda.Controls.Add(Me.PClock, 4, 0)
        Me.TL_controlloAgenda.Controls.Add(Me.Panel1, 1, 0)
        Me.TL_controlloAgenda.Location = New System.Drawing.Point(2, 2)
        Me.TL_controlloAgenda.Margin = New System.Windows.Forms.Padding(0)
        Me.TL_controlloAgenda.Name = "TL_controlloAgenda"
        Me.TL_controlloAgenda.RowCount = 1
        Me.TL_controlloAgenda.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TL_controlloAgenda.Size = New System.Drawing.Size(744, 70)
        Me.TL_controlloAgenda.TabIndex = 198
        '
        'tblinserimentoPeriodoLavoro
        '
        Me.tblinserimentoPeriodoLavoro.ColumnCount = 2
        Me.tblinserimentoPeriodoLavoro.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblinserimentoPeriodoLavoro.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 164.0!))
        Me.tblinserimentoPeriodoLavoro.Controls.Add(Me.cmbMese, 1, 0)
        Me.tblinserimentoPeriodoLavoro.Controls.Add(Me.cmbAnno, 1, 1)
        Me.tblinserimentoPeriodoLavoro.Controls.Add(Me.Label1, 0, 0)
        Me.tblinserimentoPeriodoLavoro.Controls.Add(Me.Label2, 0, 1)
        Me.tblinserimentoPeriodoLavoro.Dock = System.Windows.Forms.DockStyle.Top
        Me.tblinserimentoPeriodoLavoro.Location = New System.Drawing.Point(0, 0)
        Me.tblinserimentoPeriodoLavoro.Margin = New System.Windows.Forms.Padding(0)
        Me.tblinserimentoPeriodoLavoro.Name = "tblinserimentoPeriodoLavoro"
        Me.tblinserimentoPeriodoLavoro.RowCount = 2
        Me.tblinserimentoPeriodoLavoro.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblinserimentoPeriodoLavoro.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblinserimentoPeriodoLavoro.Size = New System.Drawing.Size(305, 70)
        Me.tblinserimentoPeriodoLavoro.TabIndex = 199
        '
        'cmbMese
        '
        Me.cmbMese.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbMese.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cmbMese.FormattingEnabled = True
        Me.cmbMese.Location = New System.Drawing.Point(144, 3)
        Me.cmbMese.Name = "cmbMese"
        Me.cmbMese.Size = New System.Drawing.Size(158, 28)
        Me.cmbMese.TabIndex = 0
        '
        'cmbAnno
        '
        Me.cmbAnno.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbAnno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cmbAnno.FormattingEnabled = True
        Me.cmbAnno.Location = New System.Drawing.Point(144, 38)
        Me.cmbAnno.Name = "cmbAnno"
        Me.cmbAnno.Size = New System.Drawing.Size(158, 28)
        Me.cmbAnno.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(29, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Mese di Lavoro:"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(30, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Anno di Lavoro:"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.TX_dataoggi, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TX_nomegiorno, 0, 1)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(434, 0)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(202, 70)
        Me.TableLayoutPanel3.TabIndex = 198
        '
        'PClock
        '
        Me.PClock.Image = CType(resources.GetObject("PClock.Image"), System.Drawing.Image)
        Me.PClock.InitialImage = CType(resources.GetObject("PClock.InitialImage"), System.Drawing.Image)
        Me.PClock.Location = New System.Drawing.Point(644, 0)
        Me.PClock.Margin = New System.Windows.Forms.Padding(0)
        Me.PClock.Name = "PClock"
        Me.PClock.Size = New System.Drawing.Size(68, 70)
        Me.PClock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PClock.TabIndex = 0
        Me.PClock.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lbAzienda)
        Me.Panel1.Controls.Add(Me.CBazienda)
        Me.Panel1.Location = New System.Drawing.Point(308, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(123, 64)
        Me.Panel1.TabIndex = 200
        Me.Panel1.Visible = False
        '
        'lbAzienda
        '
        Me.lbAzienda.AutoSize = True
        Me.lbAzienda.Location = New System.Drawing.Point(14, 14)
        Me.lbAzienda.Name = "lbAzienda"
        Me.lbAzienda.Size = New System.Drawing.Size(93, 13)
        Me.lbAzienda.TabIndex = 202
        Me.lbAzienda.Text = "Azenda produttiva"
        '
        'CBazienda
        '
        Me.CBazienda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBazienda.FormattingEnabled = True
        Me.CBazienda.Location = New System.Drawing.Point(3, 37)
        Me.CBazienda.Name = "CBazienda"
        Me.CBazienda.Size = New System.Drawing.Size(120, 21)
        Me.CBazienda.TabIndex = 201
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.DG_giorno, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.LB_assenti, 0, 1)
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 75)
        Me.TableLayoutPanel5.Margin = New System.Windows.Forms.Padding(1)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(742, 462)
        Me.TableLayoutPanel5.TabIndex = 200
        '
        'DG_giorno
        '
        Me.DG_giorno.AllowUserToAddRows = False
        Me.DG_giorno.AllowUserToDeleteRows = False
        Me.DG_giorno.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG_giorno.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DG_giorno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_giorno.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CAgendaID, Me.C_data, Me.C_Ora, Me.C_sostituto, Me.C_Assente, Me.C_cliente, Me.C_locazione, Me.C_tipo, Me.C_note, Me.C_ID, Me.C_iddip, Me.C_IDsost, Me.C_IDcli, Me.DGWCsostidraggruppamento, Me.DGWCsostidconfermato})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DG_giorno.DefaultCellStyle = DataGridViewCellStyle2
        Me.DG_giorno.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG_giorno.Location = New System.Drawing.Point(1, 1)
        Me.DG_giorno.Margin = New System.Windows.Forms.Padding(1)
        Me.DG_giorno.Name = "DG_giorno"
        Me.DG_giorno.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG_giorno.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DG_giorno.RowHeadersVisible = False
        Me.DG_giorno.RowHeadersWidth = 4
        Me.DG_giorno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_giorno.Size = New System.Drawing.Size(740, 432)
        Me.DG_giorno.TabIndex = 197
        '
        'CAgendaID
        '
        Me.CAgendaID.HeaderText = "ID"
        Me.CAgendaID.MinimumWidth = 10
        Me.CAgendaID.Name = "CAgendaID"
        Me.CAgendaID.ReadOnly = True
        Me.CAgendaID.Visible = False
        '
        'C_data
        '
        Me.C_data.HeaderText = "Data"
        Me.C_data.Name = "C_data"
        Me.C_data.ReadOnly = True
        Me.C_data.Visible = False
        '
        'C_Ora
        '
        Me.C_Ora.FillWeight = 35.0!
        Me.C_Ora.HeaderText = "Ora"
        Me.C_Ora.MinimumWidth = 10
        Me.C_Ora.Name = "C_Ora"
        Me.C_Ora.ReadOnly = True
        '
        'C_sostituto
        '
        Me.C_sostituto.FillWeight = 30.0!
        Me.C_sostituto.HeaderText = "Assente"
        Me.C_sostituto.MinimumWidth = 10
        Me.C_sostituto.Name = "C_sostituto"
        Me.C_sostituto.ReadOnly = True
        '
        'C_Assente
        '
        Me.C_Assente.FillWeight = 30.0!
        Me.C_Assente.HeaderText = "Sostituito"
        Me.C_Assente.MinimumWidth = 10
        Me.C_Assente.Name = "C_Assente"
        Me.C_Assente.ReadOnly = True
        '
        'C_cliente
        '
        Me.C_cliente.FillWeight = 40.0!
        Me.C_cliente.HeaderText = "Cantiere"
        Me.C_cliente.MinimumWidth = 10
        Me.C_cliente.Name = "C_cliente"
        Me.C_cliente.ReadOnly = True
        Me.C_cliente.Visible = False
        '
        'C_locazione
        '
        Me.C_locazione.FillWeight = 50.0!
        Me.C_locazione.HeaderText = "Dettaglio"
        Me.C_locazione.MinimumWidth = 10
        Me.C_locazione.Name = "C_locazione"
        Me.C_locazione.ReadOnly = True
        '
        'C_tipo
        '
        Me.C_tipo.FillWeight = 20.0!
        Me.C_tipo.HeaderText = "Tipo"
        Me.C_tipo.MinimumWidth = 10
        Me.C_tipo.Name = "C_tipo"
        Me.C_tipo.ReadOnly = True
        '
        'C_note
        '
        Me.C_note.FillWeight = 50.0!
        Me.C_note.HeaderText = "Note"
        Me.C_note.MinimumWidth = 10
        Me.C_note.Name = "C_note"
        Me.C_note.ReadOnly = True
        '
        'C_ID
        '
        Me.C_ID.HeaderText = "identificativo"
        Me.C_ID.MinimumWidth = 10
        Me.C_ID.Name = "C_ID"
        Me.C_ID.ReadOnly = True
        Me.C_ID.Visible = False
        '
        'C_iddip
        '
        Me.C_iddip.HeaderText = "IDdipendente"
        Me.C_iddip.Name = "C_iddip"
        Me.C_iddip.ReadOnly = True
        Me.C_iddip.Visible = False
        '
        'C_IDsost
        '
        Me.C_IDsost.HeaderText = "IDSost"
        Me.C_IDsost.Name = "C_IDsost"
        Me.C_IDsost.ReadOnly = True
        Me.C_IDsost.Visible = False
        '
        'C_IDcli
        '
        Me.C_IDcli.HeaderText = "IDcli"
        Me.C_IDcli.Name = "C_IDcli"
        Me.C_IDcli.ReadOnly = True
        Me.C_IDcli.Visible = False
        '
        'DGWCsostidraggruppamento
        '
        Me.DGWCsostidraggruppamento.HeaderText = "raggruppato"
        Me.DGWCsostidraggruppamento.Name = "DGWCsostidraggruppamento"
        Me.DGWCsostidraggruppamento.ReadOnly = True
        Me.DGWCsostidraggruppamento.Visible = False
        '
        'DGWCsostidconfermato
        '
        Me.DGWCsostidconfermato.HeaderText = "Confermato"
        Me.DGWCsostidconfermato.Name = "DGWCsostidconfermato"
        Me.DGWCsostidconfermato.ReadOnly = True
        Me.DGWCsostidconfermato.Visible = False
        '
        'LB_assenti
        '
        Me.LB_assenti.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LB_assenti.AutoSize = True
        Me.LB_assenti.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_assenti.Location = New System.Drawing.Point(3, 434)
        Me.LB_assenti.Name = "LB_assenti"
        Me.LB_assenti.Size = New System.Drawing.Size(736, 28)
        Me.LB_assenti.TabIndex = 199
        Me.LB_assenti.Text = "Label1"
        Me.LB_assenti.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.ColumnCount = 2
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 148.0!))
        Me.TableLayoutPanel8.Controls.Add(Me.TableLayoutPanel7, 0, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.BT_termina, 1, 0)
        Me.TableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(5, 543)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 1
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(738, 156)
        Me.TableLayoutPanel8.TabIndex = 203
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 3
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel7.Controls.Add(Me.BT_avanti, 2, 1)
        Me.TableLayoutPanel7.Controls.Add(Me.BT_stampa, 2, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.BT_agenda, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.BT_nuovo, 1, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.BT_oggi, 1, 1)
        Me.TableLayoutPanel7.Controls.Add(Me.BT_indietro, 0, 1)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 2
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(584, 150)
        Me.TableLayoutPanel7.TabIndex = 204
        '
        'BT_agenda
        '
        Me.BT_agenda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BT_agenda.FlatAppearance.BorderSize = 0
        Me.BT_agenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_agenda.Image = CType(resources.GetObject("BT_agenda.Image"), System.Drawing.Image)
        Me.BT_agenda.Location = New System.Drawing.Point(2, 2)
        Me.BT_agenda.Margin = New System.Windows.Forms.Padding(2)
        Me.BT_agenda.Name = "BT_agenda"
        Me.BT_agenda.Size = New System.Drawing.Size(190, 71)
        Me.BT_agenda.TabIndex = 198
        Me.BT_agenda.UseVisualStyleBackColor = True
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.FillWeight = 45.0!
        Me.DataGridViewTextBoxColumn2.HeaderText = "Ora"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        Me.DataGridViewTextBoxColumn2.Width = 90
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.FillWeight = 50.0!
        Me.DataGridViewTextBoxColumn3.HeaderText = "Assente"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        Me.DataGridViewTextBoxColumn3.Width = 102
        '
        'DataGridViewTextBoxColumn4
        '
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn4.FillWeight = 50.0!
        Me.DataGridViewTextBoxColumn4.HeaderText = "Sostituzione"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 102
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn5.FillWeight = 50.0!
        Me.DataGridViewTextBoxColumn5.HeaderText = "Cantiere"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.FillWeight = 50.0!
        Me.DataGridViewTextBoxColumn6.HeaderText = "Destinatario"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Visible = False
        Me.DataGridViewTextBoxColumn6.Width = 102
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.FillWeight = 30.0!
        Me.DataGridViewTextBoxColumn7.HeaderText = "Tipo"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Visible = False
        Me.DataGridViewTextBoxColumn7.Width = 61
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.FillWeight = 30.0!
        Me.DataGridViewTextBoxColumn8.HeaderText = "Note"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        Me.DataGridViewTextBoxColumn8.Width = 88
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.FillWeight = 45.0!
        Me.DataGridViewTextBoxColumn9.HeaderText = "identificativo"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Visible = False
        Me.DataGridViewTextBoxColumn9.Width = 89
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn10.FillWeight = 45.0!
        Me.DataGridViewTextBoxColumn10.HeaderText = "id"
        Me.DataGridViewTextBoxColumn10.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Visible = False
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.FillWeight = 60.0!
        Me.DataGridViewTextBoxColumn11.HeaderText = "idinviato"
        Me.DataGridViewTextBoxColumn11.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Visible = False
        Me.DataGridViewTextBoxColumn11.Width = 78
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.FillWeight = 60.0!
        Me.DataGridViewTextBoxColumn12.HeaderText = "iddestinatario"
        Me.DataGridViewTextBoxColumn12.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Visible = False
        Me.DataGridViewTextBoxColumn12.Width = 118
        '
        'DataGridViewTextBoxColumn13
        '
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn13.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn13.FillWeight = 40.0!
        Me.DataGridViewTextBoxColumn13.HeaderText = "Cosa"
        Me.DataGridViewTextBoxColumn13.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Visible = False
        Me.DataGridViewTextBoxColumn13.Width = 365
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn14.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn14.FillWeight = 3.0!
        Me.DataGridViewTextBoxColumn14.HeaderText = "V"
        Me.DataGridViewTextBoxColumn14.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Visible = False
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.FillWeight = 15.0!
        Me.DataGridViewTextBoxColumn15.HeaderText = "Quando"
        Me.DataGridViewTextBoxColumn15.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Visible = False
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.HeaderText = "IDdipendente"
        Me.DataGridViewTextBoxColumn16.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.Visible = False
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.HeaderText = "IDSost"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.Visible = False
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.HeaderText = "IDcli"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.Visible = False
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.HeaderText = "IDcli"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.Visible = False
        '
        'Frmavvio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1062, 781)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.TX_avvio)
        Me.Controls.Add(Me.STS_informazioni)
        Me.Controls.Add(Me.MNS_menu_tendina)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MNS_menu_tendina
        Me.Name = "Frmavvio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Progetto Organizzazione Pulizie"
        Me.MNS_menu_tendina.ResumeLayout(False)
        Me.MNS_menu_tendina.PerformLayout()
        Me.STS_informazioni.ResumeLayout(False)
        Me.STS_informazioni.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TL_controlloAgenda.ResumeLayout(False)
        Me.tblinserimentoPeriodoLavoro.ResumeLayout(False)
        Me.tblinserimentoPeriodoLavoro.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.PClock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        CType(Me.DG_giorno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.TableLayoutPanel8.PerformLayout()
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MNS_menu_tendina As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TerminaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ApplicativiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DipendentiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Listaimmagini As ImageList
    Friend WithEvents btn_credenziali As Button
    Friend WithEvents informazioniAvvio As ToolTip
    Friend WithEvents STS_informazioni As StatusStrip
    Friend WithEvents STS_dipendenti As ToolStripStatusLabel
    Friend WithEvents STS_clienti As ToolStripStatusLabel
    Friend WithEvents STS_materiale As ToolStripStatusLabel
    Friend WithEvents STS_contabilita As ToolStripStatusLabel
    Friend WithEvents STS_impostazioni As ToolStripStatusLabel
    Friend WithEvents immagini_menu As ImageList
    Friend WithEvents AnagraficaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AnagraficaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MagazzinoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrdiniToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProdottiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FornitoriToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CategorieToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContabilitaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FatturazioneToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrimaNotaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImpostazioniToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CredenzialiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FinestraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CreditiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AiutiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Etichetta_rete As ToolStripStatusLabel
    Friend WithEvents Spazio As ToolStripStatusLabel
    Friend WithEvents STS_user As ToolStripStatusLabel
    Friend WithEvents TX_avvio As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents TBL_pulsanti As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents menu_principale As TreeView
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TL_controlloAgenda As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TX_dataoggi As TextBox
    Friend WithEvents TX_nomegiorno As TextBox
    Friend WithEvents LB_assenti As Label
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents DG_giorno As DataGridView
    Friend WithEvents InserimentoPresenzeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PianoDiLavoroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PianoDiLavoroToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents RiepilogoPresenzeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RedditivitàToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MNU_letteredipendenti As ToolStripMenuItem
    Friend WithEvents MNUControllaLePresenzeMenisili As ToolStripMenuItem
    Friend WithEvents MacchinariToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents GestioneSostituzioneFerieToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BT_nuovo As Button
    Friend WithEvents BT_stampa As Button
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents BT_oggi As Button
    Friend WithEvents BT_agenda As Button
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents BT_avanti As Button
    Friend WithEvents BT_indietro As Button
    Friend WithEvents PClock As PictureBox
    Friend WithEvents BT_termina As Button
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents SettaggioVariabiliToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tblinserimentoPeriodoLavoro As TableLayoutPanel
    Friend WithEvents cmbMese As ComboBox
    Friend WithEvents cmbAnno As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CAgendaID As DataGridViewTextBoxColumn
    Friend WithEvents C_data As DataGridViewTextBoxColumn
    Friend WithEvents C_Ora As DataGridViewTextBoxColumn
    Friend WithEvents C_sostituto As DataGridViewTextBoxColumn
    Friend WithEvents C_Assente As DataGridViewTextBoxColumn
    Friend WithEvents C_cliente As DataGridViewTextBoxColumn
    Friend WithEvents C_locazione As DataGridViewTextBoxColumn
    Friend WithEvents C_tipo As DataGridViewTextBoxColumn
    Friend WithEvents C_note As DataGridViewTextBoxColumn
    Friend WithEvents C_ID As DataGridViewTextBoxColumn
    Friend WithEvents C_iddip As DataGridViewTextBoxColumn
    Friend WithEvents C_IDsost As DataGridViewTextBoxColumn
    Friend WithEvents C_IDcli As DataGridViewTextBoxColumn
    Friend WithEvents DGWCsostidraggruppamento As DataGridViewTextBoxColumn
    Friend WithEvents DGWCsostidconfermato As DataGridViewTextBoxColumn
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents btFeriePresenti As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CBazienda As ComboBox
    Friend WithEvents lbAzienda As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tvSegnalazioniClienti As TreeView
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LL_ordiniweb As Button
End Class
