﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace modpack.Models;

public partial class Administrator
{
    public int AdministratorId { get; set; }

    public int TitleId { get; set; }

    public string AdminCode { get; set; }

    public string Name { get; set; }

    public string Image { get; set; }

    public string Account { get; set; }

    public string Password { get; set; }

    public virtual ICollection<AdministratorActivitylog> AdministratorActivitylogs { get; set; } = new List<AdministratorActivitylog>();

    public virtual ICollection<AdministratorModification> AdministratorModificationAdministrators { get; set; } = new List<AdministratorModification>();

    public virtual ICollection<AdministratorModification> AdministratorModificationModifiers { get; set; } = new List<AdministratorModification>();

    public virtual ICollection<ServiceRecord> ServiceRecords { get; set; } = new List<ServiceRecord>();

    public virtual AdministratorTitle Title { get; set; }
}