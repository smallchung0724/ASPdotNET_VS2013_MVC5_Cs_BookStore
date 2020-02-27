using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Models.Interface;
using Models.Table;

namespace Models.Repository
{
    public class Repository_Role_Cs : Repository_Role_if
    {
        BookStoreContext db;

        public Repository_Role_Cs()
        {
            if (db == null)
                db = new BookStoreContext();
        }

        #region Role 操作
        public IQueryable<Role> AllRoleFill()
        {
            IQueryable<Role> SearchData = db.Role.OrderBy(m => m.Sort);

            return SearchData;
        }

        public Role RoleFillBy(Guid Rolesno)
        {
            Role SearchData = db.Role.Find(Rolesno);

            return SearchData;
        }

        public int RoleCount()
        {
            int Count = db.Role.Count();

            return Count;
        }

        public bool InsertRole(Role roleData)
        {
            if (roleData == null)
                return false;

            db.Role.Add(roleData);

            db.SaveChanges();

            return true;
        }

        public bool UpdateRoleBy(Role roleData)
        {
            Role OldData = db.Role.Find(roleData.Rolesno);

            if (OldData == null)
                return false;

            OldData.Name = roleData.Name;
            OldData.Sort = roleData.Sort;
            OldData.Sort = roleData.Sort;
            OldData.Modifydt = DateTime.Now;

            db.SaveChanges();

            return true;
        }

        public bool DeleteRoleBy(Guid Rolesno)
        {
            Role OldData = db.Role.Find(Rolesno);

            if (OldData == null)
                return false;

            db.Role.Remove(OldData);

            db.SaveChanges();

            return true;
        }
        #endregion
    }
}
