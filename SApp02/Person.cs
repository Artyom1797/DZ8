using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SApp02
{
    public class Person
    {

        public Person(string firstName1)
        {
            FirstName = firstName1;
        }

        public Person()
        { 
        }

        public string SecondName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}
