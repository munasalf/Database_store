using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorDatabase_3_1.Model
{
      public class User
      {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }


        [Required]
        [MaxLength(50, ErrorMessage = "First Name must be 30 characters or less"), MinLength(4)]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Phone]
        [Required(ErrorMessage = "Phone no. is required")]
        public long PhoneNumber { get; set; }

        public string UserType { get; set; }

        [DataType(DataType.DateTime)]
        public int registrationdate { get; set; }



      }

}
