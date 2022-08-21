using System;
using System.Collections.Generic;
using System.Linq;

using System.Web;
using System.IO;
using U19106832_HW04.Models;

namespace U19106832_HW04.Models
{
    public class RegisterClient:ClientInfo
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public string TypeOfEvent { get; set; }
        public string Company { get; set; }
        public int AmountDonated { get; set; }
        public int DateType { get; set; }

    }
    public RegisterClient()
    {

    }

    public RegisterCLient(string Name, string Surname, string TypeOfEvent, string Company, int AmountPeople) base(fname, sname, Tevent, cname, apeople)
{
    public string Name = new name();
    public string Surname = new sname();
    public string TypeOfEvent = new tevent();
    public string Company = new Cname();
    public int AmountDonated = new adonated();
    public int DateType = new DateTime();
}
}