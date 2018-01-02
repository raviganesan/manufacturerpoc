using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManufacturerCode.ViewModel
{
    public class Manufacturer
    {
        public string Code { get; set; }

        public string ManufacturerName { get; set; }

        public string CodeManufacturerName { get { return this.Code + " - " + this.ManufacturerName; } }

        public static List<Manufacturer> GetManufacturers()
        {
            List<Manufacturer> manufacturers = new List<Manufacturer>();

            for (int i = 0; i <= 25; i++)
            {
                manufacturers.Add(new Manufacturer { Code = i + "A", ManufacturerName = "Test" + i });
            }

            return manufacturers;

        }
    }
}
