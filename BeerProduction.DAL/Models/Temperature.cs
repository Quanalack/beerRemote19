using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeerProduction.DAL.Models
{
    public class Temperature
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
