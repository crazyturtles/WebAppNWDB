﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region Additional Namespaces
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
#endregion
namespace NWSystem.ENTITIES
{
    [Table("Region")]
    public class Region
    {
        public int RegionID { get; set; }
        public string RegionDescription { get; set; }
    }
}
