using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Models.Interface;
using Models.Repository;
using Models.Table;

namespace BookStore.Service
{
    public class Service_OrderD_Cs : Repository_OrderD_if
    {
        protected Repository_OrderD_if Repository_OrderD_P { get; set; }

        public Service_OrderD_Cs() : this(null) { }

        public Service_OrderD_Cs(Repository_OrderD_if ifRepository_OrderD_Val)
        {
            Repository_OrderD_P = ifRepository_OrderD_Val ?? new Repository_OrderD_Cs();
        }

        #region OrderD 操作
        public IQueryable<OrderD> AllOrderDFill()
        {
            return Repository_OrderD_P.AllOrderDFill();
        }

        public OrderD OrderDFillBy(Guid Orderdtsno)
        {
            return Repository_OrderD_P.OrderDFillBy(Orderdtsno);
        }

        public int OrderDCount(Guid orderno)
        {
            return Repository_OrderD_P.OrderDCount(orderno);
        }

        public bool InsertOrderD(OrderD orderdData)
        {
            return Repository_OrderD_P.InsertOrderD(orderdData);
        }

        public bool UpdateOrderDBy(OrderD orderdData)
        {
            return Repository_OrderD_P.UpdateOrderDBy(orderdData);
        }

        public bool DeleteOrderDBy(Guid Orderdtsno)
        {
            return Repository_OrderD_P.DeleteOrderDBy(Orderdtsno);
        }
        #endregion
    }
}