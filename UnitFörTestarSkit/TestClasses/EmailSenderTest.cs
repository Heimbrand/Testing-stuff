using FakeItEasy;
using testarskit.Mock.Interfaces;
using testarskit.Repositories;

namespace UnitFörTestarSkit.TestClasses;

public class EmailSenderTest
{
    private readonly EmailService _service;
    private readonly IEmailService _repo;

    public EmailSenderTest()
    {
        _repo = A.Fake<IEmailService>();
        _service = new EmailService(_repo);
    }

    [Fact]
    public void SendEmailTest()
    {
        // Arrange 
        string toAddress = "test";
        string subject = "test";
        string body = "test";

         // Act 
        _service.SendEmail(toAddress, subject, body);

        // Assert
        A.CallTo(() => _repo.SendEmail(toAddress, subject, body)).MustHaveHappenedOnceExactly();
    }
}