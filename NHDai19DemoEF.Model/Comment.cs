using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHDai19DemoEF.Model
{
    public class Comment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CommentId { get; set; }
        [Required]
        [StringLength(500)]
        public string Content { get; set; }
        [Display(Name = "Created Date")]
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }

        [Required]
        public int BookId { get; set; }
        public virtual Book Book { get; set; }
    }
}
