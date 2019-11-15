using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace VCDrapery.Server.Data.Models
{
    [Table("Fabric")] 
    public class Fabric
    {
        string FabricType { get; set; }
        string Color { get; set; }
        string CurtainType { get; set; }
    }
}
