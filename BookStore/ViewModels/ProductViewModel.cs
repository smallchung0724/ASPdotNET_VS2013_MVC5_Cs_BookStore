using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using Models.Table;

namespace BookStore.ViewModels
{
    public class ProductViewModel
    {
        public ProductViewModel()
        {

        }

        [Key]
        //[Required]
        public Guid Productsno { get; set; }

        [DisplayName("名稱")]
        //[Required]
        public string Name { get; set; }

        [DisplayName("作者")]
        //[Required]
        public string Author { get; set; }

        //[Required]
        public Guid Suppsno { get; set; }

        [DisplayName("出版日期")]
        //[Required]
        [DataType(DataType.DateTime)]
        public DateTime Publish { get; set; }

        [DisplayName("定價")]
        //[Required]
        [MinLength(0, ErrorMessage = "定價不可小於0")]
        public double ActualPrice { get; set; }

        [DisplayName("售價")]
        //[Required]
        [MinLength(0, ErrorMessage = "售價不可小於0")]
        public double UnitPrice { get; set; }

        [DisplayName("折扣數")]
        //[Required]
        public double Discount { get; set; }

        [DisplayName("語言")]
        //[Required]
        public string Language { get; set; }

        [DisplayName("頁數")]
        //[Required]
        [MinLength(1, ErrorMessage = "頁數不可小於1")]
        public int PageNumber { get; set; }

        [DisplayName("ISBN")]
        //[Required]
        public string ISBN { get; set; }

        [DisplayName("檔案位置")]
        public string Url { get; set; }

        [DisplayName("註解")]
        public string Alt { get; set; }

        [DisplayName("超連結")]
        public string Href { get; set; }

        [DisplayName("商品描述")]
        public string Describe { get; set; }

        [DisplayName("目錄大網")]
        public string Outline { get; set; }

        [DisplayName("商品內容")]
        public string Contents { get; set; }

        public List<Product> DataList { get; set; }   
 
    }
}