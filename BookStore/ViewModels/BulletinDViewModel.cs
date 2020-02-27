using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using Models.Table;

namespace BookStore.ViewModels
{
    public class BulletinDViewModel
    {
        public BulletinDViewModel()
        {
          
        }

        [Key]
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

        public List<BulletinM> DataListM { get; set; }
        public List<BulletinD> DataListD { get; set; }

    }
}