using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NHDai19DemoEF.Model
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Author Name")]
        public string AuthorName { get; set; }

        [StringLength(1000)]
        public string History { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}