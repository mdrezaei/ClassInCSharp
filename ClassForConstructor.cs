using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3_TopLearn_Class
{
    class ClassForConstructor
    {
        public string UserName;
        public string UserAge;
        public string UserHomeTown;

        public ClassForConstructor(string Name,string Age,string Town)//دقیقا هم اسم کلاس
        {
            this.UserName = Name;// به خود کلاسی که توش هستیم اشاره میکنه this 
            this.UserAge = Age;
            UserHomeTown = Town;
        }
    }
}
