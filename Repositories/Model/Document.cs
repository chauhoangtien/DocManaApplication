using System;
using System.Collections.Generic;

namespace Repositories.Model;

public partial class Document
{
    public string DocumentId { get; set; } = null!;

    public string? DocumentName { get; set; }

    public string? ProjectId { get; set; }

    public string? Version { get; set; }

    public string? Status { get; set; }

    public string? SubmittedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? FilePath { get; set; }

    public virtual Project? Project { get; set; }

    public virtual User? SubmittedByNavigation { get; set; }

    public virtual ICollection<ProfileDocument> ProfileDocuments { get; set; } = new List<ProfileDocument>();

    //public virtual ICollection<Profile> Profiles { get; set; } = new List<Profile>();
}
