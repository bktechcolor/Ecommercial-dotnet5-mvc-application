using eTickets.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    [Table("Actors")]
    public class Actor:IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Profile Picture is required")]
        [Display(Name = "Profile Picture")]
        public string ProfilePictureURL { get; set; }
        [Required(ErrorMessage = "Full Name is required")]
        [Display(Name = "Full Name")]
        [StringLength(50,MinimumLength =3,ErrorMessage ="Must be between 3 and 50 characters")]
        public string FullName { get; set; }
        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography is required")]
        public string Bio { get; set; }
        //Relationships
        public List<Actor_Movie> Actors_Movie { get; set; }
    }
}
