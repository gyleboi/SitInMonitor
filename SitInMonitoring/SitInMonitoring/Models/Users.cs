using System.ComponentModel.DataAnnotations;

namespace SitInMonitoring.Models
{
    public class Users
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Student Id Number")]
        public string StudentId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        [Required]
        [Display(Name ="Username")]
        public string UserName { get; set; }
        
        [DataType(DataType.Password)]
        public string Password { get; set; }



    }
}
