using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManufacturerCode.ViewModel
{
    public class ChildManufacturer
    {
        public bool IsSelected { get; set; }

        public string ChildCode { get; set; }


        public static List<ChildManufacturer> GetChildManufacturers()
        {
            List<ChildManufacturer> childManufacturers = new List<ChildManufacturer>
            {
                new ChildManufacturer{ IsSelected = true, ChildCode = "AGO"},
                new ChildManufacturer{ IsSelected = true, ChildCode = "AG4"},
                new ChildManufacturer{ IsSelected = true, ChildCode = "APO"},
                new ChildManufacturer{ IsSelected = true, ChildCode = "AP4"},
                new ChildManufacturer{ IsSelected = true, ChildCode = "APN"},
                new ChildManufacturer{ IsSelected = true, ChildCode = "APW"},
            };


            return childManufacturers;
        }
    }
}
