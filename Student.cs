using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.class_method
{
    internal class Student
    {
        public double weight;
        public string name;
        public int age;

        public Student(double aWeight, string aName, int aAge)
        {
            this.weight = aWeight;
            this.name = aName;
            this.age = aAge;
        }
        //You now have one stop to test Obesity of your students and
        public bool IsObese()
        {
            if(weight > 60)
            {
                return true;
            }else return false;
        }
    }
}
