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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.goUrl = New System.Windows.Forms.TextBox()
        Me.urlResponseText = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(167, 213)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 28)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "sendRequest"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'goUrl
        '
        Me.goUrl.Location = New System.Drawing.Point(12, 216)
        Me.goUrl.Name = "goUrl"
        Me.goUrl.Size = New System.Drawing.Size(149, 22)
        Me.goUrl.TabIndex = 1
        '
        'urlResponseText
        '
        Me.urlResponseText.Location = New System.Drawing.Point(12, 12)
        Me.urlResponseText.Multiline = True
        Me.urlResponseText.Name = "urlResponseText"
        Me.urlResponseText.Size = New System.Drawing.Size(258, 173)
        Me.urlResponseText.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 253)
        Me.Controls.Add(Me.urlResponseText)
        Me.Controls.Add(Me.goUrl)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents goUrl As System.Windows.Forms.TextBox
    Friend WithEvents urlResponseText As System.Windows.Forms.TextBox

End Class
