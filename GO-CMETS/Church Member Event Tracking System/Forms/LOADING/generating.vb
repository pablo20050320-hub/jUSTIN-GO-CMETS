' Itong buong code ay para sa generating.vb

Public Class generating

    ' Ang buong text na gusto nating i-type
    Private fullText As String = "Generating ID... Please wait."

    ' Tagabilang kung anong letra na ang ipapakita
    Private currentCharIndex As Integer = 0

    Private Sub generating_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' Siguraduhing blangko ang label sa simula
        Label1.Text = ""

        ' ===== PAGBABAGO DITO =====
        ' Pinalitan natin ang Interval sa designer, pero siguraduhin mo na
        ' ang Interval ng TypingTimer mo ay naka-set sa mas mabilis na numero.
        ' Halimbawa: 70 (mula sa 100)
        TypingTimer.Interval = 70

        ' Simulan ang timer para mag-umpisa ang pag-type
        TypingTimer.Start()
    End Sub

    Private Sub TypingTimer_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles TypingTimer.Tick
        ' I-check kung may natitira pang letra na ita-type
        If currentCharIndex < fullText.Length Then
            ' Idagdag ang susunod na letra
            Label1.Text &= fullText(currentCharIndex)
            ' Itaas ang bilang para sa susunod na letra
            currentCharIndex += 1
        Else
            ' Kung tapos na ang lahat ng letra...
            TypingTimer.Stop()

            ' ===== PAGBABAGO DITO =====
            ' Maghintay ng mas maikling oras bago isara.
            ' 300ms (0.3 segundo) ay sapat na para mabasa.
            Dim closeTimer As New Timer()
            closeTimer.Interval = 300 ' Dati ay 500
            AddHandler closeTimer.Tick, AddressOf CloseForm
            closeTimer.Start()
        End If
    End Sub

    Private Sub CloseForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Itong function ang magsasara ng form
        Dim timer As Timer = CType(sender, Timer)
        timer.Stop()
        Me.Close()
    End Sub

End Class
