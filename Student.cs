using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Class_Methods
{
    internal class Student
    {
        //Variables
        public int age;
        public string name;
        public double weight;
        public Double height;

        //Constructors
        public Student(string name,int age, double weight,double height)
        {
            this.age = age;
            this.name = name;
            this.weight = weight;
            Idealbw = height;
           
        }

        //Checks the obese of students
        public bool IsObese()
        {
            if (this.weight > 60)
            {
                return true;
            }else
            {
                return false;
            }
        }


        //calculates the ideal body weight 
        public Double Idealbw
        {
            get { return this.height; }
            set
            {
                this.height = (value - 100);
                
            }
        }

    }
}
