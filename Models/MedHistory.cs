using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using U19106832_HW04.Models;
using System.Web;

namespace U19106832_HW04.Models
{
    public class MedHistory : ClientInfo
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public string TypeOfEvent { get; set; }
        public string Company { get; set; }
        public int AmountPeople { get; set; }
        public int DateType { get; set; }
    }
    public MedHistory()
    {

    }

    public MedHistory(string Name, string Surname, string TypeOfEvent, string Company, int AmountPeople) base(fname, sname, Tevent, cname, apeople)
 {
    public string Name = new name();
    public string Surname = new sname();
    public string TypeOfEvent = new tevent();
    public string Company = new Cname();
    public int AmountPeople = new apeople();
    public int DateType = new DateTime();
}
}


