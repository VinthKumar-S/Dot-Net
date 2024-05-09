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
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.rate = New System.Windows.Forms.TextBox
        Me.Time = New System.Windows.Forms.TextBox
        Me.princ = New System.Windows.Forms.TextBox
        Me.cmp = New System.Windows.Forms.RadioButton
        Me.sim = New System.Windows.Forms.RadioButton
        Me.submit = New System.Windows.Forms.Button
        Me.res = New System.Windows.Forms.Label
        Me.La = New System.Windows.Forms.Label
        Me.clear = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(173, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Simple And Compound Interest"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Princple Amount"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Rate Of Interest"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "No of Time"
        '
        'rate
        '
        Me.rate.Location = New System.Drawing.Point(156, 118)
        Me.rate.Name = "rate"
        Me.rate.Size = New System.Drawing.Size(100, 20)
        Me.rate.TabIndex = 4
        '
        'Time
        '
        Me.Time.Location = New System.Drawing.Point(156, 157)
        Me.Time.Name = "Time"
        Me.Time.Size = New System.Drawing.Size(100, 20)
        Me.Time.TabIndex = 5
        '
        'princ
        '
        Me.princ.Location = New System.Drawing.Point(156, 77)
        Me.princ.Name = "princ"
        Me.princ.Size = New System.Drawing.Size(100, 20)
        Me.princ.TabIndex = 6
        '
        'cmp
        '
        Me.cmp.AutoSize = True
        Me.cmp.Location = New System.Drawing.Point(211, 233)
        Me.cmp.Name = "cmp"
        Me.cmp.Size = New System.Drawing.Size(114, 17)
        Me.cmp.TabIndex = 7
        Me.cmp.TabStop = True
        Me.cmp.Text = "Compound Interest"
        Me.cmp.UseVisualStyleBackColor = True
        '
        'sim
        '
        Me.sim.AutoSize = True
        Me.sim.Location = New System.Drawing.Point(69, 233)
        Me.sim.Name = "sim"
        Me.sim.Size = New System.Drawing.Size(94, 17)
        Me.sim.TabIndex = 8
        Me.sim.TabStop = True
        Me.sim.Text = "Simple Interest"
        Me.sim.UseVisualStyleBackColor = True
        '
        'submit
        '
        Me.submit.Location = New System.Drawing.Point(88, 281)
        Me.submit.Name = "submit"
        Me.submit.Size = New System.Drawing.Size(75, 23)
        Me.submit.TabIndex = 9
        Me.submit.Text = "Submit"
        Me.submit.UseVisualStyleBackColor = True
        '
        'res
        '
        Me.res.AutoSize = True
        Me.res.Location = New System.Drawing.Point(194, 328)
        Me.res.Name = "res"
        Me.res.Size = New System.Drawing.Size(0, 13)
        Me.res.TabIndex = 10
        '
        'La
        '
        Me.La.AutoSize = True
        Me.La.Location = New System.Drawing.Point(124, 328)
        Me.La.Name = "La"
        Me.La.Size = New System.Drawing.Size(40, 13)
        Me.La.TabIndex = 11
        Me.La.Text = "Result:"
        '
        'clear
        '
        Me.clear.Location = New System.Drawing.Point(223, 281)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(75, 23)
        Me.clear.TabIndex = 12
        Me.clear.Text = "Clear"
        Me.clear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 371)
        Me.Controls.Add(Me.clear)
        Me.Controls.Add(Me.La)
        Me.Controls.Add(Me.res)
        Me.Controls.Add(Me.submit)
        Me.Controls.Add(Me.sim)
        Me.Controls.Add(Me.cmp)
        Me.Controls.Add(Me.princ)
        Me.Controls.Add(Me.Time)
        Me.Controls.Add(Me.rate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents rate As System.Windows.Forms.TextBox
    Friend WithEvents Time As System.Windows.Forms.TextBox
    Friend WithEvents princ As System.Windows.Forms.TextBox
    Friend WithEvents cmp As System.Windows.Forms.RadioButton
    Friend WithEvents sim As System.Windows.Forms.RadioButton
    Friend WithEvents submit As System.Windows.Forms.Button
    Friend WithEvents res As System.Windows.Forms.Label
    Friend WithEvents La As System.Windows.Forms.Label
    Friend WithEvents clear As System.Windows.Forms.Button

End Class
