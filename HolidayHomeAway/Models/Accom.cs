using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolidayHomeAway.Models
{
    public enum AvailabilityType
    {
        High,
        Medium,
        Low
    };
    public class Accom
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public decimal Price { get; set; }
        public AvailabilityType AvailabilityType { get; set; }
        public string ImageUrl { get; set; }
        public int AccomTypeId { get; set; }
        public Type AccomType { get; set; }
        public string Notes { get; set; }

        
    }
}
