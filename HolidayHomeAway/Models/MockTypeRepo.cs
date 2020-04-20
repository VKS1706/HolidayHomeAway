using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolidayHomeAway.Models
{
    public class MockTypeRepo:ITypeRepo
    {
        public IEnumerable<Type> Types =>
        new List<Type>
        {
            new Type{Id = 1, Name = "Static Caravan", Description = "This is a static caravan"},
            new Type{Id = 2, Name = "Lodge", Description = "This is a lodge"}
        };
    }
}
