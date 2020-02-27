using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace Models.Table
{
    public partial class Supplier
    {
        public Supplier()
        {
            //this.Createdt = DateTime.Now;

            //this.products = new List<Product>();
        }

        [Key]
        public Guid Suppsno { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Fax { get; set; }

        public string Adress { get; set; }

        public DateTime Createdt { get; set; }

        public Nullable<DateTime> Modifydt { get; set; }

        public virtual ICollection<Product> products { get; set; }
    }
}
