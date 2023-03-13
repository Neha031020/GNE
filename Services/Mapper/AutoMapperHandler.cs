using AutoMapper;
using DataAccess.Entity;
using Services.DTOClass;

namespace Services.Mapper
{
    public class AutoMapperHandler:Profile
    {
        public AutoMapperHandler()
        {
            CreateMap<Currency, CurrencyDTO>().ReverseMap();
            CreateMap<Category, CategoryTypeDTO>().ReverseMap();
            CreateMap<CounterParty, CounterPartyDTO>().ReverseMap();
            CreateMap<User,UserDTO>().ReverseMap();
        }
    }
}
