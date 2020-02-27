using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Models.Interface;
using Models.Table;

namespace Models.Repository
{
    public class Repository_TrollerD_Cs : Repository_TrollerD_if
    {
        BookStoreContext db;

        public Repository_TrollerD_Cs()
        {
            if (db == null)
                db = new BookStoreContext();
        }

        #region TrollerD 操作
        public IQueryable<TrollerD> AllTrollerDFill()
        {
            IQueryable<TrollerD> SearchData = db.TrollerD.OrderBy(m => m.Serno);

            return SearchData;
        }

        public TrollerD TrollerDFillBy(Guid Trollerdtsno)
        {
            TrollerD SearchData = db.TrollerD.Find(Trollerdtsno);

            return SearchData;
        }

        public int TrollerDCount()
        {
            int Count = db.TrollerD.Count();

            return Count;
        }

        public bool InsertTrollerD(TrollerD trollerdData)
        {
            if (trollerdData == null)
                return false;

            db.TrollerD.Add(trollerdData);

            db.SaveChanges();

            return true;
        }

        public bool UpdateTrollerDBy(TrollerD trollerdData)
        {
            TrollerD OldData = db.TrollerD.Find(trollerdData.Trollerdtsno);

            if (OldData == null)
                return false;

            OldData.Serno = trollerdData.Serno;
            OldData.Quantity = trollerdData.Quantity;
            OldData.Modifydt = DateTime.Now;

            db.SaveChanges();

            return true;
        }

        public bool DeleteTrollerDBy(Guid Trollerdtsno)
        {
            TrollerD OldData = db.TrollerD.Find(Trollerdtsno);

            if (OldData == null)
                return false;

            db.TrollerD.Remove(OldData);

            db.SaveChanges();

            return true;
        }
        #endregion
    }
}
