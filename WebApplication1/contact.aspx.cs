﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;

namespace WebApplication1
{
    public partial class contact : System.Web.UI.Page
    {
        protected void btnSendEmail_Click(object sender, EventArgs e)
        {
            SmtpClient smtpClient = new SmtpClient();
            MailMessage msg = new MailMessage("syamim28@gmail.c", "syamim28@gmail.com");
            msg.Subject = txtSubject.Text;
            msg.Body = txtBody.Text;

            smtpClient.Host = "smtp.gmail.com";
            smtpClient.Port = 587;
            smtpClient.EnableSsl = true;

            System.Net.NetworkCredential credentials = new System.Net.NetworkCredential("syamim28@gmail.com", "YOURGMAILPWD");
            smtpClient.Credentials = credentials;
            msg = new MailMessage("syamim28@gmail.com", "syamim28@gmail.com");

            try
            {
                smtpClient.Send(msg);
                Literal1.Text = "<p>Success, mail sent using SMTP with secure connection and credentials</p>";
            }
            catch (Exception ex)
            {
                //display the full error to the user
                Literal1.Text = "<p>Send failed: " + ex.Message + ":" + ex.InnerException + "</p>";

            }

        }
    }
}