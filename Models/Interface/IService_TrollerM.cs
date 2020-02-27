using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Models.Table;

namespace Models.Interface
{
    public interface Service_TrollerM_if
    {
        #region TrollerM 操作
        IQueryable<TrollerM> AllTrollerMFill();

        TrollerM TrollerMFillBy(Guid Trollersno);

        int TrollerMCount();

        bool InsertTrollerM(TrollerM trollermData);

        bool UpdateTrollerMBy(TrollerM trollermData);

        bool DeleteTrollerMBy(Guid Trollersno);
        #endregion
    }
}
