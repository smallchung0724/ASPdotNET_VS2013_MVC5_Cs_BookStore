using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Models.Interface;
using Models.Repository;
using Models.Table;

namespace BookStore.Service
{
    public class Service_TrollerM : Repository_TrollerM_if
    {
        Repository_TrollerM_if Repository_TrollerM_P;

        public Service_TrollerM() : this(null) { }

        public Service_TrollerM(Repository_TrollerM_if Repository_TrollerM_Val)
        {
            Repository_TrollerM_P = Repository_TrollerM_Val ?? new Repository_TrollerM_Cs();
        }

        #region TrollerM 操作
        public IQueryable<TrollerM> AllTrollerMFill()
        {
            return Repository_TrollerM_P.AllTrollerMFill();
        }

        public TrollerM TrollerMFillBy(Guid Trollersno)
        {
            return Repository_TrollerM_P.TrollerMFillBy(Trollersno);
        }

        public int TrollerMCount()
        {
            return Repository_TrollerM_P.TrollerMCount();
        }

        public bool InsertTrollerM(TrollerM trollermData)
        {
            return Repository_TrollerM_P.InsertTrollerM(trollermData);
        }

        public bool UpdateTrollerMBy(TrollerM trollermData)
        {
            return Repository_TrollerM_P.UpdateTrollerMBy(trollermData);
        }

        public bool DeleteTrollerMBy(Guid Trollersno)
        {
            return Repository_TrollerM_P.DeleteTrollerMBy(Trollersno);
        }
        #endregion
    }
}