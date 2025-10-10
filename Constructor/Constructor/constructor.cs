using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
 
    public  class Def1
    {
        
        public string name;
        public int age;

            public Def1(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
          
            public void DisplayInfo()
            {
                Console.WriteLine($"Name: {name}, Age: {age}");
        }
    }
}


