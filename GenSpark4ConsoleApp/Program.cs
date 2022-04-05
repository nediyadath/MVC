
using GenSpark4ConsoleApp.Abstraction;
using GenSpark4ConsoleApp.DAL;
using GenSpark4ConsoleApp.Models;
using GenSpark4ConsoleApp.Mycode;
using GenSpark4ConsoleApp.Vehicles;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Net.Mail;
using System.Text;

namespace GenSpark4ConsoleApp
{
    class Program
    {

        //Inheritance, Polymorphism, Encapsulation, Abstraction

        static void Main(string[] args)
        {
            ConstructorExampleClass obj = new ConstructorExampleClass(10);
            IA ab = new Test();
            ab.M1();
            int a = 0;
            int b = 1;
            int c = a + b;
            for(int i = 0; i < 100; i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;

                b = c;

            }

            CRUD cr = new CRUD();
            DataTable dt = cr.FetchPatients();
            foreach (DataRow drow in dt.Rows)
            {
                //Console.WriteLine(
                //    int.Parse(drow["id"].ToString()) + " | " + drow["name"].ToString()
                //    );

                Console.WriteLine(int.Parse(drow["id"].ToString()) + " | " + drow["name"].ToString());

                //}
                Console.ReadLine();
            }
        }


        public enum DOW
        {
            Sun, Mon, Tue, Wed, Thu, Fri, Sat
        }

    }

    public interface IA
    {
        void M1();
    }

    public class Test: IA
    {
        public void M1() { }
    }
}
