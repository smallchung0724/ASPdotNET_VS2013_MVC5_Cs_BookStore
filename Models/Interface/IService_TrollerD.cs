using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Models.Table;

namespace Models.Interface
{
    public interface Service_TrollerD_if
    {
        #region TrollerD 操作
        IQueryable<TrollerD> AllTrollerDFill();

        TrollerD TrollerDFillBy(Guid Trollerdtsno);

        int TrollerDCount();

        bool InsertTrollerD(TrollerD trollerdData);

        bool UpdateTrollerDBy(TrollerD trollerdData);

        bool DeleteTrollerDBy(Guid Trollerdtsno);
        #endregion
    }
}
