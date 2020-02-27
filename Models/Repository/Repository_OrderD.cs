using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Models.Interface;
using Models.Table;

namespace Models.Repository
{
    public class Repository_OrderD_Cs : Repository_OrderD_if
    {
        BookStoreContext db;

        public Repository_OrderD_Cs()
        {
            if (db == null)
                db = new BookStoreContext();
        }

        #region OrderD 操作
        public IQueryable<OrderD> AllOrderDFill()
        {
            IQueryable<OrderD> SearchData = db.OrderD.OrderBy(m => m.serno);

            return SearchData;
        }

        public OrderD OrderDFillBy(Guid Orderdtsno)
        {
            OrderD SearchData = db.OrderD.Find(Orderdtsno);

            return SearchData;
        }

        public int OrderDCount(Guid ordersno)
        {
            IQueryable<OrderD> SearchData = db.OrderD.OrderBy(m => m.serno);

            int Count = SearchData.Count();

            return Count;
        }

        public bool InsertOrderD(OrderD orderdData)
        {
            if (orderdData == null)
                return false;

            db.OrderD.Add(orderdData);

            db.SaveChanges();

            return true;
        }

        public bool UpdateOrderDBy(OrderD orderdData)
        {
            OrderD OldData = db.OrderD.Find(orderdData.Orderdtsno);

            if (OldData == null)
                return false;

            OldData.serno = orderdData.serno;
            OldData.Quantity = orderdData.Quantity;
            OldData.Modifydt = DateTime.Now;

            db.SaveChanges();

            return true;
        }

        public bool DeleteOrderDBy(Guid Orderdtsno)
        {
            OrderD OldData = db.OrderD.Find(Orderdtsno);

            if (OldData == null)
                return false;

            db.OrderD.Remove(OldData);

            db.SaveChanges();

            return true;
        }
        #endregion
    }
}
