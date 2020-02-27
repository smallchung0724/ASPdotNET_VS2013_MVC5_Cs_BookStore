using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Models.Interface;
using Models.Table;

namespace Models.Repository
{
    public class Repository_Product_Cs : Repository_Product_if
    {
        BookStoreContext db;

        public Repository_Product_Cs()
        {
            if (db == null)
                db = new BookStoreContext();
        }

        #region Product 操作
        public IQueryable<Product> AllProductFill()
        {
            IQueryable<Product> SearchData = db.Product.OrderBy(m => m.Name);

            return SearchData;
        }

        public Product ProductFillBy(Guid Productsno)
        {
            Product SearchData = db.Product.Find(Productsno);

            return SearchData;
        }

        public int ProductCount()
        {
            int Count = db.Product.Count();

            return Count;
        }

        public bool InsertProduct(Product productData)
        {
            if (productData == null)
                return false;

            db.Product.Add(productData);

            db.SaveChanges();

            return true;
        }

        public bool UpdateProductBy(Product productData)
        {
            Product OldData = db.Product.Find(productData);

            if (OldData == null)
                return false;

            OldData.Name = productData.Name;
            OldData.Author = productData.Author;
            OldData.Suppsno = productData.Suppsno;
            OldData.Publish = productData.Publish;
            OldData.ActualPrice = productData.ActualPrice;
            OldData.UnitPrice = productData.UnitPrice;
            OldData.Discount = productData.Discount;
            OldData.Language = productData.Language;
            OldData.PageNumber = productData.PageNumber;
            OldData.ISBN = productData.ISBN;
            OldData.Url = productData.Url;
            OldData.Alt = productData.Alt;
            OldData.Href = productData.Href;
            OldData.Describe = productData.Describe;
            OldData.Outline = productData.Outline;
            OldData.Contents = productData.Contents;
            OldData.Modifydt = DateTime.Now;

            db.SaveChanges();

            return true;
        }

        public bool DeleteProductBy(Guid Productsno)
        {
            Product OldData = db.Product.Find(Productsno);

            if (OldData == null)
                return false;

            db.Product.Remove(OldData);

            db.SaveChanges();

            return true;
        }
        #endregion
    }
}
