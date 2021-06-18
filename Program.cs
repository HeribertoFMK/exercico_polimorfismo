using System;
using System.Collections.Generic;
using exercicioherpoli.Entities;
using System.Globalization;


namespace exercicioherpoli
{
    class Program
    {
        static void Main(string[] args)
        {
           
           List<Employee> list = new List<Employee>();


           
            Console.WriteLine("Enter the number of employees:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {

                System.Console.WriteLine($"Employee #{i} data:");
                System.Console.Write("Outsourced (y/n)?");
                char x = char.Parse(Console.ReadLine());
                System.Console.Write("Name: ");
                string name = Console.ReadLine();
                System.Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                System.Console.WriteLine("Value per hour:");
                double valueperhours = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                if (x == 'y')
                {
                    System.Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    list.Add(new OutsourceEmployee(name, hours, valueperhours, additionalCharge));

                }else{

                    list.Add(new Employee(name, hours, valueperhours));



                }
                

                               

               


            }

            System.Console.WriteLine("PAYMENTS: ");
            foreach (Employee item in list)
            {
                System.Console.WriteLine(item.Name + " $ " + item.Payment().ToString("F2", CultureInfo.InvariantCulture));

            }

        }
    }
}



