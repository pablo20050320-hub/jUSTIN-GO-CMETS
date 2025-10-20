Module Utilities


    Public Sub ShowInfo(ByVal message As String, Optional ByVal title As String = "Info")
        MsgBox(message, MsgBoxStyle.Information, title)
    End Sub


    Public Sub ShowError(ByVal message As String, Optional ByVal title As String = "Error")
        MsgBox(message, MsgBoxStyle.Critical, title)
    End Sub

    Public Sub ShowWarning(ByVal message As String, Optional ByVal title As String = "Warning")
        MsgBox(message, MsgBoxStyle.Exclamation, title)
    End Sub

    Public Sub ClearTextBoxes(ByVal parent As Control)
        For Each ctrl As Control In parent.Controls
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Clear()
            ElseIf ctrl.HasChildren Then
                ClearTextBoxes(ctrl)
            End If
        Next
    End Sub

    Public Sub SetDatePickerFormat(ByVal dp As DateTimePicker, Optional ByVal format As String = "MM/dd/yyyy")
        dp.Format = DateTimePickerFormat.Custom
        dp.CustomFormat = format
    End Sub
End Module
