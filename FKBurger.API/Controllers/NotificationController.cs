using FKBurger.Business.Abstract;
using FKBurger.DTO.NotificationDTO;
using FKBurger.Entity.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FKBurger.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class NotificationController : ControllerBase
{
	private readonly INotificationService _notificationService;
	public NotificationController(INotificationService notificationService)
	{
		_notificationService = notificationService;
	}
	[HttpGet]
	public IActionResult NotificationList()
	{
		return Ok(_notificationService.TGetListAll());
	}
	[HttpGet("NotificationCountByStatusFalse")]
	public IActionResult NotificationCountByStatusFalse()
	{
		return Ok(_notificationService.TNotificationCountByStatusFalse());
	}
	[HttpGet("GetAllNotificationByFalse")]
	public IActionResult GetAllNotificationByFalse()
	{
		return Ok(_notificationService.TGetAllNotificationByFalse());
	}
	[HttpPost]
	public IActionResult CreateNotification(CreateNotificationDTO createNotificationDTO)
	{
		Notification notification = new Notification()
		{
			Description = createNotificationDTO.Description,
			Icon = createNotificationDTO.Icon,
			Status = false,
			Type = createNotificationDTO.Type,
			Date = Convert.ToDateTime(DateTime.Now.ToShortDateString())
		};
		_notificationService.TAdd(notification);
		return Ok("Ekleme işlemi başarıyla yapıldı");
	}
	[HttpDelete("{id}")]
	public IActionResult DeleteNotification(int id)
	{
		var value = _notificationService.TGetById(id);
		_notificationService.TDelete(value);
		return Ok("Bildirim Silindi");
	}
	[HttpGet("{id}")]
	public IActionResult GetNotification(int id)
	{
		var value = _notificationService.TGetById(id);
		return Ok(value);
	}

	[HttpPut]
	public IActionResult UpdateNotification(UpdateNotificationDTO updateNotificationDTO)
	{
		Notification notification = new Notification()
		{
			NotificationID = updateNotificationDTO.NotificationID,
			Description = updateNotificationDTO.Description,
			Icon = updateNotificationDTO.Icon,
			Status = updateNotificationDTO.Status,
			Type = updateNotificationDTO.Type,
			Date = updateNotificationDTO.Date
		};
		_notificationService.TUpdate(notification);
		return Ok("Güncelleme işlemi başarıyla yapıldı");
	}
	[HttpGet("NotificationStatusChangeToFalse/{id}")]
	public IActionResult NotificationStatusChangeToFalse(int id)
	{
		_notificationService.TNotificationStatusChangeToFalse(id);
		return Ok("Güncelleme yapıldı");
	}
	[HttpGet("NotificationStatusChangeToTrue/{id}")]
	public IActionResult NotificationStatusChangeToTrue(int id)
	{
		_notificationService.TNotificationStatusChangeToTrue(id);
		return Ok("Güncelleme yapıldı");
	}
}
