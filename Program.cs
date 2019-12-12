using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDemo
{
    class Program
    { 

        //int result;
        //public void division(int num1, int num2)
        //{

        //    try
        //    {
        //        result = num1 / num2;
        //    }
        //    catch (DivideByZeroException e)
        //    {
        //        Console.WriteLine("Exception caught: {0}", e);
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine("Exception caught: {0}", e);
        //    }
        //    finally
        //    {
        //        Console.WriteLine("Result: {0}", result);
        //    }
        //}
        static void Main(string[] args)
        {
             
            //int[] arr = new int[5];
            //Console.WriteLine(arr.Length);
            ArrayList arrList = new ArrayList();
            arrList.Add(10);
            arrList.Add(10.1);
            arrList.Add("10.6r");
            arrList.Add("Tej");
            foreach (var VARIABLE in arrList)
            {
                Console.WriteLine(VARIABLE);
            }
            //arrList.Add("abc");
            //arrList.Add("abc");
            //arrList.Add("abc");
            //arrList.Add("abc");
            //arrList.Add("abcd");
            //arrList.Add("abc");
            //arrList.Add("abc");
            //arrList.Add("abc");
            //arrList.Add("abc");
            //Console.WriteLine(arrList.Capacity);

            Hashtable ht = new Hashtable();
            ht.Add("s1", "Charan");
            ht.Add("s2", "Sai");
            ht.Add("s3", "Kiran");
            ht.Add("s4", "Tej");
            ht.Add("s5", "Neha");


            foreach (DictionaryEntry entry in ht)
            {
                Console.WriteLine("{0}, {1}", entry.Key, entry.Value);
            }
            //    Program p = new Program();
            //    //p.division(25, 0);
            //    int x = int.Parse(Console.ReadLine());
            //    int y = int.Parse(Console.ReadLine());
            //    if (y > 30)
            //    {
            //        throw new DividedbyMonthException();
            //    }
            //    int z = x / y;
            //    Console.WriteLine("The Result is : " + z);
            //    Console.ReadKey();
        }


    }
    //public class DividedbyMonthException : ApplicationException
    //{
    //    public override string Message
    //    {
    //        get
    //        {
    //            return "Divided by greater than 30";
    //        }
    //    }
    //}
}
