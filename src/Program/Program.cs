using System;

namespace UnitTestAndDebug
{
    class Program
    {
        static void Main(string[] args)
        {
            Person john = new Person("John Doe", "1.234.567-8", "19-04-1991");
            Person jane = new Person("Jane Doe", "8.765.432-1", "01-01-2000");
       //     Person nacho = new Person("Nacho", "4.928.322-7");

            john.IntroduceYourself();
            jane.IntroduceYourself();
        }
    }
}
