using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Models.Interface;
using Models.Table;

namespace Models.Repository
{
    public class Repository_Supplier_Cs : Repository_Supplier_if
    {
        BookStoreContext db;

        public Repository_Supplier_Cs()
        {
            db = new BookStoreContext();
        }

        #region Supplier 操作
        public IQueryable<Supplier> AllSupplierFill()
        {
            IQueryable<Supplier> SearchData = db.Supplier.OrderBy(m => m.Name);

            return SearchData;
        }

        public Supplier SupplierFillBy(Guid Suppliersno)
        {
            Supplier SearchData = db.Supplier.Find(Suppliersno);

            return SearchData;
        }

        public int SupplierCount()
        {
            int Count = db.Supplier.Count();

            return Count;
        }

        public bool InsertSupplier(Supplier supplierData)
        {
            if (supplierData == null)
                return false;

            db.Supplier.Add(supplierData);

            db.SaveChanges();

            return true;
        }

        public bool UpdateSupplierBy(Supplier supplierData)
        {
            Supplier OldData = db.Supplier.Find(supplierData.Suppsno);

            if (OldData == null)
                return false;

            OldData.Name = supplierData.Name;
            OldData.Email = supplierData.Email;
            OldData.Phone = supplierData.Phone;
            OldData.Fax = supplierData.Fax;
            OldData.Adress = supplierData.Adress;
            OldData.Modifydt = DateTime.Now;

            db.SaveChanges();

            return true;
        }

        public bool DeleteSupplierBy(Guid Suppliersno)
        {
            Supplier OldData = db.Supplier.Find(Suppliersno);

            if (OldData == null)
                return false;

            db.Supplier.Remove(OldData);

            db.SaveChanges();

            return true;
        }
        #endregion
    }
}
