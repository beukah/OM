Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Excel
Imports Microsoft.Office.Interop.Outlook
Imports Microsoft.Office.Tools.Ribbon
Imports System.Diagnostics
Imports System.Drawing
Imports System.Windows.Forms
Imports Button = System.Windows.Forms.Button
Imports Label = System.Windows.Forms.Label
Imports TextBox = System.Windows.Forms.TextBox
Imports System.IO
Imports Application = Microsoft.Office.Interop.Outlook.Application
Imports System.Runtime.InteropServices
Imports Microsoft.Office.Core
Imports System.Data.OleDb

Public Class Ribbon1

    Public Property ClientSize As System.Drawing.Size
    Public workbookname As String = "\\ww002.siemens.net\dfs69\group\gss\bss\o2c di BE\VA-BAC-split.xlsx"
    Public Property Url As Uri
    Public strTitleForm1 As String
    Public xlapp As Excel.Application
    Dim oForm As Form1
    Dim found, strClientNumber, strOrderNumber, orderNumber As String
    Public savePathWindows(0 To 4) As String
    Public savePathOutlook(0 To 4) As String
    Public temp(0 To 4) As String
    Public defaultPath As String = "c:\Orders\"
    Public strSavePathW As String
    Public xlBook As Excel.Workbook
    Public xlsheet As Excel.Worksheet



    Public Sub Ribbon1_Load(ByVal sender As System.Object, ByVal e As RibbonUIEventArgs) Handles MyBase.Load
        'If xlapp Is Nothing Then
        'xlapp = New Excel.Application



        'workbookname =


        ' Else

        ' End If
        ' IdentifyItem()
        If CBAutoCheck.Checked <> False Then
            checkList()
        Else

        End If
    End Sub

    Private Sub Save_Mail(sender As Object, e As RibbonControlEventArgs) Handles Button1.Click

        saveItem()

    End Sub


    Public Sub Identify_Mail(sender As Object, e As RibbonControlEventArgs) Handles Button2.Click

        IdentifyItem()


    End Sub


    Public Sub BtClPrice_Click(sender As Object, e As RibbonControlEventArgs) Handles BtClPrice.Click

        Dim strTitleForm1 As String
        Dim oForm As Form1
        oForm = New Form1()
        oForm.Text = "Clarif Prix"
        strTitleForm1 = oForm.Text
        My.Settings.strTitleForm1 = oForm.Text
        My.Settings.Save()
        oForm.Show()

    End Sub

    Public Sub BtClref_Click(sender As Object, e As RibbonControlEventArgs) Handles BtClRef.Click

        Dim strTitleForm1 As String
        Dim oForm As Form1
        oForm = New Form1()
        oForm.Text = "Clarif Reference"
        strTitleForm1 = oForm.Text
        My.Settings.strTitleForm1 = oForm.Text
        My.Settings.Save()
        oForm.Show()

    End Sub

    Public Sub BtCltext_Click(sender As Object, e As RibbonControlEventArgs) Handles BtClText.Click

        Dim strTitleForm1 As String
        Dim oForm As Form1
        oForm = New Form1()
        oForm.Text = "Clarif Texte"
        strTitleForm1 = oForm.Text
        My.Settings.strTitleForm1 = oForm.Text
        My.Settings.Save()
        oForm.Show()

    End Sub

    Private Sub BtSignature_Click(sender As Object, e As RibbonControlEventArgs) Handles BtSignature.Click

        Dim oForm As FmSignature
        oForm = New FmSignature
        oForm.TBSignature.Text = My.Settings.Signature
        oForm.Show()

    End Sub
    Private Sub BtBody_Click(sender As Object, e As RibbonControlEventArgs) Handles BtBody.Click

        Dim oForm As New FmBody
        oForm.TBBodyPrice.Text = My.Settings.BodyPrice
        oForm.TBBodyRef.Text = My.Settings.BodyRef
        oForm.TBBodyText.Text = My.Settings.BodyText
        oForm.Show()

    End Sub
    Private Sub BtSavePath_Click(sender As Object, e As RibbonControlEventArgs)

        Dim olApp As New Outlook.Application
        Dim accounts As Outlook.Accounts = olApp.Session.Accounts

        Dim i As Integer = 1
        Dim FmAccount As New Form
        Dim ArAccounts(10) As String
        Dim x As Integer
        Dim mailbox As Folder

        With FmAccount
            .Height = 791
            .Width = 1064
            .StartPosition = FormStartPosition.WindowsDefaultLocation
            .AutoSizeMode = AutoSizeMode.GrowOnly
            .AutoScroll = True
        End With

        For Each mailbox In olApp.Session.Folders
            Dim TBAccount As New TextBox
            Dim LbAccountName As New Label

            LbAccountName.Text = mailbox.Name
            LbAccountName.Name = mailbox.Name

            MsgBox(mailbox.Name)

            ArAccounts(i) = mailbox.Name

            i += 1
            x = i * 100
            FmAccount.Controls.Add(LbAccountName)

            With LbAccountName
                .Height = 60
                .Width = 400
                .Top = x
                .Left = 20
            End With

            FmAccount.Controls.Add(TBAccount)

            With TBAccount
                .Height = 60
                .Width = 400
                .Top = x
                .Left = 480
            End With

        Next

        Dim BtAccountsOK As New Button
        Dim BtAccountsCancel As New Button

        FmAccount.Controls.Add(BtAccountsCancel)
        FmAccount.Controls.Add(BtAccountsOK)

        With BtAccountsOK
            .Top = x + 20
            .Left = 480
        End With

        With BtAccountsCancel
            .Top = x + 20
            .Left = 20
        End With

        With FmAccount
            .Show()
        End With

    End Sub

    Private Sub BtHelp_Click(sender As Object, e As RibbonControlEventArgs) Handles BtHelp.Click
        Dim olApp As New Outlook.Application
        Dim accounts As Outlook.Accounts = olApp.Session.Accounts
        Dim oForm As New FmHelp

        Dim oInspector As Outlook.Inspector = olApp.ActiveInspector
        Dim item As MailItem
        If oInspector Is Nothing Then
            item = olApp.ActiveExplorer.Selection.Item(1)
        Else
            item = oInspector.CurrentItem
        End If

        If item.ReceivedByName Like "Est Bo-Order" Then
            Url = New Uri("G:\BSS DF FR\BO Documentation\Manuais\HTMversion\QM-GBS O2C PT DI 1 1 -FR-003  Back Office Order - Direct Sales.htm")
        ElseIf item.ReceivedByName Like "Scpi Bo-Order" Then
            Url = New Uri("G:\BSS DF FR\BO Documentation\Manuais\HTMversion\QM-GBS O2C PT DI 1 1 -FR-004 Back Office Order - SiPlan.htm")
        Else
            Process.Start("G:\BSS DF FR\BO Documentation\Manuais\HTMversion\")
        End If

        oForm.WebBrowser1.Url = Url
        oForm.Show()

    End Sub

    Private Sub BtCheckList_Click(sender As Object, e As RibbonControlEventArgs) Handles BtCheckList.Click, EBClient.TextChanged

        checkList()

    End Sub

    Public Function GetWorkbook(ByVal sFullName As String) As Workbook

        Dim xlapp As New Excel.Application
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

    End Function

    Private Sub BtSearch_Click(sender As Object, e As RibbonControlEventArgs) Handles BtSearch.Click, EBSearchOrder.TextChanged
        Dim i As Integer
        Dim path As String()
        Dim olApp As New Outlook.Application
        Dim OrigEmail As Outlook.MailItem = olApp.ActiveExplorer.Selection(1)
        savePathWindows(0) = My.Settings.Account1SPW
        savePathWindows(1) = My.Settings.Account2SPW
        savePathWindows(2) = My.Settings.Account3SPW
        savePathWindows(3) = My.Settings.Account4SPW
        savePathWindows(4) = My.Settings.Account5SPW
        savePathOutlook(0) = My.Settings.Account1SPO
        savePathOutlook(1) = My.Settings.Account2SPO
        savePathOutlook(2) = My.Settings.Account3SPO
        savePathOutlook(3) = My.Settings.Account4SPO
        savePathOutlook(4) = My.Settings.Account5SPO

        Dim mbname As MAPIFolder = OrigEmail.Parent
        Dim mailboxname As String
        mailboxname = mbname.Store.DisplayName
        For Each mailbox In olApp.Session.Folders
            If mailbox.Name Like "Public*" Or Nothing Then
                GoTo skip





            Else
                temp(i) = mailbox.Name

                i += 1
            End If
skip:

        Next
        temp = SortArrayAtoZ(temp)

        i = -1



        Do
            i += 1


        Loop Until mailboxname = temp(i)





        If CBSearchFolders.Checked = False Then
            path = Directory.GetDirectories(savePathWindows(i), EBSearchOrder.Text & "*", SearchOption.TopDirectoryOnly)
        Else
            path = Directory.GetFiles(savePathWindows(i), EBSearchOrder.Text & "*", SearchOption.TopDirectoryOnly)
        End If

        Dim file As String


        For Each file In path
            'MsgBox(file)
            Process.Start(file)
        Next



    End Sub

    Private Sub BtCreditControl_Click(sender As Object, e As RibbonControlEventArgs) Handles BtCreditControl.Click

        Dim strTitleForm1 As String
        Dim oForm As Form4

        oForm = New Form4()
        oForm.Text = "Credit Control"
        strTitleForm1 = oForm.Text

        My.Settings.strTitleForm1 = oForm.Text
        My.Settings.Save()
        oForm.Show()

    End Sub
    Sub SaveMail()
        Dim strObject As String


        Dim olApp As New Outlook.Application
        Dim OrigEmail As Outlook.MailItem = olApp.ActiveExplorer.Selection(1)

        Dim mailbox As Folder
        Dim accountform As New Form5

        Dim i As Integer
        savePathWindows(0) = My.Settings.Account1SPW
        savePathWindows(1) = My.Settings.Account2SPW
        savePathWindows(2) = My.Settings.Account3SPW
        savePathWindows(3) = My.Settings.Account4SPW
        savePathWindows(4) = My.Settings.Account5SPW
        savePathOutlook(0) = My.Settings.Account1SPO
        savePathOutlook(1) = My.Settings.Account2SPO
        savePathOutlook(2) = My.Settings.Account3SPO
        savePathOutlook(3) = My.Settings.Account4SPO
        savePathOutlook(4) = My.Settings.Account5SPO
        ' Dim oInspector As Outlook.Inspector = olApp.ActiveInspector
        ' If oInspector Is Nothing Then
        ' OrigEmail = olApp.ActiveExplorer.Selection.Item(1)
        '  Else
        'OrigEmail = oInspector.CurrentItem
        '  End If


        strClientNumber = RTrim(EBClientName.Text)
        'strClientNumber.TrimEnd()

        Dim mbname As MAPIFolder = OrigEmail.Parent
        Dim mailboxname As String
        mailboxname = mbname.Store.DisplayName
        For Each mailbox In olApp.Session.Folders
            If mailbox.Name Like "Public*" Or Nothing Then
                GoTo skip





            Else
                temp(i) = mailbox.Name

                i += 1
            End If
skip:

        Next
        temp = SortArrayAtoZ(temp)

        i = -1



        Do
            i += 1
            strSavePathW = savePathWindows(i) & "\" & orderNumber & " " & strClientNumber & "\"

        Loop Until mailboxname = temp(i)

        If Not System.IO.Directory.Exists(strSavePathW) Then

            System.IO.Directory.CreateDirectory(strSavePathW)
        End If


        If strSavePathW = "" Then
            strSavePathW = defaultPath
        End If
        With OrigEmail

            strObject = .Subject
            .SaveAs(strSavePathW & RemoveIllegalCharacters(strObject) & ".msg")
            '.Close(SaveMode:=True)
        End With

    End Sub

    Function RemoveIllegalCharacters(strValue As String) As String

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

    Public Shared WithEvents myOlExp As Outlook.Explorer

    Public Sub Initialize_handler()

        myOlExp = myOlExp.Application.ActiveExplorer

    End Sub

    Private Sub myOlExp_SelectionChange()

        saveItem()
    End Sub

    Private Sub BtAccounts_Click(sender As Object, e As RibbonControlEventArgs) Handles BtAccounts.Click
        Dim oform As Form
        oform = New Form5
        oform.Show()

    End Sub

    Private Sub saveItem()

        Dim olApp As New Outlook.Application
        Dim oInspector As Outlook.Inspector = olApp.ActiveInspector
        Dim OrigEmail As Outlook.MailItem = GetCurrentItem() 'olApp.ActiveExplorer.Selection(1)
        Dim strSubject As String
        Dim newSubject As String
        Dim ns As Outlook.NameSpace
        Dim moveToFolder As Outlook.Folder

        ' If oInspector Is Nothing Then
        'OrigEmail = olApp.ActiveExplorer.Selection.Item(1)
        '  Else
        'OrigEmail = oInspector.CurrentItem
        ' End If

        orderNumber = EBOrderNumber.Text

        If EBClientName.Text = "" Then
            MsgBox("Please enter the client number.")
            Exit Sub
        End If
        If EBOrderNumber.Text = "" Then
            MsgBox("Please enter the order number.")
            Exit Sub
        End If

        strSubject = OrigEmail.Subject

        If strSubject.Contains(orderNumber) = False Then

            newSubject = orderNumber & " // " & strSubject
        Else
            newSubject = strSubject
        End If
        Dim mbname As MAPIFolder = OrigEmail.Parent
        Dim mailboxname As String
        mailboxname = mbname.Store.DisplayName
        OrigEmail.Subject = newSubject
        OrigEmail.Save()
        SaveMail()
        ns = olApp.Application.GetNamespace("MAPI")
        Dim i As Integer
        'MsgBox(item.ReceivedByName)
        i = -1
        Do
            i += 1

        Loop Until mailboxname Like temp(i)
        moveToFolder = GetFolder(savePathOutlook(i))
        If CBCreditCheck.Checked = False Then


            OrigEmail.Move(moveToFolder)

        Else
            Dim cporigEmail As MailItem
            cporigEmail = OrigEmail.Copy
            OrigEmail.Move(moveToFolder)
            cporigEmail.Categories = "Credit Check"
            cporigEmail.Save()
            CBCreditCheck.Checked = False
        End If


    End Sub

    Function GetFolder(ByVal FolderPath As String) As Outlook.Folder
        Dim TestFolder As Outlook.Folder
        Dim FoldersArray As Object

        Dim i As Integer
        Dim olApp As New Outlook.Application
        Dim objns As [NameSpace] = olApp.GetNamespace("MAPI")
        ' On Error GoTo GetFolder_Error
        If Left(FolderPath, 2) = "\\" Then
            FolderPath = Right(FolderPath, Len(FolderPath) - 2)
        End If
        'Convert folderpath to array 
        FoldersArray = Split(FolderPath, "/")
        TestFolder = olApp.Session.Folders.Item(FoldersArray(0))
        If Not TestFolder Is Nothing Then
            For i = 1 To UBound(FoldersArray, 1)
                Dim SubFolders As Outlook.Folders
                SubFolders = TestFolder.Folders
                TestFolder = SubFolders.Item(FoldersArray(i))
                If TestFolder Is Nothing Then
                    GetFolder = Nothing
                End If
            Next
        End If
        'Return the TestFolder 
        GetFolder = TestFolder
        Exit Function

GetFolder_Error:
        GetFolder = Nothing
        Exit Function
    End Function

    Private Sub CBAutoCheck_Click(sender As Object, e As RibbonControlEventArgs) Handles CBAutoCheck.Click
        My.Settings.CBautoSearch = CBAutoCheck.Checked

        My.Settings.Save()

    End Sub



    Private Sub IdentifyItem()
        On Error Resume Next
        Dim olApp As New Outlook.Application
        Dim clientName As String
        Dim OrigEmail As Outlook.MailItem = GetCurrentItem()
        EBClientName.Text = ""
        EBOrderNumber.Text = ""

        'Dim ClientsConnectionString As String




        ' On Error GoTo ErrorHandler
        If OrigEmail.Subject.IndexOf("customer", 0) <> -1 Then


            strClientNumber = Mid(OrigEmail.Subject, OrigEmail.Subject.IndexOf("customer", 0) + 10, 10)

        Else

            found = Mid(OrigEmail.Subject, OrigEmail.Subject.IndexOf("Acc:", 0), OrigEmail.Subject.IndexOf("Acc:", 0) + 14)
            If found = Nothing Then
                strClientNumber = Mid(OrigEmail.Subject, OrigEmail.Subject.IndexOf("_", 0) + 2, 10)

            Else
                strClientNumber = found
            End If
        End If
        EBClientNumber.Text = strClientNumber
        On Error Resume Next
        Dim begin As Integer = OrigEmail.Body.IndexOf("N° Commande client", 0) + 20
        Dim ending As Integer = OrigEmail.Body.IndexOf("Date de la", 0) - 1
        Dim ClientOrderNumber As String = Mid(OrigEmail.Body, begin, ending - begin)

        On Error Resume Next

        If OrigEmail.Subject.IndexOf("310", 0) <> -1 Then
            EBOrderNumber.Text = Mid(OrigEmail.Subject, OrigEmail.Subject.IndexOf("3"c, 0) + 1, 9)
        Else
            EBOrderNumber.Text = "N/A"
        End If



        If ClientOrderNumber <> "" Then
            EBClientRef.Text = ClientOrderNumber.Trim()
        Else
            EBClientRef.Text = "N/A"
        End If
        '
        ' Dim theConnectionString As New Data.OleDb.OleDbConnection
        '  theConnectionString.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Clients.accdb"
        '  Dim theSQLStatement As String
        ' Dim adp As OleDbDataAdapter = New OleDbDataAdapter _
        '("select DF-PD Contact info.Customer Name From DF-PD Contact info where" & EBClientRef.Text & "EQUALS DF-PD Contact info.SAP Nbr", theConnectionString)

        '


        ' If xlBook Is Nothing Then
        xlBook = GetWorkbook(workbookname)
        xlsheet = xlBook.Worksheets("Klanten Jelle")
        '  Else


        '   End If


        Dim rng As Excel.Range
        With xlsheet.Range("b:b")
            rng = .Find(strClientNumber,
                        ,
               Excel.XlFindLookIn.xlValues,
               Excel.XlLookAt.xlWhole,
              Excel.XlSearchOrder.xlByRows,
               Excel.XlSearchDirection.xlNext,
               False)

            ' MsgBox(rng.Value)
            If Not rng Is Nothing Then
                EBClientName.Text = rng.Offset(, -1).Value

            Else
                EBListSpecs.Text = "No"
            End If

        End With
        On Error Resume Next
        xlBook.Close(SaveChanges:=False)

        'String = "select [DF-PD Contact info].""Customer Name"" From ""DF-PD Contact info"" where" & EBClientRef.Text & " = [DF-PD Contact info].""SAP Nbr"";"
        'MsgBox(begin & " " & ending & " " & ClientOrderNumber)
        Exit Sub

ErrorHandler:

        EBClientName.Text = "N/A"

        Resume Next
        'MsgBox(strClientNumber)




    End Sub

    Private Sub checkList()





        Dim xlBook As Excel.Workbook
        Dim xlsheet As Excel.Worksheet
        Dim workbookname As String

        workbookname = "C:\Users\z0041vad\Documents\Liste clients OEM-VD.xls"

        xlBook = GetWorkbook(workbookname)
        xlsheet = xlBook.Worksheets("est")

        Dim rng As Excel.Range
        Dim newImage As Image = Image.FromFile("D:\UserData\z0041vad\Documents\Privé\siemens.jpg")

        With xlsheet.Range("a:a")

            rng = .Find(strClientNumber,
                            ,
                Excel.XlFindLookIn.xlValues,
                Excel.XlLookAt.xlWhole,
                Excel.XlSearchOrder.xlByRows,
                Excel.XlSearchDirection.xlNext,
                False)
            If Not rng Is Nothing Then

                If rng.Interior.Color = RGB(0, 255, 153) Then
                    With EBListSpecs
                        .Text = "Yes"
                        .Image = newImage
                    End With
                Else
                    With EBListSpecs
                        .Text = "No"
                        .Image = newImage
                    End With
                End If
            Else
                EBListSpecs.Text = "No"
            End If

        End With

        xlsheet = xlBook.Worksheets("liste blanche")

        With xlsheet.Range("a:a")

            rng = .Find(strClientNumber,
                            ,
                Excel.XlFindLookIn.xlValues,
                Excel.XlLookAt.xlWhole,
                Excel.XlSearchOrder.xlByRows,
                Excel.XlSearchDirection.xlNext,
                False)

            If Not rng Is Nothing Then
                With EBListBlanche
                    .Text = "Yes"
                    .Image = newImage
                End With
            Else
                EBListBlanche.Text = "No"
            End If

        End With
        xlBook.Saved = True
        xlBook.Close()
    End Sub
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

    Function GetCurrentItem() As Object
        Dim objApp As Outlook.Application

        objApp = New Application
        On Error Resume Next
        Select Case TypeName(objApp.ActiveWindow)
            Case "Explorer"
                GetCurrentItem = objApp.ActiveExplorer.Selection.Item(1)
            Case "Inspector"
                GetCurrentItem = objApp.ActiveInspector.CurrentItem
        End Select

        objApp = Nothing
    End Function
End Class
