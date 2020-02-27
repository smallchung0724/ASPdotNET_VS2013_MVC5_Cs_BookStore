using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Models.Interface;
using Models.Repository;
using Models.Table;

namespace BookStore.Service
{
    public class Service_Member_Cs : Service_Member_if
    {
        protected Repository_Member_if Repository_Member_P { get; set; }

        public Service_Member_Cs() : this(null) { }

        public Service_Member_Cs(Repository_Member_if ifRepository_Member_Val)
        {
            Repository_Member_P = ifRepository_Member_Val ?? new Repository_Member_Cs();
        }

        #region Member 操作
        public IQueryable<Member> AllMemberFill()
        {
            return Repository_Member_P.AllMemberFill();
        }

        public Member MemberFillBy(Guid Membersno)
        {
            return Repository_Member_P.MemberFillBy(Membersno);
        }

        public int MemberCount()
        {
            return Repository_Member_P.MemberCount();
        }

        public bool InsertMember(Member memberData)
        {
            return Repository_Member_P.InsertMember(memberData);
        }

        public bool UpdateMemberBy(Member memberData)
        {
            return Repository_Member_P.UpdateMemberBy(memberData);
        }

        public bool DeleteMemberBy(Guid Membersno)
        {
            return Repository_Member_P.DeleteMemberBy(Membersno);
        }
        #endregion
    }
}