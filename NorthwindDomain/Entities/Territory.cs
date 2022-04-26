﻿using NorthwindDomain.AutoGen;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NorthwindDomain.AutoGen
{
    [Keyless]
    public partial class Territory
    {
        [Column("TerritoryID", TypeName = "nvarchar")]
        public string TerritoryId { get; set; } = null!;
        [Column(TypeName = "nchar")]
        public string TerritoryDescription { get; set; } = null!;
        [Column("RegionID", TypeName = "int")]
        public long RegionId { get; set; }
    }
}
