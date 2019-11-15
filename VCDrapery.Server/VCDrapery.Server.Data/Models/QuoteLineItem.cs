using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace VCDrapery.Server.Data.Models
{
    [Table("QuoteLineItems")]
    public class QuoteLineItem
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("QuoteId")]
        public int QuoteId { get; set; }
        public string Room { get; set; }
        public string FabricType { get; set; }
        public string FabricColor { get; set; }
        public decimal FabricFabFmg { get; set; }
        public string FabricCurtainType { get; set; }
        public decimal FabricLength { get; set; }
        public decimal FabricFullness { get; set; }
        public decimal RodSize { get; set; }
        public decimal Return { get; set; }
        public decimal Widths { get; set; }
        public decimal Yards { get; set; }
        public decimal WidthsLab { get; set; }
        public string RodType { get; set; }
        public decimal RodPrice { get; set; }
        public decimal FabricPrice { get; set; }
        public decimal LaborPrice { get; set; }
        public decimal PriceBeforeTax { get; set; }
        public decimal Tax { get; set; }
        public decimal TotalPrice { get; set; }
        public string Comments { get; set; }
        public DateTime DateAdded { get; set; }

        public virtual Quote Quote { get; set; }


        public bool IsNew() => QuoteId == 0 ? true : false;
    }
}
