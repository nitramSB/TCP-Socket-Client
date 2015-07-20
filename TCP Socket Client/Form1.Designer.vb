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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.ReplyTextField = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.TakeUsername = New System.Windows.Forms.Button()
        Me.UsernameTextbox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.Update = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListViewOnline = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Enabled = False
        Me.RichTextBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.RichTextBox1.Location = New System.Drawing.Point(16, 196)
        Me.RichTextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(355, 176)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'ReplyTextField
        '
        Me.ReplyTextField.Enabled = False
        Me.ReplyTextField.Location = New System.Drawing.Point(16, 388)
        Me.ReplyTextField.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ReplyTextField.Name = "ReplyTextField"
        Me.ReplyTextField.Size = New System.Drawing.Size(355, 93)
        Me.ReplyTextField.TabIndex = 3
        Me.ReplyTextField.Text = "Test"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 22)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Public Chat:"
        '
        'UsernameLabel
        '
        Me.UsernameLabel.AutoSize = True
        Me.UsernameLabel.Font = New System.Drawing.Font("Palatino Linotype", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.ForeColor = System.Drawing.Color.Black
        Me.UsernameLabel.Location = New System.Drawing.Point(123, 128)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(133, 22)
        Me.UsernameLabel.TabIndex = 14
        Me.UsernameLabel.Text = "Username status"
        '
        'TakeUsername
        '
        Me.TakeUsername.Location = New System.Drawing.Point(75, 75)
        Me.TakeUsername.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TakeUsername.Name = "TakeUsername"
        Me.TakeUsername.Size = New System.Drawing.Size(258, 50)
        Me.TakeUsername.TabIndex = 13
        Me.TakeUsername.Text = "Take username"
        Me.TakeUsername.UseVisualStyleBackColor = True
        '
        'UsernameTextbox
        '
        Me.UsernameTextbox.Location = New System.Drawing.Point(75, 42)
        Me.UsernameTextbox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.UsernameTextbox.Name = "UsernameTextbox"
        Me.UsernameTextbox.Size = New System.Drawing.Size(257, 26)
        Me.UsernameTextbox.TabIndex = 12
        Me.UsernameTextbox.Text = "Dave"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(115, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Choose a nickname"
        '
        'SubmitButton
        '
        Me.SubmitButton.Enabled = False
        Me.SubmitButton.Location = New System.Drawing.Point(14, 486)
        Me.SubmitButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(356, 44)
        Me.SubmitButton.TabIndex = 10
        Me.SubmitButton.Text = "Submit"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'Update
        '
        Me.Update.Interval = 500
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(494, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(237, 49)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Users Online"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(503, 372)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(185, 58)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListViewOnline
        '
        Me.ListViewOnline.Location = New System.Drawing.Point(468, 84)
        Me.ListViewOnline.Name = "ListViewOnline"
        Me.ListViewOnline.Size = New System.Drawing.Size(281, 198)
        Me.ListViewOnline.TabIndex = 20
        Me.ListViewOnline.UseCompatibleStateImageBehavior = False
        '
        'Form1
        '
        Me.AcceptButton = Me.SubmitButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(872, 540)
        Me.Controls.Add(Me.ListViewOnline)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.TakeUsername)
        Me.Controls.Add(Me.UsernameTextbox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SubmitButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ReplyTextField)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "AnonyChat"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents ReplyTextField As System.Windows.Forms.RichTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents TakeUsername As System.Windows.Forms.Button
    Friend WithEvents UsernameTextbox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SubmitButton As System.Windows.Forms.Button
    Friend WithEvents Update As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ListViewOnline As System.Windows.Forms.ListView

End Class
