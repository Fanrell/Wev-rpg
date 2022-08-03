﻿namespace RPG.Models;

public class BaseEntity
{
    public Guid Id { get; set; }
    public DateTime AddedDate { get; set; }
    public DateTime ModifiedDate { get; set; }
}