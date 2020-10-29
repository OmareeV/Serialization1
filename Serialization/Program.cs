using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml; 
using System.Xml.Serialization;
using System.IO;

namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();

            emp.ID = 123;
            emp.name = "Nerd";
            emp.SSNumber = 123456789;
            emp.EntryDate = DateTime.Now;

            Console.WriteLine($"Employee ID: {emp.ID} \nEmployee Name: {emp.name}\nEmployee SS# {emp.SSNumber}\nDate Created:{emp.EntryDate}");
        }
    }
}
