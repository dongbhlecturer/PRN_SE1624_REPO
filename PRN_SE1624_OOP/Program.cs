﻿/*Lap trinh tao ra mot List cac Employees ma in ra man hinh*/
namespace Prn.Se1624;
using static System.Console;

public class Program
{
    public static void Main()
    {
        /*1. create a object (instance)*/
        /*
        Employee e = new Employee();
        e.Id = 1;
        e.Name = "Bui Huu Dong";
        e.Level = "Senior";
        e.Salary = 1500.55f;
        */
        Employee e = new Employee(1500f,"Junior",1,"Dong",new DateOnly());
        /*2. Create a list Employees and filter and display to console*/


        WriteLine(e);   
        ReadLine();
    }
}
