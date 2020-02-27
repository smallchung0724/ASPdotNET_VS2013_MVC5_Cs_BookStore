using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace Models.Table
{
    public partial class Member
    {
        public Member()
        {
            this.Authcode = string.Empty;
            this.Createdt = DateTime.Now;

            this.orderms = new List<OrderM>();
            this.trollerms = new List<TrollerM>();
            this.role = new Role();
        }

        [Key]
        public Guid Membersno { get; set; }

        public Guid Rolesno { get; set; }

        public string Account { get; set; }

        public string Password { get; set; }

        public string re_Password { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Authcode { get; set; }

        public DateTime Createdt { get; set; }

        public Nullable<DateTime> Modifydt { get; set; }

        public virtual ICollection<OrderM> orderms { get; set; }
        public virtual ICollection<TrollerM> trollerms { get; set; }
        public virtual Role role { get; set; }
    }
}
