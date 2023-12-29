Imports System.Runtime.CompilerServices

'Estensione per aggiungere add agli array
'Figata sensazionale non bisogna più ridimensionare gli array fa tutto in automatico.
Public Module MyExtensions
    <Extension()>
    Public Sub Add(Of T)(ByRef arr As T(), item As T)
        If arr Is Nothing Then
            Array.Resize(Of T)(arr, 1)
        Else
            Array.Resize(arr, arr.Length + 1)
        End If

        arr(arr.Length - 1) = item
    End Sub

End Module

Public Class SCARDIOREQUEST
    Public Property dwProtocol As Long
    Public Property cbPciLength As Long
End Class


Public Class APDURec
    Public Property bCLA As Byte
    Public Property bINS As Byte
    Public Property bP1 As Byte
    Public Property bP2 As Byte
    Public Property bP3 As Byte
    Public Property Data() As Byte
    Public Property IsSend As Boolean
End Class

Public Class SCARDREADERSTATE
    Public Property szReader As String
    Public Property pwUserData As String
    Public Property dwCurrenState As Long
    Public Property dwEventState As Long
    Public Property lAtrLen As Long
    Public Property rgbAtr As BytArray
End Class

Public Class VERSIONCONTROL
    Public Property SmclibVersion As Long
    Public Property DriverMajor As Byte
    Public Property DriverMinor As Byte
    Public Property FirmwareMajor As Byte
    Public Property FirmwareMinor As Byte
    Public Property UpdateKey As Byte
End Class
Public Class BytArray
#Disable Warning CA1819 ' Le proprietà non devono restituire matrici
    Public Property ByBytes As Byte()
#Enable Warning CA1819 ' Le proprietà non devono restituire matrici
End Class
<CodeAnalysis.SuppressMessage("Design", "CA1052:I tipi che contengono membri static devono Static o NotInheritable", Justification:="<In sospeso>")>
<CodeAnalysis.SuppressMessage("Design", "CA1060:Spostare le istanze di PInvoke nella classe NativeMethods", Justification:="<In sospeso>")>
Public Class NFCcontroller


    ' Our own Public Const ant declarations
    Public Const MINTIMEOUT = 0
    Public Const MAXREADERS = 8

    ' Public Const ants used to access card and reader attributes

    Public Const SCARDCLASSVENDORINFO = 1      ' Vendor information definitions
    Public Const SCARDCLASSCOMMUNICATIONS = 2   ' Communication definitions
    Public Const SCARDCLASSPROTOCOL = 3         ' Protocol definitions
    Public Const SCARDCLASSPOWERMGMT = 4       ' Power Management definitions
    Public Const SCARDCLASSSECURITY = 5         ' Security Assurance definitions
    Public Const SCARDCLASSMECHANICAL = 6       ' Mechanical characteristic definitions
    Public Const SCARDCLASSVENDORDEFINED = 7   ' Vendor specific definitions
    Public Const SCARDCLASSIFDPROTOCOL = 8     ' Interface Device Protocol options
    Public Const SCARDCLASSICCSTATE = 9        ' ICC State specific definitions
    Public Const SCARDCLASSSYSTEM = &H7FFF      ' System-specific definitions
    Public Const SCARDATTRVENDORNAME = (((SCARDCLASSVENDORINFO) * (2 ^ 16)) Or (&H100))
    Public Const SCARDATTRVENDORIFDTYPE = (((SCARDCLASSVENDORINFO) *
                                            (2 ^ 16)) Or (&H101))
    Public Const SCARDATTRVENDORIFDVERSION = (((SCARDCLASSVENDORINFO) *
                                               (2 ^ 16)) Or (&H102))

    Public Const SCARDATTRVENDORIFDSERIALNO = (((SCARDCLASSVENDORINFO) *
                                                 (2 ^ 16)) Or (&H103))

    Public Const SCARDATTRCHANNELID = (((SCARDCLASSCOMMUNICATIONS) *
                                       (2 ^ 16)) Or (&H110))

    Public Const SCARDATTRASYNCPROTOCOLTYPES = (((SCARDCLASSPROTOCOL) *
                                               (2 ^ 16)) Or (&H120))

    Public Const SCARDATTRDEFAULTCLK = (((SCARDCLASSPROTOCOL) *
                                        (2 ^ 16)) Or (&H121))

    Public Const SCARDATTRMAXCLK = (((SCARDCLASSPROTOCOL) *
                                    (2 ^ 16)) Or (&H122))

    Public Const SCARDATTRDEFAULTDATARATE = (((SCARDCLASSPROTOCOL) *
                                              (2 ^ 16)) Or (&H123))

    Public Const SCARDATTRMAXDATARATE = (((SCARDCLASSPROTOCOL) *
                                              (2 ^ 16)) Or (&H124))

    Public Const SCARDATTRMAXIFSD = (((SCARDCLASSPROTOCOL) *
                                              (2 ^ 16)) Or (&H125))

    Public Const SCARDATTRSYNCPROTOCOLTYPES = (((SCARDCLASSPROTOCOL) *
                                              (2 ^ 16)) Or (&H126))

    Public Const SCARDATTRPOWERMGMTSUPPORT = (((SCARDCLASSPOWERMGMT) *
                                               (2 ^ 16)) Or (&H131))

    Public Const SCARDATTRUSERTOCARDAUTHDEVICE = (((SCARDCLASSSECURITY) *
                                                     (2 ^ 16)) Or (&H140))

    Public Const SCARDATTRUSERAUTHINPUTDEVICE = (((SCARDCLASSSECURITY) *
                                                   (2 ^ 16)) Or (&H142))

    Public Const SCARDATTRCHARACTERISTICS = (((SCARDCLASSMECHANICAL) *
                                            (2 ^ 16)) Or (&H150))


    Public Const SCARDATTRCURRENTPROTOCOLTYPE = (((SCARDCLASSIFDPROTOCOL) *
                                                  (2 ^ 16)) Or (&H201))

    Public Const SCARDATTRCURRENTCLK = (((SCARDCLASSIFDPROTOCOL) *
                                                  (2 ^ 16)) Or (&H202))

    Public Const SCARDATTRCURRENTF = (((SCARDCLASSIFDPROTOCOL) *
                                                  (2 ^ 16)) Or (&H203))

    Public Const SCARDATTRCURRENTD = (((SCARDCLASSIFDPROTOCOL) *
                                                  (2 ^ 16)) Or (&H204))

    Public Const SCARDATTRCURRENTN = (((SCARDCLASSIFDPROTOCOL) *
                                                  (2 ^ 16)) Or (&H205))

    Public Const SCARDATTRCURRENTW = (((SCARDCLASSIFDPROTOCOL) *
                                                  (2 ^ 16)) Or (&H206))

    Public Const SCARDATTRCURRENTIFSC = (((SCARDCLASSIFDPROTOCOL) *
                                                  (2 ^ 16)) Or (&H207))

    Public Const SCARDATTRCURRENTIFSD = (((SCARDCLASSIFDPROTOCOL) *
                                                  (2 ^ 16)) Or (&H208))

    Public Const SCARDATTRCURRENTBWT = (((SCARDCLASSIFDPROTOCOL) *
                                                  (2 ^ 16)) Or (&H209))

    Public Const SCARDATTRCURRENTCWT = (((SCARDCLASSIFDPROTOCOL) *
                                                  (2 ^ 16)) Or (&H20A))

    Public Const SCARDATTRCURRENTEBCENCODING = (((SCARDCLASSIFDPROTOCOL) *
                                                  (2 ^ 16)) Or (&H20B))

    Public Const SCARDATTREXTENDEDBWT = (((SCARDCLASSIFDPROTOCOL) *
                                                  (2 ^ 16)) Or (&H20C))


    Public Const SCARDATTRICCPRESENCE = (((SCARDCLASSICCSTATE) *
                                         (2 ^ 16)) Or (&H300))

    Public Const SCARDATTRICCINTERFACESTATUS = (((SCARDCLASSICCSTATE) *
                                         (2 ^ 16)) Or (&H301))

    Public Const SCARDATTRCURRENTIOSTATE = (((SCARDCLASSICCSTATE) *
                                         (2 ^ 16)) Or (&H302))

    Public Const SCARDATTRATRSTRING = (((SCARDCLASSICCSTATE) *
                                         (2 ^ 16)) Or (&H303))

    Public Const SCARDATTRICCTYPEPERATR = (((SCARDCLASSICCSTATE) *
                                         (2 ^ 16)) Or (&H304))


    Public Const SCARDATTRESCRESET = (((SCARDCLASSVENDORDEFINED) *
                                      (2 ^ 16)) Or (&HA000))

    Public Const SCARDATTRESCCANCEL = (((SCARDCLASSVENDORDEFINED) *
                                      (2 ^ 16)) Or (&HA003))

    Public Const SCARDATTRESCAUTHREQUEST = (((SCARDCLASSVENDORDEFINED) *
                                      (2 ^ 16)) Or (&HA005))

    Public Const SCARDATTRMAXINPUT = (((SCARDCLASSVENDORDEFINED) *
                                      (2 ^ 16)) Or (&HA007))


    Public Const SCARDATTRDEVICEUNIT = (((SCARDCLASSSYSTEM) *
                                        (2 ^ 16)) Or (&H1))

    Public Const SCARDATTRDEVICEINUSE = (((SCARDCLASSSYSTEM) *
                                        (2 ^ 16)) Or (&H2))

    Public Const SCARDATTRDEVICEFRIENDLYNAMEA = (((SCARDCLASSSYSTEM) *
                                        (2 ^ 16)) Or (&H3))

    Public Const SCARDATTRDEVICESYSTEMNAMEA = (((SCARDCLASSSYSTEM) *
                                        (2 ^ 16)) Or (&H4))

    Public Const SCARDATTRDEVICEFRIENDLYNAMEW = (((SCARDCLASSSYSTEM) *
                                        (2 ^ 16)) Or (&H5))

    Public Const SCARDATTRDEVICESYSTEMNAMEW = (((SCARDCLASSSYSTEM) *
                                        (2 ^ 16)) Or (&H6))

    Public Const SCARDATTRSUPRESST1IFSREQUEST = (((SCARDCLASSSYSTEM) *
                                        (2 ^ 16)) Or (&H7))

    Public Const SCARDATTRDEVICEFRIENDLYNAME = SCARDATTRDEVICEFRIENDLYNAMEA
    Public Const SCARDATTRDEVICESYSTEMNAME = SCARDATTRDEVICESYSTEMNAMEA


    '**************************************************************************
    ' IOCTL Codes
    '**************************************************************************

    Public Const METHODBUFFERED = 0
    Public Const METHODINDIRECT = 1
    Public Const METHODOUTDIRECT = 2
    Public Const METHODNEITHER = 3
    Public Const FILEANYACCESS = &H0
    Public Const FILEREADACCESS = &H1
    Public Const FILEWRITEACCESS = &H2

    Public Const FILEDEVICESMARTCARD = &H31

    Public Const IOCTLPSCRCOMMAND = (((FILEDEVICESMARTCARD) * (2 ^ 16)) Or
                                    ((FILEANYACCESS) * (2 ^ 14)) Or
                                    ((&H800) * (2 ^ 2)) Or
                                    (METHODBUFFERED))

    Public Const IOCTLGETVERSIONS = (((FILEDEVICESMARTCARD) * (2 ^ 16)) Or
                                    ((FILEANYACCESS) * (2 ^ 14)) Or
                                    ((&H801) * (2 ^ 2)) Or
                                    (METHODBUFFERED))

    Public Const IOCTLSETTIMEOUT = (((FILEDEVICESMARTCARD) * (2 ^ 16)) Or
                                    ((FILEANYACCESS) * (2 ^ 14)) Or
                                    ((&H802) * (2 ^ 2)) Or
                                    (METHODBUFFERED))

    Public Const IOCTLRESETINTERFACE = (((FILEDEVICESMARTCARD) * (2 ^ 16)) Or
                                    ((FILEANYACCESS) * (2 ^ 14)) Or
                                    ((&H803) * (2 ^ 2)) Or
                                    (METHODBUFFERED))

    Public Const IOCTLGETCONFIGURATION = (((FILEDEVICESMARTCARD) * (2 ^ 16)) Or
                                    ((FILEANYACCESS) * (2 ^ 14)) Or
                                    ((&H804) * (2 ^ 2)) Or
                                    (METHODBUFFERED))

    Public Const IOCTLSCMPINPAD = (((FILEDEVICESMARTCARD) * (2 ^ 16)) Or
                                    ((FILEANYACCESS) * (2 ^ 14)) Or
                                    ((&H805) * (2 ^ 2)) Or
                                    (METHODBUFFERED))

    Public Const IOCTLSCMSETP = (((FILEDEVICESMARTCARD) * (2 ^ 16)) Or
                                    ((FILEANYACCESS) * (2 ^ 14)) Or
                                    ((&H811) * (2 ^ 2)) Or
                                    (METHODBUFFERED))

    Public Const IOCTLSCMGETP = (((FILEDEVICESMARTCARD) * (2 ^ 16)) Or
                                    ((FILEANYACCESS) * (2 ^ 14)) Or
                                    ((&H812) * (2 ^ 2)) Or
                                    (METHODBUFFERED))

    Public Const IOCTLGETDEVICENAME = (((FILEDEVICESMARTCARD) * (2 ^ 16)) Or
                                    ((FILEANYACCESS) * (2 ^ 14)) Or
                                    ((&H820) * (2 ^ 2)) Or
                                    (METHODBUFFERED))


    '**************************************************************************
    ' Context Scope
    '**************************************************************************
    ' The context is a user context, and any database operations are performed
    ' within the domain of the user.
    Public Const SCARDSCOPEUSER = 0

    ' The context is that of the current terminal,and any database operations
    ' are performed within the domain of that terminal. (The calling application
    ' must have appropriate access permissions for any database actions.)
    Public Const SCARDSCOPETERMINAL = 1

    ' The context is the system context, and any database operations are performed
    ' within the domain of the system.  (The calling application must have appropriate
    ' access permissions for any database actions.)
    Public Const SCARDSCOPESYSTEM = 2

    '**************************************************************************
    ' Context Scope
    '**************************************************************************
    Public Const SCARDSSUCCESS = 0
    Public Const SCARDATRLENGTH = 33

    ' The application is unaware of the current state, and would like to
    ' know.  The use of this value results in an immediate return from state transition
    ' monitoring services.  This is represented by all bits set to zero.
    Public Const SCARDSTATEUNAWARE = &H0

    ' The application requested that this reader be ignored.  No other bits will be set.
    Public Const SCARDSTATEIGNORE = &H1

    ' This implies that there is a difference between the state believed by the
    ' application, and the state known by the Service Manager.  When this bit is set,
    ' the application may assume a significant state change has occurred on this reader.
    Public Const SCARDSTATECHANGED = &H2

    ' This implies that the given reader name is not recognized by the Service Manager.
    ' If this bit is set, then SCARDSTATECHANGED and SCARDSTATEIGNORE will also
    ' be set.
    Public Const SCARDSTATEUNKNOWN = &H4

    ' This implies that the actual state of this reader is not
    ' available.  If this bit is set, then all the following bits are clear.
    Public Const SCARDSTATEUNAVAILABLE = &H8

    Public Const SCARDSTATEEMPTY = &H10 ' This implies that there is not
    ' card in the reader.  If this bit
    ' is set, all the following bits
    ' will be clear.
    Public Const SCARDSTATEPRESENT = &H20 ' This implies that there is a card
    ' in the reader.
    Public Const SCARDSTATEATRMATCH = &H40 ' This implies that there is a card
    ' in the reader with an ATR
    ' matching one of the target cards.
    ' If this bit is set,
    ' SCARDSTATEPRESENT will also be
    ' set.  This bit is only returned
    ' on the SCardLocateCard() service.
    Public Const SCARDSTATEEXCLUSIVE = &H80 ' This implies that the card in the
    ' reader is allocated for exclusive
    ' use by another application.  If
    ' this bit is set,
    ' SCARDSTATEPRESENT will also be
    ' set.
    ' This implies that the card in the reader is in use by one or more
    ' other applications, but may be connected to in shared mode.  If
    ' this bit is set, SCARDSTATEPRESENT will also be set.
    Public Const SCARDSTATEINUSE = &H100

    ' This implies that the card in the reader is unresponsive or not
    ' supported by the reader or software.
    Public Const SCARDSTATEMUTE = &H200

    ' This implies that the card in the reader has not been powered up.
    Public Const SCARDSTATEUNPOWERED = &H400


    '**************************************************************************
    '
    '**************************************************************************
    ' This application is not willing to share this card with other applications.
    Public Const SCARDSHAREEXCLUSIVE = 1

    ' This application is willing to share this card with other applications.
    Public Const SCARDSHARESHARED = 2

    ' This application demands direct control of the reader,
    ' so it is not available to other applications.
    Public Const SCARDSHAREDIRECT = 3

    '**************************************************************************
    '   Disposition
    '**************************************************************************
    ' Don't do anything special on close
    Public Const SCARDLEAVECARD = 0

    ' Reset the card on close
    Public Const SCARDRESETCARD = 1

    ' Power down the card on close
    Public Const SCARDUNPOWERCARD = 2

    ' Eject the card on close
    Public Const SCARDEJECTCARD = 3

    '**************************************************************************
    '   Error Codes
    '**************************************************************************
    Public Const SCARDFINTERNALERROR = &H80100001
    Public Const SCARDECANCELLED = &H80100002
    Public Const SCARDEINVALIDHANDLE = &H80100003
    Public Const SCARDEINVALIDPARAMETER = &H80100004
    Public Const SCARDEINVALIDTARGET = &H80100005
    Public Const SCARDENOMEMORY = &H80100006
    Public Const SCARDFWAITEDTOOLONG = &H80100007
    Public Const SCARDEINSUFFICIENTBUFFER = &H80100008
    Public Const SCARDEUNKNOWNREADER = &H80100009
    Public Const SCARDETIMEOUT = &H8010000A
    Public Const SCARDESHARINGVIOLATION = &H8010000B
    Public Const SCARDENOSMARTCARD = &H8010000C
    Public Const SCARDEUNKNOWNCARD = &H8010000D
    Public Const SCARDECANTDISPOSE = &H8010000E
    Public Const SCARDEPROTOMISMATCH = &H8010000F
    Public Const SCARDENOTREADY = &H80100010
    Public Const SCARDEINVALIDVALUE = &H80100011
    Public Const SCARDESYSTEMCANCELLED = &H80100012
    Public Const SCARDFCOMMERROR = &H80100013
    Public Const SCARDFUNKNOWNERROR = &H80100014
    Public Const SCARDEINVALIDATR = &H80100015
    Public Const SCARDENOTTRANSACTED = &H80100016
    Public Const SCARDEREADERUNAVAILABLE = &H80100017
    Public Const SCARDPSHUTDOWN = &H80100018
    Public Const SCARDEPCITOOSMALL = &H80100019
    Public Const SCARDEREADERUNSUPPORTED = &H8010001A
    Public Const SCARDEDUPLICATEREADER = &H8010001B
    Public Const SCARDECARDUNSUPPORTED = &H8010001C
    Public Const SCARDENOSERVICE = &H8010001D
    Public Const SCARDESERVICESTOPPED = &H8010001E
    Public Const SCARDWUNSUPPORTEDCARD = &H80100065
    Public Const SCARDWUNRESPONSIVECARD = &H80100066
    Public Const SCARDWUNPOWEREDCARD = &H80100067
    Public Const SCARDWRESETCARD = &H80100068
    Public Const SCARDWREMOVEDCARD = &H80100069


    '**************************************************************************
    '   Protocol
    '**************************************************************************
    ' There is no active protocol.
    Public Const SCARDPROTOCOLUNDEFINED = &H0

    ' T=0 is the active protocol.
    Public Const SCARDPROTOCOLT0 = &H1

    ' T=1 is the active protocol.
    Public Const SCARDPROTOCOLT1 = &H2

    ' Raw is the active protocol.
    Public Const SCARDPROTOCOLRAW = &H10000

    ' Use implicit PTS.
    Public Const SCARDPROTOCOLDEFAULT = &H80000000


    '**************************************************************************
    '   Reader State
    '**************************************************************************
    ' This value implies the driver is unaware
    ' of the current state of the reader.
    Public Const SCARDUNKNOWN = 0

    ' This value implies there is no card in
    ' the reader.
    Public Const SCARDABSENT = 1

    ' This value implies there is a card is
    ' present in the reader, but that it has
    ' not been moved into position for use.
    Public Const SCARDPRESENT = 2

    ' This value implies there is a card in the
    ' reader in position for use.  The card is
    ' not powered.
    Public Const SCARDSWALLOWED = 3

    ' This value implies there is power is
    ' being provided to the card, but the
    ' Reader Driver is unaware of the mode of
    ' the card.
    Public Const SCARDPOWERED = 4

    ' This value implies the card has been
    ' reset and is awaiting PTS negotiation.
    Public Const SCARDNEGOTIABLE = 5

    ' This value implies the card has been
    ' reset and specific communication
    ' protocols have been established.
    Public Const SCARDSPECIFIC = 6


    '**************************************************************************
    ' Prototypes
    '**************************************************************************

    Public Declare Function SCardEstablishContext Lib "WinScard.dll" (
    ByVal dwScope As Long,
    ByVal pvReserved1 As Long,
    ByVal pvReserved2 As Long,
    ByRef phContext As Long) As Long

    '**************************************************************************
    Public Declare Function SCardReleaseContext Lib "WinScard.dll" (
    ByVal hContext As Long
) As Long

    '**************************************************************************
    Public Declare Function SCardConnect Lib "WinScard.dll" Alias "SCardConnectA" (
    ByVal hContext As Long,
    ByVal szReaderName As String,
    ByVal dwShareMode As Long,
    ByVal dwPrefProtocol As Long,
    ByRef hCard As Long,
    ByRef ActiveProtocol As Long
) As Long

    '**************************************************************************
    Public Declare Function SCardDisconnect Lib "WinScard.dll" (
    ByVal hCard As Long,
    ByVal Disposistion As Long
) As Long

    '**************************************************************************
    Public Declare Function SCardBeginTransaction Lib "WinScard.dll" (
    ByVal hCard As Long
) As Long

    '**************************************************************************
    Public Declare Function SCardEndTransaction Lib "WinScard.dll" (
    ByVal hCard As Long,
    ByVal Disposition As Long
) As Long

    '**************************************************************************
    Public Declare Function SCardState Lib "WinScard.dll" (
    ByVal hCard As Long,
    ByRef State As Long,
    ByRef Protocol As Long,
    ByRef ATR As Byte,
    ByRef ATRLen As Long
) As Long

    '**************************************************************************
    Public Declare Function SCardStatus Lib "WinScard.dll" Alias "SCardStatusA" (
    ByVal hCard As Long,
    ByVal szReaderName As String,
    ByRef pcchReaderLen As Long,
    ByRef State As Long,
    ByRef Protocol As Long,
    ByRef ATR As BytArray,
    ByRef ATRLen As Long
) As Long

    '**************************************************************************
    Public Declare Function SCardTransmit Lib "WinScard.dll" (
    ByVal hCard As Long,
    ByVal pioSendRequest As Long,
    ByRef SendBuff As BytArray,
    ByVal SendBuffLen As Long,
    ByVal pioRecvRequest As Long,
    ByRef RecvBuff As BytArray,
    ByRef RecvBuffLen As Long
) As Long

    '**************************************************************************
    Public Declare Function SCardListReaders Lib "WinScard.dll" Alias "SCardListReadersA" (
    ByVal hContext As Long,
    ByVal mzGroup As String,
    ByVal ReaderList As String,
    ByRef pcchReaders As Long
) As Long

    '**************************************************************************
    Public Declare Function SCardCancel Lib "WinScard.dll" (
    ByVal hContext As Long
) As Long

    '**************************************************************************
    Public Declare Function SCardSetAttrib Lib "WinScard.dll" (
    ByVal hCard As Long,
    ByVal dwAttrId As Long,
    ByVal pbAttr As BytArray,
    ByVal lAttrLen As Long
) As Long

    '**************************************************************************
    Public Declare Function SCardGetStatusChange Lib "WinScard.dll" Alias _
                       "SCardGetStatusChangeA" (
    ByVal hContext As Long,
    ByVal dwTimeOut As Long,
    ByRef rgReaderStates As SCARDREADERSTATE,
    ByVal cReaders As Long
) As Long
    '**************************************************************************
    Public Declare Function SCardControl Lib "WinScard.dll" (
    ByVal hCard As Long,
    ByVal dwControlCode As Long,
    ByVal lpInBuffer As Long,
    ByVal lSizeofBuffer As Long,
    ByRef lpReceiveBuffer As VERSIONCONTROL,
    ByVal lpReceiveBufferSize As Long,
    ByRef lpBytesReturned As Long
) As Long

    '**************************************************************************
    Public Declare Function SCardGetAttrib Lib "WinScard.dll" (
    ByVal hCard As Long,
    ByVal dwAttrId As Long,
    ByRef pbAttr As BytArray,
    ByRef pcbAttrLen As Long
) As Long

End Class

'**************************************************************************