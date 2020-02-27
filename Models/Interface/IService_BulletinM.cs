using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Models.Table;

namespace Models.Interface
{
    public interface Service_BulletinM_if
    {
        #region BulletimM 操作
        IQueryable<BulletinM> AllBulletinMFill();

        BulletinM BulletinMFillBy(Guid Bulletinsno);

        int BulletinMCount();

        int BulletinMmaxSort();

        bool InsertBulletinM(BulletinM bulletinmData);

        bool UpdateBulletinMBy(BulletinM bulletinmData);

        bool DeleteBulletinMBy(Guid Bulletinsno);
        #endregion
    }
}
