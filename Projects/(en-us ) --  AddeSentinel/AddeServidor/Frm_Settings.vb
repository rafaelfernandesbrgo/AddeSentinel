''email
Imports System
Imports System.Net
Imports System.Net.Mail


Public Class Frm_Settings

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '' loads values
        tx_hotmailSend.Text = My.Settings.HotmailSend
        tx_PasswordSend.Text = My.Settings.PasswordSend
        tx_HotmailReceive.Text = My.Settings.HotmailReceive

        ''starts blocked
        tx_hotmailSend.Enabled = False
        tx_PasswordSend.Enabled = False
        tx_HotmailReceive.Enabled = False
        tx_hotmailSend.BackColor = SystemColors.ButtonFace
        tx_PasswordSend.BackColor = SystemColors.ButtonFace
        tx_HotmailReceive.BackColor = SystemColors.ButtonFace
        bt_Save.Enabled = False
        bt_Test.Enabled = False

    End Sub

    Private Sub bt_Sair_Click(sender As Object, e As EventArgs) Handles bt_Save.Click

        Try

            My.Settings.HotmailSend = tx_hotmailSend.Text
            My.Settings.PasswordSend = tx_PasswordSend.Text
            My.Settings.HotmailReceive = tx_HotmailReceive.Text
            My.Settings.PasswordAcess = tx_PasswordAcess.Text
            My.Settings.Save()
            My.Settings.Reload()
            MessageBox.Show("Updated!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Try

            If tx_PasswordAcess.Text = My.Settings.PasswordAcess Then
                tx_hotmailSend.Enabled = True
                tx_PasswordSend.Enabled = True
                tx_HotmailReceive.Enabled = True
                tx_hotmailSend.BackColor = SystemColors.ControlLightLight
                tx_PasswordSend.BackColor = SystemColors.ControlLightLight
                tx_HotmailReceive.BackColor = SystemColors.ControlLightLight
                bt_Save.Enabled = True
                bt_Test.Enabled = True
                MessageBox.Show("Confirmed access!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                tx_hotmailSend.Enabled = False
                tx_PasswordSend.Enabled = False
                tx_HotmailReceive.Enabled = False
                tx_hotmailSend.BackColor = SystemColors.ButtonFace
                tx_PasswordSend.BackColor = SystemColors.ButtonFace
                tx_HotmailReceive.BackColor = SystemColors.ButtonFace
                bt_Save.Enabled = False
                bt_Test.Enabled = False
                MessageBox.Show("Incorrect Access Password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub bt_Testar_Click(sender As Object, e As EventArgs) Handles bt_Test.Click


        Try

            Dim SmtpServer As New SmtpClient()
            Dim mail As New MailMessage()
            SmtpServer.Credentials = New Net.NetworkCredential(My.Settings.HotmailSend, My.Settings.PasswordSend)
            SmtpServer.Host = "smtp.live.com"
            SmtpServer.Port = 587
            SmtpServer.EnableSsl = True
            mail.From = New MailAddress(My.Settings.HotmailSend)
            mail.To.Add(My.Settings.HotmailReceive)

            mail.Body = "Connected"
            mail.Subject = "Connection Test"
            SmtpServer.Send(mail)

            MessageBox.Show("Connected established, test email sent!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Not connected!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try



    End Sub
End Class

