using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SiteRando.Models
{
    [Table("Hike")]
    public class Hike 
    {
        public Hike( string title, int distance, int time, int elevation, int difficult, string startDetails, string endDetails, string details, string map)
        {
            Title = title;
            Distance = distance;
            Time = time;
            Elevation = elevation;
            Difficult = difficult;
            StartDetails = startDetails;
            EndDetails = endDetails;
            Details = details;
            Map = map;
        }

        public int Id { get; set; }
        [Required]
        public string Title { get; set; }

        [Required]
        //In meters
        public int Distance { get; set; }

        [Required]
        //In minutes
        public int Time { get; set; }

        [Required]
        //In meters
        public int Elevation { get; set; }

        [Required]
        public int Difficult { get; set; }

        [Required]
        public string StartDetails { get; set; }

        [Required]
        public string EndDetails { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Details { get; set; }

        [Required]
        public string Map { get; set; }
        public override string ToString()
        {
            return Title.ToString();
        }
    }
   
}
