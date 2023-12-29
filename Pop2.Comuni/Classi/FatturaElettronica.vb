Public Class FatturaE

    ' NOTA: con il codice generato potrebbe essere richiesto almeno .NET Framework 4.5 o .NET Core/Standard 2.0.
    '''<remarks/>
    <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True, [Namespace]:="http://ivaservizi.agenziaentrate.gov.it/docs/xsd/fatture/v1.2"),
 System.Xml.Serialization.XmlRootAttribute([Namespace]:="http://ivaservizi.agenziaentrate.gov.it/docs/xsd/fatture/v1.2", IsNullable:=False)>
    Partial Public Class FatturaElettronica

        Private fatturaElettronicaHeaderField As FatturaElettronicaHeader

        Private fatturaElettronicaBodyField As FatturaElettronicaBody

        Private textField() As String

        Private versioneField As String

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute([Namespace]:="")>
        Public Property FatturaElettronicaHeader() As FatturaElettronicaHeader
            Get
                Return Me.fatturaElettronicaHeaderField
            End Get
            Set
                Me.fatturaElettronicaHeaderField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute([Namespace]:="")>
        Public Property FatturaElettronicaBody() As FatturaElettronicaBody
            Get
                Return Me.fatturaElettronicaBodyField
            End Get
            Set
                Me.fatturaElettronicaBodyField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlTextAttribute()>
        Public Property Text() As String()
            Get
                Return Me.textField
            End Get
            Set
                Me.textField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property versione() As String
            Get
                Return Me.versioneField
            End Get
            Set
                Me.versioneField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
 System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Partial Public Class FatturaElettronicaHeader

        Private datiTrasmissioneField As FatturaElettronicaHeaderDatiTrasmissione

        Private cedentePrestatoreField As FatturaElettronicaHeaderCedentePrestatore

        Private cessionarioCommittenteField As FatturaElettronicaHeaderCessionarioCommittente

        Private soggettoEmittenteField As String

        Private textField() As String

        '''<remarks/>
        Public Property DatiTrasmissione() As FatturaElettronicaHeaderDatiTrasmissione
            Get
                Return Me.datiTrasmissioneField
            End Get
            Set
                Me.datiTrasmissioneField = Value
            End Set
        End Property

        '''<remarks/>
        Public Property CedentePrestatore() As FatturaElettronicaHeaderCedentePrestatore
            Get
                Return Me.cedentePrestatoreField
            End Get
            Set
                Me.cedentePrestatoreField = Value
            End Set
        End Property

        '''<remarks/>
        Public Property CessionarioCommittente() As FatturaElettronicaHeaderCessionarioCommittente
            Get
                Return Me.cessionarioCommittenteField
            End Get
            Set
                Me.cessionarioCommittenteField = Value
            End Set
        End Property

        '''<remarks/>
        Public Property SoggettoEmittente() As String
            Get
                Return Me.soggettoEmittenteField
            End Get
            Set
                Me.soggettoEmittenteField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlTextAttribute()>
        Public Property Text() As String()
            Get
                Return Me.textField
            End Get
            Set
                Me.textField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Partial Public Class FatturaElettronicaHeaderDatiTrasmissione

        Private idTrasmittenteField As FatturaElettronicaHeaderDatiTrasmissioneIdTrasmittente

        Private progressivoInvioField As UShort

        Private formatoTrasmissioneField As String

        Private codiceDestinatarioField As String

        Private contattiTrasmittenteField As FatturaElettronicaHeaderDatiTrasmissioneContattiTrasmittente

        Private textField() As String

        '''<remarks/>
        Public Property IdTrasmittente() As FatturaElettronicaHeaderDatiTrasmissioneIdTrasmittente
            Get
                Return Me.idTrasmittenteField
            End Get
            Set
                Me.idTrasmittenteField = Value
            End Set
        End Property

        '''<remarks/>
        Public Property ProgressivoInvio() As UShort
            Get
                Return Me.progressivoInvioField
            End Get
            Set
                Me.progressivoInvioField = Value
            End Set
        End Property

        '''<remarks/>
        Public Property FormatoTrasmissione() As String
            Get
                Return Me.formatoTrasmissioneField
            End Get
            Set
                Me.formatoTrasmissioneField = Value
            End Set
        End Property

        '''<remarks/>
        Public Property CodiceDestinatario() As String
            Get
                Return Me.codiceDestinatarioField
            End Get
            Set
                Me.codiceDestinatarioField = Value
            End Set
        End Property

        '''<remarks/>
        Public Property ContattiTrasmittente() As FatturaElettronicaHeaderDatiTrasmissioneContattiTrasmittente
            Get
                Return Me.contattiTrasmittenteField
            End Get
            Set
                Me.contattiTrasmittenteField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlTextAttribute()>
        Public Property Text() As String()
            Get
                Return Me.textField
            End Get
            Set
                Me.textField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Partial Public Class FatturaElettronicaHeaderDatiTrasmissioneIdTrasmittente

        Private idPaeseField As String

        Private idCodiceField As UInteger

        '''<remarks/>
        Public Property IdPaese() As String
            Get
                Return Me.idPaeseField
            End Get
            Set
                Me.idPaeseField = Value
            End Set
        End Property

        '''<remarks/>
        Public Property IdCodice() As UInteger
            Get
                Return Me.idCodiceField
            End Get
            Set
                Me.idCodiceField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Partial Public Class FatturaElettronicaHeaderDatiTrasmissioneContattiTrasmittente

        Private telefonoField As String

        Private emailField As String

        '''<remarks/>
        Public Property Telefono() As String
            Get
                Return Me.telefonoField
            End Get
            Set
                Me.telefonoField = Value
            End Set
        End Property

        '''<remarks/>
        Public Property Email() As String
            Get
                Return Me.emailField
            End Get
            Set
                Me.emailField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Partial Public Class FatturaElettronicaHeaderCedentePrestatore

        Private datiAnagraficiField As FatturaElettronicaHeaderCedentePrestatoreDatiAnagrafici

        Private sedeField As FatturaElettronicaHeaderCedentePrestatoreSede

        Private stabileOrganizzazioneField As FatturaElettronicaHeaderCedentePrestatoreStabileOrganizzazione

        Private iscrizioneREAField As FatturaElettronicaHeaderCedentePrestatoreIscrizioneREA

        Private textField() As String

        '''<remarks/>
        Public Property DatiAnagrafici() As FatturaElettronicaHeaderCedentePrestatoreDatiAnagrafici
            Get
                Return Me.datiAnagraficiField
            End Get
            Set
                Me.datiAnagraficiField = Value
            End Set
        End Property

        '''<remarks/>
        Public Property Sede() As FatturaElettronicaHeaderCedentePrestatoreSede
            Get
                Return Me.sedeField
            End Get
            Set
                Me.sedeField = Value
            End Set
        End Property

        '''<remarks/>
        Public Property StabileOrganizzazione() As FatturaElettronicaHeaderCedentePrestatoreStabileOrganizzazione
            Get
                Return Me.stabileOrganizzazioneField
            End Get
            Set
                Me.stabileOrganizzazioneField = Value
            End Set
        End Property

        '''<remarks/>
        Public Property IscrizioneREA() As FatturaElettronicaHeaderCedentePrestatoreIscrizioneREA
            Get
                Return Me.iscrizioneREAField
            End Get
            Set
                Me.iscrizioneREAField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlTextAttribute()>
        Public Property Text() As String()
            Get
                Return Me.textField
            End Get
            Set
                Me.textField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Partial Public Class FatturaElettronicaHeaderCedentePrestatoreDatiAnagrafici

        Private idFiscaleIVAField As FatturaElettronicaHeaderCedentePrestatoreDatiAnagraficiIdFiscaleIVA

        Private anagraficaField As FatturaElettronicaHeaderCedentePrestatoreDatiAnagraficiAnagrafica

        Private regimeFiscaleField As String

        Private textField() As String

        '''<remarks/>
        Public Property IdFiscaleIVA() As FatturaElettronicaHeaderCedentePrestatoreDatiAnagraficiIdFiscaleIVA
            Get
                Return Me.idFiscaleIVAField
            End Get
            Set
                Me.idFiscaleIVAField = Value
            End Set
        End Property

        '''<remarks/>
        Public Property Anagrafica() As FatturaElettronicaHeaderCedentePrestatoreDatiAnagraficiAnagrafica
            Get
                Return Me.anagraficaField
            End Get
            Set
                Me.anagraficaField = Value
            End Set
        End Property

        '''<remarks/>
        Public Property RegimeFiscale() As String
            Get
                Return Me.regimeFiscaleField
            End Get
            Set
                Me.regimeFiscaleField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlTextAttribute()>
        Public Property Text() As String()
            Get
                Return Me.textField
            End Get
            Set
                Me.textField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Partial Public Class FatturaElettronicaHeaderCedentePrestatoreDatiAnagraficiIdFiscaleIVA

        Private idPaeseField As String

        Private idCodiceField As ULong

        '''<remarks/>
        Public Property IdPaese() As String
            Get
                Return Me.idPaeseField
            End Get
            Set
                Me.idPaeseField = Value
            End Set
        End Property

        '''<remarks/>
        Public Property IdCodice() As ULong
            Get
                Return Me.idCodiceField
            End Get
            Set
                Me.idCodiceField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Partial Public Class FatturaElettronicaHeaderCedentePrestatoreDatiAnagraficiAnagrafica

        Private denominazioneField As String

        '''<remarks/>
        Public Property Denominazione() As String
            Get
                Return Me.denominazioneField
            End Get
            Set
                Me.denominazioneField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Partial Public Class FatturaElettronicaHeaderCedentePrestatoreSede

        Private indirizzoField As String

        Private numeroCivicoField As Byte

        Private cAPField As UShort

        Private comuneField As String

        Private provinciaField As String

        Private nazioneField As String

        '''<remarks/>
        Public Property Indirizzo() As String
            Get
                Return Me.indirizzoField
            End Get
            Set
                Me.indirizzoField = Value
            End Set
        End Property

        '''<remarks/>
        Public Property NumeroCivico() As Byte
            Get
                Return Me.numeroCivicoField
            End Get
            Set
                Me.numeroCivicoField = Value
            End Set
        End Property

        '''<remarks/>
        Public Property CAP() As UShort
            Get
                Return Me.cAPField
            End Get
            Set
                Me.cAPField = Value
            End Set
        End Property

        '''<remarks/>
        Public Property Comune() As String
            Get
                Return Me.comuneField
            End Get
            Set
                Me.comuneField = Value
            End Set
        End Property

        '''<remarks/>
        Public Property Provincia() As String
            Get
                Return Me.provinciaField
            End Get
            Set
                Me.provinciaField = Value
            End Set
        End Property

        '''<remarks/>
        Public Property Nazione() As String
            Get
                Return Me.nazioneField
            End Get
            Set
                Me.nazioneField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Partial Public Class FatturaElettronicaHeaderCedentePrestatoreStabileOrganizzazione

        Private indirizzoField As String

        Private numeroCivicoField As String

        Private cAPField As UShort

        Private comuneField As String

        Private provinciaField As String

        Private nazioneField As String

        '''<remarks/>
        Public Property Indirizzo() As String
            Get
                Return Me.indirizzoField
            End Get
            Set
                Me.indirizzoField = Value
            End Set
        End Property

        '''<remarks/>
        Public Property NumeroCivico() As String
            Get
                Return Me.numeroCivicoField
            End Get
            Set
                Me.numeroCivicoField = Value
            End Set
        End Property

        '''<remarks/>
        Public Property CAP() As UShort
            Get
                Return Me.cAPField
            End Get
            Set
                Me.cAPField = Value
            End Set
        End Property

        '''<remarks/>
        Public Property Comune() As String
            Get
                Return Me.comuneField
            End Get
            Set
                Me.comuneField = Value
            End Set
        End Property

        '''<remarks/>
        Public Property Provincia() As String
            Get
                Return Me.provinciaField
            End Get
            Set
                Me.provinciaField = Value
            End Set
        End Property

        '''<remarks/>
        Public Property Nazione() As String
            Get
                Return Me.nazioneField
            End Get
            Set
                Me.nazioneField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Partial Public Class FatturaElettronicaHeaderCedentePrestatoreIscrizioneREA

        Private ufficioField As String

        Private numeroREAField As String

        Private capitaleSocialeField As Decimal

        Private socioUnicoField As String

        Private statoLiquidazioneField As String

        '''<remarks/>
        Public Property Ufficio() As String
            Get
                Return Me.ufficioField
            End Get
            Set
                Me.ufficioField = Value
            End Set
        End Property

        '''<remarks/>
        Public Property NumeroREA() As String
            Get
                Return Me.numeroREAField
            End Get
            Set
                Me.numeroREAField = Value
            End Set
        End Property

        '''<remarks/>
        Public Property CapitaleSociale() As Decimal
            Get
                Return Me.capitaleSocialeField
            End Get
            Set
                Me.capitaleSocialeField = Value
            End Set
        End Property

        '''<remarks/>
        Public Property SocioUnico() As String
            Get
                Return Me.socioUnicoField
            End Get
            Set
                Me.socioUnicoField = Value
            End Set
        End Property

        '''<remarks/>
        Public Property StatoLiquidazione() As String
            Get
                Return Me.statoLiquidazioneField
            End Get
            Set
                Me.statoLiquidazioneField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Partial Public Class FatturaElettronicaHeaderCessionarioCommittente

        Private datiAnagraficiField As FatturaElettronicaHeaderCessionarioCommittenteDatiAnagrafici

        Private sedeField As FatturaElettronicaHeaderCessionarioCommittenteSede

        Private textField() As String

        '''<remarks/>
        Public Property DatiAnagrafici() As FatturaElettronicaHeaderCessionarioCommittenteDatiAnagrafici
            Get
                Return Me.datiAnagraficiField
            End Get
            Set
                Me.datiAnagraficiField = Value
            End Set
        End Property

        '''<remarks/>
        Public Property Sede() As FatturaElettronicaHeaderCessionarioCommittenteSede
            Get
                Return Me.sedeField
            End Get
            Set
                Me.sedeField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlTextAttribute()>
        Public Property Text() As String()
            Get
                Return Me.textField
            End Get
            Set
                Me.textField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Partial Public Class FatturaElettronicaHeaderCessionarioCommittenteDatiAnagrafici

        Private codiceFiscaleField As ULong

        Private anagraficaField As FatturaElettronicaHeaderCessionarioCommittenteDatiAnagraficiAnagrafica

        Private textField() As String

        '''<remarks/>
        Public Property CodiceFiscale() As ULong
            Get
                Return Me.codiceFiscaleField
            End Get
            Set
                Me.codiceFiscaleField = Value
            End Set
        End Property

        '''<remarks/>
        Public Property Anagrafica() As FatturaElettronicaHeaderCessionarioCommittenteDatiAnagraficiAnagrafica
            Get
                Return Me.anagraficaField
            End Get
            Set
                Me.anagraficaField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlTextAttribute()>
        Public Property Text() As String()
            Get
                Return Me.textField
            End Get
            Set
                Me.textField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Partial Public Class FatturaElettronicaHeaderCessionarioCommittenteDatiAnagraficiAnagrafica

        Private denominazioneField As String

        '''<remarks/>
        Public Property Denominazione() As String
            Get
                Return Me.denominazioneField
            End Get
            Set
                Me.denominazioneField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Partial Public Class FatturaElettronicaHeaderCessionarioCommittenteSede

        Private indirizzoField As String

        Private cAPField As UShort

        Private comuneField As String

        Private provinciaField As String

        Private nazioneField As String

        '''<remarks/>
        Public Property Indirizzo() As String
            Get
                Return Me.indirizzoField
            End Get
            Set
                Me.indirizzoField = Value
            End Set
        End Property

        '''<remarks/>
        Public Property CAP() As UShort
            Get
                Return Me.cAPField
            End Get
            Set
                Me.cAPField = Value
            End Set
        End Property

        '''<remarks/>
        Public Property Comune() As String
            Get
                Return Me.comuneField
            End Get
            Set
                Me.comuneField = Value
            End Set
        End Property

        '''<remarks/>
        Public Property Provincia() As String
            Get
                Return Me.provinciaField
            End Get
            Set
                Me.provinciaField = Value
            End Set
        End Property

        '''<remarks/>
        Public Property Nazione() As String
            Get
                Return Me.nazioneField
            End Get
            Set
                Me.nazioneField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
 System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
    Partial Public Class FatturaElettronicaBody

        Private datiGeneraliField As FatturaElettronicaBodyDatiGenerali

        Private datiBeniServiziField As FatturaElettronicaBodyDatiBeniServizi

        Private datiPagamentoField As FatturaElettronicaBodyDatiPagamento

        Private textField() As String

        '''<remarks/>
        Public Property DatiGenerali() As FatturaElettronicaBodyDatiGenerali
            Get
                Return Me.datiGeneraliField
            End Get
            Set
                Me.datiGeneraliField = Value
            End Set
        End Property

        '''<remarks/>
        Public Property DatiBeniServizi() As FatturaElettronicaBodyDatiBeniServizi
            Get
                Return Me.datiBeniServiziField
            End Get
            Set
                Me.datiBeniServiziField = Value
            End Set
        End Property

        '''<remarks/>
        Public Property DatiPagamento() As FatturaElettronicaBodyDatiPagamento
            Get
                Return Me.datiPagamentoField
            End Get
            Set
                Me.datiPagamentoField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlTextAttribute()>
        Public Property Text() As String()
            Get
                Return Me.textField
            End Get
            Set
                Me.textField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Partial Public Class FatturaElettronicaBodyDatiGenerali

        Private datiGeneraliDocumentoField As FatturaElettronicaBodyDatiGeneraliDatiGeneraliDocumento

        Private textField() As String

        '''<remarks/>
        Public Property DatiGeneraliDocumento() As FatturaElettronicaBodyDatiGeneraliDatiGeneraliDocumento
            Get
                Return Me.datiGeneraliDocumentoField
            End Get
            Set
                Me.datiGeneraliDocumentoField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlTextAttribute()>
        Public Property Text() As String()
            Get
                Return Me.textField
            End Get
            Set
                Me.textField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Partial Public Class FatturaElettronicaBodyDatiGeneraliDatiGeneraliDocumento

        Private tipoDocumentoField As String

        Private divisaField As String

        Private dataField As Date

        Private numeroField As String

        Private importoTotaleDocumentoField As Decimal

        '''<remarks/>
        Public Property TipoDocumento() As String
            Get
                Return Me.tipoDocumentoField
            End Get
            Set
                Me.tipoDocumentoField = Value
            End Set
        End Property

        '''<remarks/>
        Public Property Divisa() As String
            Get
                Return Me.divisaField
            End Get
            Set
                Me.divisaField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(DataType:="date")>
        Public Property Data() As Date
            Get
                Return Me.dataField
            End Get
            Set
                Me.dataField = Value
            End Set
        End Property

        '''<remarks/>
        Public Property Numero() As String
            Get
                Return Me.numeroField
            End Get
            Set
                Me.numeroField = Value
            End Set
        End Property

        '''<remarks/>
        Public Property ImportoTotaleDocumento() As Decimal
            Get
                Return Me.importoTotaleDocumentoField
            End Get
            Set
                Me.importoTotaleDocumentoField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Partial Public Class FatturaElettronicaBodyDatiBeniServizi

        Private dettaglioLineeField() As FatturaElettronicaBodyDatiBeniServiziDettaglioLinee

        Private datiRiepilogoField() As FatturaElettronicaBodyDatiBeniServiziDatiRiepilogo

        Private textField() As String

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("DettaglioLinee")>
        Public Property DettaglioLinee() As FatturaElettronicaBodyDatiBeniServiziDettaglioLinee()
            Get
                Return Me.dettaglioLineeField
            End Get
            Set
                Me.dettaglioLineeField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("DatiRiepilogo")>
        Public Property DatiRiepilogo() As FatturaElettronicaBodyDatiBeniServiziDatiRiepilogo()
            Get
                Return Me.datiRiepilogoField
            End Get
            Set
                Me.datiRiepilogoField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlTextAttribute()>
        Public Property Text() As String()
            Get
                Return Me.textField
            End Get
            Set
                Me.textField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Partial Public Class FatturaElettronicaBodyDatiBeniServiziDettaglioLinee

        Private numeroLineaField As Byte

        Private descrizioneField As String

        Private quantitaField As Decimal

        Private prezzoUnitarioField As Decimal

        Private prezzoTotaleField As Decimal

        Private aliquotaIVAField As Decimal

        '''<remarks/>
        Public Property NumeroLinea() As Byte
            Get
                Return Me.numeroLineaField
            End Get
            Set
                Me.numeroLineaField = Value
            End Set
        End Property

        '''<remarks/>
        Public Property Descrizione() As String
            Get
                Return Me.descrizioneField
            End Get
            Set
                Me.descrizioneField = Value
            End Set
        End Property

        '''<remarks/>
        Public Property Quantita() As Decimal
            Get
                Return Me.quantitaField
            End Get
            Set
                Me.quantitaField = Value
            End Set
        End Property

        '''<remarks/>
        Public Property PrezzoUnitario() As Decimal
            Get
                Return Me.prezzoUnitarioField
            End Get
            Set
                Me.prezzoUnitarioField = Value
            End Set
        End Property

        '''<remarks/>
        Public Property PrezzoTotale() As Decimal
            Get
                Return Me.prezzoTotaleField
            End Get
            Set
                Me.prezzoTotaleField = Value
            End Set
        End Property

        '''<remarks/>
        Public Property AliquotaIVA() As Decimal
            Get
                Return Me.aliquotaIVAField
            End Get
            Set
                Me.aliquotaIVAField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Partial Public Class FatturaElettronicaBodyDatiBeniServiziDatiRiepilogo

        Private aliquotaIVAField As Decimal

        Private imponibileImportoField As Decimal

        Private impostaField As Decimal

        Private esigibilitaIVAField As String

        Private riferimentoNormativoField As String

        '''<remarks/>
        Public Property AliquotaIVA() As Decimal
            Get
                Return Me.aliquotaIVAField
            End Get
            Set
                Me.aliquotaIVAField = Value
            End Set
        End Property

        '''<remarks/>
        Public Property ImponibileImporto() As Decimal
            Get
                Return Me.imponibileImportoField
            End Get
            Set
                Me.imponibileImportoField = Value
            End Set
        End Property

        '''<remarks/>
        Public Property Imposta() As Decimal
            Get
                Return Me.impostaField
            End Get
            Set
                Me.impostaField = Value
            End Set
        End Property

        '''<remarks/>
        Public Property EsigibilitaIVA() As String
            Get
                Return Me.esigibilitaIVAField
            End Get
            Set
                Me.esigibilitaIVAField = Value
            End Set
        End Property

        '''<remarks/>
        Public Property RiferimentoNormativo() As String
            Get
                Return Me.riferimentoNormativoField
            End Get
            Set
                Me.riferimentoNormativoField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Partial Public Class FatturaElettronicaBodyDatiPagamento

        Private condizioniPagamentoField As String

        Private dettaglioPagamentoField As FatturaElettronicaBodyDatiPagamentoDettaglioPagamento

        Private textField() As String

        '''<remarks/>
        Public Property CondizioniPagamento() As String
            Get
                Return Me.condizioniPagamentoField
            End Get
            Set
                Me.condizioniPagamentoField = Value
            End Set
        End Property

        '''<remarks/>
        Public Property DettaglioPagamento() As FatturaElettronicaBodyDatiPagamentoDettaglioPagamento
            Get
                Return Me.dettaglioPagamentoField
            End Get
            Set
                Me.dettaglioPagamentoField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlTextAttribute()>
        Public Property Text() As String()
            Get
                Return Me.textField
            End Get
            Set
                Me.textField = Value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
    Partial Public Class FatturaElettronicaBodyDatiPagamentoDettaglioPagamento

        Private beneficiarioField As String

        Private modalitaPagamentoField As String

        Private dataRiferimentoTerminiPagamentoField As Date

        Private dataScadenzaPagamentoField As Date

        Private importoPagamentoField As Decimal

        Private iBANField As String

        '''<remarks/>
        Public Property Beneficiario() As String
            Get
                Return Me.beneficiarioField
            End Get
            Set
                Me.beneficiarioField = Value
            End Set
        End Property

        '''<remarks/>
        Public Property ModalitaPagamento() As String
            Get
                Return Me.modalitaPagamentoField
            End Get
            Set
                Me.modalitaPagamentoField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(DataType:="date")>
        Public Property DataRiferimentoTerminiPagamento() As Date
            Get
                Return Me.dataRiferimentoTerminiPagamentoField
            End Get
            Set
                Me.dataRiferimentoTerminiPagamentoField = Value
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(DataType:="date")>
        Public Property DataScadenzaPagamento() As Date
            Get
                Return Me.dataScadenzaPagamentoField
            End Get
            Set
                Me.dataScadenzaPagamentoField = Value
            End Set
        End Property

        '''<remarks/>
        Public Property ImportoPagamento() As Decimal
            Get
                Return Me.importoPagamentoField
            End Get
            Set
                Me.importoPagamentoField = Value
            End Set
        End Property

        '''<remarks/>
        Public Property IBAN() As String
            Get
                Return Me.iBANField
            End Get
            Set
                Me.iBANField = Value
            End Set
        End Property
    End Class


End Class
