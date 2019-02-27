﻿using HepsiBurada.MODELS.Enums;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace HepsiBurada.BLL.Services.Senders
{
    public class EmailService:IMessageService
    {
        private string _userId = HttpContext.Current.User.Identity.GetUserId();
        public string[] Cc { get; set; }
        public string[] Bcc { get; set; }
        public string FilePath { get; set; }
        public MessageStates MessageState { get; private set; }
        public string SenderMail { get; set; }
        public string Password { get; set; }
        public string Smtp { get; set; }
        public int SmtpPort { get; set; }

        public EmailService()
        {
            this.SenderMail = "networkteknikservis@gmail.com";
            this.Password = "111111a*";
            this.Smtp = "smtp.gmail.com";
            this.SmtpPort = 587;
        }
        public EmailService(string senderMail, string password, string smtp, int smtpPort)
        {
            this.SenderMail = senderMail;
            this.Password = password;
            this.Smtp = smtp;
            this.SmtpPort = smtpPort;
        }

        public async Task SendAsync(IdentityMessage message, params string[] contacts)
        {
            var userID = _userId ?? "system";
            try
            {
                var mail = new MailMessage { From = new MailAddress(this.SenderMail) };
                if (!string.IsNullOrEmpty(FilePath))
                {
                    mail.Attachments.Add(new Attachment(FilePath));
                }
                foreach (var c in contacts)
                {
                    mail.To.Add(c);
                }
                if (Cc != null && Cc.Length > 0)
                {
                    foreach (var cc in Cc)
                    {
                        mail.CC.Add(new MailAddress(cc));
                    }
                }

                if (Bcc != null && Bcc.Length > 0)
                {
                    foreach (var bcc in Bcc)
                    {
                        mail.Bcc.Add(new MailAddress(bcc));
                    }
                }
                mail.Subject = message.Subject;
                mail.Body = message.Body;

                mail.IsBodyHtml = true;
                mail.BodyEncoding = Encoding.UTF8;
                mail.SubjectEncoding = Encoding.UTF8;
                mail.HeadersEncoding = Encoding.UTF8;

                var smptClient = new SmtpClient(this.Smtp, this.SmtpPort)
                {
                    Credentials = new NetworkCredential(this.SenderMail, this.Password),
                    EnableSsl = true
                };
                await smptClient.SendMailAsync(mail);
                MessageState = MessageStates.Gönderildi;
            }
            catch (Exception ex)
            {
                MessageState = MessageStates.Gönderilemedi;
            }

        }

        public void Send(IdentityMessage message, params string[] contacts)
        {
            Task.Run(async () =>
            {
                await this.SendAsync(message, contacts);
            });
        }
    }
}
