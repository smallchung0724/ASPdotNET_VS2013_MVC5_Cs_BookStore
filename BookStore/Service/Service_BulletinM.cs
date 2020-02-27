using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Models.Interface;
using Models.Repository;
using Models.Table;

namespace BookStore.Service
{
    public class Service_BulletinM_Cs : Repository_BulletinM_if
    {
        protected Repository_BulletinM_if Repository_BulletinM_P { get; set; }

        public Service_BulletinM_Cs() : this(null) { }

        public Service_BulletinM_Cs(Repository_BulletinM_if ifRepository_BulletinM_Val)
        {
            Repository_BulletinM_P = ifRepository_BulletinM_Val ?? new Repository_BulletinM_Cs();
        }

        #region BulletimM 操作
        public IQueryable<BulletinM> AllBulletinMFill()
        {
            return Repository_BulletinM_P.AllBulletinMFill();
        }

        public BulletinM BulletinMFillBy(Guid Bulletinsno)
        {
            return Repository_BulletinM_P.BulletinMFillBy(Bulletinsno);
        }

        public int BulletinMCount()
        {
            return Repository_BulletinM_P.BulletinMCount();
        }

        public int BulletinMmaxSort()
        {
            return Repository_BulletinM_P.BulletinMmaxSort();
        }

        public bool InsertBulletinM(BulletinM bulletinmData)
        {
            return Repository_BulletinM_P.InsertBulletinM(bulletinmData);
        }

        public bool UpdateBulletinMBy(BulletinM bulletinmData)
        {
            return Repository_BulletinM_P.UpdateBulletinMBy(bulletinmData);
        }

        public bool DeleteBulletinMBy(Guid Bulletinsno)
        {
            return Repository_BulletinM_P.DeleteBulletinMBy(Bulletinsno);
        }
        #endregion
    }
}