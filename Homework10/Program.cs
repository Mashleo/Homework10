using System;
using System.Collections;
using System.Collections.Generic;
using ClassLibrary;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {


            var item1 = new MyItem { age = 10, name = "Mike" };
            var item2 = new MyItem { age = 20, name = "Nick" };
            var item3 = new MyItem { age = 40, name = "Alex" };
            var item4 = new MyItem { age = 30, name = "Ivan" };
            var item5 = new MyItem { age = 70, name = "Dmitro" };
            var item6 = new MyItem { age = 50, name = "Leo" };
            var myList = new MyList();
            
            myList.Add(item1);
            myList.Add(item2);
            myList.Add(item3);
            myList.Add(item3);
            myList.Add(item3);
            myList.Add(item3);
            myList.Add(item3);
            myList.Add(item4);
            myList.Add(item5);
            myList.Add(item6);
            Console.WriteLine(myList.Contains(item3));// итем 3 есть?

            foreach (var item in myList.storage) //удаляем все элементы, а не первый
            {
                myList.Remove(item3);
            }
            Console.WriteLine(myList.Contains(item3));// итем 3 есть?
            myList.Insert(3, item3);
            Console.WriteLine(myList.Contains(item3));// итем 3 есть?




            Console.WriteLine(myList.IndexOf(item3));
            myList.Insert(5, item4);


            foreach (var item in myList.storage)
            {
                if (item==null)
                {
                    break;

                }
                Console.WriteLine(item.ToString());
            }
            myList.Clear();



        }
    }
    
    
}
