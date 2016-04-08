using FoodGuard.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace FoodGuard.Email.Provider
{
    public static class EmailHelper
    {
        static EmailBusiness EmailBusiness = new EmailBusiness();

        static SmtpClient client;

        static EmailHelper()
        {
            client = new SmtpClient();
        }

        public static bool SendAsHtml<T>(string templateName, string fromAddress, string toEmailAddress, string subject, T data) where T : new()
        {
            var template = EmailBusiness.GetTemplateByName(templateName);
            if (template != null)
            {
                string content = EmailTemplateRender.Compile<T>(template.Html, data);

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(fromAddress);
                mail.To.Add(toEmailAddress);
                mail.Subject = subject;
                mail.IsBodyHtml = true;
                mail.Body = content;

                try
                {
                    client.Send(mail);
                    return true;
                }
                catch (Exception ex)
                {
                }
            }

            return false;
        }
    }
}
