using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        //veri erişim işlerini yaoacaj

        //ürüne ait özel işler hoin gibi

        List<ProductDetailDto> GetProductDetailDtos();
    }
}
