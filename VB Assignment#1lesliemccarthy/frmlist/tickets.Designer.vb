<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tickets
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMat = New System.Windows.Forms.TextBox()
        Me.txtCostMatChd = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCostMatAd = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMatSeat = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnPrice = New System.Windows.Forms.Button()
        Me.txtChiTicketMat = New System.Windows.Forms.TextBox()
        Me.txtAdTicketMat = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnBuytick = New System.Windows.Forms.Button()
        Me.ptb3 = New System.Windows.Forms.PictureBox()
        CType(Me.ptb3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 16)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Matinee Show"
        '
        'txtMat
        '
        Me.txtMat.Enabled = False
        Me.txtMat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMat.Location = New System.Drawing.Point(153, 44)
        Me.txtMat.Name = "txtMat"
        Me.txtMat.Size = New System.Drawing.Size(137, 21)
        Me.txtMat.TabIndex = 5
        '
        'txtCostMatChd
        '
        Me.txtCostMatChd.Enabled = False
        Me.txtCostMatChd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostMatChd.Location = New System.Drawing.Point(153, 143)
        Me.txtCostMatChd.Name = "txtCostMatChd"
        Me.txtCostMatChd.Size = New System.Drawing.Size(91, 21)
        Me.txtCostMatChd.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 16)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Child Price. €"
        '
        'txtCostMatAd
        '
        Me.txtCostMatAd.Enabled = False
        Me.txtCostMatAd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostMatAd.Location = New System.Drawing.Point(153, 98)
        Me.txtCostMatAd.Name = "txtCostMatAd"
        Me.txtCostMatAd.Size = New System.Drawing.Size(91, 21)
        Me.txtCostMatAd.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(29, 101)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 16)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Adult Price. €"
        '
        'txtMatSeat
        '
        Me.txtMatSeat.Enabled = False
        Me.txtMatSeat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMatSeat.Location = New System.Drawing.Point(153, 190)
        Me.txtMatSeat.Name = "txtMatSeat"
        Me.txtMatSeat.Size = New System.Drawing.Size(51, 21)
        Me.txtMatSeat.TabIndex = 9
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(29, 193)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(118, 16)
        Me.Label13.TabIndex = 33
        Me.Label13.Text = "Seats Available"
        '
        'btnPrice
        '
        Me.btnPrice.Location = New System.Drawing.Point(562, 268)
        Me.btnPrice.Name = "btnPrice"
        Me.btnPrice.Size = New System.Drawing.Size(99, 38)
        Me.btnPrice.TabIndex = 42
        Me.btnPrice.Text = "Click For Price"
        Me.btnPrice.UseVisualStyleBackColor = True
        '
        'txtChiTicketMat
        '
        Me.txtChiTicketMat.Location = New System.Drawing.Point(153, 286)
        Me.txtChiTicketMat.Name = "txtChiTicketMat"
        Me.txtChiTicketMat.Size = New System.Drawing.Size(51, 20)
        Me.txtChiTicketMat.TabIndex = 48
        '
        'txtAdTicketMat
        '
        Me.txtAdTicketMat.Location = New System.Drawing.Point(153, 238)
        Me.txtAdTicketMat.Name = "txtAdTicketMat"
        Me.txtAdTicketMat.Size = New System.Drawing.Size(51, 20)
        Me.txtAdTicketMat.TabIndex = 47
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(29, 286)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 16)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Tickets Child"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(29, 242)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(102, 16)
        Me.Label17.TabIndex = 49
        Me.Label17.Text = "Tickets Adult:"
        '
        'btnBack
        '
        Me.btnBack.BackgroundImage = Global.frmlist.My.Resources.Resources.go_back
        Me.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBack.Location = New System.Drawing.Point(343, 268)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(92, 38)
        Me.btnBack.TabIndex = 41
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnBuytick
        '
        Me.btnBuytick.BackgroundImage = Global.frmlist.My.Resources.Resources.buy
        Me.btnBuytick.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBuytick.Location = New System.Drawing.Point(452, 268)
        Me.btnBuytick.Name = "btnBuytick"
        Me.btnBuytick.Size = New System.Drawing.Size(95, 38)
        Me.btnBuytick.TabIndex = 40
        Me.btnBuytick.UseVisualStyleBackColor = True
        '
        'ptb3
        '
        Me.ptb3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptb3.Location = New System.Drawing.Point(343, 44)
        Me.ptb3.Name = "ptb3"
        Me.ptb3.Size = New System.Drawing.Size(318, 205)
        Me.ptb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptb3.TabIndex = 39
        Me.ptb3.TabStop = False
        '
        'tickets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(709, 399)
        Me.Controls.Add(Me.txtChiTicketMat)
        Me.Controls.Add(Me.txtAdTicketMat)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.btnPrice)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnBuytick)
        Me.Controls.Add(Me.ptb3)
        Me.Controls.Add(Me.txtMatSeat)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtCostMatChd)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCostMatAd)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtMat)
        Me.Controls.Add(Me.Label2)
        Me.Name = "tickets"
        Me.Text = "Tickets "
        CType(Me.ptb3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMat As System.Windows.Forms.TextBox
    Friend WithEvents txtCostMatChd As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCostMatAd As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtMatSeat As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents ptb3 As System.Windows.Forms.PictureBox
    Friend WithEvents btnBuytick As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnPrice As System.Windows.Forms.Button
    Friend WithEvents txtChiTicketMat As System.Windows.Forms.TextBox
    Friend WithEvents txtAdTicketMat As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
End Class
