using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace HolidayHomeAway.Models
{ 
    public class AccomRepo : IAccomRepo
    {
        private readonly AppDbContext _appDbContext;

        public AccomRepo(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Accom> AllAccom
        {
            get { return _appDbContext.Accoms.Include(a => a.AccomType); }
        }
        public Accom GetByAccomId(int accomId)
        {
            return _appDbContext.Accoms.FirstOrDefault(a => a.Id == accomId);
        }

        public void UpdateAccom(Accom accom)
        {
            
            _appDbContext.Accoms.Update(accom);
            _appDbContext.SaveChanges();
        }

        public void CreateAccom(Accom accom)
        {
            _appDbContext.Accoms.Add(accom);
            _appDbContext.SaveChanges();
        }
    }
}
