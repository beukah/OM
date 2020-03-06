<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CLBEmailAddress = New System.Windows.Forms.CheckedListBox()
        Me.TBClientNumber = New System.Windows.Forms.TextBox()
        Me.TBOrderNumber = New System.Windows.Forms.TextBox()
        Me.Client_Number = New System.Windows.Forms.Label()
        Me.Order_Number = New System.Windows.Forms.Label()
        Me.TBSapData = New System.Windows.Forms.TextBox()
        Me.BtClarify = New System.Windows.Forms.Button()
        Me.CBFollowUp = New System.Windows.Forms.CheckBox()
        Me.TBFollowUpDays = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CLBEmailAddress
        '
        Me.CLBEmailAddress.FormattingEnabled = True
        Me.CLBEmailAddress.Location = New System.Drawing.Point(103, 60)
        Me.CLBEmailAddress.Margin = New System.Windows.Forms.Padding(2)
        Me.CLBEmailAddress.Name = "CLBEmailAddress"
        Me.CLBEmailAddress.Size = New System.Drawing.Size(365, 49)
        Me.CLBEmailAddress.TabIndex = 0
        '
        'TBClientNumber
        '
        Me.TBClientNumber.Location = New System.Drawing.Point(204, 161)
        Me.TBClientNumber.Margin = New System.Windows.Forms.Padding(2)
        Me.TBClientNumber.Name = "TBClientNumber"
        Me.TBClientNumber.Size = New System.Drawing.Size(68, 20)
        Me.TBClientNumber.TabIndex = 1
        '
        'TBOrderNumber
        '
        Me.TBOrderNumber.Location = New System.Drawing.Point(204, 203)
        Me.TBOrderNumber.Margin = New System.Windows.Forms.Padding(2)
        Me.TBOrderNumber.Name = "TBOrderNumber"
        Me.TBOrderNumber.Size = New System.Drawing.Size(68, 20)
        Me.TBOrderNumber.TabIndex = 1
        '
        'Client_Number
        '
        Me.Client_Number.AutoSize = True
        Me.Client_Number.Location = New System.Drawing.Point(103, 161)
        Me.Client_Number.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Client_Number.Name = "Client_Number"
        Me.Client_Number.Size = New System.Drawing.Size(73, 13)
        Me.Client_Number.TabIndex = 2
        Me.Client_Number.Text = "Client Number"
        '
        'Order_Number
        '
        Me.Order_Number.AutoSize = True
        Me.Order_Number.Location = New System.Drawing.Point(103, 203)
        Me.Order_Number.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Order_Number.Name = "Order_Number"
        Me.Order_Number.Size = New System.Drawing.Size(73, 13)
        Me.Order_Number.TabIndex = 2
        Me.Order_Number.Text = "Order Number"
        '
        'TBSapData
        '
        Me.TBSapData.Location = New System.Drawing.Point(103, 255)
        Me.TBSapData.Margin = New System.Windows.Forms.Padding(2)
        Me.TBSapData.Multiline = True
        Me.TBSapData.Name = "TBSapData"
        Me.TBSapData.Size = New System.Drawing.Size(365, 111)
        Me.TBSapData.TabIndex = 3
        '
        'BtClarify
        '
        Me.BtClarify.Location = New System.Drawing.Point(311, 203)
        Me.BtClarify.Margin = New System.Windows.Forms.Padding(2)
        Me.BtClarify.Name = "BtClarify"
        Me.BtClarify.Size = New System.Drawing.Size(77, 20)
        Me.BtClarify.TabIndex = 4
        Me.BtClarify.Text = "Clarify"
        Me.BtClarify.UseVisualStyleBackColor = True
        '
        'CBFollowUp
        '
        Me.CBFollowUp.AutoSize = True
        Me.CBFollowUp.Location = New System.Drawing.Point(311, 161)
        Me.CBFollowUp.Margin = New System.Windows.Forms.Padding(2)
        Me.CBFollowUp.Name = "CBFollowUp"
        Me.CBFollowUp.Size = New System.Drawing.Size(73, 17)
        Me.CBFollowUp.TabIndex = 5
        Me.CBFollowUp.Text = "Follow Up"
        Me.CBFollowUp.UseVisualStyleBackColor = True
        '
        'TBFollowUpDays
        '
        Me.TBFollowUpDays.Location = New System.Drawing.Point(389, 161)
        Me.TBFollowUpDays.Name = "TBFollowUpDays"
        Me.TBFollowUpDays.Size = New System.Drawing.Size(22, 20)
        Me.TBFollowUpDays.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(437, 165)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Days"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 445)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TBFollowUpDays)
        Me.Controls.Add(Me.CBFollowUp)
        Me.Controls.Add(Me.BtClarify)
        Me.Controls.Add(Me.TBSapData)
        Me.Controls.Add(Me.Order_Number)
        Me.Controls.Add(Me.Client_Number)
        Me.Controls.Add(Me.TBOrderNumber)
        Me.Controls.Add(Me.TBClientNumber)
        Me.Controls.Add(Me.CLBEmailAddress)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CLBEmailAddress As Windows.Forms.CheckedListBox
    Friend WithEvents TBClientNumber As Windows.Forms.TextBox
    Friend WithEvents TBOrderNumber As Windows.Forms.TextBox
    Friend WithEvents Client_Number As Windows.Forms.Label
    Friend WithEvents Order_Number As Windows.Forms.Label
    Friend WithEvents TBSapData As Windows.Forms.TextBox
    Friend WithEvents BtClarify As Windows.Forms.Button
    Friend WithEvents CBFollowUp As Windows.Forms.CheckBox
    Friend WithEvents TBFollowUpDays As Windows.Forms.TextBox
    Friend WithEvents Label1 As Windows.Forms.Label
End Class
