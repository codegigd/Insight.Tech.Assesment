using AutoMapper;
using Insight.Product.WebApi.DBModel;

namespace Insight.Product.WebApi.ViewModel
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Products, ProductModel>();
        }
    }
}
