Partial Class Ribbon1
    Inherits Microsoft.Office.Tools.Ribbon.RibbonBase

    <System.Diagnostics.DebuggerNonUserCode()>
    Public Sub New(ByVal container As System.ComponentModel.IContainer)
        MyClass.New()

        'Required for Windows.Forms Class Composition Designer support
        If (container IsNot Nothing) Then
            container.Add(Me)
        End If

    End Sub

    <System.Diagnostics.DebuggerNonUserCode()>
    Public Sub New()
        MyBase.New(Globals.Factory.GetRibbonFactory())

        'This call is required by the Component Designer.
        InitializeComponent()

    End Sub

    'Component overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Component Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Component Designer
    'It can be modified using the Component Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Tab1 = Me.Factory.CreateRibbonTab
        Me.Group1 = Me.Factory.CreateRibbonGroup
        Me.Box2 = Me.Factory.CreateRibbonBox
        Me.EBClientName = Me.Factory.CreateRibbonEditBox
        Me.EBOrderNumber = Me.Factory.CreateRibbonEditBox
        Me.EBClientRef = Me.Factory.CreateRibbonEditBox
        Me.EBClientNumber = Me.Factory.CreateRibbonEditBox
        Me.Button2 = Me.Factory.CreateRibbonButton
        Me.Button1 = Me.Factory.CreateRibbonButton
        Me.Group2 = Me.Factory.CreateRibbonGroup
        Me.BtClPrice = Me.Factory.CreateRibbonButton
        Me.BtClRef = Me.Factory.CreateRibbonButton
        Me.BtClText = Me.Factory.CreateRibbonButton
        Me.BtCreditControl = Me.Factory.CreateRibbonButton
        Me.GrCheckList = Me.Factory.CreateRibbonGroup
        Me.Box3 = Me.Factory.CreateRibbonBox
        Me.EBClient = Me.Factory.CreateRibbonEditBox
        Me.BtCheckList = Me.Factory.CreateRibbonButton
        Me.CBAutoCheck = Me.Factory.CreateRibbonCheckBox
        Me.EBListBlanche = Me.Factory.CreateRibbonEditBox
        Me.EBListSpecs = Me.Factory.CreateRibbonEditBox
        Me.GrSearch = Me.Factory.CreateRibbonGroup
        Me.BtSearch = Me.Factory.CreateRibbonButton
        Me.EBSearchOrder = Me.Factory.CreateRibbonEditBox
        Me.GrHelp = Me.Factory.CreateRibbonGroup
        Me.BtHelp = Me.Factory.CreateRibbonButton
        Me.Settings = Me.Factory.CreateRibbonGroup
        Me.BtAccounts = Me.Factory.CreateRibbonButton
        Me.Clarifications = Me.Factory.CreateRibbonMenu
        Me.BtSignature = Me.Factory.CreateRibbonButton
        Me.BtBody = Me.Factory.CreateRibbonButton
        Me.CheckBox1 = Me.Factory.CreateRibbonCheckBox
        Me.CBCreditCheck = Me.Factory.CreateRibbonCheckBox
        Me.Tab1.SuspendLayout()
        Me.Group1.SuspendLayout()
        Me.Box2.SuspendLayout()
        Me.Group2.SuspendLayout()
        Me.GrCheckList.SuspendLayout()
        Me.Box3.SuspendLayout()
        Me.GrSearch.SuspendLayout()
        Me.GrHelp.SuspendLayout()
        Me.Settings.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tab1
        '
        Me.Tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office
        Me.Tab1.Groups.Add(Me.Group1)
        Me.Tab1.Groups.Add(Me.Group2)
        Me.Tab1.Groups.Add(Me.GrCheckList)
        Me.Tab1.Groups.Add(Me.GrSearch)
        Me.Tab1.Groups.Add(Me.GrHelp)
        Me.Tab1.Groups.Add(Me.Settings)
        Me.Tab1.Label = "SAP"
        Me.Tab1.Name = "Tab1"
        '
        'Group1
        '
        Me.Group1.Items.Add(Me.Box2)
        Me.Group1.Items.Add(Me.Button2)
        Me.Group1.Items.Add(Me.Button1)
        Me.Group1.Items.Add(Me.CBCreditCheck)
        Me.Group1.Label = "Identify Order Number and Save"
        Me.Group1.Name = "Group1"
        '
        'Box2
        '
        Me.Box2.BoxStyle = Microsoft.Office.Tools.Ribbon.RibbonBoxStyle.Vertical
        Me.Box2.Items.Add(Me.EBClientName)
        Me.Box2.Items.Add(Me.EBOrderNumber)
        Me.Box2.Items.Add(Me.EBClientRef)
        Me.Box2.Items.Add(Me.EBClientNumber)
        Me.Box2.Name = "Box2"
        '
        'EBClientName
        '
        Me.EBClientName.Label = "Client Name"
        Me.EBClientName.Name = "EBClientName"
        Me.EBClientName.Text = Nothing
        '
        'EBOrderNumber
        '
        Me.EBOrderNumber.Label = "Order Number"
        Me.EBOrderNumber.Name = "EBOrderNumber"
        Me.EBOrderNumber.Text = Nothing
        '
        'EBClientRef
        '
        Me.EBClientRef.Label = "Client Reference"
        Me.EBClientRef.Name = "EBClientRef"
        Me.EBClientRef.Text = Nothing
        '
        'EBClientNumber
        '
        Me.EBClientNumber.Label = "Client Number"
        Me.EBClientNumber.Name = "EBClientNumber"
        Me.EBClientNumber.Text = Nothing
        '
        'Button2
        '
        Me.Button2.Label = "Get Client Nr"
        Me.Button2.Name = "Button2"
        '
        'Button1
        '
        Me.Button1.Label = "Save"
        Me.Button1.Name = "Button1"
        '
        'Group2
        '
        Me.Group2.Items.Add(Me.BtClPrice)
        Me.Group2.Items.Add(Me.BtClRef)
        Me.Group2.Items.Add(Me.BtClText)
        Me.Group2.Items.Add(Me.BtCreditControl)
        Me.Group2.Label = "Clarify"
        Me.Group2.Name = "Group2"
        '
        'BtClPrice
        '
        Me.BtClPrice.Label = "Clarify Price"
        Me.BtClPrice.Name = "BtClPrice"
        '
        'BtClRef
        '
        Me.BtClRef.Label = "Clarify Ref"
        Me.BtClRef.Name = "BtClRef"
        '
        'BtClText
        '
        Me.BtClText.Label = "Clarify Text"
        Me.BtClText.Name = "BtClText"
        '
        'BtCreditControl
        '
        Me.BtCreditControl.Label = "Controle Crédit"
        Me.BtCreditControl.Name = "BtCreditControl"
        '
        'GrCheckList
        '
        Me.GrCheckList.Items.Add(Me.Box3)
        Me.GrCheckList.Items.Add(Me.EBListBlanche)
        Me.GrCheckList.Items.Add(Me.EBListSpecs)
        Me.GrCheckList.Label = "Check List"
        Me.GrCheckList.Name = "GrCheckList"
        '
        'Box3
        '
        Me.Box3.BoxStyle = Microsoft.Office.Tools.Ribbon.RibbonBoxStyle.Vertical
        Me.Box3.Items.Add(Me.EBClient)
        Me.Box3.Items.Add(Me.BtCheckList)
        Me.Box3.Items.Add(Me.CBAutoCheck)
        Me.Box3.Name = "Box3"
        '
        'EBClient
        '
        Me.EBClient.Label = "Client"
        Me.EBClient.Name = "EBClient"
        Me.EBClient.Text = Nothing
        '
        'BtCheckList
        '
        Me.BtCheckList.Label = "Check"
        Me.BtCheckList.Name = "BtCheckList"
        '
        'CBAutoCheck
        '
        Me.CBAutoCheck.Label = "Auto Check"
        Me.CBAutoCheck.Name = "CBAutoCheck"
        '
        'EBListBlanche
        '
        Me.EBListBlanche.Label = "Check Liste Blanche"
        Me.EBListBlanche.Name = "EBListBlanche"
        Me.EBListBlanche.Text = Nothing
        '
        'EBListSpecs
        '
        Me.EBListSpecs.Label = "Check Specs"
        Me.EBListSpecs.Name = "EBListSpecs"
        Me.EBListSpecs.Text = Nothing
        '
        'GrSearch
        '
        Me.GrSearch.Items.Add(Me.BtSearch)
        Me.GrSearch.Items.Add(Me.EBSearchOrder)
        Me.GrSearch.Label = "Search"
        Me.GrSearch.Name = "GrSearch"
        '
        'BtSearch
        '
        Me.BtSearch.Label = "Search"
        Me.BtSearch.Name = "BtSearch"
        '
        'EBSearchOrder
        '
        Me.EBSearchOrder.Label = "Order Number"
        Me.EBSearchOrder.Name = "EBSearchOrder"
        Me.EBSearchOrder.Text = Nothing
        '
        'GrHelp
        '
        Me.GrHelp.Items.Add(Me.BtHelp)
        Me.GrHelp.Items.Add(Me.CheckBox1)
        Me.GrHelp.Label = "Help"
        Me.GrHelp.Name = "GrHelp"
        '
        'BtHelp
        '
        Me.BtHelp.Label = "Help"
        Me.BtHelp.Name = "BtHelp"
        '
        'Settings
        '
        Me.Settings.Items.Add(Me.BtAccounts)
        Me.Settings.Items.Add(Me.Clarifications)
        Me.Settings.Label = "Settings"
        Me.Settings.Name = "Settings"
        '
        'BtAccounts
        '
        Me.BtAccounts.Label = "Accounts"
        Me.BtAccounts.Name = "BtAccounts"
        '
        'Clarifications
        '
        Me.Clarifications.Items.Add(Me.BtSignature)
        Me.Clarifications.Items.Add(Me.BtBody)
        Me.Clarifications.Label = "Clarifications"
        Me.Clarifications.Name = "Clarifications"
        '
        'BtSignature
        '
        Me.BtSignature.Label = "Signature"
        Me.BtSignature.Name = "BtSignature"
        Me.BtSignature.ShowImage = True
        '
        'BtBody
        '
        Me.BtBody.Label = "Body"
        Me.BtBody.Name = "BtBody"
        Me.BtBody.ShowImage = True
        '
        'CheckBox1
        '
        Me.CheckBox1.Label = "CheckBox1"
        Me.CheckBox1.Name = "CheckBox1"
        '
        'CBCreditCheck
        '
        Me.CBCreditCheck.Label = "Credit Check"
        Me.CBCreditCheck.Name = "CBCreditCheck"
        '
        'Ribbon1
        '
        Me.Name = "Ribbon1"
        Me.RibbonType = "Microsoft.Outlook.Explorer, Microsoft.Outlook.Journal, Microsoft.Outlook.Mail.Com" &
    "pose, Microsoft.Outlook.Mail.Read"
        Me.Tabs.Add(Me.Tab1)
        Me.Tab1.ResumeLayout(False)
        Me.Tab1.PerformLayout()
        Me.Group1.ResumeLayout(False)
        Me.Group1.PerformLayout()
        Me.Box2.ResumeLayout(False)
        Me.Box2.PerformLayout()
        Me.Group2.ResumeLayout(False)
        Me.Group2.PerformLayout()
        Me.GrCheckList.ResumeLayout(False)
        Me.GrCheckList.PerformLayout()
        Me.Box3.ResumeLayout(False)
        Me.Box3.PerformLayout()
        Me.GrSearch.ResumeLayout(False)
        Me.GrSearch.PerformLayout()
        Me.GrHelp.ResumeLayout(False)
        Me.GrHelp.PerformLayout()
        Me.Settings.ResumeLayout(False)
        Me.Settings.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Tab1 As Microsoft.Office.Tools.Ribbon.RibbonTab
    Friend WithEvents Group1 As Microsoft.Office.Tools.Ribbon.RibbonGroup
    Friend WithEvents EBOrderNumber As Microsoft.Office.Tools.Ribbon.RibbonEditBox
    Friend WithEvents Group2 As Microsoft.Office.Tools.Ribbon.RibbonGroup
    Friend WithEvents BtClPrice As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents BtClRef As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents BtClText As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents Settings As Microsoft.Office.Tools.Ribbon.RibbonGroup
    Friend WithEvents Clarifications As Microsoft.Office.Tools.Ribbon.RibbonMenu
    Friend WithEvents BtSignature As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents BtBody As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents GrHelp As Microsoft.Office.Tools.Ribbon.RibbonGroup
    Friend WithEvents BtHelp As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents GrCheckList As Microsoft.Office.Tools.Ribbon.RibbonGroup
    Friend WithEvents BtCheckList As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents EBListSpecs As Microsoft.Office.Tools.Ribbon.RibbonEditBox
    Friend WithEvents EBListBlanche As Microsoft.Office.Tools.Ribbon.RibbonEditBox
    Friend WithEvents EBClient As Microsoft.Office.Tools.Ribbon.RibbonEditBox
    Friend WithEvents BtCreditControl As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents EBClientName As Microsoft.Office.Tools.Ribbon.RibbonEditBox
    Friend WithEvents Button2 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents Button1 As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents GrSearch As Microsoft.Office.Tools.Ribbon.RibbonGroup
    Friend WithEvents BtSearch As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents EBSearchOrder As Microsoft.Office.Tools.Ribbon.RibbonEditBox
    Friend WithEvents EBClientRef As Microsoft.Office.Tools.Ribbon.RibbonEditBox
    Friend WithEvents BtAccounts As Microsoft.Office.Tools.Ribbon.RibbonButton
    Friend WithEvents Box2 As Microsoft.Office.Tools.Ribbon.RibbonBox
    Friend WithEvents Box3 As Microsoft.Office.Tools.Ribbon.RibbonBox
    Friend WithEvents CBAutoCheck As Microsoft.Office.Tools.Ribbon.RibbonCheckBox
    Friend WithEvents EBClientNumber As Microsoft.Office.Tools.Ribbon.RibbonEditBox
    Friend WithEvents CBCreditCheck As Microsoft.Office.Tools.Ribbon.RibbonCheckBox
    Friend WithEvents CheckBox1 As Microsoft.Office.Tools.Ribbon.RibbonCheckBox
End Class

Partial Class ThisRibbonCollection

    <System.Diagnostics.DebuggerNonUserCode()> _
    Friend ReadOnly Property Ribbon1() As Ribbon1
        Get
            Return Me.GetRibbon(Of Ribbon1)()
        End Get
    End Property
End Class
