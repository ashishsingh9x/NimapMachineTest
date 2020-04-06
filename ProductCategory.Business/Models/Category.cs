using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCategory.Business.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Category Name is required")]
        [StringLength(250, ErrorMessage = "Category Name should be maximum 250 characters")]
        public string Name { get; set; }
        
        public virtual ICollection<Product> Products { get; set; }
    }
}