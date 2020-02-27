using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Models.Table;

namespace Models.Interface
{
    public interface Repository_Product_if
    {
        #region Product 操作
        IQueryable<Product> AllProductFill();

        Product ProductFillBy(Guid Productsno);

        int ProductCount();

        bool InsertProduct(Product productData);

        bool UpdateProductBy(Product productData);

        bool DeleteProductBy(Guid Productsno);
        #endregion
    }
}
