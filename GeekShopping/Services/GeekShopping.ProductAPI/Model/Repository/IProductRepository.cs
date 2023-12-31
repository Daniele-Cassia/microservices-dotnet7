// using System;
// using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using GeekShopping.ProductAPI.Data.ValueObjects;

namespace GeekShopping.ProductAPI.Repository
{
  public interface IProductRepository
  {
    Task<IEnumerable<ProductVO>> FindAll();
    Task<ProductVO> FindById(long id);
    Task<ProductVO> Create(ProductVO vo);
    Task<ProductVO> Update(ProductVO vo);
    Task<bool> Delete(long id);
  }
}