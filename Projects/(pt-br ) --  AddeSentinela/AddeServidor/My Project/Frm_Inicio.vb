''notificação
Imports Tulpep.NotificationWindow

''login
Imports Microsoft.Win32

''email
Imports System
Imports System.Net
Imports System.Net.Mail

''login
Imports System.Security
Imports System.Security.Principal.WindowsIdentity


Public Class Frm_Oculto

    Dim nomeLogin As String
    Dim EmailOK As Boolean = False

    Private Sub ConfiguraçãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfiguraçãoToolStripMenuItem.Click
        Dim F_X As New Frm_Configuração
        Frm_Configuração.Show()
    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub Frm_Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ''invisivel
        Me.Visible = False
        Me.ShowInTaskbar = False


        ColocaNoLogin()
        PegaLogon()
        Notificação("Inicio")
        EnviaEmail()

        If EmailOK = True Then
            Notificação("Final")
        End If

    End Sub



    Public Sub ColocaNoLogin()
        Try
            Using key As RegistryKey = My.Computer.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Run", True)
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run", My.Application.Info.Title, My.Application.Info.DirectoryPath & "\" & My.Application.Info.Title & ".exe")
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            My.Computer.Registry.CurrentUser.Close()
        End Try
    End Sub

    Public Sub EnviaEmail()

        Try

            Dim SmtpServer As New SmtpClient()
            Dim mail As New MailMessage()
            SmtpServer.Credentials = New Net.NetworkCredential("rafaelvbf3@hotmail.com", "janela2014")
            SmtpServer.Host = "smtp.live.com"
            SmtpServer.Port = 587
            SmtpServer.EnableSsl = True
            mail.From = New MailAddress("rafaelvbf3@hotmail.com")
            mail.To.Add("rafaelvbf3@hotmail.com")

            mail.Body = nomeLogin & "foi acessado às " & Now
            mail.Subject = "Acesso ao " & nomeLogin
            SmtpServer.Send(mail)

            EmailOK = True
        Catch ex As Exception
            EmailOK = False
        End Try

    End Sub

    Public Sub Notificação(ByVal Qual As String)

        If Qual = "Inicio" Then
            NotifyIcon1.BalloonTipTitle = "Informação"
            NotifyIcon1.BalloonTipText = "Enviando email..."
            NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
            NotifyIcon1.ShowBalloonTip(50000)
        End If

        If Qual = "Final" Then
            NotifyIcon1.BalloonTipTitle = "Informação"
            NotifyIcon1.BalloonTipText = nomeLogin & " foi acessado às " & Now & ". Notificação encaminhada por email."
            NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
            NotifyIcon1.ShowBalloonTip(50000)
        End If


    End Sub

    Public Sub PegaLogon()
        nomeLogin = GetCurrent.Name
    End Sub

End Class