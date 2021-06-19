Public Class frmResult

    'Back button
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    'View button
    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        viewReason()
    End Sub

    'Display output function
    Public Function dataSubmit()
        lblName.Text = frmMain.txtName.Text
        lblIC.Text = frmMain.txtIC.Text
        lblAddress.Text = frmMain.txtAddress.Text
        lblAge.Text = frmMain.numAge.Value
        lblEmail.Text = frmMain.txtEmail.Text
        lblPhone.Text = frmMain.txtPhone.Text
        lblExp.Text = frmMain.numExp.Value
        lblSalary.Text = frmMain.numSalary.Value

        If frmMain.radioMale.Checked = True Then
            lblGender.Text = frmMain.radioMale.Text
        ElseIf frmMain.radioFemale.Checked = True Then
            lblGender.Text = frmMain.radioFemale.Text
        End If


        If frmMain.comboEdu.Text = "SPM" Then
            lblEdu.Text = "SPM"
        ElseIf frmMain.comboEdu.Text = "STPM" Then
            lblEdu.Text = "STPM"
        ElseIf frmMain.comboEdu.Text = "Diploma" Then
            lblEdu.Text = "Diploma"
        ElseIf frmMain.comboEdu.Text = "Degree" Then
            lblEdu.Text = "Degree"
        ElseIf frmMain.comboEdu.Text = "Master" Then
            lblEdu.Text = "Master"
        End If



        'Call for jobCondition function
        jobCondition()
        Return True
    End Function

    'Check for condition
    Public Function jobCondition()

        If frmMain.numExp.Value >= 2 Then
                If frmMain.comboEdu.Text = "Diploma" Or frmMain.comboEdu.Text = "Degree" Or frmMain.comboEdu.Text = "Master" Then

                If frmMain.radioFemale.Checked = True Then
                    lblResult.Text = "Qualified"
                    lblResult.ForeColor = Color.Green
                    btnView.Hide()
                Else
                    lblResult.Text = "Not Qualified"
                            lblResult.ForeColor = Color.Red
                        End If
                    Else
                        lblResult.Text = "Not Qualified"
                        lblResult.ForeColor = Color.Red
                    End If
                Else
                    lblResult.Text = "Not Qualified"
                    lblResult.ForeColor = Color.Red
                End If


        Return True
    End Function

    'View reason
    Public Function viewReason()
        Dim formView As New frmView
        frmView.Show()
        Return True
    End Function
End Class