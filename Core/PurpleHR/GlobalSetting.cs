using System;
using System.Collections.Generic;

namespace DigiStoreApi.Core.PurpleHR;

public partial class GlobalSetting
{
    public int Id { get; set; }

    public string? SessionTimeOut { get; set; }

    public int? Status { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }
}
