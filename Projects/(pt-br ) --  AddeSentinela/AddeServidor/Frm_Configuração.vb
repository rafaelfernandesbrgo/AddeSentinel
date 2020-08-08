''email
Imports System
Imports System.Net
Imports System.Net.Mail


Public Class Frm_Configuração

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ''carrega valores
        tx_hotmailEnvio.Text = My.Settings.HotmailEnvio
        tx_SenhaEnvio.Text = My.Settings.SenhaEnvio
        tx_hotmailRecebimento.Text = My.Settings.HotmailRecebimento

        ''começa bloqueado
        tx_hotmailEnvio.Enabled = False
        tx_SenhaEnvio.Enabled = False
        tx_hotmailRecebimento.Enabled = False
        tx_hotmailEnvio.BackColor = SystemColors.ButtonFace
        tx_SenhaEnvio.BackColor = SystemColors.ButtonFace
        tx_hotmailRecebimento.BackColor = SystemColors.ButtonFace
        bt_Salvar.Enabled = False
        bt_Testar.Enabled = False

    End Sub

    Private Sub bt_Sair_Click(sender As Object, e As EventArgs) Handles bt_Salvar.Click

        Try

            My.Settings.HotmailEnvio = tx_hotmailEnvio.Text
            My.Settings.SenhaEnvio = tx_SenhaEnvio.Text
            My.Settings.HotmailRecebimento = tx_hotmailRecebimento.Text
            My.Settings.SenhaAcesso = tx_SenhaAcesso.Text
            My.Settings.Save()
            My.Settings.Reload()
            MessageBox.Show("Atualizado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Try

            If tx_SenhaAcesso.Text = My.Settings.SenhaAcesso Then
                tx_hotmailEnvio.Enabled = True
                tx_SenhaEnvio.Enabled = True
                tx_hotmailRecebimento.Enabled = True
                tx_hotmailEnvio.BackColor = SystemColors.ControlLightLight
                tx_SenhaEnvio.BackColor = SystemColors.ControlLightLight
                tx_hotmailRecebimento.BackColor = SystemColors.ControlLightLight
                bt_Salvar.Enabled = True
                bt_Testar.Enabled = True
                MessageBox.Show("Acesso Liberado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                tx_hotmailEnvio.Enabled = False
                tx_SenhaEnvio.Enabled = False
                tx_hotmailRecebimento.Enabled = False
                tx_hotmailEnvio.BackColor = SystemColors.ButtonFace
                tx_SenhaEnvio.BackColor = SystemColors.ButtonFace
                tx_hotmailRecebimento.BackColor = SystemColors.ButtonFace
                bt_Salvar.Enabled = False
                bt_Testar.Enabled = False
                MessageBox.Show("Senha de Acesso incorreta!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub bt_Testar_Click(sender As Object, e As EventArgs) Handles bt_Testar.Click


        Try

            Dim SmtpServer As New SmtpClient()
            Dim mail As New MailMessage()
            SmtpServer.Credentials = New Net.NetworkCredential(My.Settings.HotmailEnvio, My.Settings.SenhaEnvio)
            SmtpServer.Host = "smtp.live.com"
            SmtpServer.Port = 587
            SmtpServer.EnableSsl = True
            mail.From = New MailAddress(My.Settings.HotmailEnvio)
            mail.To.Add(My.Settings.HotmailRecebimento)

            mail.Body = "Conexão estabelecida"
            mail.Subject = "Teste de Conexão"
            SmtpServer.Send(mail)

            MessageBox.Show("Conexão estabelecida, email de teste enviado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Conexão não estabelecida!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try



    End Sub
End Class

