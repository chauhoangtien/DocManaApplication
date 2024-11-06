using System;
using System.Collections.Generic;

namespace Repositories.Model;

public partial class Profile
{
    public string ProfileId { get; set; } = null!;

    public string? ProfileName { get; set; }

    public string? ProjectId { get; set; }

    public string? Description { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<AccessPermission> AccessPermissions { get; set; } = new List<AccessPermission>();

    public virtual ICollection<GroupEmail> GroupEmails { get; set; } = new List<GroupEmail>();

    public virtual Project? Project { get; set; }

    public virtual ICollection<ProfileDocument> ProfileDocuments { get; set; } = new List<ProfileDocument>();

    //public virtual ICollection<Document> Documents { get; set; } = new List<Document>();
}
