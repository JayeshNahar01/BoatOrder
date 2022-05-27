using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer
{

    
    [Table("User")]                                                      // creating table Customer in db
    public class Users
    {
        [Key]                                                                // making ID as primary key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]                // making ID as auto-incrementing by 1
        public int ID { get; set; }

        [Required]                                                           // making Name as not null 
        public string Name { get; set; } 


        [Required]
        
        [EmailAddress(ErrorMessage = "Invalid Email Address")]               // validating the EmailID
        public string EmailID { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter Password")]
        [StringLength(maximumLength: 30, MinimumLength = 7, ErrorMessage = "Password should be strong.")]
        public string Password { get; set; }

        [Required]
        public string PhoneNo { get; set; }

        public string Address { get; set; }

        [Required]
        public string City { get; set; }

        public virtual ICollection<BoatDetails> Orders { get; set; }              // foreign key property
    }
}
