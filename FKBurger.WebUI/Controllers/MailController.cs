using Microsoft.AspNetCore.Mvc;
using FKBurger.WebUI.DTOs.MailDTOs;
using MimeKit;
using MailKit.Net.Smtp;

namespace FKBurger.WebUI.Controllers;
public class MailController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(CreateMailDTO createMailDTO)
    {
        MimeMessage mimeMessage = new MimeMessage();

        MailboxAddress mailboxAddressFrom = new MailboxAddress("FKBurger Rezervasyon", "firatkazak@gmail.com");
        mimeMessage.From.Add(mailboxAddressFrom);

        MailboxAddress mailboxAddressTo = new MailboxAddress("User", createMailDTO.ReceiverMail);
        mimeMessage.To.Add(mailboxAddressTo);

        var bodyBuilder = new BodyBuilder();
        bodyBuilder.TextBody = createMailDTO.Body; ;
        mimeMessage.Body = bodyBuilder.ToMessageBody();

        mimeMessage.Subject = createMailDTO.Subject;

        SmtpClient client = new SmtpClient();
        client.Connect("smtp.gmail.com", 587, false);
        client.Authenticate("firatkazak@gmail.com", "uvll izrj pakg ckpi ");

        client.Send(mimeMessage);
        client.Disconnect(true);

        return RedirectToAction("Index", "Category");
    }
}
