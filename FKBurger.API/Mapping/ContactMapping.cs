using AutoMapper;
using FKBurger.DTO.ContactDTO;
using FKBurger.Entity.Entities;

namespace FKBurger.API.Mapping;
public class ContactMapping : Profile
{
	public ContactMapping()
	{
		CreateMap<Contact, CreateContactDTO>().ReverseMap();
		CreateMap<Contact, GetContactDTO>().ReverseMap();
		CreateMap<Contact, ResultContactDTO>().ReverseMap();
		CreateMap<Contact, UpdateContactDTO>().ReverseMap();
	}
}
