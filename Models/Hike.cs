using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SiteRando.Models
{
    public class Hike
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }

        [Required]
        public int Distance { get; set; }

        [Required]
        public int Time { get; set; }

        [Required]
        public int Elevation { get; set; }

        [Required]
        public int Difficult { get; set; }

        [Required]
        public string Startdetails { get; set; }

        [Required]
        public string Enddetails { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Details { get; set; }

        [Required]
        public string Map { get; set; }
    }
}
