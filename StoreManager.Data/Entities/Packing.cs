using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StoreManager.Data.Entities
{
    public class Packing
    {
        [Required()]
        [Key]
        public int Id { get; set; }
        [Required()]
        [StringLength(20)]
        public string Label { get; set; }
        public int Factor { get; set; }
        public int ItemId { get; set; }
        public virtual Item Items { get; set; }
    }
}
