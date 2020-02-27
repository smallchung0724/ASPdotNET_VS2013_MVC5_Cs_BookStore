using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Models.Interface;
using Models.Repository;
using Models.Table;

namespace BookStore.Service
{
    public class Service_Role : Repository_Role_if
    {
        Repository_Role_if Repository_Role_P;

        public Service_Role() : this(null) { }

        public Service_Role(Repository_Role_if Repository_Role_Val)
        {
            Repository_Role_P = Repository_Role_Val ?? new Repository_Role_Cs();
        }

        #region Role 操作
        public IQueryable<Role> AllRoleFill()
        {
            return Repository_Role_P.AllRoleFill();
        }

        public Role RoleFillBy(Guid Rolesno)
        {
            return Repository_Role_P.RoleFillBy(Rolesno);
        }

        public int RoleCount()
        {
            return Repository_Role_P.RoleCount();
        }

        public bool InsertRole(Role roleData)
        {
            return Repository_Role_P.InsertRole(roleData);
        }

        public bool UpdateRoleBy(Role roleData)
        {
            return Repository_Role_P.UpdateRoleBy(roleData);
        }

        public bool DeleteRoleBy(Guid Rolesno)
        {
            return Repository_Role_P.DeleteRoleBy(Rolesno);
        }
        #endregion
    }
}