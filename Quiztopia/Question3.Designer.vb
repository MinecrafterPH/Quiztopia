﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Question3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Question3))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 15.0!)
        Me.Label2.Location = New System.Drawing.Point(69, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 30)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "2x + 9 = 69. Find x."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.0!)
        Me.Label1.Location = New System.Drawing.Point(80, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 23)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "QUESTION #3"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(155, 211)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(120, 52)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "x = 69"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(29, 211)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(120, 52)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "x = 30"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(155, 153)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(120, 52)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "x = 39"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(29, 153)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 52)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "x = 15"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Question3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(304, 291)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Question3"
        Me.Text = "Question #3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
