using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreManager.Data.Entities
{
    public class InventoryEventHeader
    {
        [Required()]
        [Key]
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int StoreId { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public Nullable<decimal> Value { get; set; }
        public int UserId { get; set; }
        public virtual ICollection<InventoryEventDetail> InventoryEventDetails { get; set; }
        public virtual Store Stores { get; set; }
        public virtual User Users { get; set; }
    }
}
