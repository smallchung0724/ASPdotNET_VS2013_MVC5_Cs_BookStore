using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Models.Interface;
using Models.Repository;
using Models.Table;

namespace BookStore.Service
{
    public class Service_TrollerD : Repository_TrollerD_if
    {
        Repository_TrollerD_if Repository_TrollerD_P;

        public Service_TrollerD() : this(null) { }

        public Service_TrollerD(Repository_TrollerD_if Repository_TrollerD_Val)
        {
            Repository_TrollerD_P = Repository_TrollerD_Val ?? new Repository_TrollerD_Cs();
        }

        #region TrollerD 操作
        public IQueryable<TrollerD> AllTrollerDFill()
        {
            return Repository_TrollerD_P.AllTrollerDFill();
        }

        public TrollerD TrollerDFillBy(Guid Trollerdtsno)
        {
            return Repository_TrollerD_P.TrollerDFillBy(Trollerdtsno);
        }

        public int TrollerDCount()
        {
            return Repository_TrollerD_P.TrollerDCount();
        }

        public bool InsertTrollerD(TrollerD trollerdData)
        {
            return Repository_TrollerD_P.InsertTrollerD(trollerdData);
        }

        public bool UpdateTrollerDBy(TrollerD trollerdData)
        {
            return Repository_TrollerD_P.UpdateTrollerDBy(trollerdData);
        }

        public bool DeleteTrollerDBy(Guid Trollerdtsno)
        {
            return Repository_TrollerD_P.DeleteTrollerDBy(Trollerdtsno);
        }
        #endregion
    }
}