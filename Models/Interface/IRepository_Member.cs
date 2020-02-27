using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Models.Table;

namespace Models.Interface
{
    public interface Repository_Member_if
    {
        #region Member 操作
        IQueryable<Member> AllMemberFill();

        Member MemberFillBy(Guid Membersno);

        int MemberCount();

        bool InsertMember(Member memberData);

        bool UpdateMemberBy(Member memberData);

        bool DeleteMemberBy(Guid Membersno);
        #endregion
    }
}
