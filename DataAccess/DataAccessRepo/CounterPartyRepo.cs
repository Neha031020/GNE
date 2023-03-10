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
    
    public class CounterPartyRepo : ICounterParty
    {
        private readonly GneProjectContext _Context;
        public CounterPartyRepo(GneProjectContext context)
        {
            _Context = context;
        }
        public async Task<string> EditOrApproveCounterParty(CounterParty counterParty)
        {
           var exisitingData=await _Context.CounterParties.Where(x=>x.CounterPartyId==counterParty.CounterPartyId).FirstOrDefaultAsync();
            if (exisitingData==null) 
            { 
                return ("Party Not Found");
            }
            exisitingData.PartyName = counterParty.PartyName;
            exisitingData.Status = counterParty.Status;
            await _Context.SaveChangesAsync();
            return ("Update Successfully.....:)");


        }

        public async Task<List<CounterParty>> GetListOfCounter()
        {
            try
            {
                var ListCounterParty = await _Context.CounterParties.ToListAsync();
                return ListCounterParty;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
