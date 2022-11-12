using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ProgramMain
{
    class HashtableExample
    {
        public void HashtableMethods()
        {
            Hashtable htObject = new Hashtable();
            //-------------------------------------------------------
            //USING ADD METHOD
            //-------------------------------------------------------
            Console.WriteLine("Add the element in a Hashtable");
            htObject.Add("Eno", 01);
            htObject.Add("Ename", "xyz");
            htObject.Add("job", "engineer");
            htObject.Add("salary", 10000);
            htObject.Add("Email", "xyz@gamil.com");
            htObject.Add("Location", "delhi");
            //-------------------------------------------------------
            //-------------------------------------------------------
            foreach (object key in htObject.Keys)
            {
                Console.WriteLine(key+"  :  "+ htObject[key]);
            }
            //-------------------------------------------------------
            //USING COUNT
            //-------------------------------------------------------
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("USING COUNT TOTAL NUMBER OF ELEMENT IN A Hashtable" + "  " + htObject.Count);
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------");
            //-------------------------------------------------------
            //USING REMOVE
            //-------------------------------------------------------
            Console.WriteLine("remove the element in a Hashtable");
            htObject.Remove("Eno");
            Console.WriteLine("after use remove method");
            foreach (object key in htObject.Keys)
            {
                Console.WriteLine(key + "  :  " + htObject[key]);
            }
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------");
            //-------------------------------------------------------
            //USING COUNT AFTER REMOVE
            //-------------------------------------------------------
            Console.WriteLine("USING COUNT TOTAL NUMBER OF ELEMENT IN A Hashtable" + "  "+htObject.Count);
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------");
            //-------------------------------------------------------
            //USING Contaions
            //-------------------------------------------------------
            Console.WriteLine("check element is in a Hashtable or not by using contains");
            Console.WriteLine(htObject.Contains("job"));
            Console.WriteLine(htObject.Contains("engineer"));
            Console.WriteLine(htObject.Contains(5000));
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------");
            //-------------------------------------------------------
            //USING ContaionsKey
            //-------------------------------------------------------
            Console.WriteLine("check keys is in a Hashtable or not by using containsKey");
            Console.WriteLine(htObject.ContainsKey("salary"));
            Console.WriteLine(htObject.ContainsKey("dob"));
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------");
            //-------------------------------------------------------
            //USING ContainsValue
            //-------------------------------------------------------
            Console.WriteLine("check values is in a Hashtable or not by using containsValue");
            Console.WriteLine(htObject.ContainsValue(01));
            Console.WriteLine(htObject.Contains("job"));
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------");
            //-------------------------------------------------------
            //USING COUNT BEFORE CLEAR
            //-------------------------------------------------------
            Console.WriteLine("BEFORE CLEAR TOTAL NUMBER OF ELEMENT IN A Hashtable" + "  " + htObject.Count);
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------");
            //-------------------------------------------------------
            //USING CLEAR
            //-------------------------------------------------------
            htObject.Clear();
            //-------------------------------------------------------
            //USING COUNT AFTER CLEAR
            //-------------------------------------------------------
            Console.WriteLine("AFTER CLEAR TOTAL NUMBER OF ELEMENT IN A hashtable" + "  " + htObject.Count);
        }
    }
}
