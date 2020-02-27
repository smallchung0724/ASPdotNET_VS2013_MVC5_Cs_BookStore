using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Models.Table;

namespace Models.Interface
{
    public interface Service_OrderD_if
    {
        #region OrderD 操作
        IQueryable<OrderD> AllOrderDFill();

        OrderD OrderDFillBy(Guid Orderdtsno);

        int OrderDCount(Guid orderno);

        bool InsertOrderD(OrderD orderdData);

        bool UpdateOrderDBy(OrderD orderdData);

        bool DeleteOrderDBy(Guid Orderdtsno);
        #endregion
    }
}
