using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace APBD_c11.Models
{
    public class Medicaments
    {

        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdMedicament { get; set; }
        
        [Required]
        [MaxLength(100)]
        public String Name { get; set; }
        [Required]
        [MaxLength(100)]
        public String Description { get; set; }
        [Required]
        [MaxLength(100)]
        public String Type { get; set; }
        public virtual ICollection<Prescription_Medicament> Prescription_Medicament { get; set; }


        public Medicaments()
        {
            Prescription_Medicament = new HashSet<Prescription_Medicament>();
        }

    }
}
