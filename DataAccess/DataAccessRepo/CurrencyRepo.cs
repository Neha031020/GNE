using DataAccess.Context;
using DataAccess.Entity;
using DataAccess.IDataAcces;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.DataAccessRepo
{
    public class CurrencyRepo : ICurrency
    {
        private readonly GneProjectContext _Context;
        public CurrencyRepo(GneProjectContext context)
        {
            _Context = context;    
        }
        public async Task<string> AddOrUpdateCurrency(Currency currency)
        {
            try
            {
            var CurrencyData=await _Context.Currencies.Where(x=>x.CurrencyCode==currency.CurrencyCode).FirstOrDefaultAsync();
                if (CurrencyData != null)
                {
                    CurrencyData.CurrencyName = currency.CurrencyName;
                    await _Context.SaveChangesAsync();
                   return ("Updated Successfully.....:)");
                }
                _Context.Currencies.Add(new Currency
                {
                    CurrencyCode = currency.CurrencyCode,
                    CurrencyName = currency.CurrencyName,
                    Symbol = currency.Symbol,

                });
                await _Context.SaveChangesAsync();
                return ("Added Succesfully......:)");
            }
            catch (Exception)
            {

                throw;
            }

        }

        public async Task<string> DeleteCurrencyById(int id)
        {
            try
            {
                var CurrencyById=await _Context.Currencies.Where(x=>x.CurrencyId==id).FirstOrDefaultAsync();
                if (CurrencyById == null)
                    return ("Currency Not Found");
                 _Context.RemoveRange(CurrencyById);
                _Context.SaveChanges();
                return ("Delete Succesfully......:)");
            }
            catch (Exception)
            {

                throw;
            }
        }

       
       public async Task<List<Currency>>GetAllCurrency()
        {
            try
            {
                var ListCurrency = await _Context.Currencies.ToListAsync();
                return ListCurrency;
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
