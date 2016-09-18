Imports System.IO


Public Class Form1

    Dim Reader As StreamReader = New StreamReader("..\..\Resources\shows.txt") 'Reader is a string variable that stores the text data in the text shows file.

    Dim showToDisplay, showInFile As String

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click


        Me.Hide()
        frmlogin.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Do Until Reader.EndOfStream 'Read the shows.txt file to the end
                'read in the name of the show and add it to the combo box
                cmbList.Items.Add(Reader.ReadLine)
                For i = 1 To 14
                    Reader.ReadLine() '1 Every 14 lines read from the shows.txt file will be added to the combo box.

                Next


            Loop
            'close the file
            Reader.Close()
            ' Force the combo box to show the first item (otherwise it will be blank)
            cmbList.SelectedIndex = 0

        Catch ex As Exception

        End Try

    End Sub

    Private Sub cmbList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbList.SelectedIndexChanged
        DataGridView1.Rows.Clear()

        Dim matStart, matFinish As String
        Dim EvnStart, EvnFinish, EvnChild, remarks As String
        showToSelect = Convert.ToString(cmbList.SelectedItem) 'my string variable (showToSelect) will store the value of what ever item i select from the combo box.


        Try
            Dim Reader As StreamReader = New StreamReader("..\..\Resources\shows.txt")

            Do Until Reader.EndOfStream 'Read the entire shows.txt file and stop reading when at the end of the text file.

                selectFile = Reader.ReadLine 'my string variable (selectFile) represents the shows.txt file read line by line
                If selectFile = showToSelect Then 'here i will compare the show i select from the combo box (showToSelect) with my string variable (selectFile) if
                    'they match, then i want to read the rest of the data assocated with that show.

                    matDate = Reader.ReadLine() 'Date of show listing. Public variable matinee show
                    matStart = Reader.ReadLine()
                    matFinish = Reader.ReadLine()
                    matChild = Reader.ReadLine()
                    matAdult = Reader.ReadLine()
                    matSeats = Reader.ReadLine()
                    Evn = Reader.ReadLine()
                    EvnDate = Reader.ReadLine() 'Date of show listing. Public variable evening show
                    EvnStart = Reader.ReadLine()
                    EvnFinish = Reader.ReadLine()
                    EvnChild = Reader.ReadLine()
                    EvnAdult = Reader.ReadLine()
                    EvnSeats = Reader.ReadLine()
                    remarks = Reader.ReadLine()

                    DataGridView1.Rows.Add(selectFile, matDate, matStart, matFinish, "€" + matChild, "€" + matAdult, matSeats) 'The first row of the Data grid gets popualted
                    DataGridView1.Rows.Add(Evn, EvnDate, EvnStart, EvnFinish, "€" + EvnChild, "€" + EvnAdult, EvnSeats) 'The second row of the grid gets populated.
                    rtbRemarks.Text = remarks


                End If

            Loop
            Reader.Close()
            If (Evn = "NO Evening Show") Then 'when this is read from text file (evening check box) is set to false
                chkEvening.Enabled = False
                chkEvening.Checked = False
                MsgBox("Sorry no evening Show available!")
            Else
                chkEvening.Enabled = True
            End If

            If cmbList.Text = "Ben and Holly" Then
                ptb2.Image = Bitmap.FromFile("..\..\Resources\1.jpg")

            ElseIf cmbList.Text = "Carries War" Then
                ptb2.Image = Bitmap.FromFile("..\..\Resources\2.jpg")

            ElseIf cmbList.Text = "Joseph and the Amazing" Then
                ptb2.Image = Bitmap.FromFile("..\..\Resources\3.jpg")

            ElseIf cmbList.Text = "Stomp" Then
                ptb2.Image = Bitmap.FromFile("..\..\Resources\4.jpg")

            ElseIf cmbList.Text = "The Lion King" Then
                ptb2.Image = Bitmap.FromFile("..\..\Resources\5.jpg")

            ElseIf cmbList.Text = "Phantom of the Opera" Then
                ptb2.Image = Bitmap.FromFile("..\..\Resources\6.jpg")

            ElseIf cmbList.Text = "Les Miserables" Then
                ptb2.Image = Bitmap.FromFile("..\..\Resources\7.jpg")

            ElseIf cmbList.Text = "War-horse" Then
                ptb2.Image = Bitmap.FromFile("..\..\Resources\8.jpg")

            ElseIf cmbList.Text = "Dirty-dancing" Then
                ptb2.Image = Bitmap.FromFile("..\..\Resources\9.jpg")

            ElseIf cmbList.Text = "A little music" Then
                ptb2.Image = Bitmap.FromFile("..\..\Resources\10.jpg")

            ElseIf cmbList.Text = "We will Rock You" Then
                ptb2.Image = Bitmap.FromFile("..\..\Resources\11.jpg")

            Else
                ptb2.Image = Bitmap.FromFile("..\..\Resources\12.jpg")
            End If

        Catch ex As Exception
            MsgBox("No file found", MsgBoxStyle.Critical, "Missing File")
            cmbList.Focus()
        End Try

    End Sub


    Private Sub btnTickets_Click(sender As Object, e As EventArgs) Handles btnTickets.Click
       
        If (chkMatinee.Checked) Then 'Open the tickets Form
            tickets.Show()

        ElseIf (chkEvening.Checked) Then
            ticketsEvening.Show()

        Else
            MsgBox("Please Select a Show to buy Tickets!")


        End If

    End Sub

   
    Private Sub chkMatinee_CheckedChanged(sender As Object, e As EventArgs) Handles chkMatinee.CheckedChanged
        If chkMatinee.Checked = True Then
            chkEvening.Enabled = False
        Else
            chkEvening.Enabled = True
        End If

    End Sub

    Private Sub chkEvening_CheckedChanged(sender As Object, e As EventArgs) Handles chkEvening.CheckedChanged
        If chkEvening.Checked = True Then
            chkMatinee.Enabled = False

        Else
            chkMatinee.Enabled = True
        End If
    End Sub

   
End Class
