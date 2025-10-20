Imports System.Drawing
Imports MessagingToolkit.QRCode.Codec
Imports System.IO
Imports System.Drawing.Imaging

Public Class FormIDCard

    Public Sub New(ByVal id As String, ByVal studentName As String, ByVal Course As String, ByVal city As String, ByVal studentPic As Byte())
        InitializeComponent()
        Me.studentIDLabel3.Text = id
        Me.studentNameLabel1.Text = studentName
        Me.MemberLabel4.Text = Course
        Me.cityLabel2.Text = city
        If Not studentPic Is Nothing Then
            Dim tempImage As Image
            Using ms As New MemoryStream(studentPic)
                tempImage = Image.FromStream(ms)
            End Using
            Me.studentPic.Image = New Bitmap(tempImage)
            tempImage.Dispose()
        End If

        ' === TANDAAN: Inalis na natin ang pag-generate ng QR code dito para sa PictureBox.
        ' Ang pag-generate ay mangyayari na lang kapag pinindot ang Export.
        ' Kung gusto mo pa ring makita ang QR sa ID, ibalik mo lang ang linyang ito:
        ' GenerateAndDisplayQRCode(id)
    End Sub

    ' (Opsyonal: Pwede mong i-delete itong buong function kung hindi mo na ipapakita ang QR sa ID card mismo)
    Private Sub GenerateAndDisplayQRCode(ByVal id As String)
        Try
            Dim qrCodeDataString As String = id
            Dim qrCodeEncoder As New QRCodeEncoder()
            qrCodeEncoder.QRCodeScale = 8
            qrCodeEncoder.QRCodeVersion = 0
            Dim qrCodeImage As Bitmap = qrCodeEncoder.Encode(qrCodeDataString)
            Me.qrCodepic.Image = qrCodeImage
        Catch ex As Exception
            MessageBox.Show("Error generating QR Code: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MakePictureBoxRound()
        Try
            Dim graphicsPath As New System.Drawing.Drawing2D.GraphicsPath()
            graphicsPath.AddEllipse(0, 0, studentPic.Width, studentPic.Height)
            studentPic.Region = New Region(graphicsPath)
        Catch ex As Exception
            ' Huwag mag-error
        End Try
    End Sub

    Private Sub FormIDCard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MakePictureBoxRound()
        ' Kung gusto mong makita agad ang QR sa ID, tawagin mo ito dito:
        GenerateAndDisplayQRCode(studentIDLabel3.Text)
    End Sub

    ' === ITO ANG INAYOS NA EXPORT BUTTON (All-in-One) ===
    Private Sub btnExport_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExport.Click
        Try
            ' --- Step 1: Kunin ang data na kailangan ---
            Dim memberID As String = studentIDLabel3.Text
            If String.IsNullOrWhiteSpace(memberID) Then
                MessageBox.Show("Member ID is missing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' --- Step 2: Gumawa ng QR code na may magandang scale ---
            Dim qrCodeEncoder As New QRCodeEncoder()
            qrCodeEncoder.QRCodeScale = 8 ' Mas malaki at mas malinaw
            qrCodeEncoder.QRCodeVersion = 0
            Dim qrCodeImage As Bitmap = qrCodeEncoder.Encode(memberID)

            ' --- Step 3: Idagdag ang "Quiet Zone" (White Border) ---
            Dim quietZoneSize As Integer = 20 ' 20 pixels na border
            Dim finalImage As New Bitmap(qrCodeImage.Width + (quietZoneSize * 2), qrCodeImage.Height + (quietZoneSize * 2))
            Using g As Graphics = Graphics.FromImage(finalImage)
                g.Clear(Color.White)
                g.DrawImage(qrCodeImage, New Point(quietZoneSize, quietZoneSize))
            End Using

            ' --- Step 4: I-setup ang SaveFileDialog ---
            SaveFileDialog1.FileName = "QR_" & studentNameLabel1.Text.Replace(" ", "_") & ".png"
            SaveFileDialog1.Filter = "PNG Image|*.png"

            ' --- Step 5: Ipakita ang dialog at i-save ang final image ---
            If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
                finalImage.Save(SaveFileDialog1.FileName, ImageFormat.Png)
                MessageBox.Show("QR Code exported successfully!", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            ' --- Step 6: I-dispose ang mga ginamit na imahe ---
            qrCodeImage.Dispose()
            finalImage.Dispose()

        Catch ex As Exception
            MessageBox.Show("An error occurred while exporting the QR Code: " & ex.Message, "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class