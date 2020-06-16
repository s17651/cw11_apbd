using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace APBD_c11.Models
{
    public class Prescriptions
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPrescription { get; set; }
        [Required]
        public DateTime Birthdate { get; set; }
        [Required]
        public DateTime DueDate { get; set; }
        [Required]
        public int IdDoctor { get; set;  }
        [ForeignKey("IdDoctor")]
        public virtual Doctor Doctor { get; set; }
        [Required]
        public int IdPatient { get; set; }
        [ForeignKey("IdPatient")]
        public virtual Patient Patient { get; set; }
        public virtual ICollection<Prescription_Medicament> Prescription_Medicaments { get; set; }

        public Prescriptions() 
        {
            Prescription_Medicaments = new HashSet<Prescription_Medicament>();
        }


    }
}
