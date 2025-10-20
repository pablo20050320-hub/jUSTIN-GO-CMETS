Imports System.Data.SqlClient
Imports System.IO

Public Class MemberHistoryForm
    Private connString As String = "Server=DESKTOP-GO\SQLEXPRESS; Database=MemberInfo; Trusted_Connection=True;"
    Private memberIdToShow As Integer

    ' Constructor: Ito pa rin ang tatanggap ng ID mula sa Form2
    Public Sub New(ByVal memberId As Integer)
        InitializeComponent()
        Me.memberIdToShow = memberId
    End Sub

    Private Sub MemberHistoryForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Me.Text = "Attendance History"
        LoadHistory()
    End Sub

    Private Sub LoadHistory()
        Try
            Using conn As New SqlConnection(connString)
                conn.Open()

                ' --- BINAGO PARA KUNIN ANG LAHAT NG INFO (PANGALAN, MINISTRY, PICTURE) SA ISANG BIYAHE LANG ---
                Dim memberQuery As String = "SELECT first_name, last_name, Ministry, profile_pic FROM dbo.memberinfo WHERE id = @id"
                Using memberCmd As New SqlCommand(memberQuery, conn)
                    memberCmd.Parameters.AddWithValue("@id", memberIdToShow)

                    Using reader As SqlDataReader = memberCmd.ExecuteReader()
                        If reader.Read() Then
                            ' I-populate ang mga bagong controls
                            Dim memberName As String = reader("first_name").ToString() & " " & reader("last_name").ToString()
                            lblNameHeader.Text = "Attendance History for: " & memberName
                            lblMinistry.Text = "Ministry: " & reader("Ministry").ToString()

                            ' I-handle ang Profile Picture
                            If Not IsDBNull(reader("profile_pic")) Then
                                Dim imageData As Byte() = CType(reader("profile_pic"), Byte())
                                Using ms As New MemoryStream(imageData)
                                    pbStudentPic.Image = Image.FromStream(ms)
                                End Using
                            Else
                                pbStudentPic.Image = Nothing ' O isang default image
                            End If
                        End If
                    End Using ' Isasara ang reader dito
                End Using

                ' --- Ang pagkuha ng history ay hiwalay at walang pagbabago ---
                Dim historyQuery As String = "SELECT event_name, event_date, status, time_in FROM dbo.MemberAttendance WHERE member_id = @id AND is_deleted = 0 ORDER BY event_date DESC"
                Using adapter As New SqlDataAdapter(historyQuery, conn)
                    adapter.SelectCommand.Parameters.AddWithValue("@id", memberIdToShow)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)

                    ' I-format ang Time In
                    dt.Columns.Add("TimeInFormatted", GetType(String))
                    For Each row As DataRow In dt.Rows
                        If Not IsDBNull(row("time_in")) Then
                            Dim timeValue As TimeSpan = CType(row("time_in"), TimeSpan)
                            row("TimeInFormatted") = DateTime.Today.Add(timeValue).ToString("hh:mm tt")
                        Else
                            row("TimeInFormatted") = ""
                        End If
                    Next

                    dgvHistory.DataSource = dt

                    ' Itago at ayusin ang columns
                    If dgvHistory.Columns.Contains("time_in") Then
                        dgvHistory.Columns("time_in").Visible = False
                    End If
                    If dgvHistory.Columns.Contains("TimeInFormatted") Then
                        dgvHistory.Columns("TimeInFormatted").HeaderText = "Time In"
                    End If

                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading attendance history: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class