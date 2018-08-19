using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;

namespace Playground
    {
        class Program
            {
            static void Main(string[] args)
            {
                var customer = new MyLibrary.Customer();

                MyLibrary.ICalculate addfunction = new MyLibrary.AddCalculate();
                MyLibrary.ICalculate subtractfunction = new MyLibrary.SubtractCalculate();
                MyLibrary.ICalculate multiplyfunction = new MyLibrary.MultiplyCalculate();

                var result = addfunction.PerformCal(10,10);
                Console.WriteLine("result:" + result);

                MyObject myObject = new MyObject();
                MyObject myObject2 = new MyObject(10, 10);
                myObject.Calculate();
                //myObject.number1 = 10;
                //myObject.number2 = 15;

                //Console.WriteLine("number1: " + myObject.number1());
                //Console.WriteLine("number2: " + myObject.number2());
                Console.WriteLine("number3 is: " + myObject.number3);
                Console.WriteLine("number3 is: " + myObject2.number3);

                Console.ReadLine();
            }
        }
    }
