using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace HAIS.DailyFuel.APP.Models
{
    [Table("StationFuelDetail")]
    public class StationFuelDetail
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Type { get; set; }
        public float Price { get; set; }
        public DateTime UpdatedOn { get; set; }
        [ForeignKey(typeof(FuelStation))]
        public int StationId { get; set; }

        [ManyToOne(CascadeOperations = CascadeOperation.CascadeRead)]
        public FuelStation FuelStation { get; set; }

    }
}
