using System;
using System.Collections.Generic;

namespace Repositories.Model;

public partial class ProjectGroup
{
    public string ProjectId { get; set; } = null!;

    public string GroupId { get; set; } = null!;

    public virtual Project Project { get; set; } = null!;

    public virtual Group Group { get; set; } = null!;
}
