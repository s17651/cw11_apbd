using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace APBD_c11.Models
{
    public class Prescription_Medicament
    {

        public int IdMedicament { get; set; }
        public int IdPrescription { get; set; }
        [ForeignKey("IdMedicament")]
        public Medicaments Medicament { get; set; }
        [ForeignKey("IdPrescription")]
        public Prescriptions Prescription { get; set; }
        public int? Dose { get; set; }
        [Required]
        [MaxLength(100)]
        public String Details { get; set; }

    }
}
