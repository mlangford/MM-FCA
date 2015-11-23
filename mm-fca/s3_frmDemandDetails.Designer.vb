<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class s3_frmDemandDetails
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
        Me.cboDemandFieldBus = New System.Windows.Forms.ComboBox()
        Me.btn3_Prev = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cboDemandIDField = New System.Windows.Forms.ComboBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.cboDemandPointsLayerBus = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.cboDemandFieldCar = New System.Windows.Forms.ComboBox()
        Me.cboDemandPointsLayerCar = New System.Windows.Forms.ComboBox()
        Me.btn3Next = New System.Windows.Forms.Button()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboDemandFieldBus
        '
        Me.cboDemandFieldBus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDemandFieldBus.FormattingEnabled = True
        Me.cboDemandFieldBus.Location = New System.Drawing.Point(433, 321)
        Me.cboDemandFieldBus.Margin = New System.Windows.Forms.Padding(4)
        Me.cboDemandFieldBus.Name = "cboDemandFieldBus"
        Me.cboDemandFieldBus.Size = New System.Drawing.Size(292, 33)
        Me.cboDemandFieldBus.TabIndex = 34
        '
        'btn3_Prev
        '
        Me.btn3_Prev.Image = Global.mm_fca.My.Resources.Resources.prevB
        Me.btn3_Prev.Location = New System.Drawing.Point(9, 585)
        Me.btn3_Prev.Margin = New System.Windows.Forms.Padding(4)
        Me.btn3_Prev.Name = "btn3_Prev"
        Me.btn3_Prev.Size = New System.Drawing.Size(69, 64)
        Me.btn3_Prev.TabIndex = 36
        Me.btn3_Prev.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn3_Prev.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(8, 322)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(385, 51)
        Me.TextBox4.TabIndex = 33
        Me.TextBox4.Text = "Attribute field for Travel Mode #2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "holding the demand point volume :"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(8, 122)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(385, 51)
        Me.TextBox2.TabIndex = 32
        Me.TextBox2.Text = "Attribute field for Travel Mode #1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "holding the demand point volume :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cboDemandIDField)
        Me.GroupBox3.Controls.Add(Me.TextBox5)
        Me.GroupBox3.Controls.Add(Me.TextBox3)
        Me.GroupBox3.Controls.Add(Me.cboDemandPointsLayerBus)
        Me.GroupBox3.Controls.Add(Me.TextBox4)
        Me.GroupBox3.Controls.Add(Me.cboDemandFieldBus)
        Me.GroupBox3.Controls.Add(Me.TextBox2)
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Controls.Add(Me.cboDemandFieldCar)
        Me.GroupBox3.Controls.Add(Me.cboDemandPointsLayerCar)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(9, 33)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(1088, 523)
        Me.GroupBox3.TabIndex = 35
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "service DEMAND details:"
        '
        'cboDemandIDField
        '
        Me.cboDemandIDField.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDemandIDField.FormattingEnabled = True
        Me.cboDemandIDField.Location = New System.Drawing.Point(433, 444)
        Me.cboDemandIDField.Margin = New System.Windows.Forms.Padding(4)
        Me.cboDemandIDField.Name = "cboDemandIDField"
        Me.cboDemandIDField.Size = New System.Drawing.Size(292, 33)
        Me.cboDemandIDField.TabIndex = 38
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(8, 444)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(385, 51)
        Me.TextBox5.TabIndex = 37
        Me.TextBox5.Text = "Select a Demand Points layer field that is to be" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "copied across to the results ta" & _
    "ble for data linking"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(8, 247)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(385, 48)
        Me.TextBox3.TabIndex = 36
        Me.TextBox3.Text = "Select layer containing the demand locations" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "for the Travel Mode 2 network :"
        '
        'cboDemandPointsLayerBus
        '
        Me.cboDemandPointsLayerBus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDemandPointsLayerBus.FormattingEnabled = True
        Me.cboDemandPointsLayerBus.Location = New System.Drawing.Point(433, 247)
        Me.cboDemandPointsLayerBus.Margin = New System.Windows.Forms.Padding(4)
        Me.cboDemandPointsLayerBus.Name = "cboDemandPointsLayerBus"
        Me.cboDemandPointsLayerBus.Size = New System.Drawing.Size(585, 33)
        Me.cboDemandPointsLayerBus.TabIndex = 35
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
        Me.TextBox1.Text = "Layer containing the demand locations" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "for the Travel Mode #1 network :"
        '
        'cboDemandFieldCar
        '
        Me.cboDemandFieldCar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDemandFieldCar.FormattingEnabled = True
        Me.cboDemandFieldCar.Location = New System.Drawing.Point(433, 122)
        Me.cboDemandFieldCar.Margin = New System.Windows.Forms.Padding(4)
        Me.cboDemandFieldCar.Name = "cboDemandFieldCar"
        Me.cboDemandFieldCar.Size = New System.Drawing.Size(292, 33)
        Me.cboDemandFieldCar.TabIndex = 26
        '
        'cboDemandPointsLayerCar
        '
        Me.cboDemandPointsLayerCar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDemandPointsLayerCar.FormattingEnabled = True
        Me.cboDemandPointsLayerCar.Location = New System.Drawing.Point(433, 46)
        Me.cboDemandPointsLayerCar.Margin = New System.Windows.Forms.Padding(4)
        Me.cboDemandPointsLayerCar.Name = "cboDemandPointsLayerCar"
        Me.cboDemandPointsLayerCar.Size = New System.Drawing.Size(585, 33)
        Me.cboDemandPointsLayerCar.TabIndex = 0
        '
        'btn3Next
        '
        Me.btn3Next.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn3Next.Image = Global.mm_fca.My.Resources.Resources.nextB
        Me.btn3Next.Location = New System.Drawing.Point(1028, 585)
        Me.btn3Next.Margin = New System.Windows.Forms.Padding(4)
        Me.btn3Next.Name = "btn3Next"
        Me.btn3Next.Size = New System.Drawing.Size(69, 64)
        Me.btn3Next.TabIndex = 37
        Me.btn3Next.UseVisualStyleBackColor = True
        '
        's3_frmDemandDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1104, 662)
        Me.Controls.Add(Me.btn3_Prev)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btn3Next)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "s3_frmDemandDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Demand Details"
        Me.TopMost = True
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cboDemandFieldBus As System.Windows.Forms.ComboBox
    Friend WithEvents btn3_Prev As System.Windows.Forms.Button
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents cboDemandFieldCar As System.Windows.Forms.ComboBox
    Friend WithEvents cboDemandPointsLayerCar As System.Windows.Forms.ComboBox
    Friend WithEvents btn3Next As System.Windows.Forms.Button
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents cboDemandPointsLayerBus As System.Windows.Forms.ComboBox
    Friend WithEvents cboDemandIDField As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
End Class
