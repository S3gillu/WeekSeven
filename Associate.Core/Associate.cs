
using System.ComponentModel.DataAnnotations;


namespace Associate.Core
{
    public class AssociateApp
    {

        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public bool MaritalStatus { get; set; }

        [Required]
        public string District { get; set; }
        [Required]
        public string Town { get; set; }

        
        public byte[] Image { get; set; }


    }
}
