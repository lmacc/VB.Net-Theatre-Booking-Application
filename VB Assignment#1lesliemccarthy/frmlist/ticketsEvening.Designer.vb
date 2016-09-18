<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ticketsEvening
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TxtAdTicketEvn = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtEvnSeats = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtEvnAd = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtEvnShow = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnPrice = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnBuytick = New System.Windows.Forms.Button()
        Me.ptb3 = New System.Windows.Forms.PictureBox()
        CType(Me.ptb3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtAdTicketEvn
        '
        Me.TxtAdTicketEvn.Location = New System.Drawing.Point(156, 224)
        Me.TxtAdTicketEvn.Name = "TxtAdTicketEvn"
        Me.TxtAdTicketEvn.Size = New System.Drawing.Size(51, 20)
        Me.TxtAdTicketEvn.TabIndex = 1
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(30, 228)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(102, 16)
        Me.Label19.TabIndex = 64
        Me.Label19.Text = "Tickets Adult:"
        '
        'txtEvnSeats
        '
        Me.txtEvnSeats.Enabled = False
        Me.txtEvnSeats.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEvnSeats.Location = New System.Drawing.Point(156, 161)
        Me.txtEvnSeats.Name = "txtEvnSeats"
        Me.txtEvnSeats.Size = New System.Drawing.Size(51, 21)
        Me.txtEvnSeats.TabIndex = 56
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(30, 166)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(118, 16)
        Me.Label15.TabIndex = 60
        Me.Label15.Text = "Seats Available"
        '
        'txtEvnAd
        '
        Me.txtEvnAd.Enabled = False
        Me.txtEvnAd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEvnAd.Location = New System.Drawing.Point(156, 95)
        Me.txtEvnAd.Name = "txtEvnAd"
        Me.txtEvnAd.Size = New System.Drawing.Size(51, 21)
        Me.txtEvnAd.TabIndex = 55
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(30, 100)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 16)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = "Adult Price. €"
        '
        'txtEvnShow
        '
        Me.txtEvnShow.Enabled = False
        Me.txtEvnShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEvnShow.Location = New System.Drawing.Point(156, 39)
        Me.txtEvnShow.Name = "txtEvnShow"
        Me.txtEvnShow.Size = New System.Drawing.Size(137, 21)
        Me.txtEvnShow.TabIndex = 54
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(30, 44)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 16)
        Me.Label9.TabIndex = 57
        Me.Label9.Text = "Evening Show"
        '
        'btnPrice
        '
        Me.btnPrice.Location = New System.Drawing.Point(552, 263)
        Me.btnPrice.Name = "btnPrice"
        Me.btnPrice.Size = New System.Drawing.Size(99, 38)
        Me.btnPrice.TabIndex = 68
        Me.btnPrice.Text = "Click For Price"
        Me.btnPrice.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.BackgroundImage = Global.frmlist.My.Resources.Resources.go_back
        Me.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBack.Location = New System.Drawing.Point(333, 263)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(92, 38)
        Me.btnBack.TabIndex = 67
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnBuytick
        '
        Me.btnBuytick.BackgroundImage = Global.frmlist.My.Resources.Resources.buy
        Me.btnBuytick.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBuytick.Location = New System.Drawing.Point(440, 263)
        Me.btnBuytick.Name = "btnBuytick"
        Me.btnBuytick.Size = New System.Drawing.Size(95, 38)
        Me.btnBuytick.TabIndex = 66
        Me.btnBuytick.UseVisualStyleBackColor = True
        '
        'ptb3
        '
        Me.ptb3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptb3.Location = New System.Drawing.Point(333, 39)
        Me.ptb3.Name = "ptb3"
        Me.ptb3.Size = New System.Drawing.Size(318, 205)
        Me.ptb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptb3.TabIndex = 65
        Me.ptb3.TabStop = False
        '
        'ticketsEvening
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(703, 373)
        Me.Controls.Add(Me.btnPrice)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnBuytick)
        Me.Controls.Add(Me.ptb3)
        Me.Controls.Add(Me.TxtAdTicketEvn)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtEvnSeats)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtEvnAd)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtEvnShow)
        Me.Controls.Add(Me.Label9)
        Me.Name = "ticketsEvening"
        Me.Text = "ticketsEvening"
        CType(Me.ptb3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtAdTicketEvn As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtEvnSeats As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtEvnAd As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtEvnShow As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnPrice As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnBuytick As System.Windows.Forms.Button
    Friend WithEvents ptb3 As System.Windows.Forms.PictureBox
End Class
