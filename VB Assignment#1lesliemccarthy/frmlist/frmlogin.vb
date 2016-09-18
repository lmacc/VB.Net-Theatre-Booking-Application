Imports System.IO

Public Class frmlogin
    Dim username, password As String
    Dim match As Boolean = False

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'open text file for reading
        Using passwordReader As StreamReader = New StreamReader("..\..\Resources\Login.txt")


            While Not (match Or passwordReader.EndOfStream)
                username = passwordReader.ReadLine
                password = passwordReader.ReadLine
                If (username = txtname.Text And password = txtpass.Text) Then
                    match = True 'If the user name and password that i use to login match the user name and password i type in then open the Admin form.
                End If
            End While
            If txtname.Text = username And match Then
                Me.Hide()
                Admin.Show()
            Else
                If (match) Then
                    MsgBox("Access granted.", MsgBoxStyle.Information, "Successful login")
                Else
                    MsgBox("Access denied.", MsgBoxStyle.Critical, "Contact your system administrator.")
                    btnLogin.Enabled = True
                End If
            End If
            ' Close the file 
            passwordReader.Close()
        End Using
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        Form1.Show()

    End Sub

    Private Sub frmlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class