using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Models.Interface;
using Models.Table;

namespace Models.Repository
{
    public class Repository_TrollerM_Cs : Repository_TrollerM_if
    {
        BookStoreContext db;

        public Repository_TrollerM_Cs()
        {
            if (db == null)
                db = new BookStoreContext();
        }

        #region TrollerM 操作
        public IQueryable<TrollerM> AllTrollerMFill()
        {
            IQueryable<TrollerM> SearchData = db.TrollerM.OrderBy(m => m.Trollerno);

            return SearchData;
        }

        public TrollerM TrollerMFillBy(Guid Trollersno)
        {
            TrollerM SearchData = db.TrollerM.Find(Trollersno);

            return SearchData;
        }

        public int TrollerMCount()
        {
            int Count = db.TrollerM.Count();

            return Count;
        }

        public bool InsertTrollerM(TrollerM trollermData)
        {
            if (trollermData == null)
                return false;

            db.TrollerM.Add(trollermData);

            db.SaveChanges();

            return true;
        }

        public bool UpdateTrollerMBy(TrollerM trollermData)
        {
            TrollerM OldData = db.TrollerM.Find(trollermData.Trollersno);

            if (OldData == null)
                return false;

            OldData.Trollerdate = trollermData.Trollerdate;
            OldData.IsOrder = trollermData.IsOrder;
            OldData.Modifydt = DateTime.Now;

            return true;
        }

        public bool DeleteTrollerMBy(Guid Trollersno)
        {
            TrollerM OldData = db.TrollerM.Find(Trollersno);

            if (OldData == null)
                return false;

            db.TrollerM.Remove(OldData);

            db.SaveChanges();

            return true;
        }
        #endregion
    }
}
