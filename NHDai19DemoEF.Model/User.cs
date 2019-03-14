using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHDai19DemoEF.Model
{
    public class User
    {
        [Key]
        [StringLength(50)]
        public string Username { get; set; }
        [Required]
        [StringLength(100)]
        public string Password { get; set; }
        [Required]
        [StringLength(100)]
        public string Email { get; set; }
        public int Role { get; set; }
        public bool IsActive { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
