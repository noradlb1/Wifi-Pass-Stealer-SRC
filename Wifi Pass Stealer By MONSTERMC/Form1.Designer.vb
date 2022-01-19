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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ETheme1 = New Wifi_Pass_Stealer_By_MONSTERMC.ETheme()
        Me.EButton2 = New Wifi_Pass_Stealer_By_MONSTERMC.EButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EButton1 = New Wifi_Pass_Stealer_By_MONSTERMC.EButton()
        Me.ETheme1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ETheme1
        '
        Me.ETheme1.BackColor = System.Drawing.Color.White
        Me.ETheme1.Controls.Add(Me.EButton2)
        Me.ETheme1.Controls.Add(Me.Label4)
        Me.ETheme1.Controls.Add(Me.Label3)
        Me.ETheme1.Controls.Add(Me.Label2)
        Me.ETheme1.Controls.Add(Me.Label1)
        Me.ETheme1.Controls.Add(Me.EButton1)
        Me.ETheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ETheme1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.ETheme1.ForeColor = System.Drawing.Color.Black
        Me.ETheme1.Image = Nothing
        Me.ETheme1.Location = New System.Drawing.Point(0, 0)
        Me.ETheme1.MoveHeight = 20
        Me.ETheme1.Name = "ETheme1"
        Me.ETheme1.Resizable = False
        Me.ETheme1.Size = New System.Drawing.Size(160, 127)
        Me.ETheme1.TabIndex = 0
        Me.ETheme1.Text = "Wifi Pass Stealer"
        Me.ETheme1.TransparencyKey = System.Drawing.Color.Fuchsia
        '
        'EButton2
        '
        Me.EButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EButton2.Image = Nothing
        Me.EButton2.Location = New System.Drawing.Point(147, 3)
        Me.EButton2.Name = "EButton2"
        Me.EButton2.NoRounding = False
        Me.EButton2.Size = New System.Drawing.Size(10, 13)
        Me.EButton2.TabIndex = 5
        Me.EButton2.Text = "X"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.Label4.ForeColor = System.Drawing.Color.Brown
        Me.Label4.Location = New System.Drawing.Point(144, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(14, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "D"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.Label3.ForeColor = System.Drawing.Color.Brown
        Me.Label3.Location = New System.Drawing.Point(96, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "T"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.Label2.ForeColor = System.Drawing.Color.Brown
        Me.Label2.Location = New System.Drawing.Point(45, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Y"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.Label1.ForeColor = System.Drawing.Color.Brown
        Me.Label1.Location = New System.Drawing.Point(3, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "F"
        '
        'EButton1
        '
        Me.EButton1.Image = Nothing
        Me.EButton1.Location = New System.Drawing.Point(12, 25)
        Me.EButton1.Name = "EButton1"
        Me.EButton1.NoRounding = False
        Me.EButton1.Size = New System.Drawing.Size(136, 75)
        Me.EButton1.TabIndex = 0
        Me.EButton1.Text = "GRAB"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(160, 127)
        Me.Controls.Add(Me.ETheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ETheme1.ResumeLayout(False)
        Me.ETheme1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ETheme1 As ETheme
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents EButton1 As EButton
    Friend WithEvents EButton2 As EButton
End Class
