using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskCalculatorFunctions.Models
{
    internal class Class1
    {

        public double add(double num1, double num2)
        {
            return num1 + num2; 
        }
        public double add(double num1, double num2,double num3)
        {
            return   num1 + num2 + num3;
        }

        public int add(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }


        public string salary(double salary, int work_hour)
        {




            return $"Total salary: {salary+(work_hour*10)}";
        }






    }
}
