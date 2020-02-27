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
    [MetadataType(typeof(TrollerMMetadata))]
    [Table("TrollerM")]
    public partial class TrollerM
    {
        public class TrollerMMetadata
        {
            [DisplayName("ID")]
            [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            [Required]
            public Guid Trollersno { get; set; }

            [DisplayName("購物車編號")]
            [Required]
            public string Trollerno { get; set; }

            [DisplayName("購物車日期")]
            [Required]
            [DataType(DataType.DateTime)]
            public DateTime Trollerdate { get; set; }

            [Required]
            public Guid Membersno { get; set; }

            [DisplayName("是否成立訂單")]
            [Required]
            public bool IsOrder { get; set; }

            [DisplayName("建立時間")]
            [Required]
            [DataType(DataType.DateTime)]
            public DateTime Createdt { get; set; }

            [DisplayName("修改時間")]
            public Nullable<DateTime> Modifydt { get; set; }
        }
    }
}
