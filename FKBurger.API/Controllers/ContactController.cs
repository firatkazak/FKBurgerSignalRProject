using AutoMapper;
using FKBurger.Business.Abstract;
using FKBurger.DTO.ContactDTO;
using FKBurger.Entity.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FKBurger.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ContactController : ControllerBase
{
    private readonly IContactService _contactService;
    private readonly IMapper _mapper;

    public ContactController(IContactService contactService, IMapper mapper)
    {
        _contactService = contactService;
        _mapper = mapper;
    }

    [HttpGet]
    public IActionResult ContactList()
    {
        var value = _mapper.Map<List<ResultContactDTO>>(_contactService.TGetListAll());
        return Ok(value);
    }
    [HttpPost]
    public IActionResult CreateContact(CreateContactDTO createContactDTO)
    {
        _contactService.TAdd(new Contact()
        {
            FooterDescription = createContactDTO.FooterDescription,
            Location = createContactDTO.Location,
            Mail = createContactDTO.Mail,
            Phone = createContactDTO.Phone,
            FooterTitle = createContactDTO.FooterTitle,
            OpenDays = createContactDTO.OpenDays,
            OpenDaysDescription = createContactDTO.OpenDaysDescription,
            OpenHours = createContactDTO.OpenHours
        });
        return Ok("İletişim Bilgisi Eklendi");
    }
    [HttpDelete("{id}")]
    public IActionResult DeleteContact(int id)
    {
        var value = _contactService.TGetById(id);
        _contactService.TDelete(value);
        return Ok("İletişim Bilgisi Silindi");
    }
    [HttpGet("{id}")]
    public IActionResult GetContact(int id)
    {
        var value = _contactService.TGetById(id);
        return Ok(value);
    }
    [HttpPut]
    public IActionResult UpdateContact(UpdateContactDTO updateContactDTO)
    {
        _contactService.TUpdate(new Contact()
        {
            ContactID = updateContactDTO.ContactID,
            FooterDescription = updateContactDTO.FooterDescription,
            Location = updateContactDTO.Location,
            Mail = updateContactDTO.Mail,
            Phone = updateContactDTO.Phone,
            FooterTitle = updateContactDTO.FooterTitle,
            OpenDays = updateContactDTO.OpenDays,
            OpenDaysDescription = updateContactDTO.OpenDaysDescription,
            OpenHours = updateContactDTO.OpenHours
        });
        return Ok("İletişim Bilgisi Güncellendi");
    }
}