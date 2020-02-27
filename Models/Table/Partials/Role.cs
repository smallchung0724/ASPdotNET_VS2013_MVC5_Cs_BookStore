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
    public partial class Role
    {
        [MetadataType(typeof(RoleMetadata))]
        [Table("Role")]
        public class RoleMetadata
        {
            [DisplayName("ID")]
            [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            [Required]
            public Guid Rolesno { get; set; }

            [DisplayName("名稱")]
            [Required]
            public string Name { get; set; }

            [DisplayName("排序")]
            [Required]
            public int Sort { get; set; }

            [DisplayName("是否使用")]
            [Required]
            public bool IsEnable { get; set; }

            [DisplayName("建立時間")]
            [Required]
            [DataType(DataType.DateTime)]
            public DateTime Createdt { get; set; }

            [DisplayName("修改時間")]
            public Nullable<DateTime> Modifydt { get; set; }
        }
    }
}
