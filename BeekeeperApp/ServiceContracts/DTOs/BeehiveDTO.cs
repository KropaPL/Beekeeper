using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceContracts.DTOs
{
    public class BeehiveDto
    {
        [Required(ErrorMessage = "Model can't be blank")]
        public string? Model { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage ="Production Date can't be blank")]
        public DateTime? ProductionDate { get; set; }

        [Required(ErrorMessage ="Description can't be blank")]
        public string? Desc { get; set; }

        [Required(ErrorMessage ="Price can't be blank")]
        [Range(1,9000)]
        public decimal Price { get; set; }
    }
}
