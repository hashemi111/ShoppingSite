using _0_Framework.Application;
using ShopManagement.Application.Contracts.ProductCategoryApp;
using ShopManagement.Domain.ProductCategoryAgg;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopManegement.Application
{
    public class ProductCategoryApplication : IProductCategoryApplication

    {
        readonly private IProductCategoryRepository _productCategoryRepository;

        public ProductCategoryApplication(IProductCategoryRepository productCategoryRepository)
        {
            _productCategoryRepository = productCategoryRepository;
        }

        public OprationResult Create(CreateProductCategory command)
        {
           
            var operationResult = new OprationResult();
            if (_productCategoryRepository.Exists(x=>x.Name==command.Name))
                return operationResult.Failed("رکورد تکراری است");
            var slug = command.Slug.Slugify();
            var productCategory = new ProductCategory(command.Name, command.Description
                , command.Picture, command.PictureALt, command.PictureTitle, command.Keywords,
                command.MetaDescription,slug);
            _productCategoryRepository.Create(productCategory);
            _productCategoryRepository.SaveChanege();
            return operationResult.Succeeded();

        }

        public OprationResult Edit(EditProductCategory command)
        {
            var operationResult = new OprationResult();
           
            var productCategory = _productCategoryRepository.Get(command.Id);
            if (productCategory == null)
            
                return operationResult.Failed("چنین رکوردی یافت نشد!");

             
             
            if (_productCategoryRepository.Exists
                (x => x.Name == command.Name && x.Id != command.Id))

            
                return operationResult.Failed("ثبت یوزر تکراری ممکن نیست !");


             
            var slug = command.Slug.Slugify();
            
            productCategory.Edit(command.Name, command.Description
                , command.Picture, command.PictureALt, command.PictureTitle, command.Keywords,
                command.MetaDescription, slug);
           
            
            _productCategoryRepository.SaveChanege();
            return operationResult.Succeeded();
        }

        public List<ProductCategoryViewModel> Search(ProductCategorySearchModel searchModel)
        {
            return _productCategoryRepository.Search(searchModel);
        }

        public EditProductCategory Select(long id)
        {
            return _productCategoryRepository.GetDetails(id);
        }

        
    }
}
