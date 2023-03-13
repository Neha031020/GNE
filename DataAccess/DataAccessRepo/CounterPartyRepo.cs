using DataAccess.Entity;
using DataAccess.Context;

using DataAccess.IDataAcces;
using Microsoft.EntityFrameworkCore;

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
            try
            {
                var exisitingData = await _Context.CounterParties.Where(x => x.PartyName == counterParty.PartyName).FirstOrDefaultAsync();
                if (exisitingData != null)
                {
                    exisitingData.Status = counterParty.Status;

                    await _Context.SaveChangesAsync();
                    return ("Update Successfully.....:)");
                }
                var NewcounterParty = (new CounterParty
                {
                    PartyName = counterParty.PartyName,
                    Status = counterParty.Status,

                });
                await _Context.CounterParties.AddAsync(NewcounterParty);
                await _Context.SaveChangesAsync();
                return ("Added Succesfully......:)");
            }
            catch (Exception)
            {

                throw;
            }


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
