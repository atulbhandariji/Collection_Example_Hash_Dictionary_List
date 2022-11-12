using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramMain
{
    class ListExample
    {
        int counter = 0;
        public void ListExampleMethod()
        {
            List<string> employeeList = new List<string>();
            //-------------------------------------------------------
            //USING ADD METHOD
            //-------------------------------------------------------
            employeeList.Add("Atul");
            employeeList.Add("Ashish");
            employeeList.Add("Vijay");
            employeeList.Add("Ashish");
            employeeList.Add("Ashish");
            employeeList.Add("Vipul");
            employeeList.Add("XYZ");
            //--------------------------------------------------------
            //(1) print all employee with the name of Ashish
            //--------------------------------------------------------
            Console.WriteLine("print all employee with name of Ashish");
            foreach (string nameOfEmployee in employeeList)
            {
                if (nameOfEmployee.Contains("Ashish"))
                {
                    counter++;
                    Console.WriteLine(nameOfEmployee);

                }

            }
            if (counter <= 0)
            {
                Console.WriteLine("Ashish name doesn't exists");
            }
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------");
            //-----------------------------------------------------------------------
            //(2) print total number of employee in a list
            //-----------------------------------------------------------------------
            Console.WriteLine("Total Number of Employee in a List is =" + "  " + employeeList.Count);
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------");
            //-----------------------------------------------------------------------
            //(3) print first and last record from list
            //-----------------------------------------------------------------------
            string firstEmployee = employeeList[0];
            string lastEmployee = employeeList[employeeList.Count - 1];

            Console.WriteLine("the name of first employee(record) in a list is=" + " " + firstEmployee + " " +
               "---- and the name of last employee(record) is in a list is=" + " " + lastEmployee);
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------");
            //---------------------------------------------------------------------------
            //(4) check if a person with name XYZ exists in list or not
            //---------------------------------------------------------------------------
            Console.WriteLine(" check if a person with name XYZ exists in list or not");
            if (employeeList.Exists(emplyeeName => emplyeeName==("XYZ")))
            {
                Console.WriteLine("the item exists");
            }
            else
            {
                Console.WriteLine("doesn't exists");
            }

        }
    }
}

