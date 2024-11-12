using System.Net;
using System.Net.Mail;
using testarskit.Mock.Interfaces;

namespace testarskit.Repositories;

public class EmailService (IEmailService repo)
{ 
    public void SendEmail(string toAddress, string subject, string body)
    {
        repo.SendEmail(toAddress, subject, body);
    }
}