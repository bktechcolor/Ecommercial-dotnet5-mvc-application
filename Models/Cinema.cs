using eTickets.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    [Table("Cinemas")]
    public class Cinema:IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Logo is required")]
        [Display(Name = "Logo")]
        public string Logo { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Name")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Must be between 3 and 50 characters")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Description is required")]
        [Display(Name = "Description")]
        public string Description { get; set; }
        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
