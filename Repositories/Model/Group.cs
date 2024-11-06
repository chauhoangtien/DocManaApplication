using System;
using System.Collections.Generic;

namespace Repositories.Model;

public partial class Group
{
    public string GroupId { get; set; } = null!;

    public string? GroupName { get; set; }

    public string? DepartmentId { get; set; }

    public string? LeaderId { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual Department? Department { get; set; }

    public virtual User? Leader { get; set; }

    public virtual ICollection<UserGroup> UserGroups { get; set; } = new List<UserGroup>();

    public virtual ICollection<ProjectGroup> ProjectGroups { get; set; } = new List<ProjectGroup>();
    //public virtual ICollection<Project> Projects { get; set; } = new List<Project>();
}
