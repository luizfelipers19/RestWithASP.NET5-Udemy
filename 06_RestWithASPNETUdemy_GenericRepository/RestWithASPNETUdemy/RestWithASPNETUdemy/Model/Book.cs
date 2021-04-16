using RestWithASPNETUdemy.Model.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNETUdemy.Model
{
    [Table("books")]
    public class Book : BaseEntity
    {   
        

        [Column("title")]
        public string Title { get; set; }

        [Column("author")]
        public string Author { get; set; }
        [Column("price")]
        public decimal Price { get; set; }
        [Column("launch_date")]
        public DateTime LaunchDate { get; set; }

        

    }
}
