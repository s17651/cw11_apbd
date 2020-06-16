using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace APBD_c11.Models
{
    public class Doctor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdDoctor { get; set; }
        [Required]
        [MaxLength(100)]
        public String FirstName { get; set; }
        [Required]
        [MaxLength(100)]
        public String LastName { get; set; }
        [Required]
        [MaxLength(100)]
        public String Email { get; set; }

        public ICollection<Prescriptions> Prescriptions { get; set; }

        public Doctor()
        {
            Prescriptions = new HashSet<Prescriptions>();
        }

    }
}
