using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4 {

    public enum ShippingMethod {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }

    public class Person {
        public int Age;
    }

    class Program {

        static void Main(string[] args) {
            var number = 1;
            Increment(number);

            Console.WriteLine("number: {0}", number);

            var person = new Person() { Age = 20 };
        }

        //This will not increment the number, because the variable type.
        public static void Increment(int number) {
            number += 10;
        }
        //This will increment the Age value of the person passed into as arguments
        public static void MakeOld(Person person) {
            person.Age += 10;
        }

        //static void Main(string[] args) {
        //    var a = 10;
        //    var b = a;
        //    b++;
        //    Console.WriteLine(string.Format("a: {0}, b: {1}",a,b));

        //    var array1 = new int[3] { 1,2,3 };
        //    var array2 = array1;
        //    array2[0] = 0;

        //    Console.WriteLine(string.Format("array1: {0}, array2: {1}", array1[0], array2[0]));

        //    Console.ReadLine();
        //}

        //static void Main(string[] args) {
        //    var method = ShippingMethod.Express;
        //    Console.WriteLine((int)method);

        //    var methodId = 3;
        //    Console.WriteLine((ShippingMethod)methodId);

        //    Console.WriteLine(method.ToString());

        //    var methodName = "Express";
        //    var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);

        //    Console.WriteLine(shippingMethod);

        //    Console.ReadLine();
        //}

//        static void Main(string[] args) {

//            var numbers = new int[3];
//            numbers[0] = 1;

//            Console.WriteLine(numbers[0]);
//            Console.WriteLine(numbers[1]);
//            Console.WriteLine(numbers[2]);

//            string firstName = "Chris";
//            string lastName = "White";
//            string fullName = firstName + " " + lastName;
//            string myFullName = string.Format("My name is {0} {1}",firstName,lastName);
//            Console.WriteLine(myFullName);

//            Console.ReadLine();

//            var text = @"Hi John
//Look into the following paths
//    c:\folder1\folder2
//    c:\folder3\folder4";
//            Console.WriteLine(text);
//            Console.ReadLine();
//        }
    }
}
