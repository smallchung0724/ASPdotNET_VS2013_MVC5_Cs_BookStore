using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace Models.Table
{
    public partial class OrderM
    {
        public OrderM()
        {
            this.Orderdate = DateTime.Today;
            this.Createdt = DateTime.Now;

            //this.trollerm = new TrollerM();
            this.orderds = new List<OrderD>();
            this.member = new Member();
        }

        [Key]
        public Guid Ordersno { get; set; }

        public Guid Orderno { get; set; }

        public DateTime Orderdate { get; set; }

        public Guid Membersno { get; set; }

        //public Guid Trollersno { get; set; }

        public DateTime Createdt { get; set; }

        public Nullable<DateTime> Modifydt { get; set; }

        //public virtual TrollerM trollerm { get; set; }
        public virtual ICollection<OrderD> orderds { get; set; }
        public virtual Member member { get; set; }
    }
}
