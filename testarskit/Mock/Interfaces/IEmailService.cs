namespace testarskit.Mock.Interfaces;

public interface IEmailService
{
    void SendEmail(string toAddress, string subject, string body);
}