using AutoMapper;
using ECOMM.Common.Models.Product;
using ECOMM.Persistence.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECOMM.Persistence.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //Product models mapping
            CreateMap<Product, ProductListModel>();
            CreateMap<ProductCreateModel, Product>();
        }
    }
}
