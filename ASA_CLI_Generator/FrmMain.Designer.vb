<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.Label1 = New System.Windows.Forms.Label
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.CmbCryptAlg = New System.Windows.Forms.ComboBox
        Me.CmbCryptEnc = New System.Windows.Forms.ComboBox
        Me.CmbCryptDH = New System.Windows.Forms.ComboBox
        Me.TxtPSK = New System.Windows.Forms.TextBox
        Me.TxtOut = New System.Windows.Forms.TextBox
        Me.SFText = New System.Windows.Forms.SaveFileDialog
        Me.MTxtIPRemote = New IPAddressControlLib.IPAddressControl
        Me.MTxtMASKRemote = New IPAddressControlLib.IPAddressControl
        Me.MTxtPeer = New IPAddressControlLib.IPAddressControl
        Me.MTxtIPLocal = New IPAddressControlLib.IPAddressControl
        Me.MTxtMaskLocal = New IPAddressControlLib.IPAddressControl
        Me.GrpPsk = New System.Windows.Forms.GroupBox
        Me.PanPSKChk = New System.Windows.Forms.Panel
        Me.BtnCopyPSK = New System.Windows.Forms.Button
        Me.ChkPskLow = New System.Windows.Forms.CheckBox
        Me.NumPskLen = New System.Windows.Forms.NumericUpDown
        Me.ChkPskNum = New System.Windows.Forms.CheckBox
        Me.ChkPskSpec = New System.Windows.Forms.CheckBox
        Me.ChkPskUp = New System.Windows.Forms.CheckBox
        Me.BtnEureka = New System.Windows.Forms.Button
        Me.ButtonSAve = New System.Windows.Forms.Button
        Me.GrpPsk.SuspendLayout()
        Me.PanPSKChk.SuspendLayout()
        CType(Me.NumPskLen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 14)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "OutLocal"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 14
        Me.ListBox1.Items.AddRange(New Object() {"Dim OutLocal", "Dim OutMask", "Dim OutPeer", "", "Dim InLocal", "Dim InMask", "", "Dim CryptAlg", "Dim CryptDH", "Dim CryptEnc", "Dim psk", "", "Dim NATlow", "Dim NAThigh"})
        Me.ListBox1.Location = New System.Drawing.Point(530, 233)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(160, 256)
        Me.ListBox1.TabIndex = 3
        Me.ListBox1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 14)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "OutMask"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 14)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "OutPeer"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 14)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "InLocal"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(241, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 14)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "InMask"
        '
        'CmbCryptAlg
        '
        Me.CmbCryptAlg.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CmbCryptAlg.BackColor = System.Drawing.Color.Silver
        Me.CmbCryptAlg.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbCryptAlg.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.CmbCryptAlg.FormattingEnabled = True
        Me.CmbCryptAlg.Items.AddRange(New Object() {"AES256", "AES128", "3DES"})
        Me.CmbCryptAlg.Location = New System.Drawing.Point(293, 47)
        Me.CmbCryptAlg.Name = "CmbCryptAlg"
        Me.CmbCryptAlg.Size = New System.Drawing.Size(140, 24)
        Me.CmbCryptAlg.TabIndex = 6
        Me.CmbCryptAlg.Text = "AES256"
        '
        'CmbCryptEnc
        '
        Me.CmbCryptEnc.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CmbCryptEnc.BackColor = System.Drawing.Color.Silver
        Me.CmbCryptEnc.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbCryptEnc.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.CmbCryptEnc.FormattingEnabled = True
        Me.CmbCryptEnc.Items.AddRange(New Object() {"SHA1", "SHA256", "SHA512"})
        Me.CmbCryptEnc.Location = New System.Drawing.Point(293, 76)
        Me.CmbCryptEnc.Name = "CmbCryptEnc"
        Me.CmbCryptEnc.Size = New System.Drawing.Size(140, 24)
        Me.CmbCryptEnc.TabIndex = 7
        Me.CmbCryptEnc.Text = "SHA512"
        '
        'CmbCryptDH
        '
        Me.CmbCryptDH.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CmbCryptDH.BackColor = System.Drawing.Color.Silver
        Me.CmbCryptDH.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbCryptDH.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.CmbCryptDH.FormattingEnabled = True
        Me.CmbCryptDH.Items.AddRange(New Object() {"DH2", "DH5", "DH14", "DH19", "DH21", "DH24"})
        Me.CmbCryptDH.Location = New System.Drawing.Point(293, 107)
        Me.CmbCryptDH.Name = "CmbCryptDH"
        Me.CmbCryptDH.Size = New System.Drawing.Size(140, 24)
        Me.CmbCryptDH.TabIndex = 8
        Me.CmbCryptDH.Text = "DH19"
        '
        'TxtPSK
        '
        Me.TxtPSK.BackColor = System.Drawing.Color.Silver
        Me.TxtPSK.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TxtPSK.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPSK.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.TxtPSK.Location = New System.Drawing.Point(3, 64)
        Me.TxtPSK.Name = "TxtPSK"
        Me.TxtPSK.Size = New System.Drawing.Size(412, 23)
        Me.TxtPSK.TabIndex = 8
        '
        'TxtOut
        '
        Me.TxtOut.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtOut.BackColor = System.Drawing.Color.Silver
        Me.TxtOut.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TxtOut.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.TxtOut.Location = New System.Drawing.Point(2, 150)
        Me.TxtOut.Multiline = True
        Me.TxtOut.Name = "TxtOut"
        Me.TxtOut.Size = New System.Drawing.Size(928, 501)
        Me.TxtOut.TabIndex = 12
        '
        'SFText
        '
        Me.SFText.DefaultExt = "TXT"
        Me.SFText.FileName = "VpnScript"
        Me.SFText.Filter = "*.TXT|TextFiles"
        Me.SFText.Title = "Save Script to File:"
        '
        'MTxtIPRemote
        '
        Me.MTxtIPRemote.AllowInternalTab = False
        Me.MTxtIPRemote.AutoHeight = True
        Me.MTxtIPRemote.BackColor = System.Drawing.Color.Silver
        Me.MTxtIPRemote.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MTxtIPRemote.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.MTxtIPRemote.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MTxtIPRemote.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.MTxtIPRemote.Location = New System.Drawing.Point(80, 19)
        Me.MTxtIPRemote.MinimumSize = New System.Drawing.Size(114, 23)
        Me.MTxtIPRemote.Name = "MTxtIPRemote"
        Me.MTxtIPRemote.ReadOnly = False
        Me.MTxtIPRemote.Size = New System.Drawing.Size(133, 23)
        Me.MTxtIPRemote.TabIndex = 1
        Me.MTxtIPRemote.Text = "..."
        '
        'MTxtMASKRemote
        '
        Me.MTxtMASKRemote.AllowInternalTab = False
        Me.MTxtMASKRemote.AutoHeight = True
        Me.MTxtMASKRemote.BackColor = System.Drawing.Color.Silver
        Me.MTxtMASKRemote.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MTxtMASKRemote.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.MTxtMASKRemote.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MTxtMASKRemote.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.MTxtMASKRemote.Location = New System.Drawing.Point(80, 48)
        Me.MTxtMASKRemote.MinimumSize = New System.Drawing.Size(114, 23)
        Me.MTxtMASKRemote.Name = "MTxtMASKRemote"
        Me.MTxtMASKRemote.ReadOnly = False
        Me.MTxtMASKRemote.Size = New System.Drawing.Size(133, 23)
        Me.MTxtMASKRemote.TabIndex = 2
        Me.MTxtMASKRemote.Text = "..."
        '
        'MTxtPeer
        '
        Me.MTxtPeer.AllowInternalTab = False
        Me.MTxtPeer.AutoHeight = True
        Me.MTxtPeer.BackColor = System.Drawing.Color.Silver
        Me.MTxtPeer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MTxtPeer.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.MTxtPeer.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MTxtPeer.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.MTxtPeer.Location = New System.Drawing.Point(80, 78)
        Me.MTxtPeer.MinimumSize = New System.Drawing.Size(114, 23)
        Me.MTxtPeer.Name = "MTxtPeer"
        Me.MTxtPeer.ReadOnly = False
        Me.MTxtPeer.Size = New System.Drawing.Size(133, 23)
        Me.MTxtPeer.TabIndex = 3
        Me.MTxtPeer.Text = "..."
        '
        'MTxtIPLocal
        '
        Me.MTxtIPLocal.AllowInternalTab = False
        Me.MTxtIPLocal.AutoHeight = True
        Me.MTxtIPLocal.BackColor = System.Drawing.Color.Silver
        Me.MTxtIPLocal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MTxtIPLocal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.MTxtIPLocal.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MTxtIPLocal.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.MTxtIPLocal.Location = New System.Drawing.Point(80, 108)
        Me.MTxtIPLocal.MinimumSize = New System.Drawing.Size(114, 23)
        Me.MTxtIPLocal.Name = "MTxtIPLocal"
        Me.MTxtIPLocal.ReadOnly = False
        Me.MTxtIPLocal.Size = New System.Drawing.Size(133, 23)
        Me.MTxtIPLocal.TabIndex = 4
        Me.MTxtIPLocal.Text = "..."
        '
        'MTxtMaskLocal
        '
        Me.MTxtMaskLocal.AllowInternalTab = False
        Me.MTxtMaskLocal.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MTxtMaskLocal.AutoHeight = True
        Me.MTxtMaskLocal.BackColor = System.Drawing.Color.Silver
        Me.MTxtMaskLocal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MTxtMaskLocal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.MTxtMaskLocal.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MTxtMaskLocal.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.MTxtMaskLocal.Location = New System.Drawing.Point(294, 19)
        Me.MTxtMaskLocal.MinimumSize = New System.Drawing.Size(114, 23)
        Me.MTxtMaskLocal.Name = "MTxtMaskLocal"
        Me.MTxtMaskLocal.ReadOnly = False
        Me.MTxtMaskLocal.Size = New System.Drawing.Size(139, 23)
        Me.MTxtMaskLocal.TabIndex = 5
        Me.MTxtMaskLocal.Text = "..."
        '
        'GrpPsk
        '
        Me.GrpPsk.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpPsk.AutoSize = True
        Me.GrpPsk.Controls.Add(Me.TxtPSK)
        Me.GrpPsk.Controls.Add(Me.PanPSKChk)
        Me.GrpPsk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GrpPsk.Location = New System.Drawing.Point(501, 42)
        Me.GrpPsk.Margin = New System.Windows.Forms.Padding(1)
        Me.GrpPsk.Name = "GrpPsk"
        Me.GrpPsk.Size = New System.Drawing.Size(418, 90)
        Me.GrpPsk.TabIndex = 20
        Me.GrpPsk.TabStop = False
        Me.GrpPsk.Text = "Generate PSK"
        '
        'PanPSKChk
        '
        Me.PanPSKChk.Controls.Add(Me.BtnCopyPSK)
        Me.PanPSKChk.Controls.Add(Me.ChkPskLow)
        Me.PanPSKChk.Controls.Add(Me.NumPskLen)
        Me.PanPSKChk.Controls.Add(Me.ChkPskNum)
        Me.PanPSKChk.Controls.Add(Me.ChkPskSpec)
        Me.PanPSKChk.Controls.Add(Me.ChkPskUp)
        Me.PanPSKChk.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanPSKChk.Location = New System.Drawing.Point(3, 16)
        Me.PanPSKChk.Name = "PanPSKChk"
        Me.PanPSKChk.Size = New System.Drawing.Size(412, 32)
        Me.PanPSKChk.TabIndex = 13
        '
        'BtnCopyPSK
        '
        Me.BtnCopyPSK.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCopyPSK.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BtnCopyPSK.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCopyPSK.Location = New System.Drawing.Point(319, 0)
        Me.BtnCopyPSK.Name = "BtnCopyPSK"
        Me.BtnCopyPSK.Size = New System.Drawing.Size(90, 27)
        Me.BtnCopyPSK.TabIndex = 11
        Me.BtnCopyPSK.Text = "Copy PSK"
        Me.BtnCopyPSK.UseVisualStyleBackColor = True
        '
        'ChkPskLow
        '
        Me.ChkPskLow.AutoSize = True
        Me.ChkPskLow.Checked = True
        Me.ChkPskLow.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkPskLow.Location = New System.Drawing.Point(3, 6)
        Me.ChkPskLow.Name = "ChkPskLow"
        Me.ChkPskLow.Size = New System.Drawing.Size(45, 18)
        Me.ChkPskLow.TabIndex = 13
        Me.ChkPskLow.Text = "abc"
        Me.ChkPskLow.UseVisualStyleBackColor = True
        '
        'NumPskLen
        '
        Me.NumPskLen.Location = New System.Drawing.Point(204, 4)
        Me.NumPskLen.Maximum = New Decimal(New Integer() {128, 0, 0, 0})
        Me.NumPskLen.Minimum = New Decimal(New Integer() {8, 0, 0, 0})
        Me.NumPskLen.Name = "NumPskLen"
        Me.NumPskLen.Size = New System.Drawing.Size(51, 20)
        Me.NumPskLen.TabIndex = 17
        Me.NumPskLen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumPskLen.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'ChkPskNum
        '
        Me.ChkPskNum.AutoSize = True
        Me.ChkPskNum.Checked = True
        Me.ChkPskNum.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkPskNum.Location = New System.Drawing.Point(102, 6)
        Me.ChkPskNum.Name = "ChkPskNum"
        Me.ChkPskNum.Size = New System.Drawing.Size(44, 18)
        Me.ChkPskNum.TabIndex = 15
        Me.ChkPskNum.Text = "123"
        Me.ChkPskNum.UseVisualStyleBackColor = True
        '
        'ChkPskSpec
        '
        Me.ChkPskSpec.AutoSize = True
        Me.ChkPskSpec.Checked = True
        Me.ChkPskSpec.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkPskSpec.Location = New System.Drawing.Point(152, 6)
        Me.ChkPskSpec.Name = "ChkPskSpec"
        Me.ChkPskSpec.Size = New System.Drawing.Size(46, 18)
        Me.ChkPskSpec.TabIndex = 16
        Me.ChkPskSpec.Text = "!@#"
        Me.ChkPskSpec.UseVisualStyleBackColor = True
        '
        'ChkPskUp
        '
        Me.ChkPskUp.AutoSize = True
        Me.ChkPskUp.Checked = True
        Me.ChkPskUp.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkPskUp.Location = New System.Drawing.Point(47, 6)
        Me.ChkPskUp.Name = "ChkPskUp"
        Me.ChkPskUp.Size = New System.Drawing.Size(49, 18)
        Me.ChkPskUp.TabIndex = 14
        Me.ChkPskUp.Text = "ABC"
        Me.ChkPskUp.UseVisualStyleBackColor = True
        '
        'BtnEureka
        '
        Me.BtnEureka.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnEureka.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold)
        Me.BtnEureka.Location = New System.Drawing.Point(811, 7)
        Me.BtnEureka.Name = "BtnEureka"
        Me.BtnEureka.Size = New System.Drawing.Size(108, 33)
        Me.BtnEureka.TabIndex = 10
        Me.BtnEureka.Text = "Go"
        Me.BtnEureka.UseVisualStyleBackColor = True
        '
        'ButtonSAve
        '
        Me.ButtonSAve.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonSAve.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold)
        Me.ButtonSAve.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonSAve.Location = New System.Drawing.Point(706, 7)
        Me.ButtonSAve.Name = "ButtonSAve"
        Me.ButtonSAve.Size = New System.Drawing.Size(99, 33)
        Me.ButtonSAve.TabIndex = 12
        Me.ButtonSAve.Text = "Save"
        Me.ButtonSAve.UseVisualStyleBackColor = True
        '
        'FrmMain
        '
        Me.AcceptButton = Me.BtnEureka
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(931, 653)
        Me.Controls.Add(Me.GrpPsk)
        Me.Controls.Add(Me.MTxtMaskLocal)
        Me.Controls.Add(Me.MTxtIPLocal)
        Me.Controls.Add(Me.MTxtPeer)
        Me.Controls.Add(Me.MTxtMASKRemote)
        Me.Controls.Add(Me.MTxtIPRemote)
        Me.Controls.Add(Me.ButtonSAve)
        Me.Controls.Add(Me.BtnEureka)
        Me.Controls.Add(Me.TxtOut)
        Me.Controls.Add(Me.CmbCryptDH)
        Me.Controls.Add(Me.CmbCryptEnc)
        Me.Controls.Add(Me.CmbCryptAlg)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Abhi's Cure for World Hunger"
        Me.GrpPsk.ResumeLayout(False)
        Me.GrpPsk.PerformLayout()
        Me.PanPSKChk.ResumeLayout(False)
        Me.PanPSKChk.PerformLayout()
        CType(Me.NumPskLen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CmbCryptAlg As System.Windows.Forms.ComboBox
    Friend WithEvents CmbCryptEnc As System.Windows.Forms.ComboBox
    Friend WithEvents CmbCryptDH As System.Windows.Forms.ComboBox
    Friend WithEvents TxtPSK As System.Windows.Forms.TextBox
    Friend WithEvents TxtOut As System.Windows.Forms.TextBox
    Friend WithEvents SFText As System.Windows.Forms.SaveFileDialog
    Friend WithEvents MTxtIPRemote As IPAddressControlLib.IPAddressControl
    Friend WithEvents MTxtMASKRemote As IPAddressControlLib.IPAddressControl
    Friend WithEvents MTxtPeer As IPAddressControlLib.IPAddressControl
    Friend WithEvents MTxtIPLocal As IPAddressControlLib.IPAddressControl
    Friend WithEvents MTxtMaskLocal As IPAddressControlLib.IPAddressControl
    Friend WithEvents GrpPsk As System.Windows.Forms.GroupBox
    Friend WithEvents PanPSKChk As System.Windows.Forms.Panel
    Friend WithEvents ChkPskLow As System.Windows.Forms.CheckBox
    Friend WithEvents NumPskLen As System.Windows.Forms.NumericUpDown
    Friend WithEvents ChkPskNum As System.Windows.Forms.CheckBox
    Friend WithEvents ChkPskSpec As System.Windows.Forms.CheckBox
    Friend WithEvents ChkPskUp As System.Windows.Forms.CheckBox
    Friend WithEvents BtnEureka As System.Windows.Forms.Button
    Friend WithEvents ButtonSAve As System.Windows.Forms.Button
    Friend WithEvents BtnCopyPSK As System.Windows.Forms.Button

End Class
