using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace HAIS.DailyFuel.APP.Models
{
    [Table("FuelStation")]
    public class FuelStation
    {
        [PrimaryKey]
        public int Id { get; set; }
        public string Name { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int CityId { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<StationFuelDetail> FuelDetail { get; set; }
    }
}
