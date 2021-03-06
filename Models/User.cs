using System.ComponentModel.DataAnnotations;

namespace secfromscratch.Models
{
    public class User
    {
        public int Id {get; set;}

        [Required]
        public string UserName {get; set;}

        [Required]
        [DataType(DataType.Password)]
        public string Password {get; set;}
    }
}