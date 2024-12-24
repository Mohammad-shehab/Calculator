//1. Create 3 functions  name : Add
//2.First one 2 Parameter and sum 
//3. Calc summation of 3 parameters
//4. 3 parameters , Calc Summation
//5. Print Salary with bounce (Work hour * hour rate=10 KD)
//6. Call function by main program and print all result


using System;
using TaskCalculatorFunctions.Models;

Console.WriteLine("Function 1");
Console.WriteLine("Enter 2 numbers: ");
double num1 = Convert.ToDouble(Console.ReadLine());
double num2 = Convert.ToDouble(Console.ReadLine());
Class1 sum = new Class1();

Console.WriteLine($"Sum :  {sum.add(num1, num2)}");


////////////////////////////////////////////////////////////


Console.WriteLine("------------------------------------------");

Console.WriteLine("Function 2");
Console.WriteLine("Enter 3 numbers: ");
double num3 = Convert.ToDouble(Console.ReadLine());
double num4 = Convert.ToDouble(Console.ReadLine());
double num5 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Sum :  {sum.add(num3, num4, num5)}");


////////////////////////////////////////////////////////////
Console.WriteLine("------------------------------------------");


Console.WriteLine("Function 3 (INTEGERS ONLY)");
Console.WriteLine("Enter 3 numbers: ");
int num6 = Convert.ToInt32(Console.ReadLine());
int num7 = Convert.ToInt32(Console.ReadLine());
int num8 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Sum :  {sum.add(num6, num7, num8)}");

////////////////////////////////////////////////////////////
Console.WriteLine("------------------------------------------");


Console.WriteLine("Function 4");
Console.WriteLine("Enter your salary: ");
double salary = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter your work hours: ");
int work_hour = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(sum.salary(salary, work_hour));





