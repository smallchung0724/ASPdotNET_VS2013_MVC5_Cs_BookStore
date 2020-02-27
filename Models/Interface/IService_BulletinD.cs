using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Models.Table;

namespace Models.Interface
{
    public interface Service_BulletinD_if
    {
        #region BulletimD 操作
        IQueryable<BulletinD> AllBulletinDFill();

        BulletinD BulletinDFillBy(Guid Bulletindtsno);

        int BulletinDCount();

        int BulletinDmaxSort();

        bool InsertBulletinD(BulletinD bulletindData);

        bool UpdateBulletinDBy(BulletinD bulletindData);

        bool DeleteBulletinDBy(Guid Bulletindtsno);
        #endregion
    }
}
