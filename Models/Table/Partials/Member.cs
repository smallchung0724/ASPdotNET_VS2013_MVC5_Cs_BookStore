using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Table.Partials
{
    [MetadataType(typeof(MemberMetadata))]
    [Table("Member")]
    public partial class Member
    {
        public class MemberMetadata
        {
            [DisplayName("ID")]
            [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            [Required]
            public Guid Membersno { get; set; }

            [Required]
            public Guid Rolesno { get; set; }

            [DisplayName("帳號")]
            [Required]
            public string Account { get; set; }

            [DisplayName("密碼")]
            [Required]
            [StringLength(12, ErrorMessage = "{0}的長度需介於{2}到{1}.", MinimumLength = 6)]
            [Compare("Password", ErrorMessage = "兩次密碼輸入不一致")]
            public string Password { get; set; }

            [DisplayName("確認密碼")]
            [Required]
            public string re_Password { get; set; }

            [DisplayName("名稱")]
            [Required]
            public string Name { get; set; }

            [DisplayName("信箱")]
            [Required]
            [EmailAddress]
            public string Email { get; set; }

            [DisplayName("驗証碼")]
            public string Authcode { get; set; }

            [DisplayName("建立時間")]
            [Required]
            [DataType(DataType.DateTime)]
            public DateTime Createdt { get; set; }

            [DisplayName("修改時間")]
            public Nullable<DateTime> Modifydt { get; set; }
        }
    }
}
