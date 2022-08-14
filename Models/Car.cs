using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carlist.App.Maui.Models
{
    public class Car : BaseEntity
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Vin { get; set; }

    }
}
