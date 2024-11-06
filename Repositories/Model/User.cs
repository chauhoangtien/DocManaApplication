using System;
using System.Collections.Generic;

namespace Repositories.Model;

public partial class User
{
    public string UserId { get; set; } = null!;

    public string? Password { get; set; }

    public string? FullName { get; set; }

    public string? Address { get; set; }

    public string? Gender { get; set; }

    public string? Email { get; set; }

    public byte[]? Avatar { get; set; }

    public string? Role { get; set; }

    public string? Status { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<AccessPermission> AccessPermissions { get; set; } = new List<AccessPermission>();

    public virtual ICollection<Department> Departments { get; set; } = new List<Department>();

    public virtual ICollection<Document> Documents { get; set; } = new List<Document>();

    public virtual ICollection<GroupEmail> GroupEmails { get; set; } = new List<GroupEmail>();

    public virtual ICollection<Group> Groups { get; set; } = new List<Group>();

    public virtual ICollection<Project> Projects { get; set; } = new List<Project>();

    public virtual ICollection<UserDepartment> UserDepartments { get; set; } = new List<UserDepartment>();

    public virtual ICollection<UserGroup> UserGroups { get; set; } = new List<UserGroup>();
}
