using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace HAIS.DailyFuel.APP.Models
{
    [Table("City")]
    public class City
    {
        [PrimaryKey]
        public int Id { get; set; }
        public string Name { get; set; }
        public int StateId { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }

}
