Imports System.IO
Public Class frmRemoveShow
    Dim tempShowWriter As StreamWriter = New StreamWriter("..\..\Resources\Temp.txt")
    Dim showReader As StreamReader = New StreamReader("..\..\Resources\shows.txt")
    Dim showToDelete, showInFile As String
    Dim found As Boolean = False
    Private Sub frmRemoveShow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Do While Not showReader.EndOfStream
                'read in the name of the show and add it to the combo box
                cmbShow.Items.Add(showReader.ReadLine)
                For i = 1 To 14
                    showReader.ReadLine()

                Next
            Loop
            'close the file
            showReader.Close()
            ' Force the combo box to show the first item (otherwise it will be blank)
            cmbShow.SelectedIndex = 0



        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        showToDelete = Convert.ToString(cmbShow.SelectedItem)
        Dim showReader As StreamReader = New StreamReader("..\..\Resources\shows.txt")
        Try
            'Scroll through the file until you find the product to be removed
            Do While Not showReader.EndOfStream And Not found
                showInFile = showReader.ReadLine 'Read in the name of show from the file
                'if the name of the show read in from the file does not match the show to be deleted then move all details on that product to the temporary file
                If showInFile <> showToDelete Then
                    tempShowWriter.WriteLine(showInFile)

                    For i As UShort = 1 To 14
                        tempShowWriter.WriteLine(showReader.ReadLine)
                    Next
                    found = False
                Else 'if you have found the show to be deleted
                    'skip the show by reading in the remaining 9 details for that show
                    For i As UShort = 1 To 14
                        Dim temp = showReader.ReadLine()
                    Next
                    'copy the remaining contents of the file to the tempory file
                    Dim thetemp As String = showReader.ReadToEnd
                    MsgBox(thetemp & "****")
                    tempShowWriter.Write(thetemp)
                    found = True
                End If

            Loop

            If found Then
                ' Close both files

                showReader.Close()
                tempShowWriter.Close()

                ' Now copy the contents of the temporary file back to shows.txt
                showReader = New StreamReader("..\..\Resources\Temp.txt")
                tempShowWriter = New StreamWriter("..\..\Resources\shows.txt")

                tempShowWriter.WriteLine(showReader.ReadToEnd)

                ' Close the files
                showReader.Close()
                tempShowWriter.Close()
                MsgBox("All details on " & showToDelete & " have been removed.", , "Successful deletion")
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Admin.Show()
    End Sub

   
    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()
        Admin.Show()
    End Sub
End Class