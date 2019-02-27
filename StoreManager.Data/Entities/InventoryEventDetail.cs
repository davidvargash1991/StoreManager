using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreManager.Data.Entities
{
    public class InventoryEventDetail
    {
        [Required()]
        [Key]
        public int Id { get; set; }
        public int InventoryEventHeaderId { get; set; }
        public int ItemId { get; set; }
        public int Amount { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public Nullable<decimal> UnitValue { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public Nullable<decimal> TaxPercentage { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public Nullable<decimal> TaxValue { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public Nullable<decimal> TotalValue { get; set; }
        public virtual Item Items { get; set; }
        public virtual InventoryEventHeader InventoryEventHeaders { get; set; }
    }
}
