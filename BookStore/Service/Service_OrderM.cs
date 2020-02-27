using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Models.Interface;
using Models.Repository;
using Models.Table;

namespace BookStore.Service
{
    public class Service_OrderM : Service_OrderM_if
    {
        protected Repository_OrderM_if Repository_OrderM_P { get; set; }

        public Service_OrderM() : this(null) { }

        public Service_OrderM(Repository_OrderM_if Repository_OrderM_Val)
        {
            Repository_OrderM_P = Repository_OrderM_Val ?? new Repository_OrderM_Cs();
        }

        #region OrderM 操作
        public IQueryable<OrderM> AllOrderMFill()
        {
            return Repository_OrderM_P.AllOrderMFill();
        }

        public OrderM OrderMFillBy(Guid Ordersno)
        {
            return Repository_OrderM_P.OrderMFillBy(Ordersno);
        }

        public int OrderMCount()
        {
            return Repository_OrderM_P.OrderMCount();
        }

        public bool InsertOrderM(OrderM ordermData)
        {
            return Repository_OrderM_P.InsertOrderM(ordermData);
        }

        public bool UpdateOrderMBy(OrderM ordermData)
        {
            return Repository_OrderM_P.UpdateOrderMBy(ordermData);
        }

        public bool DeleteOrderMBy(Guid Ordersno)
        {
            return Repository_OrderM_P.DeleteOrderMBy(Ordersno);
        }
        #endregion
    }
}