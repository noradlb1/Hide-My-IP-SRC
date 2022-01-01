<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChooseIPCountryForm
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
        Me.FormSkin1 = New Hide_My_IP_By_Adel_Rehan.FormSkin()
        Me.btnDone = New Hide_My_IP_By_Adel_Rehan.FlatButton()
        Me.cmbCountry = New Hide_My_IP_By_Adel_Rehan.FlatComboBox()
        Me.lblInfo2 = New Hide_My_IP_By_Adel_Rehan.FlatLabel()
        Me.FlatClose1 = New Hide_My_IP_By_Adel_Rehan.FlatClose()
        Me.FormSkin1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.btnDone)
        Me.FormSkin1.Controls.Add(Me.cmbCountry)
        Me.FormSkin1.Controls.Add(Me.lblInfo2)
        Me.FormSkin1.Controls.Add(Me.FlatClose1)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(408, 135)
        Me.FormSkin1.TabIndex = 1
        Me.FormSkin1.Text = "Hide My IP By Adel Rehan"
        '
        'btnDone
        '
        Me.btnDone.BackColor = System.Drawing.Color.Transparent
        Me.btnDone.BaseColor = System.Drawing.Color.Green
        Me.btnDone.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDone.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnDone.Location = New System.Drawing.Point(51, 91)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Rounded = False
        Me.btnDone.Size = New System.Drawing.Size(101, 32)
        Me.btnDone.TabIndex = 24
        Me.btnDone.Text = "Done"
        Me.btnDone.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'cmbCountry
        '
        Me.cmbCountry.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.cmbCountry.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbCountry.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCountry.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.cmbCountry.ForeColor = System.Drawing.Color.White
        Me.cmbCountry.FormattingEnabled = True
        Me.cmbCountry.HoverColor = System.Drawing.Color.Green
        Me.cmbCountry.ItemHeight = 18
        Me.cmbCountry.Items.AddRange(New Object() {"Albania", "Argentina", "Armenia", "Australia", "Brazil", "Canada", "China", "Egypt", "Europe", "France", "Germany", "Greece", "India", "Indonesia", "Iran", "Iraq", "Italy", "Japan", "Mexico", "Netherlands", "Nigeria", "Oman", "Paraguay", "Philippines", "Russia", "Saudi Arabia", "South Africa", "Spain", "Sweden", "Switzerland", "Turkey", "United Arab Emirates", "United Kingdom", "United States", "Viet Nam"})
        Me.cmbCountry.Location = New System.Drawing.Point(77, 59)
        Me.cmbCountry.Name = "cmbCountry"
        Me.cmbCountry.Size = New System.Drawing.Size(319, 24)
        Me.cmbCountry.TabIndex = 23
        '
        'lblInfo2
        '
        Me.lblInfo2.AutoSize = True
        Me.lblInfo2.BackColor = System.Drawing.Color.Transparent
        Me.lblInfo2.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblInfo2.ForeColor = System.Drawing.Color.White
        Me.lblInfo2.Location = New System.Drawing.Point(12, 64)
        Me.lblInfo2.Name = "lblInfo2"
        Me.lblInfo2.Size = New System.Drawing.Size(54, 13)
        Me.lblInfo2.TabIndex = 22
        Me.lblInfo2.Text = "Country :"
        '
        'FlatClose1
        '
        Me.FlatClose1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatClose1.BackColor = System.Drawing.Color.White
        Me.FlatClose1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.FlatClose1.Font = New System.Drawing.Font("Marlett", 12.0!)
        Me.FlatClose1.Location = New System.Drawing.Point(378, 12)
        Me.FlatClose1.Name = "FlatClose1"
        Me.FlatClose1.Size = New System.Drawing.Size(18, 18)
        Me.FlatClose1.TabIndex = 8
        Me.FlatClose1.Text = "FlatClose1"
        Me.FlatClose1.TextColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        '
        'ChooseIPCountryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(408, 135)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ChooseIPCountryForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ChooseIPCountryForm"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FormSkin1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FormSkin1 As Hide_My_IP_By_Adel_Rehan.FormSkin
    Friend WithEvents FlatClose1 As Hide_My_IP_By_Adel_Rehan.FlatClose
    Friend WithEvents cmbCountry As Hide_My_IP_By_Adel_Rehan.FlatComboBox
    Friend WithEvents lblInfo2 As Hide_My_IP_By_Adel_Rehan.FlatLabel
    Friend WithEvents btnDone As Hide_My_IP_By_Adel_Rehan.FlatButton
End Class
