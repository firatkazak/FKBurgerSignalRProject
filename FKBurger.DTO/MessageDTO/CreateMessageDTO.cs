﻿namespace FKBurger.DTO.MessageDTO;
public class CreateMessageDTO
{
    public string NameSurname { get; set; }
    public string Mail { get; set; }
    public string Phone { get; set; }
    public string Subject { get; set; }
    public string MessageContent { get; set; }
    public DateTime MessageSendDate { get; set; }
    public bool Status { get; set; }
}
