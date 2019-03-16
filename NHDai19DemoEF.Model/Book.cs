using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHDai19DemoEF.Model
{
   public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookId { get; set; }

        [Required(ErrorMessage = "Required!")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Required!")]
        public string Summary { get; set; }

        [Required(ErrorMessage = "Required!")]
        [DisplayFormat(DataFormatString = "{0:C0}")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Required!")]
        public string ImgUrl { get; set; }

        [Required(ErrorMessage = "Required!")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Required!")]
        [DisplayName("Created Date")]
        public DateTimeOffset CreatedDate { get; set; }

        [Required(ErrorMessage = "Required!")]
        [DisplayName("Modified Date")]
        public DateTimeOffset ModifiedDate { get; set; }

        public bool IsActive { get; set; }

        [Required(ErrorMessage = "Required!")]
        [DisplayName("Author")]
        public int AuthorId { get; set; }
        public virtual Author Author { set; get; }

        [Required(ErrorMessage = "Required!")]
        [DisplayName("Category")]
        public int CategoryId { get; set; }
        public virtual Category Category { set; get; }

        [Required(ErrorMessage = "Required!")]
        [DisplayName("Publisher")]
        public int PublisherId { get; set; }
        public virtual Publisher Publisher { get; set; }
    }
}
