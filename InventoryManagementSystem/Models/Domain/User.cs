﻿using System;
using System.Collections.Generic;

namespace InventoryManagementSystem.Models.Domain;

public partial class User
{
    public int UserId { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;
}
