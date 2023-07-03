using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3_TopLearn_Class
{
    class SecondClassForMethods
    {
        //Private فقط در کلاس خودش 
        //Public همهجا
        //Protcted فقد جازه دسترسی متغیرها و متدها از کلاس و زیرکلاس را می دهد. بدین معنا که متدها می توانند از داخل کلاس و کلاسی که از آن ارث بری کرده است قابل دسترسی باشند.
        //internal فقط در نیم اسپیس خودش یا در همان پروژه خودش هر سلوشن میتونه چند نیماسپیس(پروژه) داشته باشه      
        private static int PrivateSumMethod(int a,int b)
        {
            return a + b;
        }

        public static int PublicSumMethod(int a, int b)
        {
            Console.WriteLine(PrivateSumMethod(5,10));
            return a + b;
        }


    }
}
