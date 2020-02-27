using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Models.Table;

namespace Models.Interface
{
    public interface Repository_OrderM_if
    {
        #region OrderM 操作
        IQueryable<OrderM> AllOrderMFill();

        OrderM OrderMFillBy(Guid Ordersno);

        int OrderMCount();

        bool InsertOrderM(OrderM ordermData);

        bool UpdateOrderMBy(OrderM ordermData);

        bool DeleteOrderMBy(Guid Ordersno);
        #endregion
    }
}
