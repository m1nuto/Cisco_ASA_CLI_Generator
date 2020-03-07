Imports System.IO.File

Public Class FrmMain

    Dim nl = Environment.NewLine

    Dim ad = AppDomain.CurrentDomain.BaseDirectory
    Dim ScDir = ad & "Scripts\"

    Dim ScVPN1 = ScDir & "VPN1.txt"


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.Cisco_Blue_Round_Edge_Orange_WBO_TOOLS

      

        SFText.InitialDirectory = ad
        Generate()


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

    Private Sub ButtonSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSAve.Click
        If SFText.ShowDialog() = Windows.Forms.DialogResult.OK Then
            WriteAllText(SFText.FileName, TxtOut.Text)
        End If


    End Sub

    Public Sub Validation() Handles NumPskLen.ValueChanged, ChkPskSpec.CheckStateChanged, ChkPskLow.CheckStateChanged, ChkPskNum.CheckStateChanged, ChkPskUp.CheckStateChanged

        If ChkPskLow.Checked Or ChkPskNum.Checked Or ChkPskUp.Checked Or ChkPskSpec.Checked Then

            Generate()
        End If
    End Sub

    Public Sub Generate()
        'Generate the Random Text
        '65-90:  A - Z
        '97-122: a - z
        '48-57:  0 - 9
        '123,126: {|}~
        '91,95: [\]^_
        '60,64: <=>?@`
        '33,35-47: !#$%&’()*+,-./

        If NumPskLen.Text > 0 Then
            Randomize(Rnd() * Date.Now.Millisecond)
            Dim R As New System.Random(Rnd() * Date.Now.Millisecond)
            Dim Final$ = ""
            Do Until Final.Length = NumPskLen.Text
                Dim CurrentNumber% = R.Next(33, 126 + 1)
                If (If(ChkPskSpec.Checked, NumberInRange(CurrentNumber, 123, 126), False)) Or _
                (If(ChkPskSpec.Checked, NumberInRange(CurrentNumber, 91, 95), False)) Or _
                (If(ChkPskSpec.Checked, NumberInRange(CurrentNumber, 60, 64), False)) Or _
                (If(ChkPskSpec.Checked, NumberInRange(CurrentNumber, 33, 33), False)) Or _
                (If(ChkPskSpec.Checked, NumberInRange(CurrentNumber, 35, 47), False)) Or _
                (If(ChkPskNum.Checked, NumberInRange(CurrentNumber, 48, 57), False)) Or _
                (If(ChkPskUp.Checked, NumberInRange(CurrentNumber, 65, 90), False)) Or _
                 (If(ChkPskLow.Checked, NumberInRange(CurrentNumber, 97, 122), False)) Then
                    'Chr is in range, post to Final String
                    Final &= Chr(CurrentNumber)
                End If
            Loop
            TxtPSK.Text = Final
        End If

    End Sub

    Public Function NumberInRange(ByVal Number%, ByVal Min%, ByVal Max%) As Boolean
        Return (Number >= Min And Number <= Max)
    End Function



    Public Function IsLoaded(ByVal FormName As String) As Boolean

        Dim Forms As New List(Of Form)()
        Dim formType As Type = Type.GetType("System.Windows.Forms.Form")

        For Each t As Type In Me.GetType().Assembly.GetTypes()
            If t.IsSubclassOf(formType) = True Then
                Forms.Add(CType(Activator.CreateInstance(t), Form))
            End If
        Next

        Dim sFormName As String

        sFormName = UCase$(FormName)

        For Each f As Form In Forms

            If UCase$(f.Name) = sFormName Then
                IsLoaded = True
            Else
                IsLoaded = False
                Exit Function
            End If
        Next


    End Function

    ' ''For use in a class contained in an external .dll
    'Public Function IsLoaded(ByVal FormName As String, ByVal FormCollection _
    'As Object) As Boolean

    '    Dim sFormName As String
    '    Dim f As Form
    '    sFormName = UCase$(FormName)

    '    On Error Resume Next
    '    For Each f In FormCollection
    '        If UCase$(f.Name) = sFormName Then
    '            IsLoaded = True
    '            Exit Function
    '        End If
    '    Next

    'End Function



    Private Sub AdjustText()
        On Error Resume Next

        Dim Fit As Boolean = False
        Dim CurSize As Single
        Dim SizeStep As Single = 1
        Do Until Fit
            CurSize += SizeStep
            Dim Fnt As Font = New Font(TxtPSK.Font.Name, CurSize)
            Dim textSize As Size = TextRenderer.MeasureText(TxtPSK.Text, Fnt)
            If textSize.Height >= TxtPSK.Height Or textSize.Width >= TxtPSK.Width Or TxtPSK.Height = 0 Or TxtPSK.Width = 0 Then
                Fit = True
                If textSize.Width > TxtPSK.Width Then
                    CurSize -= SizeStep
                End If
                If textSize.Height > TxtPSK.Height Then
                    CurSize -= SizeStep
                End If
            End If
        Loop
        Dim x = CurSize
        If x >= 5 And x <= 24 Then
            TxtPSK.Font = New Font(TxtPSK.Font.Name, CurSize)
            Application.DoEvents()
        End If
    End Sub

    Private Sub TxtPSK_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPSK.TextChanged
        If TxtPSK.Text.Length > 10 Then
            AdjustText()
        End If


    End Sub



    Private Sub BtnCopyPSK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCopyPSK.Click
Begin:

        Try
            Do Until Windows.Forms.Clipboard.GetText = TxtPSK.Text
Half:

                Try
                    Windows.Forms.Clipboard.SetText(TxtPSK.Text)
                Catch
                    GoTo Half

                End Try

            Loop
        Catch ex As Exception
            GoTo Begin
        End Try
        
    End Sub
End Class