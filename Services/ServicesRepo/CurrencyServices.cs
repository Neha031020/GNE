using AutoMapper;
using DataAccess.Entity;
using DataAccess.IDataAcces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Services.DTOClass;
using Services.ServicesInterface;

namespace Services.ServicesRepo
{

    public class CurrencyServices : ICurrencServices

    {
        private readonly ICurrency _currency;
        private IMapper _mapper;
        public CurrencyServices(ICurrency currency,IMapper mapper)
        {
            _currency = currency;
            _mapper = mapper;
        }

        public  async Task<string> AddOrUpdateCurrency(CurrencyDTO currencyDTO)
        {
            var DtoToUser = _mapper.Map<CurrencyDTO, Currency>(currencyDTO);

            var CurrencyData = await _currency.AddOrUpdateCurrency(DtoToUser);
            return CurrencyData;

           
        }

        public async Task<string> DeleteCurrencyById(int id)
        {
           var CurrencyById=await _currency.DeleteCurrencyById(id);
            return CurrencyById;
        }

        public async Task<List<CurrencyDTO>> GetAllCurrencyList()
        {
            var ListOfCurrency =await _currency.GetAllCurrency();
            var DtoToClass = _mapper.Map<List<Currency>, List<CurrencyDTO>>(ListOfCurrency);
            return DtoToClass;
        }
    }
}
