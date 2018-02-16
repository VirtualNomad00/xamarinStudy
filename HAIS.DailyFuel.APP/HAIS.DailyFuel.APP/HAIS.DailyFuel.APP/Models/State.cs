using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace HAIS.DailyFuel.APP.Models
{
    [Table("State")]
    public class State
    {
        [PrimaryKey]
        public int Id { get; set; }
        public string Name { get; set; }
    }

}
