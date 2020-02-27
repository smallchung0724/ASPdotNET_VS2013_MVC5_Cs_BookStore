using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Models.Interface;
using Models.Table;

namespace Models.Repository
{
    public class Repository_OrderM_Cs : Repository_OrderM_if
    {
        BookStoreContext db;

        public Repository_OrderM_Cs()
        {
            if (db == null)
                db = new BookStoreContext();
        }

        #region OrderM 操作
        public IQueryable<OrderM> AllOrderMFill()
        {
            IQueryable<OrderM> SearchData = db.OrderM.OrderBy(m => m.Orderno);

            return SearchData;
        }

        public OrderM OrderMFillBy(Guid Ordersno)
        {
            OrderM SearchData = db.OrderM.Find(Ordersno);

            return SearchData;
        }

        public int OrderMCount()
        {
            int Count = db.OrderM.Count();

            return Count;
        }

        public bool InsertOrderM(OrderM ordermData)
        {
            if (ordermData == null)
                return false;

            db.OrderM.Add(ordermData);
            db.SaveChanges();

            return true;
        }

        public bool UpdateOrderMBy(OrderM ordermData)
        {
            OrderM OldData = db.OrderM.Find(ordermData.Ordersno);

            if (OldData == null)
                return false;

            OldData.Orderdate = ordermData.Orderdate;
            OldData.Modifydt = DateTime.Now;

            db.SaveChanges();

            return true;
        }

        public bool DeleteOrderMBy(Guid Ordersno)
        {
            OrderM OldData = db.OrderM.Find(Ordersno);

            if (OldData == null)
                return false;

            db.OrderM.Remove(OldData);

            db.SaveChanges();

            return true;
        }
        #endregion
    }
}
