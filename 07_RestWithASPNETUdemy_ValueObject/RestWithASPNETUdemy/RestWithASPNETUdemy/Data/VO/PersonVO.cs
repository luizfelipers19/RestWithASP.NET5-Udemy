using RestWithASPNETUdemy.Model.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNETUdemy.Data.VO
{

   
    public class PersonVO
    {
        public long Id { get; set; }

        
        public string FirstName { get; set; }

        
        public string LastName { get; set; }

        
        public string Address { get; set; }

        
        public string Gender { get; set; }


    }
}
