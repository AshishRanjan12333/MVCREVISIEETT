using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCREVISIEETT.Models
{
    public class Customer
    {

        public int Id { get; set; }
        public string C_Name { get; set; }
        public string C_Email { get; set; }
        public string C_Mobile { get; set; }
        public string C_Gender { get; set; }
        public Location location { get; set; }



    }
}
