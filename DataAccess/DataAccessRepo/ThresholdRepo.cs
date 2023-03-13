using DataAccess.Context;
using DataAccess.Entity;
using DataAccess.IDataAcces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DataAccessRepo
{
    public class ThresholdRepo : IThreshold
    {
        private readonly GneProjectContext _context;
        public ThresholdRepo(GneProjectContext context)
        {
            _context = context;
        }
        public async Task<List<Threshold>> GetAllThresholdList()
        {
            try
            {
                var ListOfThreshold=await _context.Thresholds.ToListAsync();
                return ListOfThreshold;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
