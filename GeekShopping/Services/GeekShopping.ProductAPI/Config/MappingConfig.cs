using AutoMapper;
using GeekShopping.ProductAPI.Model;
using GeekShopping.ProductAPI.Data.ValueObjects;


namespace GeekShopping.ProductAPI.Config
{
  public class MappingConfig
  {
    public static MapperConfiguration RegisterMaps()
    {
      var mappingCOnfig = new MapperConfiguration(config =>
      {
        config.CreateMap<ProductVO, Product>();
        config.CreateMap<Product, ProductVO>();
      });
      return mappingCOnfig;
    }
  }
}