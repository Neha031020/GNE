using AutoMapper;
using DataAccess.Entity;
using DataAccess.IDataAcces;
using Services.DTOClass;
using Services.ServicesInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ServicesRepo
{
    public class CounterPartyServices : ICounterPartyServices
    {
        private readonly ICounterParty _counterParty; 
        private IMapper _mapper;
        public CounterPartyServices(ICounterParty counterParty,IMapper mapper)
        {
            _counterParty = counterParty;
            _mapper = mapper;
        }
        public async Task<string> CounterPartyEdit(CounterPartyDTO counterPartyDTO)
        {
            //var DtoToUser = _mapper.Map<CategoryTypeDTO, Category>(categoryDTO);
            var DtoToUser = _mapper.Map<CounterPartyDTO, CounterParty>(counterPartyDTO);
            var DataCounter = await _counterParty.EditOrApproveCounterParty(DtoToUser);
            return DataCounter;
        }

        public async Task<List<CounterPartyDTO>> GetListOfParty()
        {
            var ListOfCounter = await _counterParty.GetListOfCounter();
            var DtoToClass = _mapper.Map<List<CounterParty>, List<CounterPartyDTO>>(ListOfCounter);
            return DtoToClass;
        }
    }
}
