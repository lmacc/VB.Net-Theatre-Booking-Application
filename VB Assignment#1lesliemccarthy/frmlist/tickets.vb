

Public Class tickets

    Private Sub tickets_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtMat.Text = showToSelect
        
        txtCostMatAd.Text = matAdult
        txtCostMatChd.Text = matChild
        txtMatSeat.Text = matSeats
        
        txtAdTicketMat.Text = "0"
        txtChiTicketMat.Text = "0" 'These two cant be left blank, as i must convert them to intergers for calculations later.


        If txtMat.Text = "Ben and Holly" Then
            ptb3.Image = Bitmap.FromFile("..\..\Resources\1.jpg")

        ElseIf txtMat.Text = "Carries War" Then
            ptb3.Image = Bitmap.FromFile("..\..\Resources\2.jpg")

        ElseIf txtMat.Text = "Joseph and the Amazing" Then
            ptb3.Image = Bitmap.FromFile("..\..\Resources\3.jpg")

        ElseIf txtMat.Text = "Stomp" Then
            ptb3.Image = Bitmap.FromFile("..\..\Resources\4.jpg")

        ElseIf txtMat.Text = "The Lion King" Then
            ptb3.Image = Bitmap.FromFile("..\..\Resources\5.jpg")

        ElseIf txtMat.Text = "Phantom of the Opera" Then
            ptb3.Image = Bitmap.FromFile("..\..\Resources\6.jpg")

        ElseIf txtMat.Text = "Les Miserables" Then
            ptb3.Image = Bitmap.FromFile("..\..\Resources\7.jpg")

        ElseIf txtMat.Text = "War-horse" Then
            ptb3.Image = Bitmap.FromFile("..\..\Resources\8.jpg")

        ElseIf txtMat.Text = "Dirty-dancing" Then
            ptb3.Image = Bitmap.FromFile("..\..\Resources\9.jpg")

        ElseIf txtMat.Text = "A little music" Then
            ptb3.Image = Bitmap.FromFile("..\..\Resources\10.jpg")

        ElseIf txtMat.Text = "We will Rock You" Then
            ptb3.Image = Bitmap.FromFile("..\..\Resources\11.jpg")

        Else
            ptb3.Image = Bitmap.FromFile("..\..\Resources\12.jpg")
        End If


    End Sub

    Private Sub txtAdTicket_KeyPress(sender As Object, e As KeyPressEventArgs)


        If Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = Chr(8)) Then
            e.Handled = True

        End If
    End Sub


    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        Form1.Show()

    End Sub

    Private Sub btnPrice_Click(sender As Object, e As EventArgs) Handles btnPrice.Click

        Dim matAdultPrice, matChildPrice As Single
        Dim MatineeSeat As Integer

       

        'Matinee show variables being converted to data thats calculable.
        AdultTicket = Convert.ToInt16(txtAdTicketMat.Text)
        ChildTicket = Convert.ToInt16(txtChiTicketMat.Text)
        matAdultPrice = Convert.ToSingle(txtCostMatAd.Text)
        matChildPrice = Convert.ToSingle(txtCostMatChd.Text)
        MatineeSeat = Convert.ToInt16(txtMatSeat.Text)

        If (MatineeSeat > AdultTicket) Then
            txtMatSeat.Text = Convert.ToString(MatineeSeat - AdultTicket)
            total = FormatCurrency(matAdultPrice * AdultTicket)
            btnPrice.Text = total

        Else
            txtAdTicketMat.Focus()
            txtChiTicketMat.Focus()
            txtAdTicketMat.Text = "0"
            txtChiTicketMat.Text = "0"
            txtMatSeat.Text = Convert.ToString(matSeats)
            MsgBox("Sorry not enough seats" & matSeats)

        End If

        If (MatineeSeat > ChildTicket) Then
            txtMatSeat.Text = Convert.ToString(MatineeSeat - ChildTicket)
            total = FormatCurrency(matChildPrice * ChildTicket)
            btnPrice.Text = total

        Else
            txtAdTicketMat.Focus()
            txtChiTicketMat.Focus()
            txtAdTicketMat.Text = "0"
            txtChiTicketMat.Text = "0"
            txtMatSeat.Text = Convert.ToString(matSeats)
            MsgBox("Sorry not enough seats" & matSeats)

        End If


        If (MatineeSeat > (ChildTicket + AdultTicket)) Then
            txtMatSeat.Text = Convert.ToString(MatineeSeat - (ChildTicket + AdultTicket))
            total = FormatCurrency((matChildPrice * ChildTicket) + (matAdultPrice * AdultTicket))
            btnPrice.Text = total
        Else
            txtAdTicketMat.Focus()
            txtChiTicketMat.Focus()
            txtAdTicketMat.Text = "0"
            txtChiTicketMat.Text = "0"
            txtMatSeat.Text = Convert.ToString(matSeats)
            MsgBox("Sorry not enough seats" & matSeats)

        End If


    End Sub

    
    Private Sub btnBuytick_Click(sender As Object, e As EventArgs) Handles btnBuytick.Click
        Me.Hide()
        paymentform.Show()

    End Sub

   
    
End Class