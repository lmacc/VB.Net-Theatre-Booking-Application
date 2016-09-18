Public Class paymentform


    Private Sub paymentform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTotal.Text = total

        If lblTotal.Text = "" Then 'if label total equals nothing then user must go back and click button for price.
            MsgBox("Go Back and Click for Price")
            Me.Close()

        End If

        For i As Integer = Date.Now.Year To Date.Now.Year + 5 'Year is cast to an interger showing this year with the combo box listing 5 more years
            cmbYear.Items.Add(i)
        Next i

        For i As Integer = Date.Now.Month To Date.Now.Month + 11 'Month is cast to an interger showing this month with the combo box listing 11 more months
            cmbMonth.Items.Add(i)
        Next
        cmbMonth.SelectedIndex = 0 'Setting index to 0 forces the combo box to display this month
        cmbYear.SelectedIndex = 0 'Setting index to 0 forces the combo box to display this year.

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        Form1.Show()

    End Sub

    Private Sub btnSub_Click(sender As Object, e As EventArgs) Handles btnSub.Click
        fullName = txtfName.Text + " " + txtlName.Text 'Concatinate first and second name
        address = txtAddress.Text
        street = txtStreet.Text
        city = txtCity.Text
        creditCard = txtCardNumber.Text

        If (rbtCard.Checked = False) Then
            MsgBox("You must choose a card", MsgBoxStyle.OkOnly, "Error in input")

        ElseIf txtCardName.Text <> fullName Then
            MsgBox("Your credit card name first and last name dont match.", MsgBoxStyle.OkOnly, "Error in input")
            txtCardName.Focus()

        ElseIf txtCardNumber.TextLength <> 16 Then
            MsgBox("Your credit card number must consist of 16 digits.", MsgBoxStyle.OkOnly, "Error in input")
            txtCardNumber.Focus()

        Else
            Dim answer As Integer = MsgBox("Are you sure you want to place this order", MsgBoxStyle.YesNo, "Are you sure?")
            If answer = vbYes Then
                MsgBox("Thank You for Your purchase ")
                Me.Close()
                printTickets.Show()

            End If

        End If
    End Sub

    Private Sub txtCardNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCardNumber.KeyPress 'Digits only allowed 
        If Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = Chr(8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCardName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCardName.KeyPress, txtfName.KeyPress, txtlName.KeyPress
        If Not (e.KeyChar >= "a" And e.KeyChar <= "z" Or e.KeyChar >= "A" And e.KeyChar <= "Z" Or e.KeyChar = " " Or e.KeyChar = Chr(8) Or e.KeyChar = Chr(96) Or e.KeyChar = Chr(39)) Then

            e.Handled = True

        End If

    End Sub

   
    Private Sub txtCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCode.KeyPress
        If Not (Char.IsLetterOrDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or e.KeyChar = " ") Then 'First check to see if the characters are valid
            'characters allowed letters, digits, backspace or space only.
            e.Handled = True

        End If
    End Sub

    Private Sub txtCode_LostFocus(sender As Object, e As EventArgs) Handles btnCheck.Click
        Dim validCode As Boolean = True
        If (txtCode.Text.Length <> 6) Then 'Then check for length of string to equal 6 characters only.
            validCode = False

        ElseIf Not (Char.IsLetter(txtCode.Text.ElementAt(0))) Then
            validCode = False

        ElseIf Not (Char.IsLetter(txtCode.Text.ElementAt(1))) Then
            validCode = False

        ElseIf Not (Char.IsLetter(txtCode.Text.ElementAt(2))) Then
            validCode = False

        Else
            For i As Integer = 3 To txtCode.Text.Length - 1

                If Not (Char.IsDigit(txtCode.Text.ElementAt(i))) Then
                    validCode = False 'Count last 3 characters and if they are digits validation is true, else validation is false
                End If

            Next

        End If
        If Not (validCode) Then
            MsgBox("Promotional Code Not Valid", vbInformation, "Invalid Code")
            txtCode.Text = ""
            txtCode.Focus()

        Else

            txtCode.Text = txtCode.Text.ToUpper 'when string has passed validation, set the characters to uppercase.
            PromoCode = txtCode.Text
            Dim reducedPrice As Single
            Dim newTotal As String
            reducedPrice = Convert.ToSingle(CDbl(total) * 0.2) 'if the validation is true for (Promotional Code) then there is a reduction 20% to the customer.
            newTotal = FormatCurrency(CDbl(total) - reducedPrice)
            total = newTotal
            lblTotal.Text = total
            reducedPrice = CSng(FormatCurrency(reducedPrice))
            MsgBox("Congradulations Your new price has been reduced by   " & reducedPrice)

        End If

    End Sub

    Private Sub txtfName_TextChanged(sender As Object, e As EventArgs) Handles txtfName.TextChanged

    End Sub
End Class