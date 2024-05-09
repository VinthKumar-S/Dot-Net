<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Insert = New System.Windows.Forms.Button
        Me.create = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Insert
        '
        Me.Insert.Location = New System.Drawing.Point(100, 95)
        Me.Insert.Name = "Insert"
        Me.Insert.Size = New System.Drawing.Size(75, 23)
        Me.Insert.TabIndex = 0
        Me.Insert.Text = "Insert"
        Me.Insert.UseVisualStyleBackColor = True
        '
        'create
        '
        Me.create.Location = New System.Drawing.Point(257, 95)
        Me.create.Name = "create"
        Me.create.Size = New System.Drawing.Size(75, 23)
        Me.create.TabIndex = 1
        Me.create.Text = "create"
        Me.create.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(140, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Table Creation And Insertion"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(481, 262)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.create)
        Me.Controls.Add(Me.Insert)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Insert As System.Windows.Forms.Button
    Friend WithEvents create As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
