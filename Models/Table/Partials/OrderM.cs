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
    [MetadataType(typeof(OrderMMetadata))]
    [Table("OrderM")]
    public partial class OrderM
    {
        public class OrderMMetadata
        {
            [DisplayName("ID")]
            [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            [Required]
            public Guid Ordersno { get; set; }

            [DisplayName("訂單編號")]
            [Required]
            public string Orderno { get; set; }

            [DisplayName("訂單日期")]
            [Required]
            [DataType(DataType.DateTime)]
            public DateTime Orderdate { get; set; }

            [Required]
            public Guid Membersno { get; set; }

            //[Required]
            //public Guid Trollersno { get; set; }

            [DisplayName("建立時間")]
            [Required]
            [DataType(DataType.DateTime)]
            public DateTime Createdt { get; set; }

            [DisplayName("修改時間")]
            public Nullable<DateTime> Modifydt { get; set; }
        }
    }
}
