Public Class frmMain

    'Reset button
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        resetValue()
    End Sub

    'Submit button
    Private Sub btnSubmit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSubmit.Click
        checkInput()
    End Sub

    'Exit button
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Call exitProgram function
        exitProgram()
    End Sub

    'Exit function
    Public Function exitProgram()
        Dim exitmsg As String
        exitmsg = MsgBox("Are you sure ?", vbQuestion + vbYesNo, "Restaurant Job Application Form")
        If exitmsg = vbYes Then
            Me.Close()
        Else
            MsgBox("You can continue.", vbQuestion + vbOKOnly, "Restaurant Job Application Form")
        End If
        Return True
    End Function

    'Check input function
    Public Function checkInput()
        'Set value 
        numAge.Maximum = 40
        numAge.Minimum = 25
        numExp.Maximum = 10
        numSalary.Minimum = 2000
        numSalary.Maximum = 7000

        If txtName.Text = "" Then
            MsgBox("Please fill in your name !", vbExclamation + vbOKOnly, "Restaurant Job Application Form")
        ElseIf txtIC.TextLength < 12 Then
            MsgBox("Identical Card Number should not less than 12 !", vbExclamation + vbOKOnly, "Restaurant Job Application Form")
        ElseIf txtIC.TextLength > 12 Then
            MsgBox("Identical Card Number should not more than 12 !", vbExclamation + vbOKOnly, "Restaurant Job Application Form")
        ElseIf radioFemale.Checked = False And radioMale.Checked = False Then
            MsgBox("Please select gender !", vbExclamation + vbOKOnly, "Restaurant Job Application Form")
        ElseIf txtAddress.Text = "" Then
            MsgBox("Please fill in your address !", vbExclamation + vbOKOnly, "Restaurant Job Application Form")
        ElseIf txtEmail.Text = "" Then
            MsgBox("Please fill in your email address !", vbExclamation + vbOKOnly, "Restaurant Job Application Form")
        ElseIf txtPhone.TextLength < 10 Then
            MsgBox("Phone Number should not less than 10 !", vbExclamation + vbOKOnly, "Restaurant Job Application Form")
        ElseIf txtPhone.TextLength > 11 Then
            MsgBox("Phone Number should not more than 11 !", vbExclamation + vbOKOnly, "Restaurant Job Application Form")

        ElseIf comboEdu.Text = "" Then
            MsgBox("Please select your education !", vbExclamation + vbOKOnly, "Restaurant Job Application Form")

        Else
            Dim formResult As New frmResult
            MsgBox("Submit Successful !", vbOKOnly, "Restaurant Job Application Form")
            frmResult.Show()
            'Call dataSubmit function from frmResult
            frmResult.dataSubmit()
        End If
        Return True
    End Function

    'Reset value function
    Public Function resetValue()
        txtName.Clear()
        txtAddress.Clear()
        txtEmail.Clear()
        txtIC.Clear()
        txtPhone.Clear()
        radioMale.Checked = False
        radioFemale.Checked = False

        numAge.Value = 25
        numExp.Value = 0
        numSalary.Value = 2000
        comboEdu.Text = ""


        Return True
    End Function

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub radioMale_CheckedChanged(sender As Object, e As EventArgs) Handles radioMale.CheckedChanged

    End Sub
End Class
