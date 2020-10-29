using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    [Serializable]
    public class Employee
    {
        public int ID { get; set; }
        public string name { get; set; }

        public double SSNumber { get; set; }

        public DateTime EntryDate { get; set; }
    }
}
