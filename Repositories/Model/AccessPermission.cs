using System;
using System.Collections.Generic;

namespace Repositories.Model;

public partial class AccessPermission
{
    public int PermissionId { get; set; }

    public string? UserId { get; set; }

    public string? ProfileId { get; set; }

    public string? AccessLevel { get; set; }

    public virtual Profile? Profile { get; set; }

    public virtual User? User { get; set; }
}
