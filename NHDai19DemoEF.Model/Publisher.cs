using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NHDai19DemoEF.Model
{
    public class Publisher
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PublisherId { set; get; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Publisher Name")]
        public string PublisherName { set; get; }
        [StringLength(1000)]
        public string Description { get; set; }
        public  ICollection<Book> Books { set; get; }
    }
}