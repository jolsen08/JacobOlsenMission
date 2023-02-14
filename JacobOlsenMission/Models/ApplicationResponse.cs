using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JacobOlsenMission.Models
{
    /*This model will instantiate each attribute and will create the Sqlite database when migrated*/
    public class ApplicationResponse
    {
        /*Creating the primary key, MovieID, which will autoincrement*/
        [Key]
        [Required]
        public int MovieID { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public short Year { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public string Rating { get; set; }

        /*The remaining attributes are not required*/
        public bool Edited { get; set; }
        public string LentTo { get; set; }
        /*Setting the string max length to 25, even though that is already enforced in the cshtml form.*/
        [StringLength(25)]
        public string Notes { get; set; }
    }
}
