using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Models.Interface;
using Models.Table;

namespace Models.Repository
{
    public class Repository_Member_Cs : Repository_Member_if
    {
        BookStoreContext db;

        public Repository_Member_Cs()
        {
            if (db == null)
                db = new BookStoreContext();
        }

        #region Member 操作
        public IQueryable<Member> AllMemberFill()
        {
            IQueryable<Member> SearchData = db.Member.OrderBy(m => m.Account);

            return SearchData;
        }

        public Member MemberFillBy(Guid Membersno)
        {
            Member SearchData = db.Member.Find(Membersno);

            return SearchData;
        }

        public int MemberCount()
        {
            int Count = db.Member.Count();

            return Count;
        }

        public bool InsertMember(Member memberData)
        {
            if (memberData == null)
                return false;

            db.Member.Add(memberData);

            db.SaveChanges();

            return true;
        }

        public bool UpdateMemberBy(Member memberData)
        {
            Member OldData = db.Member.Find(memberData.Membersno);

            if (OldData == null)
                return false;

            OldData.Rolesno = memberData.Rolesno;
            OldData.Password = memberData.Password;
            OldData.re_Password = memberData.re_Password;
            OldData.Name = memberData.Name;
            OldData.Email = memberData.Email;
            OldData.Authcode = memberData.Authcode;
            OldData.Modifydt = DateTime.Now;

            db.SaveChanges();

            return true;
        }

        public bool DeleteMemberBy(Guid Membersno)
        {
            Member OldData = db.Member.Find(Membersno);

            if (OldData == null)
                return false;

            db.Member.Remove(OldData);

            db.SaveChanges();

            return true;
        }
        #endregion
    }
}
