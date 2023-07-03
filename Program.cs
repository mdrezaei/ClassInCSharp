using System;

namespace ConsoleApp3_TopLearn_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            int PublicSumMethod = SecondClassForMethods.PublicSumMethod(4, 3);
            Console.WriteLine(PublicSumMethod);//میشه از اسم مشابه با متد استفاده کرد چون اون متد در کلاس دیگر و این وریبل در این کلاس دیگر اند
            Console.WriteLine(SecondClassForMethods.PublicSumMethod(4, 5));

            ThirdClassForField User1 = new ThirdClassForField();
            //User1.UserName = "Ali";//چون استاتیک هست فیلدش ارور میده
            ThirdClassForField.UserName = "Ali";//باید این طوری مقدار دهی بشود
            string UserName2 = ThirdClassForField.UserName = "Ali";
            //مشخصا این شکلی هم میشود بهتره
            User1.UserAge = 17;
            User1.UserId = "1Ali17";
            //چون استاتیک نبود مجبور به نمونه سازی شدیم و مانند خط 11 و 9 کارینکردیم
            Console.WriteLine(User1);
            //باید بگیم کدوم بخش از کلاس ما چاپ شود. اگر فقط اسم کلاس نمونه سازی شده را بنویسیم ، ادرس کلاسی که برای چاپ صداش زدیم را، چاپ میکند. چون انجاست که اطلاعات ذخیره است. باید و باید همیشه مشخص کنیم چه چیزی را از کلاس ها میخواهیم. نه اینکه فقط جا را بگیم، یعنی اسم کلاس را بگیم . باید جاش و چیز مورد نظر را که میتواند فیلد باشد یا متد یا چیز های دیگر را مشخص کنیم
            Console.WriteLine(ThirdClassForField.UserName + " " + User1.UserAge + " " + User1.UserId);
            //فیلد استاتیک به شکل بالا هم پرینت میشود حتی اگر درون استرینگ میریختیمش و باز هم مانند بالا استفاده اش میکردیم هم پرینت میشد
            Console.WriteLine(UserName2 + " " + User1.UserAge + " " + User1.UserId);
            //مشخصا این شکلی هم میشود بهتره

            ClassForConstructor User2 = new ClassForConstructor("Ali", "17", "Karaj");           
            Console.WriteLine($"Name = {User2.UserName} Age = {User2.UserAge} Town = {User2.UserHomeTown}");//علامت دلار قبل دابل کتیشن کمک میکنه وسط عبارت بعد باز کردن {} بلاک کد بزنیم
            Console.WriteLine(User2.UserName + " " + User2.UserAge + " " + User2.UserHomeTown);

            //نهوه کار کانستراکتور کلاس
            //وقتی کلاس صدا نمونه سازی میشه یکبار کانستراکتورش ساخته میشود
            SecondClassFoeConstructor User3 = new SecondClassFoeConstructor();

            SecondClassFoeConstructor User4 = new SecondClassFoeConstructor();
            Console.WriteLine(User4.UserName + " " + User4.UserAge + " " + User4.UserHomeTown);
        }
    }
}
