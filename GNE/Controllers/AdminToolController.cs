using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.DTOClass;
using Services.ServicesInterface;
using Services.ServicesRepo;

namespace Api.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class AdminToolController : ControllerBase
    {
        private readonly ICurrencServices _currency;
        private readonly ICategoryTypeServices _categoryType;
        private readonly ICounterPartyServices _counterParty;
        private readonly IThresholdServices _threshold;
        public AdminToolController(ICurrencServices currency, ICategoryTypeServices categoryType, ICounterPartyServices counterParty, IThresholdServices threshold)
        {
            _currency = currency;
            _categoryType = categoryType;
            _counterParty = counterParty;
            _threshold = threshold;
        }
        [HttpGet]
        public async Task<IActionResult> Currencies()
        {
            var ListOfCurrency=await _currency.GetAllCurrencyList();
          return Ok(ListOfCurrency);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteCurrencyById(int id)
        {
            var DataById=await _currency.DeleteCurrencyById(id);
            return Ok(DataById);
        }
        [HttpPut]
        public async Task<IActionResult> AddOrUpdateCurrency(CurrencyDTO currencyDTO)
        {
            var data=await _currency.AddOrUpdateCurrency(currencyDTO);
            return Ok(data);
        }

        [HttpGet]
        public async Task<IActionResult> CategoryTypes()
        {
            var ListOfCategory = await _categoryType.GetAllCategoryList();
            return Ok(ListOfCategory);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteCategoryById(int id)
        {
            var DataById = await _categoryType.DeleteCategoryById(id);
            return Ok(DataById);
        }
        [HttpPut]
        public async Task<IActionResult> AddOrUpdateCategory(CategoryTypeDTO categoryDTO)
        {
            var data = await _categoryType.AddOrUpdateCategory(categoryDTO);
            return Ok(data);
        }
        [HttpGet]
        public async Task<IActionResult> CounterParties()
        {
            var ListOfCounterParty = await _counterParty.GetListOfParty();
            return Ok(ListOfCounterParty);
        }

        [HttpPut]
        public async Task<IActionResult> CounterPartyEdit(CounterPartyDTO counterPartyDTO)
        {
            var data = await _counterParty.CounterPartyEdit(counterPartyDTO);
            return Ok(data);
        }


        [HttpGet]
        public async Task<IActionResult> Thresholds()
        {
            var ListOfThreshold=await _threshold.GetListOfThreshold();
            return Ok(ListOfThreshold);
        }
    }


   

}
