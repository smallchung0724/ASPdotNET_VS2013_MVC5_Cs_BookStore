using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Models.Interface;
using Models.Table;

namespace Models.Repository
{
    public class Repository_BulletinD_Cs : Repository_BulletinD_if
    {
        BookStoreContext db;

        public Repository_BulletinD_Cs()
        {
            if (db == null)
                db = new BookStoreContext();
        }

        #region BulletimD 操作
        public IQueryable<BulletinD> AllBulletinDFill()
        {
            IQueryable<BulletinD> SearchData = db.BulletinD.OrderBy(m => m.Sort);

            return SearchData;
        }

        public BulletinD BulletinDFillBy(Guid Bulletindtsno)
        {
            BulletinD SearchData = db.BulletinD.Find(Bulletindtsno);

            return SearchData;
        }

        public int BulletinDCount()
        {
            int Count = db.BulletinD.Count();

            return Count;
        }

        public int BulletinDmaxSort()
        {
            int Sort = BulletinDCount() == 0 ? 0 : db.BulletinD.Max(m => m.Sort);

            return Sort;
        }

        public bool InsertBulletinD(BulletinD bulletindData)
        {
            if (bulletindData == null)
                return false;

            db.BulletinD.Add(bulletindData);
            db.SaveChanges();

            return true;
        }

        public bool UpdateBulletinDBy(BulletinD bulletindData)
        {
            BulletinD OldData = db.BulletinD.Find(bulletindData.Bulletindtsno);

            if (OldData == null)
                return false;

            OldData.Name = bulletindData.Name;
            OldData.Sort = bulletindData.Sort;
            OldData.IsEnable = bulletindData.IsEnable;
            OldData.IsImage = bulletindData.IsImage;
            OldData.Url = bulletindData.Url;
            OldData.Alt = bulletindData.Alt;
            OldData.Href = bulletindData.Href;
            OldData.Modifydt = DateTime.Now;

            db.SaveChanges();

            return true;
        }

        public bool DeleteBulletinDBy(Guid Bulletindtsno)
        {
            BulletinD OldData = db.BulletinD.Find(Bulletindtsno);

            if (OldData == null)
                return false;

            db.BulletinD.Remove(OldData);

            db.SaveChanges();

            return true;
        }
        #endregion
    }
}
