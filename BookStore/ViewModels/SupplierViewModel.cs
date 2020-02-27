using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using Models.Table;

namespace BookStore.ViewModels
{
    public class SupplierViewModel
    {
        public SupplierViewModel()
        {

        }

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

        public List<Supplier> DataList { get; set; } 
    }
}