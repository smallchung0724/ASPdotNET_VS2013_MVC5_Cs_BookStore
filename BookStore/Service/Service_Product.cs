using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Models.Interface;
using Models.Repository;
using Models.Table;

namespace BookStore.Service
{
    public class Service_Product : Repository_Product_if
    {
        Repository_Product_if Repository_Product_P;

        public Service_Product() : this(null) { }

        public Service_Product(Repository_Product_if Repository_Product_Val)
        {
            Repository_Product_P = Repository_Product_Val ?? new Repository_Product_Cs();
        }

        #region Product 操作
        public IQueryable<Product> AllProductFill()
        {
            return Repository_Product_P.AllProductFill();
        }

        public Product ProductFillBy(Guid Productsno)
        {
            return Repository_Product_P.ProductFillBy(Productsno);
        }

        public int ProductCount()
        {
            return Repository_Product_P.ProductCount();
        }

        public bool InsertProduct(Product productData)
        {
            return Repository_Product_P.InsertProduct(productData);
        }

        public bool UpdateProductBy(Product productData)
        {
            return Repository_Product_P.UpdateProductBy(productData);
        }

        public bool DeleteProductBy(Guid Productsno)
        {
            return Repository_Product_P.DeleteProductBy(Productsno);
        }
        #endregion
    }
}