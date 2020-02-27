using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Models.Table;

namespace Models.Interface
{
    public interface Service_Supplier_if
    {
        #region Supplier 操作
        IQueryable<Supplier> AllSupplierFill();

        Supplier SupplierFillBy(Guid Suppliersno);

        int SupplierCount();

        bool InsertSupplier(Supplier supplierData);

        bool UpdateSupplierBy(Supplier supplierData);

        bool DeleteSupplierBy(Guid Suppliersno);
        #endregion
    }
}
