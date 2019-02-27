
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreManager.Data.Entities
{
    public class Item
    {
        [Required()]
        [Key]
        public int Id { get; set; }
        [Required()]
        [StringLength(100)]
        public string Name { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal Tax { get; set; }
        public virtual ICollection<InventoryEventDetail> InventoryEventDetails { get; set; }
        public virtual ICollection<Packing> Packings { get; set; }
    }
}
