using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new person();
            person.Name = "Asta";
            person.Addres = "Kerajaan Clover";
            person.Ngomong();
            person.TempatId();

            var student = new Student();
            student.Name = "Levi Ackermen";
            student.Identitas = "Panglima Perang";
            student.StatusId();

            


        }
    }
}
