using System;
using System.Collections.Generic;

namespace RakesModules.Models;

public partial class User
{
    public int Id { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public int? GroupId { get; set; }

    public virtual Group? Group { get; set; }
}
