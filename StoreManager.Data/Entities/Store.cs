using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreManager.Data.Entities
{
    public class Store
    {
        [Required()]
        [Key]
        public int Id { get; set; }
        [Required()]
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(50)]
        public string Address { get; set; }
        public bool IsWarehouse { get; set; }
        [Column(TypeName = "decimal(11, 8)")]
        public Nullable<decimal> Latitude { get; set; }
        [Column(TypeName = "decimal(11, 8)")]
        public Nullable<decimal> Longitude { get; set; }
        public virtual ICollection<InventoryEventHeader> InventoryEventHeaders { get; set; }
    }
}
