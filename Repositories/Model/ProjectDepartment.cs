using System;
using System.Collections.Generic;

namespace Repositories.Model;

public partial class ProjectDepartment
{
    public string ProjectId { get; set; } = null!;

    public string DepartmentId { get; set; } = null!;

    public virtual Project Project { get; set; } = null!;

    public virtual Department Department { get; set; } = null!;
}
