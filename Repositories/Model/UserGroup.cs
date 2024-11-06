using System;
using System.Collections.Generic;

namespace Repositories.Model;

public partial class UserGroup
{
    public string UserId { get; set; } = null!;

    public string GroupId { get; set; } = null!;

    public string? Role { get; set; }

    public DateTime? JoinedDate { get; set; }

    public virtual Group Group { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
