Imports System.IO.File

Public Class Form1

    Dim nl = Environment.NewLine

    Dim ad = AppDomain.CurrentDomain.BaseDirectory
    Dim ScDir = ad & "Scripts\"

    Dim ScVPN1 = ScDir & "VPN1.txt"


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SFText.InitialDirectory = ad

    End Sub


    Private Sub MakeVPN1()
        'Dim OutLocal
        'Dim OutMask
        'Dim OutPeer


        'Dim InLocal
        'Dim InMask


        'Dim CryptAlg
        'Dim CryptDH
        'Dim CryptEnc
        'Dim psk

        'Dim NATlow
        'Dim NAThigh

        'Dim Internal
        'Dim Remotet
        TxtOut.Text = ModScriptVPN(ScVPN1, MTxtIPRemote.Text.Replace(" ", ""), MTxtMASKRemote.Text.Replace(" ", ""), MTxtPeer.Text.Replace(" ", ""), MTxtIPLocal.Text.Replace(" ", ""), MTxtMaskLocal.Text.Replace(" ", ""), _
                                   CmbCryptAlg.Text, CmbCryptDH.Text, CmbCryptEnc.Text, TxtPSK.Text)


    End Sub

    Private Function ModScriptVPN(ByVal ScrPath, ByVal OutLocal, ByVal OutMask, ByVal OutPeer, ByVal InLocal _
            , ByVal InMask, ByVal CryptAlg, ByVal CryptDH, ByVal CryptEnc, ByVal psk) As String

        Dim Tmp() As String = ReadAllText(ScrPath).Split("~"c)
        Dim ScrCur = Tmp(1)

        ScrCur = USc(ScrCur, "OutLocal", OutLocal)
        ScrCur = USc(ScrCur, "OutMask", OutMask)
        ScrCur = USc(ScrCur, "OutPeer", OutPeer)
        ScrCur = USc(ScrCur, "InLocal", InLocal)
        ScrCur = USc(ScrCur, "InMask", InMask)
        ScrCur = USc(ScrCur, "CryptAlg", CryptAlg)
        ScrCur = USc(ScrCur, "CryptDH", CryptDH)
        ScrCur = USc(ScrCur, "CryptEnc", CryptEnc)
        ScrCur = USc(ScrCur, "psk", psk)


        Return ScrCur


    End Function

    Private Function USc(ByVal InPut As String, ByVal Exist As String, ByVal Change As String) As String
        InPut = InPut.Replace(Exist, Change)
        Return InPut
    End Function



    Private Sub BtnEureka_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEureka.Click
        MakeVPN1()
    End Sub

    Private Sub ButtonSAve_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSAve.Click
        If SFText.ShowDialog() = Windows.Forms.DialogResult.OK Then
            WriteAllText(SFText.FileName, TxtOut.Text)
        End If


    End Sub
End Class