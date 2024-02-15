<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        TextBox1 = New TextBox()
        txtFirstnum = New Label()
        TextBox2 = New TextBox()
        txtSecondnum = New Label()
        Button1 = New Button()
        lblResult = New Label()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(12, 57)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 0
        ' 
        ' txtFirstnum
        ' 
        txtFirstnum.AutoSize = True
        txtFirstnum.Location = New Point(12, 39)
        txtFirstnum.Name = "txtFirstnum"
        txtFirstnum.Size = New Size(50, 15)
        txtFirstnum.TabIndex = 1
        txtFirstnum.Text = "1st num"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(12, 116)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 0
        ' 
        ' txtSecondnum
        ' 
        txtSecondnum.AutoSize = True
        txtSecondnum.Location = New Point(12, 98)
        txtSecondnum.Name = "txtSecondnum"
        txtSecondnum.Size = New Size(53, 15)
        txtSecondnum.TabIndex = 1
        txtSecondnum.Text = "2nd sum"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(12, 158)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 2
        Button1.Text = "Try"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' lblResult
        ' 
        lblResult.AutoSize = True
        lblResult.Location = New Point(71, 211)
        lblResult.Name = "lblResult"
        lblResult.Size = New Size(39, 15)
        lblResult.TabIndex = 3
        lblResult.Text = "Result"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(432, 392)
        Controls.Add(lblResult)
        Controls.Add(Button1)
        Controls.Add(txtSecondnum)
        Controls.Add(TextBox2)
        Controls.Add(txtFirstnum)
        Controls.Add(TextBox1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtFirstnum As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents txtSecondnum As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents lblResult As Label
End Class
