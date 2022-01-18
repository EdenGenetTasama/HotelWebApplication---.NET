using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelWebApplication.Models
{
    public class Invait
    {
        public Invait(int id, int idOfGuest, int dateOfEmployee, int payedMoneny, int moreToPay, int numOfEmployee)
        {
            Id=id;
            IdOfGuest=idOfGuest;
            DateOfEmployee=dateOfEmployee;
            NumOfEmployee=numOfEmployee;
            PayedMoneny =payedMoneny;
            MoreToPay=moreToPay;
        }

        public int Id { get; set; }
        public int IdOfGuest { get; set; }
        public int NumOfEmployee { get; set; }
        public int DateOfEmployee { get; set; }

        public int PayedMoneny { get; set; }
        public int MoreToPay { get; set; }
    }
}