<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmSignature
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FmSignature))
        Me.TBSignature = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtCancelSignature = New System.Windows.Forms.Button()
        Me.BtOKSignature = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TBSignature
        '
        Me.TBSignature.Location = New System.Drawing.Point(162, 71)
        Me.TBSignature.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TBSignature.Multiline = True
        Me.TBSignature.Name = "TBSignature"
        Me.TBSignature.Size = New System.Drawing.Size(307, 129)
        Me.TBSignature.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 26)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "My Signature:"
        '
        'BtCancelSignature
        '
        Me.BtCancelSignature.Location = New System.Drawing.Point(189, 234)
        Me.BtCancelSignature.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtCancelSignature.Name = "BtCancelSignature"
        Me.BtCancelSignature.Size = New System.Drawing.Size(76, 28)
        Me.BtCancelSignature.TabIndex = 2
        Me.BtCancelSignature.Text = "Cancel"
        Me.BtCancelSignature.UseVisualStyleBackColor = True
        '
        'BtOKSignature
        '
        Me.BtOKSignature.Location = New System.Drawing.Point(348, 234)
        Me.BtOKSignature.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtOKSignature.Name = "BtOKSignature"
        Me.BtOKSignature.Size = New System.Drawing.Size(76, 28)
        Me.BtOKSignature.TabIndex = 2
        Me.BtOKSignature.Text = "OK"
        Me.BtOKSignature.UseVisualStyleBackColor = True
        '
        'FmSignature
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 292)
        Me.Controls.Add(Me.BtOKSignature)
        Me.Controls.Add(Me.BtCancelSignature)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TBSignature)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "FmSignature"
        Me.Text = "Signature"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TBSignature As Windows.Forms.TextBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents BtCancelSignature As Windows.Forms.Button
    Friend WithEvents BtOKSignature As Windows.Forms.Button
End Class
