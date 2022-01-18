using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelWebApplication.Models
{
    public class CEO
    {
        public CEO(int id, string fullName, int payment, int age)
        {
            Id=id;
            FullName=fullName;
            Payment=payment;
            Age=age;
        }

        public int Id { get; set; }
        public string FullName { get; set; }
        public int Payment { get; set; }
        public int Age { get; set; }

        static public List<CEO> CEOlist = new List<CEO>()
        {
        new CEO(0 , "EdenTasama", 20000 , 25 ),
        new CEO(1 , "Daniel Tal" , 30000 , 26),
        new CEO(2 , "Oshra Tasama" , 40000 , 29 ),

        };
    }

}