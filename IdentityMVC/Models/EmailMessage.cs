using System.Collections.Generic;

namespace IdentityMVC.Models
{
    public class EmailMessage
    {
        public EmailMessage()
        {
            FromAddresses = new List<EmailAddress>();
            ToAddresses = new List<EmailAddress>();
        }

        public EmailMessage(string fromAddress, string toAddress)
        {
            FromAddresses = new List<EmailAddress> { new EmailAddress() { Name = string.Empty, Address = fromAddress } };
            ToAddresses = new List<EmailAddress> { new EmailAddress() { Name = string.Empty, Address = toAddress } };
        }

        public EmailMessage(EmailAddress fromAddress, string toAddress)
        {
            FromAddresses = new List<EmailAddress> { fromAddress };
            ToAddresses = new List<EmailAddress> { new EmailAddress() { Name = string.Empty, Address = toAddress } };
        }

        public EmailMessage(string fromAddress, EmailAddress toAddress)
        {
            FromAddresses = new List<EmailAddress> { new EmailAddress() { Name = string.Empty, Address = fromAddress } };
            ToAddresses = new List<EmailAddress> { toAddress };
        }

        public List<EmailAddress> ToAddresses { get; set; }
        public List<EmailAddress> FromAddresses { get; set; }
        public string Subject { get; set; }
        public string HtmlBody { get; set; }
        public string TextBody { get; set; }
    }
}
