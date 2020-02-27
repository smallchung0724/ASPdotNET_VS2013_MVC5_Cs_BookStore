using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace Models.Table
{
    public partial class BulletinD
    {
        public BulletinD()
        {
            //this.IsEnable = false;
            //this.IsImage = false;
            //this.Createdt = DateTime.Now;

            //this.bulletinm = new BulletinM();
        }

        [Key]
        public Guid Bulletindtsno { get; set; }

        public Guid Bulletinsno { get; set; }

        public string Name { get; set; }

        public int Sort { get; set; }

        public bool IsEnable { get; set; }

        public bool IsImage { get; set; }

        public string Url { get; set; }

        public string Alt { get; set; }

        public string Href { get; set; }

        public DateTime Createdt { get; set; }

        public Nullable<DateTime> Modifydt { get; set; }

        public virtual BulletinM bulletinm { get; set; }
    }
}
