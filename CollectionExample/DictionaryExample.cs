using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramMain
{
    class DictionaryExample
    {
        public void DictionaryMethod()
        {
            Dictionary<int, string> dtObject = new Dictionary<int, string>();
            //-------------------------------------------------------
            //USING ADD METHOD
            //-------------------------------------------------------
            dtObject.Add(0, "hello");
            dtObject.Add(1, "my");
            dtObject.Add(2, "name");
            dtObject.Add(3, "is");
            dtObject.Add(4, "atul");
            Console.Write("the element is a list-------->");
            foreach (KeyValuePair<int, string> showElements in dtObject)
            {
                Console.Write("{0}  ",showElements.Value);
            }
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------");
            //-----------------------------------------------------
            // Checking whether dtObject is 
            // equal to itself or not 
            //-----------------------------------------------------
            Console.WriteLine("the dictionary is equal to itself or not");
            Console.WriteLine(dtObject.Equals(dtObject));
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------");
            //-----------------------------------------------------
            //create a new dicyionary
            //-----------------------------------------------------
            Dictionary<int, string> dtObject1 = new Dictionary<int, string>();
            //-------------------------------------------------------
            //USING ADD METHOD
            //-------------------------------------------------------
            dtObject1.Add(0, "hello");
            dtObject1.Add(1, "my");
            dtObject1.Add(2, "name");
            dtObject1.Add(3, "is");
            dtObject1.Add(4, "atul");
            //-------------------------------------------------------
            // Checking whether dtObject is 
            // equal to dtObject1 or not
            //-------------------------------------------------------
            Console.WriteLine("the dictionary is equal to other dictionary");
            Console.WriteLine(dtObject.Equals(dtObject1));
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------");
            //-------------------------------------------------------
            //creating a new directory
            //-------------------------------------------------------
            Dictionary<int, string> dtObject2 = new Dictionary<int, string>();
            //// Assigning dtObject1 to dtObject2 
            dtObject2 = dtObject1;
            Console.WriteLine("the dictionary is assign to the new dictionary");
            Console.WriteLine(dtObject1.Equals(dtObject2));
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------");

            //-------------------------------------------------------
            //USING COUNT
            //-------------------------------------------------------
            Console.WriteLine("USING COUNT TOTAL NUMBER OF ELEMENT IN A DICTIONARY" + "  " + dtObject.Count);
            //-------------------------------------------------------
            //USING REMOVE
            //-------------------------------------------------------
            Console.Write("remove the element in a Dictionary---------->");
            dtObject.Remove(0);
            foreach (KeyValuePair<int, string> showElements in dtObject)
            {
                Console.Write("{0}   ",showElements.Value);
            }
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------");
            //-------------------------------------------------------
            //USING COUNT AFTER REMOVE
            //-------------------------------------------------------
            Console.WriteLine("USING COUNT TOTAL NUMBER OF ELEMENT IN A DICTIONARY------->" + "  " + dtObject.Count);
            //-------------------------------------------------------
            //USING CONTAINSKEY
            //-------------------------------------------------------
            Console.WriteLine("check keys is in a Dictionary or not by using containsKeys:");
            if (dtObject.ContainsKey(3) == true)
            {
                Console.WriteLine("key is found");
            }
            else
            {
                Console.WriteLine("key is not found");
            }
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------");
            //-------------------------------------------------------
            //USING CONTAINSVALUES
            //-------------------------------------------------------
            Console.WriteLine("check value is in a Dictionary or not by using containsValues:");
            if (dtObject.ContainsValue("atul") == true)
            {
                Console.WriteLine("value is found");
            }
            else
            {
                Console.WriteLine("value is not found");
            }
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------");
            //-------------------------------------------------------
            //USING COUNT BEFORE CLEAR
            //-------------------------------------------------------
            Console.WriteLine("BEFORE CLEAR TOTAL NUMBER OF ELEMENT IN A Dictionary" + "  " + dtObject.Count);
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------");
            //-------------------------------------------------------
            //USING CLEAR
            //-------------------------------------------------------
            dtObject.Clear();
            //-------------------------------------------------------
            //USING COUNT AFTER CLEAR
            //-------------------------------------------------------
            Console.WriteLine("AFTER CLEAR TOTAL NUMBER OF ELEMENT IN A Dictionary" + "  " + dtObject.Count);
        }
    }
}

