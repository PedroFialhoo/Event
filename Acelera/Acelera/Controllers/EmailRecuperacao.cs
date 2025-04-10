using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

public class EmailRecuperacao
{
    private string remetente = "event.sup00@gmail.com";
    private string senha = "qoih dwgq xrmy sapl";

    public bool EnviarEmail(string destinatario, string codigoRecuperacao)
    {
        try
        {
            MailMessage mensagem = new MailMessage();
            mensagem.From = new MailAddress(remetente);
            mensagem.To.Add(destinatario);
            mensagem.Subject = "Recuperação de Conta";
            mensagem.Body = $"Olá! Aqui está seu código de recuperação: {codigoRecuperacao}";
            mensagem.IsBodyHtml = false;

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new NetworkCredential(remetente, senha);
            smtp.EnableSsl = true;

            smtp.Send(mensagem);

            return true;
        }
        catch (SmtpException ex)
        {
            // Você pode exibir a mensagem de erro ou logar
            MessageBox.Show("Erro ao enviar e-mail: " + ex.Message);
            return false;
        }
    }
}
