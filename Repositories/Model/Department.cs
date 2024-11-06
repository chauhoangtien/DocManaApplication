using System;
using System.Collections.Generic;

namespace Repositories.Model;

public partial class Department
{
    public string DepartmentId { get; set; } = null!;

    public string? DepartmentName { get; set; }

    public string? ManagerId { get; set; }

    public string? Description { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<Group> Groups { get; set; } = new List<Group>();

    public virtual User? Manager { get; set; }

    public virtual ICollection<UserDepartment> UserDepartments { get; set; } = new List<UserDepartment>();

    public virtual ICollection<ProjectDepartment> ProjectDepartments { get; set; } = new List<ProjectDepartment>();

    //public virtual ICollection<Project> Projects { get; set; } = new List<Project>();
}
