'
' This file is part of the LibreOffice project.
'
' This Source Code Form is subject to the terms of the Mozilla Public
' License, v. 2.0. If a copy of the MPL was not distributed with this
' file, You can obtain one at http://mozilla.org/MPL/2.0/.
'
' This file incorporates work covered by the following license notice:
'
'   Licensed to the Apache Software Foundation (ASF) under one or more
'   contributor license agreements. See the NOTICE file distributed
'   with this work for additional information regarding copyright
'   ownership. The ASF licenses this file to you under the Apache
'   License, Version 2.0 (the "License"); you may not use this file
'   except in compliance with the License. You may obtain a copy of
'   the License at http://www.apache.org/licenses/LICENSE-2.0 .
'

Option Explicit On
Option Strict On
Imports Pop2.Comuni
Imports unoidl.com.sun.star.lang
Imports unoidl.com.sun.star.uno
Imports uno.util

Module ProvaScrittura

    Sub Main(ByVal rg As dsPreventivi.dtPreventiviDestinatariRow, ByVal dtPR As DataTable)

        Dim xContext As XComponentContext
        xContext = Bootstrap.bootstrap()
        Dim xFactory As XMultiServiceFactory
        xFactory = DirectCast(xContext.getServiceManager(), XMultiServiceFactory)

        'Create the Desktop
        Dim xDesktop As unoidl.com.sun.star.frame.XDesktop
        xDesktop = DirectCast(xFactory.createInstance("com.sun.star.frame.Desktop"), unoidl.com.sun.star.frame.XDesktop)

        'Open a new empty writer document
        Dim xComponentLoader As unoidl.com.sun.star.frame.XComponentLoader
        xComponentLoader = DirectCast(xDesktop, unoidl.com.sun.star.frame.XComponentLoader)
        Dim arProps() As unoidl.com.sun.star.beans.PropertyValue = New unoidl.com.sun.star.beans.PropertyValue() {}
        Dim oDocumento As unoidl.com.sun.star.lang.XComponent
        Dim filetxt As String = "file:///U:/Proposte di contratto/proposte.odt"
        '"private:factory/swriter"
        oDocumento = xComponentLoader.loadComponentFromURL(filetxt, "_blank", 0, arProps)

        Dim oContenuto As unoidl.com.sun.star.text.XTextDocument
        oContenuto = DirectCast(oDocumento, unoidl.com.sun.star.text.XTextDocument)


        InserisciTestoAlSegnalibro(oContenuto, "societa", rg.societa & " ")
        InserisciTestoAlSegnalibro(oContenuto, "indirizzo", rg.indirizzo & " ")
        InserisciTestoAlSegnalibro(oContenuto, "cap", rg.cap & " ")
        InserisciTestoAlSegnalibro(oContenuto, "localita", rg.localita & " ")
        InserisciTestoAlSegnalibro(oContenuto, "provincia", rg.prv & " ")
        InserisciTestoAlSegnalibro(oContenuto, "titolo", rg.tit & " ")
        InserisciTestoAlSegnalibro(oContenuto, "referente", rg.Resp & " ")
        InserisciTestoAlSegnalibro(oContenuto, "societa2", rg.societa & " ")
        InserisciTestoAlSegnalibro(oContenuto, "piva", If(rg.Isp_ivaNull, "", rg.p_iva) & " ")
        InserisciTestoAlSegnalibro(oContenuto, "indirizzo2", rg.indirizzo & " ")
        InserisciTestoAlSegnalibro(oContenuto, "localita2", rg.localita & " ")
        InserisciTestoAlSegnalibro(oContenuto, "provincia2", rg.prv & " ")
        InserisciTestoAlSegnalibro(oContenuto, "societa3", rg.societa & " ")
        InserisciTestoAlSegnalibro(oContenuto, "indirizzo3", rg.indirizzo & " ")
        InserisciTestoAlSegnalibro(oContenuto, "localita3", rg.localita & " ")
        InserisciTestoAlSegnalibro(oContenuto, "sicurezzaluoghi", rg.sicurezzaluoghi & " ")

        InserisciTestoAlSegnalibro(oContenuto, "sicurezzanum", rg.sicurezzanum & " ")
        InserisciTestoAlSegnalibro(oContenuto, "sicurezzatxt", rg.sicurezzatxt & " ")

        InserisciTestoAlSegnalibro(oContenuto, "prezzoorarionum", rg.prezzooranum & " ")
        InserisciTestoAlSegnalibro(oContenuto, "prezzoorariotxt", rg.prezzooratxt & " ")
        InserisciTestoAlSegnalibro(oContenuto, "canonemesenum", rg.canonenum & " ")
        InserisciTestoAlSegnalibro(oContenuto, "canonemesetxt", rg.canonetxt & " ")

        InserisciTestoAlSegnalibro(oContenuto, "decorrenzadata", If(rg.IsdecorrenzaNull, Now().ToShortDateString, rg.decorrenza.ToShortDateString) & " ")
        InserisciTestoAlSegnalibro(oContenuto, "provanum", rg.provanum & " ")
        InserisciTestoAlSegnalibro(oContenuto, "provadat", If(rg.IsprovadatNull, Now().ToShortDateString, rg.provadat.ToShortDateString) & " ")
        InserisciTestoAlSegnalibro(oContenuto, "scadenzadat", If(rg.IsscadenzaNull, Now().ToShortDateString, rg.scadenza.ToShortDateString) & " ")

        InserisciTestoAlSegnalibro(oContenuto, "societa9", rg.societa & " ")
        InserisciTestoAlSegnalibro(oContenuto, "indirizzo9", rg.indirizzo & " ")
        InserisciTestoAlSegnalibro(oContenuto, "localita9", rg.localita & " ")
        InserisciTestoAlSegnalibro(oContenuto, "provincia9", rg.prv & " ")
        InserisciTestoAlSegnalibro(oContenuto, "societa9bis", rg.societa & " ")

        InserisciTestoAlSegnalibro(oContenuto, "societa10", rg.societa & " ")

        InserisciTestoAlSegnalibro(oContenuto, "societa12", rg.societa & " ")
        InserisciTestoAlSegnalibro(oContenuto, "indirizzo12", rg.indirizzo & " ")
        InserisciTestoAlSegnalibro(oContenuto, "localita12", rg.localita & " ")

        InserisciTestoAlSegnalibro(oContenuto, "decorrenza12", If(rg.IsdecorrenzaNull, Now().ToShortDateString, rg.decorrenza.ToShortDateString) & " ")
        InserisciTestoAlSegnalibro(oContenuto, "tit12", rg.tit & " ")
        InserisciTestoAlSegnalibro(oContenuto, "responsabile12", rg.Resp & " ")

        If dtPR.Rows.Count = 0 Then
            Return
        End If
        Dim dv As DataView
        For Each tt As DataRow In dtPR.Rows
            tt("sortfrequenza") = If(IsDBNull(tt("sortfrequenza")), 0, tt("sortfrequenza"))
            dtPR.AcceptChanges()
        Next
        Try
            Dim query = From c In dtPR.AsEnumerable
                        Order By c.Field(Of String)("categoria") Descending,
                                c.Field(Of Int32)("sortfrequenza") Ascending,
                                c.Field(Of Int32)("sort") Ascending
            dv = query.AsDataView
        Catch ex As Exception
            MsgBox("Mi spiace non sono riuscito" & vbCrLf & "a elaborare il documento correttamente," & vbCrLf & "prova  a chiudere e riaprire la maschera")
        End Try


#Disable Warning BC42104 ' La variabile 'dv' è stata usata prima dell'assegnazione di un valore. È possibile che in fase di esecuzione venga restituita un'eccezione dovuta a un riferimento Null.
        dv.RowFilter = String.Format("id_destinatario = {0}", rg.id)
#Enable Warning BC42104 ' La variabile 'dv' è stata usata prima dell'assegnazione di un valore. È possibile che in fase di esecuzione venga restituita un'eccezione dovuta a un riferimento Null.
        Dim tmpDV As DataTable = dv.ToTable
        Dim oldCat As String = tmpDV(0).Field(Of String)("categoria")
        'InserisciTestoAlSegnalibro(oContenuto, "capitolato", oldCat & vbCrLf)
        Dim oldFre As String = tmpDV(0).Field(Of String)("frequenza")
        InserisciTtitolo1(oContenuto, oldCat)
        InserisceinterruzioneParagrafo(oContenuto)
        InserisciTtitolo2(oContenuto, oldFre)
        InserisceinterruzioneParagrafo(oContenuto)

        For Each rgPR As DataRow In tmpDV.Rows
            Dim cat As String = rgPR.Field(Of String)("categoria")
            Dim fre As String = rgPR.Field(Of String)("frequenza")
            Dim ope As String = rgPR.Field(Of String)("operazione")
            Dim note As String = If(IsDBNull(rgPR.Field(Of String)("note")), Nothing, rgPR.Field(Of String)("note"))

            Select Case True
                Case oldCat <> cat And oldFre = fre
                    oldCat = cat
                    InserisceinterruzionediPagina(oContenuto)
                    InserisceinterruzioneParagrafo(oContenuto)
                    InserisciTtitolo1(oContenuto, oldCat)
                    InserisceinterruzioneParagrafo(oContenuto)
                    InserisciTtitolo2(oContenuto, oldFre)
                    InserisceinterruzioneParagrafo(oContenuto)
                Case oldCat <> cat And oldFre <> fre
                    oldCat = cat
                    InserisceinterruzionediPagina(oContenuto)
                    InserisceinterruzioneParagrafo(oContenuto)
                    InserisciTtitolo1(oContenuto, oldCat)
                    InserisceinterruzioneParagrafo(oContenuto)
                    oldFre = fre
                    InserisciTtitolo2(oContenuto, oldFre)
                    InserisceinterruzioneParagrafo(oContenuto)
                Case oldCat = cat And oldFre <> fre
                    oldFre = fre
                    InserisciTtitolo2(oContenuto, oldFre)
                    InserisceinterruzioneParagrafo(oContenuto)
            End Select
            InserisciTesto(oContenuto, ope)
            InserisceinterruzioneParagrafo(oContenuto)
            If Not note = Nothing Then
                Try
                    If note.ToString.Trim.Length > 0 Then
                        InserisciNote(oContenuto, note)
                        InserisceinterruzioneParagrafo(oContenuto)
                    End If
                Catch ex As Exception

                End Try
            End If

        Next


    End Sub
    Public Sub InserisciTestoAlSegnalibro(ByRef oDoc As unoidl.com.sun.star.text.XTextDocument, nomeSegnalibro As String, testo As String)

        Dim BookmarksSupplier As unoidl.com.sun.star.text.XBookmarksSupplier = CType(oDoc, unoidl.com.sun.star.text.XBookmarksSupplier)
        Dim FoundBookmark As unoidl.com.sun.star.text.XTextContent = CType(BookmarksSupplier.getBookmarks.getByName(nomeSegnalibro).Value, unoidl.com.sun.star.text.XTextContent)
        Dim BookmarkField As unoidl.com.sun.star.text.XTextRange = FoundBookmark.getAnchor()
        BookmarkField.setString(testo)

    End Sub
    Private Sub InserisciTtitolo2(ByRef oDoc As unoidl.com.sun.star.text.XTextDocument, testo As String)

        Dim contenuto As unoidl.com.sun.star.text.XText = CType(oDoc.getText(), unoidl.com.sun.star.text.XText)
        Dim textRange As unoidl.com.sun.star.text.XTextRange
        textRange = contenuto.getEnd()
        contenuto.getText().insertString(textRange, testo, True)
        Dim xPropertySetCursor As unoidl.com.sun.star.beans.XPropertySet
        xPropertySetCursor = DirectCast(textRange, unoidl.com.sun.star.beans.XPropertySet)
        xPropertySetCursor.setPropertyValue("CharShadowed", New uno.Any(False))
        xPropertySetCursor.setPropertyValue("CharColor", New uno.Any(Color.RoyalBlue.ToArgb))
        xPropertySetCursor.setPropertyValue("CharHeight", New uno.Any(13.0))
        xPropertySetCursor.setPropertyValue("CharShadowed", New uno.Any(True))
        'xPropertySetCursor.setPropertyValue("CharCaseMap", New uno.Any(4))
        xPropertySetCursor.setPropertyValue("ParaLeftMargin", New uno.Any(1))
        xPropertySetCursor.setPropertyValue("ParaTopMargin", New uno.Any(400))
        xPropertySetCursor.setPropertyValue("ParaBottomMargin", New uno.Any(400))
        xPropertySetCursor.setPropertyValue("CharFontName", New uno.Any("Tahoma"))
    End Sub
    Private Sub InserisciTtitolo1(ByRef oDoc As unoidl.com.sun.star.text.XTextDocument, testo As String)

        Dim contenuto As unoidl.com.sun.star.text.XText = CType(oDoc.getText(), unoidl.com.sun.star.text.XText)
        Dim textRange As unoidl.com.sun.star.text.XTextRange
        textRange = contenuto.getEnd()
        contenuto.getText().insertString(textRange, testo, True)
        Dim xPropertySetCursor As unoidl.com.sun.star.beans.XPropertySet
        xPropertySetCursor = DirectCast(textRange, unoidl.com.sun.star.beans.XPropertySet)
        xPropertySetCursor.setPropertyValue("CharShadowed", New uno.Any(True))
        xPropertySetCursor.setPropertyValue("CharColor", New uno.Any(Color.RoyalBlue.ToArgb))
        xPropertySetCursor.setPropertyValue("CharHeight", New uno.Any(16.0))
        xPropertySetCursor.setPropertyValue("ParaTopMargin", New uno.Any(200))
        xPropertySetCursor.setPropertyValue("ParaLeftMargin", New uno.Any(400))
        xPropertySetCursor.setPropertyValue("CharFontName", New uno.Any("Tahoma"))


    End Sub
    Private Sub InserisciTesto(ByRef oDoc As unoidl.com.sun.star.text.XTextDocument, testo As String)
        Dim contenuto As unoidl.com.sun.star.text.XText = CType(oDoc.getText(), unoidl.com.sun.star.text.XText)
        Dim textRange As unoidl.com.sun.star.text.XTextRange
        textRange = contenuto.getEnd()
        contenuto.getText().insertString(textRange, testo, True)
        Dim xPropertySetCursor As unoidl.com.sun.star.beans.XPropertySet
        xPropertySetCursor = DirectCast(textRange, unoidl.com.sun.star.beans.XPropertySet)
        xPropertySetCursor.setPropertyValue("CharShadowed", New uno.Any(False))
        xPropertySetCursor.setPropertyValue("CharColor", New uno.Any(Color.Black.ToArgb))
        xPropertySetCursor.setPropertyValue("CharHeight", New uno.Any(12.0))
        xPropertySetCursor.setPropertyValue("ParaLeftMargin", New uno.Any(200))
        xPropertySetCursor.setPropertyValue("CharFontName", New uno.Any("Tahoma"))
    End Sub
    Private Sub InserisciNote(ByRef oDoc As unoidl.com.sun.star.text.XTextDocument, testo As String)
        Dim contenuto As unoidl.com.sun.star.text.XText = CType(oDoc.getText(), unoidl.com.sun.star.text.XText)
        Dim textRange As unoidl.com.sun.star.text.XTextRange
        textRange = contenuto.getEnd()
        contenuto.getText().insertString(textRange, testo, True)
        Dim xPropertySetCursor As unoidl.com.sun.star.beans.XPropertySet
        xPropertySetCursor = DirectCast(textRange, unoidl.com.sun.star.beans.XPropertySet)

        xPropertySetCursor.setPropertyValue("CharShadowed", New uno.Any(False))
        xPropertySetCursor.setPropertyValue("CharColor", New uno.Any(Color.Black.ToArgb))
        xPropertySetCursor.setPropertyValue("CharHeight", New uno.Any(8.0))
        xPropertySetCursor.setPropertyValue("ParaLeftMargin", New uno.Any(1200))
        xPropertySetCursor.setPropertyValue("CharFontName", New uno.Any("Times New Roman"))
    End Sub

    Private Sub InserisceinterruzioneParagrafo(ByRef oDoc As unoidl.com.sun.star.text.XTextDocument)
        Dim contenuto As unoidl.com.sun.star.text.XText = CType(oDoc.getText(), unoidl.com.sun.star.text.XText)
        Dim oTesto = contenuto.getText()
        oTesto.insertControlCharacter(contenuto.getEnd, unoidl.com.sun.star.text.ControlCharacter.PARAGRAPH_BREAK, False)
    End Sub
    Private Sub InserisceinterruzionediPagina(ByRef oDoc As unoidl.com.sun.star.text.XTextDocument)
        Dim contenuto As unoidl.com.sun.star.text.XText = CType(oDoc.getText(), unoidl.com.sun.star.text.XText)
        Dim oTesto = contenuto.getText()
        Dim textRange As unoidl.com.sun.star.text.XTextRange
        textRange = contenuto.getEnd()
        contenuto.getText().insertString(textRange, " ", True)
        Dim xPropertySetCursor As unoidl.com.sun.star.beans.XPropertySet
        xPropertySetCursor = DirectCast(textRange, unoidl.com.sun.star.beans.XPropertySet)
        xPropertySetCursor.setPropertyValue("BreakType", New uno.Any(5))
        oTesto.insertControlCharacter(contenuto.getEnd, unoidl.com.sun.star.text.ControlCharacter.PARAGRAPH_BREAK, False)
    End Sub

    'oCursor.setPropertyValue("BreakType", 5)
End Module