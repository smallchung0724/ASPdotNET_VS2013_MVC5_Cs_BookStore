using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using Models.Table;

namespace BookStore.ViewModels
{
    public class BulletinMViewModel
    {
        public BulletinMViewModel()
        {
        }

        [Key]
        [DisplayName("ID")]
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

        public List<BulletinM> DataList { get; set; }   
    }
}