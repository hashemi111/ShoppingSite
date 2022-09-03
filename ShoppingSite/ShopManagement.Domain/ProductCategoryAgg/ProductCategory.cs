namespace ShopManagement.Domain.ProductCategoryAgg
{
   public class ProductCategory : _0_Framework.Domain.EntityBase
    {
       

        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Picture { get; private set; }
        public string PictureALt { get; private set; }
        public string PictureTitle { get; private set; }
        public string KeyWords { get; private set; }
        public string MetaDescription { get; private set; }
        
        //برای سئو و یکی بودن آن با تایتل صفحه لازم است
        public string Slug { get; private set; }


        public ProductCategory(string name, string description, string Picture, string pictureALt, string pictureTitle, string keyWords, string metaDescription, string slug)
        {
            Name = name;
            Description = description;
            Picture = Picture;
            PictureALt = pictureALt;
            PictureTitle = pictureTitle;
            KeyWords = keyWords;
            MetaDescription = metaDescription;
            Slug = slug;
        }


        // چون ستهای خود را پرایوت میزنم باید ادیت بدون ساختن نمونه امکان پذیر بشه
        public void Edit(string name, string description, string Picture, string pictureALt, string pictureTitle, string keyWords, string metaDescription, string slug)
        {
            Name = name;
            Description = description;
            Picture = Picture;
            PictureALt = pictureALt;
            PictureTitle = pictureTitle;
            KeyWords = keyWords;
            MetaDescription = metaDescription;
            Slug = slug;
        }
    }
}
