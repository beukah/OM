Public Class FmBody
    Dim strBodyPrice As String
    Dim strBodyRef As String
    Dim strBodyText As String
    Dim strBodyCreditControl As String
    Dim oForm As FmBody



    Private Sub BtBodyOK_Click(sender As Object, e As EventArgs) Handles BtBodyOK.Click
        strBodyPrice = TBBodyPrice.Text
        strBodyRef = TBBodyRef.Text
        strBodyText = TBBodyText.Text
        strBodyCreditControl = TbBodyCreditControl.Text
        My.Settings.BodyPrice = strBodyPrice
        My.Settings.BodyRef = strBodyRef
        My.Settings.BodyText = strBodyText
        My.Settings.BodyCreditControl = strBodyCreditControl
        My.Settings.Save()
        Me.Close()
    End Sub

    Private Sub BtBodyCancel_Click(sender As Object, e As EventArgs) Handles BtBodyCancel.Click
        Me.Close()
    End Sub
End Class