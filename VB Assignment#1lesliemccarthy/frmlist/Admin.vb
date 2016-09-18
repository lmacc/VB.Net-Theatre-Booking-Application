Imports System.IO
Public Class Admin

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If (cmbMat.Text = "") Then
            MsgBox("You must enter a title for a show ", MsgBoxStyle.Critical, "Data Missing")
       
        ElseIf (txtPriAdultMat.Text = "") Then
            MsgBox("You must enter a price for adult tickets", MsgBoxStyle.Critical, "Data Missing")
            txtPriAdultMat.Focus()

        ElseIf (txtPriChildMat.Text = "") Then
            MsgBox("You must enter a price for children tickets", MsgBoxStyle.Critical, "Data Missing")
            txtPriChildMat.Focus()

        ElseIf (txtSeatMat.Text = "") Then
            MsgBox("Enter quantity of seats for matinee show", MsgBoxStyle.Critical, "Data Missing")
            txtSeatMat.Focus()

        ElseIf (txtPriAdultEvn.Text = "") Then
            MsgBox("Enter a price for adult tickets", MsgBoxStyle.Critical, "Data Missing")
            txtPriAdultEvn.Focus()

        ElseIf (txtSeatEvn.Text = "") Then
            MsgBox("Enter quantity of seats for evening show", MsgBoxStyle.Critical, "Data Missing")
            txtSeatEvn.Focus()

        ElseIf (rtxtbox.Text = "") Then
            MsgBox("Enter a summary for show event", MsgBoxStyle.Critical, "Data Missing")
            rtxtbox.Focus()
        Else
            'All data is entered 
            Try

                Using showWriter As StreamWriter = New StreamWriter("..\..\Resources\shows.txt", True)
                    With showWriter
                        'Write all the details to shows.txt file 
                        'matinee show
                        .WriteLine(cmbMat.Text)
                        .WriteLine(dtpMat.Text)
                        .WriteLine(dtpMatStart.Text)
                        .WriteLine(dtpMatFin.Text)
                        .WriteLine(txtPriChildMat.Text)
                        .WriteLine(txtPriAdultMat.Text)
                        .WriteLine(txtSeatMat.Text)
                        'evening show
                        .WriteLine(cmbEvn.Text)
                        .WriteLine(dtpEvn.Text)
                        .WriteLine(dtpEvnStart.Text)
                        .WriteLine(dtpEvnFin.Text)
                        .WriteLine(txtPriceChildEv.Text)
                        .WriteLine(txtPriAdultEvn.Text)
                        .WriteLine(txtSeatEvn.Text)
                        .WriteLine(rtxtbox.Text)

                        showWriter.Close() ' Close the writer when all lines have been written to shows.txt file
                    End With
                    MsgBox("Details of " & cmbMat.Text & " Have been successfully added to file.", , "OK")

                End Using

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


        End If
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear all the text fields
       
        txtPriChildMat.Text = ""
        txtPriAdultMat.Text = ""
        txtSeatMat.Text = ""
        txtPriAdultEvn.Text = ""
        txtSeatEvn.Text = ""
        rtxtbox.Text = ""
    End Sub

    Private Sub frmAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With cmbMat.Items
            ' When the form loads populate the combo box with the titles listed here.
            .Add("Ben and Holly")
            .Add("Carries War")
            .Add("Joseph and the Amazing")
            .Add("Stomp")
            .Add("The Lion King")
            .Add("Phantom of the Opera")
            .Add("Les Miserables")
            .Add("War-horse")
            .Add("Dirty-dancing")
            .Add("A little music")
            .Add("We will Rock You")

        End With
        cmbMat.SelectedIndex = 0 'set the combo box to display the first title of show.

       
        With cmbEvn.Items
            .Add("NO Evening Show")
            .Add("YES Evening Show")
        End With
    End Sub

    Private Sub txtShow_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not (e.KeyChar = " " Or e.KeyChar >= "a" And e.KeyChar <= "z" Or e.KeyChar >= "A" And e.KeyChar <= "Z" Or e.KeyChar = Chr(8)) Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtPriChildMat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPriChildMat.KeyPress, txtPriAdultMat.KeyPress, txtPriAdultEvn.KeyPress
        'Allow digits and the backspace key only
        If Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = Chr(8) Or e.KeyChar = Chr(46)) Then
            e.Handled = True

        End If
    End Sub

    Private Sub txtSeatsMat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSeatMat.KeyPress, txtSeatEvn.KeyPress
        'Allow digits and the backspace key only
        If Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = Chr(8)) Then
            e.Handled = True

        End If
    End Sub


    Private Sub cmbMat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbMat.KeyPress
        If Not (cmbMat.Text = "Ben and Holly" Or cmbMat.Text = "Carries War" Or cmbMat.Text = "Joseph and the Amazing" Or cmbMat.Text = "Stomp" Or
           cmbMat.Text = "The Lion King" Or cmbMat.Text = "Phantom of the Opera" Or cmbMat.Text = "Les Miserables" Or cmbMat.Text = "War-horse" Or
           cmbMat.Text = "Dirty-dancing" Or cmbMat.Text = "A little music" Or cmbMat.Text = "We will Rock You") Then
            ptb1.Image = Bitmap.FromFile("..\..\Resources\12.jpg")
        End If

    End Sub

    Private Sub txtPriceChildEv_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPriceChildEv.KeyPress
        If Not (e.KeyChar = "0" Or e.KeyChar = "" Or e.KeyChar = Chr(8)) Then
            e.Handled = True
        End If
    End Sub


    Private Sub btnChangeUser_Click(sender As Object, e As EventArgs) Handles btnChangeUser.Click
        Me.Hide()
        frmChangeUser.Show()

    End Sub


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        Form1.Show()

    End Sub


    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Me.Hide()
        frmRemoveShow.Show()

    End Sub

    Private Sub cmbMat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMat.SelectedIndexChanged
        If cmbMat.Text = "Ben and Holly" Then
            ptb1.Image = Bitmap.FromFile("..\..\Resources\1.jpg")

        ElseIf cmbMat.Text = "Carries War" Then
            ptb1.Image = Bitmap.FromFile("..\..\Resources\2.jpg")

        ElseIf cmbMat.Text = "Joseph and the Amazing" Then
            ptb1.Image = Bitmap.FromFile("..\..\Resources\3.jpg")

        ElseIf cmbMat.Text = "Stomp" Then
            ptb1.Image = Bitmap.FromFile("..\..\Resources\4.jpg")

        ElseIf cmbMat.Text = "The Lion King" Then
            ptb1.Image = Bitmap.FromFile("..\..\Resources\5.jpg")

        ElseIf cmbMat.Text = "Phantom of the Opera" Then
            ptb1.Image = Bitmap.FromFile("..\..\Resources\6.jpg")

        ElseIf cmbMat.Text = "Les Miserables" Then
            ptb1.Image = Bitmap.FromFile("..\..\Resources\7.jpg")

        ElseIf cmbMat.Text = "War-horse" Then
            ptb1.Image = Bitmap.FromFile("..\..\Resources\8.jpg")

        ElseIf cmbMat.Text = "Dirty-dancing" Then
            ptb1.Image = Bitmap.FromFile("..\..\Resources\9.jpg")

        ElseIf cmbMat.Text = "A little music" Then
            ptb1.Image = Bitmap.FromFile("..\..\Resources\10.jpg")

        ElseIf cmbMat.Text = "We will Rock You" Then
            ptb1.Image = Bitmap.FromFile("..\..\Resources\11.jpg")

        Else
            ptb1.Image = Bitmap.FromFile("..\..\Resources\12.jpg")


        End If
    End Sub

    Private Sub cmbEvn_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEvn.SelectedIndexChanged

    End Sub
End Class