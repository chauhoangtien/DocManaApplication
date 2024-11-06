using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace Repositories.Model;

public partial class ProfileDocument
{
    public string ProfileId { get; set; } = null!;

    public string DocumentId { get; set; } = null!;

    public virtual Profile Profile { get; set; } = null!;
    public virtual Document Document { get; set; } = null!;
}
