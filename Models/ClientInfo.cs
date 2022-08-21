using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using U19106832_HW04.Controllers;
using U19106832_HW04.Models;

namespace U19106832_HW04.Models
{
    public abstract class ClientInfo
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string TypeOfEvent { get; set; }
        public string Company { get; set; }
        public int AmountPeople { get; set; } = 500; 

    }
    public ClientInfo(string Name, string Surname, string TypeOfEvent, string Company, int AmountPeople)
    {
        Name = fname;
        Surname = sname;
        TypeOfEvent = tcondition;
        Company = cname;
        AmountPeople = adonated;

    }
}