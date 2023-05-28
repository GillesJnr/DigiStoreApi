using System;
using System.Collections.Generic;

namespace DigiStoreApi.Core.PurpleHR;

public partial class UserMessage
{
    public Guid MessageId { get; set; }

    public string? MessageTitle { get; set; }

    public string? MessageDetails { get; set; }

    public string? MessageOwner { get; set; }

    public string? MessageFrom { get; set; }

    public string? MessageStatus { get; set; }

    public DateTime? EntryDate { get; set; }

    public DateTime? SeenDate { get; set; }
}
