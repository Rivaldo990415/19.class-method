using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.class_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student(70, "John", 15);
            Student student2 = new Student(40, "John", 10);

            Console.WriteLine(student1.IsObese());
            Console.WriteLine(student2.IsObese());

            Console.ReadLine();

        }
    }
}
