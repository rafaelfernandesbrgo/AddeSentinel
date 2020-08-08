<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Configuração
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
        Me.tx_SenhaEnvio = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.tx_hotmailEnvio = New MetroFramework.Controls.MetroTextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.tx_hotmailRecebimento = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.bt_Salvar = New MetroFramework.Controls.MetroButton()
        Me.bt_Testar = New MetroFramework.Controls.MetroButton()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.tx_SenhaAcesso = New MetroFramework.Controls.MetroTextBox()
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
        Me.Panel1.Controls.Add(Me.tx_SenhaEnvio)
        Me.Panel1.Controls.Add(Me.MetroLabel1)
        Me.Panel1.Controls.Add(Me.tx_hotmailEnvio)
        Me.Panel1.Location = New System.Drawing.Point(40, 178)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(306, 72)
        Me.Panel1.TabIndex = 27
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel2.Location = New System.Drawing.Point(13, 43)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(47, 19)
        Me.MetroLabel2.TabIndex = 22
        Me.MetroLabel2.Text = "Senha:"
        Me.MetroLabel2.UseCustomBackColor = True
        Me.MetroLabel2.UseCustomForeColor = True
        Me.MetroLabel2.UseStyleColors = True
        '
        'tx_SenhaEnvio
        '
        '
        '
        '
        Me.tx_SenhaEnvio.CustomButton.Image = Nothing
        Me.tx_SenhaEnvio.CustomButton.Location = New System.Drawing.Point(206, 1)
        Me.tx_SenhaEnvio.CustomButton.Name = ""
        Me.tx_SenhaEnvio.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tx_SenhaEnvio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tx_SenhaEnvio.CustomButton.TabIndex = 1
        Me.tx_SenhaEnvio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tx_SenhaEnvio.CustomButton.UseSelectable = True
        Me.tx_SenhaEnvio.CustomButton.Visible = False
        Me.tx_SenhaEnvio.Lines = New String(-1) {}
        Me.tx_SenhaEnvio.Location = New System.Drawing.Point(66, 43)
        Me.tx_SenhaEnvio.MaxLength = 32767
        Me.tx_SenhaEnvio.Name = "tx_SenhaEnvio"
        Me.tx_SenhaEnvio.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tx_SenhaEnvio.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tx_SenhaEnvio.SelectedText = ""
        Me.tx_SenhaEnvio.SelectionLength = 0
        Me.tx_SenhaEnvio.SelectionStart = 0
        Me.tx_SenhaEnvio.ShortcutsEnabled = True
        Me.tx_SenhaEnvio.Size = New System.Drawing.Size(228, 23)
        Me.tx_SenhaEnvio.Style = MetroFramework.MetroColorStyle.Yellow
        Me.tx_SenhaEnvio.TabIndex = 1
        Me.tx_SenhaEnvio.UseSelectable = True
        Me.tx_SenhaEnvio.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tx_SenhaEnvio.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel1.Location = New System.Drawing.Point(3, 13)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(58, 19)
        Me.MetroLabel1.TabIndex = 21
        Me.MetroLabel1.Text = "Hotmail:"
        Me.MetroLabel1.UseCustomBackColor = True
        Me.MetroLabel1.UseCustomForeColor = True
        Me.MetroLabel1.UseStyleColors = True
        '
        'tx_hotmailEnvio
        '
        '
        '
        '
        Me.tx_hotmailEnvio.CustomButton.Image = Nothing
        Me.tx_hotmailEnvio.CustomButton.Location = New System.Drawing.Point(206, 1)
        Me.tx_hotmailEnvio.CustomButton.Name = ""
        Me.tx_hotmailEnvio.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tx_hotmailEnvio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tx_hotmailEnvio.CustomButton.TabIndex = 1
        Me.tx_hotmailEnvio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tx_hotmailEnvio.CustomButton.UseSelectable = True
        Me.tx_hotmailEnvio.CustomButton.Visible = False
        Me.tx_hotmailEnvio.Lines = New String(-1) {}
        Me.tx_hotmailEnvio.Location = New System.Drawing.Point(66, 13)
        Me.tx_hotmailEnvio.MaxLength = 32767
        Me.tx_hotmailEnvio.Name = "tx_hotmailEnvio"
        Me.tx_hotmailEnvio.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tx_hotmailEnvio.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tx_hotmailEnvio.SelectedText = ""
        Me.tx_hotmailEnvio.SelectionLength = 0
        Me.tx_hotmailEnvio.SelectionStart = 0
        Me.tx_hotmailEnvio.ShortcutsEnabled = True
        Me.tx_hotmailEnvio.Size = New System.Drawing.Size(228, 23)
        Me.tx_hotmailEnvio.Style = MetroFramework.MetroColorStyle.Yellow
        Me.tx_hotmailEnvio.TabIndex = 0
        Me.tx_hotmailEnvio.UseSelectable = True
        Me.tx_hotmailEnvio.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tx_hotmailEnvio.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.MetroLabel4)
        Me.Panel2.Controls.Add(Me.tx_hotmailRecebimento)
        Me.Panel2.Location = New System.Drawing.Point(40, 298)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(306, 46)
        Me.Panel2.TabIndex = 28
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel4.Location = New System.Drawing.Point(6, 13)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(58, 19)
        Me.MetroLabel4.TabIndex = 23
        Me.MetroLabel4.Text = "Hotmail:"
        Me.MetroLabel4.UseCustomBackColor = True
        Me.MetroLabel4.UseCustomForeColor = True
        Me.MetroLabel4.UseStyleColors = True
        '
        'tx_hotmailRecebimento
        '
        '
        '
        '
        Me.tx_hotmailRecebimento.CustomButton.Image = Nothing
        Me.tx_hotmailRecebimento.CustomButton.Location = New System.Drawing.Point(206, 1)
        Me.tx_hotmailRecebimento.CustomButton.Name = ""
        Me.tx_hotmailRecebimento.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tx_hotmailRecebimento.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tx_hotmailRecebimento.CustomButton.TabIndex = 1
        Me.tx_hotmailRecebimento.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tx_hotmailRecebimento.CustomButton.UseSelectable = True
        Me.tx_hotmailRecebimento.CustomButton.Visible = False
        Me.tx_hotmailRecebimento.Lines = New String(-1) {}
        Me.tx_hotmailRecebimento.Location = New System.Drawing.Point(66, 13)
        Me.tx_hotmailRecebimento.MaxLength = 32767
        Me.tx_hotmailRecebimento.Name = "tx_hotmailRecebimento"
        Me.tx_hotmailRecebimento.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tx_hotmailRecebimento.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tx_hotmailRecebimento.SelectedText = ""
        Me.tx_hotmailRecebimento.SelectionLength = 0
        Me.tx_hotmailRecebimento.SelectionStart = 0
        Me.tx_hotmailRecebimento.ShortcutsEnabled = True
        Me.tx_hotmailRecebimento.Size = New System.Drawing.Size(228, 23)
        Me.tx_hotmailRecebimento.Style = MetroFramework.MetroColorStyle.Yellow
        Me.tx_hotmailRecebimento.TabIndex = 0
        Me.tx_hotmailRecebimento.UseSelectable = True
        Me.tx_hotmailRecebimento.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tx_hotmailRecebimento.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel5.Location = New System.Drawing.Point(40, 156)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(40, 19)
        Me.MetroLabel5.TabIndex = 23
        Me.MetroLabel5.Text = "Envio"
        Me.MetroLabel5.UseCustomBackColor = True
        Me.MetroLabel5.UseCustomForeColor = True
        Me.MetroLabel5.UseStyleColors = True
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel6.Location = New System.Drawing.Point(40, 276)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(86, 19)
        Me.MetroLabel6.TabIndex = 29
        Me.MetroLabel6.Text = "Recebimento"
        Me.MetroLabel6.UseCustomBackColor = True
        Me.MetroLabel6.UseCustomForeColor = True
        Me.MetroLabel6.UseStyleColors = True
        '
        'bt_Salvar
        '
        Me.bt_Salvar.Location = New System.Drawing.Point(118, 362)
        Me.bt_Salvar.Name = "bt_Salvar"
        Me.bt_Salvar.Size = New System.Drawing.Size(75, 33)
        Me.bt_Salvar.Style = MetroFramework.MetroColorStyle.Green
        Me.bt_Salvar.TabIndex = 30
        Me.bt_Salvar.Text = "Salvar"
        Me.bt_Salvar.UseCustomBackColor = True
        Me.bt_Salvar.UseSelectable = True
        '
        'bt_Testar
        '
        Me.bt_Testar.Location = New System.Drawing.Point(199, 362)
        Me.bt_Testar.Name = "bt_Testar"
        Me.bt_Testar.Size = New System.Drawing.Size(75, 33)
        Me.bt_Testar.Style = MetroFramework.MetroColorStyle.Green
        Me.bt_Testar.TabIndex = 31
        Me.bt_Testar.Text = "Testar"
        Me.bt_Testar.UseCustomBackColor = True
        Me.bt_Testar.UseSelectable = True
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(271, 94)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(75, 33)
        Me.MetroButton2.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroButton2.TabIndex = 32
        Me.MetroButton2.Text = "Ok"
        Me.MetroButton2.UseCustomBackColor = True
        Me.MetroButton2.UseSelectable = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.MetroLabel7)
        Me.Panel3.Controls.Add(Me.tx_SenhaAcesso)
        Me.Panel3.Location = New System.Drawing.Point(40, 90)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(217, 42)
        Me.Panel3.TabIndex = 28
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel7.Location = New System.Drawing.Point(8, 9)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(47, 19)
        Me.MetroLabel7.TabIndex = 22
        Me.MetroLabel7.Text = "Senha:"
        Me.MetroLabel7.UseCustomBackColor = True
        Me.MetroLabel7.UseCustomForeColor = True
        Me.MetroLabel7.UseStyleColors = True
        '
        'tx_SenhaAcesso
        '
        '
        '
        '
        Me.tx_SenhaAcesso.CustomButton.Image = Nothing
        Me.tx_SenhaAcesso.CustomButton.Location = New System.Drawing.Point(120, 1)
        Me.tx_SenhaAcesso.CustomButton.Name = ""
        Me.tx_SenhaAcesso.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tx_SenhaAcesso.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tx_SenhaAcesso.CustomButton.TabIndex = 1
        Me.tx_SenhaAcesso.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tx_SenhaAcesso.CustomButton.UseSelectable = True
        Me.tx_SenhaAcesso.CustomButton.Visible = False
        Me.tx_SenhaAcesso.Lines = New String(-1) {}
        Me.tx_SenhaAcesso.Location = New System.Drawing.Point(61, 9)
        Me.tx_SenhaAcesso.MaxLength = 32767
        Me.tx_SenhaAcesso.Name = "tx_SenhaAcesso"
        Me.tx_SenhaAcesso.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tx_SenhaAcesso.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tx_SenhaAcesso.SelectedText = ""
        Me.tx_SenhaAcesso.SelectionLength = 0
        Me.tx_SenhaAcesso.SelectionStart = 0
        Me.tx_SenhaAcesso.ShortcutsEnabled = True
        Me.tx_SenhaAcesso.Size = New System.Drawing.Size(142, 23)
        Me.tx_SenhaAcesso.Style = MetroFramework.MetroColorStyle.Yellow
        Me.tx_SenhaAcesso.TabIndex = 1
        Me.tx_SenhaAcesso.UseSelectable = True
        Me.tx_SenhaAcesso.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tx_SenhaAcesso.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel3.Location = New System.Drawing.Point(40, 68)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(49, 19)
        Me.MetroLabel3.TabIndex = 33
        Me.MetroLabel3.Text = "Acesso"
        Me.MetroLabel3.UseCustomBackColor = True
        Me.MetroLabel3.UseCustomForeColor = True
        Me.MetroLabel3.UseStyleColors = True
        '
        'Frm_Configuração
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(367, 418)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.bt_Testar)
        Me.Controls.Add(Me.bt_Salvar)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Configuração"
        Me.Style = MetroFramework.MetroColorStyle.Black
        Me.Text = "Configuração"
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
    Friend WithEvents tx_SenhaEnvio As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents tx_hotmailEnvio As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents tx_hotmailRecebimento As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents bt_Salvar As MetroFramework.Controls.MetroButton
    Friend WithEvents bt_Testar As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents tx_SenhaAcesso As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
End Class
