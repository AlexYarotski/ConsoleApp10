using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10.Lesson4.Student
{
    internal abstract class UserConfig
    {
        public string Name 
        { 
            get;
            private set; 
        }

        public string SecondName 
        { 
            get;
            private set;
        }
        
        public UserConfig(string name, string secondName)
        {
            Name = name;
            SecondName = secondName;
        }
    }
}
