using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2._1
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee Alex = new Employee("Gingalau", "Alexandru", "Ianuarie", "Martie", "Milioane", 25);

            Leave Concediu = new Leave("Decembrie", 232, "Concediu");
            Alex.DisplayInfo();

            try
            {
                Alex.AddNewLeave(Concediu, Alex);
            }
            catch (Exception)
            {


            };
            Alex.DisplayInfo();
            Console.ReadLine();


        }
    }
}
