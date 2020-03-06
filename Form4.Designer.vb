<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.TbAmount = New System.Windows.Forms.TextBox()
        Me.LbAmount = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.BtOkCreditControl = New System.Windows.Forms.Button()
        Me.TBOrderNumber = New System.Windows.Forms.TextBox()
        Me.LbOrderNumber = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TbAmount
        '
        Me.TbAmount.Location = New System.Drawing.Point(282, 88)
        Me.TbAmount.Name = "TbAmount"
        Me.TbAmount.Size = New System.Drawing.Size(100, 20)
        Me.TbAmount.TabIndex = 0
        '
        'LbAmount
        '
        Me.LbAmount.AutoSize = True
        Me.LbAmount.Location = New System.Drawing.Point(171, 91)
        Me.LbAmount.Name = "LbAmount"
        Me.LbAmount.Size = New System.Drawing.Size(46, 13)
        Me.LbAmount.TabIndex = 1
        Me.LbAmount.Text = "Montant"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(174, 129)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(428, 186)
        Me.RichTextBox1.TabIndex = 2
        Me.RichTextBox1.Text = ""
        '
        'BtOkCreditControl
        '
        Me.BtOkCreditControl.Location = New System.Drawing.Point(270, 372)
        Me.BtOkCreditControl.Name = "BtOkCreditControl"
        Me.BtOkCreditControl.Size = New System.Drawing.Size(75, 23)
        Me.BtOkCreditControl.TabIndex = 3
        Me.BtOkCreditControl.Text = "Ok"
        Me.BtOkCreditControl.UseVisualStyleBackColor = True
        '
        'TBOrderNumber
        '
        Me.TBOrderNumber.Location = New System.Drawing.Point(282, 50)
        Me.TBOrderNumber.Name = "TBOrderNumber"
        Me.TBOrderNumber.Size = New System.Drawing.Size(100, 20)
        Me.TBOrderNumber.TabIndex = 0
        '
        'LbOrderNumber
        '
        Me.LbOrderNumber.AutoSize = True
        Me.LbOrderNumber.Location = New System.Drawing.Point(171, 53)
        Me.LbOrderNumber.Name = "LbOrderNumber"
        Me.LbOrderNumber.Size = New System.Drawing.Size(73, 13)
        Me.LbOrderNumber.TabIndex = 1
        Me.LbOrderNumber.Text = "Order Number"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtOkCreditControl)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.LbOrderNumber)
        Me.Controls.Add(Me.TBOrderNumber)
        Me.Controls.Add(Me.LbAmount)
        Me.Controls.Add(Me.TbAmount)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TbAmount As Windows.Forms.TextBox
    Friend WithEvents LbAmount As Windows.Forms.Label
    Friend WithEvents RichTextBox1 As Windows.Forms.RichTextBox
    Friend WithEvents BtOkCreditControl As Windows.Forms.Button
    Friend WithEvents TBOrderNumber As Windows.Forms.TextBox
    Friend WithEvents LbOrderNumber As Windows.Forms.Label
End Class
