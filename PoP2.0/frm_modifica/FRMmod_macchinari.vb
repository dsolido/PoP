Public Class FRMmod_macchinari
    Dim RG As DataRow
    Dim DT As DataTable
    Friend WithEvents CBfornitore As ComboBox
    Friend WithEvents CBmarca As ComboBox

    Public Sub New(ByRef OT As DataTable)



        InitializeComponent()
        'RG = BS 'RG equicale alla riga del macchinario passata dal Parent
        DT = OT 'DT è il Datatable contenete tutte le informazioni dei macchinari passate dal Parent
        'CBfornitore

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().

    End Sub
    Private Sub FRMmod_macchinari_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.TA_fornitori.Fill(Me.DS_prodotti.DT_fornitori)
        Me.TA_prodottimarche.Fill(Me.DS_prodotti.DT_prodottimarche)
        BSmacchine.DataMember = DT.TableName
        BSmacchine.DataSource = DT
        FRMmodcaricaCombo()
    End Sub
    Private Sub FRMmodcaricaCombo()
        'Carica e abbina i Controlli Combo con i dati passati dal Form Parent

        Me.CBfornitore = New System.Windows.Forms.ComboBox()
        Me.CBfornitore.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BSmacchine, "idforn", True))
        Me.CBfornitore.DataSource = Me.BSfornitori
        Me.CBfornitore.DisplayMember = "anagrafica"
        Me.CBfornitore.FormattingEnabled = True
        Me.CBfornitore.Location = New System.Drawing.Point(153, 113)
        Me.CBfornitore.Name = "CBfornitore"
        Me.CBfornitore.Size = New System.Drawing.Size(300, 28)
        Me.CBfornitore.TabIndex = 27
        Me.CBfornitore.ValueMember = "id"
        Me.Controls.Add(Me.CBfornitore)

        Me.CBmarca = New System.Windows.Forms.ComboBox()
        Me.CBmarca.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BSmacchine, "idmarca", True))
        Me.CBmarca.DataSource = Me.BSmarche
        Me.CBmarca.DisplayMember = "Azienda"
        Me.CBmarca.FormattingEnabled = True
        Me.CBmarca.Location = New System.Drawing.Point(159, 159)
        Me.CBmarca.Name = "CBmarca"
        Me.CBmarca.Size = New System.Drawing.Size(300, 28)
        Me.CBmarca.TabIndex = 28
        Me.CBmarca.ValueMember = "id"
        Me.Controls.Add(Me.CBmarca)
    End Sub

    Private Sub TTBTTermina_Click(sender As Object, e As EventArgs) Handles TTBTTermina.Click
        BSmacchine.CancelEdit()
        Me.Close()
    End Sub

    Private Sub TTBTSalva_Click(sender As Object, e As EventArgs) Handles TTBTSalva.Click
        MemorizzainformazioniMAcchine()
    End Sub
    Private Sub MemorizzainformazioniMAcchine()
        BSmacchine.EndEdit()
        Dim RG As DSmacchinari.DTmacchineRow
        RG = DirectCast(BSmacchine.Current, DataRowView).Row
        Select Case RG.RowState
            Case DataRowState.Added
                RG.revisione = If(RG.IsrevisioneNull, Now, RG.revisione)
                RG.batterie = If(RG.IsbatterieNull, Now, RG.batterie)
                RG.dtacquisto = If(RG.IsdtacquistoNull, Now, RG.dtacquisto)
                Using TA As New DSmacchinariTableAdapters.TAmacchine
                    TA.inserisce(RG.descrizione, RG.idforn, RG.idmarca, RG.dtacquisto, RG.prezzo, RG.nu, Now, Now, RG.note)
                End Using
            Case DataRowState.Modified
                RG.revisione = If(RG.IsrevisioneNull, Now, RG.revisione)
                RG.batterie = If(RG.IsbatterieNull, Now, RG.batterie)
                RG.dtacquisto = If(RG.IsdtacquistoNull, Now, RG.dtacquisto)
                Using TA As New DSmacchinariTableAdapters.TAmacchine
                    TA.modifica(RG.descrizione, RG.idforn, RG.idmarca, RG.dtacquisto, RG.prezzo, RG.nu, RG.revisione, RG.batterie, RG.note, RG.id)
                End Using
        End Select

        RG.AcceptChanges()
    End Sub

End Class