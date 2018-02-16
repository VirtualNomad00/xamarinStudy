using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace HAIS.DailyFuel.APP.Models
{
    [Table("AverageFuelPrice")]
    public class AverageFuelPrice
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Type { get; set; }
        public float Price { get; set; }
        public DateTime UpdatedOn { get; set; }
        public float Change { get; set; }
        [ForeignKey(typeof(City))]
        public int CityId { get; set; }

    }
}
