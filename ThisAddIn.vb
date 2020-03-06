
Imports System.Windows.Forms
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Outlook
Imports Microsoft.Office.Tools.Ribbon

Public Class ThisAddIn
    Private UserControl1 As UserControl
    Private myCustomTaskPane As Microsoft.Office.Tools.CustomTaskPane
    Dim WithEvents currentExplorer As Outlook.Explorer = Nothing

    Private Declare Function SetParent Lib "user32" (ByVal hWndChild As Long,
ByVal hWndNewParent As Long) As Long

    Private Declare Function FindWindow Lib "user32" Alias "FindWindowA" _
(ByVal lpClassName As String, ByVal lpWindowName As String) As Long









    Private Sub ThisAddIn_Shutdown() Handles Me.Shutdown

    End Sub

End Class
