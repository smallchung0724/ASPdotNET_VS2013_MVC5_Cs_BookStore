using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace Models.Table
{
    public partial class TrollerD
    {
        public TrollerD()
        {
            this.Quantity = 0;
            this.Createdt = DateTime.Now;

            this.trollerm = new TrollerM();
            this.products = new List<Product>();
        }

        [Key]
        public Guid Trollerdtsno { get; set; }

        public Guid Trollersno { get; set; }

        public Guid Productsno { get; set; }

        public int Serno { get; set; }

        public int Quantity { get; set; }

        public DateTime Createdt { get; set; }

        public Nullable<DateTime> Modifydt { get; set; }

        public virtual TrollerM trollerm { get; set; }
        public virtual ICollection<Product> products { get; set; }
    }
}
