Public Class ticketsEvening

    Private Sub ticketsEvening_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtEvnShow.Text = showToSelect
        txtEvnAd.Text = EvnAdult
        txtEvnSeats.Text = EvnSeats
        TxtAdTicketEvn.Text = "0"

        If txtEvnShow.Text = "Ben and Holly" Then
            ptb3.Image = Bitmap.FromFile("..\..\Resources\1.jpg")

        ElseIf txtEvnShow.Text = "Carries War" Then
            ptb3.Image = Bitmap.FromFile("..\..\Resources\2.jpg")

        ElseIf txtEvnShow.Text = "Joseph and the Amazing" Then
            ptb3.Image = Bitmap.FromFile("..\..\Resources\3.jpg")

        ElseIf txtEvnShow.Text = "Stomp" Then
            ptb3.Image = Bitmap.FromFile("..\..\Resources\4.jpg")

        ElseIf txtEvnShow.Text = "The Lion King" Then
            ptb3.Image = Bitmap.FromFile("..\..\Resources\5.jpg")

        ElseIf txtEvnShow.Text = "Phantom of the Opera" Then
            ptb3.Image = Bitmap.FromFile("..\..\Resources\6.jpg")

        ElseIf txtEvnShow.Text = "Les Miserables" Then
            ptb3.Image = Bitmap.FromFile("..\..\Resources\7.jpg")

        ElseIf txtEvnShow.Text = "War-horse" Then
            ptb3.Image = Bitmap.FromFile("..\..\Resources\8.jpg")

        ElseIf txtEvnShow.Text = "Dirty-dancing" Then
            ptb3.Image = Bitmap.FromFile("..\..\Resources\9.jpg")

        ElseIf txtEvnShow.Text = "A little music" Then
            ptb3.Image = Bitmap.FromFile("..\..\Resources\10.jpg")

        ElseIf txtEvnShow.Text = "We will Rock You" Then
            ptb3.Image = Bitmap.FromFile("..\..\Resources\11.jpg")

        Else
            ptb3.Image = Bitmap.FromFile("..\..\Resources\12.jpg") 'image displaying No Image Available
        End If
    End Sub

    Private Sub TxtAdTicketEvn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtAdTicketEvn.KeyPress
        If Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = Chr(8)) Then
            e.Handled = True
        End If
    End Sub

    
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        Form1.Show()
    End Sub

  

    


    Private Sub btnPrice_Click(sender As Object, e As EventArgs) Handles btnPrice.Click
        Dim EveningAdultPrice As Single
        Dim EveningSeat As Integer

        'show variables being converted to data thats calculable.
        AdultTicket = Convert.ToInt16(TxtAdTicketEvn.Text)
        EveningSeat = Convert.ToInt16(txtEvnSeats.Text)
        EveningAdultPrice = Convert.ToSingle(txtEvnAd.Text)

        If (EveningSeat > AdultTicket) Then
            txtEvnSeats.Text = Convert.ToString(EveningSeat - AdultTicket)
            total = FormatCurrency(EveningAdultPrice * AdultTicket)
            btnPrice.Text = total

        Else
            TxtAdTicketEvn.Focus()
            txtEvnSeats.Text = EvnSeats
            TxtAdTicketEvn.Text = "0"
            MsgBox("Not enough seats  ")


        End If


    End Sub

    Private Sub btnBuytick_Click(sender As Object, e As EventArgs) Handles btnBuytick.Click

        Me.Hide()
        paymentform.Show()

    End Sub

End Class