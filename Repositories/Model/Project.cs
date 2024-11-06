using System;
using System.Collections.Generic;

namespace Repositories.Model;

public partial class Project
{
    public string ProjectId { get; set; } = null!;

    public string? ProjectName { get; set; }

    public string? Description { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? Status { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual User? CreatedByNavigation { get; set; }

    public virtual ICollection<Document> Documents { get; set; } = new List<Document>();

    public virtual ICollection<Profile> Profiles { get; set; } = new List<Profile>();

    public virtual ICollection<ProjectDepartment> ProjectDepartments { get; set; } = new List<ProjectDepartment>();

    public virtual ICollection<ProjectGroup> ProjectGroups { get; set; } = new List<ProjectGroup>();

    //public virtual ICollection<Department> Departments { get; set; } = new List<Department>();

    //public virtual ICollection<Group> Groups { get; set; } = new List<Group>();
}
