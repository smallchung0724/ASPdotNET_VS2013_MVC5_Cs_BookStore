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
    [MetadataType(typeof(BulletinDMetadata))]
    [Table("BulletinD")]
    public partial class BulletinD
    {
        public class BulletinDMetadata
        {
            [DisplayName("ID")]
            [Key]
            [Required]
            public Guid Bulletindtsno { get; set; }

            [Required]
            public Guid Bulletinsno { get; set; }

            [DisplayName("名稱")]
            [Required]
            public string Name { get; set; }

            [DisplayName("排序")]
            [Required]
            public int Sort { get; set; }

            [DisplayName("是否使用")]
            [Required]
            public bool IsEnable { get; set; }

            [DisplayName("是否為圖片")]
            [Required]
            public bool IsImage { get; set; }

            [DisplayName("檔案位置")]
            public string Url { get; set; }

            [DisplayName("註解")]
            public string Alt { get; set; }

            [DisplayName("超連結")]
            public string Href { get; set; }

            [DisplayName("建立時間")]
            [Required]
            [DataType(DataType.DateTime)]
            public DateTime Createdt { get; set; }

            [DisplayName("修改時間")]
            public Nullable<DateTime> Modifydt { get; set; }
        }
    }
}
