Imports System.IO
Public Class frmChangeUser


    Private Sub btnAdduser_Click(sender As Object, e As EventArgs) Handles btnAdduser.Click
        If txtNewName.Text = "" Then
            MsgBox("You must enter a user name", MsgBoxStyle.Critical, "Data Missing")
            txtNewName.Focus()
        ElseIf txtNewPass.Text = "" Then
            MsgBox("You must enter a password", MsgBoxStyle.Critical, "Data Missing")
            txtNewPass.Focus()
        ElseIf txtConPass.Text = "" Then
            MsgBox("You must confirm the password", MsgBoxStyle.Critical, "Data Missing")
            txtConPass.Focus()
        ElseIf txtNewPass.Text <> txtConPass.Text Then
            MsgBox("The two passwords do not match", MsgBoxStyle.Critical, "Passwords don't match")
            txtNewPass.Clear()
            txtConPass.Clear()
            txtNewPass.Focus()
        Else
            Using passwordWriter As StreamWriter = New StreamWriter("..\..\Resources\Login.txt", False) ' setting to false will rewrite the text in the login text file. 
                passwordWriter.Write(txtNewName.Text) 'Write new user name to login text file. 
                passwordWriter.Write(vbCrLf)
                passwordWriter.Write(txtNewPass.Text) 'write new password to login text file.
                MsgBox("User successfully added", MsgBoxStyle.Information, "User added")
                passwordWriter.Close()
            End Using
        End If
    End Sub

    Private Sub btnCan_Click(sender As Object, e As EventArgs) Handles btnCan.Click
        Me.Close()

    End Sub

    Private Sub frmChangeUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class