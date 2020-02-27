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
    [MetadataType(typeof(SupplierMetadata))]
    [Table("Supplier")]
    public partial class Supplier
    {
        public class SupplierMetadata
        {
            [Key]
            [Required]
            public Guid Suppsno { get; set; }

            [DisplayName("名稱")]
            [Required]
            public string Name { get; set; }

            [DisplayName("信箱")]
            [Required]
            [EmailAddress]
            public string Email { get; set; }

            [DisplayName("電話")]
            [Required]
            public string Phone { get; set; }

            [DisplayName("傳真")]
            [Required]
            public string Fax { get; set; }

            [DisplayName("地址")]
            [Required]
            public string Adress { get; set; }

            [DisplayName("建立時間")]
            [Required]
            [DataType(DataType.DateTime)]
            public DateTime Createdt { get; set; }

            [DisplayName("修改時間")]
            public Nullable<DateTime> Modifydt { get; set; }
        }
    }
}
