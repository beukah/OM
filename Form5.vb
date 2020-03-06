Imports System.Windows.Forms
Imports Microsoft.Office.Interop.Outlook



Public Class Form5
    Public savePathWindows(0 To 4) As String
    Public savePathOutlook(0 To 4) As String

    Public temp(0 To 4) As String
    Public olApp As New Outlook.Application
    Public accounts As Outlook.Accounts = olApp.Session.Accounts

    Public i As Integer = 0
    Public FmAccount As New Form
    Public ArAccounts(10) As String
    Public x As Integer

    Public mailbox As Folder
    Public textboxW(0 To 4) As TextBox
    Public textboxO(0 To 4) As TextBox
    Public TBadress(0 To 4) As TextBox
    Public strEmailAdress(0 To 4) As String

    Public Sub BtOptionsAccountOK_Click(sender As Object, e As EventArgs) Handles BtOptionsAccountOK.Click

        textboxW(0) = TBAcSPW1
        textboxW(1) = TBAcSPW2
        textboxW(2) = TBAcSPW3
        textboxW(3) = TBAcSPW4
        textboxW(4) = TBAcSPW5
        textboxO(0) = TBAcSPO1
        textboxO(1) = TBAcSPO2
        textboxO(2) = TBAcSPO3
        textboxO(3) = TBAcSPO4
        textboxO(4) = TBAcSPO5
        TBadress(0) = TBEmailAdress1
        TBadress(1) = TBEmailAdress2
        TBadress(2) = TBEmailAdress3
        TBadress(3) = TBEmailAdress4
        TBadress(4) = TBEmailAdress5

        For Each mailbox In olApp.Session.Folders
            strEmailAdress(i) = TBadress(i).Text
            savePathWindows(i) = textboxW(i).Text
            savePathOutlook(i) = textboxO(i).Text
            If i = 4 Then
                Exit For
            End If
            If strEmailAdress(i) = "" Then
                strEmailAdress(i) = "* * *"

            End If

            i += 1

        Next



        My.Settings.Account1SPW = savePathWindows(0)
        My.Settings.Account2SPW = savePathWindows(1)
        My.Settings.Account3SPW = savePathWindows(2)
        My.Settings.Account4SPW = savePathWindows(3)
        My.Settings.Account5SPW = savePathWindows(4)
        My.Settings.Account1SPO = savePathOutlook(0)
        My.Settings.Account2SPO = savePathOutlook(1)
        My.Settings.Account3SPO = savePathOutlook(2)
        My.Settings.Account4SPO = savePathOutlook(3)
        My.Settings.Account5SPO = savePathOutlook(4)
        My.Settings.TBadress1 = strEmailAdress(0)
        My.Settings.TBadress2 = strEmailAdress(1)
        My.Settings.TBadress3 = strEmailAdress(2)
        My.Settings.TBadress4 = strEmailAdress(3)
        My.Settings.TBadress5 = strEmailAdress(4)

        My.Settings.Save()


        Me.Close()

    End Sub

    Private Sub FolderBrowserDialog1_HelpRequest(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim i As Integer
        Dim olApp As New Outlook.Application



        TBAcSPW1.Text = My.Settings.Account1SPW
        TBAcSPW2.Text = My.Settings.Account2SPW
        TBAcSPW3.Text = My.Settings.Account3SPW
        TBAcSPW4.Text = My.Settings.Account4SPW
        TBAcSPW5.Text = My.Settings.Account5SPW
        TBAcSPO1.Text = My.Settings.Account1SPO
        TBAcSPO2.Text = My.Settings.Account2SPO
        TBAcSPO3.Text = My.Settings.Account3SPO
        TBAcSPO4.Text = My.Settings.Account4SPO
        TBAcSPO5.Text = My.Settings.Account5SPO
        TBEmailAdress1.Text = My.Settings.TBadress1
        TBEmailAdress2.Text = My.Settings.TBadress2
        TBEmailAdress3.Text = My.Settings.TBadress3
        TBEmailAdress4.Text = My.Settings.TBadress4
        TBEmailAdress5.Text = My.Settings.TBadress5
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
        LbAccount1.Text = temp(0)
        LbAccount2.Text = temp(1)
        LbAccount3.Text = temp(2)
        LbAccount4.Text = temp(3)
        LbAccount5.Text = temp(4)



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

    Private Sub FolderBrowserDialog1_HelpRequest_1(sender As Object, e As EventArgs) Handles FolderBrowserDialog1.HelpRequest

    End Sub

    Private Sub BtBrowseW1_Click(sender As Object, e As EventArgs) Handles BtBrowseW1.Click
        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            TBAcSPW1.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub
    Private Sub BtBrowseW2_Click(sender As Object, e As EventArgs) Handles BtBrowseW2.Click
        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            TBAcSPW2.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub BtBrowseW3_Click(sender As Object, e As EventArgs) Handles BtBrowseW3.Click
        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            TBAcSPW3.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub BtBrowseW4_Click(sender As Object, e As EventArgs) Handles BtBrowseW4.Click
        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            TBAcSPW4.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub BtBrowseW5_Click(sender As Object, e As EventArgs) Handles BtBrowseW5.Click
        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            TBAcSPW5.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Public Sub BtBrowseO1_Click(sender As Object, e As EventArgs) Handles BtBrowseO1.Click

        Dim pick As MAPIFolder
        pick = olApp.GetNamespace("mapi").PickFolder
        TBAcSPO1.Text = pick.FolderPath
        TBAcSPO1.Text = Replace(TBAcSPO1.Text, "\\", "")
        TBAcSPO1.Text = Replace(TBAcSPO1.Text, "\", "/")
    End Sub

    Public Sub BtBrowseO2_Click(sender As Object, e As EventArgs) Handles BtBrowseO2.Click

        Dim pick As MAPIFolder
        pick = olApp.GetNamespace("mapi").PickFolder
        TBAcSPO2.Text = pick.FolderPath
        TBAcSPO2.Text = Replace(TBAcSPO2.Text, "\\", "")
        TBAcSPO2.Text = Replace(TBAcSPO2.Text, "\", "/")
    End Sub

    Public Sub BtBrowseO3_Click(sender As Object, e As EventArgs) Handles BtBrowseO3.Click

        Dim pick As MAPIFolder
        pick = olApp.GetNamespace("mapi").PickFolder
        TBAcSPO3.Text = pick.FolderPath
        TBAcSPO3.Text = Replace(TBAcSPO3.Text, "\\", "")
        TBAcSPO3.Text = Replace(TBAcSPO3.Text, "\", "/")
    End Sub

    Public Sub BtBrowseO4_Click(sender As Object, e As EventArgs) Handles BtBrowseO4.Click

        Dim pick As MAPIFolder
        pick = olApp.GetNamespace("mapi").PickFolder
        TBAcSPO4.Text = pick.FolderPath
        TBAcSPO4.Text = Replace(TBAcSPO4.Text, "\\", "")
        TBAcSPO4.Text = Replace(TBAcSPO4.Text, "\", "/")
    End Sub

    Public Sub BtBrowseO5_Click(sender As Object, e As EventArgs) Handles BtBrowseO5.Click

        Dim pick As MAPIFolder
        pick = olApp.GetNamespace("mapi").PickFolder
        TBAcSPO5.Text = pick.FolderPath
        TBAcSPO5.Text = Replace(TBAcSPO5.Text, "\\", "")
        TBAcSPO5.Text = Replace(TBAcSPO5.Text, "\", "/")
    End Sub

    Private Sub BtOptionsAccountCancel_Click(sender As Object, e As EventArgs) Handles BtOptionsAccountCancel.Click
        Me.Close()
    End Sub
End Class