using System;
using System.Collections.Generic;

namespace Repositories.Model;

public partial class GroupEmail
{
    public string EmailId { get; set; } = null!;

    public string? SenderId { get; set; }

    public string? ProfileId { get; set; }

    public string? Recipients { get; set; }

    public string? Cclist { get; set; }

    public string? Subject { get; set; }

    public string? Body { get; set; }

    public DateTime? SendDate { get; set; }

    public virtual Profile? Profile { get; set; }

    public virtual User? Sender { get; set; }
}
