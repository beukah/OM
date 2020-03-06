Imports System.Windows.Forms
Imports System.Windows.Interop
Imports Microsoft.Office.Interop.Excel
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Security.AccessControl
Imports System.Text.RegularExpressions
Imports Microsoft.Office.Interop.Outlook

Public Class Form1
    Dim xlapp As Excel.Application
    Dim strBody, strToXl As String
    Dim ts, fso As Object
    Dim subjectOrig, TempFile, strSap, strSavePath, strOrderNumber, strAccount, signature, strSubjectId As String
    Dim objtxt As New DataObject
    Dim lrow, lcol, cwidth, intDays As Double
    Dim rng As Excel.Range
    Dim strTempPath As String = System.IO.Path.GetTempPath()
    Dim olApp As New Outlook.Application
    Dim oInspector As Outlook.Inspector = olApp.ActiveInspector
    Dim form As FmSignature = New FmSignature()
    Dim strObject As String
    Dim strSignature As String = My.Settings.Signature.Replace(vbCrLf, "<br>")
    Dim strBodyPrice As String = My.Settings.BodyPrice.Replace(vbCrLf, "<br>")
    Dim strBodyRef As String = My.Settings.BodyRef.Replace(vbCrLf, "<br>")
    Public strEmailAdress(0 To 4) As String

    Public i As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        emailadress()

    End Sub

    Dim strBodyText As String = My.Settings.BodyText.Replace(vbCrLf, "<br>")
    Dim OrigEmail As Outlook.MailItem = olApp.ActiveExplorer.Selection(1)
    Dim forwardEmail As Outlook.MailItem = olApp.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem)
    Dim newEmail As Outlook.MailItem
    Dim oForm As Form1

    Dim strClientNumber As String


    ' Private Sub BtClarify_Click(sender As Object, e As EventArgs) Handles BtClarify.Click
    'Dim strTitelForm1 As String = My.Settings.strTitleForm1
    'Dim x As New Ribbon1()

    'If strTitelForm1 = "Clarif Texte" Then

    '  strBody = strBodyText
    '      ts = "<br>" & TBSapData.Text & "<br>"

    'Else
    'If strTitelForm1 = "Clarif Prix" Then
    'strBody = strBodyPrice
    'strToXl = TBSapData.Text
    'ExcelToOutlook()
    'Else
    'strBody = strBodyRef
    'strToXl = TBSapData.Text
    'ts = "<br>" & TBSapData.Text & "<br>"
    'End If
    'End If


    '  Createmail()
    '   SaveMail()
    '  Me.Close()
    'End Sub


    Public Sub Createmail()

        strAccount = ""
        For Each checkeditem In CLBEmailAddress.CheckedItems
            strAccount = strAccount & "; " & checkeditem
        Next

        subjectOrig = OrigEmail.Subject
        strOrderNumber = TBOrderNumber.Text
        strSubjectId = My.Settings.strTitleForm1
        subjectOrig = strOrderNumber & " // " & strSubjectId & "// " & subjectOrig
        OrigEmail.Subject = subjectOrig
        With forwardEmail
            .To = OrigEmail.Forward.To
            .HTMLBody = "<br>" & strBody & "<br>" & ts & "<br>" & strSignature & "<br>" & "<br>" & OrigEmail.Reply.HTMLBody
            .Subject = subjectOrig
            '.SendUsingAccount = OrigEmail.ReceivedByEntryID
            .Recipients.ResolveAll()
            .Recipients.Add(strAccount)
            .Display()
        End With

        If CBFollowUp.Checked = True Then
            intDays = TBFollowUpDays.Text
            Dim date1 As Date = Now
            Dim date2 As Date = date1.AddDays(intDays)
            With OrigEmail
                .MarkAsTask(Microsoft.Office.Interop.Outlook.OlMarkInterval.olMarkThisWeek)
                .TaskDueDate = date2
                .FlagRequest = subjectOrig
                .ReminderSet = True
                .ReminderTime = date2
                .Save()
            End With
        Else
        End If

    End Sub

    Public Sub ExcelToOutlook()
        xlapp = New Excel.Application
        Dim xlBook As Workbook
        Dim tempBook As String
        tempBook = strTempPath & "tempbook.xlsx"
        If Dir(tempBook) = "" Then
            xlBook = xlapp.Workbooks.Add
            xlBook.SaveAs(tempBook)

        End If
        xlBook = GetWorkbook(tempBook)
        'xlApp.Visible = True
        Dim xlsheet As Worksheet = xlBook.Worksheets(1)

        Clipboard.SetText(strToXl)
        xlsheet.Range("A2").PasteSpecial()

        lrow = xlsheet.Cells(xlsheet.Rows.Count, "A").end(Excel.XlDirection.xlUp).row

        rng = xlsheet.Range("A2", "A" & lrow)
        rng.TextToColumns _
        (Destination:=xlsheet.Range("A2"),
        DataType:=Excel.XlTextParsingType.xlDelimited,
        ConsecutiveDelimiter:=True,
        Tab:=False,
        Semicolon:=False,
        Comma:=False,
        Space:=True,
        Other:=False,
        OtherChar:="-")


        With xlsheet
            .Range("A1").Value = "Poste"
            .Range("B1").Value = "Réf"
            .Range("C1").Value = "Qte"
            .Range("D1").Value = "Prix de Client"
            .Range("E1").Value = "Prix SAP"
            .Range("F1").Value = "Ecart"
        End With
        lrow = xlsheet.Cells(xlsheet.Rows.Count, "A").end(Excel.XlDirection.xlUp).row
        lcol = xlsheet.Cells(1, xlsheet.Columns.Count).end(Excel.XlDirection.xlToLeft).column
        rng = xlsheet.Range(xlsheet.Cells(1, 1), xlsheet.Cells(lrow, lcol))

        With rng
            .Columns.AutoFit()
            .Rows.AutoFit()
        End With

        xlsheet.Range("A:N").NumberFormat = "@"

        xlsheet.Range(xlsheet.Cells(1, 1), (xlsheet.Cells(1, lcol))).Font.Bold = True

        For Each rng In rng
            cwidth = rng.Columns.ColumnWidth

            rng.Columns.ColumnWidth = cwidth + 2
        Next

        TempFile = Environ$("temp") & "\" & Format(Now, "dd-mm-yy h-mm-ss") & ".htm"

        With xlBook.PublishObjects.Add(
                 SourceType:=Excel.XlSourceType.xlSourceRange,
                 Filename:=TempFile,
                 Sheet:=xlBook.Sheets(1).Name,
                 Source:=xlBook.Sheets(1).UsedRange.Address,
                 HtmlType:=Excel.XlHtmlType.xlHtmlStatic)
            .Publish(True)
        End With


        fso = CreateObject("scripting.filesystemobject")

        ts = fso.GetFile(TempFile).OpenAsTextStream(1, -2)

        ts = Replace(ts.readall, "align=center x:publishsource=",
                          "align=left x:publishsource=")

        With xlBook
            .Saved = True
            .Close()
        End With
        xlapp.Quit()
    End Sub
    Public Function GetWorkbook(ByVal sFullName As String) As Workbook

        'Dim xlapp As New Excel.Application
        Dim sFile As String
        Dim wbReturn As Workbook

        sFile = Dir(sFullName)

        On Error Resume Next
        wbReturn = xlapp.Workbooks(sFile)

        If wbReturn Is Nothing Then
            wbReturn = xlapp.Workbooks.Open(sFullName)
        End If
        On Error GoTo 0

        GetWorkbook = wbReturn
        'xlapp.Quit()
    End Function

    Sub SaveMail()


        If TBClientNumber.Text = "" Then
            MsgBox("Please enter the client number")

        End If

        'FolderAcl.SetAccessRuleProtection(True, False) 'uncomment to remove existing permissions
        'FileInfo.SetAccessControl(FileAcl)


        strSavePath = "C:\Orders\" & strOrderNumber & " " & TBClientNumber.Text

        If Not System.IO.Directory.Exists(strSavePath) Then

            System.IO.Directory.CreateDirectory(strSavePath)




        End If

        With OrigEmail
            strObject = .Subject
            .SaveAs(strSavePath & RemoveIllegalCharacters(strObject) & ".msg")

        End With

        With forwardEmail
            strObject = .Subject
            .SaveAs(strSavePath & RemoveIllegalCharacters(strObject) & ".msg")
        End With





    End Sub

    Function RemoveIllegalCharacters(strValue As String) As String
        ' Purpose: Remove characters that cannot be in a filename from a string.'
        ' Written: 4/24/2009'
        ' Author:  BlueDevilFan'
        ' Outlook: All versions'
        RemoveIllegalCharacters = strValue
        RemoveIllegalCharacters = Replace(RemoveIllegalCharacters, "<", "")
        RemoveIllegalCharacters = Replace(RemoveIllegalCharacters, ">", "")
        RemoveIllegalCharacters = Replace(RemoveIllegalCharacters, ":", "")
        RemoveIllegalCharacters = Replace(RemoveIllegalCharacters, Chr(34), "'")
        RemoveIllegalCharacters = Replace(RemoveIllegalCharacters, "/", "")
        RemoveIllegalCharacters = Replace(RemoveIllegalCharacters, "\", "")
        RemoveIllegalCharacters = Replace(RemoveIllegalCharacters, "|", "")
        RemoveIllegalCharacters = Replace(RemoveIllegalCharacters, "?", "")
        RemoveIllegalCharacters = Replace(RemoveIllegalCharacters, "*", "")
    End Function



    Sub emailadress()
        Dim temp(0 To 4) As String
        Dim olApp As New Outlook.Application
        Dim OrigEmail As Outlook.MailItem
        Dim s As String
        Dim i As Integer
        Dim accountform As New Form5
        Dim adress(0 To 4) As String
        Dim oInspector As Outlook.Inspector = olApp.ActiveInspector

        If oInspector Is Nothing Then
            OrigEmail = olApp.ActiveExplorer.Selection.Item(1)
        Else
            OrigEmail = oInspector.CurrentItem
        End If

        For Each mailbox In olApp.Session.Folders
            If mailbox.Name Like "Public*" Or mailbox.Name Like "Archive*" Or mailbox.Name Like "archive*" Or Nothing Then
                GoTo skip





            Else
                temp(i) = mailbox.Name
                If i > 3 Then GoTo skip Else
                i += 1
            End If
skip:


        Next
        temp = SortArrayAtoZ(temp)
        adress(0) = My.Settings.TBadress1
        adress(1) = My.Settings.TBadress2
        adress(2) = My.Settings.TBadress3
        adress(3) = My.Settings.TBadress4
        adress(4) = My.Settings.TBadress5

        Dim mbname As MAPIFolder = OrigEmail.Parent
        Dim mailboxname As String
        mailboxname = mbname.Store.DisplayName
        Dim a As Integer = 0
        i = -1
        Do
            i += 1


        Loop Until mailboxname = temp(i)



        Dim email As String() = SplitWords(adress(i))

        i = 0
        For Each s In email
            CLBEmailAddress.Items.Insert(a, email(i))
            i += 1
            a += 1
        Next
    End Sub
    Private Function SplitWords(ByVal s As String) As String()
        ' Call Regex.Split function from the imported namespace.
        ' ... Return the result array.
        Return s.Split({Environment.NewLine}, StringSplitOptions.None)
    End Function

    Function SortArrayAtoZ(myArray As Object)

        Dim i As Long
        Dim j As Long
        Dim Temp

        'Sort the Array A-Z
        For i = LBound(myArray) To UBound(myArray) - 1
            For j = i + 1 To UBound(myArray)
                If UCase(myArray(i)) < UCase(myArray(j)) Then
                    Temp = myArray(j)
                    myArray(j) = myArray(i)
                    myArray(i) = Temp
                End If
            Next j
        Next i

        SortArrayAtoZ = myArray

    End Function
End Class





