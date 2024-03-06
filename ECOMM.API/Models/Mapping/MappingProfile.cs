using AutoMapper;
using ECOMM.API.Models.Account;
using ECOMM.API.Models.Product;
using ECOMM.Common.Models.Account;
using ECOMM.Common.Models.Product;

namespace ECOMM.API.Models.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            //Account models mapping
            CreateMap<LoginViewModel, LoginModel>();
            CreateMap<RegisterViewModel, RegisterModel>();

            //Product models mapping
            CreateMap<ProductListModel, ProductListViewModel>();
            CreateMap<ProductCreateViewModel, ProductCreateModel>();
        }
    }
}
