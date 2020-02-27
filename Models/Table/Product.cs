using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace Models.Table
{
    public partial class Product
    {
        public Product()
        {
            //this.ActualPrice = 0;
            //this.UnitPrice = 0;
            //this.Discount = 0;
            //this.PageNumber = 1;
            //this.Createdt = DateTime.Now;

            //this.orderd = new OrderD();
            //this.trollerd = new TrollerD();
            //this.supplier = new Supplier();
        }

        [Key]
        public Guid Productsno { get; set; }

        public string Name { get; set; }

        public string Author { get; set; }

        public Guid Suppsno { get; set; }

        public DateTime Publish { get; set; }

        public double ActualPrice { get; set; }

        public double UnitPrice { get; set; }

        public double Discount { get; set; }

        public string Language { get; set; }

        public int PageNumber { get; set; }

        public string ISBN { get; set; }

        public string Url { get; set; }

        public string Alt { get; set; }

        public string Href { get; set; }

        public string Describe { get; set; }

        public string Outline { get; set; }

        public string Contents { get; set; }

        public DateTime Createdt { get; set; }

        public Nullable<DateTime> Modifydt { get; set; }

        public virtual OrderD orderd { get; set; }
        public virtual TrollerD trollerd { get; set; }
        public virtual Supplier supplier { get; set; }
    }
}
