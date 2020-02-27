using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Models.Table;

namespace Models.Interface
{
    public interface Repository_Role_if
    {
        #region Role 操作
        IQueryable<Role> AllRoleFill();

        Role RoleFillBy(Guid Rolesno);

        int RoleCount();

        bool InsertRole(Role roleData);

        bool UpdateRoleBy(Role roleData);

        bool DeleteRoleBy(Guid Rolesno);
        #endregion
    }
}
