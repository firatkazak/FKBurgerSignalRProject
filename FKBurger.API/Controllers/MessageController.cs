using FKBurger.Business.Abstract;
using FKBurger.DTO.MessageDTO;
using FKBurger.Entity.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FKBurger.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class MessageController : ControllerBase
{
    private readonly IMessageService _messageService;
    public MessageController(IMessageService messageService)
    {
        _messageService = messageService;
    }

    [HttpGet]
    public IActionResult MessageList()
    {
        var values = _messageService.TGetListAll();
        return Ok(values);
    }
    [HttpPost]
    public IActionResult CreateMessage(CreateMessageDTO createMessageDTO)
    {
        Message message = new Message()
        {
            Mail = createMessageDTO.Mail,
            MessageContent = createMessageDTO.MessageContent,
            MessageSendDate = DateTime.Now,
            NameSurname = createMessageDTO.NameSurname,
            Phone = createMessageDTO.Phone,
            Status = false,
            Subject = createMessageDTO.Subject
        };
        _messageService.TAdd(message);
        return Ok("Mesaj Başarılı Bir Şekilde Gönderildi");
    }
    [HttpDelete("{id}")]
    public IActionResult DeleteMessage(int id)
    {
        var value = _messageService.TGetById(id);
        _messageService.TDelete(value);
        return Ok("Mesaj Silindi");
    }
    [HttpPut]
    public IActionResult UpdateMessage(UpdateMessageDTO updateMessageDTO)
    {
        Message message = new Message()
        {
            Mail = updateMessageDTO.Mail,
            MessageContent = updateMessageDTO.MessageContent,
            MessageSendDate = updateMessageDTO.MessageSendDate,
            NameSurname = updateMessageDTO.NameSurname,
            Phone = updateMessageDTO.Phone,
            Status = false,
            Subject = updateMessageDTO.Subject,
            MessageID = updateMessageDTO.MessageID
        };
        _messageService.TUpdate(message);
        return Ok("Mesaj Bilgisi Güncellendi");
    }
    [HttpGet("{id}")]
    public IActionResult GetMessage(int id)
    {
        var value = _messageService.TGetById(id);
        return Ok(value);
    }
}