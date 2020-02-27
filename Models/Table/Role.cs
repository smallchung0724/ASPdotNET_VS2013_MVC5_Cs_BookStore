using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace Models.Table
{
    public partial class Role
    {
        public Role()
        {
            this.IsEnable = false;
            this.Createdt = DateTime.Now;

            this.members = new List<Member>();
        }

        [Key]
        public Guid Rolesno { get; set; }

        public string Name { get; set; }

        public int Sort { get; set; }

        public bool IsEnable { get; set; }

        public DateTime Createdt { get; set; }

        public Nullable<DateTime> Modifydt { get; set; }

        public virtual ICollection<Member> members { get; set; }
    }
}
