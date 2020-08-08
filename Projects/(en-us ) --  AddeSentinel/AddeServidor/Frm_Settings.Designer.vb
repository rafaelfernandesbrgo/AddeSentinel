<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Settings
    Inherits MetroFramework.Forms.MetroForm

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.tx_PasswordSend = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.tx_hotmailSend = New MetroFramework.Controls.MetroTextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.tx_HotmailReceive = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.bt_Save = New MetroFramework.Controls.MetroButton()
        Me.bt_Test = New MetroFramework.Controls.MetroButton()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.tx_PasswordAcess = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.MetroLabel2)
        Me.Panel1.Controls.Add(Me.tx_PasswordSend)
        Me.Panel1.Controls.Add(Me.MetroLabel1)
        Me.Panel1.Controls.Add(Me.tx_hotmailSend)
        Me.Panel1.Location = New System.Drawing.Point(53, 219)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(407, 88)
        Me.Panel1.TabIndex = 27
        Me.Panel1.UseWaitCursor = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel2.Location = New System.Drawing.Point(17, 53)
        Me.MetroLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(50, 20)
        Me.MetroLabel2.TabIndex = 22
        Me.MetroLabel2.Text = "Senha:"
        Me.MetroLabel2.UseCustomBackColor = True
        Me.MetroLabel2.UseCustomForeColor = True
        Me.MetroLabel2.UseStyleColors = True
        Me.MetroLabel2.UseWaitCursor = True
        '
        'tx_PasswordSend
        '
        '
        '
        '
        Me.tx_PasswordSend.CustomButton.Image = Nothing
        Me.tx_PasswordSend.CustomButton.Location = New System.Drawing.Point(371, 2)
        Me.tx_PasswordSend.CustomButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tx_PasswordSend.CustomButton.Name = ""
        Me.tx_PasswordSend.CustomButton.Size = New System.Drawing.Size(31, 28)
        Me.tx_PasswordSend.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tx_PasswordSend.CustomButton.TabIndex = 1
        Me.tx_PasswordSend.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tx_PasswordSend.CustomButton.UseSelectable = True
        Me.tx_PasswordSend.CustomButton.UseWaitCursor = True
        Me.tx_PasswordSend.CustomButton.Visible = False
        Me.tx_PasswordSend.Lines = New String(-1) {}
        Me.tx_PasswordSend.Location = New System.Drawing.Point(88, 53)
        Me.tx_PasswordSend.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tx_PasswordSend.MaxLength = 32767
        Me.tx_PasswordSend.Name = "tx_PasswordSend"
        Me.tx_PasswordSend.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tx_PasswordSend.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tx_PasswordSend.SelectedText = ""
        Me.tx_PasswordSend.SelectionLength = 0
        Me.tx_PasswordSend.SelectionStart = 0
        Me.tx_PasswordSend.ShortcutsEnabled = True
        Me.tx_PasswordSend.Size = New System.Drawing.Size(304, 28)
        Me.tx_PasswordSend.Style = MetroFramework.MetroColorStyle.Yellow
        Me.tx_PasswordSend.TabIndex = 1
        Me.tx_PasswordSend.UseSelectable = True
        Me.tx_PasswordSend.UseWaitCursor = True
        Me.tx_PasswordSend.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tx_PasswordSend.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel1.Location = New System.Drawing.Point(4, 16)
        Me.MetroLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(59, 20)
        Me.MetroLabel1.TabIndex = 21
        Me.MetroLabel1.Text = "Hotmail:"
        Me.MetroLabel1.UseCustomBackColor = True
        Me.MetroLabel1.UseCustomForeColor = True
        Me.MetroLabel1.UseStyleColors = True
        Me.MetroLabel1.UseWaitCursor = True
        '
        'tx_hotmailSend
        '
        '
        '
        '
        Me.tx_hotmailSend.CustomButton.Image = Nothing
        Me.tx_hotmailSend.CustomButton.Location = New System.Drawing.Point(371, 2)
        Me.tx_hotmailSend.CustomButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tx_hotmailSend.CustomButton.Name = ""
        Me.tx_hotmailSend.CustomButton.Size = New System.Drawing.Size(31, 28)
        Me.tx_hotmailSend.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tx_hotmailSend.CustomButton.TabIndex = 1
        Me.tx_hotmailSend.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tx_hotmailSend.CustomButton.UseSelectable = True
        Me.tx_hotmailSend.CustomButton.UseWaitCursor = True
        Me.tx_hotmailSend.CustomButton.Visible = False
        Me.tx_hotmailSend.Lines = New String(-1) {}
        Me.tx_hotmailSend.Location = New System.Drawing.Point(88, 16)
        Me.tx_hotmailSend.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tx_hotmailSend.MaxLength = 32767
        Me.tx_hotmailSend.Name = "tx_hotmailSend"
        Me.tx_hotmailSend.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tx_hotmailSend.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tx_hotmailSend.SelectedText = ""
        Me.tx_hotmailSend.SelectionLength = 0
        Me.tx_hotmailSend.SelectionStart = 0
        Me.tx_hotmailSend.ShortcutsEnabled = True
        Me.tx_hotmailSend.Size = New System.Drawing.Size(304, 28)
        Me.tx_hotmailSend.Style = MetroFramework.MetroColorStyle.Yellow
        Me.tx_hotmailSend.TabIndex = 0
        Me.tx_hotmailSend.UseSelectable = True
        Me.tx_hotmailSend.UseWaitCursor = True
        Me.tx_hotmailSend.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tx_hotmailSend.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.MetroLabel4)
        Me.Panel2.Controls.Add(Me.tx_HotmailReceive)
        Me.Panel2.Location = New System.Drawing.Point(53, 367)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(407, 56)
        Me.Panel2.TabIndex = 28
        Me.Panel2.UseWaitCursor = True
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel4.Location = New System.Drawing.Point(8, 16)
        Me.MetroLabel4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(59, 20)
        Me.MetroLabel4.TabIndex = 23
        Me.MetroLabel4.Text = "Hotmail:"
        Me.MetroLabel4.UseCustomBackColor = True
        Me.MetroLabel4.UseCustomForeColor = True
        Me.MetroLabel4.UseStyleColors = True
        Me.MetroLabel4.UseWaitCursor = True
        '
        'tx_HotmailReceive
        '
        '
        '
        '
        Me.tx_HotmailReceive.CustomButton.Image = Nothing
        Me.tx_HotmailReceive.CustomButton.Location = New System.Drawing.Point(371, 2)
        Me.tx_HotmailReceive.CustomButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tx_HotmailReceive.CustomButton.Name = ""
        Me.tx_HotmailReceive.CustomButton.Size = New System.Drawing.Size(31, 28)
        Me.tx_HotmailReceive.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tx_HotmailReceive.CustomButton.TabIndex = 1
        Me.tx_HotmailReceive.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tx_HotmailReceive.CustomButton.UseSelectable = True
        Me.tx_HotmailReceive.CustomButton.UseWaitCursor = True
        Me.tx_HotmailReceive.CustomButton.Visible = False
        Me.tx_HotmailReceive.Lines = New String(-1) {}
        Me.tx_HotmailReceive.Location = New System.Drawing.Point(88, 16)
        Me.tx_HotmailReceive.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tx_HotmailReceive.MaxLength = 32767
        Me.tx_HotmailReceive.Name = "tx_HotmailReceive"
        Me.tx_HotmailReceive.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tx_HotmailReceive.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tx_HotmailReceive.SelectedText = ""
        Me.tx_HotmailReceive.SelectionLength = 0
        Me.tx_HotmailReceive.SelectionStart = 0
        Me.tx_HotmailReceive.ShortcutsEnabled = True
        Me.tx_HotmailReceive.Size = New System.Drawing.Size(304, 28)
        Me.tx_HotmailReceive.Style = MetroFramework.MetroColorStyle.Yellow
        Me.tx_HotmailReceive.TabIndex = 0
        Me.tx_HotmailReceive.UseSelectable = True
        Me.tx_HotmailReceive.UseWaitCursor = True
        Me.tx_HotmailReceive.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tx_HotmailReceive.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel5.Location = New System.Drawing.Point(53, 192)
        Me.MetroLabel5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(50, 25)
        Me.MetroLabel5.TabIndex = 23
        Me.MetroLabel5.Text = "Send"
        Me.MetroLabel5.UseCustomBackColor = True
        Me.MetroLabel5.UseCustomForeColor = True
        Me.MetroLabel5.UseStyleColors = True
        Me.MetroLabel5.UseWaitCursor = True
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel6.Location = New System.Drawing.Point(53, 340)
        Me.MetroLabel6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(73, 25)
        Me.MetroLabel6.TabIndex = 29
        Me.MetroLabel6.Text = "Receive"
        Me.MetroLabel6.UseCustomBackColor = True
        Me.MetroLabel6.UseCustomForeColor = True
        Me.MetroLabel6.UseStyleColors = True
        Me.MetroLabel6.UseWaitCursor = True
        '
        'bt_Save
        '
        Me.bt_Save.Location = New System.Drawing.Point(157, 446)
        Me.bt_Save.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bt_Save.Name = "bt_Save"
        Me.bt_Save.Size = New System.Drawing.Size(100, 41)
        Me.bt_Save.Style = MetroFramework.MetroColorStyle.Green
        Me.bt_Save.TabIndex = 30
        Me.bt_Save.Text = "Save"
        Me.bt_Save.UseCustomBackColor = True
        Me.bt_Save.UseSelectable = True
        Me.bt_Save.UseWaitCursor = True
        '
        'bt_Test
        '
        Me.bt_Test.Location = New System.Drawing.Point(265, 446)
        Me.bt_Test.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bt_Test.Name = "bt_Test"
        Me.bt_Test.Size = New System.Drawing.Size(100, 41)
        Me.bt_Test.Style = MetroFramework.MetroColorStyle.Green
        Me.bt_Test.TabIndex = 31
        Me.bt_Test.Text = "Test"
        Me.bt_Test.UseCustomBackColor = True
        Me.bt_Test.UseSelectable = True
        Me.bt_Test.UseWaitCursor = True
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(361, 116)
        Me.MetroButton2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(100, 41)
        Me.MetroButton2.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroButton2.TabIndex = 32
        Me.MetroButton2.Text = "Ok"
        Me.MetroButton2.UseCustomBackColor = True
        Me.MetroButton2.UseSelectable = True
        Me.MetroButton2.UseWaitCursor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.MetroLabel7)
        Me.Panel3.Controls.Add(Me.tx_PasswordAcess)
        Me.Panel3.Location = New System.Drawing.Point(53, 111)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(300, 51)
        Me.Panel3.TabIndex = 28
        Me.Panel3.UseWaitCursor = True
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel7.Location = New System.Drawing.Point(11, 11)
        Me.MetroLabel7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(83, 25)
        Me.MetroLabel7.TabIndex = 22
        Me.MetroLabel7.Text = "Password"
        Me.MetroLabel7.UseCustomBackColor = True
        Me.MetroLabel7.UseCustomForeColor = True
        Me.MetroLabel7.UseStyleColors = True
        Me.MetroLabel7.UseWaitCursor = True
        '
        'tx_PasswordAcess
        '
        '
        '
        '
        Me.tx_PasswordAcess.CustomButton.Image = Nothing
        Me.tx_PasswordAcess.CustomButton.Location = New System.Drawing.Point(217, 2)
        Me.tx_PasswordAcess.CustomButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tx_PasswordAcess.CustomButton.Name = ""
        Me.tx_PasswordAcess.CustomButton.Size = New System.Drawing.Size(31, 28)
        Me.tx_PasswordAcess.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tx_PasswordAcess.CustomButton.TabIndex = 1
        Me.tx_PasswordAcess.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tx_PasswordAcess.CustomButton.UseSelectable = True
        Me.tx_PasswordAcess.CustomButton.UseWaitCursor = True
        Me.tx_PasswordAcess.CustomButton.Visible = False
        Me.tx_PasswordAcess.Lines = New String(-1) {}
        Me.tx_PasswordAcess.Location = New System.Drawing.Point(95, 10)
        Me.tx_PasswordAcess.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tx_PasswordAcess.MaxLength = 32767
        Me.tx_PasswordAcess.Name = "tx_PasswordAcess"
        Me.tx_PasswordAcess.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tx_PasswordAcess.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tx_PasswordAcess.SelectedText = ""
        Me.tx_PasswordAcess.SelectionLength = 0
        Me.tx_PasswordAcess.SelectionStart = 0
        Me.tx_PasswordAcess.ShortcutsEnabled = True
        Me.tx_PasswordAcess.Size = New System.Drawing.Size(189, 28)
        Me.tx_PasswordAcess.Style = MetroFramework.MetroColorStyle.Yellow
        Me.tx_PasswordAcess.TabIndex = 1
        Me.tx_PasswordAcess.UseSelectable = True
        Me.tx_PasswordAcess.UseWaitCursor = True
        Me.tx_PasswordAcess.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tx_PasswordAcess.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel3.Location = New System.Drawing.Point(53, 84)
        Me.MetroLabel3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(65, 25)
        Me.MetroLabel3.TabIndex = 33
        Me.MetroLabel3.Text = "Access"
        Me.MetroLabel3.UseCustomBackColor = True
        Me.MetroLabel3.UseCustomForeColor = True
        Me.MetroLabel3.UseStyleColors = True
        Me.MetroLabel3.UseWaitCursor = True
        '
        'Frm_Settings
        '
        Me.ApplyImageInvert = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 514)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.bt_Test)
        Me.Controls.Add(Me.bt_Save)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Settings"
        Me.Padding = New System.Windows.Forms.Padding(27, 74, 27, 25)
        Me.Style = MetroFramework.MetroColorStyle.Black
        Me.Text = "Settings"
        Me.UseWaitCursor = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents tx_PasswordSend As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents tx_hotmailSend As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents tx_HotmailReceive As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents bt_Save As MetroFramework.Controls.MetroButton
    Friend WithEvents bt_Test As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents tx_PasswordAcess As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
End Class
