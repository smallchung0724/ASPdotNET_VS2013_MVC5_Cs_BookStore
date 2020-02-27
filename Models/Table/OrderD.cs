using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace Models.Table
{
    public partial class OrderD
    {
        public OrderD()
        {
            this.Quantity = 0;
            this.Createdt = DateTime.Now;

            this.orderm = new OrderM();
            this.products = new List<Product>();
        }

        [Key]
        public Guid Orderdtsno { get; set; }

        public Guid Ordersno { get; set; }

        public Guid Productsno { get; set; }

        public int serno { get; set; }

        public int Quantity { get; set; }

        public DateTime Createdt { get; set; }

        public Nullable<DateTime> Modifydt { get; set; }

        public virtual OrderM orderm { get; set; }
        public virtual ICollection<Product> products { get; set; }
    }
}
