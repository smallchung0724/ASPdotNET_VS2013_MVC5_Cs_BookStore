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
    [MetadataType(typeof(OrderDMetadata))]
    [Table("OrderD")]
    public partial class OrderD
    {
        public class OrderDMetadata
        {
            [DisplayName("ID")]
            [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            [Required]
            public Guid Orderdtsno { get; set; }

            [Required]
            public Guid Ordersno { get; set; }

            [Required]
            public Guid Productsno { get; set; }

            [DisplayName("項次")]
            [Required]
            [MinLength(0, ErrorMessage = "項次不可小於0")]
            public int serno { get; set; }

            [DisplayName("數量")]
            [Required]
            [MinLength(0, ErrorMessage = "數量不可小於0")]
            public int Quantity { get; set; }

            [DisplayName("建立時間")]
            [Required]
            [DataType(DataType.DateTime)]
            public DateTime Createdt { get; set; }

            [DisplayName("修改時間")]
            public Nullable<DateTime> Modifydt { get; set; }
        }
    }
}
