﻿namespace DefaultNamespace;

public class Users
{
    [Key]
    public int id { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
}