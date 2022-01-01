<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.FormSkin1 = New Hide_My_IP_By_Adel_Rehan.FormSkin()
        Me.lblRealIP = New Hide_My_IP_By_Adel_Rehan.FlatLabel()
        Me.lblInfo2 = New Hide_My_IP_By_Adel_Rehan.FlatLabel()
        Me.pcbFakeCountry = New System.Windows.Forms.PictureBox()
        Me.lblFakeIP = New Hide_My_IP_By_Adel_Rehan.FlatLabel()
        Me.FlatLabel3 = New Hide_My_IP_By_Adel_Rehan.FlatLabel()
        Me.lblFakeLocation = New Hide_My_IP_By_Adel_Rehan.FlatLabel()
        Me.FlatLabel1 = New Hide_My_IP_By_Adel_Rehan.FlatLabel()
        Me.btnChooseIPCountry = New Hide_My_IP_By_Adel_Rehan.FlatButton()
        Me.btnHideIP = New Hide_My_IP_By_Adel_Rehan.FlatButton()
        Me.lblCheckIPInfo = New Hide_My_IP_By_Adel_Rehan.FlatLabel()
        Me.lblInfo = New Hide_My_IP_By_Adel_Rehan.FlatLabel()
        Me.pcbRealCountry = New System.Windows.Forms.PictureBox()
        Me.FlatLabel2 = New Hide_My_IP_By_Adel_Rehan.FlatLabel()
        Me.FlatClose1 = New Hide_My_IP_By_Adel_Rehan.FlatClose()
        Me.FlatMini1 = New Hide_My_IP_By_Adel_Rehan.FlatMini()
        Me.FormSkin1.SuspendLayout()
        CType(Me.pcbFakeCountry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbRealCountry, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.lblRealIP)
        Me.FormSkin1.Controls.Add(Me.lblInfo2)
        Me.FormSkin1.Controls.Add(Me.pcbFakeCountry)
        Me.FormSkin1.Controls.Add(Me.lblFakeIP)
        Me.FormSkin1.Controls.Add(Me.FlatLabel3)
        Me.FormSkin1.Controls.Add(Me.lblFakeLocation)
        Me.FormSkin1.Controls.Add(Me.FlatLabel1)
        Me.FormSkin1.Controls.Add(Me.btnChooseIPCountry)
        Me.FormSkin1.Controls.Add(Me.btnHideIP)
        Me.FormSkin1.Controls.Add(Me.lblCheckIPInfo)
        Me.FormSkin1.Controls.Add(Me.lblInfo)
        Me.FormSkin1.Controls.Add(Me.pcbRealCountry)
        Me.FormSkin1.Controls.Add(Me.FlatLabel2)
        Me.FormSkin1.Controls.Add(Me.FlatClose1)
        Me.FormSkin1.Controls.Add(Me.FlatMini1)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(534, 232)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "Hide My IP By Adel Rehan"
        '
        'lblRealIP
        '
        Me.lblRealIP.AutoSize = True
        Me.lblRealIP.BackColor = System.Drawing.Color.Transparent
        Me.lblRealIP.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.lblRealIP.ForeColor = System.Drawing.Color.White
        Me.lblRealIP.Location = New System.Drawing.Point(203, 62)
        Me.lblRealIP.Name = "lblRealIP"
        Me.lblRealIP.Size = New System.Drawing.Size(86, 28)
        Me.lblRealIP.TabIndex = 23
        Me.lblRealIP.Text = "00:00:00"
        '
        'lblInfo2
        '
        Me.lblInfo2.AutoSize = True
        Me.lblInfo2.BackColor = System.Drawing.Color.Transparent
        Me.lblInfo2.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblInfo2.ForeColor = System.Drawing.Color.White
        Me.lblInfo2.Location = New System.Drawing.Point(68, 116)
        Me.lblInfo2.Name = "lblInfo2"
        Me.lblInfo2.Size = New System.Drawing.Size(217, 13)
        Me.lblInfo2.TabIndex = 22
        Me.lblInfo2.Text = "You are currently not hiding your Real IP!"
        '
        'pcbFakeCountry
        '
        Me.pcbFakeCountry.BackColor = System.Drawing.Color.Transparent
        Me.pcbFakeCountry.Location = New System.Drawing.Point(426, 151)
        Me.pcbFakeCountry.Name = "pcbFakeCountry"
        Me.pcbFakeCountry.Size = New System.Drawing.Size(96, 72)
        Me.pcbFakeCountry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbFakeCountry.TabIndex = 20
        Me.pcbFakeCountry.TabStop = False
        '
        'lblFakeIP
        '
        Me.lblFakeIP.AutoSize = True
        Me.lblFakeIP.BackColor = System.Drawing.Color.Transparent
        Me.lblFakeIP.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblFakeIP.ForeColor = System.Drawing.Color.White
        Me.lblFakeIP.Location = New System.Drawing.Point(225, 199)
        Me.lblFakeIP.Name = "lblFakeIP"
        Me.lblFakeIP.Size = New System.Drawing.Size(35, 13)
        Me.lblFakeIP.TabIndex = 19
        Me.lblFakeIP.Text = "None"
        '
        'FlatLabel3
        '
        Me.FlatLabel3.AutoSize = True
        Me.FlatLabel3.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel3.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.FlatLabel3.ForeColor = System.Drawing.Color.White
        Me.FlatLabel3.Location = New System.Drawing.Point(177, 199)
        Me.FlatLabel3.Name = "FlatLabel3"
        Me.FlatLabel3.Size = New System.Drawing.Size(50, 13)
        Me.FlatLabel3.TabIndex = 18
        Me.FlatLabel3.Text = "Fake IP :"
        '
        'lblFakeLocation
        '
        Me.lblFakeLocation.AutoSize = True
        Me.lblFakeLocation.BackColor = System.Drawing.Color.Transparent
        Me.lblFakeLocation.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblFakeLocation.ForeColor = System.Drawing.Color.White
        Me.lblFakeLocation.Location = New System.Drawing.Point(260, 163)
        Me.lblFakeLocation.Name = "lblFakeLocation"
        Me.lblFakeLocation.Size = New System.Drawing.Size(35, 13)
        Me.lblFakeLocation.TabIndex = 17
        Me.lblFakeLocation.Text = "None"
        '
        'FlatLabel1
        '
        Me.FlatLabel1.AutoSize = True
        Me.FlatLabel1.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel1.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.FlatLabel1.ForeColor = System.Drawing.Color.White
        Me.FlatLabel1.Location = New System.Drawing.Point(177, 163)
        Me.FlatLabel1.Name = "FlatLabel1"
        Me.FlatLabel1.Size = New System.Drawing.Size(85, 13)
        Me.FlatLabel1.TabIndex = 16
        Me.FlatLabel1.Text = "Fake Location :"
        '
        'btnChooseIPCountry
        '
        Me.btnChooseIPCountry.BackColor = System.Drawing.Color.Transparent
        Me.btnChooseIPCountry.BaseColor = System.Drawing.Color.Green
        Me.btnChooseIPCountry.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChooseIPCountry.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnChooseIPCountry.Location = New System.Drawing.Point(12, 191)
        Me.btnChooseIPCountry.Name = "btnChooseIPCountry"
        Me.btnChooseIPCountry.Rounded = False
        Me.btnChooseIPCountry.Size = New System.Drawing.Size(126, 32)
        Me.btnChooseIPCountry.TabIndex = 15
        Me.btnChooseIPCountry.Text = "Choose IP Country"
        Me.btnChooseIPCountry.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnHideIP
        '
        Me.btnHideIP.BackColor = System.Drawing.Color.Transparent
        Me.btnHideIP.BaseColor = System.Drawing.Color.Green
        Me.btnHideIP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHideIP.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnHideIP.Location = New System.Drawing.Point(12, 153)
        Me.btnHideIP.Name = "btnHideIP"
        Me.btnHideIP.Rounded = False
        Me.btnHideIP.Size = New System.Drawing.Size(126, 32)
        Me.btnHideIP.TabIndex = 14
        Me.btnHideIP.Text = "Hide IP"
        Me.btnHideIP.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'lblCheckIPInfo
        '
        Me.lblCheckIPInfo.AutoSize = True
        Me.lblCheckIPInfo.BackColor = System.Drawing.Color.Transparent
        Me.lblCheckIPInfo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblCheckIPInfo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCheckIPInfo.ForeColor = System.Drawing.Color.White
        Me.lblCheckIPInfo.Location = New System.Drawing.Point(448, 112)
        Me.lblCheckIPInfo.Name = "lblCheckIPInfo"
        Me.lblCheckIPInfo.Size = New System.Drawing.Size(75, 13)
        Me.lblCheckIPInfo.TabIndex = 13
        Me.lblCheckIPInfo.Text = "Check IP Info"
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.BackColor = System.Drawing.Color.Transparent
        Me.lblInfo.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblInfo.ForeColor = System.Drawing.Color.White
        Me.lblInfo.Location = New System.Drawing.Point(12, 116)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(56, 13)
        Me.lblInfo.TabIndex = 12
        Me.lblInfo.Text = "Warning!"
        '
        'pcbRealCountry
        '
        Me.pcbRealCountry.BackColor = System.Drawing.Color.Transparent
        Me.pcbRealCountry.Location = New System.Drawing.Point(67, 51)
        Me.pcbRealCountry.Name = "pcbRealCountry"
        Me.pcbRealCountry.Size = New System.Drawing.Size(48, 48)
        Me.pcbRealCountry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbRealCountry.TabIndex = 10
        Me.pcbRealCountry.TabStop = False
        '
        'FlatLabel2
        '
        Me.FlatLabel2.AutoSize = True
        Me.FlatLabel2.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel2.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.FlatLabel2.ForeColor = System.Drawing.Color.White
        Me.FlatLabel2.Location = New System.Drawing.Point(121, 62)
        Me.FlatLabel2.Name = "FlatLabel2"
        Me.FlatLabel2.Size = New System.Drawing.Size(94, 28)
        Me.FlatLabel2.TabIndex = 9
        Me.FlatLabel2.Text = "Real IP : "
        '
        'FlatClose1
        '
        Me.FlatClose1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatClose1.BackColor = System.Drawing.Color.White
        Me.FlatClose1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.FlatClose1.Font = New System.Drawing.Font("Marlett", 12.0!)
        Me.FlatClose1.Location = New System.Drawing.Point(504, 12)
        Me.FlatClose1.Name = "FlatClose1"
        Me.FlatClose1.Size = New System.Drawing.Size(18, 18)
        Me.FlatClose1.TabIndex = 8
        Me.FlatClose1.Text = "FlatClose1"
        Me.FlatClose1.TextColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        '
        'FlatMini1
        '
        Me.FlatMini1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatMini1.BackColor = System.Drawing.Color.White
        Me.FlatMini1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.FlatMini1.Font = New System.Drawing.Font("Marlett", 12.0!)
        Me.FlatMini1.Location = New System.Drawing.Point(476, 12)
        Me.FlatMini1.Name = "FlatMini1"
        Me.FlatMini1.Size = New System.Drawing.Size(18, 18)
        Me.FlatMini1.TabIndex = 7
        Me.FlatMini1.Text = "FlatMini1"
        Me.FlatMini1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 232)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hide My IP By Adel Rehan"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FormSkin1.PerformLayout()
        CType(Me.pcbFakeCountry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbRealCountry, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FormSkin1 As Hide_My_IP_By_Adel_Rehan.FormSkin
    Friend WithEvents FlatClose1 As Hide_My_IP_By_Adel_Rehan.FlatClose
    Friend WithEvents FlatMini1 As Hide_My_IP_By_Adel_Rehan.FlatMini
    Friend WithEvents pcbRealCountry As System.Windows.Forms.PictureBox
    Friend WithEvents FlatLabel2 As Hide_My_IP_By_Adel_Rehan.FlatLabel
    Friend WithEvents lblInfo As Hide_My_IP_By_Adel_Rehan.FlatLabel
    Friend WithEvents lblCheckIPInfo As Hide_My_IP_By_Adel_Rehan.FlatLabel
    Friend WithEvents btnChooseIPCountry As Hide_My_IP_By_Adel_Rehan.FlatButton
    Friend WithEvents btnHideIP As Hide_My_IP_By_Adel_Rehan.FlatButton
    Friend WithEvents lblFakeIP As Hide_My_IP_By_Adel_Rehan.FlatLabel
    Friend WithEvents FlatLabel3 As Hide_My_IP_By_Adel_Rehan.FlatLabel
    Friend WithEvents lblFakeLocation As Hide_My_IP_By_Adel_Rehan.FlatLabel
    Friend WithEvents FlatLabel1 As Hide_My_IP_By_Adel_Rehan.FlatLabel
    Friend WithEvents pcbFakeCountry As System.Windows.Forms.PictureBox
    Friend WithEvents lblInfo2 As Hide_My_IP_By_Adel_Rehan.FlatLabel
    Friend WithEvents lblRealIP As Hide_My_IP_By_Adel_Rehan.FlatLabel

End Class
