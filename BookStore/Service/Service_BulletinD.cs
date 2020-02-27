using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Models.Interface;
using Models.Repository;
using Models.Table;

namespace BookStore.Service
{
    public class Service_BulletinD_Cs : Service_BulletinD_if
    {
        protected Repository_BulletinD_if Repository_BulletinD_P { get; set; }

        public Service_BulletinD_Cs() : this(null) { }

        public Service_BulletinD_Cs(Repository_BulletinD_if ifRepository_BulletinD_Val)
        {
            Repository_BulletinD_P = ifRepository_BulletinD_Val ?? new Repository_BulletinD_Cs();
        }

        #region BulletimD 操作
        public IQueryable<BulletinD> AllBulletinDFill()
        {
            return Repository_BulletinD_P.AllBulletinDFill();
        }

        public BulletinD BulletinDFillBy(Guid Bulletindtsno)
        {
            return Repository_BulletinD_P.BulletinDFillBy(Bulletindtsno);
        }

        public int BulletinDCount()
        {
            return Repository_BulletinD_P.BulletinDCount();
        }

        public int BulletinDmaxSort()
        {
            return Repository_BulletinD_P.BulletinDmaxSort();
        }

        public bool InsertBulletinD(BulletinD bulletindData)
        {
            return Repository_BulletinD_P.InsertBulletinD(bulletindData);
        }

        public bool UpdateBulletinDBy(BulletinD bulletindData)
        {
            return Repository_BulletinD_P.UpdateBulletinDBy(bulletindData);
        }

        public bool DeleteBulletinDBy(Guid Bulletindtsno)
        {
            return Repository_BulletinD_P.DeleteBulletinDBy(Bulletindtsno);
        }
        #endregion
    }
}