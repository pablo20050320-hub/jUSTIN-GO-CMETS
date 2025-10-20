Imports System.Data.SqlClient

Public Class Form2
    Private connString As String = "Server=DESKTOP-GO\SQLEXPRESS; Database=MemberInfo; Trusted_Connection=True;"

    Private Function GetConnection() As SqlConnection
        Return New SqlConnection(connString)
    End Function

    Private Sub Form2_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Me.Text = "Member List"
        RefreshGrid()
    End Sub

    ' === REFRESH GRID ===
    Public Sub RefreshGrid()
        Try
            Using con As SqlConnection = GetConnection()
                ' FIX: Ipinapakita na lang ang mga HINDI deleted (is_deleted = 0)
                Dim sql As String = "SELECT id, last_name, first_name, Ministry, city FROM memberinfo WHERE is_deleted = 0"
                Using adapter As New SqlDataAdapter(sql, con)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    dgvInfo.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading members: " & ex.Message)
        End Try
    End Sub

    ' === SEARCH ===
    Private Sub txtSearch_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtSearch.TextChanged
        Try
            Using con As SqlConnection = GetConnection()
                ' FIX: Idinagdag ang "is_deleted = 0" para ang sine-search ay active members lang
                Dim query As String = "SELECT id, last_name, first_name, Ministry, city FROM memberinfo WHERE is_deleted = 0 AND (CAST(id AS VARCHAR(50)) LIKE @q OR last_name LIKE @q OR first_name LIKE @q OR Ministry LIKE @q)"
                Using adapter As New SqlDataAdapter(query, con)
                    adapter.SelectCommand.Parameters.AddWithValue("@q", "%" & txtSearch.Text.Trim() & "%")
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    dgvInfo.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Search error: " & ex.Message)
        End Try
    End Sub

    ' === CRUD at IBA PANG BUTTONS (ADD, UPDATE, DELETE, GENERATE ID) ===
    ' Ang mga code mo dito ay maganda at functional na. Walang kailangang baguhin.
    ' (btnAdd_Click, btnUpdate_Click, btnDelete_Click, btnGenerateID_Click)

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        ' Pwedeng ganito para bumalik sya after isara
        Using addForm As New Form1()
            If addForm.ShowDialog() = DialogResult.OK Then
                RefreshGrid()
            End If
        End Using
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If dgvInfo.CurrentRow Is Nothing Then
            ' FIX: Pinalitan ng MessageBox.Show
            MessageBox.Show("Please select a member record to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Try
            Dim studentID As Integer = Convert.ToInt32(dgvInfo.CurrentRow.Cells("id").Value)
            Using updateForm As New Form1(studentID)
                Dim result As DialogResult = updateForm.ShowDialog()
                If result = DialogResult.OK Then
                    RefreshGrid()
                End If
            End Using
        Catch ex As Exception
            ' FIX: Pinalitan din ng MessageBox.Show
            MessageBox.Show("An error occurred while trying to update: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If dgvInfo.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a member record to delete.")
            Return
        End If
        Dim studentID As Integer = Convert.ToInt32(dgvInfo.CurrentRow.Cells("id").Value)
        Dim studentName As String = dgvInfo.CurrentRow.Cells("first_name").Value.ToString() & " " & dgvInfo.CurrentRow.Cells("last_name").Value.ToString()

        ' FIX: Pinalitan ang mensahe
        If MessageBox.Show("Are you sure you want to move " & studentName & " to the Recycle Bin?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
            Return
        End If
        Try
            Using con As SqlConnection = GetConnection()
                con.Open()
                ' FIX: Hindi na DELETE, kundi UPDATE para i-set ang is_deleted = 1
                Dim query As String = "UPDATE memberinfo SET is_deleted = 1 WHERE id=@id"
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@id", studentID)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("✅ Member moved to Recycle Bin successfully!")
            RefreshGrid()
        Catch ex As Exception
            MessageBox.Show("Error deleting record: " & ex.Message)
        End Try
    End Sub
    Private Sub btnRecycle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecycle.Click
        Using recycleForm As New RecycleBinMembersForm()
            recycleForm.ShowDialog()
        End Using
        ' I-refresh ang grid baka may ni-restore na miyembro
        RefreshGrid()
    End Sub

    Private Sub btnGenerateID_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnGenerateID.Click
        If dgvInfo.CurrentRow Is Nothing Then
            MsgBox("Please select a member record to generate an ID.")
            Return
        End If

        ' --- Kunin ang data mula sa DataGridView (Walang pinagbago dito) ---
        Dim studentID As String = dgvInfo.CurrentRow.Cells("id").Value.ToString()
        Dim studentName As String = dgvInfo.CurrentRow.Cells("first_name").Value.ToString() & " " & dgvInfo.CurrentRow.Cells("last_name").Value.ToString()
        Dim course As String = dgvInfo.CurrentRow.Cells("Ministry").Value.ToString()
        Dim city As String = dgvInfo.CurrentRow.Cells("city").Value.ToString()
        Dim studentPic As Byte() = Nothing

        Try
            Using con As SqlConnection = GetConnection()
                Dim query As String = "SELECT profile_pic FROM memberinfo WHERE id = @id"
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@id", CInt(studentID)) ' Siguraduhing tama ang data type
                    con.Open()
                    Dim result As Object = cmd.ExecuteScalar()
                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        studentPic = CType(result, Byte())
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error fetching profile picture: " & ex.Message)
            Return ' Itigil kung may error
        End Try


        ' === ITO ANG INAYOS NA BAHAGI ===

        ' 1. Ipakita ang loading screen. Ang code ay hihinto dito hanggang magsara ang loading screen.
        Using loadingForm As New generating()
            loadingForm.ShowDialog()
        End Using

        ' 2. Kapag nagsara na ang loading screen, saka lang gagawin at ipapakita ang ID Card.
        Using idCardForm As New FormIDCard(studentID, studentName, course, city, studentPic)
            idCardForm.ShowDialog()
        End Using

    End Sub

     Private Sub LoadMinistry(ByVal ministryName As String)
        Try
            Using con As SqlConnection = GetConnection()
                ' FIX: Idinagdag ang "is_deleted = 0" para active members lang ang makita
                Dim query As String = "SELECT id, last_name, first_name, Ministry, city FROM memberinfo WHERE is_deleted = 0 AND UPPER(LTRIM(RTRIM(Ministry))) = UPPER(@m)"
                Using adapter As New SqlDataAdapter(query, con)
                    adapter.SelectCommand.Parameters.AddWithValue("@m", ministryName.Trim())
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    dgvInfo.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error filtering ministry: " & ex.Message)
        End Try
    End Sub

    ' Ang mga ito ay tama na, dahil tumatawag lang sila sa inayos na LoadMinistry function.
    Private Sub WORSHIPTEAMToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WORSHIPTEAMToolStripMenuItem.Click
        LoadMinistry("WORSHIP TEAM MINISTRY")
    End Sub

    Private Sub YOUTHMINISTRYToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles YOUTHMINISTRYToolStripMenuItem.Click
        LoadMinistry("YOUTH MINISTRY")
    End Sub

    Private Sub KIDSMINISTRYToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles KIDSMINISTRYToolStripMenuItem.Click
        LoadMinistry("KIDS MINISTRY")
    End Sub

    Private Sub WOMENSMINISTRYToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles WOMENSMINISTRYToolStripMenuItem.Click
        LoadMinistry("WOMENS MINISTRY")
    End Sub

    Private Sub MENSMINISTRYToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles MENSMINISTRYToolStripMenuItem.Click
        LoadMinistry("MENS MINISTRY")
    End Sub
    Private Sub AllMinistryToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ALLMINISTRYToolStripMenuItem.Click
        ' Para ipakita ang lahat, tawagin lang ang RefreshGrid()
        RefreshGrid()
    End Sub


    ' ==== NAVIGATION BUTTONS ====

    Private Sub btnDashboard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDashboard.Click
        ' TAMA ITO: Lilipat sa Dashboard at isasara ang current form
        Dim dashboardForm As New DashboardForm()
        dashboardForm.Show()
        Me.Close()
    End Sub

    Private Sub btnEventsAttendance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEventsAttendance.Click
        ' TAMA ITO: Lilipat sa Attendance Form
        Dim attendForm As New AttendanceForm()
        attendForm.Show()
        Me.Close()
    End Sub

    Private Sub btnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogout.Click
        ' TAMA ITO: Babalik sa Login Form
        If MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim loginForm As New Form3()
            loginForm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnMemberAttendance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMemberAttendance.Click
        Dim attendanceForm As New MemberAttendanceForm() ' Siguraduhing ito ang tamang pangalan ng form
        attendanceForm.Show()
        Me.Close()
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        If dgvInfo.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a member to view.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Try
            ' 1. Kunin ang ID ng miyembro na napili sa grid.
            Dim memberId As Integer = Convert.ToInt32(dgvInfo.CurrentRow.Cells("id").Value)

            ' 2. Buksan ang Form1 gamit ang bagong "view-only" constructor.
            Using viewForm As New Form1(memberId, True) ' Ang 'True' ay nagsasabing "view mode" ito.
                viewForm.ShowDialog()
            End Using

        Catch ex As Exception
            MessageBox.Show("An error occurred while trying to view the record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvInfo_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvInfo.CellDoubleClick
        ' Tiyakin na hindi ang header row ang na-double-click
        If e.RowIndex < 0 Then Return

        ' Tiyakin na may napiling row
        If dgvInfo.CurrentRow Is Nothing Then Return

        Try
            ' 1. Kunin ang ID ng miyembro mula sa na-click na row.
            Dim memberId As Integer = Convert.ToInt32(dgvInfo.CurrentRow.Cells("id").Value)

            ' 2. Gumawa ng instance ng bagong form at ipasa ang ID.
            Using historyForm As New MemberHistoryForm(memberId)
                ' 3. Ipakita ang form.
                historyForm.ShowDialog()
            End Using

        Catch ex As Exception
            MessageBox.Show("An error occurred while trying to view history: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class