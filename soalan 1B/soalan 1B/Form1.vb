Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Const CAJ_MINIMUM As Double = 10.0
        Dim berat, upahKira, upahAkhir As Double
        Dim inputBerat As String

        inputBerat = InputBox("Masukkan berat Pelam (kg):", "Kira Upah Pos", "0")

        If Double.TryParse(inputBerat, berat) AndAlso berat > 0 Then

            upahKira = (Math.Min(berat, 20.0) * 2.0) + (Math.Max(0, berat - 20.0) * 1.5)

            upahAkhir = Math.Max(upahKira, CAJ_MINIMUM)

            MsgBox("Berat: " & berat.ToString("N2") & " kg" & vbCrLf &
                   "Upah Dikira: RM " & upahKira.ToString("N2") & vbCrLf &
                   "--------------------------------" & vbCrLf &
                   "**Jumlah Upah Pos:** **RM " & upahAkhir.ToString("N2") & "**",
                   MsgBoxStyle.Information, "Keputusan Upah Pos")
        End If
        Me.Close()
    End Sub
End Class