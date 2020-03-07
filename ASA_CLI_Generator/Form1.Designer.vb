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
        Me.Label6 = New System.Windows.Forms.Label
        Me.TxtOut = New System.Windows.Forms.TextBox
        Me.BtnEureka = New System.Windows.Forms.Button
        Me.ButtonSAve = New System.Windows.Forms.Button
        Me.SFText = New System.Windows.Forms.SaveFileDialog
        Me.MTxtIPRemote = New IPAddressControlLib.IPAddressControl
        Me.MTxtMASKRemote = New IPAddressControlLib.IPAddressControl
        Me.MTxtPeer = New IPAddressControlLib.IPAddressControl
        Me.MTxtIPLocal = New IPAddressControlLib.IPAddressControl
        Me.MTxtMaskLocal = New IPAddressControlLib.IPAddressControl
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "OutLocal"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"Dim OutLocal", "Dim OutMask", "Dim OutPeer", "", "Dim InLocal", "Dim InMask", "", "Dim CryptAlg", "Dim CryptDH", "Dim CryptEnc", "Dim psk", "", "Dim NATlow", "Dim NAThigh"})
        Me.ListBox1.Location = New System.Drawing.Point(454, 216)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(138, 238)
        Me.ListBox1.TabIndex = 3
        Me.ListBox1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "OutMask"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "OutPeer"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "InLocal"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "InMask"
        '
        'CmbCryptAlg
        '
        Me.CmbCryptAlg.FormattingEnabled = True
        Me.CmbCryptAlg.Items.AddRange(New Object() {"aes256", "ase128", "3des"})
        Me.CmbCryptAlg.Location = New System.Drawing.Point(517, 53)
        Me.CmbCryptAlg.Name = "CmbCryptAlg"
        Me.CmbCryptAlg.Size = New System.Drawing.Size(121, 21)
        Me.CmbCryptAlg.TabIndex = 6
        Me.CmbCryptAlg.Text = "aes256"
        '
        'CmbCryptEnc
        '
        Me.CmbCryptEnc.FormattingEnabled = True
        Me.CmbCryptEnc.Items.AddRange(New Object() {"sha1", "sha256", "sha512"})
        Me.CmbCryptEnc.Location = New System.Drawing.Point(517, 83)
        Me.CmbCryptEnc.Name = "CmbCryptEnc"
        Me.CmbCryptEnc.Size = New System.Drawing.Size(121, 21)
        Me.CmbCryptEnc.TabIndex = 7
        Me.CmbCryptEnc.Text = "sha512"
        '
        'CmbCryptDH
        '
        Me.CmbCryptDH.FormattingEnabled = True
        Me.CmbCryptDH.Items.AddRange(New Object() {"DH2", "DH5", "DH14", "DH21", "DH24"})
        Me.CmbCryptDH.Location = New System.Drawing.Point(517, 112)
        Me.CmbCryptDH.Name = "CmbCryptDH"
        Me.CmbCryptDH.Size = New System.Drawing.Size(121, 21)
        Me.CmbCryptDH.TabIndex = 8
        Me.CmbCryptDH.Text = "DH21"
        '
        'TxtPSK
        '
        Me.TxtPSK.Location = New System.Drawing.Point(310, 83)
        Me.TxtPSK.Name = "TxtPSK"
        Me.TxtPSK.Size = New System.Drawing.Size(163, 20)
        Me.TxtPSK.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(276, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "PSK"
        '
        'TxtOut
        '
        Me.TxtOut.Location = New System.Drawing.Point(2, 143)
        Me.TxtOut.Multiline = True
        Me.TxtOut.Name = "TxtOut"
        Me.TxtOut.Size = New System.Drawing.Size(649, 348)
        Me.TxtOut.TabIndex = 20
        '
        'BtnEureka
        '
        Me.BtnEureka.Location = New System.Drawing.Point(517, 24)
        Me.BtnEureka.Name = "BtnEureka"
        Me.BtnEureka.Size = New System.Drawing.Size(121, 23)
        Me.BtnEureka.TabIndex = 10
        Me.BtnEureka.Text = "Go"
        Me.BtnEureka.UseVisualStyleBackColor = True
        '
        'ButtonSAve
        '
        Me.ButtonSAve.Location = New System.Drawing.Point(310, 46)
        Me.ButtonSAve.Name = "ButtonSAve"
        Me.ButtonSAve.Size = New System.Drawing.Size(163, 31)
        Me.ButtonSAve.TabIndex = 11
        Me.ButtonSAve.Text = "Save"
        Me.ButtonSAve.UseVisualStyleBackColor = True
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
        Me.MTxtIPRemote.BackColor = System.Drawing.SystemColors.Window
        Me.MTxtIPRemote.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MTxtIPRemote.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.MTxtIPRemote.Location = New System.Drawing.Point(69, 9)
        Me.MTxtIPRemote.MinimumSize = New System.Drawing.Size(87, 20)
        Me.MTxtIPRemote.Name = "MTxtIPRemote"
        Me.MTxtIPRemote.ReadOnly = False
        Me.MTxtIPRemote.Size = New System.Drawing.Size(87, 20)
        Me.MTxtIPRemote.TabIndex = 1
        Me.MTxtIPRemote.Text = "..."
        '
        'MTxtMASKRemote
        '
        Me.MTxtMASKRemote.AllowInternalTab = False
        Me.MTxtMASKRemote.AutoHeight = True
        Me.MTxtMASKRemote.BackColor = System.Drawing.SystemColors.Window
        Me.MTxtMASKRemote.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MTxtMASKRemote.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.MTxtMASKRemote.Location = New System.Drawing.Point(69, 37)
        Me.MTxtMASKRemote.MinimumSize = New System.Drawing.Size(87, 20)
        Me.MTxtMASKRemote.Name = "MTxtMASKRemote"
        Me.MTxtMASKRemote.ReadOnly = False
        Me.MTxtMASKRemote.Size = New System.Drawing.Size(87, 20)
        Me.MTxtMASKRemote.TabIndex = 2
        Me.MTxtMASKRemote.Text = "..."
        '
        'MTxtPeer
        '
        Me.MTxtPeer.AllowInternalTab = False
        Me.MTxtPeer.AutoHeight = True
        Me.MTxtPeer.BackColor = System.Drawing.SystemColors.Window
        Me.MTxtPeer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MTxtPeer.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.MTxtPeer.Location = New System.Drawing.Point(69, 65)
        Me.MTxtPeer.MinimumSize = New System.Drawing.Size(87, 20)
        Me.MTxtPeer.Name = "MTxtPeer"
        Me.MTxtPeer.ReadOnly = False
        Me.MTxtPeer.Size = New System.Drawing.Size(87, 20)
        Me.MTxtPeer.TabIndex = 3
        Me.MTxtPeer.Text = "..."
        '
        'MTxtIPLocal
        '
        Me.MTxtIPLocal.AllowInternalTab = False
        Me.MTxtIPLocal.AutoHeight = True
        Me.MTxtIPLocal.BackColor = System.Drawing.SystemColors.Window
        Me.MTxtIPLocal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MTxtIPLocal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.MTxtIPLocal.Location = New System.Drawing.Point(69, 93)
        Me.MTxtIPLocal.MinimumSize = New System.Drawing.Size(87, 20)
        Me.MTxtIPLocal.Name = "MTxtIPLocal"
        Me.MTxtIPLocal.ReadOnly = False
        Me.MTxtIPLocal.Size = New System.Drawing.Size(87, 20)
        Me.MTxtIPLocal.TabIndex = 4
        Me.MTxtIPLocal.Text = "..."
        '
        'MTxtMaskLocal
        '
        Me.MTxtMaskLocal.AllowInternalTab = False
        Me.MTxtMaskLocal.AutoHeight = True
        Me.MTxtMaskLocal.BackColor = System.Drawing.SystemColors.Window
        Me.MTxtMaskLocal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MTxtMaskLocal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.MTxtMaskLocal.Location = New System.Drawing.Point(69, 121)
        Me.MTxtMaskLocal.MinimumSize = New System.Drawing.Size(87, 20)
        Me.MTxtMaskLocal.Name = "MTxtMaskLocal"
        Me.MTxtMaskLocal.ReadOnly = False
        Me.MTxtMaskLocal.Size = New System.Drawing.Size(87, 20)
        Me.MTxtMaskLocal.TabIndex = 5
        Me.MTxtMaskLocal.Text = "..."
        '
        'Form1
        '
        Me.AcceptButton = Me.BtnEureka
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 492)
        Me.Controls.Add(Me.MTxtMaskLocal)
        Me.Controls.Add(Me.MTxtIPLocal)
        Me.Controls.Add(Me.MTxtPeer)
        Me.Controls.Add(Me.MTxtMASKRemote)
        Me.Controls.Add(Me.MTxtIPRemote)
        Me.Controls.Add(Me.ButtonSAve)
        Me.Controls.Add(Me.BtnEureka)
        Me.Controls.Add(Me.TxtOut)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtPSK)
        Me.Controls.Add(Me.CmbCryptDH)
        Me.Controls.Add(Me.CmbCryptEnc)
        Me.Controls.Add(Me.CmbCryptAlg)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Abhi's Cure for World Hunger"
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
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtOut As System.Windows.Forms.TextBox
    Friend WithEvents BtnEureka As System.Windows.Forms.Button
    Friend WithEvents ButtonSAve As System.Windows.Forms.Button
    Friend WithEvents SFText As System.Windows.Forms.SaveFileDialog
    Friend WithEvents MTxtIPRemote As IPAddressControlLib.IPAddressControl
    Friend WithEvents MTxtMASKRemote As IPAddressControlLib.IPAddressControl
    Friend WithEvents MTxtPeer As IPAddressControlLib.IPAddressControl
    Friend WithEvents MTxtIPLocal As IPAddressControlLib.IPAddressControl
    Friend WithEvents MTxtMaskLocal As IPAddressControlLib.IPAddressControl

End Class
