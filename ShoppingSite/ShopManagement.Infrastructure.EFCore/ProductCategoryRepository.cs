using _0_Framework.Infrastructure;
using ShopManagement.Application.Contracts.ProductCategoryApp;
using ShopManagement.Domain.ProductCategoryAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ShopManagement.Infrastructure.EFCore
{
    public class ProductCategoryRepository :RepositoryBase<long,ProductCategory>, IProductCategoryRepository
    {

        private readonly ShopContext _context;

        public ProductCategoryRepository(ShopContext context): base(context)
        {
            _context = context;
        }

       

        

       
        

        public EditProductCategory GetDetails(long Id)
        {
            return _context.ProductCategories.Select(x => new EditProductCategory()
            {
                Id=x.Id,
                Name=x.Name,
                Description=x.Description,
                Keywords=x.KeyWords,
                MetaDescription=x.MetaDescription,
                Picture=x.Picture,
                PictureALt=x.PictureALt,
                PictureTitle=x.PictureTitle,
                Slug=x.Slug
            
            }).FirstOrDefault(x => x.Id == Id);
        }

       

        public List<ProductCategoryViewModel> Search(ProductCategorySearchModel searchModel)
        {
            var query = _context.ProductCategories.Select(x=>new ProductCategoryViewModel()
            {
            
                Id=x.Id,
                Picture=x.Picture,
                Name=x.Name,
                CareationDate=x.CreationDate.ToString()

            }
            );
            // جستجو بر اساس نام

            if (!string.IsNullOrWhiteSpace(searchModel.Name))
            {

                query = query.Where(x => x.Name.Contains(searchModel.Name));
            }

            return  
                query.OrderByDescending(x => x.Id).ToList();
        }

        

        
    }
}
