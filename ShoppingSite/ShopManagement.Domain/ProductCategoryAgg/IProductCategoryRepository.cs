using _0_Framework.Domain;
using ShopManagement.Application.Contracts.ProductCategoryApp;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ShopManagement.Domain.ProductCategoryAgg
{
    public  interface IProductCategoryRepository :IRepository<long,ProductCategory>
    {

       // void Create(ProductCategory entity);
        
      // ProductCategory Select(long Id);
       EditProductCategory GetDetails(long Id);
      //  List<ProductCategory> Get();

      //  bool Exists(Expression<Func<ProductCategory , bool>> expression );

       
       // void SaveChanges();
        List<ProductCategoryViewModel> Search(ProductCategorySearchModel searchModel);
    }
}
