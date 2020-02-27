using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace Models.Table
{
    public partial class TrollerM
    {
        public TrollerM()
        {
            this.Trollerdate = DateTime.Today;
            this.IsOrder = false;
            this.Createdt = DateTime.Now;

            //this.orderm = new OrderM();
            this.trollerd = new List<TrollerD>();
            this.member = new Member();
        }

        [Key]
        public Guid Trollersno { get; set; }

        public string Trollerno { get; set; }

        public DateTime Trollerdate { get; set; }

        public Guid Membersno { get; set; }

        public bool IsOrder { get; set; }

        public DateTime Createdt { get; set; }

        public Nullable<DateTime> Modifydt { get; set; }

        //public virtual OrderM orderm { get; set; }
        public virtual ICollection<TrollerD> trollerd { get; set; }
        public virtual Member member { get; set; }
    }
}
