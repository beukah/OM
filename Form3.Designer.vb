<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FmBody
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FmBody))
        Me.LbBodyPrice = New System.Windows.Forms.Label()
        Me.TBBodyPrice = New System.Windows.Forms.TextBox()
        Me.TBBodyRef = New System.Windows.Forms.TextBox()
        Me.TBBodyText = New System.Windows.Forms.TextBox()
        Me.BtBodyCancel = New System.Windows.Forms.Button()
        Me.BtBodyOK = New System.Windows.Forms.Button()
        Me.LbBodyRef = New System.Windows.Forms.Label()
        Me.LbBodyText = New System.Windows.Forms.Label()
        Me.TbBodyCreditControl = New System.Windows.Forms.TextBox()
        Me.LbBodyCreditControl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LbBodyPrice
        '
        Me.LbBodyPrice.AutoSize = True
        Me.LbBodyPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbBodyPrice.Location = New System.Drawing.Point(11, 128)
        Me.LbBodyPrice.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LbBodyPrice.Name = "LbBodyPrice"
        Me.LbBodyPrice.Size = New System.Drawing.Size(124, 26)
        Me.LbBodyPrice.TabIndex = 4
        Me.LbBodyPrice.Text = "Body Price:"
        '
        'TBBodyPrice
        '
        Me.TBBodyPrice.Location = New System.Drawing.Point(169, 107)
        Me.TBBodyPrice.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TBBodyPrice.Multiline = True
        Me.TBBodyPrice.Name = "TBBodyPrice"
        Me.TBBodyPrice.Size = New System.Drawing.Size(487, 76)
        Me.TBBodyPrice.TabIndex = 3
        '
        'TBBodyRef
        '
        Me.TBBodyRef.Location = New System.Drawing.Point(169, 205)
        Me.TBBodyRef.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TBBodyRef.Multiline = True
        Me.TBBodyRef.Name = "TBBodyRef"
        Me.TBBodyRef.Size = New System.Drawing.Size(487, 76)
        Me.TBBodyRef.TabIndex = 3
        '
        'TBBodyText
        '
        Me.TBBodyText.Location = New System.Drawing.Point(169, 303)
        Me.TBBodyText.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TBBodyText.Multiline = True
        Me.TBBodyText.Name = "TBBodyText"
        Me.TBBodyText.Size = New System.Drawing.Size(487, 76)
        Me.TBBodyText.TabIndex = 3
        '
        'BtBodyCancel
        '
        Me.BtBodyCancel.Location = New System.Drawing.Point(238, 402)
        Me.BtBodyCancel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtBodyCancel.Name = "BtBodyCancel"
        Me.BtBodyCancel.Size = New System.Drawing.Size(109, 38)
        Me.BtBodyCancel.TabIndex = 6
        Me.BtBodyCancel.Text = "Cancel"
        Me.BtBodyCancel.UseVisualStyleBackColor = True
        '
        'BtBodyOK
        '
        Me.BtBodyOK.Location = New System.Drawing.Point(473, 402)
        Me.BtBodyOK.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtBodyOK.Name = "BtBodyOK"
        Me.BtBodyOK.Size = New System.Drawing.Size(109, 38)
        Me.BtBodyOK.TabIndex = 5
        Me.BtBodyOK.Text = "OK"
        Me.BtBodyOK.UseVisualStyleBackColor = True
        '
        'LbBodyRef
        '
        Me.LbBodyRef.AutoSize = True
        Me.LbBodyRef.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbBodyRef.Location = New System.Drawing.Point(11, 227)
        Me.LbBodyRef.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LbBodyRef.Name = "LbBodyRef"
        Me.LbBodyRef.Size = New System.Drawing.Size(108, 26)
        Me.LbBodyRef.TabIndex = 4
        Me.LbBodyRef.Text = "Body Ref:"
        '
        'LbBodyText
        '
        Me.LbBodyText.AutoSize = True
        Me.LbBodyText.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbBodyText.Location = New System.Drawing.Point(11, 324)
        Me.LbBodyText.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LbBodyText.Name = "LbBodyText"
        Me.LbBodyText.Size = New System.Drawing.Size(115, 26)
        Me.LbBodyText.TabIndex = 4
        Me.LbBodyText.Text = "Body Text:"
        '
        'TbBodyCreditControl
        '
        Me.TbBodyCreditControl.Location = New System.Drawing.Point(169, 11)
        Me.TbBodyCreditControl.Margin = New System.Windows.Forms.Padding(2)
        Me.TbBodyCreditControl.Multiline = True
        Me.TbBodyCreditControl.Name = "TbBodyCreditControl"
        Me.TbBodyCreditControl.Size = New System.Drawing.Size(487, 76)
        Me.TbBodyCreditControl.TabIndex = 3
        '
        'LbBodyCreditControl
        '
        Me.LbBodyCreditControl.AutoSize = True
        Me.LbBodyCreditControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbBodyCreditControl.Location = New System.Drawing.Point(11, 32)
        Me.LbBodyCreditControl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LbBodyCreditControl.Name = "LbBodyCreditControl"
        Me.LbBodyCreditControl.Size = New System.Drawing.Size(152, 26)
        Me.LbBodyCreditControl.TabIndex = 4
        Me.LbBodyCreditControl.Text = "Credit Control:"
        '
        'FmBody
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(695, 478)
        Me.Controls.Add(Me.BtBodyOK)
        Me.Controls.Add(Me.BtBodyCancel)
        Me.Controls.Add(Me.LbBodyText)
        Me.Controls.Add(Me.LbBodyRef)
        Me.Controls.Add(Me.LbBodyCreditControl)
        Me.Controls.Add(Me.LbBodyPrice)
        Me.Controls.Add(Me.TBBodyText)
        Me.Controls.Add(Me.TBBodyRef)
        Me.Controls.Add(Me.TbBodyCreditControl)
        Me.Controls.Add(Me.TBBodyPrice)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FmBody"
        Me.Text = "Body"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LbBodyPrice As Windows.Forms.Label
    Friend WithEvents TBBodyPrice As Windows.Forms.TextBox
    Friend WithEvents TBBodyRef As Windows.Forms.TextBox
    Friend WithEvents TBBodyText As Windows.Forms.TextBox
    Friend WithEvents BtBodyCancel As Windows.Forms.Button
    Friend WithEvents BtBodyOK As Windows.Forms.Button
    Friend WithEvents LbBodyRef As Windows.Forms.Label
    Friend WithEvents LbBodyText As Windows.Forms.Label
    Friend WithEvents TbBodyCreditControl As Windows.Forms.TextBox
    Friend WithEvents LbBodyCreditControl As Windows.Forms.Label
End Class
