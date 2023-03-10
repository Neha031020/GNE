using System;
using System.Collections.Generic;

namespace Api;

public partial class ReceiverAttachment
{
    public int Id { get; set; }

    public string AttachmentTitle { get; set; } = null!;

    public string AttachmentPath { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }
}
