using System;
using System.Collections.Generic;

namespace Repositories.Model;

public partial class UserDepartment
{
    public string UserId { get; set; } = null!;

    public string DepartmentId { get; set; } = null!;

    public string? Role { get; set; }

    public DateTime? JoinedDate { get; set; }

    public virtual Department Department { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
