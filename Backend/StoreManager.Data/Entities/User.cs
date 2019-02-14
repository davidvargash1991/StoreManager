using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StoreManager.Data.Entities
{
    public class User
    {
        public User()
        {
            this.Active = true;
            this.Locked = false;
            this.LoginAttempts = 0;
        }

        [Required()]
        [Key]
        public int Id { get; set; }
        [Required()]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required()]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required()]
        [StringLength(15)]
        public string Username { get; set; }
        public bool Active { get; set; }
        public bool Locked { get; set; }
        public Nullable<DateTime> DateUnlock { get; set; }
        public int LoginAttempts { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
}
