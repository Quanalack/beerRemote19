using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerProduction.DAL.Models
{
    public class MachineSpeed
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public float Value { get; set; }
        public DateTime DateTime { get; set; }
        public int BatchReportId { get; set; }
        public BatchReport BatchReport { get; set; }

    }
}
