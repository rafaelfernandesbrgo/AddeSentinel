
''email
Imports System
Imports System.Net
Imports System.Net.Mail

''login
Imports Microsoft.Win32
Imports System.Security
Imports System.Security.Principal.WindowsIdentity



Public Class Frm_HiddenStart

    Dim EmailOK As Boolean = False


    Private Sub Frm_InicioOculto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            ''invisible
            Me.Visible = False
            Me.ShowInTaskbar = False

            '' start, notify, send email or configure
            PutInLogin()
            Notify("Start")
            SendEmail()
            If EmailOK = True Then
                Notify("End")
            Else
                Dim F_X As New Frm_Settings
                Frm_Settings.Show()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    ''menu strip
    Private Sub ConfiguraçãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfiguraçãoToolStripMenuItem.Click
        Dim F_X As New Frm_Settings
        Frm_Settings.Show()
    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        Application.Exit()
    End Sub




    Public Sub PutInLogin()
        Try
            Using key As RegistryKey = My.Computer.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Run", True)
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run", My.Application.Info.Title, My.Application.Info.DirectoryPath & "\" & My.Application.Info.Title & ".exe")
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            My.Computer.Registry.CurrentUser.Close()
        End Try
    End Sub

    Public Sub SendEmail()

        Try

            Dim SmtpServer As New SmtpClient()
            Dim mail As New MailMessage()
            SmtpServer.Credentials = New Net.NetworkCredential(My.Settings.HotmailSend, My.Settings.PasswordSend)
            SmtpServer.Host = "smtp.live.com"
            SmtpServer.Port = 587
            SmtpServer.EnableSsl = True
            mail.From = New MailAddress(My.Settings.HotmailSend)
            mail.To.Add(My.Settings.HotmailReceive)

            mail.Body = GetCurrent.Name & " was accessed at " & Now
            mail.Subject = "Access to " & GetCurrent.Name
            SmtpServer.Send(mail)

            EmailOK = True
        Catch ex As Exception
            EmailOK = False
        End Try

    End Sub

    Public Sub Notify(ByVal Qual As String)

        Try
            If Qual = "Start" Then
                NotifyIcon1.BalloonTipTitle = "Information"
                NotifyIcon1.BalloonTipText = "Sending email..."
                NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
                NotifyIcon1.ShowBalloonTip(50000)
            End If

            If Qual = "End" Then
                NotifyIcon1.BalloonTipTitle = "Information"
                NotifyIcon1.BalloonTipText = GetCurrent.Name & " was accessed at " & Now & ". Notification forwarded by email."
                NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
                NotifyIcon1.ShowBalloonTip(50000)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class