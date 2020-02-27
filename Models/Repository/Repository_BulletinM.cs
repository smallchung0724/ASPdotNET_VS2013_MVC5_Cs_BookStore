using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Models.Interface;
using Models.Table;

namespace Models.Repository
{
    public class Repository_BulletinM_Cs: Repository_BulletinM_if
    {
        BookStoreContext db;

        public Repository_BulletinM_Cs()
        {
            if (db == null)
                db = new BookStoreContext();
        }

        #region BulletimM 操作
        public IQueryable<BulletinM> AllBulletinMFill()
        {
            IQueryable<BulletinM> SearchData = db.BulletinM.OrderBy(m => m.Sort);

            return SearchData;
        }

        public BulletinM BulletinMFillBy(Guid Bulletinsno)
        {
            BulletinM SearchData = db.BulletinM.Find(Bulletinsno);

            return SearchData;
        }

        public int BulletinMCount()
        {
            int Count = db.BulletinM.Count();

            return Count;
        }

        public int BulletinMmaxSort()
        {
            int Short = BulletinMCount() == 0 ? 0 : db.BulletinM.Max(m => m.Sort);

            return Short;
        }
         
        public bool InsertBulletinM(BulletinM bulletinmData)
        {
            if (bulletinmData == null)
                return false;

            db.BulletinM.Add(bulletinmData);
            db.SaveChanges();

            return true;
        }

        public bool UpdateBulletinMBy(BulletinM bulletinmData)
        {
            BulletinM OldData = db.BulletinM.Find(bulletinmData.Bulletinsno);

            if (OldData == null)
                return false;

            OldData.Name = bulletinmData.Name;
            OldData.Sort = bulletinmData.Sort;
            OldData.IsEnable = bulletinmData.IsEnable;
            OldData.Modifydt = DateTime.Now;

            db.SaveChanges();

            return true;
        }

        public bool DeleteBulletinMBy(Guid Bulletinsno)
        {
            BulletinM OldData = db.BulletinM.Find(Bulletinsno);

            if (OldData == null)
                return false;

            db.BulletinM.Remove(OldData);
            db.SaveChanges();

            return true;
        }
        #endregion
    }
}
