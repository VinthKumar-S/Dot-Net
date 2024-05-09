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
        Me.Label1 = New System.Windows.Forms.Label
        Me.disp = New System.Windows.Forms.Button
        Me.list1 = New System.Windows.Forms.ListView
        Me.list2 = New System.Windows.Forms.ListBox
        Me.t11 = New System.Windows.Forms.TextBox
        Me.res = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(182, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Display"
        '
        'disp
        '
        Me.disp.Location = New System.Drawing.Point(175, 199)
        Me.disp.Name = "disp"
        Me.disp.Size = New System.Drawing.Size(75, 23)
        Me.disp.TabIndex = 1
        Me.disp.Text = "Display"
        Me.disp.UseVisualStyleBackColor = True
        '
        'list1
        '
        Me.list1.Location = New System.Drawing.Point(44, 89)
        Me.list1.Name = "list1"
        Me.list1.Size = New System.Drawing.Size(121, 97)
        Me.list1.TabIndex = 2
        Me.list1.UseCompatibleStateImageBehavior = False
        '
        'list2
        '
        Me.list2.FormattingEnabled = True
        Me.list2.Location = New System.Drawing.Point(245, 89)
        Me.list2.Name = "list2"
        Me.list2.Size = New System.Drawing.Size(120, 95)
        Me.list2.TabIndex = 3
        '
        't11
        '
        Me.t11.Location = New System.Drawing.Point(245, 269)
        Me.t11.Name = "t11"
        Me.t11.Size = New System.Drawing.Size(100, 20)
        Me.t11.TabIndex = 4
        '
        'res
        '
        Me.res.Location = New System.Drawing.Point(245, 322)
        Me.res.Name = "res"
        Me.res.Size = New System.Drawing.Size(100, 20)
        Me.res.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 269)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 325)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Rollnumber"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(163, 361)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Submit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 449)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.res)
        Me.Controls.Add(Me.t11)
        Me.Controls.Add(Me.list2)
        Me.Controls.Add(Me.list1)
        Me.Controls.Add(Me.disp)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents disp As System.Windows.Forms.Button
    Friend WithEvents list1 As System.Windows.Forms.ListView
    Friend WithEvents list2 As System.Windows.Forms.ListBox
    Friend WithEvents t11 As System.Windows.Forms.TextBox
    Friend WithEvents res As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
