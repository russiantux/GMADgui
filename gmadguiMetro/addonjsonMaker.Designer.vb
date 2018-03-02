<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addonjsonMaker
    Inherits MetroFramework.Forms.MetroForm

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
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.addonType = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.addonName = New MetroFramework.Controls.MetroTextBox()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 143)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(84, 19)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Addon Type:"
        '
        'addonType
        '
        Me.addonType.FormattingEnabled = True
        Me.addonType.ItemHeight = 23
        Me.addonType.Items.AddRange(New Object() {"Server Content", "Gamemode", "Map", "Weapon", "Vehicle", "NPC", "Tool", "Effects", "Model"})
        Me.addonType.Location = New System.Drawing.Point(23, 165)
        Me.addonType.Name = "addonType"
        Me.addonType.Size = New System.Drawing.Size(271, 29)
        Me.addonType.TabIndex = 1
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(24, 77)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(92, 19)
        Me.MetroLabel2.TabIndex = 2
        Me.MetroLabel2.Text = "Addon Name:"
        '
        'addonName
        '
        Me.addonName.Location = New System.Drawing.Point(24, 100)
        Me.addonName.Name = "addonName"
        Me.addonName.Size = New System.Drawing.Size(271, 23)
        Me.addonName.TabIndex = 3
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(67, 277)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(75, 23)
        Me.MetroButton1.TabIndex = 4
        Me.MetroButton1.Text = "Generate"
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(165, 277)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(75, 23)
        Me.MetroButton2.TabIndex = 5
        Me.MetroButton2.Text = "Cancel"
        '
        'addonjsonMaker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 430)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.addonName)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.addonType)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Name = "addonjsonMaker"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Purple
        Me.Text = "addon.json Generator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents addonType As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents addonName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
End Class
