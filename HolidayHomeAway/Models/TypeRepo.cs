using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolidayHomeAway.Models
{
    public class TypeRepo :ITypeRepo
    {
        private readonly AppDbContext _appDbContext;

        public TypeRepo(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Type> Types => _appDbContext.Types;
    }
}
