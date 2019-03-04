using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Contacts;

namespace The_Paper.Models
{
    class SettingPageClass
    {
        public static async Task ComposeEmail()//设置邮件方法
        {
            var emailMessage = new Windows.ApplicationModel.Email.EmailMessage();
            //emailMessage.Body = messageBody;
            var email = new ContactEmail()
            {
                Address = "singhwongwxg@hotmail.com",
                Description = "问题反馈  (澎湃新闻速览版)",
            };
            //var email = recipient.Emails.FirstOrDefault<Windows.ApplicationModel.Contacts.ContactEmail>();
            if (email != null)
            {
                var emailRecipient = new Windows.ApplicationModel.Email.EmailRecipient(email.Address);
                emailMessage.To.Add(emailRecipient);
                emailMessage.Subject = email.Description;
            }

            await Windows.ApplicationModel.Email.EmailManager.ShowComposeNewEmailAsync(emailMessage);
        }

        public static async Task<bool> SetComment()
        {
            bool result = await Windows.System.Launcher.LaunchUriAsync(new Uri("ms-windows-store://review/?ProductId=9PCR0B34NFT8"));
            return result;
        }
    }
}
