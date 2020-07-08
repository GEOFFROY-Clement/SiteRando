using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SiteRando.Models
{
    public class Hike
    {   
        
        private int id;
        [Required]
        private string Title;
        [Required]
        private int Distance;
        [Required]
        private int Time;
        [Required]
        private int Elevation;
        [Required]
        private int Difficult;


        [Required]
        private string Startdetails;
        [Required]
        private string Enddetails;


        [Required]
        [DataType(DataType.Text)]
        string Details;


        [Required]
        string Map;

        public int Id { get => id; set => id = value; }
        public string Title1 { get => Title; set => Title = value; }
        public int Distance1 { get => Distance; set => Distance = value; }
        public int Time1 { get => Time; set => Time = value; }
        public int Elevation1 { get => Elevation; set => Elevation = value; }
        public int Difficult1 { get => Difficult; set => Difficult = value; }
        public string Startdetails1 { get => Startdetails; set => Startdetails = value; }
        public string Enddetails1 { get => Enddetails; set => Enddetails = value; }
        public string Details1 { get => Details; set => Details = value; }
        public string Map1 { get => Map; set => Map = value; }
    }
}
