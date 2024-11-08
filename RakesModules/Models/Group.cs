﻿using System;
using System.Collections.Generic;

namespace RakesModules.Models;

public partial class Group
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
