Public Class FmSignature
    Dim strSignature

    ' Public property to expose favorite color to other classes
    Public Property StrMySignature As String
        Get

            ' Returns the value of the private variable
            Return StrSignature
        End Get
        Set(ByVal value As String)
            ' Sets the private variable to the specified value
            StrSignature = value
        End Set
    End Property



    Private Sub BtOKSignature_Click(sender As Object, e As EventArgs) Handles BtOKSignature.Click


        StrSignature = TBSignature.Text
        My.Settings.Signature = strSignature
        My.Settings.Save()
        Me.Close()

    End Sub

    Private Sub BtCancelSignature_Click(sender As Object, e As EventArgs) Handles BtCancelSignature.Click
        Me.Close()
    End Sub
End Class