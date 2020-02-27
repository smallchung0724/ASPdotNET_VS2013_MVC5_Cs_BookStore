using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Models.Interface;
using Models.Repository;
using Models.Table;

namespace BookStore.Service
{
    public class Service_Supplier : Repository_Supplier_if
    {
        Repository_Supplier_if Repository_Supplier_P;

        public Service_Supplier() : this(null) { }

        public Service_Supplier(Repository_Supplier_if Repository_Supplier_Val)
        {
            Repository_Supplier_P = Repository_Supplier_Val ?? new Repository_Supplier_Cs();
        }

        #region Supplier 操作
        public IQueryable<Supplier> AllSupplierFill()
        {
            return Repository_Supplier_P.AllSupplierFill();
        }

        public Supplier SupplierFillBy(Guid Suppliersno)
        {
            return Repository_Supplier_P.SupplierFillBy(Suppliersno);
        }

        public int SupplierCount()
        {
            return Repository_Supplier_P.SupplierCount();
        }

        public bool InsertSupplier(Supplier supplierData)
        {
            return Repository_Supplier_P.InsertSupplier(supplierData);
        }

        public bool UpdateSupplierBy(Supplier supplierData)
        {
            return Repository_Supplier_P.UpdateSupplierBy(supplierData);
        }

        public bool DeleteSupplierBy(Guid Suppliersno)
        {
            return Repository_Supplier_P.DeleteSupplierBy(Suppliersno);
        }
        #endregion
    }
}