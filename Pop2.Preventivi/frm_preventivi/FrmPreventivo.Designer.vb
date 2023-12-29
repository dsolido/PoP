Imports Pop2.Comuni
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPreventivo
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IdLabel As System.Windows.Forms.Label
        Dim SocietaLabel As System.Windows.Forms.Label
        Dim IndirizzoLabel As System.Windows.Forms.Label
        Dim CapLabel As System.Windows.Forms.Label
        Dim TitLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim SicurezzaluoghiLabel As System.Windows.Forms.Label
        Dim PrezzooranumLabel As System.Windows.Forms.Label
        Dim CanonenumLabel As System.Windows.Forms.Label
        Dim SicurezzanumLabel As System.Windows.Forms.Label
        Dim ScadenzaLabel As System.Windows.Forms.Label
        Dim NoteLabel As System.Windows.Forms.Label
        Dim RicontattiLabel As System.Windows.Forms.Label
        Dim R_telLabel As System.Windows.Forms.Label
        Dim R_mailLabel As System.Windows.Forms.Label
        Dim CreatoilLabel As System.Windows.Forms.Label
        Dim DecorrenzaLabel As System.Windows.Forms.Label
        Dim P_ivaLabel As System.Windows.Forms.Label
        Dim C_fLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPreventivo))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.bsRelPreventiviDestinatariPreventivi = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsPreventiviDestinatari = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPreventivi = New PoP2.Comuni.DSPreventivi()
        Me.DM_barra = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.TTBTElimina = New System.Windows.Forms.ToolStripButton()
        Me.TTTestoRicerca = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.TTBTAggiunge = New System.Windows.Forms.ToolStripButton()
        Me.TTBTRicarica = New System.Windows.Forms.ToolStripButton()
        Me.TTBTTermina = New System.Windows.Forms.ToolStripButton()
        Me.TTBTStampa = New System.Windows.Forms.ToolStripButton()
        Me.tsbOperazioni = New System.Windows.Forms.ToolStripButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.CapTextBox = New System.Windows.Forms.TextBox()
        Me.LocalitaTextBox = New System.Windows.Forms.TextBox()
        Me.PrvTextBox = New System.Windows.Forms.TextBox()
        Me.TitTextBox = New System.Windows.Forms.TextBox()
        Me.RespTextBox = New System.Windows.Forms.TextBox()
        Me.PrezzooranumTextBox = New System.Windows.Forms.TextBox()
        Me.PrezzooratxtTextBox = New System.Windows.Forms.TextBox()
        Me.CanonenumTextBox = New System.Windows.Forms.TextBox()
        Me.CanonetxtTextBox = New System.Windows.Forms.TextBox()
        Me.SicurezzanumTextBox = New System.Windows.Forms.TextBox()
        Me.SicurezzatxtTextBox = New System.Windows.Forms.TextBox()
        Me.ProvanumTextBox = New System.Windows.Forms.TextBox()
        Me.ProvadatDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.tabPreventivi = New System.Windows.Forms.TabControl()
        Me.tbPreventivo = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btCreaCliente = New System.Windows.Forms.Button()
        Me.btMemorizza = New System.Windows.Forms.Button()
        Me.btDuplica = New System.Windows.Forms.Button()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.SocietaTextBox = New System.Windows.Forms.TextBox()
        Me.IndirizzoTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.SicurezzaluoghiTextBox = New System.Windows.Forms.TextBox()
        Me.ScadenzaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.NoteTextBox = New System.Windows.Forms.TextBox()
        Me.RicontattiTextBox = New System.Windows.Forms.TextBox()
        Me.R_telTextBox = New System.Windows.Forms.TextBox()
        Me.R_mailTextBox = New System.Windows.Forms.TextBox()
        Me.CreatoilDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DecorrenzaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.P_ivaTextBox = New System.Windows.Forms.TextBox()
        Me.C_fTextBox = New System.Windows.Forms.TextBox()
        Me.dgwDimensioni = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdpreventivoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescrizioneDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DimensioniDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.relPreventiviDestinatariPreventiviDimensioni = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgwDestinatari = New System.Windows.Forms.DataGridView()
        Me.dgwccreatoil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwcSocietaDestinatario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwcLocalita = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwcResp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwctelefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlOperazioni = New System.Windows.Forms.Panel()
        Me.dgwPreventivi = New System.Windows.Forms.DataGridView()
        Me.dgwcCategoria = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.bsPreventiviCategorie = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgwcid_dimensioni = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.dgwcID_Operazioni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwcOperazione = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwcFrequenza = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.bsPreventiviFrequenze = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgwcImpegnomq = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwcImpegnonumero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwcTaratura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwcFreq = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwcRisultato = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwcIDpreventivi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwcSortPreventivi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwcDestinatario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwcDimensioni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwcAttivo = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.lbClienteAbbinato = New System.Windows.Forms.ListBox()
        Me.btEliminaAbbinamento = New System.Windows.Forms.Button()
        Me.gbAbbinamentoCliente = New System.Windows.Forms.GroupBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.relDettaglio = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsCantieri = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_clienti = New PoP2.Comuni.DS_clienti()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.dgwcSocietaAbbinabile = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbRicercaClienteabbinabile = New System.Windows.Forms.TextBox()
        Me.btAbbinaPreventivo = New System.Windows.Forms.Button()
        Me.btnPreventivisvuotaArray = New System.Windows.Forms.Button()
        Me.btnPreventiviIncolla = New System.Windows.Forms.Button()
        Me.btnPreventiviCopia = New System.Windows.Forms.Button()
        Me.tbCalcoli = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.chGraficoPreventivo = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgwRisultato = New System.Windows.Forms.DataGridView()
        Me.dgwElencoDimensioni = New System.Windows.Forms.DataGridView()
        Me.DescrizioneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DimensioniDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txSconto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txCostoOrario = New System.Windows.Forms.TextBox()
        Me.btAggiornaGrafico = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbElencoOperazioni = New System.Windows.Forms.TabPage()
        Me.dgwOperazioni = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn39 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn38 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn36 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn40 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn37 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsPreventiviOperazioni = New System.Windows.Forms.BindingSource(Me.components)
        Me.relPreventiviDimensionidtPreventivi = New System.Windows.Forms.BindingSource(Me.components)
        Me.RelPreventiviAbbinamento = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsPreventivi = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TA_cantieri_new = New PoP2.Comuni.DS_clientiTableAdapters.TA_cantieri_new()
        Me.TA_locazione_new = New PoP2.Comuni.DS_clientiTableAdapters.TA_locazione_new()
        Me.bsPreventiviabbinamento = New System.Windows.Forms.BindingSource(Me.components)
        Me.TaPreventiviDestinatari = New PoP2.Comuni.DSPreventiviTableAdapters.taPreventiviDestinatari()
        Me.TableAdapterManager = New PoP2.Comuni.DSPreventiviTableAdapters.TableAdapterManager()
        Me.TaPreventivi = New PoP2.Comuni.DSPreventiviTableAdapters.taPreventivi()
        Me.TaPreventiviOperazioni = New PoP2.Comuni.DSPreventiviTableAdapters.taPreventiviOperazioni()
        Me.TaPreventiviFrequenze = New PoP2.Comuni.DSPreventiviTableAdapters.taPreventiviFrequenze()
        Me.TaPreventiviCategorie = New PoP2.Comuni.DSPreventiviTableAdapters.taPreventiviCategorie()
        Me.TaPreventiviDimensioni = New PoP2.Comuni.DSPreventiviTableAdapters.taPreventiviDimensioni()
        Me.bsPreventiviDimensioni = New System.Windows.Forms.BindingSource(Me.components)
        Me.TaPreventiviAbbinamento = New PoP2.Comuni.DSPreventiviTableAdapters.taPreventiviAbbinamento()
        Me.dgwcLocazioneAbbinabile = New System.Windows.Forms.DataGridViewTextBoxColumn()
        IdLabel = New System.Windows.Forms.Label()
        SocietaLabel = New System.Windows.Forms.Label()
        IndirizzoLabel = New System.Windows.Forms.Label()
        CapLabel = New System.Windows.Forms.Label()
        TitLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        SicurezzaluoghiLabel = New System.Windows.Forms.Label()
        PrezzooranumLabel = New System.Windows.Forms.Label()
        CanonenumLabel = New System.Windows.Forms.Label()
        SicurezzanumLabel = New System.Windows.Forms.Label()
        ScadenzaLabel = New System.Windows.Forms.Label()
        NoteLabel = New System.Windows.Forms.Label()
        RicontattiLabel = New System.Windows.Forms.Label()
        R_telLabel = New System.Windows.Forms.Label()
        R_mailLabel = New System.Windows.Forms.Label()
        CreatoilLabel = New System.Windows.Forms.Label()
        DecorrenzaLabel = New System.Windows.Forms.Label()
        P_ivaLabel = New System.Windows.Forms.Label()
        C_fLabel = New System.Windows.Forms.Label()
        CType(Me.bsRelPreventiviDestinatariPreventivi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsPreventiviDestinatari, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPreventivi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DM_barra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DM_barra.SuspendLayout()
        Me.tabPreventivi.SuspendLayout()
        Me.tbPreventivo.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgwDimensioni, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.relPreventiviDestinatariPreventiviDimensioni, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgwDestinatari, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlOperazioni.SuspendLayout()
        CType(Me.dgwPreventivi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsPreventiviCategorie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsPreventiviFrequenze, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbAbbinamentoCliente.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.relDettaglio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCantieri, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_clienti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbCalcoli.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.chGraficoPreventivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.dgwRisultato, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgwElencoDimensioni, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.tbElencoOperazioni.SuspendLayout()
        CType(Me.dgwOperazioni, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsPreventiviOperazioni, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.relPreventiviDimensionidtPreventivi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RelPreventiviAbbinamento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsPreventivi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsPreventiviabbinamento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsPreventiviDimensioni, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(97, 20)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(18, 13)
        IdLabel.TabIndex = 0
        IdLabel.Text = "id:"
        '
        'SocietaLabel
        '
        SocietaLabel.AutoSize = True
        SocietaLabel.Location = New System.Drawing.Point(69, 46)
        SocietaLabel.Name = "SocietaLabel"
        SocietaLabel.Size = New System.Drawing.Size(46, 13)
        SocietaLabel.TabIndex = 2
        SocietaLabel.Text = "Societa:"
        '
        'IndirizzoLabel
        '
        IndirizzoLabel.AutoSize = True
        IndirizzoLabel.Location = New System.Drawing.Point(67, 72)
        IndirizzoLabel.Name = "IndirizzoLabel"
        IndirizzoLabel.Size = New System.Drawing.Size(48, 13)
        IndirizzoLabel.TabIndex = 4
        IndirizzoLabel.Text = "Indirizzo:"
        '
        'CapLabel
        '
        CapLabel.AutoSize = True
        CapLabel.Location = New System.Drawing.Point(71, 97)
        CapLabel.Name = "CapLabel"
        CapLabel.Size = New System.Drawing.Size(44, 13)
        CapLabel.TabIndex = 6
        CapLabel.Text = "Località"
        '
        'TitLabel
        '
        TitLabel.AutoSize = True
        TitLabel.Location = New System.Drawing.Point(58, 123)
        TitLabel.Name = "TitLabel"
        TitLabel.Size = New System.Drawing.Size(57, 13)
        TitLabel.TabIndex = 12
        TitLabel.Text = "Referente:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Location = New System.Drawing.Point(63, 149)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(52, 13)
        TelefonoLabel.TabIndex = 16
        TelefonoLabel.Text = "Telefono:"
        '
        'SicurezzaluoghiLabel
        '
        SicurezzaluoghiLabel.AutoSize = True
        SicurezzaluoghiLabel.Location = New System.Drawing.Point(76, 175)
        SicurezzaluoghiLabel.Name = "SicurezzaluoghiLabel"
        SicurezzaluoghiLabel.Size = New System.Drawing.Size(39, 13)
        SicurezzaluoghiLabel.TabIndex = 18
        SicurezzaluoghiLabel.Text = "Luoghi"
        Me.ToolTip1.SetToolTip(SicurezzaluoghiLabel, "Inserire una breve descrizione dei luoghi interessati al servizio")
        '
        'PrezzooranumLabel
        '
        PrezzooranumLabel.AutoSize = True
        PrezzooranumLabel.Location = New System.Drawing.Point(12, 200)
        PrezzooranumLabel.Name = "PrezzooranumLabel"
        PrezzooranumLabel.Size = New System.Drawing.Size(103, 13)
        PrezzooranumLabel.TabIndex = 20
        PrezzooranumLabel.Text = "Prezzo in Economia:"
        '
        'CanonenumLabel
        '
        CanonenumLabel.AutoSize = True
        CanonenumLabel.Location = New System.Drawing.Point(27, 225)
        CanonenumLabel.Name = "CanonenumLabel"
        CanonenumLabel.Size = New System.Drawing.Size(88, 13)
        CanonenumLabel.TabIndex = 24
        CanonenumLabel.Text = "Canone Menisile:"
        '
        'SicurezzanumLabel
        '
        SicurezzanumLabel.AutoSize = True
        SicurezzanumLabel.Location = New System.Drawing.Point(29, 251)
        SicurezzanumLabel.Name = "SicurezzanumLabel"
        SicurezzanumLabel.Size = New System.Drawing.Size(86, 13)
        SicurezzanumLabel.TabIndex = 28
        SicurezzanumLabel.Text = "Costo Sicurezza:"
        '
        'ScadenzaLabel
        '
        ScadenzaLabel.AutoSize = True
        ScadenzaLabel.Location = New System.Drawing.Point(389, 258)
        ScadenzaLabel.Name = "ScadenzaLabel"
        ScadenzaLabel.Size = New System.Drawing.Size(58, 13)
        ScadenzaLabel.TabIndex = 21
        ScadenzaLabel.Text = "Scadenza:"
        '
        'NoteLabel
        '
        NoteLabel.AutoSize = True
        NoteLabel.Location = New System.Drawing.Point(82, 299)
        NoteLabel.Name = "NoteLabel"
        NoteLabel.Size = New System.Drawing.Size(33, 13)
        NoteLabel.TabIndex = 38
        NoteLabel.Text = "Note:"
        '
        'RicontattiLabel
        '
        RicontattiLabel.AutoSize = True
        RicontattiLabel.Location = New System.Drawing.Point(60, 344)
        RicontattiLabel.Name = "RicontattiLabel"
        RicontattiLabel.Size = New System.Drawing.Size(55, 13)
        RicontattiLabel.TabIndex = 40
        RicontattiLabel.Text = "Ricontatti:"
        '
        'R_telLabel
        '
        R_telLabel.AutoSize = True
        R_telLabel.Location = New System.Drawing.Point(38, 367)
        R_telLabel.Name = "R_telLabel"
        R_telLabel.Size = New System.Drawing.Size(77, 13)
        R_telLabel.TabIndex = 42
        R_telLabel.Text = "Tel Ricontatto:"
        '
        'R_mailLabel
        '
        R_mailLabel.AutoSize = True
        R_mailLabel.Location = New System.Drawing.Point(34, 390)
        R_mailLabel.Name = "R_mailLabel"
        R_mailLabel.Size = New System.Drawing.Size(81, 13)
        R_mailLabel.TabIndex = 44
        R_mailLabel.Text = "Mail Ricontatto:"
        '
        'CreatoilLabel
        '
        CreatoilLabel.AutoSize = True
        CreatoilLabel.Location = New System.Drawing.Point(225, 20)
        CreatoilLabel.Name = "CreatoilLabel"
        CreatoilLabel.Size = New System.Drawing.Size(41, 13)
        CreatoilLabel.TabIndex = 1
        CreatoilLabel.Text = "Creato:"
        '
        'DecorrenzaLabel
        '
        DecorrenzaLabel.AutoSize = True
        DecorrenzaLabel.Location = New System.Drawing.Point(50, 278)
        DecorrenzaLabel.Name = "DecorrenzaLabel"
        DecorrenzaLabel.Size = New System.Drawing.Size(65, 13)
        DecorrenzaLabel.TabIndex = 48
        DecorrenzaLabel.Text = "Decorrenza:"
        '
        'P_ivaLabel
        '
        P_ivaLabel.AutoSize = True
        P_ivaLabel.Location = New System.Drawing.Point(81, 321)
        P_ivaLabel.Name = "P_ivaLabel"
        P_ivaLabel.Size = New System.Drawing.Size(34, 13)
        P_ivaLabel.TabIndex = 50
        P_ivaLabel.Text = "P iva:"
        '
        'C_fLabel
        '
        C_fLabel.AutoSize = True
        C_fLabel.Location = New System.Drawing.Point(231, 321)
        C_fLabel.Name = "C_fLabel"
        C_fLabel.Size = New System.Drawing.Size(23, 13)
        C_fLabel.TabIndex = 19
        C_fLabel.Text = "CF:"
        '
        'bsRelPreventiviDestinatariPreventivi
        '
        Me.bsRelPreventiviDestinatariPreventivi.DataMember = "RelPreventiviDestinatari_Preventivi"
        Me.bsRelPreventiviDestinatariPreventivi.DataSource = Me.bsPreventiviDestinatari
        '
        'bsPreventiviDestinatari
        '
        Me.bsPreventiviDestinatari.DataMember = "dtPreventiviDestinatari"
        Me.bsPreventiviDestinatari.DataSource = Me.DsPreventivi
        '
        'DsPreventivi
        '
        Me.DsPreventivi.DataSetName = "dsPreventivi"
        Me.DsPreventivi.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DM_barra
        '
        Me.DM_barra.AddNewItem = Nothing
        Me.DM_barra.AutoSize = False
        Me.DM_barra.BindingSource = Me.bsPreventiviDestinatari
        Me.DM_barra.CountItem = Me.ToolStripLabel1
        Me.DM_barra.DeleteItem = Me.TTBTElimina
        Me.DM_barra.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DM_barra.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.DM_barra.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TTTestoRicerca, Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator3, Me.TTBTAggiunge, Me.TTBTRicarica, Me.TTBTElimina, Me.TTBTTermina, Me.TTBTStampa, Me.tsbOperazioni})
        Me.DM_barra.Location = New System.Drawing.Point(0, 841)
        Me.DM_barra.MoveFirstItem = Me.ToolStripButton1
        Me.DM_barra.MoveLastItem = Me.ToolStripButton4
        Me.DM_barra.MoveNextItem = Me.ToolStripButton3
        Me.DM_barra.MovePreviousItem = Me.ToolStripButton2
        Me.DM_barra.Name = "DM_barra"
        Me.DM_barra.PositionItem = Me.ToolStripTextBox1
        Me.DM_barra.Size = New System.Drawing.Size(1363, 100)
        Me.DM_barra.TabIndex = 192
        Me.DM_barra.Text = "BindingNavigator1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(55, 97)
        Me.ToolStripLabel1.Text = "di {0}"
        Me.ToolStripLabel1.ToolTipText = "Numero totale di elementi"
        '
        'TTBTElimina
        '
        Me.TTBTElimina.AutoSize = False
        Me.TTBTElimina.Image = Global.PoP2.Comuni.My.Resources.Resources.omino_cestino48
        Me.TTBTElimina.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TTBTElimina.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TTBTElimina.Name = "TTBTElimina"
        Me.TTBTElimina.RightToLeftAutoMirrorImage = True
        Me.TTBTElimina.Size = New System.Drawing.Size(50, 70)
        Me.TTBTElimina.Text = "Elimina"
        Me.TTBTElimina.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TTBTElimina.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'TTTestoRicerca
        '
        Me.TTTestoRicerca.BackColor = System.Drawing.Color.LightCyan
        Me.TTTestoRicerca.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.TTTestoRicerca.Name = "TTTestoRicerca"
        Me.TTTestoRicerca.Size = New System.Drawing.Size(116, 100)
        Me.TTTestoRicerca.ToolTipText = "Immettere l'anno di lavoro"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.AutoSize = False
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton1.Size = New System.Drawing.Size(45, 40)
        Me.ToolStripButton1.Text = "Inizio"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.AutoSize = False
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton2.Size = New System.Drawing.Size(45, 40)
        Me.ToolStripButton2.Text = "Indietro"
        Me.ToolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 100)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.AccessibleName = "Posizione"
        Me.ToolStripTextBox1.AutoSize = False
        Me.ToolStripTextBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(45, 33)
        Me.ToolStripTextBox1.Text = "0"
        Me.ToolStripTextBox1.ToolTipText = "Posizione corrente"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 100)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.AutoSize = False
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton3.Size = New System.Drawing.Size(45, 40)
        Me.ToolStripButton3.Text = "Avanti"
        Me.ToolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.AutoSize = False
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton4.Size = New System.Drawing.Size(45, 40)
        Me.ToolStripButton4.Text = "Fine"
        Me.ToolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 100)
        '
        'TTBTAggiunge
        '
        Me.TTBTAggiunge.AutoSize = False
        Me.TTBTAggiunge.Image = CType(resources.GetObject("TTBTAggiunge.Image"), System.Drawing.Image)
        Me.TTBTAggiunge.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TTBTAggiunge.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TTBTAggiunge.Name = "TTBTAggiunge"
        Me.TTBTAggiunge.RightToLeftAutoMirrorImage = True
        Me.TTBTAggiunge.Size = New System.Drawing.Size(50, 70)
        Me.TTBTAggiunge.Text = "Nuovo"
        Me.TTBTAggiunge.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TTBTAggiunge.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'TTBTRicarica
        '
        Me.TTBTRicarica.AutoSize = False
        Me.TTBTRicarica.Image = Global.PoP2.Comuni.My.Resources.Resources.ricicla48
        Me.TTBTRicarica.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TTBTRicarica.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TTBTRicarica.Name = "TTBTRicarica"
        Me.TTBTRicarica.Size = New System.Drawing.Size(50, 70)
        Me.TTBTRicarica.Text = "Ricarica"
        Me.TTBTRicarica.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TTBTRicarica.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'TTBTTermina
        '
        Me.TTBTTermina.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.TTBTTermina.AutoSize = False
        Me.TTBTTermina.Image = Global.PoP2.Comuni.My.Resources.Resources.ominotermina48
        Me.TTBTTermina.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TTBTTermina.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TTBTTermina.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TTBTTermina.Name = "TTBTTermina"
        Me.TTBTTermina.Size = New System.Drawing.Size(50, 70)
        Me.TTBTTermina.Text = "Termina"
        Me.TTBTTermina.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TTBTTermina.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'TTBTStampa
        '
        Me.TTBTStampa.AutoSize = False
        Me.TTBTStampa.Image = Global.PoP2.Comuni.My.Resources.Resources.omino_stampa48
        Me.TTBTStampa.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TTBTStampa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TTBTStampa.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TTBTStampa.Name = "TTBTStampa"
        Me.TTBTStampa.Size = New System.Drawing.Size(50, 70)
        Me.TTBTStampa.Text = "Stampa"
        Me.TTBTStampa.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TTBTStampa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.TTBTStampa.ToolTipText = "Elabora la stampa"
        '
        'tsbOperazioni
        '
        Me.tsbOperazioni.AutoSize = False
        Me.tsbOperazioni.Image = Global.PoP2.Comuni.My.Resources.Resources.ominofoglioore
        Me.tsbOperazioni.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.tsbOperazioni.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbOperazioni.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.tsbOperazioni.Name = "tsbOperazioni"
        Me.tsbOperazioni.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tsbOperazioni.RightToLeftAutoMirrorImage = True
        Me.tsbOperazioni.Size = New System.Drawing.Size(60, 70)
        Me.tsbOperazioni.Text = "Operazioni"
        Me.tsbOperazioni.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tsbOperazioni.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tsbOperazioni.ToolTipText = "Apre una maschera per inserire delle nuove operazioni"
        '
        'CapTextBox
        '
        Me.CapTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsPreventiviDestinatari, "cap", True))
        Me.CapTextBox.Location = New System.Drawing.Point(119, 94)
        Me.CapTextBox.Name = "CapTextBox"
        Me.CapTextBox.Size = New System.Drawing.Size(47, 20)
        Me.CapTextBox.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.CapTextBox, "Codice Avviamento postale")
        '
        'LocalitaTextBox
        '
        Me.LocalitaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsPreventiviDestinatari, "localita", True))
        Me.LocalitaTextBox.Location = New System.Drawing.Point(176, 94)
        Me.LocalitaTextBox.Name = "LocalitaTextBox"
        Me.LocalitaTextBox.Size = New System.Drawing.Size(143, 20)
        Me.LocalitaTextBox.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.LocalitaTextBox, "Città")
        '
        'PrvTextBox
        '
        Me.PrvTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsPreventiviDestinatari, "prv", True))
        Me.PrvTextBox.Location = New System.Drawing.Point(325, 94)
        Me.PrvTextBox.Name = "PrvTextBox"
        Me.PrvTextBox.Size = New System.Drawing.Size(52, 20)
        Me.PrvTextBox.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.PrvTextBox, "Provincia")
        '
        'TitTextBox
        '
        Me.TitTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsPreventiviDestinatari, "tit", True))
        Me.TitTextBox.Location = New System.Drawing.Point(119, 120)
        Me.TitTextBox.Name = "TitTextBox"
        Me.TitTextBox.Size = New System.Drawing.Size(47, 20)
        Me.TitTextBox.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.TitTextBox, "Inserire il Titolo")
        '
        'RespTextBox
        '
        Me.RespTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsPreventiviDestinatari, "Resp", True))
        Me.RespTextBox.Location = New System.Drawing.Point(176, 120)
        Me.RespTextBox.Name = "RespTextBox"
        Me.RespTextBox.Size = New System.Drawing.Size(200, 20)
        Me.RespTextBox.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.RespTextBox, "Nome del referente")
        '
        'PrezzooranumTextBox
        '
        Me.PrezzooranumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsPreventiviDestinatari, "prezzooranum", True))
        Me.PrezzooranumTextBox.Location = New System.Drawing.Point(119, 197)
        Me.PrezzooranumTextBox.Name = "PrezzooranumTextBox"
        Me.PrezzooranumTextBox.Size = New System.Drawing.Size(54, 20)
        Me.PrezzooranumTextBox.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.PrezzooranumTextBox, "Tariffa oraria in economia")
        '
        'PrezzooratxtTextBox
        '
        Me.PrezzooratxtTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsPreventiviDestinatari, "prezzooratxt", True))
        Me.PrezzooratxtTextBox.Location = New System.Drawing.Point(179, 197)
        Me.PrezzooratxtTextBox.Name = "PrezzooratxtTextBox"
        Me.PrezzooratxtTextBox.Size = New System.Drawing.Size(202, 20)
        Me.PrezzooratxtTextBox.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.PrezzooratxtTextBox, "Tariffa in lettere")
        '
        'CanonenumTextBox
        '
        Me.CanonenumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsPreventiviDestinatari, "canonenum", True))
        Me.CanonenumTextBox.Location = New System.Drawing.Point(119, 222)
        Me.CanonenumTextBox.Name = "CanonenumTextBox"
        Me.CanonenumTextBox.Size = New System.Drawing.Size(95, 20)
        Me.CanonenumTextBox.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.CanonenumTextBox, "Canone mensile")
        '
        'CanonetxtTextBox
        '
        Me.CanonetxtTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsPreventiviDestinatari, "canonetxt", True))
        Me.CanonetxtTextBox.Location = New System.Drawing.Point(220, 222)
        Me.CanonetxtTextBox.Name = "CanonetxtTextBox"
        Me.CanonetxtTextBox.Size = New System.Drawing.Size(159, 20)
        Me.CanonetxtTextBox.TabIndex = 15
        Me.ToolTip1.SetToolTip(Me.CanonetxtTextBox, "Canone in lettere")
        '
        'SicurezzanumTextBox
        '
        Me.SicurezzanumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsPreventiviDestinatari, "sicurezzanum", True))
        Me.SicurezzanumTextBox.Location = New System.Drawing.Point(119, 248)
        Me.SicurezzanumTextBox.Name = "SicurezzanumTextBox"
        Me.SicurezzanumTextBox.Size = New System.Drawing.Size(54, 20)
        Me.SicurezzanumTextBox.TabIndex = 16
        Me.ToolTip1.SetToolTip(Me.SicurezzanumTextBox, "Costo della sicurezza")
        '
        'SicurezzatxtTextBox
        '
        Me.SicurezzatxtTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsPreventiviDestinatari, "sicurezzatxt", True))
        Me.SicurezzatxtTextBox.Location = New System.Drawing.Point(179, 248)
        Me.SicurezzatxtTextBox.Name = "SicurezzatxtTextBox"
        Me.SicurezzatxtTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SicurezzatxtTextBox.TabIndex = 17
        Me.ToolTip1.SetToolTip(Me.SicurezzatxtTextBox, "Sicurezza in lettere")
        '
        'ProvanumTextBox
        '
        Me.ProvanumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsPreventiviDestinatari, "provanum", True))
        Me.ProvanumTextBox.Location = New System.Drawing.Point(220, 274)
        Me.ProvanumTextBox.Name = "ProvanumTextBox"
        Me.ProvanumTextBox.Size = New System.Drawing.Size(60, 20)
        Me.ProvanumTextBox.TabIndex = 19
        Me.ToolTip1.SetToolTip(Me.ProvanumTextBox, "Inserire il numero di giorni alla scadenza del periodo di prova")
        '
        'ProvadatDateTimePicker
        '
        Me.ProvadatDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.bsPreventiviDestinatari, "provadat", True))
        Me.ProvadatDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ProvadatDateTimePicker.Location = New System.Drawing.Point(286, 274)
        Me.ProvadatDateTimePicker.Name = "ProvadatDateTimePicker"
        Me.ProvadatDateTimePicker.Size = New System.Drawing.Size(95, 20)
        Me.ProvadatDateTimePicker.TabIndex = 20
        Me.ToolTip1.SetToolTip(Me.ProvadatDateTimePicker, "Inserire la data di termine del periodo di prova")
        '
        'tabPreventivi
        '
        Me.tabPreventivi.Controls.Add(Me.tbPreventivo)
        Me.tabPreventivi.Controls.Add(Me.tbCalcoli)
        Me.tabPreventivi.Controls.Add(Me.tbElencoOperazioni)
        Me.tabPreventivi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabPreventivi.Location = New System.Drawing.Point(0, 0)
        Me.tabPreventivi.Name = "tabPreventivi"
        Me.tabPreventivi.SelectedIndex = 0
        Me.tabPreventivi.Size = New System.Drawing.Size(1363, 841)
        Me.tabPreventivi.TabIndex = 194
        '
        'tbPreventivo
        '
        Me.tbPreventivo.Controls.Add(Me.TableLayoutPanel1)
        Me.tbPreventivo.Location = New System.Drawing.Point(4, 22)
        Me.tbPreventivo.Name = "tbPreventivo"
        Me.tbPreventivo.Padding = New System.Windows.Forms.Padding(3)
        Me.tbPreventivo.Size = New System.Drawing.Size(1355, 815)
        Me.tbPreventivo.TabIndex = 0
        Me.tbPreventivo.Text = "Operazioni"
        Me.tbPreventivo.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.pnlOperazioni, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.72405!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.27595!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1349, 809)
        Me.TableLayoutPanel1.TabIndex = 194
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 482.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 347.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.dgwDimensioni, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.dgwDestinatari, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1343, 428)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.btCreaCliente)
        Me.Panel1.Controls.Add(Me.btMemorizza)
        Me.Panel1.Controls.Add(Me.btDuplica)
        Me.Panel1.Controls.Add(IdLabel)
        Me.Panel1.Controls.Add(Me.IdTextBox)
        Me.Panel1.Controls.Add(SocietaLabel)
        Me.Panel1.Controls.Add(Me.SocietaTextBox)
        Me.Panel1.Controls.Add(IndirizzoLabel)
        Me.Panel1.Controls.Add(Me.IndirizzoTextBox)
        Me.Panel1.Controls.Add(CapLabel)
        Me.Panel1.Controls.Add(Me.CapTextBox)
        Me.Panel1.Controls.Add(Me.LocalitaTextBox)
        Me.Panel1.Controls.Add(Me.PrvTextBox)
        Me.Panel1.Controls.Add(TitLabel)
        Me.Panel1.Controls.Add(Me.TitTextBox)
        Me.Panel1.Controls.Add(Me.RespTextBox)
        Me.Panel1.Controls.Add(TelefonoLabel)
        Me.Panel1.Controls.Add(Me.TelefonoTextBox)
        Me.Panel1.Controls.Add(SicurezzaluoghiLabel)
        Me.Panel1.Controls.Add(Me.SicurezzaluoghiTextBox)
        Me.Panel1.Controls.Add(PrezzooranumLabel)
        Me.Panel1.Controls.Add(Me.PrezzooranumTextBox)
        Me.Panel1.Controls.Add(Me.PrezzooratxtTextBox)
        Me.Panel1.Controls.Add(CanonenumLabel)
        Me.Panel1.Controls.Add(Me.CanonenumTextBox)
        Me.Panel1.Controls.Add(Me.CanonetxtTextBox)
        Me.Panel1.Controls.Add(SicurezzanumLabel)
        Me.Panel1.Controls.Add(Me.SicurezzanumTextBox)
        Me.Panel1.Controls.Add(Me.SicurezzatxtTextBox)
        Me.Panel1.Controls.Add(Me.ProvanumTextBox)
        Me.Panel1.Controls.Add(Me.ProvadatDateTimePicker)
        Me.Panel1.Controls.Add(ScadenzaLabel)
        Me.Panel1.Controls.Add(Me.ScadenzaDateTimePicker)
        Me.Panel1.Controls.Add(NoteLabel)
        Me.Panel1.Controls.Add(Me.NoteTextBox)
        Me.Panel1.Controls.Add(RicontattiLabel)
        Me.Panel1.Controls.Add(Me.RicontattiTextBox)
        Me.Panel1.Controls.Add(R_telLabel)
        Me.Panel1.Controls.Add(Me.R_telTextBox)
        Me.Panel1.Controls.Add(R_mailLabel)
        Me.Panel1.Controls.Add(Me.R_mailTextBox)
        Me.Panel1.Controls.Add(CreatoilLabel)
        Me.Panel1.Controls.Add(Me.CreatoilDateTimePicker)
        Me.Panel1.Controls.Add(DecorrenzaLabel)
        Me.Panel1.Controls.Add(Me.DecorrenzaDateTimePicker)
        Me.Panel1.Controls.Add(P_ivaLabel)
        Me.Panel1.Controls.Add(Me.P_ivaTextBox)
        Me.Panel1.Controls.Add(C_fLabel)
        Me.Panel1.Controls.Add(Me.C_fTextBox)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(508, 422)
        Me.Panel1.TabIndex = 0
        '
        'btCreaCliente
        '
        Me.btCreaCliente.Location = New System.Drawing.Point(371, 384)
        Me.btCreaCliente.Name = "btCreaCliente"
        Me.btCreaCliente.Size = New System.Drawing.Size(116, 23)
        Me.btCreaCliente.TabIndex = 31
        Me.btCreaCliente.Text = "Genera Cliente"
        Me.btCreaCliente.UseVisualStyleBackColor = True
        '
        'btMemorizza
        '
        Me.btMemorizza.Location = New System.Drawing.Point(371, 341)
        Me.btMemorizza.Name = "btMemorizza"
        Me.btMemorizza.Size = New System.Drawing.Size(55, 23)
        Me.btMemorizza.TabIndex = 27
        Me.btMemorizza.Text = "Salva"
        Me.btMemorizza.UseVisualStyleBackColor = True
        '
        'btDuplica
        '
        Me.btDuplica.Location = New System.Drawing.Point(432, 341)
        Me.btDuplica.Name = "btDuplica"
        Me.btDuplica.Size = New System.Drawing.Size(55, 23)
        Me.btDuplica.TabIndex = 28
        Me.btDuplica.Text = "Duplica"
        Me.btDuplica.UseVisualStyleBackColor = True
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsPreventiviDestinatari, "id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(119, 17)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(95, 20)
        Me.IdTextBox.TabIndex = 1
        '
        'SocietaTextBox
        '
        Me.SocietaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsPreventiviDestinatari, "societa", True))
        Me.SocietaTextBox.Location = New System.Drawing.Point(119, 43)
        Me.SocietaTextBox.Name = "SocietaTextBox"
        Me.SocietaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SocietaTextBox.TabIndex = 3
        '
        'IndirizzoTextBox
        '
        Me.IndirizzoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsPreventiviDestinatari, "indirizzo", True))
        Me.IndirizzoTextBox.Location = New System.Drawing.Point(119, 69)
        Me.IndirizzoTextBox.Name = "IndirizzoTextBox"
        Me.IndirizzoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IndirizzoTextBox.TabIndex = 4
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsPreventiviDestinatari, "telefono", True))
        Me.TelefonoTextBox.Location = New System.Drawing.Point(119, 146)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TelefonoTextBox.TabIndex = 10
        '
        'SicurezzaluoghiTextBox
        '
        Me.SicurezzaluoghiTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsPreventiviDestinatari, "sicurezzaluoghi", True))
        Me.SicurezzaluoghiTextBox.Location = New System.Drawing.Point(119, 172)
        Me.SicurezzaluoghiTextBox.Name = "SicurezzaluoghiTextBox"
        Me.SicurezzaluoghiTextBox.Size = New System.Drawing.Size(342, 20)
        Me.SicurezzaluoghiTextBox.TabIndex = 11
        '
        'ScadenzaDateTimePicker
        '
        Me.ScadenzaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.bsPreventiviDestinatari, "scadenza", True))
        Me.ScadenzaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ScadenzaDateTimePicker.Location = New System.Drawing.Point(392, 274)
        Me.ScadenzaDateTimePicker.Name = "ScadenzaDateTimePicker"
        Me.ScadenzaDateTimePicker.Size = New System.Drawing.Size(95, 20)
        Me.ScadenzaDateTimePicker.TabIndex = 22
        '
        'NoteTextBox
        '
        Me.NoteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsPreventiviDestinatari, "note", True))
        Me.NoteTextBox.Location = New System.Drawing.Point(119, 296)
        Me.NoteTextBox.Name = "NoteTextBox"
        Me.NoteTextBox.Size = New System.Drawing.Size(342, 20)
        Me.NoteTextBox.TabIndex = 23
        '
        'RicontattiTextBox
        '
        Me.RicontattiTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsPreventiviDestinatari, "ricontatti", True))
        Me.RicontattiTextBox.Location = New System.Drawing.Point(119, 341)
        Me.RicontattiTextBox.Name = "RicontattiTextBox"
        Me.RicontattiTextBox.Size = New System.Drawing.Size(200, 20)
        Me.RicontattiTextBox.TabIndex = 26
        '
        'R_telTextBox
        '
        Me.R_telTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsPreventiviDestinatari, "r_tel", True))
        Me.R_telTextBox.Location = New System.Drawing.Point(119, 364)
        Me.R_telTextBox.Name = "R_telTextBox"
        Me.R_telTextBox.Size = New System.Drawing.Size(200, 20)
        Me.R_telTextBox.TabIndex = 29
        '
        'R_mailTextBox
        '
        Me.R_mailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsPreventiviDestinatari, "r_mail", True))
        Me.R_mailTextBox.Location = New System.Drawing.Point(119, 387)
        Me.R_mailTextBox.Name = "R_mailTextBox"
        Me.R_mailTextBox.Size = New System.Drawing.Size(200, 20)
        Me.R_mailTextBox.TabIndex = 30
        '
        'CreatoilDateTimePicker
        '
        Me.CreatoilDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.bsPreventiviDestinatari, "creatoil", True))
        Me.CreatoilDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.CreatoilDateTimePicker.Location = New System.Drawing.Point(275, 17)
        Me.CreatoilDateTimePicker.Name = "CreatoilDateTimePicker"
        Me.CreatoilDateTimePicker.Size = New System.Drawing.Size(101, 20)
        Me.CreatoilDateTimePicker.TabIndex = 2
        '
        'DecorrenzaDateTimePicker
        '
        Me.DecorrenzaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.bsPreventiviDestinatari, "decorrenza", True))
        Me.DecorrenzaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DecorrenzaDateTimePicker.Location = New System.Drawing.Point(119, 274)
        Me.DecorrenzaDateTimePicker.Name = "DecorrenzaDateTimePicker"
        Me.DecorrenzaDateTimePicker.Size = New System.Drawing.Size(95, 20)
        Me.DecorrenzaDateTimePicker.TabIndex = 18
        '
        'P_ivaTextBox
        '
        Me.P_ivaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsPreventiviDestinatari, "p_iva", True))
        Me.P_ivaTextBox.Location = New System.Drawing.Point(119, 318)
        Me.P_ivaTextBox.Name = "P_ivaTextBox"
        Me.P_ivaTextBox.Size = New System.Drawing.Size(103, 20)
        Me.P_ivaTextBox.TabIndex = 24
        '
        'C_fTextBox
        '
        Me.C_fTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsPreventiviDestinatari, "c_f", True))
        Me.C_fTextBox.Location = New System.Drawing.Point(259, 318)
        Me.C_fTextBox.Name = "C_fTextBox"
        Me.C_fTextBox.Size = New System.Drawing.Size(122, 20)
        Me.C_fTextBox.TabIndex = 25
        '
        'dgwDimensioni
        '
        Me.dgwDimensioni.AutoGenerateColumns = False
        Me.dgwDimensioni.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgwDimensioni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwDimensioni.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn1, Me.IdpreventivoDataGridViewTextBoxColumn1, Me.DescrizioneDataGridViewTextBoxColumn1, Me.DimensioniDataGridViewTextBoxColumn1})
        Me.dgwDimensioni.DataSource = Me.relPreventiviDestinatariPreventiviDimensioni
        Me.dgwDimensioni.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgwDimensioni.Location = New System.Drawing.Point(999, 3)
        Me.dgwDimensioni.Name = "dgwDimensioni"
        Me.dgwDimensioni.Size = New System.Drawing.Size(341, 422)
        Me.dgwDimensioni.TabIndex = 2
        '
        'IdDataGridViewTextBoxColumn1
        '
        Me.IdDataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn1.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn1.Name = "IdDataGridViewTextBoxColumn1"
        Me.IdDataGridViewTextBoxColumn1.Visible = False
        '
        'IdpreventivoDataGridViewTextBoxColumn1
        '
        Me.IdpreventivoDataGridViewTextBoxColumn1.DataPropertyName = "id_preventivo"
        Me.IdpreventivoDataGridViewTextBoxColumn1.HeaderText = "id_preventivo"
        Me.IdpreventivoDataGridViewTextBoxColumn1.Name = "IdpreventivoDataGridViewTextBoxColumn1"
        Me.IdpreventivoDataGridViewTextBoxColumn1.Visible = False
        '
        'DescrizioneDataGridViewTextBoxColumn1
        '
        Me.DescrizioneDataGridViewTextBoxColumn1.DataPropertyName = "descrizione"
        Me.DescrizioneDataGridViewTextBoxColumn1.HeaderText = "descrizione"
        Me.DescrizioneDataGridViewTextBoxColumn1.Name = "DescrizioneDataGridViewTextBoxColumn1"
        '
        'DimensioniDataGridViewTextBoxColumn1
        '
        Me.DimensioniDataGridViewTextBoxColumn1.DataPropertyName = "dimensioni"
        Me.DimensioniDataGridViewTextBoxColumn1.FillWeight = 50.0!
        Me.DimensioniDataGridViewTextBoxColumn1.HeaderText = "dimensioni"
        Me.DimensioniDataGridViewTextBoxColumn1.Name = "DimensioniDataGridViewTextBoxColumn1"
        '
        'relPreventiviDestinatariPreventiviDimensioni
        '
        Me.relPreventiviDestinatariPreventiviDimensioni.DataMember = "dtPreventiviDestinatari_dtPreventiviDimensioni"
        Me.relPreventiviDestinatariPreventiviDimensioni.DataSource = Me.bsPreventiviDestinatari
        '
        'dgwDestinatari
        '
        Me.dgwDestinatari.AutoGenerateColumns = False
        Me.dgwDestinatari.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgwDestinatari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwDestinatari.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgwccreatoil, Me.dgwcSocietaDestinatario, Me.dgwcLocalita, Me.dgwcResp, Me.dgwctelefono})
        Me.dgwDestinatari.DataSource = Me.bsPreventiviDestinatari
        Me.dgwDestinatari.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgwDestinatari.Location = New System.Drawing.Point(517, 3)
        Me.dgwDestinatari.Name = "dgwDestinatari"
        Me.dgwDestinatari.ReadOnly = True
        Me.dgwDestinatari.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgwDestinatari.Size = New System.Drawing.Size(476, 422)
        Me.dgwDestinatari.TabIndex = 1
        '
        'dgwccreatoil
        '
        Me.dgwccreatoil.DataPropertyName = "creatoil"
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.dgwccreatoil.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgwccreatoil.FillWeight = 50.0!
        Me.dgwccreatoil.HeaderText = "Creato il"
        Me.dgwccreatoil.Name = "dgwccreatoil"
        Me.dgwccreatoil.ReadOnly = True
        '
        'dgwcSocietaDestinatario
        '
        Me.dgwcSocietaDestinatario.DataPropertyName = "societa"
        Me.dgwcSocietaDestinatario.HeaderText = "societa"
        Me.dgwcSocietaDestinatario.Name = "dgwcSocietaDestinatario"
        Me.dgwcSocietaDestinatario.ReadOnly = True
        '
        'dgwcLocalita
        '
        Me.dgwcLocalita.DataPropertyName = "localita"
        Me.dgwcLocalita.HeaderText = "localita"
        Me.dgwcLocalita.Name = "dgwcLocalita"
        Me.dgwcLocalita.ReadOnly = True
        Me.dgwcLocalita.Visible = False
        '
        'dgwcResp
        '
        Me.dgwcResp.DataPropertyName = "Resp"
        Me.dgwcResp.FillWeight = 60.0!
        Me.dgwcResp.HeaderText = "Responsabile"
        Me.dgwcResp.Name = "dgwcResp"
        Me.dgwcResp.ReadOnly = True
        Me.dgwcResp.Visible = False
        '
        'dgwctelefono
        '
        Me.dgwctelefono.DataPropertyName = "telefono"
        Me.dgwctelefono.FillWeight = 60.0!
        Me.dgwctelefono.HeaderText = "Telefono"
        Me.dgwctelefono.Name = "dgwctelefono"
        Me.dgwctelefono.ReadOnly = True
        '
        'pnlOperazioni
        '
        Me.pnlOperazioni.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlOperazioni.Controls.Add(Me.dgwPreventivi)
        Me.pnlOperazioni.Controls.Add(Me.lbClienteAbbinato)
        Me.pnlOperazioni.Controls.Add(Me.btEliminaAbbinamento)
        Me.pnlOperazioni.Controls.Add(Me.gbAbbinamentoCliente)
        Me.pnlOperazioni.Controls.Add(Me.btnPreventivisvuotaArray)
        Me.pnlOperazioni.Controls.Add(Me.btnPreventiviIncolla)
        Me.pnlOperazioni.Controls.Add(Me.btnPreventiviCopia)
        Me.pnlOperazioni.Location = New System.Drawing.Point(5, 437)
        Me.pnlOperazioni.Name = "pnlOperazioni"
        Me.pnlOperazioni.Size = New System.Drawing.Size(1341, 369)
        Me.pnlOperazioni.TabIndex = 1
        '
        'dgwPreventivi
        '
        Me.dgwPreventivi.AutoGenerateColumns = False
        Me.dgwPreventivi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgwPreventivi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwPreventivi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgwcCategoria, Me.dgwcid_dimensioni, Me.dgwcID_Operazioni, Me.dgwcOperazione, Me.dgwcFrequenza, Me.dgwcImpegnomq, Me.dgwcImpegnonumero, Me.dgwcTaratura, Me.dgwcFreq, Me.dgwcRisultato, Me.DataGridViewTextBoxColumn31, Me.DataGridViewTextBoxColumn32, Me.dgwcIDpreventivi, Me.dgwcSortPreventivi, Me.dgwcDestinatario, Me.dgwcDimensioni, Me.dgwcAttivo})
        Me.dgwPreventivi.DataSource = Me.bsRelPreventiviDestinatariPreventivi
        Me.dgwPreventivi.Location = New System.Drawing.Point(5, 5)
        Me.dgwPreventivi.Name = "dgwPreventivi"
        Me.dgwPreventivi.RowHeadersWidth = 21
        Me.dgwPreventivi.Size = New System.Drawing.Size(1132, 363)
        Me.dgwPreventivi.TabIndex = 15
        '
        'dgwcCategoria
        '
        Me.dgwcCategoria.DataPropertyName = "id_categoria"
        Me.dgwcCategoria.DataSource = Me.bsPreventiviCategorie
        Me.dgwcCategoria.DisplayMember = "descrizione"
        Me.dgwcCategoria.FillWeight = 30.0!
        Me.dgwcCategoria.HeaderText = "Categoria"
        Me.dgwcCategoria.Name = "dgwcCategoria"
        Me.dgwcCategoria.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgwcCategoria.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.dgwcCategoria.ValueMember = "id"
        '
        'bsPreventiviCategorie
        '
        Me.bsPreventiviCategorie.DataMember = "dtPreventiviCategorie"
        Me.bsPreventiviCategorie.DataSource = Me.DsPreventivi
        '
        'dgwcid_dimensioni
        '
        Me.dgwcid_dimensioni.DataPropertyName = "id_dimensioni"
        Me.dgwcid_dimensioni.DataSource = Me.relPreventiviDestinatariPreventiviDimensioni
        Me.dgwcid_dimensioni.DisplayMember = "descrizione"
        Me.dgwcid_dimensioni.FillWeight = 25.0!
        Me.dgwcid_dimensioni.HeaderText = "Dettaglio Dimensioni"
        Me.dgwcid_dimensioni.Name = "dgwcid_dimensioni"
        Me.dgwcid_dimensioni.ValueMember = "id"
        '
        'dgwcID_Operazioni
        '
        Me.dgwcID_Operazioni.DataPropertyName = "id_operazioni"
        Me.dgwcID_Operazioni.HeaderText = "id_destinatario"
        Me.dgwcID_Operazioni.Name = "dgwcID_Operazioni"
        Me.dgwcID_Operazioni.Visible = False
        '
        'dgwcOperazione
        '
        Me.dgwcOperazione.DataPropertyName = "operazione"
        Me.dgwcOperazione.FillWeight = 90.0!
        Me.dgwcOperazione.HeaderText = "Operazione"
        Me.dgwcOperazione.Name = "dgwcOperazione"
        Me.dgwcOperazione.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'dgwcFrequenza
        '
        Me.dgwcFrequenza.DataPropertyName = "id_frequenza"
        Me.dgwcFrequenza.DataSource = Me.bsPreventiviFrequenze
        Me.dgwcFrequenza.DisplayMember = "descrizione"
        Me.dgwcFrequenza.FillWeight = 25.0!
        Me.dgwcFrequenza.HeaderText = "Frequenza"
        Me.dgwcFrequenza.Name = "dgwcFrequenza"
        Me.dgwcFrequenza.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgwcFrequenza.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.dgwcFrequenza.ValueMember = "id"
        '
        'bsPreventiviFrequenze
        '
        Me.bsPreventiviFrequenze.DataMember = "dtPreventiviFrequenze"
        Me.bsPreventiviFrequenze.DataSource = Me.DsPreventivi
        '
        'dgwcImpegnomq
        '
        Me.dgwcImpegnomq.DataPropertyName = "impegnomq"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        Me.dgwcImpegnomq.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgwcImpegnomq.FillWeight = 15.0!
        Me.dgwcImpegnomq.HeaderText = "resa m²"
        Me.dgwcImpegnomq.Name = "dgwcImpegnomq"
        '
        'dgwcImpegnonumero
        '
        Me.dgwcImpegnonumero.DataPropertyName = "impegnonumero"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        Me.dgwcImpegnonumero.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgwcImpegnonumero.FillWeight = 15.0!
        Me.dgwcImpegnonumero.HeaderText = "resa n°"
        Me.dgwcImpegnonumero.Name = "dgwcImpegnonumero"
        '
        'dgwcTaratura
        '
        Me.dgwcTaratura.DataPropertyName = "taratura"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        Me.dgwcTaratura.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgwcTaratura.FillWeight = 10.0!
        Me.dgwcTaratura.HeaderText = "SC%"
        Me.dgwcTaratura.Name = "dgwcTaratura"
        '
        'dgwcFreq
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        Me.dgwcFreq.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgwcFreq.FillWeight = 10.0!
        Me.dgwcFreq.HeaderText = "Freq"
        Me.dgwcFreq.Name = "dgwcFreq"
        '
        'dgwcRisultato
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        Me.dgwcRisultato.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgwcRisultato.FillWeight = 10.0!
        Me.dgwcRisultato.HeaderText = "Ore"
        Me.dgwcRisultato.Name = "dgwcRisultato"
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "data"
        Me.DataGridViewTextBoxColumn31.FillWeight = 30.0!
        Me.DataGridViewTextBoxColumn31.HeaderText = "data"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        Me.DataGridViewTextBoxColumn31.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn31.Visible = False
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "note"
        DataGridViewCellStyle7.Format = "N2"
        Me.DataGridViewTextBoxColumn32.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn32.FillWeight = 25.0!
        Me.DataGridViewTextBoxColumn32.HeaderText = "note"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        '
        'dgwcIDpreventivi
        '
        Me.dgwcIDpreventivi.DataPropertyName = "id"
        Me.dgwcIDpreventivi.FillWeight = 20.0!
        Me.dgwcIDpreventivi.HeaderText = "id"
        Me.dgwcIDpreventivi.Name = "dgwcIDpreventivi"
        Me.dgwcIDpreventivi.Visible = False
        '
        'dgwcSortPreventivi
        '
        Me.dgwcSortPreventivi.DataPropertyName = "sort"
        Me.dgwcSortPreventivi.FillWeight = 5.0!
        Me.dgwcSortPreventivi.HeaderText = "O"
        Me.dgwcSortPreventivi.Name = "dgwcSortPreventivi"
        '
        'dgwcDestinatario
        '
        Me.dgwcDestinatario.DataPropertyName = "id_destinatario"
        Me.dgwcDestinatario.HeaderText = "id_destinatario"
        Me.dgwcDestinatario.Name = "dgwcDestinatario"
        Me.dgwcDestinatario.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgwcDestinatario.Visible = False
        '
        'dgwcDimensioni
        '
        Me.dgwcDimensioni.DataPropertyName = "dimensioni"
        Me.dgwcDimensioni.HeaderText = "dimensioni m²"
        Me.dgwcDimensioni.Name = "dgwcDimensioni"
        Me.dgwcDimensioni.Visible = False
        '
        'dgwcAttivo
        '
        Me.dgwcAttivo.DataPropertyName = "visibile"
        Me.dgwcAttivo.FalseValue = "0"
        Me.dgwcAttivo.FillWeight = 5.0!
        Me.dgwcAttivo.HeaderText = "A"
        Me.dgwcAttivo.Name = "dgwcAttivo"
        Me.dgwcAttivo.TrueValue = "1"
        '
        'lbClienteAbbinato
        '
        Me.lbClienteAbbinato.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbClienteAbbinato.FormattingEnabled = True
        Me.lbClienteAbbinato.Location = New System.Drawing.Point(1144, 101)
        Me.lbClienteAbbinato.Name = "lbClienteAbbinato"
        Me.lbClienteAbbinato.Size = New System.Drawing.Size(185, 69)
        Me.lbClienteAbbinato.TabIndex = 14
        '
        'btEliminaAbbinamento
        '
        Me.btEliminaAbbinamento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btEliminaAbbinamento.Location = New System.Drawing.Point(1141, 72)
        Me.btEliminaAbbinamento.Name = "btEliminaAbbinamento"
        Me.btEliminaAbbinamento.Size = New System.Drawing.Size(188, 23)
        Me.btEliminaAbbinamento.TabIndex = 13
        Me.btEliminaAbbinamento.Text = "Elimina Abbinamento"
        Me.btEliminaAbbinamento.UseVisualStyleBackColor = True
        Me.btEliminaAbbinamento.Visible = False
        '
        'gbAbbinamentoCliente
        '
        Me.gbAbbinamentoCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbAbbinamentoCliente.Controls.Add(Me.DataGridView2)
        Me.gbAbbinamentoCliente.Controls.Add(Me.DataGridView1)
        Me.gbAbbinamentoCliente.Controls.Add(Me.tbRicercaClienteabbinabile)
        Me.gbAbbinamentoCliente.Controls.Add(Me.btAbbinaPreventivo)
        Me.gbAbbinamentoCliente.Location = New System.Drawing.Point(1144, 175)
        Me.gbAbbinamentoCliente.Name = "gbAbbinamentoCliente"
        Me.gbAbbinamentoCliente.Size = New System.Drawing.Size(187, 196)
        Me.gbAbbinamentoCliente.TabIndex = 12
        Me.gbAbbinamentoCliente.TabStop = False
        Me.gbAbbinamentoCliente.Text = "A chi abbino il capitolato"
        Me.gbAbbinamentoCliente.Visible = False
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgwcLocazioneAbbinabile})
        Me.DataGridView2.DataSource = Me.relDettaglio
        Me.DataGridView2.Location = New System.Drawing.Point(6, 96)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.Size = New System.Drawing.Size(174, 65)
        Me.DataGridView2.TabIndex = 12
        '
        'relDettaglio
        '
        Me.relDettaglio.DataMember = "DT_cantieri_new_DT_locazione_new"
        Me.relDettaglio.DataSource = Me.bsCantieri
        '
        'bsCantieri
        '
        Me.bsCantieri.DataMember = "DT_cantieri_new"
        Me.bsCantieri.DataSource = Me.DS_clienti
        '
        'DS_clienti
        '
        Me.DS_clienti.DataSetName = "DS_clienti"
        Me.DS_clienti.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgwcSocietaAbbinabile})
        Me.DataGridView1.DataSource = Me.bsCantieri
        Me.DataGridView1.Location = New System.Drawing.Point(6, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(174, 73)
        Me.DataGridView1.TabIndex = 10
        '
        'dgwcSocietaAbbinabile
        '
        Me.dgwcSocietaAbbinabile.DataPropertyName = "societa"
        Me.dgwcSocietaAbbinabile.HeaderText = "societa"
        Me.dgwcSocietaAbbinabile.Name = "dgwcSocietaAbbinabile"
        Me.dgwcSocietaAbbinabile.ReadOnly = True
        '
        'tbRicercaClienteabbinabile
        '
        Me.tbRicercaClienteabbinabile.Location = New System.Drawing.Point(7, 165)
        Me.tbRicercaClienteabbinabile.Name = "tbRicercaClienteabbinabile"
        Me.tbRicercaClienteabbinabile.Size = New System.Drawing.Size(105, 20)
        Me.tbRicercaClienteabbinabile.TabIndex = 11
        '
        'btAbbinaPreventivo
        '
        Me.btAbbinaPreventivo.Location = New System.Drawing.Point(123, 167)
        Me.btAbbinaPreventivo.Name = "btAbbinaPreventivo"
        Me.btAbbinaPreventivo.Size = New System.Drawing.Size(57, 21)
        Me.btAbbinaPreventivo.TabIndex = 9
        Me.btAbbinaPreventivo.Text = "Abbina"
        Me.btAbbinaPreventivo.UseVisualStyleBackColor = True
        '
        'btnPreventivisvuotaArray
        '
        Me.btnPreventivisvuotaArray.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPreventivisvuotaArray.Enabled = False
        Me.btnPreventivisvuotaArray.Location = New System.Drawing.Point(1142, 47)
        Me.btnPreventivisvuotaArray.Name = "btnPreventivisvuotaArray"
        Me.btnPreventivisvuotaArray.Size = New System.Drawing.Size(102, 23)
        Me.btnPreventivisvuotaArray.TabIndex = 6
        Me.btnPreventivisvuotaArray.Text = "Svuota dati mem"
        Me.btnPreventivisvuotaArray.UseVisualStyleBackColor = True
        '
        'btnPreventiviIncolla
        '
        Me.btnPreventiviIncolla.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPreventiviIncolla.Enabled = False
        Me.btnPreventiviIncolla.Location = New System.Drawing.Point(1142, 25)
        Me.btnPreventiviIncolla.Name = "btnPreventiviIncolla"
        Me.btnPreventiviIncolla.Size = New System.Drawing.Size(102, 23)
        Me.btnPreventiviIncolla.TabIndex = 5
        Me.btnPreventiviIncolla.Text = "Incolla il capitolato"
        Me.btnPreventiviIncolla.UseVisualStyleBackColor = True
        '
        'btnPreventiviCopia
        '
        Me.btnPreventiviCopia.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPreventiviCopia.Location = New System.Drawing.Point(1142, 3)
        Me.btnPreventiviCopia.Name = "btnPreventiviCopia"
        Me.btnPreventiviCopia.Size = New System.Drawing.Size(102, 23)
        Me.btnPreventiviCopia.TabIndex = 4
        Me.btnPreventiviCopia.Text = "Copia il capitolato"
        Me.btnPreventiviCopia.UseVisualStyleBackColor = True
        '
        'tbCalcoli
        '
        Me.tbCalcoli.Controls.Add(Me.TableLayoutPanel3)
        Me.tbCalcoli.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.tbCalcoli.Location = New System.Drawing.Point(4, 22)
        Me.tbCalcoli.Name = "tbCalcoli"
        Me.tbCalcoli.Padding = New System.Windows.Forms.Padding(3)
        Me.tbCalcoli.Size = New System.Drawing.Size(1355, 815)
        Me.tbCalcoli.TabIndex = 1
        Me.tbCalcoli.Text = "Calcoli economici"
        Me.tbCalcoli.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.09153!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.90847!))
        Me.TableLayoutPanel3.Controls.Add(Me.chGraficoPreventivo, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel4, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1349, 809)
        Me.TableLayoutPanel3.TabIndex = 7
        '
        'chGraficoPreventivo
        '
        Me.chGraficoPreventivo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ChartArea1.Name = "ChartArea1"
        Me.chGraficoPreventivo.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chGraficoPreventivo.Legends.Add(Legend1)
        Me.chGraficoPreventivo.Location = New System.Drawing.Point(530, 3)
        Me.chGraficoPreventivo.Name = "chGraficoPreventivo"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.chGraficoPreventivo.Series.Add(Series1)
        Me.chGraficoPreventivo.Size = New System.Drawing.Size(816, 803)
        Me.chGraficoPreventivo.TabIndex = 1
        Me.chGraficoPreventivo.Text = "Chart1"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.dgwRisultato, 0, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.dgwElencoDimensioni, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Panel2, 0, 1)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 3
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.10468!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.89532!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 455.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(527, 809)
        Me.TableLayoutPanel4.TabIndex = 2
        '
        'dgwRisultato
        '
        Me.dgwRisultato.AllowUserToAddRows = False
        Me.dgwRisultato.AllowUserToDeleteRows = False
        Me.dgwRisultato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwRisultato.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgwRisultato.Location = New System.Drawing.Point(3, 356)
        Me.dgwRisultato.Name = "dgwRisultato"
        Me.dgwRisultato.ReadOnly = True
        Me.dgwRisultato.Size = New System.Drawing.Size(521, 450)
        Me.dgwRisultato.TabIndex = 6
        '
        'dgwElencoDimensioni
        '
        Me.dgwElencoDimensioni.AllowUserToAddRows = False
        Me.dgwElencoDimensioni.AllowUserToDeleteRows = False
        Me.dgwElencoDimensioni.AutoGenerateColumns = False
        Me.dgwElencoDimensioni.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgwElencoDimensioni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwElencoDimensioni.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DescrizioneDataGridViewTextBoxColumn, Me.DimensioniDataGridViewTextBoxColumn})
        Me.dgwElencoDimensioni.DataSource = Me.relPreventiviDestinatariPreventiviDimensioni
        Me.dgwElencoDimensioni.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgwElencoDimensioni.Location = New System.Drawing.Point(3, 3)
        Me.dgwElencoDimensioni.Name = "dgwElencoDimensioni"
        Me.dgwElencoDimensioni.ReadOnly = True
        Me.dgwElencoDimensioni.RowHeadersVisible = False
        Me.dgwElencoDimensioni.Size = New System.Drawing.Size(521, 256)
        Me.dgwElencoDimensioni.TabIndex = 0
        '
        'DescrizioneDataGridViewTextBoxColumn
        '
        Me.DescrizioneDataGridViewTextBoxColumn.DataPropertyName = "descrizione"
        Me.DescrizioneDataGridViewTextBoxColumn.HeaderText = "descrizione"
        Me.DescrizioneDataGridViewTextBoxColumn.Name = "DescrizioneDataGridViewTextBoxColumn"
        Me.DescrizioneDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DimensioniDataGridViewTextBoxColumn
        '
        Me.DimensioniDataGridViewTextBoxColumn.DataPropertyName = "dimensioni"
        Me.DimensioniDataGridViewTextBoxColumn.FillWeight = 50.0!
        Me.DimensioniDataGridViewTextBoxColumn.HeaderText = "dimensioni"
        Me.DimensioniDataGridViewTextBoxColumn.Name = "DimensioniDataGridViewTextBoxColumn"
        Me.DimensioniDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txSconto)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txCostoOrario)
        Me.Panel2.Controls.Add(Me.btAggiornaGrafico)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 262)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(527, 91)
        Me.Panel2.TabIndex = 7
        '
        'txSconto
        '
        Me.txSconto.Location = New System.Drawing.Point(229, 38)
        Me.txSconto.Name = "txSconto"
        Me.txSconto.Size = New System.Drawing.Size(84, 23)
        Me.txSconto.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(226, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Sconto"
        '
        'txCostoOrario
        '
        Me.txCostoOrario.Location = New System.Drawing.Point(138, 38)
        Me.txCostoOrario.Name = "txCostoOrario"
        Me.txCostoOrario.Size = New System.Drawing.Size(85, 23)
        Me.txCostoOrario.TabIndex = 4
        '
        'btAggiornaGrafico
        '
        Me.btAggiornaGrafico.Location = New System.Drawing.Point(34, 38)
        Me.btAggiornaGrafico.Name = "btAggiornaGrafico"
        Me.btAggiornaGrafico.Size = New System.Drawing.Size(75, 23)
        Me.btAggiornaGrafico.TabIndex = 2
        Me.btAggiornaGrafico.Text = "Grafico"
        Me.btAggiornaGrafico.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(135, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Costo Orario"
        '
        'tbElencoOperazioni
        '
        Me.tbElencoOperazioni.Controls.Add(Me.dgwOperazioni)
        Me.tbElencoOperazioni.Location = New System.Drawing.Point(4, 22)
        Me.tbElencoOperazioni.Name = "tbElencoOperazioni"
        Me.tbElencoOperazioni.Padding = New System.Windows.Forms.Padding(3)
        Me.tbElencoOperazioni.Size = New System.Drawing.Size(1355, 815)
        Me.tbElencoOperazioni.TabIndex = 2
        Me.tbElencoOperazioni.Text = "Elenco Operazioni"
        Me.tbElencoOperazioni.UseVisualStyleBackColor = True
        '
        'dgwOperazioni
        '
        Me.dgwOperazioni.AutoGenerateColumns = False
        Me.dgwOperazioni.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgwOperazioni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwOperazioni.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn39, Me.DataGridViewTextBoxColumn38, Me.DataGridViewTextBoxColumn34, Me.DataGridViewTextBoxColumn35, Me.DataGridViewTextBoxColumn36, Me.DataGridViewTextBoxColumn40, Me.DataGridViewTextBoxColumn37})
        Me.dgwOperazioni.DataSource = Me.bsPreventiviOperazioni
        Me.dgwOperazioni.Location = New System.Drawing.Point(8, 6)
        Me.dgwOperazioni.Name = "dgwOperazioni"
        Me.dgwOperazioni.Size = New System.Drawing.Size(927, 803)
        Me.dgwOperazioni.TabIndex = 0
        '
        'DataGridViewTextBoxColumn39
        '
        Me.DataGridViewTextBoxColumn39.DataPropertyName = "idcategoria"
        Me.DataGridViewTextBoxColumn39.DataSource = Me.bsPreventiviCategorie
        Me.DataGridViewTextBoxColumn39.DisplayMember = "descrizione"
        Me.DataGridViewTextBoxColumn39.FillWeight = 60.0!
        Me.DataGridViewTextBoxColumn39.HeaderText = "Categoria"
        Me.DataGridViewTextBoxColumn39.Name = "DataGridViewTextBoxColumn39"
        Me.DataGridViewTextBoxColumn39.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn39.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn39.ValueMember = "id"
        '
        'DataGridViewTextBoxColumn38
        '
        Me.DataGridViewTextBoxColumn38.DataPropertyName = "attivo"
        Me.DataGridViewTextBoxColumn38.FillWeight = 30.0!
        Me.DataGridViewTextBoxColumn38.HeaderText = "attivo"
        Me.DataGridViewTextBoxColumn38.Name = "DataGridViewTextBoxColumn38"
        Me.DataGridViewTextBoxColumn38.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn38.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn34.FillWeight = 20.0!
        Me.DataGridViewTextBoxColumn34.HeaderText = "id"
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.DataPropertyName = "descrizione"
        Me.DataGridViewTextBoxColumn35.FillWeight = 200.0!
        Me.DataGridViewTextBoxColumn35.HeaderText = "descrizione"
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        '
        'DataGridViewTextBoxColumn36
        '
        Me.DataGridViewTextBoxColumn36.DataPropertyName = "impegnometroquadro"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N2"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.DataGridViewTextBoxColumn36.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn36.FillWeight = 40.0!
        Me.DataGridViewTextBoxColumn36.HeaderText = "Resa/M²"
        Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
        '
        'DataGridViewTextBoxColumn40
        '
        Me.DataGridViewTextBoxColumn40.DataPropertyName = "impegnonumero"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "N2"
        Me.DataGridViewTextBoxColumn40.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn40.FillWeight = 40.0!
        Me.DataGridViewTextBoxColumn40.HeaderText = "Resa/N°"
        Me.DataGridViewTextBoxColumn40.Name = "DataGridViewTextBoxColumn40"
        '
        'DataGridViewTextBoxColumn37
        '
        Me.DataGridViewTextBoxColumn37.DataPropertyName = "data"
        Me.DataGridViewTextBoxColumn37.FillWeight = 50.0!
        Me.DataGridViewTextBoxColumn37.HeaderText = "data"
        Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
        '
        'bsPreventiviOperazioni
        '
        Me.bsPreventiviOperazioni.DataMember = "dtPreventiviOperazioni"
        Me.bsPreventiviOperazioni.DataSource = Me.DsPreventivi
        '
        'relPreventiviDimensionidtPreventivi
        '
        Me.relPreventiviDimensionidtPreventivi.DataMember = "dtPreventiviDimensioni_dtPreventivi"
        '
        'RelPreventiviAbbinamento
        '
        Me.RelPreventiviAbbinamento.DataMember = "dtPreventivi_dtPreventiviAbbinamento"
        Me.RelPreventiviAbbinamento.DataSource = Me.bsPreventivi
        '
        'bsPreventivi
        '
        Me.bsPreventivi.DataMember = "dtPreventivi"
        Me.bsPreventivi.DataSource = Me.DsPreventivi
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 40
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "societa"
        Me.DataGridViewTextBoxColumn2.HeaderText = "societa"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Visible = False
        Me.DataGridViewTextBoxColumn2.Width = 66
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "indirizzo"
        Me.DataGridViewTextBoxColumn3.HeaderText = "indirizzo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 69
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "cap"
        Me.DataGridViewTextBoxColumn4.FillWeight = 50.0!
        Me.DataGridViewTextBoxColumn4.HeaderText = "cap"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 50
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "localita"
        DataGridViewCellStyle10.Format = "d"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewTextBoxColumn5.FillWeight = 50.0!
        Me.DataGridViewTextBoxColumn5.HeaderText = "localita"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 65
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "prv"
        Me.DataGridViewTextBoxColumn6.HeaderText = "prv"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 47
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "tit"
        Me.DataGridViewTextBoxColumn7.HeaderText = "tit"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Visible = False
        Me.DataGridViewTextBoxColumn7.Width = 40
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Resp"
        Me.DataGridViewTextBoxColumn8.FillWeight = 60.0!
        Me.DataGridViewTextBoxColumn8.HeaderText = "Resp"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Visible = False
        Me.DataGridViewTextBoxColumn8.Width = 57
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "telefono"
        Me.DataGridViewTextBoxColumn9.FillWeight = 60.0!
        Me.DataGridViewTextBoxColumn9.HeaderText = "telefono"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 70
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "sicurezzaluoghi"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.Format = "N2"
        Me.DataGridViewTextBoxColumn10.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewTextBoxColumn10.FillWeight = 30.0!
        Me.DataGridViewTextBoxColumn10.HeaderText = "sicurezzaluoghi"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 104
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "prezzooranum"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle12.Format = "N2"
        Me.DataGridViewTextBoxColumn11.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewTextBoxColumn11.FillWeight = 30.0!
        Me.DataGridViewTextBoxColumn11.HeaderText = "prezzooranum"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 98
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "prezzooratxt"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle13.Format = "N2"
        Me.DataGridViewTextBoxColumn12.DefaultCellStyle = DataGridViewCellStyle13
        Me.DataGridViewTextBoxColumn12.FillWeight = 30.0!
        Me.DataGridViewTextBoxColumn12.HeaderText = "prezzooratxt"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 89
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "canonenum"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle14.Format = "N2"
        Me.DataGridViewTextBoxColumn13.DefaultCellStyle = DataGridViewCellStyle14
        Me.DataGridViewTextBoxColumn13.FillWeight = 30.0!
        Me.DataGridViewTextBoxColumn13.HeaderText = "canonenum"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Width = 88
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "canonetxt"
        Me.DataGridViewTextBoxColumn14.FillWeight = 30.0!
        Me.DataGridViewTextBoxColumn14.HeaderText = "canonetxt"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn14.Visible = False
        Me.DataGridViewTextBoxColumn14.Width = 79
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "sicurezzanum"
        DataGridViewCellStyle15.Format = "N2"
        Me.DataGridViewTextBoxColumn15.DefaultCellStyle = DataGridViewCellStyle15
        Me.DataGridViewTextBoxColumn15.FillWeight = 30.0!
        Me.DataGridViewTextBoxColumn15.HeaderText = "sicurezzanum"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn15.Width = 96
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "sicurezzatxt"
        DataGridViewCellStyle16.Format = "N2"
        Me.DataGridViewTextBoxColumn16.DefaultCellStyle = DataGridViewCellStyle16
        Me.DataGridViewTextBoxColumn16.FillWeight = 60.0!
        Me.DataGridViewTextBoxColumn16.HeaderText = "sicurezzatxt"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.Width = 87
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "provanum"
        Me.DataGridViewTextBoxColumn17.FillWeight = 20.0!
        Me.DataGridViewTextBoxColumn17.HeaderText = "provanum"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.Visible = False
        Me.DataGridViewTextBoxColumn17.Width = 79
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "provadat"
        Me.DataGridViewTextBoxColumn18.FillWeight = 20.0!
        Me.DataGridViewTextBoxColumn18.HeaderText = "provadat"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.Width = 74
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "scadenza"
        Me.DataGridViewTextBoxColumn19.HeaderText = "scadenza"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn19.Visible = False
        Me.DataGridViewTextBoxColumn19.Width = 78
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "note"
        Me.DataGridViewTextBoxColumn20.HeaderText = "note"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.Visible = False
        Me.DataGridViewTextBoxColumn20.Width = 53
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "ricontatti"
        Me.DataGridViewTextBoxColumn21.HeaderText = "ricontatti"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.Visible = False
        Me.DataGridViewTextBoxColumn21.Width = 72
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "r_tel"
        Me.DataGridViewTextBoxColumn22.HeaderText = "r_tel"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.Width = 52
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "r_mail"
        Me.DataGridViewTextBoxColumn23.FillWeight = 50.0!
        Me.DataGridViewTextBoxColumn23.HeaderText = "r_mail"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.Width = 59
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "creatoil"
        Me.DataGridViewTextBoxColumn24.FillWeight = 20.0!
        Me.DataGridViewTextBoxColumn24.HeaderText = "creatoil"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.Width = 66
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "decorrenza"
        Me.DataGridViewTextBoxColumn25.FillWeight = 200.0!
        Me.DataGridViewTextBoxColumn25.HeaderText = "decorrenza"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.Width = 85
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "p_iva"
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle17.Format = "N2"
        DataGridViewCellStyle17.NullValue = Nothing
        Me.DataGridViewTextBoxColumn26.DefaultCellStyle = DataGridViewCellStyle17
        Me.DataGridViewTextBoxColumn26.FillWeight = 40.0!
        Me.DataGridViewTextBoxColumn26.HeaderText = "p_iva"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.Width = 58
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "c_f"
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle18.Format = "N2"
        Me.DataGridViewTextBoxColumn27.DefaultCellStyle = DataGridViewCellStyle18
        Me.DataGridViewTextBoxColumn27.FillWeight = 40.0!
        Me.DataGridViewTextBoxColumn27.HeaderText = "c_f"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.Width = 47
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn28.FillWeight = 20.0!
        Me.DataGridViewTextBoxColumn28.HeaderText = "id"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn28.Visible = False
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "data"
        DataGridViewCellStyle19.Format = "N2"
        Me.DataGridViewTextBoxColumn29.DefaultCellStyle = DataGridViewCellStyle19
        Me.DataGridViewTextBoxColumn29.FillWeight = 30.0!
        Me.DataGridViewTextBoxColumn29.HeaderText = "data"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        Me.DataGridViewTextBoxColumn29.Visible = False
        Me.DataGridViewTextBoxColumn29.Width = 107
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "id"
        DataGridViewCellStyle20.Format = "N2"
        Me.DataGridViewTextBoxColumn30.DefaultCellStyle = DataGridViewCellStyle20
        Me.DataGridViewTextBoxColumn30.FillWeight = 20.0!
        Me.DataGridViewTextBoxColumn30.HeaderText = "O"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        Me.DataGridViewTextBoxColumn30.Width = 32
        '
        'TA_cantieri_new
        '
        Me.TA_cantieri_new.ClearBeforeFill = True
        '
        'TA_locazione_new
        '
        Me.TA_locazione_new.ClearBeforeFill = True
        '
        'bsPreventiviabbinamento
        '
        Me.bsPreventiviabbinamento.DataMember = "dtPreventiviAbbinamento"
        Me.bsPreventiviabbinamento.DataSource = Me.DsPreventivi
        '
        'TaPreventiviDestinatari
        '
        Me.TaPreventiviDestinatari.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = PoP2.Comuni.DSPreventiviTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TaPreventivi
        '
        Me.TaPreventivi.ClearBeforeFill = True
        '
        'TaPreventiviOperazioni
        '
        Me.TaPreventiviOperazioni.ClearBeforeFill = True
        '
        'TaPreventiviFrequenze
        '
        Me.TaPreventiviFrequenze.ClearBeforeFill = True
        '
        'TaPreventiviCategorie
        '
        Me.TaPreventiviCategorie.ClearBeforeFill = True
        '
        'TaPreventiviDimensioni
        '
        Me.TaPreventiviDimensioni.ClearBeforeFill = True
        '
        'bsPreventiviDimensioni
        '
        Me.bsPreventiviDimensioni.DataMember = "dtPreventiviDimensioni"
        Me.bsPreventiviDimensioni.DataSource = Me.DsPreventivi
        '
        'TaPreventiviAbbinamento
        '
        Me.TaPreventiviAbbinamento.ClearBeforeFill = True
        '
        'dgwcLocazioneAbbinabile
        '
        Me.dgwcLocazioneAbbinabile.DataPropertyName = "locazione"
        Me.dgwcLocazioneAbbinabile.HeaderText = "Dettaglio"
        Me.dgwcLocazioneAbbinabile.Name = "dgwcLocazioneAbbinabile"
        Me.dgwcLocazioneAbbinabile.ReadOnly = True
        '
        'FrmPreventivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1363, 941)
        Me.Controls.Add(Me.tabPreventivi)
        Me.Controls.Add(Me.DM_barra)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmPreventivo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Proposte di contratto"
        CType(Me.bsRelPreventiviDestinatariPreventivi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsPreventiviDestinatari, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPreventivi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DM_barra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DM_barra.ResumeLayout(False)
        Me.DM_barra.PerformLayout()
        Me.tabPreventivi.ResumeLayout(False)
        Me.tbPreventivo.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgwDimensioni, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.relPreventiviDestinatariPreventiviDimensioni, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgwDestinatari, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlOperazioni.ResumeLayout(False)
        CType(Me.dgwPreventivi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsPreventiviCategorie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsPreventiviFrequenze, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbAbbinamentoCliente.ResumeLayout(False)
        Me.gbAbbinamentoCliente.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.relDettaglio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCantieri, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_clienti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbCalcoli.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.chGraficoPreventivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel4.ResumeLayout(False)
        CType(Me.dgwRisultato, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgwElencoDimensioni, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.tbElencoOperazioni.ResumeLayout(False)
        CType(Me.dgwOperazioni, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsPreventiviOperazioni, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.relPreventiviDimensionidtPreventivi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RelPreventiviAbbinamento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsPreventivi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsPreventiviabbinamento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsPreventiviDimensioni, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DsPreventivi As dsPreventivi
    Friend WithEvents bsPreventiviDestinatari As BindingSource
    Friend WithEvents TaPreventiviDestinatari As dsPreventiviTableAdapters.taPreventiviDestinatari
    Friend WithEvents TableAdapterManager As dsPreventiviTableAdapters.TableAdapterManager
    Friend WithEvents bsPreventivi As BindingSource
    Friend WithEvents TaPreventivi As dsPreventiviTableAdapters.taPreventivi
    Friend WithEvents DM_barra As BindingNavigator
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents TTBTElimina As ToolStripButton
    Friend WithEvents TTTestoRicerca As ToolStripTextBox
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents TTBTAggiunge As ToolStripButton
    Friend WithEvents TTBTRicarica As ToolStripButton
    Friend WithEvents TTBTTermina As ToolStripButton
    Friend WithEvents bsPreventiviOperazioni As BindingSource
    Friend WithEvents TaPreventiviOperazioni As dsPreventiviTableAdapters.taPreventiviOperazioni
    Friend WithEvents bsPreventiviFrequenze As BindingSource
    Friend WithEvents TaPreventiviFrequenze As dsPreventiviTableAdapters.taPreventiviFrequenze
    Friend WithEvents bsRelPreventiviDestinatariPreventivi As BindingSource
    Friend WithEvents TaPreventiviCategorie As dsPreventiviTableAdapters.taPreventiviCategorie
    Friend WithEvents tsbOperazioni As ToolStripButton
    Friend WithEvents bsPreventiviCategorie As BindingSource
    Friend WithEvents TTBTStampa As ToolStripButton
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
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As DataGridViewTextBoxColumn
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents tabPreventivi As TabControl
    Friend WithEvents tbPreventivo As TabPage
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents dgwDestinatari As DataGridView
    Friend WithEvents tbCalcoli As TabPage
    Friend WithEvents TaPreventiviDimensioni As dsPreventiviTableAdapters.taPreventiviDimensioni
    Friend WithEvents relPreventiviDimensionidtPreventivi As BindingSource
    Friend WithEvents RelPreventiviAbbinamento As BindingSource
    Friend WithEvents dgwDimensioni As DataGridView
    Friend WithEvents relPreventiviDestinatariPreventiviDimensioni As BindingSource
    Friend WithEvents bsPreventiviDimensioni As BindingSource
    Friend WithEvents IdDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents IdpreventivoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DescrizioneDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DimensioniDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents chGraficoPreventivo As DataVisualization.Charting.Chart
    Friend WithEvents dgwElencoDimensioni As DataGridView
    Friend WithEvents DescrizioneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DimensioniDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btAggiornaGrafico As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txCostoOrario As TextBox
    Friend WithEvents dgwccreatoil As DataGridViewTextBoxColumn
    Friend WithEvents dgwcSocietaDestinatario As DataGridViewTextBoxColumn
    Friend WithEvents dgwcLocalita As DataGridViewTextBoxColumn
    Friend WithEvents dgwcResp As DataGridViewTextBoxColumn
    Friend WithEvents dgwctelefono As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents SocietaTextBox As TextBox
    Friend WithEvents IndirizzoTextBox As TextBox
    Friend WithEvents CapTextBox As TextBox
    Friend WithEvents LocalitaTextBox As TextBox
    Friend WithEvents PrvTextBox As TextBox
    Friend WithEvents TitTextBox As TextBox
    Friend WithEvents RespTextBox As TextBox
    Friend WithEvents TelefonoTextBox As TextBox
    Friend WithEvents SicurezzaluoghiTextBox As TextBox
    Friend WithEvents PrezzooranumTextBox As TextBox
    Friend WithEvents PrezzooratxtTextBox As TextBox
    Friend WithEvents CanonenumTextBox As TextBox
    Friend WithEvents CanonetxtTextBox As TextBox
    Friend WithEvents SicurezzanumTextBox As TextBox
    Friend WithEvents SicurezzatxtTextBox As TextBox
    Friend WithEvents ProvanumTextBox As TextBox
    Friend WithEvents ProvadatDateTimePicker As DateTimePicker
    Friend WithEvents ScadenzaDateTimePicker As DateTimePicker
    Friend WithEvents NoteTextBox As TextBox
    Friend WithEvents RicontattiTextBox As TextBox
    Friend WithEvents R_telTextBox As TextBox
    Friend WithEvents R_mailTextBox As TextBox
    Friend WithEvents CreatoilDateTimePicker As DateTimePicker
    Friend WithEvents DecorrenzaDateTimePicker As DateTimePicker
    Friend WithEvents P_ivaTextBox As TextBox
    Friend WithEvents C_fTextBox As TextBox
    Friend WithEvents btMemorizza As Button
    Friend WithEvents btDuplica As Button
    Friend WithEvents dgwRisultato As DataGridView
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents tbElencoOperazioni As TabPage
    Friend WithEvents dgwOperazioni As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn34 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn35 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn39 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn36 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn40 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn38 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn37 As DataGridViewTextBoxColumn
    Friend WithEvents txSconto As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dgwcPrezzo As DataGridViewTextBoxColumn
    Friend WithEvents pnlOperazioni As Panel
    Friend WithEvents btnPreventivisvuotaArray As Button
    Friend WithEvents btnPreventiviIncolla As Button
    Friend WithEvents btnPreventiviCopia As Button
    Friend WithEvents bsPreventiviabbinamento As BindingSource
    Friend WithEvents TaPreventiviAbbinamento As dsPreventiviTableAdapters.taPreventiviAbbinamento
    Friend WithEvents btAbbinaPreventivo As Button
    Friend WithEvents bsCantieri As BindingSource
    Friend WithEvents DS_clienti As DS_clienti
    Friend WithEvents TA_cantieri_new As DS_clientiTableAdapters.TA_cantieri_new
    Friend WithEvents tbRicercaClienteabbinabile As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents dgwcSocietaAbbinabile As DataGridViewTextBoxColumn
    Friend WithEvents gbAbbinamentoCliente As GroupBox
    Friend WithEvents btEliminaAbbinamento As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents relDettaglio As BindingSource
    Friend WithEvents TA_locazione_new As DS_clientiTableAdapters.TA_locazione_new
    Friend WithEvents lbClienteAbbinato As ListBox
    Friend WithEvents dgwPreventivi As DataGridView
    Friend WithEvents dgwcCategoria As DataGridViewComboBoxColumn
    Friend WithEvents dgwcid_dimensioni As DataGridViewComboBoxColumn
    Friend WithEvents dgwcID_Operazioni As DataGridViewTextBoxColumn
    Friend WithEvents dgwcOperazione As DataGridViewTextBoxColumn
    Friend WithEvents dgwcFrequenza As DataGridViewComboBoxColumn
    Friend WithEvents dgwcImpegnomq As DataGridViewTextBoxColumn
    Friend WithEvents dgwcImpegnonumero As DataGridViewTextBoxColumn
    Friend WithEvents dgwcTaratura As DataGridViewTextBoxColumn
    Friend WithEvents dgwcFreq As DataGridViewTextBoxColumn
    Friend WithEvents dgwcRisultato As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As DataGridViewTextBoxColumn
    Friend WithEvents dgwcIDpreventivi As DataGridViewTextBoxColumn
    Friend WithEvents dgwcSortPreventivi As DataGridViewTextBoxColumn
    Friend WithEvents dgwcDestinatario As DataGridViewTextBoxColumn
    Friend WithEvents dgwcDimensioni As DataGridViewTextBoxColumn
    Friend WithEvents dgwcAttivo As DataGridViewCheckBoxColumn
    Friend WithEvents btCreaCliente As Button
    Friend WithEvents dgwcLocazioneAbbinabile As DataGridViewTextBoxColumn
End Class
