Imports System.Data.SqlClient
Imports System.Globalization
Imports System.IO
Imports System.Drawing.Imaging

Public Class Form1
    ' --- PRIVATE VARIABLES ---
    Private studentIdToUpdate As Integer? = Nothing
    Private isViewMode As Boolean = False ' Ginagamit para malaman kung ang form ay para sa viewing lang.

#Region "Constructors"
    ' Constructor para sa pag-ADD ng bagong member
    Public Sub New()
        InitializeComponent()
    End Sub

    ' Constructor para sa pag-UPDATE ng existing member
    Public Sub New(ByVal studentID As Integer)
        InitializeComponent()
        Me.studentIdToUpdate = studentID
    End Sub

    ' Constructor para sa pag-VIEW ng existing member (read-only)
    Public Sub New(ByVal studentID As Integer, ByVal isViewOnly As Boolean)
        InitializeComponent()
        Me.studentIdToUpdate = studentID
        Me.isViewMode = isViewOnly
    End Sub
#End Region

#Region "Helper Functions"
    ' Nagbibigay ng bagong instance ng SqlConnection
    Private Function GetConnection() As SqlConnection
        Return New SqlConnection("Server=DESKTOP-GO\SQLEXPRESS; Database=MemberInfo; Trusted_Connection=True;")
    End Function

    ' Helper para magpakita ng Information MessageBox
    Private Sub ShowInfo(ByVal message As String, ByVal title As String)
        MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' Helper para magpakita ng Error MessageBox
    Private Sub ShowError(ByVal message As String)
        MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
#End Region

#Region "Form Load and Data Loading"
    ' Pangunahing event na tumatakbo pagbukas ng form
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' Itago muna ang date sa DateTimePicker
        Date_day.Format = DateTimePickerFormat.Custom
        Date_day.CustomFormat = " "

        If isViewMode Then
            ' --- KUNG ANG FORM AY NASA "VIEW MODE" ---
            Me.Text = "View Member Information"
            LoadDataForUpdate() ' I-load ang data
            SetViewOnlyMode()   ' I-lock ang lahat ng controls
        ElseIf studentIdToUpdate.HasValue Then
            ' --- KUNG ANG FORM AY NASA "UPDATE MODE" ---
            Me.Text = "Update Member Record"
            btnAdd.Text = "Save Changes"
            btnClear.Visible = False
            btnViewRecords.Visible = False ' Itago ang 'Back to List' sa update mode
            LoadDataForUpdate()
        Else
            ' --- KUNG ANG FORM AY NASA "ADD MODE" ---
            Me.Text = "Add New Member"
            btnViewRecords.Text = "Back to List"
        End If
    End Sub

    ' Kumukuha ng data mula sa database para i-populate ang form fields
    Private Sub LoadDataForUpdate()
        If Not studentIdToUpdate.HasValue Then Return

        Using con As SqlConnection = GetConnection()
            Dim query As String = "SELECT * FROM memberinfo WHERE id = @id"
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@id", studentIdToUpdate.Value)
                Try
                    con.Open()
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            txtID.Text = reader("id").ToString()
                            txtLname.Text = reader("last_name").ToString()
                            txtFname.Text = reader("first_name").ToString()
                            txtMname.Text = reader("middle_name").ToString()
                            txtSuffix.Text = reader("suffix").ToString()
                            CBox1Gender.Text = reader("gender").ToString()
                            Dim bdayString As String = reader("birthday").ToString()
                            Dim parsedDate As DateTime
                            If DateTime.TryParseExact(bdayString, "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, parsedDate) Then
                                Date_day.Value = parsedDate
                                Date_day.CustomFormat = "MM/dd/yyyy"
                            End If
                            CBox2Civil.Text = reader("civil_status").ToString()
                            txtCitizen.Text = reader("citizenship").ToString()
                            txtSUno.Text = reader("street_no").ToString()
                            txtStreet.Text = reader("street").ToString()
                            txtSubdivi.Text = reader("subdivision").ToString()
                            txtBrgy.Text = reader("barangay").ToString()
                            txtCity.Text = reader("city").ToString()
                            txtZipcode.Text = reader("zip_code").ToString()
                            txtCNum.Text = reader("contact_num").ToString()
                            txtAge.Text = reader("age").ToString()
                            txtFather.Text = reader("father_name").ToString()
                            txtFnum.Text = reader("num").ToString()
                            txtMother.Text = reader("mother_name").ToString()
                            txtMnum.Text = reader("num1").ToString()
                            txtGuard.Text = reader("guardian_name").ToString()
                            txtGnum.Text = reader("num2").ToString()
                            ComboBox1.Text = reader("Ministry").ToString()

                            If Not IsDBNull(reader("profile_pic")) Then
                                Dim imageData As Byte() = DirectCast(reader("profile_pic"), Byte())
                                Dim tempImage As Image
                                Using ms As New MemoryStream(imageData)
                                    tempImage = Image.FromStream(ms)
                                End Using
                                pbStudentPic.Image = New Bitmap(tempImage)
                                tempImage.Dispose()
                            Else
                                pbStudentPic.Image = Nothing
                            End If
                        End If
                    End Using
                Catch ex As Exception
                    ShowError("Failed to load member data: " & ex.Message)
                    Me.Close()
                End Try
            End Using
        End Using
    End Sub
#End Region

#Region "View-Only Mode Setup"
    ' Ginagawang read-only ang buong form
    Private Sub SetViewOnlyMode()
        ' Itago ang mga action buttons
        btnAdd.Visible = False
        btnClear.Visible = False
        btnUploadPic.Visible = False

        ' Palitan ang text ng "Back" button para maging "Close"
        btnViewRecords.Text = "Close"

        ' I-disable ang lahat ng input controls (TextBox, ComboBox, etc.)
        DisableAllInputs(Me)
    End Sub

    ' Recursive function na nagdi-disable ng lahat ng input controls sa loob ng isang parent control
    Private Sub DisableAllInputs(ByVal parent As Control)
        For Each c As Control In parent.Controls
            If TypeOf c Is TextBox Then
                CType(c, TextBox).ReadOnly = True
            ElseIf TypeOf c Is ComboBox Then
                CType(c, ComboBox).Enabled = False
            ElseIf TypeOf c Is DateTimePicker Then
                CType(c, DateTimePicker).Enabled = False
            End If

            ' Kung ang control ay isang container (tulad ng TabPage, Panel, GroupBox),
            ' pasukin ito at i-disable din ang mga controls sa loob.
            If c.HasChildren Then
                DisableAllInputs(c)
            End If
        Next
    End Sub
#End Region

#Region "Main Action Buttons (Save/Update, Clear, Back)"
    ' Button para mag-save ng bago o i-update ang existing na record
    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdd.Click
        Using con As SqlConnection = GetConnection()
            con.Open()
            Try
                Dim query As String
                Dim cmd As SqlCommand
                Dim imageToSave As Object = DBNull.Value

                ' Kunin ang image mula sa PictureBox kung meron
                If pbStudentPic.Image IsNot Nothing Then
                    Using ms As New MemoryStream()
                        pbStudentPic.Image.Save(ms, ImageFormat.Jpeg) ' I-save as Jpeg para mas maliit ang file size
                        imageToSave = ms.ToArray()
                    End Using
                End If

                If studentIdToUpdate.HasValue Then
                    ' --- UPDATE QUERY ---
                    query = "UPDATE memberinfo SET last_name=@last_name, first_name=@first_name, middle_name=@middle_name, suffix=@suffix, gender=@gender, birthday=@birthday, civil_status=@civil_status, citizenship=@citizenship, street_no=@street_no, street=@street, subdivision=@subdivision, barangay=@barangay, city=@city, zip_code=@zip_code, contact_num=@contact_num, age=@age, father_name=@father_name, num=@num, mother_name=@mother_name, num1=@num1, guardian_name=@guardian_name, num2=@num2, Ministry=@Ministry, profile_pic=@profile_pic WHERE id=@id"
                    cmd = New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@id", studentIdToUpdate.Value)
                Else
                    ' --- INSERT QUERY ---
                    query = "INSERT INTO memberinfo (last_name, first_name, middle_name, suffix, gender, birthday, civil_status, citizenship, street_no, street, subdivision, barangay, city, zip_code, contact_num, age, father_name, num, mother_name, num1, guardian_name, num2, Ministry, profile_pic) VALUES(@last_name, @first_name, @middle_name, @suffix, @gender, @birthday, @civil_status, @citizenship, @street_no, @street, @subdivision, @barangay, @city, @zip_code, @contact_num, @age, @father_name, @num, @mother_name, @num1, @guardian_name, @num2, @Ministry, @profile_pic)"
                    cmd = New SqlCommand(query, con)
                End If

                ' I-assign ang lahat ng parameters
                Dim dateToSave As String = Date_day.Value.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture)
                cmd.Parameters.AddWithValue("@last_name", txtLname.Text)
                cmd.Parameters.AddWithValue("@first_name", txtFname.Text)
                cmd.Parameters.AddWithValue("@middle_name", txtMname.Text)
                cmd.Parameters.AddWithValue("@suffix", txtSuffix.Text)
                cmd.Parameters.AddWithValue("@gender", CBox1Gender.Text)
                cmd.Parameters.AddWithValue("@birthday", dateToSave)
                cmd.Parameters.AddWithValue("@civil_status", CBox2Civil.Text)
                cmd.Parameters.AddWithValue("@citizenship", txtCitizen.Text)
                cmd.Parameters.AddWithValue("@street_no", txtSUno.Text)
                cmd.Parameters.AddWithValue("@street", txtStreet.Text)
                cmd.Parameters.AddWithValue("@subdivision", txtSubdivi.Text)
                cmd.Parameters.AddWithValue("@barangay", txtBrgy.Text)
                cmd.Parameters.AddWithValue("@city", txtCity.Text)
                cmd.Parameters.AddWithValue("@zip_code", txtZipcode.Text)
                cmd.Parameters.AddWithValue("@contact_num", txtCNum.Text)
                cmd.Parameters.AddWithValue("@age", txtAge.Text)
                cmd.Parameters.AddWithValue("@father_name", txtFather.Text)
                cmd.Parameters.AddWithValue("@num", txtFnum.Text)
                cmd.Parameters.AddWithValue("@mother_name", txtMother.Text)
                cmd.Parameters.AddWithValue("@num1", txtMnum.Text)
                cmd.Parameters.AddWithValue("@guardian_name", txtGuard.Text)
                cmd.Parameters.AddWithValue("@num2", txtGnum.Text)
                cmd.Parameters.AddWithValue("@Ministry", ComboBox1.Text)
                cmd.Parameters.Add("@profile_pic", SqlDbType.VarBinary, -1).Value = imageToSave

                cmd.ExecuteNonQuery()

                If studentIdToUpdate.HasValue Then
                    ShowInfo("✅ Updated Successfully", "Success")
                Else
                    ShowInfo("✅ Added Successfully", "Success")
                End If

                Me.DialogResult = DialogResult.OK
                Me.Close()
            Catch ex As Exception
                ShowError("An error occurred while saving: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Button para bumalik sa Form2 o isara ang form
    Private Sub btnViewRecords_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnViewRecords.Click
        Me.DialogResult = DialogResult.Cancel ' Gamitin ang Cancel para malaman ng Form2 na walang nagbago
        Me.Close()
    End Sub

    ' Button para i-clear lahat ng fields (available lang sa Add Mode)
    Private Sub btnClear_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClear.Click
        ClearAllFields()
    End Sub

    ' Button para mag-upload ng profile picture
    Private Sub btnUploadPic_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnUploadPic.Click
        Using openFile As New OpenFileDialog()
            openFile.Filter = "Image Files(*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png"
            If openFile.ShowDialog() = DialogResult.OK Then
                Try
                    If pbStudentPic.Image IsNot Nothing Then
                        pbStudentPic.Image.Dispose()
                    End If
                    ' Gumamit ng 'Using' para siguradong mare-release ang file lock
                    Using tempImage As Image = Image.FromFile(openFile.FileName)
                        pbStudentPic.Image = New Bitmap(tempImage)
                    End Using
                Catch ex As Exception
                    ShowError("Failed to load image: " & ex.Message)
                End Try
            End If
        End Using
    End Sub

    ' Function para linisin lahat ng input controls
    Private Sub ClearAllFields()
        txtID.Clear()
        txtLname.Clear()
        txtFname.Clear()
        txtMname.Clear()
        txtSuffix.Clear()
        CBox1Gender.SelectedIndex = -1
        CBox2Civil.SelectedIndex = -1
        txtCitizen.Clear()
        txtSUno.Clear()
        txtStreet.Clear()
        txtSubdivi.Clear()
        txtBrgy.Clear()
        txtCity.Clear()
        txtZipcode.Clear()
        txtCNum.Clear()
        txtAge.Clear()
        txtFather.Clear()
        txtFnum.Clear()
        txtMother.Clear()
        txtMnum.Clear()
        txtGuard.Clear()
        txtGnum.Clear()
        ComboBox1.SelectedIndex = -1
        pbStudentPic.Image = Nothing
        Date_day.Value = DateTime.Now
        Date_day.CustomFormat = " "
        txtLname.Focus()
    End Sub
#End Region

#Region "Tab Navigation and Other UI Events"
    ' Nagpapakita ng date sa picker kapag binago ang value
    Private Sub Date_day_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Date_day.ValueChanged
        Date_day.CustomFormat = "MM/dd/yyyy"
    End Sub

    ' Navigation para sa TabControl
    Private Sub btnNext_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNext.Click
        TabControl1.SelectedTab = TabPage2
    End Sub

    Private Sub btnBack2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBack2.Click
        TabControl1.SelectedTab = TabPage1
    End Sub

    Private Sub btnNext2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNext2.Click
        TabControl1.SelectedTab = TabPage3
    End Sub

    Private Sub btnBack3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBack3.Click
        TabControl1.SelectedTab = TabPage2
    End Sub
#End Region

End Class