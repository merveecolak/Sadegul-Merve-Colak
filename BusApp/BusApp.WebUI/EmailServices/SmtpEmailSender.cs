﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace BusApp.WebUI.EmailServices
{
    public class SmtpEmailSender : IEmailSender
    {
        private string _host;
        private int _port;
        private bool _enableSSL;
        private string _userName;
        private string _password;

        public SmtpEmailSender(string host, int port, bool enableSSL, string userName, string password)
        {
            _host = host;
            _port = port;
            _enableSSL = enableSSL;
            _userName = userName;
            _password = password;
        }
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var client = new SmtpClient(this._host, this._port)
            {
                Credentials = new NetworkCredential(_userName, _password),
                EnableSsl = this._enableSSL
            };
            return client.SendMailAsync(
                new MailMessage(this._userName, email, subject, htmlMessage)
                {
                    IsBodyHtml = true
                });
        }
    }
}
