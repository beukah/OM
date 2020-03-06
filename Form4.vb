Public Class Form4

    Dim olApp As New Outlook.Application
    Dim oInspector As Outlook.Inspector = olApp.ActiveInspector
    Dim OrigEmail As Outlook.MailItem = olApp.ActiveExplorer.Selection(1)
    Dim forwardEmail As Outlook.MailItem = olApp.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem)
    Dim strSignature As String = My.Settings.Signature.Replace(vbCrLf, "<br>")
    Dim strBodyCreditControl As String = My.Settings.BodyCreditControl.Replace(vbCrLf, "<br>")
    Dim subjectorig, strOrderNumber As String
    Private Sub BtOkCreditControl_Click(sender As Object, e As EventArgs) Handles BtOkCreditControl.Click
        subjectOrig = OrigEmail.Subject
        strOrderNumber = TBOrderNumber.Text

        subjectorig = strOrderNumber & " // Crédit Controle // " & subjectorig
        OrigEmail.Subject = subjectOrig


        With forwardEmail
            .To = OrigEmail.Forward.To
            .HTMLBody = "<br>" & strBodyCreditControl & "<br>" & "<br>" & strSignature & "<br>" & "<br>" & OrigEmail.Reply.HTMLBody
            .Subject = subjectOrig
            '.SendUsingAccount = OrigEmail.ReceivedByEntryID
            .Recipients.ResolveAll()
            .Recipients.Add("Jocelyn Ployaert")
            .Display()
        End With


        Me.Close()



    End Sub
End Class