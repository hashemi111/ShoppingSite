using _0_Framework.Application;
 
using System.Collections.Generic;

namespace ShopManagement.Application.Contracts.ProductCategoryApp
{
    public interface IProductCategoryApplication
    {
      
        OprationResult Create(CreateProductCategory command);
     
        OprationResult Edit(EditProductCategory command);
      
        EditProductCategory Select(long id);
      
        
        List<ProductCategoryViewModel> Search(ProductCategorySearchModel searchModel);


    }
}
