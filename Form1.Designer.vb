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
        Label1 = New Label()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        txtcode = New TextBox()
        Label3 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Monotype Corsiva", 22.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Red
        Label1.Location = New Point(277, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(291, 45)
        Label1.TabIndex = 0
        Label1.Text = "QR Code Generator"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ButtonFace
        Label2.Font = New Font("Tempus Sans ITC", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(257, 66)
        Label2.Name = "Label2"
        Label2.Size = New Size(317, 30)
        Label2.TabIndex = 1
        Label2.Text = "Use Message to generate QR"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BorderStyle = BorderStyle.Fixed3D
        PictureBox1.Location = New Point(240, 112)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(310, 233)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' txtcode
        ' 
        txtcode.Location = New Point(240, 358)
        txtcode.Multiline = True
        txtcode.Name = "txtcode"
        txtcode.Size = New Size(310, 31)
        txtcode.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(141, 370)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(84, 18)
        Label3.TabIndex = 4
        Label3.Text = "Code Here:"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        Button1.Location = New Point(240, 462)
        Button1.Name = "Button1"
        Button1.Size = New Size(135, 65)
        Button1.TabIndex = 5
        Button1.Text = "Generate Code"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        Button2.Location = New Point(406, 462)
        Button2.Name = "Button2"
        Button2.Size = New Size(144, 65)
        Button2.TabIndex = 6
        Button2.Text = "Export to Image"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(9F, 18F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(781, 641)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label3)
        Controls.Add(txtcode)
        Controls.Add(PictureBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Microsoft Sans Serif", 9F)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "QR Code Generator"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtcode As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button

End Class
