using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RmoscosoLabassignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            instructor John = new instructor();
            John.Name = "John";
            John.CourseName = "English";

            instructor Mike = new instructor();
            Mike.Name = "Mike";
            Mike.CourseName = "Math";

            Student Jane = new Student();
            Jane.Name = "Jane";
            Jane.teacher = "John";
            string Print1 = Jane.Print1();
            int sum1 = Jane.Grade(0, 95);

            System.Console.WriteLine(Jane);
            System.Console.WriteLine(sum1);
            System.Console.ReadKey();

            Student Joe = new Student();
            Joe.Name = "Joe";
            Joe.teacher = "John";
            string Print2 = Joe.Print2();
            int sum2 = Joe.Grade(0, 85);

            System.Console.WriteLine(Joe);
            System.Console.WriteLine(sum2);
            System.Console.ReadKey();

            Student Melissa = new Student();
            Melissa.Name = "Melissa";
            Melissa.teacher = "Mike";
            string Print3 = Melissa.Print3();
            int sum3 = Melissa.Grade(0, 90);

            System.Console.WriteLine(Melissa);
            System.Console.WriteLine(sum3);
            System.Console.ReadKey();

            Student Matt = new Student();
            Matt.Name = "Matt";
            Matt.teacher = "Mike";
            string Print4 = Matt.Print4();
            int sum4 = Matt.Grade(0, 92);

            System.Console.WriteLine(Matt);
            System.Console.WriteLine(sum4);
            System.Console.ReadKey();

    }
}
