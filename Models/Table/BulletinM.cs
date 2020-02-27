using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace Models.Table
{
    public partial class BulletinM
    {
        public BulletinM()
        {
            //this.IsEnable = false;
            //this.Createdt = DateTime.Now;

            //this.bulletinds = new List<BulletinD>();
        }

        [Key]
        public Guid Bulletinsno { get; set; }

        public string Name { get; set; }

        public int Sort { get; set; }

        public bool IsEnable { get; set; }

        public DateTime Createdt { get; set; }

        public Nullable<DateTime> Modifydt { get; set; }

        public virtual ICollection<BulletinD> bulletinds { get; set; }
    }
}
