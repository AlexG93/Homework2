using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2._1
{
    class Person
    {
        protected string LastName;
        protected string FirstName;
        protected string DateofBirth;

        public Person(string last, string first, string birth)
        {
            LastName = last;
            FirstName = first;
            DateofBirth = birth;
        }
        public Person()
        {

        }
    }
}
