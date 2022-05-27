using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer
{


    [Table("Customer")]
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]                                                           // making Name as not null 
        public string Name { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string EmailID { get; set; }
        

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter Password")]
        [StringLength(maximumLength: 30, MinimumLength = 7, ErrorMessage = "Password should be strong.")]
        public string Password { get; set; }

    }

}
