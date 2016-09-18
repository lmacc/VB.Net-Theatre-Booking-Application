<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
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
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnChangeUser = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.rtxtbox = New System.Windows.Forms.RichTextBox()
        Me.txtSeatEvn = New System.Windows.Forms.TextBox()
        Me.txtPriAdultEvn = New System.Windows.Forms.TextBox()
        Me.dtpEvnFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpEvnStart = New System.Windows.Forms.DateTimePicker()
        Me.dtpEvn = New System.Windows.Forms.DateTimePicker()
        Me.cmbEvn = New System.Windows.Forms.ComboBox()
        Me.txtPriceChildEv = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtSeatMat = New System.Windows.Forms.TextBox()
        Me.txtPriAdultMat = New System.Windows.Forms.TextBox()
        Me.dtpMatFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpMatStart = New System.Windows.Forms.DateTimePicker()
        Me.dtpMat = New System.Windows.Forms.DateTimePicker()
        Me.cmbMat = New System.Windows.Forms.ComboBox()
        Me.txtPriChildMat = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.ptb1 = New System.Windows.Forms.PictureBox()
        CType(Me.ptb1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(277, 498)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 95
        Me.btnClear.Text = "Clear items"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnChangeUser
        '
        Me.btnChangeUser.Location = New System.Drawing.Point(196, 498)
        Me.btnChangeUser.Name = "btnChangeUser"
        Me.btnChangeUser.Size = New System.Drawing.Size(75, 23)
        Me.btnChangeUser.TabIndex = 94
        Me.btnChangeUser.Text = "Change user"
        Me.btnChangeUser.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(115, 498)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 93
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(34, 498)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 92
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'rtxtbox
        '
        Me.rtxtbox.Location = New System.Drawing.Point(34, 348)
        Me.rtxtbox.Name = "rtxtbox"
        Me.rtxtbox.Size = New System.Drawing.Size(770, 96)
        Me.rtxtbox.TabIndex = 91
        Me.rtxtbox.Text = ""
        '
        'txtSeatEvn
        '
        Me.txtSeatEvn.Location = New System.Drawing.Point(371, 312)
        Me.txtSeatEvn.Name = "txtSeatEvn"
        Me.txtSeatEvn.Size = New System.Drawing.Size(100, 20)
        Me.txtSeatEvn.TabIndex = 90
        '
        'txtPriAdultEvn
        '
        Me.txtPriAdultEvn.Location = New System.Drawing.Point(371, 265)
        Me.txtPriAdultEvn.Name = "txtPriAdultEvn"
        Me.txtPriAdultEvn.Size = New System.Drawing.Size(100, 20)
        Me.txtPriAdultEvn.TabIndex = 89
        '
        'dtpEvnFin
        '
        Me.dtpEvnFin.CustomFormat = "HH:mm"
        Me.dtpEvnFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEvnFin.Location = New System.Drawing.Point(371, 171)
        Me.dtpEvnFin.Name = "dtpEvnFin"
        Me.dtpEvnFin.ShowUpDown = True
        Me.dtpEvnFin.Size = New System.Drawing.Size(60, 20)
        Me.dtpEvnFin.TabIndex = 88
        Me.dtpEvnFin.Value = New Date(2016, 1, 7, 20, 0, 0, 0)
        '
        'dtpEvnStart
        '
        Me.dtpEvnStart.CustomFormat = "HH:mm"
        Me.dtpEvnStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEvnStart.Location = New System.Drawing.Point(371, 126)
        Me.dtpEvnStart.Name = "dtpEvnStart"
        Me.dtpEvnStart.ShowUpDown = True
        Me.dtpEvnStart.Size = New System.Drawing.Size(60, 20)
        Me.dtpEvnStart.TabIndex = 87
        Me.dtpEvnStart.Value = New Date(2014, 12, 28, 17, 0, 0, 0)
        '
        'dtpEvn
        '
        Me.dtpEvn.Location = New System.Drawing.Point(371, 79)
        Me.dtpEvn.MaxDate = New Date(2016, 5, 4, 0, 0, 0, 0)
        Me.dtpEvn.MinDate = New Date(2015, 1, 13, 0, 0, 0, 0)
        Me.dtpEvn.Name = "dtpEvn"
        Me.dtpEvn.Size = New System.Drawing.Size(139, 20)
        Me.dtpEvn.TabIndex = 86
        Me.dtpEvn.Value = New Date(2015, 12, 31, 0, 0, 0, 0)
        '
        'cmbEvn
        '
        Me.cmbEvn.FormattingEnabled = True
        Me.cmbEvn.Location = New System.Drawing.Point(371, 33)
        Me.cmbEvn.Name = "cmbEvn"
        Me.cmbEvn.Size = New System.Drawing.Size(121, 21)
        Me.cmbEvn.TabIndex = 85
        '
        'txtPriceChildEv
        '
        Me.txtPriceChildEv.Location = New System.Drawing.Point(371, 218)
        Me.txtPriceChildEv.Name = "txtPriceChildEv"
        Me.txtPriceChildEv.Size = New System.Drawing.Size(100, 20)
        Me.txtPriceChildEv.TabIndex = 84
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(292, 314)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 18)
        Me.Label15.TabIndex = 83
        Me.Label15.Text = "Seats"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(292, 267)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(40, 18)
        Me.Label16.TabIndex = 82
        Me.Label16.Text = "Adult"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(292, 220)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(41, 18)
        Me.Label17.TabIndex = 81
        Me.Label17.Text = "Child"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(292, 173)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(47, 18)
        Me.Label18.TabIndex = 80
        Me.Label18.Text = "Finish"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(292, 126)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(39, 18)
        Me.Label19.TabIndex = 79
        Me.Label19.Text = "Start"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(292, 79)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(39, 18)
        Me.Label20.TabIndex = 78
        Me.Label20.Text = "Date"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(292, 32)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(60, 18)
        Me.Label21.TabIndex = 77
        Me.Label21.Text = "Evening"
        '
        'txtSeatMat
        '
        Me.txtSeatMat.Location = New System.Drawing.Point(110, 312)
        Me.txtSeatMat.Name = "txtSeatMat"
        Me.txtSeatMat.Size = New System.Drawing.Size(100, 20)
        Me.txtSeatMat.TabIndex = 76
        '
        'txtPriAdultMat
        '
        Me.txtPriAdultMat.Location = New System.Drawing.Point(110, 265)
        Me.txtPriAdultMat.Name = "txtPriAdultMat"
        Me.txtPriAdultMat.Size = New System.Drawing.Size(100, 20)
        Me.txtPriAdultMat.TabIndex = 75
        '
        'dtpMatFin
        '
        Me.dtpMatFin.CustomFormat = "HH:mm"
        Me.dtpMatFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpMatFin.Location = New System.Drawing.Point(110, 171)
        Me.dtpMatFin.Name = "dtpMatFin"
        Me.dtpMatFin.ShowUpDown = True
        Me.dtpMatFin.Size = New System.Drawing.Size(60, 20)
        Me.dtpMatFin.TabIndex = 74
        Me.dtpMatFin.Value = New Date(2016, 1, 7, 13, 0, 0, 0)
        '
        'dtpMatStart
        '
        Me.dtpMatStart.CustomFormat = "HH:mm"
        Me.dtpMatStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpMatStart.Location = New System.Drawing.Point(110, 126)
        Me.dtpMatStart.Name = "dtpMatStart"
        Me.dtpMatStart.ShowUpDown = True
        Me.dtpMatStart.Size = New System.Drawing.Size(60, 20)
        Me.dtpMatStart.TabIndex = 73
        Me.dtpMatStart.Value = New Date(2014, 12, 28, 11, 0, 0, 0)
        '
        'dtpMat
        '
        Me.dtpMat.Location = New System.Drawing.Point(110, 79)
        Me.dtpMat.MaxDate = New Date(2016, 2, 10, 0, 0, 0, 0)
        Me.dtpMat.MinDate = New Date(2015, 1, 13, 0, 0, 0, 0)
        Me.dtpMat.Name = "dtpMat"
        Me.dtpMat.Size = New System.Drawing.Size(139, 20)
        Me.dtpMat.TabIndex = 72
        Me.dtpMat.Value = New Date(2015, 12, 31, 0, 0, 0, 0)
        '
        'cmbMat
        '
        Me.cmbMat.FormattingEnabled = True
        Me.cmbMat.Location = New System.Drawing.Point(110, 33)
        Me.cmbMat.Name = "cmbMat"
        Me.cmbMat.Size = New System.Drawing.Size(121, 21)
        Me.cmbMat.TabIndex = 71
        '
        'txtPriChildMat
        '
        Me.txtPriChildMat.Location = New System.Drawing.Point(110, 218)
        Me.txtPriChildMat.Name = "txtPriChildMat"
        Me.txtPriChildMat.Size = New System.Drawing.Size(100, 20)
        Me.txtPriChildMat.TabIndex = 70
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(31, 314)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 18)
        Me.Label8.TabIndex = 69
        Me.Label8.Text = "Seats"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(31, 267)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 18)
        Me.Label9.TabIndex = 68
        Me.Label9.Text = "Adult"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(31, 220)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 18)
        Me.Label10.TabIndex = 67
        Me.Label10.Text = "Child"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(31, 173)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 18)
        Me.Label11.TabIndex = 66
        Me.Label11.Text = "Finish"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(31, 126)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(39, 18)
        Me.Label12.TabIndex = 65
        Me.Label12.Text = "Start"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(31, 79)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(39, 18)
        Me.Label13.TabIndex = 64
        Me.Label13.Text = "Date"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(31, 32)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(60, 18)
        Me.Label14.TabIndex = 63
        Me.Label14.Text = "Matinee"
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(368, 498)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(89, 23)
        Me.btnRemove.TabIndex = 96
        Me.btnRemove.Text = "Remove show"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'ptb1
        '
        Me.ptb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptb1.Location = New System.Drawing.Point(516, 32)
        Me.ptb1.Name = "ptb1"
        Me.ptb1.Size = New System.Drawing.Size(288, 299)
        Me.ptb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptb1.TabIndex = 97
        Me.ptb1.TabStop = False
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(828, 612)
        Me.Controls.Add(Me.ptb1)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnChangeUser)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.rtxtbox)
        Me.Controls.Add(Me.txtSeatEvn)
        Me.Controls.Add(Me.txtPriAdultEvn)
        Me.Controls.Add(Me.dtpEvnFin)
        Me.Controls.Add(Me.dtpEvnStart)
        Me.Controls.Add(Me.dtpEvn)
        Me.Controls.Add(Me.cmbEvn)
        Me.Controls.Add(Me.txtPriceChildEv)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.txtSeatMat)
        Me.Controls.Add(Me.txtPriAdultMat)
        Me.Controls.Add(Me.dtpMatFin)
        Me.Controls.Add(Me.dtpMatStart)
        Me.Controls.Add(Me.dtpMat)
        Me.Controls.Add(Me.cmbMat)
        Me.Controls.Add(Me.txtPriChildMat)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Name = "Admin"
        Me.Text = "Admin"
        CType(Me.ptb1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnChangeUser As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents rtxtbox As System.Windows.Forms.RichTextBox
    Friend WithEvents txtSeatEvn As System.Windows.Forms.TextBox
    Friend WithEvents txtPriAdultEvn As System.Windows.Forms.TextBox
    Friend WithEvents dtpEvnFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpEvnStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpEvn As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbEvn As System.Windows.Forms.ComboBox
    Friend WithEvents txtPriceChildEv As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtSeatMat As System.Windows.Forms.TextBox
    Friend WithEvents txtPriAdultMat As System.Windows.Forms.TextBox
    Friend WithEvents dtpMatFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpMatStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpMat As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbMat As System.Windows.Forms.ComboBox
    Friend WithEvents txtPriChildMat As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents ptb1 As System.Windows.Forms.PictureBox
End Class
