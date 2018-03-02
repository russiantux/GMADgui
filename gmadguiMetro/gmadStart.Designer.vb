<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class gmadStart
    Inherits MetroFramework.Forms.MetroForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(gmadStart))
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.warningPanel = New MetroFramework.Controls.MetroPanel()
        Me.warningtxt1 = New MetroFramework.Controls.MetroLabel()
        Me.Warningpic1 = New System.Windows.Forms.PictureBox()
        Me.ExtractBut = New MetroFramework.Controls.MetroButton()
        Me.extractProg1 = New MetroFramework.Controls.MetroProgressBar()
        Me.extractBut2 = New MetroFramework.Controls.MetroButton()
        Me.extractBut1 = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.folPath1 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.gmaBox1 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.warningtxt2 = New MetroFramework.Controls.MetroLabel()
        Me.warningPic2 = New System.Windows.Forms.PictureBox()
        Me.compressProg = New MetroFramework.Controls.MetroProgressBar()
        Me.MetroButton4 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton5 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton6 = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.folSelcBox1 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.folSelcBox = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTabPage3 = New MetroFramework.Controls.MetroTabPage()
        Me.latestVer = New System.Windows.Forms.Label()
        Me.MetroButton7 = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroButton8 = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.gmadSettingPath = New MetroFramework.Controls.MetroTextBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.MetroTabPage4 = New MetroFramework.Controls.MetroTabPage()
        Me.addonjsonMake = New MetroFramework.Controls.MetroCheckBox()
        Me.MetroTabControl1.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        Me.warningPanel.SuspendLayout()
        CType(Me.Warningpic1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroTabPage2.SuspendLayout()
        Me.MetroPanel1.SuspendLayout()
        CType(Me.warningPic2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroTabPage3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage1)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage2)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage4)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage3)
        Me.MetroTabControl1.HotTrack = True
        Me.MetroTabControl1.Location = New System.Drawing.Point(4, 63)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 1
        Me.MetroTabControl1.ShowToolTips = True
        Me.MetroTabControl1.Size = New System.Drawing.Size(684, 311)
        Me.MetroTabControl1.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroTabControl1.TabIndex = 5
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.Controls.Add(Me.warningPanel)
        Me.MetroTabPage1.Controls.Add(Me.ExtractBut)
        Me.MetroTabPage1.Controls.Add(Me.extractProg1)
        Me.MetroTabPage1.Controls.Add(Me.extractBut2)
        Me.MetroTabPage1.Controls.Add(Me.extractBut1)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel2)
        Me.MetroTabPage1.Controls.Add(Me.folPath1)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel1)
        Me.MetroTabPage1.Controls.Add(Me.gmaBox1)
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 35)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(676, 272)
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.Text = "Extract"
        Me.MetroTabPage1.ToolTipText = "Extract .gma files to a selected folder"
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        '
        'warningPanel
        '
        Me.warningPanel.Controls.Add(Me.warningtxt1)
        Me.warningPanel.Controls.Add(Me.Warningpic1)
        Me.warningPanel.HorizontalScrollbarBarColor = True
        Me.warningPanel.HorizontalScrollbarHighlightOnWheel = False
        Me.warningPanel.HorizontalScrollbarSize = 10
        Me.warningPanel.Location = New System.Drawing.Point(229, 185)
        Me.warningPanel.Name = "warningPanel"
        Me.warningPanel.Size = New System.Drawing.Size(200, 31)
        Me.warningPanel.TabIndex = 10
        Me.warningPanel.VerticalScrollbarBarColor = True
        Me.warningPanel.VerticalScrollbarHighlightOnWheel = False
        Me.warningPanel.VerticalScrollbarSize = 10
        '
        'warningtxt1
        '
        Me.warningtxt1.AutoSize = True
        Me.warningtxt1.CustomForeColor = True
        Me.warningtxt1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.warningtxt1.Location = New System.Drawing.Point(33, 8)
        Me.warningtxt1.Name = "warningtxt1"
        Me.warningtxt1.Size = New System.Drawing.Size(161, 19)
        Me.warningtxt1.TabIndex = 3
        Me.warningtxt1.Text = "gmad.exe not configured!"
        '
        'Warningpic1
        '
        Me.Warningpic1.BackColor = System.Drawing.Color.Transparent
        Me.Warningpic1.Image = CType(resources.GetObject("Warningpic1.Image"), System.Drawing.Image)
        Me.Warningpic1.Location = New System.Drawing.Point(3, 7)
        Me.Warningpic1.Name = "Warningpic1"
        Me.Warningpic1.Size = New System.Drawing.Size(24, 24)
        Me.Warningpic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Warningpic1.TabIndex = 2
        Me.Warningpic1.TabStop = False
        '
        'ExtractBut
        '
        Me.ExtractBut.Location = New System.Drawing.Point(282, 156)
        Me.ExtractBut.Name = "ExtractBut"
        Me.ExtractBut.Size = New System.Drawing.Size(75, 23)
        Me.ExtractBut.TabIndex = 9
        Me.ExtractBut.Text = "Extract"
        '
        'extractProg1
        '
        Me.extractProg1.Location = New System.Drawing.Point(-4, 261)
        Me.extractProg1.Name = "extractProg1"
        Me.extractProg1.Size = New System.Drawing.Size(684, 11)
        Me.extractProg1.TabIndex = 8
        '
        'extractBut2
        '
        Me.extractBut2.Location = New System.Drawing.Point(415, 108)
        Me.extractBut2.Name = "extractBut2"
        Me.extractBut2.Size = New System.Drawing.Size(48, 23)
        Me.extractBut2.TabIndex = 7
        Me.extractBut2.Text = "Select"
        '
        'extractBut1
        '
        Me.extractBut1.Location = New System.Drawing.Point(415, 42)
        Me.extractBut1.Name = "extractBut1"
        Me.extractBut1.Size = New System.Drawing.Size(48, 23)
        Me.extractBut1.TabIndex = 6
        Me.extractBut1.Text = "Select"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(15, 83)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(125, 19)
        Me.MetroLabel2.TabIndex = 5
        Me.MetroLabel2.Text = "Folder to Extract To"
        '
        'folPath1
        '
        Me.folPath1.Enabled = False
        Me.folPath1.Location = New System.Drawing.Point(16, 108)
        Me.folPath1.Name = "folPath1"
        Me.folPath1.Size = New System.Drawing.Size(392, 23)
        Me.folPath1.TabIndex = 4
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(15, 18)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(63, 19)
        Me.MetroLabel1.TabIndex = 3
        Me.MetroLabel1.Text = ".gma File"
        '
        'gmaBox1
        '
        Me.gmaBox1.Enabled = False
        Me.gmaBox1.Location = New System.Drawing.Point(15, 43)
        Me.gmaBox1.Name = "gmaBox1"
        Me.gmaBox1.Size = New System.Drawing.Size(393, 23)
        Me.gmaBox1.TabIndex = 2
        '
        'MetroTabPage2
        '
        Me.MetroTabPage2.Controls.Add(Me.addonjsonMake)
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel11)
        Me.MetroTabPage2.Controls.Add(Me.MetroPanel1)
        Me.MetroTabPage2.Controls.Add(Me.compressProg)
        Me.MetroTabPage2.Controls.Add(Me.MetroButton4)
        Me.MetroTabPage2.Controls.Add(Me.MetroButton5)
        Me.MetroTabPage2.Controls.Add(Me.MetroButton6)
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel3)
        Me.MetroTabPage2.Controls.Add(Me.folSelcBox1)
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel4)
        Me.MetroTabPage2.Controls.Add(Me.folSelcBox)
        Me.MetroTabPage2.HorizontalScrollbarBarColor = True
        Me.MetroTabPage2.Location = New System.Drawing.Point(4, 35)
        Me.MetroTabPage2.Name = "MetroTabPage2"
        Me.MetroTabPage2.Size = New System.Drawing.Size(676, 272)
        Me.MetroTabPage2.TabIndex = 1
        Me.MetroTabPage2.Text = "Compress"
        Me.MetroTabPage2.VerticalScrollbarBarColor = True
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.Location = New System.Drawing.Point(33, 239)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(591, 19)
        Me.MetroLabel11.TabIndex = 19
        Me.MetroLabel11.Text = "- Remember to add a addon.json to your mod folder! gmad.exe will not run if it do" &
    "esn't detect it! -"
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Controls.Add(Me.warningtxt2)
        Me.MetroPanel1.Controls.Add(Me.warningPic2)
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(230, 185)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(200, 31)
        Me.MetroPanel1.TabIndex = 18
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'warningtxt2
        '
        Me.warningtxt2.AutoSize = True
        Me.warningtxt2.CustomForeColor = True
        Me.warningtxt2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.warningtxt2.Location = New System.Drawing.Point(33, 8)
        Me.warningtxt2.Name = "warningtxt2"
        Me.warningtxt2.Size = New System.Drawing.Size(161, 19)
        Me.warningtxt2.TabIndex = 3
        Me.warningtxt2.Text = "gmad.exe not configured!"
        '
        'warningPic2
        '
        Me.warningPic2.Image = CType(resources.GetObject("warningPic2.Image"), System.Drawing.Image)
        Me.warningPic2.Location = New System.Drawing.Point(3, 7)
        Me.warningPic2.Name = "warningPic2"
        Me.warningPic2.Size = New System.Drawing.Size(24, 24)
        Me.warningPic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.warningPic2.TabIndex = 2
        Me.warningPic2.TabStop = False
        '
        'compressProg
        '
        Me.compressProg.Location = New System.Drawing.Point(-4, 261)
        Me.compressProg.Name = "compressProg"
        Me.compressProg.Size = New System.Drawing.Size(684, 11)
        Me.compressProg.TabIndex = 17
        '
        'MetroButton4
        '
        Me.MetroButton4.Location = New System.Drawing.Point(291, 156)
        Me.MetroButton4.Name = "MetroButton4"
        Me.MetroButton4.Size = New System.Drawing.Size(75, 23)
        Me.MetroButton4.TabIndex = 16
        Me.MetroButton4.Text = "Compress"
        '
        'MetroButton5
        '
        Me.MetroButton5.Location = New System.Drawing.Point(415, 108)
        Me.MetroButton5.Name = "MetroButton5"
        Me.MetroButton5.Size = New System.Drawing.Size(48, 23)
        Me.MetroButton5.TabIndex = 15
        Me.MetroButton5.Text = "Select"
        '
        'MetroButton6
        '
        Me.MetroButton6.Location = New System.Drawing.Point(415, 42)
        Me.MetroButton6.Name = "MetroButton6"
        Me.MetroButton6.Size = New System.Drawing.Size(48, 23)
        Me.MetroButton6.TabIndex = 14
        Me.MetroButton6.Text = "Select"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(15, 83)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(160, 19)
        Me.MetroLabel3.TabIndex = 13
        Me.MetroLabel3.Text = "Folder to output .gma file"
        '
        'folSelcBox1
        '
        Me.folSelcBox1.Enabled = False
        Me.folSelcBox1.Location = New System.Drawing.Point(16, 108)
        Me.folSelcBox1.Name = "folSelcBox1"
        Me.folSelcBox1.Size = New System.Drawing.Size(392, 23)
        Me.folSelcBox1.TabIndex = 12
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(15, 18)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(123, 19)
        Me.MetroLabel4.TabIndex = 11
        Me.MetroLabel4.Text = "Folder to compress"
        '
        'folSelcBox
        '
        Me.folSelcBox.Enabled = False
        Me.folSelcBox.Location = New System.Drawing.Point(15, 43)
        Me.folSelcBox.Name = "folSelcBox"
        Me.folSelcBox.Size = New System.Drawing.Size(393, 23)
        Me.folSelcBox.TabIndex = 10
        '
        'MetroTabPage3
        '
        Me.MetroTabPage3.Controls.Add(Me.latestVer)
        Me.MetroTabPage3.Controls.Add(Me.MetroButton7)
        Me.MetroTabPage3.Controls.Add(Me.MetroLabel10)
        Me.MetroTabPage3.Controls.Add(Me.PictureBox1)
        Me.MetroTabPage3.Controls.Add(Me.MetroLabel9)
        Me.MetroTabPage3.Controls.Add(Me.MetroLabel8)
        Me.MetroTabPage3.Controls.Add(Me.MetroLabel7)
        Me.MetroTabPage3.Controls.Add(Me.MetroButton8)
        Me.MetroTabPage3.Controls.Add(Me.MetroLabel5)
        Me.MetroTabPage3.Controls.Add(Me.MetroLabel6)
        Me.MetroTabPage3.Controls.Add(Me.gmadSettingPath)
        Me.MetroTabPage3.ForeColor = System.Drawing.Color.Red
        Me.MetroTabPage3.HorizontalScrollbarBarColor = True
        Me.MetroTabPage3.Location = New System.Drawing.Point(4, 35)
        Me.MetroTabPage3.Name = "MetroTabPage3"
        Me.MetroTabPage3.Size = New System.Drawing.Size(676, 272)
        Me.MetroTabPage3.TabIndex = 2
        Me.MetroTabPage3.Text = "Settings"
        Me.MetroTabPage3.VerticalScrollbarBarColor = True
        '
        'latestVer
        '
        Me.latestVer.AutoSize = True
        Me.latestVer.BackColor = System.Drawing.Color.Transparent
        Me.latestVer.ForeColor = System.Drawing.Color.Black
        Me.latestVer.Location = New System.Drawing.Point(323, 257)
        Me.latestVer.Name = "latestVer"
        Me.latestVer.Size = New System.Drawing.Size(39, 13)
        Me.latestVer.TabIndex = 28
        Me.latestVer.Text = "Label1"
        '
        'MetroButton7
        '
        Me.MetroButton7.Location = New System.Drawing.Point(469, 40)
        Me.MetroButton7.Name = "MetroButton7"
        Me.MetroButton7.Size = New System.Drawing.Size(48, 23)
        Me.MetroButton7.TabIndex = 27
        Me.MetroButton7.Text = "Clear"
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel10.Location = New System.Drawing.Point(565, 257)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(97, 15)
        Me.MetroLabel10.TabIndex = 26
        Me.MetroLabel10.Text = "reduxsoftware.net"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.gmadguiMetro.My.Resources.Resources.Logo
        Me.PictureBox1.Location = New System.Drawing.Point(550, 199)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(123, 55)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(189, 253)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(138, 19)
        Me.MetroLabel9.TabIndex = 23
        Me.MetroLabel9.Text = "Latest Online Version: "
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(106, 253)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(36, 19)
        Me.MetroLabel8.TabIndex = 22
        Me.MetroLabel8.Text = "1.2.1"
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(0, 253)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(111, 19)
        Me.MetroLabel7.TabIndex = 21
        Me.MetroLabel7.Text = "Current Version:  "
        '
        'MetroButton8
        '
        Me.MetroButton8.Location = New System.Drawing.Point(415, 40)
        Me.MetroButton8.Name = "MetroButton8"
        Me.MetroButton8.Size = New System.Drawing.Size(48, 23)
        Me.MetroButton8.TabIndex = 20
        Me.MetroButton8.Text = "Select"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(15, 81)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(0, 0)
        Me.MetroLabel5.TabIndex = 19
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(15, 16)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(117, 19)
        Me.MetroLabel6.TabIndex = 17
        Me.MetroLabel6.Text = "gmad.exe location"
        '
        'gmadSettingPath
        '
        Me.gmadSettingPath.Enabled = False
        Me.gmadSettingPath.Location = New System.Drawing.Point(15, 41)
        Me.gmadSettingPath.Name = "gmadSettingPath"
        Me.gmadSettingPath.Size = New System.Drawing.Size(393, 23)
        Me.gmadSettingPath.TabIndex = 16
        '
        'MetroTabPage4
        '
        Me.MetroTabPage4.HorizontalScrollbarBarColor = True
        Me.MetroTabPage4.Location = New System.Drawing.Point(4, 35)
        Me.MetroTabPage4.Name = "MetroTabPage4"
        Me.MetroTabPage4.Size = New System.Drawing.Size(676, 272)
        Me.MetroTabPage4.TabIndex = 3
        Me.MetroTabPage4.Text = "Upload"
        Me.MetroTabPage4.VerticalScrollbarBarColor = True
        '
        'addonjsonMake
        '
        Me.addonjsonMake.AutoSize = True
        Me.addonjsonMake.Location = New System.Drawing.Point(144, 22)
        Me.addonjsonMake.Name = "addonjsonMake"
        Me.addonjsonMake.Size = New System.Drawing.Size(137, 15)
        Me.addonjsonMake.TabIndex = 20
        Me.addonjsonMake.Text = "Generate addon.json?"
        Me.addonjsonMake.UseVisualStyleBackColor = True
        '
        'gmadStart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(693, 381)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "gmadStart"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Purple
        Me.Text = "GMADgui v.1.2.1"
        Me.MetroTabControl1.ResumeLayout(False)
        Me.MetroTabPage1.ResumeLayout(False)
        Me.MetroTabPage1.PerformLayout()
        Me.warningPanel.ResumeLayout(False)
        Me.warningPanel.PerformLayout()
        CType(Me.Warningpic1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroTabPage2.ResumeLayout(False)
        Me.MetroTabPage2.PerformLayout()
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        CType(Me.warningPic2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroTabPage3.ResumeLayout(False)
        Me.MetroTabPage3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage2 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage3 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents ExtractBut As MetroFramework.Controls.MetroButton
    Friend WithEvents extractProg1 As MetroFramework.Controls.MetroProgressBar
    Friend WithEvents extractBut2 As MetroFramework.Controls.MetroButton
    Friend WithEvents extractBut1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents folPath1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents gmaBox1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents compressProg As MetroFramework.Controls.MetroProgressBar
    Friend WithEvents MetroButton4 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton5 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton6 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents folSelcBox1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents folSelcBox As MetroFramework.Controls.MetroTextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents MetroButton8 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents gmadSettingPath As MetroFramework.Controls.MetroTextBox
    Friend WithEvents warningPanel As MetroFramework.Controls.MetroPanel
    Friend WithEvents warningtxt1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Warningpic1 As PictureBox
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents warningtxt2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents warningPic2 As PictureBox
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MetroButton7 As MetroFramework.Controls.MetroButton
    Friend WithEvents latestVer As Label
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents addonjsonMake As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents MetroTabPage4 As MetroFramework.Controls.MetroTabPage
End Class
