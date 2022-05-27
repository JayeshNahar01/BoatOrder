using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer
{
    [Table("BoatDetails")]
    public class BoatDetails
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public  string BoatName { get; set; }

        // specifying the format of date
        public string BoatImage { get; set; }

        [Required]
        public string HourlyRate { get; set; }


        public int UserID { get; set; }

        public virtual Users Users { get; set; }
    }

}
