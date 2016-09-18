Imports frmlist.Form1



Public Class printTickets




    Private Sub printTickets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim today As String = Convert.ToString(Date.Now)
        Dim newCard As String
        Dim lastDigits, dateOfShow As String

        If Form1.chkMatinee.Checked Then 'check if matinee check box is enabled in the class Form1, if it is then get the date of show.
            dateOfShow = matDate
        Else
            dateOfShow = EvnDate

        End If

        lastDigits = creditCard.Substring(creditCard.Length - 4) ' string variable (lastDigits) is equal to the last 4 digits of the credit card
        Dim mask As New String("*"c, creditCard.Length - 4) 'string (mask) is equal to the length of the credit card minus 4 digits 
        newCard = String.Concat(mask, lastDigits) ' string (newCard) will add 12 (*) which is (mask) to the last 4 digits which is (lastDigits) 
        'proper term is concatonate the 2 strings togeather as we cant actually add strings without converting them first.

        'Output to print tickets form.
        txtShow.Text = showToSelect
        txtDate.Text = today
        txtDateofShow.Text = dateOfShow
        txtName.Text = fullName
        txtAddress.Text = address
        txtStreet.Text = street
        txtCity.Text = city
        txtCard.Text = newCard
        txtAdult.Text = Convert.ToString(AdultTicket)
        txtChild.Text = Convert.ToString(ChildTicket)
        txtPromo.Text = PromoCode
        txtTotal.Text = total

    End Sub



    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub


End Class