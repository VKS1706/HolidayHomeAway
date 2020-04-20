using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolidayHomeAway.Models
{
    public interface IAccomRepo
    {
        IEnumerable<Accom> AllAccom { get; }
        Accom GetByAccomId(int accomId);

        void CreateAccom(Accom accom);

        void UpdateAccom(Accom accom);
    }
}
