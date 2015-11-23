<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class s2_frmSupplyDetails
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
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btn2Prev = New System.Windows.Forms.Button()
        Me.chkSupplyFieldCar = New System.Windows.Forms.CheckBox()
        Me.cboSupplyVolumeFieldCar = New System.Windows.Forms.ComboBox()
        Me.cboSupplyPointsLayerCar = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.chkSupplyFieldBus = New System.Windows.Forms.CheckBox()
        Me.cboSupplyVolumeFieldBus = New System.Windows.Forms.ComboBox()
        Me.cboSupplyPointsLayerBus = New System.Windows.Forms.ComboBox()
        Me.btn2Next = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(8, 150)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(385, 48)
        Me.TextBox2.TabIndex = 6
        Me.TextBox2.Text = "Attribute field for Travel Mode #1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "holding the supply point volume :"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(8, 46)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(385, 48)
        Me.TextBox1.TabIndex = 5
        Me.TextBox1.TabStop = False
        Me.TextBox1.Text = "Layer containing the supply locations" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "for the Travel Mode #1 network :"
        '
        'btn2Prev
        '
        Me.btn2Prev.Image = Global.mm_fca.My.Resources.Resources.prevB
        Me.btn2Prev.Location = New System.Drawing.Point(9, 585)
        Me.btn2Prev.Margin = New System.Windows.Forms.Padding(4)
        Me.btn2Prev.Name = "btn2Prev"
        Me.btn2Prev.Size = New System.Drawing.Size(69, 64)
        Me.btn2Prev.TabIndex = 14
        Me.btn2Prev.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn2Prev.UseVisualStyleBackColor = True
        '
        'chkSupplyFieldCar
        '
        Me.chkSupplyFieldCar.AutoSize = True
        Me.chkSupplyFieldCar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSupplyFieldCar.Location = New System.Drawing.Point(433, 98)
        Me.chkSupplyFieldCar.Margin = New System.Windows.Forms.Padding(4)
        Me.chkSupplyFieldCar.Name = "chkSupplyFieldCar"
        Me.chkSupplyFieldCar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkSupplyFieldCar.Size = New System.Drawing.Size(434, 44)
        Me.chkSupplyFieldCar.TabIndex = 29
        Me.chkSupplyFieldCar.Text = "check to set a field in this layer as the supply capacity" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " (if unselected, a def" & _
    "ault supply value of 1 is utilised)"
        Me.chkSupplyFieldCar.UseVisualStyleBackColor = True
        '
        'cboSupplyVolumeFieldCar
        '
        Me.cboSupplyVolumeFieldCar.Enabled = False
        Me.cboSupplyVolumeFieldCar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSupplyVolumeFieldCar.FormattingEnabled = True
        Me.cboSupplyVolumeFieldCar.Location = New System.Drawing.Point(433, 150)
        Me.cboSupplyVolumeFieldCar.Margin = New System.Windows.Forms.Padding(4)
        Me.cboSupplyVolumeFieldCar.Name = "cboSupplyVolumeFieldCar"
        Me.cboSupplyVolumeFieldCar.Size = New System.Drawing.Size(292, 33)
        Me.cboSupplyVolumeFieldCar.TabIndex = 26
        '
        'cboSupplyPointsLayerCar
        '
        Me.cboSupplyPointsLayerCar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSupplyPointsLayerCar.FormattingEnabled = True
        Me.cboSupplyPointsLayerCar.Location = New System.Drawing.Point(433, 46)
        Me.cboSupplyPointsLayerCar.Margin = New System.Windows.Forms.Padding(4)
        Me.cboSupplyPointsLayerCar.Name = "cboSupplyPointsLayerCar"
        Me.cboSupplyPointsLayerCar.Size = New System.Drawing.Size(585, 33)
        Me.cboSupplyPointsLayerCar.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox4)
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Controls.Add(Me.chkSupplyFieldBus)
        Me.GroupBox2.Controls.Add(Me.cboSupplyVolumeFieldBus)
        Me.GroupBox2.Controls.Add(Me.cboSupplyPointsLayerBus)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.chkSupplyFieldCar)
        Me.GroupBox2.Controls.Add(Me.cboSupplyVolumeFieldCar)
        Me.GroupBox2.Controls.Add(Me.cboSupplyPointsLayerCar)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(9, 33)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(1088, 523)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "service SUPPLY details:"
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(8, 407)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(385, 48)
        Me.TextBox4.TabIndex = 33
        Me.TextBox4.Text = "Attribute field for Travel Mode #2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "holding the supply point volume :"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(7, 305)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(385, 48)
        Me.TextBox3.TabIndex = 32
        Me.TextBox3.TabStop = False
        Me.TextBox3.Text = "Layer containing the supply locations" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "for the Travel Mode #2 network :"
        '
        'chkSupplyFieldBus
        '
        Me.chkSupplyFieldBus.AutoSize = True
        Me.chkSupplyFieldBus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSupplyFieldBus.Location = New System.Drawing.Point(433, 356)
        Me.chkSupplyFieldBus.Margin = New System.Windows.Forms.Padding(4)
        Me.chkSupplyFieldBus.Name = "chkSupplyFieldBus"
        Me.chkSupplyFieldBus.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkSupplyFieldBus.Size = New System.Drawing.Size(434, 44)
        Me.chkSupplyFieldBus.TabIndex = 35
        Me.chkSupplyFieldBus.Text = "check to set a field in this layer as the supply capacity" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " (if unselected, a def" & _
    "ault supply value of 1 is utilised)"
        Me.chkSupplyFieldBus.UseVisualStyleBackColor = True
        '
        'cboSupplyVolumeFieldBus
        '
        Me.cboSupplyVolumeFieldBus.Enabled = False
        Me.cboSupplyVolumeFieldBus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSupplyVolumeFieldBus.FormattingEnabled = True
        Me.cboSupplyVolumeFieldBus.Location = New System.Drawing.Point(433, 407)
        Me.cboSupplyVolumeFieldBus.Margin = New System.Windows.Forms.Padding(4)
        Me.cboSupplyVolumeFieldBus.Name = "cboSupplyVolumeFieldBus"
        Me.cboSupplyVolumeFieldBus.Size = New System.Drawing.Size(292, 33)
        Me.cboSupplyVolumeFieldBus.TabIndex = 34
        '
        'cboSupplyPointsLayerBus
        '
        Me.cboSupplyPointsLayerBus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSupplyPointsLayerBus.FormattingEnabled = True
        Me.cboSupplyPointsLayerBus.Location = New System.Drawing.Point(433, 305)
        Me.cboSupplyPointsLayerBus.Margin = New System.Windows.Forms.Padding(4)
        Me.cboSupplyPointsLayerBus.Name = "cboSupplyPointsLayerBus"
        Me.cboSupplyPointsLayerBus.Size = New System.Drawing.Size(585, 33)
        Me.cboSupplyPointsLayerBus.TabIndex = 31
        '
        'btn2Next
        '
        Me.btn2Next.Image = Global.mm_fca.My.Resources.Resources.nextB
        Me.btn2Next.Location = New System.Drawing.Point(1028, 585)
        Me.btn2Next.Margin = New System.Windows.Forms.Padding(4)
        Me.btn2Next.Name = "btn2Next"
        Me.btn2Next.Size = New System.Drawing.Size(69, 64)
        Me.btn2Next.TabIndex = 13
        Me.btn2Next.UseVisualStyleBackColor = True
        '
        's2_frmSupplyDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1104, 662)
        Me.Controls.Add(Me.btn2Prev)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btn2Next)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "s2_frmSupplyDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Supply Details"
        Me.TopMost = True
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btn2Prev As System.Windows.Forms.Button
    Friend WithEvents chkSupplyFieldCar As System.Windows.Forms.CheckBox
    Friend WithEvents cboSupplyVolumeFieldCar As System.Windows.Forms.ComboBox
    Friend WithEvents cboSupplyPointsLayerCar As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn2Next As System.Windows.Forms.Button
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents chkSupplyFieldBus As System.Windows.Forms.CheckBox
    Friend WithEvents cboSupplyVolumeFieldBus As System.Windows.Forms.ComboBox
    Friend WithEvents cboSupplyPointsLayerBus As System.Windows.Forms.ComboBox
End Class
