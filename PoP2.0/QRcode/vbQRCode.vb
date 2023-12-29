'===================================================================
' Descrizione.....: Classe per la generazione di QRCode
'                   Class to create QRCode
' Nome dei File...: vbQRCode.vb
' Data............: 14/05/2020
' Versione........: 2020.2
' Sistema.........: Visual Basic .NET/20xx
' Scritto da......: Luigi Micco
' E-Mail..........: luigi.micco(at)gmail.com
'===================================================================
'===================================================================
' (C) 2012  - L'uso di questo software è consentito solo su espressa
'     2020    autorizzazione dell'autore. Non puo' essere copiato o
'             ridistribuito, ne' integralmente, ne' parzialmente.
'
'             The use of this software is allowed only on express
'             authorization of the author. It's cannot be copied or
'             redistributed, neither integrally, neither partially.
'===================================================================

Option Strict Off
Option Explicit On

Imports System
Imports System.Text

Friend Class vbQRCode

  Public Enum vbQRError
    qrNoError = 0
    qrEmptyCode
    qrTooManyData
    qrEncodeFailed
  End Enum

  Public Enum vbQRErrorLevel
    qrLevelL = 0 ' Error correction level L : About 7% or less errors can be corrected.
    qrLevelM = 1 ' Error correction level M : About 15% or less errors can be corrected.
    qrLevelQ = 2 ' Error correction level Q : About 25% or less errors can be corrected.
    qrLevelH = 3 ' Error correction level H : About 30% or less errors can be corrected.
  End Enum

  Public Enum vbQREncoding
    qrEncAuto = -1    ' auto select best mode
    qrEncNumeric = 0  ' Encoding mode Numeric
    qrEncAlphaNum = 1 ' Encoding mode Alphanumeric
    qrEncBinary = 2   ' Encoding mode Binary
  End Enum

  Public Enum vbQRVersion
    qrVersionM1 = -4  ' MicroQRCode M1 11x11
    qrVersionM2 = -3  ' MicroQRCode M2 13x13
    qrVersionM3 = -2  ' MicroQRCode M3 15x15
    qrVersionM4 = -1  ' MicroQRCode M4 17x17
    qrVersionAuto = 0 ' (auto)
    qrVersion01 = 1   ' QRCode 21x21
    qrVersion02 = 2   ' QRCode 25x25
    qrVersion03 = 3   ' QRCode 29x29
    qrVersion04 = 4   ' QRCode 33x33
    qrVersion05 = 5   ' QRCode 37x37
    qrVersion06 = 6   ' QRCode 41x41
    qrVersion07 = 7   ' QRCode 45x45
    qrVersion08 = 8   ' QRCode 49x49
    qrVersion09 = 9   ' QRCode 53x53
    qrVersion10 = 10  ' QRCode 57x57
    qrVersion11 = 11  ' QRCode 61x61
    qrVersion12 = 12  ' QRCode 65x65
    qrVersion13 = 13  ' QRCode 69x69
    qrVersion14 = 14  ' QRCode 73x73
    qrVersion15 = 15  ' QRCode 77x77
    qrVersion16 = 16  ' QRCode 81x81
    qrVersion17 = 17  ' QRCode 85x85
    qrVersion18 = 18  ' QRCode 89x89
    qrVersion19 = 19  ' QRCode 93x93
    qrVersion20 = 20  ' QRCode 97x97
    qrVersion21 = 21  ' QRCode 101x101
    qrVersion22 = 22  ' QRCode 105x105
    qrVersion23 = 23  ' QRCode 109x109
    qrVersion24 = 24  ' QRCode 113x113
    qrVersion25 = 25  ' QRCode 117x117
    qrVersion26 = 26  ' QRCode 121x121
    qrVersion27 = 27  ' QRCode 125x125
    qrVersion28 = 28  ' QRCode 129x129
    qrVersion29 = 29  ' QRCode 133x133
    qrVersion30 = 30  ' QRCode 137x137
    qrVersion31 = 31  ' QRCode 141x141
    qrVersion32 = 32  ' QRCode 145x145
    qrVersion33 = 33  ' QRCode 149x149
    qrVersion34 = 34  ' QRCode 153x153
    qrVersion35 = 35  ' QRCode 157x157
    qrVersion36 = 36  ' QRCode 161x161
    qrVersion37 = 37  ' QRCode 165x165
    qrVersion38 = 38  ' QRCode 169x169
    qrVersion39 = 39  ' QRCode 173x173
    qrVersion40 = 40  ' QRCode 177x177
  End Enum


  Private mvarLevel As vbQRErrorLevel      '' Levels of error correction. See definitions for possible values.
  Private mvarEncodingMode As vbQREncoding '' Encoding mode.
  Private mvarCaseSensitive As Boolean     '' Boolean flag, if true the input string will be converted to uppercase.
  Private mvarShowMarkers As Boolean       '' Boolean flag, if true all markers will have a specific value.
  Private mvarQuietZone As Short           '' size, in module, of Quiet Zone
    <CodeAnalysis.SuppressMessage("Performance", "CA1814:Preferire matrici di matrici rispetto a matrici multidimensionali", Justification:="<In sospeso>")>
    Private mvarFinal(,) As Short            '' Barcode array to be returned which is readable by VB.
    Private mvarFindBestMask As Boolean      '' default is true and estimates best mask (but extremally slow), set to false to significant performance boost but (propably) worst quality code
  Private mvarVersion As Short             '' QR code version. Size of QRcode is defined as version. Version is from -3 to 40. Version M1, M2, M3, M4, version 1 is 21*21 matrix. And 4 modules increases whenever 1 version increases. So version 40 is 177*177 matrix.
  Private mvarSize As Short                '' size, in module, of QRCode matrix
  Private mvarApplyTilde As Boolean        '' Boolean flag, if true the input string will decode for ~dNNN and ~hXX special char encoding.
  Private mvarUTF8 As Boolean              '' Boolean flag, if true the input string use a UTF8 charset.

  Private mvarDataLen As Integer
  Private mvarTextData As String '' Input data string.
  Private mvarBitCount() As Object
  Private mvarEcw() As Object
  Private mvarEcb() As Object
  Private mvarEcc() As Object
  Private mvarLg() As Short
  Private mvarEx() As Short
  Private mvarCodeInfo(43) As Object
  Private mvarPattern() As Object
  Private mvarData() As Byte
#Disable Warning CA1814 ' Preferire matrici di matrici rispetto a matrici multidimensionali
    Private mvarMatrix(,) As Byte
#Enable Warning CA1814 ' Preferire matrici di matrici rispetto a matrici multidimensionali

    Private mvarShowLogo As Boolean
    Private mvarLogo() As String

  Private Const Alphanum As String = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ $%*+-./:"


  Public Sub New()
    MyBase.New()

      '# of bits of count indicator
    mvarBitCount = New Object() { _
                    New Short() {10, 12, 14}, _
                    New Short() {9, 11, 13}, _
                    New Short() {8, 16, 16}, _
                    New Short() {8, 10, 12} _
                   }

    ' error correction words L,M,Q,H for all version sizes (99=N/A)
    mvarEcw = New Object() { _
                New Short() {2, 5, 6, 8, 7, 10, 15, 20, 26, 18, 20, 24, 30, 18, 20, 24, 26, 30, 22, 24, 28, 30, 28, 28, 28, 28, 30, 30, 26, 28, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30}, _
                New Short() {99, 6, 8, 10, 10, 16, 26, 18, 24, 16, 18, 22, 22, 26, 30, 22, 22, 24, 24, 28, 28, 26, 26, 26, 26, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28, 28}, _
                New Short() {99, 99, 99, 14, 13, 22, 18, 26, 18, 24, 18, 22, 20, 24, 28, 26, 24, 20, 30, 24, 28, 28, 26, 30, 28, 30, 30, 30, 30, 28, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30}, _
                New Short() {99, 99, 99, 99, 17, 28, 22, 16, 22, 28, 26, 26, 24, 28, 24, 28, 22, 24, 24, 30, 28, 28, 26, 28, 30, 24, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30} _
              }

    ' error correction blocks L,M,Q,H for all version sizes (99=N/A)
    mvarEcb = New Object() { _
                New Short() {1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 4, 4, 4, 4, 4, 6, 6, 6, 6, 7, 8, 8, 9, 9, 10, 12, 12, 12, 13, 14, 15, 16, 17, 18, 19, 19, 20, 21, 22, 24, 25}, _
                New Short() {1, 1, 1, 1, 1, 1, 1, 2, 2, 4, 4, 4, 5, 5, 5, 8, 9, 9, 10, 10, 11, 13, 14, 16, 17, 17, 18, 20, 21, 23, 25, 26, 28, 29, 31, 33, 35, 37, 38, 40, 43, 45, 47, 49}, _
                New Short() {1, 1, 1, 1, 1, 1, 2, 2, 4, 4, 6, 6, 8, 8, 8, 10, 12, 16, 12, 17, 16, 18, 21, 20, 23, 23, 25, 27, 29, 34, 34, 35, 38, 40, 43, 45, 48, 51, 53, 56, 59, 62, 65, 68}, _
                New Short() {1, 1, 1, 1, 1, 1, 2, 4, 4, 4, 5, 6, 8, 8, 11, 11, 16, 16, 18, 16, 19, 21, 25, 25, 25, 34, 30, 32, 35, 37, 40, 42, 45, 48, 51, 54, 57, 60, 63, 66, 70, 74, 77, 81} _
              }

    ' error correction
    mvarEcc = New Object() { _
                New Short() {2, 5, 6, 8, 7, 10, 15, 20, 26, 36, 40, 48, 60, 72, 80, 96, 104, 120, 132, 144, 168, 180, 196, 224, 224, 252, 270, 300, 312, 336, 360, 390, 420, 450, 480, 510, 540, 570, 570, 600, 630, 660, 720, 750}, _
                New Short() {99, 6, 8, 10, 10, 16, 26, 36, 48, 64, 72, 88, 110, 130, 150, 176, 198, 216, 240, 280, 308, 338, 364, 416, 442, 476, 504, 560, 588, 644, 700, 728, 784, 812, 868, 924, 980, 1036, 1064, 1120, 1204, 1260, 1316, 1372}, _
                New Short() {99, 99, 99, 14, 13, 22, 36, 52, 72, 96, 108, 132, 160, 192, 224, 260, 288, 320, 360, 408, 448, 504, 546, 600, 644, 690, 750, 810, 870, 952, 1020, 1050, 1140, 1200, 1290, 1350, 1440, 1530, 1590, 1680, 1770, 1860, 1950, 2040}, _
                New Short() {99, 99, 99, 99, 17, 28, 44, 64, 88, 112, 130, 156, 192, 224, 264, 308, 352, 384, 432, 480, 532, 588, 650, 700, 750, 816, 900, 960, 1050, 1110, 1200, 1260, 1350, 1440, 1530, 1620, 1710, 1800, 1890, 1980, 2100, 2220, 2310, 2430} _
              }


    ' log/exp table
    mvarEx = New Short() {1, 2, 4, 8, 16, 32, 64, 128, 29, 58, 116, 232, 205, 135, 19, 38, 76, 152, 45, 90, 180, 117, 234, 201, 143, 3, 6, 12, 24, 48, 96, 192, 157, 39, 78, 156, 37, 74, 148, 53, 106, 212, 181, 119, 238, 193, 159, 35, 70, 140, 5, 10, 20, 40, 80, 160, 93, 186, 105, 210, 185, 111, 222, 161, 95, 190, 97, 194, 153, 47, 94, _
                  188, 101, 202, 137, 15, 30, 60, 120, 240, 253, 231, 211, 187, 107, 214, 177, 127, 254, 225, 223, 163, 91, 182, 113, 226, 217, 175, 67, 134, 17, 34, 68, 136, 13, 26, 52, 104, 208, 189, 103, 206, 129, 31, 62, 124, 248, 237, 199, 147, 59, 118, 236, 197, 151, 51, 102, 204, 133, 23, 46, 92, 184, 109, 218, 169, 79, 158, 33, 66, 132, 21, 42, 84, _
                  168, 77, 154, 41, 82, 164, 85, 170, 73, 146, 57, 114, 228, 213, 183, 115, 230, 209, 191, 99, 198, 145, 63, 126, 252, 229, 215, 179, 123, 246, 241, 255, 227, 219, 171, 75, 150, 49, 98, 196, 149, 55, 110, 220, 165, 87, 174, 65, 130, 25, 50, 100, 200, 141, 7, 14, 28, 56, 112, 224, 221, 167, 83, 166, 81, 162, 89, 178, 121, 242, 249, 239, 195, _
                  155, 43, 86, 172, 69, 138, 9, 18, 36, 72, 144, 61, 122, 244, 245, 247, 243, 251, 235, 203, 139, 11, 22, 44, 88, 176, 125, 250, 233, 207, 131, 27, 54, 108, 216, 173, 71, 142, 0}
    mvarLg = New Short() {0, 0, 1, 25, 2, 50, 26, 198, 3, 223, 51, 238, 27, 104, 199, 75, 4, 100, 224, 14, 52, 141, 239, 129, 28, 193, 105, 248, 200, 8, 76, 113, 5, 138, 101, 47, 225, 36, 15, 33, 53, 147, 142, 218, 240, 18, 130, 69, 29, 181, 194, 125, 106, 39, 249, 185, 201, 154, 9, 120, 77, 228, 114, 166, 6, 191, 139, 98, 102, 221, 48, _
                  253, 226, 152, 37, 179, 16, 145, 34, 136, 54, 208, 148, 206, 143, 150, 219, 189, 241, 210, 19, 92, 131, 56, 70, 64, 30, 66, 182, 163, 195, 72, 126, 110, 107, 58, 40, 84, 250, 133, 186, 61, 202, 94, 155, 159, 10, 21, 121, 43, 78, 212, 229, 172, 115, 243, 167, 87, 7, 112, 192, 247, 140, 128, 99, 13, 103, 74, 222, 237, 49, 197, 254, 24, _
                  227, 165, 153, 119, 38, 184, 180, 124, 17, 68, 146, 217, 35, 32, 137, 46, 55, 63, 209, 91, 149, 188, 207, 205, 144, 135, 151, 178, 220, 252, 190, 97, 242, 86, 211, 171, 20, 42, 93, 158, 132, 60, 57, 83, 71, 109, 65, 162, 31, 45, 67, 216, 183, 123, 164, 118, 196, 23, 73, 236, 127, 12, 111, 246, 108, 161, 59, 82, 41, 157, 85, 170, 251, _
                  96, 134, 177, 187, 204, 62, 90, 203, 89, 95, 176, 156, 169, 160, 81, 11, 245, 22, 235, 122, 117, 44, 215, 79, 174, 213, 233, 230, 231, 173, 232, 116, 214, 244, 234, 168, 80, 88, 175, 0}


    ' array of code info
    mvarCodeInfo(0) = New Object() {11, &H28, 4, New Short() {3, 2, 2, 1}}
    mvarCodeInfo(1) = New Object() {13, &H54, 1, New Short() {4, 3, 3, 2}}
    mvarCodeInfo(2) = New Object() {15, &H88, 6, New Short() {5, 4, 4, 3}}
    mvarCodeInfo(3) = New Object() {17, &HC4, 3, New Short() {6, 5, 5, 4}}
    mvarCodeInfo(4) = New Object() {21, &HD0, 4, New Short() {10, 9, 8, 8}}
    mvarCodeInfo(5) = New Object() {25, &H167, 4, New Short() {10, 9, 8, 8}}
    mvarCodeInfo(6) = New Object() {29, &H237, 4, New Short() {10, 9, 8, 8}}
    mvarCodeInfo(7) = New Object() {33, &H327, 4, New Short() {10, 9, 8, 8}}
    mvarCodeInfo(8) = New Object() {37, &H437, 4, New Short() {10, 9, 8, 8}}
    mvarCodeInfo(9) = New Object() {41, &H567, 4, New Short() {10, 9, 8, 8}}
    mvarCodeInfo(10) = New Object() {45, &H620, 4, New Short() {10, 9, 8, 8}}
    mvarCodeInfo(11) = New Object() {49, &H790, 4, New Short() {10, 9, 8, 8}}
    mvarCodeInfo(12) = New Object() {53, &H920, 4, New Short() {10, 9, 8, 8}}
    mvarCodeInfo(13) = New Object() {57, &HAD0, 4, New Short() {12, 11, 16, 10}}
    mvarCodeInfo(14) = New Object() {61, &HCA0, 4, New Short() {12, 11, 16, 10}}
    mvarCodeInfo(15) = New Object() {65, &HE90, 4, New Short() {12, 11, 16, 10}}
    mvarCodeInfo(16) = New Object() {69, &H10A0, 4, New Short() {12, 11, 16, 10}}
    mvarCodeInfo(17) = New Object() {73, &H122B, 4, New Short() {12, 11, 16, 10}}
    mvarCodeInfo(18) = New Object() {77, &H147B, 4, New Short() {12, 11, 16, 10}}
    mvarCodeInfo(19) = New Object() {81, &H16EB, 4, New Short() {12, 11, 16, 10}}
    mvarCodeInfo(20) = New Object() {85, &H197B, 4, New Short() {12, 11, 16, 10}}
    mvarCodeInfo(21) = New Object() {89, &H1C2B, 4, New Short() {12, 11, 16, 10}}
    mvarCodeInfo(22) = New Object() {93, &H1EFB, 4, New Short() {12, 11, 16, 10}}
    mvarCodeInfo(23) = New Object() {97, &H21EB, 4, New Short() {12, 11, 16, 10}}
    mvarCodeInfo(24) = New Object() {101, &H2424, 4, New Short() {12, 11, 16, 10}}
    mvarCodeInfo(25) = New Object() {105, &H2754, 4, New Short() {12, 11, 16, 10}}
    mvarCodeInfo(26) = New Object() {109, &H2AA4, 4, New Short() {12, 11, 16, 10}}
    mvarCodeInfo(27) = New Object() {113, &H2E14, 4, New Short() {12, 11, 16, 10}}
    mvarCodeInfo(28) = New Object() {117, &H31A4, 4, New Short() {12, 11, 16, 10}}
    mvarCodeInfo(29) = New Object() {121, &H3554, 4, New Short() {12, 11, 16, 10}}
    mvarCodeInfo(30) = New Object() {125, &H3924, 4, New Short() {14, 13, 16, 12}}
    mvarCodeInfo(31) = New Object() {129, &H3C0B, 4, New Short() {14, 13, 16, 12}}
    mvarCodeInfo(32) = New Object() {133, &H401B, 4, New Short() {14, 13, 16, 12}}
    mvarCodeInfo(33) = New Object() {137, &H444B, 4, New Short() {14, 13, 16, 12}}
    mvarCodeInfo(34) = New Object() {141, &H489B, 4, New Short() {14, 13, 16, 12}}
    mvarCodeInfo(35) = New Object() {145, &H4D0B, 4, New Short() {14, 13, 16, 12}}
    mvarCodeInfo(36) = New Object() {149, &H519B, 4, New Short() {14, 13, 16, 12}}
    mvarCodeInfo(37) = New Object() {153, &H564B, 4, New Short() {14, 13, 16, 12}}
    mvarCodeInfo(38) = New Object() {157, &H59E0, 4, New Short() {14, 13, 16, 12}}
    mvarCodeInfo(39) = New Object() {161, &H5ED0, 4, New Short() {14, 13, 16, 12}}
    mvarCodeInfo(40) = New Object() {165, &H63E0, 4, New Short() {14, 13, 16, 12}}
    mvarCodeInfo(41) = New Object() {169, &H6910, 4, New Short() {14, 13, 16, 12}}
    mvarCodeInfo(42) = New Object() {173, &H6E60, 4, New Short() {14, 13, 16, 12}}
    mvarCodeInfo(43) = New Object() {177, &H73D0, 4, New Short() {14, 13, 16, 12}}


    mvarPattern = New Object() { _
                  New Short() {383, 321, 349, 349, 349, 321, 383, 256, 511}, _
                  New Short() {256, 383, 321, 349, 349, 349, 321, 383}, _
                  New Short() {254, 130, 186, 186, 186, 130, 254, 0, 255}, _
                  New Short() {31, 17, 21, 17, 31} _
                  }


    mvarLevel = vbQRErrorLevel.qrLevelL
    mvarEncodingMode = vbQREncoding.qrEncAuto
    mvarCaseSensitive = True
    mvarShowMarkers = False
    mvarQuietZone = 2
    mvarFindBestMask = True
    mvarApplyTilde = False

  End Sub

  '---------------------------------------------------------------------------------------
  ' Proprietà : ShowMarkers
  '---------------------------------------------------------------------------------------
  Public WriteOnly Property ShowMarkers() As Boolean
    Set(ByVal Value As Boolean)
      mvarShowMarkers = Value
    End Set
  End Property

  '---------------------------------------------------------------------------------------
  ' Proprietà : FindBestMask
  '---------------------------------------------------------------------------------------
  Public WriteOnly Property FindBestMask() As Boolean
    Set(ByVal Value As Boolean)
      mvarFindBestMask = Value
    End Set
  End Property

  '---------------------------------------------------------------------------------------
  ' Proprietà : UTF8
  '---------------------------------------------------------------------------------------
  Public WriteOnly Property UTF8() As Boolean
    Set(ByVal Value As Boolean)
      mvarUTF8 = Value
    End Set
  End Property

  '---------------------------------------------------------------------------------------
  ' Proprietà : CaseSensitive
  '---------------------------------------------------------------------------------------
  Public WriteOnly Property CaseSensitive() As Boolean
    Set(ByVal Value As Boolean)
      mvarCaseSensitive = Value
    End Set
  End Property

  '---------------------------------------------------------------------------------------
  ' Proprietà : ApplyTilde
  '---------------------------------------------------------------------------------------
  Public WriteOnly Property ApplyTilde() As Boolean
    Set(ByVal Value As Boolean)
      mvarApplyTilde = Value
    End Set
  End Property

  '---------------------------------------------------------------------------------------
  ' Proprietà : QuietZone
  '---------------------------------------------------------------------------------------
  Public WriteOnly Property QuietZone() As Integer
    Set(ByVal Value As Integer)
      mvarQuietZone = Value
    End Set
  End Property


  '---------------------------------------------------------------------------------------
  ' Proprietà : EncodingMode
  ' Risultato : Restituisce l'impostazione del livello di errore
  '---------------------------------------------------------------------------------------
  Public WriteOnly Property EncodingMode() As vbQREncoding
    Set(ByVal Value As vbQREncoding)
      mvarEncodingMode = Value
    End Set
  End Property

  '---------------------------------------------------------------------------------------
  ' Proprietà : ErrorLevel
  ' Risultato : Restituisce l'impostazione del livello di errore
  '---------------------------------------------------------------------------------------
  Public WriteOnly Property ErrorLevel() As vbQRErrorLevel
    Set(ByVal Value As vbQRErrorLevel)
      mvarLevel = Value
    End Set
  End Property

  ' Proprietà : Version
  ' Risultato : Restituisce l'impostazione del livello di errore
  '---------------------------------------------------------------------------------------
  Public WriteOnly Property Version() As vbQRVersion
    Set(ByVal Value As vbQRVersion)
      mvarVersion = Value
    End Set
  End Property

    '---------------------------------------------------------------------------------------
    ' Matrix (Read-Only)
    '---------------------------------------------------------------------------------------
    <CodeAnalysis.SuppressMessage("Performance", "CA1814:Preferire matrici di matrici rispetto a matrici multidimensionali", Justification:="<In sospeso>")>
    Public ReadOnly Property Matrix() As Short(,)
        Get
            Matrix = mvarFinal
        End Get
    End Property

    '---------------------------------------------------------------------------------------
    ' Size (Read-Only)
    '---------------------------------------------------------------------------------------
    Public ReadOnly Property Size() As Short
    Get
      Return mvarSize
    End Get
  End Property

  Public Function GetFont() As String

      Dim sRow As String
      Dim sTemp As String
      Dim j As Integer
      Dim i As Integer
      Dim FontStr As String

      FontStr = " " & ChrW(&H2584) & ChrW(&H2580) & ChrW(&H2588) ' " ▄▀█" 

      '' Matrix to string
      '' The font is painted 2 rows at a time from left to right
      sTemp = ""
      sRow = ""

      For j = 0 To mvarSize - 1 Step 2
        sRow = ""
        For i = 0 To mvarSize - 1
          If mvarFinal(j, i) = 0 Then
            If j + 1 < mvarSize Then
              If mvarFinal(j + 1, i) = 0 Then
                sRow = sRow & Mid(FontStr, 1, 1)
              Else
                sRow = sRow & Mid(FontStr, 2, 1)
              End If
            Else
              sRow = sRow & Mid(FontStr, 1, 1)
            End If
          Else
            If j + 1 < mvarSize Then
              If mvarFinal(j + 1, i) = 0 Then
                sRow = sRow & Mid(FontStr, 3, 1)
              Else
                sRow = sRow & Mid(FontStr, 4, 1)
              End If
            Else
              sRow = sRow & Mid(FontStr, 3, 1)
            End If
          End If

        Next
        sTemp = sTemp & sRow & vbCrLf
      Next

      GetFont = sTemp

  End Function

  Public Function GetEPS(ByVal ModuleSize As Short) As String

    Dim strEPS As String
    Dim Y As Short
    Dim X As Short
    Dim n As Short


    strEPS = "%!PS-Adobe-3.0 EPSF-3.0" & vbCrLf
    strEPS = strEPS & "%%Creator: vbQRCode 2020.2" & vbCrLf
    strEPS = strEPS & "%%Title: qrcode" & vbCrLf
    strEPS = strEPS & "%%CreationDate: " & Replace(Format(Now(), "ddd mmm d hh:mm:ss yyyy"), ".", ":") & vbCrLf
    strEPS = strEPS & "%%BoundingBox: 0 0 " & CStr(mvarSize * ModuleSize) & " " & CStr(mvarSize * ModuleSize) & vbCrLf
    strEPS = strEPS & "%%DocumentData: Clean7Bit" & vbCrLf
    strEPS = strEPS & "%%EndComments" & vbCrLf
    strEPS = strEPS & "%%BeginProlog" & vbCrLf
    strEPS = strEPS & "/bd { bind def } bind def" & vbCrLf
    strEPS = strEPS & "/incompound false def" & vbCrLf
    strEPS = strEPS & "/m { moveto } bd" & vbCrLf
    strEPS = strEPS & "/l { lineto } bd" & vbCrLf
    strEPS = strEPS & "/*U { /incompound false def f} bd" & vbCrLf
    strEPS = strEPS & "/k { setcmykcolor } bd" & vbCrLf

    strEPS = strEPS & "/c { curveto } bd" & vbCrLf
    strEPS = strEPS & "/F { incompound not {fill} if } bd" & vbCrLf
    strEPS = strEPS & "/f { closepath F } bd" & vbCrLf
    strEPS = strEPS & "/S { stroke } bd" & vbCrLf
    strEPS = strEPS & "/*u { /incompound true def } bd" & vbCrLf
    strEPS = strEPS & "/K { k } bd" & vbCrLf

    strEPS = strEPS & "%%EndProlog" & vbCrLf
    strEPS = strEPS & "%%BeginSetup" & vbCrLf
    strEPS = strEPS & "%%EndSetup" & vbCrLf
    strEPS = strEPS & "0.000 0.000 0.000 0.000 k" & vbCrLf
    strEPS = strEPS & "0 0 m" & vbCrLf
    strEPS = strEPS & "0 0 l" & vbCrLf
    strEPS = strEPS & CStr(mvarSize * ModuleSize) & " 0 l" & vbCrLf
    strEPS = strEPS & CStr(mvarSize * ModuleSize) & " " & CStr(mvarSize * ModuleSize) & " l" & vbCrLf
    strEPS = strEPS & "0 " & CStr(mvarSize * ModuleSize) & " l" & vbCrLf
    strEPS = strEPS & "f" & vbCrLf
    strEPS = strEPS & "*U" & vbCrLf

    n = mvarSize * ModuleSize
    strEPS = strEPS & "0.000 0.000 0.000 1.000 k" & vbCrLf
    For Y = 0 To mvarSize - 1
      For X = 0 To mvarSize - 1
        If mvarFinal(Y, X) >= 1 Then
          strEPS = strEPS & CStr(X * ModuleSize) & " " & CStr(n - Y * ModuleSize) & " m" & vbCrLf
          strEPS = strEPS & CStr(X * ModuleSize) & " " & CStr(n - Y * ModuleSize) & " l" & vbCrLf
          strEPS = strEPS & CStr((X + 1) * ModuleSize) & " " & CStr(n - Y * ModuleSize) & " l" & vbCrLf
          strEPS = strEPS & CStr((X + 1) * ModuleSize) & " " & CStr(n - (Y + 1) * ModuleSize) & " l" & vbCrLf
          strEPS = strEPS & CStr((X) * ModuleSize) & " " & CStr(n - (Y + 1) * ModuleSize) & " l" & vbCrLf
          strEPS = strEPS & "f" & vbCrLf
        End If
      Next
    Next

    strEPS = strEPS & "*U" & vbCrLf
    strEPS = strEPS & "%%Trailer" & vbCrLf
    strEPS = strEPS & "%%EOF" & vbCrLf


    GetEPS = strEPS
  End Function

  Public Function GetSVG(ByVal ModuleSize As Short) As String
    Dim strSVG As String
    Dim Y As Short
    Dim X As Short

    strSVG = "<?xml version='1.0' standalone='no'?>" & vbCrLf
    strSVG = strSVG & "<!DOCTYPE svg PUBLIC '-//W3C//DTD SVG 1.1//EN' 'http://www.w3.org/Graphics/SVG/1.1/DTD/svg11.dtd'>" & vbCrLf
    strSVG = strSVG & "<svg width='" & CStr(mvarSize * ModuleSize) & "' height='" & CStr(mvarSize * ModuleSize) & "' version='1.1' xmlns='http://www.w3.org/2000/svg'>" & vbCrLf
    strSVG = strSVG & "  <g id='qrcode'>" & vbCrLf
    strSVG = strSVG & "    <g id='background' fill='#ffffff' stroke='#ffffff'><rect x='0' y='0' width='" & (mvarSize * ModuleSize) & "' height='" & CStr(mvarSize * ModuleSize) & "' /></g>" & vbCrLf
    strSVG = strSVG & "    <g id='pattern' fill='#000000' stroke='#000000'>" & vbCrLf
    '' print barcode elements
    For Y = 0 To mvarSize - 1 '' for each row
      For X = 0 To mvarSize - 1 '' for each column
        If mvarFinal(Y, X) >= 1 Then '' draw a single barcode cell
          strSVG = strSVG & "      <g id='R" & CStr(Y) & "C" & CStr(X) & "' ><rect x='" & CStr(X * ModuleSize) & "' y='" & CStr(Y * ModuleSize) & "' width='" & CStr(ModuleSize) & "' height='" & CStr(ModuleSize) & "' /></g>" & vbCrLf
        End If
      Next
    Next
    strSVG = strSVG & "    </g>" & vbCrLf
    strSVG = strSVG & "  </g>" & vbCrLf
    strSVG = strSVG & "</svg>" & vbCrLf

    GetSVG = strSVG

  End Function

  Public Function GetHTML(ByVal ModuleSize As Short) As String

    Dim strHTML As String
    Dim Y As Short
    Dim X As Short

    strHTML = "<div style='font-size:0;background-color:#ffffff;position:relative;width:" & CStr(mvarSize * ModuleSize) & "px;height:" & CStr(mvarSize * ModuleSize) & "px;'>" & vbCrLf
    For Y = 0 To mvarSize - 1 '' for each row
      For X = 0 To mvarSize - 1 '' for each column
        If mvarFinal(Y, X) >= 1 Then '' draw a single barcode cell
          strHTML = strHTML & "  <div style='background-color:#000000;width:" & CStr(ModuleSize) & "px;height:" & CStr(ModuleSize) & "px;position:absolute;left:" & CStr(X * ModuleSize) & "px;top:" & CStr(Y * ModuleSize) & "px;'>&nbsp;</div>" & vbCrLf
        End If
      Next
    Next
    strHTML = strHTML & "</div>" & vbCrLf

    GetHTML = strHTML
  End Function

  Public Function GetBMP(ByVal ModuleSize As Short) As String

    Dim strBMP As String = ""
    Dim Y As Short
    Dim X As Short
    Dim k As Short
    Dim strRow As String = ""
    Dim intTemp As Short
    Dim strPad As String = ""

    Dim bBlack As String
    Dim bWhite As String

    Dim BMPQuality As Short = 1

    BMPQuality = Int(ModuleSize / 8)
    If BMPQuality < 1 Then BMPQuality = 1

    ModuleSize = 8 * BMPQuality

    bBlack = New String(Convert.ToChar(&HFF), BMPQuality)
    bWhite = New String(Convert.ToChar(&H0), BMPQuality)

    ''Dim size As Integer

    ''size = mvarSize * ModuleSize
    intTemp = mvarSize * BMPQuality Mod 4
    If intTemp <> 0 Then strPad = New String(Convert.ToChar(&H0), 4 - intTemp)

    strBMP = "BM" & New String(Convert.ToChar(&H0), 8)
    strBMP = strBMP & Convert.ToChar(&H3E) & New String(Convert.ToChar(&H0), 3)
    strBMP = strBMP & Convert.ToChar(&H28) & New String(Convert.ToChar(&H0), 3)
    strBMP = strBMP & Convert.ToChar(CByte((mvarSize * ModuleSize) Mod 256)) & Convert.ToChar(CByte(Int(mvarSize * ModuleSize / 256))) & New String(Convert.ToChar(&H0), 2) '' width
    strBMP = strBMP & Convert.ToChar(CByte((mvarSize * ModuleSize) Mod 256)) & Convert.ToChar(CByte(Int(mvarSize * ModuleSize / 256))) & New String(Convert.ToChar(&H0), 2)  '' height
    strBMP = strBMP & Convert.ToChar(1) & Convert.ToChar(&H0) & Convert.ToChar(1) & Convert.ToChar(&H0)
    strBMP = strBMP & New String(Convert.ToChar(&H0), 8)
    strBMP = strBMP & Convert.ToChar(&H25) & Convert.ToChar(&HE) & Convert.ToChar(&H0) & Convert.ToChar(&H0)
    strBMP = strBMP & Convert.ToChar(&H25) & Convert.ToChar(&HE) & Convert.ToChar(&H0) & Convert.ToChar(&H0)
    strBMP = strBMP & New String(Convert.ToChar(&H0), 8)
    strBMP = strBMP & New String(Convert.ToChar(&HFF), 3)
    strBMP = strBMP & New String(Convert.ToChar(&H0), 5)

    For Y = mvarSize - 1 To 0 Step -1 '' for each row
      strRow = ""
      For X = 0 To mvarSize - 1 '' for each column
        If mvarFinal(Y, X) > 0 Then '' draw a single barcode cell
          strRow = strRow & bBlack
        Else
          strRow = strRow & bWhite
        End If
      Next

      strRow = strRow & strPad
'      strBMP = strBMP & String.Join("", Enumerable.Repeat(strRow, ModuleSize))
      For k = 1 To ModuleSize
        strBMP = strBMP & strRow
      Next
    Next

    GetBMP = strBMP
  End Function


  Public Function GetWMF(ByVal ModuleSize As Short, Optional ByVal Background As Boolean = False) As String

    Dim strWMF As String
    Dim i As Short
    Dim j As Short

    Dim l As Integer
    Dim n As Short

    n = 0

    If ModuleSize < 2 Then ModuleSize = 2

    strWMF = ""
    If Background Then

      '' META_CREATEPENINDIRECT
      n = n + 1
      strWMF = strWMF & Chr(&H8) & Chr(&H0) & Chr(&H0) & Chr(&H0) & _
               Chr(&HFA) & Chr(&H2) & _
               Chr(&H0) & Chr(&H0) & _
               Chr(&H0) & Chr(&H0) & _
               Chr(&H0) & Chr(&H0) & _
               Chr(&HFF) & Chr(&HFF) & Chr(&HFF) & Chr(&H0)

      '' META_SELECTOBJECT
      n = n + 1
      strWMF = strWMF & Chr(&H4) & Chr(&H0) & Chr(&H0) & Chr(&H0) & _
               Chr(&H2D) & Chr(&H1) & _
               Chr(0) & Chr(&H0)

      '' META_CREATEBRUSHINDIRECT
      n = n + 1
      strWMF = strWMF & Chr(&H7) & Chr(&H0) & Chr(&H0) & Chr(&H0) & _
               Chr(&HFC) & Chr(&H2) & _
               Chr(&H0) & Chr(&H0) & _
               Chr(&HFF) & Chr(&HFF) & Chr(&HFF) & Chr(&H0) & _
               Chr(&H0) & Chr(&H0)

      '' META_SELECTOBJECT
      n = n + 1
      strWMF = strWMF & Chr(&H4) & Chr(&H0) & Chr(&H0) & Chr(&H0) & _
               Chr(&H2D) & Chr(&H1) & _
               Chr(&H1) & Chr(&H0)

      '' META_RECTANGLE
      n = n + 1
      strWMF = strWMF & Chr(&H7) & Chr(&H0) & Chr(&H0) & Chr(&H0) & Chr(&H1B) & Chr(&H4) & _
               Chr(CByte((mvarSize * ModuleSize) Mod 256)) & Chr(CByte(Int(mvarSize * ModuleSize / 256))) & _
               Chr(CByte((mvarSize * ModuleSize) Mod 256)) & Chr(CByte(Int(mvarSize * ModuleSize / 256))) & _
               Chr(0) & Chr(0) & _
               Chr(0) & Chr(0)

    End If


    '' META_CREATEPENINDIRECT
    n = n + 1
    strWMF = strWMF & Chr(&H8) & Chr(&H0) & Chr(&H0) & Chr(&H0) & _
             Chr(&HFA) & Chr(&H2) & _
             Chr(&H0) & Chr(&H0) & _
             Chr(&H0) & Chr(&H0) & _
             Chr(&H0) & Chr(&H0) & _
             Chr(&H0) & Chr(&H0) & Chr(&H0) & Chr(&H0)

    '' META_SELECTOBJECT
    n = n + 1
    strWMF = strWMF & Chr(&H4) & Chr(&H0) & Chr(&H0) & Chr(&H0) & _
             Chr(&H2D) & Chr(&H1) & _
             Chr(&H0 + IIf(Background, 2, 0)) & Chr(&H0)

    '' META_CREATEBRUSHINDIRECT
    n = n + 1
    strWMF = strWMF & Chr(&H7) & Chr(&H0) & Chr(&H0) & Chr(&H0) & _
             Chr(&HFC) & Chr(&H2) & _
             Chr(&H0) & Chr(&H0) & _
             Chr(&H0) & Chr(&H0) & Chr(&H0) & Chr(&H0) & _
             Chr(&H0) & Chr(&H0)

    '' META_SELECTOBJECT
    n = n + 1
    strWMF = strWMF & Chr(&H4) & Chr(&H0) & Chr(&H0) & Chr(&H0) & _
             Chr(&H2D) & Chr(&H1) & _
             Chr(&H1 + IIf(Background, 2, 0)) & Chr(&H0)

    For i = 0 To mvarSize - 1
      For j = 0 To mvarSize - 1
        If mvarFinal(i, j) >= 1 Then
          n = n + 1
          '' META_RECTANGLE
          strWMF = strWMF & Chr(&H7) & Chr(&H0) & Chr(&H0) & Chr(&H0) & Chr(&H1B) & Chr(&H4) & _
                   Chr(CByte(((i + 1) * ModuleSize) Mod 256)) & Chr(CByte(Int((i + 1) * ModuleSize / 256))) & _
                   Chr(CByte(((j + 1) * ModuleSize) Mod 256)) & Chr(CByte(Int((j + 1) * ModuleSize / 256))) & _
                   Chr(CByte((i * ModuleSize) Mod 256)) & Chr(CByte(Int(i * ModuleSize / 256))) & _
                   Chr(CByte((j * ModuleSize) Mod 256)) & Chr(CByte(Int(j * ModuleSize / 256)))
        End If
      Next
    Next

    n = n + 1
      '' META_SETWINDOWEXT
    strWMF = strWMF & Chr(&H5) & Chr(&H0) & Chr(&H0) & Chr(&H0) & _
             Chr(&HC) & Chr(&H2) & _
             Chr(CByte(mvarSize * ModuleSize Mod 256)) & Chr(CByte(Int(mvarSize * ModuleSize / 256))) & _
             Chr(CByte(mvarSize * ModuleSize Mod 256)) & Chr(CByte(Int(mvarSize * ModuleSize / 256)))

    n = n + 1
      '' META_SETWINDOWORG
    strWMF = strWMF & Chr(&H5) & Chr(&H0) & Chr(&H0) & Chr(&H0) & _
             Chr(&HB) & Chr(&H2) & _
             Chr(0) & Chr(0) & _
             Chr(0) & Chr(0)


    '' META_EOF
    strWMF = strWMF & Chr(&H3) & Chr(&H0) & Chr(&H0) & Chr(&H0) & Chr(&H0) & Chr(&H0)

    l = Len(strWMF) + 18

    '' META_HEADER Record
    strWMF = Chr(&H1) & Chr(&H0) & _
             Chr(&H9) & Chr(&H0) & _
             Chr(&H0) & Chr(&H3) & _
             Chr(CByte(l Mod 256)) & Chr(CByte(Int(l / 256))) & Chr(&H0) & Chr(&H0) & _
             Chr(CByte(n Mod 256)) & Chr(CByte(Int(n / 256))) & _
             Chr(&HC) & Chr(&H0) & Chr(&H0) & Chr(&H0) & _
             Chr(&H0) & Chr(&H0) & _
             strWMF

      GetWMF = strWMF


  End Function


  Public Sub ToPrinter(ByRef Obj As Object, PosX As Double, PosY As Double, ModuleSize As Double)

      Dim x As Integer = 0
      Dim y As Integer = 0
      Dim pX As Double = 0
      Dim pY As Double = 0
      Dim oX As Double = 0
      Dim oY As Double = 0
      Dim w As Double = 0

      Dim oldPageUnit As Integer = 0
      Dim oldPageScale As Double = 0

      oldPageUnit = Obj.Graphics.PageUnit
      oldPageScale = Obj.Graphics.PageScale

      Obj.Graphics.PageUnit = GraphicsUnit.Millimeter
      Obj.Graphics.PageScale = 0.001

      w = ModuleSize * 1000
      oX = PosX * 1000
      oY = PosY * 1000

      For y = 0 To mvarSize - 1
        For x = 0 To mvarSize - 1
          pX = (x * w + oX)
          pY = (y * w + oY)
          If Matrix(y, x) > 0 Then Obj.Graphics.FillRectangle(Brushes.Black, CInt(pX), CInt(pY), CInt(w), CInt(w))
        Next
      Next

      Obj.Graphics.PageUnit = oldPageUnit
      Obj.Graphics.PageScale = oldPageScale


  End Sub

  Public Sub AddLogo(ByRef logo() As String)
    mvarShowLogo = True
    mvarLogo = logo
  End Sub


  '' QRCode 2005 2D code symbol creation according ISO/IEC 18004:2006
  '' Encode a text
  Public Function Encode(ByVal value As String) As vbQRError


    '' supporto per caratteri UTF8
    If mvarUTF8 Then value = zzFromUTF8(value)

    mvarTextData = value
        If mvarApplyTilde Then mvarTextData = ZzApplyTilde(mvarTextData)
        mvarDataLen = Len(mvarTextData)

        If mvarDataLen = 0 Then
            Encode = vbQRError.qrNoError
        Else
            If (Not mvarCaseSensitive) Then mvarTextData = UCase(mvarTextData)

            If mvarEncodingMode = vbQREncoding.qrEncAuto Then mvarEncodingMode = zzBestEncoding()
            mvarVersion = zzFinMinimunVersion(mvarVersion)

            If mvarVersion > 40 Then
                Encode = vbQRError.qrTooManyData
            Else
                mvarSize = mvarCodeInfo(mvarVersion + 3)(0) ' symbol size

                Call zzEncodeData()
                Call zzMakePattern()
                Call zzPutWords(zzReedSolomon())
                Call zzPutMask(zzGetBestMask())
                If mvarShowMarkers Then Call zzShowMarkers()

                If mvarShowLogo Then

                    Dim xDimLogo As Short
                    Dim yDimLogo As Short
                    Dim Y As Short
                    Dim X As Short

                    yDimLogo = UBound(mvarLogo)
                    For Y = 0 To yDimLogo
                        xDimLogo = Len(mvarLogo(Y))
                        For X = 0 To xDimLogo - 1
                            If (Mid(mvarLogo(Y), X + 1, 1) <> " ") Then mvarFinal(Y + Int((mvarSize - yDimLogo) / 2), X + Int((mvarSize - xDimLogo) / 2)) = Val(Mid(mvarLogo(Y), X + 1, 1))
                        Next
                    Next

                End If

                Encode = vbQRError.qrNoError
            End If
        End If
    End Function

    Private Shared Function ZzApplyTilde(code As String) As String
        Dim i As Short
        Dim cTilde As Short
        Dim longi As Short
        Dim result As String
        Dim justTilde As Boolean
        Dim ascString As String
        Dim asc As Short
        Dim nextc As Short

        result = ""
        longi = Len(code)
        cTilde = 0
        justTilde = True

        For i = 0 To longi - 1
            'Check for ~~, ~dnnn or ~hxx
            cTilde = AscW(Mid(code, i + 1, 1))
            justTilde = True
            If cTilde = 126 Then
                ' process special cases
                If i < longi - 3 Then
                    nextc = AscW(Mid(code, i + 2, 1))

                    If nextc = 126 Then
                        ' ~~
                        result = result + "~"
                        justTilde = False
                        i = i + 1
                    ElseIf nextc = 100 And i < longi - 3 And (IsNumeric(Mid(code, i + 3, 3))) Then
                        ' ~dNNN if ~d and next 3 chars are a number
                        If i < longi - 3 Then
                            ascString = Mid(code, i + 3, 3)
                            asc = Val(ascString)
                            If asc > 255 Then
                                asc = 255
                            End If
                            ' the ascii value using Chr instead of ChrW because with ChrW ~d130 to ~d150 encodes the "?" character
                            result = result + Chr(asc)
                            justTilde = False
                            i = i + 4
                        End If
                    ElseIf nextc = 104 And i < longi - 2 Then 'And (IsNumeric(Mid(code, i + 3, 3))) Then
                        ' ~hXX if ~h and next 2 chars are hex
                        If i < longi - 2 Then
                            ascString = Mid(code, i + 3, 2)
                            asc = Val("&h" & ascString)
                            ' the ascii value using Chr instead of ChrW because with ChrW ~d130 to ~d150 encodes the "?" character
                            result = result + Chr(asc)
                            justTilde = False
                            i = i + 3
                        End If
                    Else
                        'tilde character, followed by anthing other than the casses above is just a tilde character
                        result = result + ChrW(cTilde)
                    End If
                    'tilde character, followed by anthing other than the casses above is just a tilde character
                    'If justTilde = True Then
                    '  result = result & ChrW(126)
                    'End If
                End If
            Else
                ' no escape
                result = result + ChrW(cTilde)
            End If
        Next i
        ZzApplyTilde = result
        'end applyTilde
    End Function

    Private Sub zzEncodeData()
    Dim v As Double
    Dim c As Integer
    Dim eb As Integer
    Dim el As Integer

    Dim k As Integer
    Dim i As Integer
    Dim j As Integer

    el = mvarCodeInfo(mvarVersion + 3)(1) \ 8 - mvarEcw(mvarLevel)(mvarVersion + 3) * mvarEcb(mvarLevel)(mvarVersion + 3)
    ReDim mvarData(el + mvarEcw(mvarLevel)(mvarVersion + 3) * mvarEcb(mvarLevel)(mvarVersion + 3))

    c = 0 ' encode head indicator bits
    If mvarVersion > 0 Then
      v = 2 ^ mvarEncodingMode
      eb = 4
    Else
      v = mvarEncodingMode
      eb = mvarVersion + 3 ' mode indicator
    End If

    k = mvarCodeInfo(mvarVersion + 3)(3)(mvarEncodingMode)

    eb = eb + k
    v = v * 2 ^ k + mvarDataLen ' character count indicator
    For i = 1 To mvarDataLen ' encode data
        Select Case mvarEncodingMode
        Case 0 ' numeric
            v = v * IIf(i + 1 < mvarDataLen, 1024, IIf(i < mvarDataLen, 128, 16)) + Val(Mid(mvarTextData, i, 3))
            eb = eb + IIf(i + 1 < mvarDataLen, 10, 4 + 3 * (mvarDataLen - i)) : i = i + 2
        Case 1 ' alphanumeric
            j = InStr(Alphanum, Mid(mvarTextData, i, 1)) - 1
            If i < mvarDataLen Then j = 45 * j + InStr(Alphanum, Mid(mvarTextData, i + 1, 1)) - 1
            v = v * IIf(i < mvarDataLen, 2048, 64) + j
            eb = eb + IIf(i < mvarDataLen, 11, 6)
            i = i + 1
        Case 2 ' binary
            v = v * 256 + Asc(Mid(mvarTextData, i, 1))
            eb = eb + 8
        End Select
        For eb = eb To 8 Step -8 ' add data to bit stream
            j = 2 ^ (eb - 8)
            mvarData(c) = v \ j
            v = v - mvarData(c) * j : c = c + 1
        Next eb
    Next i

    If el > c Then i = IIf(mvarVersion > 0, 4, mvarVersion + 6) : v = v * 2 ^ i : eb = eb + i ' terminator
    mvarData(c) = (v * 256) \ 2 ^ eb : c = c + 1 : mvarData(c) = ((v * 65536) \ 2 ^ eb) And 255
    If eb > 8 And el >= c Then c = c + 1 ' bit padding
    If (mvarVersion And -3) = -3 And el = c Then mvarData(c) = mvarData(c) \ 16 ' M1,M3: shift high bits to low nibble
    If (mvarVersion < 1) Then c = c + 1

    i = 236
    For c = c To el - 1 ' byte padding
        mvarData(c) = IIf((mvarVersion And -3) = -3 And c = el - 1, 0, i)
        i = i Xor 236 Xor 17
    Next c

  End Sub

  Private Function zzFinMinimunVersion(Version As Short) As Short
    Dim j As Short
    Dim el As Integer
    Dim i As Short
    Dim k As Short
    Dim w As Integer

    If Version = 0 Then
      Version = 1
    Else
      If Version < 0 Then Version = Version + 1
    End If

    If Version <= 0 Then
      If Version = -3 And mvarEncodingMode <> 0 Then Version = Version + 1
      If Version = -2 And mvarEncodingMode = 2 Then Version = Version + 1
      If Version < 0 And mvarLevel = 2 Then Version = 0
    End If

    Version = Version - 1
    w = Int(mvarDataLen * New Short() {10 / 3, 11 / 2, 8, 13}(mvarEncodingMode) + 0.5) ' 3 digits in 10 bits, 2 chars in 11 bits, 1 byte, 13 bits/byte
    Do ' compute QR minimun version
      Version = Version + 1
      If Version > 40 Then Exit Do ' "Message too long"
      j = mvarEcc(mvarLevel)(Version + 3)          ' error correction
      el = mvarCodeInfo(Version + 3)(1)      ' finder, version, format
      i = mvarCodeInfo(Version + 3)(2)       ' mode indicator bits, M1+M3: +4 bits
      k = mvarCodeInfo(Version + 3)(3)(mvarEncodingMode) ' count indicator bits
    Loop While ((el \ 8) - j) * 8 < w + i + k
    If (Version = 0 And mvarEncodingMode = 0) And (((el \ 8) - j) * 8 = w + i + k) Then Version = Version + 1

    zzFinMinimunVersion = Version
  End Function

  Function zzGetBestMask() As Short
    Dim m As Integer
    Dim p As Integer
    Dim l As Integer
    Dim k As Byte
    Dim X As Short
    Dim Y As Short
    Dim i As Short
    Dim j As Integer
    Dim w As Short
    Dim c As Short
    Dim k1 As String
    Dim k2 As String
    Dim s As Short

    m = 2

    If mvarFindBestMask Then
      s = mvarCodeInfo(mvarVersion + 3)(0) ' symbol size
      m = 0
      p = 1000000 ' data masking
      For k = 0 To IIf(mvarVersion < 1, 3, 7)
        If mvarVersion < 1 Then ' penalty micro QR
          X = 1
          Y = 1
          For i = 1 To s - 1
            X = X - zzPattern(i, s - 1, k)
            Y = Y - zzPattern(s - 1, i, k)
          Next i
          j = IIf(X > Y, 16 * X + Y, X + 16 * Y)
        Else ' penalty QR
          l = 0 : k2 = "" : j = 0
          For Y = 0 To s - 1 ' horizontal
            c = 0 : i = 0 : k1 = "0000"
            For X = 0 To s - 1
              w = zzPattern(X, Y, k)
              l = l + w : k1 = k1 & w ' rule 4: count darks
              If c = w Then ' same as prev
                i = i + 1
                If X And Mid(k2, X + 4, 2) = c & c Then j = j + 3 ' rule 2: block 2x2
              Else
                If i > 5 Then j = j + i - 2 ' rule 1: >5 adjacent
                c = 1 - c : i = 1
              End If
            Next X
            If i > 5 Then j = j + i - 2 ' rule 1: >5 adjacent
            i = 0
            Do ' rule 3: like finder pattern
              i = InStr(i + 4, k1, "1011101")
              If i < 1 Then Exit Do
              If Mid(k1, i - 4, 4) = "0000" Or Mid(k1 & "0000", i + 7, 4) = "0000" Then j = j + 40
            Loop
            k2 = k1 ' rule 2: remember last line
          Next Y
          For X = 0 To s - 1 ' vertical
            c = 0 : i = 0 : k1 = "0000"
            For Y = 0 To s - 1
              w = zzPattern(X, Y, k)
              k1 = k1 & w ' vertical to string
              If c = w Then ' same as prev
                i = i + 1
              Else
                If i > 5 Then j = j + i - 2 ' rule 1: >5 adjacent
                c = 1 - c : i = 1
              End If
            Next Y
            If i > 5 Then j = j + i - 2 ' rule 1: >5 adjacent
            i = 0
            Do ' rule 3: like finder pattern
              i = InStr(i + 4, k1, "1011101")
              If i < 1 Then Exit Do
              If Mid(k1, i - 4, 4) = "0000" Or Mid(k1 & "0000", i + 7, 4) = "0000" Then j = j + 40
            Loop
          Next X
          j = j + Int(Math.Abs(10 - 20 * l / (s * s))) * 10 ' rule 4: darks
        End If
        If j < p Then p = j : m = k ' take mask of lower penalty
      Next k
    End If
    zzGetBestMask = m

  End Function

  Private Sub zzMakePattern()
    Dim X As Short
    Dim Y As Short
    Dim a As Short
    Dim i As Short
    Dim j As Short
    Dim c As Short
    Dim p As Byte
    Dim m As Short
    Dim k As Short


    ReDim mvarMatrix(mvarSize - 1, mvarSize - 1)

    ' fill QR matrix
    For i = 8 To mvarCodeInfo(mvarVersion + 3)(0) - 1 ' timing pattern
      mvarMatrix(i, IIf(mvarVersion < 1, 0, 6)) = i And 1 Xor 3
      mvarMatrix(IIf(mvarVersion < 1, 0, 6), i) = i And 1 Xor 3
    Next i
    If mvarVersion > 6 Then ' reserve version area
      For i = 0 To 17
        mvarMatrix(i \ 3, mvarCodeInfo(mvarVersion + 3)(0) - 11 + i Mod 3) = 2
        mvarMatrix(mvarCodeInfo(mvarVersion + 3)(0) - 11 + i Mod 3, i \ 3) = 2
      Next i
    End If


    If mvarVersion < 1 Then
      a = 1
    ElseIf mvarVersion < 2 Then
      a = 2
    Else
      a = mvarVersion \ 7 + 2
    End If

    For X = 1 To a ' layout finder/align pattern
      For Y = 1 To a
        If X = 1 And Y = 1 Then ' finder upper left
          i = 0
          j = 0
          p = 0
        ElseIf X = 1 And Y = a Then  ' finder lower left
          i = 0
          j = mvarCodeInfo(mvarVersion + 3)(0) - 8
          p = 1
        ElseIf X = a And Y = 1 Then  ' finder upper right
          i = mvarCodeInfo(mvarVersion + 3)(0) - 8
          j = 0
          p = 2
        Else ' alignment grid
          c = 2 * Int(2 * (mvarVersion + 1) / (1 - a)) ' pattern spacing
          i = IIf(X = 1, 4, mvarCodeInfo(mvarVersion + 3)(0) - 9 + c * (a - X))
          j = IIf(Y = 1, 4, mvarCodeInfo(mvarVersion + 3)(0) - 9 + c * (a - Y))
          p = 3 ' alignment pattern
        End If
        If mvarVersion <> 1 Or X + Y < 4 Then ' no align pattern for version 1
          For c = 0 To UBound(mvarPattern(p)) ' set fixed pattern, reserve space
            m = mvarPattern(p)(c)
            k = 0
            Do
              mvarMatrix(i + k, j + c) = (m And 1) Or 2
              m = m \ 2
              k = k + 1
            Loop While 2 ^ k <= mvarPattern(p)(0)
          Next c
        End If
      Next Y
    Next X

  End Sub

  ' get QR pattern mask
  Private Function zzPattern(ByVal X As Integer, ByVal Y As Integer, ByVal m As Short) As Short
    Dim i As Short, j As Integer
    If mvarVersion < 1 Then m = New Short() {1, 4, 6, 7}(m) ' mask pattern of micro QR
    i = mvarMatrix(X, Y)
    If i < 2 Then
      Select Case m
        Case 0 : j = (X + Y) And 1
        Case 1 : j = Y And 1
        Case 2 : j = X Mod 3
        Case 3 : j = (X + Y) Mod 3
        Case 4 : j = (X \ 3 + Y \ 2) And 1
        Case 5 : j = ((X * Y) And 1) + (X * Y) Mod 3
        Case 6 : j = (X * Y + (X * Y) Mod 3) And 1
        Case 7 : j = (X + Y + (X * Y) Mod 3) And 1
      End Select
      If j = 0 Then i = i Xor 1 ' invert only data according mask
    End If
    zzPattern = i And 1
  End Function

  Private Sub zzPutMask(m As Short)
    Dim j As Short
    Dim k As Integer
    Dim i As Short
    Dim s As Short
    Dim X As Integer, Y As Integer


    ' add format information, code level and mask
    s = mvarCodeInfo(mvarVersion + 3)(0) ' symbol size
    j = IIf(mvarVersion = -3, m, IIf(mvarVersion < 1, (2 * mvarVersion + mvarLevel + 5) * 4 + m, ((5 - mvarLevel) And 3) * 8 + m))
    j = j * 1024
    k = j
    For i = 4 To 0 Step -1 ' BCH error correction: 5 data, 10 error bits
        If j >= 1024 * 2 ^ i Then j = j Xor 1335 * 2 ^ i
    Next i ' generator polynom: x^10+x^8+x^5+x^4+x^2+x+1 = 10100110111b = 1335
    k = k Xor j Xor IIf(mvarVersion < 1, 17477, 21522) ' XOR masking
    For j = 0 To 14 ' layout format information
        If mvarVersion < 1 Then
            mvarMatrix(IIf(j < 8, 8, 15 - j), IIf(j < 8, j + 1, 8)) = k And 1 Xor 2 ' micro QR
        Else
            mvarMatrix(IIf(j < 8, s - j - 1, IIf(j = 8, 7, 14 - j)), 8) = k And 1 Xor 2 ' QR horizontal
            mvarMatrix(8, IIf(j < 6, j, IIf(j < 8, j + 1, s + j - 15))) = k And 1 Xor 2 ' vertical
        End If
        k = k \ 2
    Next j
    If mvarVersion > 6 Then ' add version information
        k = mvarVersion * 4096&
        For i = 5 To 0 Step -1 ' BCH error correction: 6 data, 12 error bits
            If k >= 4096 * 2 ^ i Then k = k Xor 7973 * 2 ^ i
        Next i ' generator polynom: x^12+x^11+x^10+x^9+x^8+x^5+x^2+1 = 1111100100101b = 7973
        k = k Xor (mvarVersion * 4096&)
        For j = 0 To 17 ' layout version information
            mvarMatrix(j \ 3, s + j Mod 3 - 11) = k And 1 Xor 2
            mvarMatrix(s + j Mod 3 - 11, j \ 3) = k And 1 Xor 2
            k = k \ 2
        Next j
    End If

    ReDim mvarFinal(s - 1 + 2 * mvarQuietZone, s - 1 + 2 * mvarQuietZone)
    For Y = 0 To s - 1
      For X = 0 To s - 1
        ' apply mask
        If zzPattern(X, Y, m) Then mvarFinal(mvarQuietZone + Y, mvarQuietZone + X) = 1
      Next X
    Next Y
    mvarSize = s + 2 * mvarQuietZone

  End Sub

  Private Sub zzPutWords(eb As Integer)
    Dim i As Integer
    Dim j As Integer
    Dim X As Integer
    Dim Y As Integer
    Dim c As Integer
    Dim k As Integer
    Dim w As Integer
    Dim el As Integer
    Dim ec As Integer
    Dim blk As Integer
    Dim b As Integer
    Dim s As Short


    s = mvarCodeInfo(mvarVersion + 3)(0)
    blk = mvarEcb(mvarLevel)(mvarVersion + 3) ' # of error correction blocks
    el = mvarCodeInfo(mvarVersion + 3)(1) \ 8 - mvarEcw(mvarLevel)(mvarVersion + 3) * blk ' data capacity
    w = el \ blk ' # of words in group 1
    ec = mvarEcw(mvarLevel)(mvarVersion + 3) ' # of error correction bytes
    b = blk + w * blk - el ' # of blocks in group 1


    X = s
    Y = s - 1 ' layout codewords
    For i = 0 To eb - 1
      c = 0 : k = 0 : j = w + 1 ' interleave data
      If i >= el Then
        c = el : k = el : j = ec ' interleave checkwords
      ElseIf i + blk - b >= el Then
        c = -b : k = c ' interleave group 2 last bytes
      ElseIf (i Mod blk) >= b Then
        c = -b ' interleave group 2
      Else
        j = j - 1 ' interleave group 1
      End If
      c = mvarData(c + ((i - k) Mod blk) * j + (i - k) \ blk) ' interleave data

      '' TODO
      For j = IIf((-3 And mvarVersion) = -3 And i = el - 1, 3, 7) To 0 Step -1 ' M1,M3: 4 bit
        k = IIf(mvarVersion > 0 And X < 6, 1, 0) ' skip vertical timing pattern
        Do ' advance x,y
          X = X - 1
          If 1 And (X + 1) Xor k Then
            If s - X - k And 2 Then
              If Y > 0 Then Y = Y - 1 : X = X + 2 ' up, top turn
            Else
              If Y < s - 1 Then Y = Y + 1 : X = X + 2 ' down, bottom turn
            End If
          End If
        Loop While mvarMatrix(X, Y) And 2 ' skip reserved area
        If c And 2 ^ j Then
          mvarMatrix(X, Y) = 1
        End If
      Next j

    Next i


  End Sub

  Private Function zzReedSolomon() As Integer

    Dim ec As Integer
    Dim j As Integer
    Dim i As Integer
    Dim k As Integer
    Dim c As Integer
    Dim eb As Integer
    Dim el As Integer
    Dim b As Integer
    Dim w As Integer
    Dim blk As Integer
    Dim X As Integer
    Dim Rs() As Short


    ec = mvarEcw(mvarLevel)(mvarVersion + 3) ' # of error correction bytes
    blk = mvarEcb(mvarLevel)(mvarVersion + 3) ' # of error correction blocks
    el = mvarCodeInfo(mvarVersion + 3)(1) \ 8 - mvarEcw(mvarLevel)(mvarVersion + 3) * blk ' data capacity

    w = el \ blk ' # of words in group 1
    b = blk + w * blk - el ' # of blocks in group 1


    ReDim Rs(ec + 1) ' compute Reed Solomon error detection and correction
    Rs(0) = 1 ' compute RS generator polynomial
    For i = 0 To ec - 1
        Rs(i + 1) = 0
        For j = i + 1 To 1 Step -1
            Rs(j) = Rs(j) Xor mvarEx((mvarLg(Rs(j - 1)) + i) Mod 255)
        Next j
    Next i
    eb = el : k = 0
    For c = 1 To blk  ' compute RS correction data for each block
      For i = IIf(c <= b, 1, 0) To w
        X = mvarData(eb) Xor mvarData(k)
        For j = 1 To ec
          mvarData(eb + j - 1) = mvarData(eb + j) Xor IIf(X, mvarEx((mvarLg(Rs(j)) + mvarLg(X)) Mod 255), 0)
        Next j
        k = k + 1
      Next i
      eb = eb + ec
    Next c

    zzReedSolomon = eb
  End Function

  Private Sub zzShowMarkers()
    Dim X As Short
    Dim Y As Short
    Dim a As Short
    Dim i As Short
    Dim j As Short
    Dim c As Short
    Dim k As Short
    Dim l As Short

    ' fill QR matrix
    For i = 8 To mvarCodeInfo(mvarVersion + 3)(0) - 1 - 8 ' timing pattern
      If (i And 1 Xor 3) = 3 Then
        mvarFinal(mvarQuietZone + i, mvarQuietZone + IIf(mvarVersion < 1, 0, 6)) = 5
        mvarFinal(mvarQuietZone + IIf(mvarVersion < 1, 0, 6), mvarQuietZone + i) = 5
      End If
    Next i

    If mvarVersion < 1 Then
      a = 1
    ElseIf mvarVersion < 2 Then
      a = 2
    Else
      a = mvarVersion \ 7 + 2
    End If

    For X = 1 To a ' layout finder/align pattern
      For Y = 1 To a
        If X = 1 And Y = 1 Then ' finder upper left
          i = 0
          j = 0
          l = 6
        ElseIf X = 1 And Y = a Then  ' finder lower left
          i = 0
          j = 1 + mvarCodeInfo(mvarVersion + 3)(0) - 8
          l = 6
        ElseIf X = a And Y = 1 Then  ' finder upper right
          i = 1 + mvarCodeInfo(mvarVersion + 3)(0) - 8
          j = 0
          l = 6
        Else ' alignment grid
          c = 2 * Int(2 * (mvarVersion + 1) / (1 - a)) ' pattern spacing
          i = IIf(X = 1, 4, mvarCodeInfo(mvarVersion + 3)(0) - 9 + c * (a - X))
          j = IIf(Y = 1, 4, mvarCodeInfo(mvarVersion + 3)(0) - 9 + c * (a - Y))
          l = 4
        End If

        For c = 0 To l
          For k = 0 To l Step l
           mvarFinal(mvarQuietZone + i + c, mvarQuietZone + j + 0 + k) = 2
           mvarFinal(mvarQuietZone + i + 0 + k, mvarQuietZone + j + c) = 2
          Next
        Next

        For c = 0 To (l Mod 4)
          For k = 0 To (l Mod 4)
            mvarFinal(mvarQuietZone + i + 2 + c, mvarQuietZone + j + 2 + k) = 3
          Next
        Next

      Next Y
    Next X

  End Sub


  Private Function zzBestEncoding() As vbQREncoding
      Dim e As vbQREncoding
      Dim i As Short
      Dim c As Byte

      e = vbQREncoding.qrEncNumeric
      For i = 1 To mvarDataLen ' compute mode
          c = AscW(Mid(mvarTextData, i, 1))
          If c < 48 Or c > 57 Then
              If e = vbQREncoding.qrEncNumeric Then e = vbQREncoding.qrEncAlphaNum ' alphanumeric mode
              If InStr(Alphanum, ChrW(c)) = 0 Then
                  If e = vbQREncoding.qrEncAlphaNum Then
                    e = vbQREncoding.qrEncBinary ' binary
                    Exit For
                  End If
              End If
          End If
      Next i

      zzBestEncoding = e

  End Function

    '' support for UTF-8
    Private Shared Function ZzFromUTF8(ByVal sStr As String) As String
        Dim l As Integer
        Dim lchar As Long
        Dim sUtf8 As String = ""

        For l = 1 To Len(sStr)

            lchar = AscW(Mid(sStr, l, 1))
            If lchar < 0 Then lchar += +65536

            If lchar <= 127 Then
                sUtf8 = sUtf8 + Mid(sStr, l, 1)
            ElseIf (lchar <= 2047) Then
                sUtf8 = sUtf8 + Chr(((lchar \ 64) Or 192))
                sUtf8 = sUtf8 + Chr(((lchar And 63) Or 128))
            Else
                sUtf8 = sUtf8 + Chr((Int(lchar \ 4096) And 15) Or 224)
                sUtf8 = sUtf8 + Chr((((lchar \ 64) And 63) Or 128))
                sUtf8 = sUtf8 + Chr(((lchar And 63) Or 128))
            End If
        Next l

        ZzFromUTF8 = sUtf8

    End Function



End Class