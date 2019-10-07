﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Program
    {
        public enum weekday { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday } //exercise 1 list
        public enum workday { Monday, Tuesday, Wednesday, Thursday, Friday } //exercise 1 list

        public int shortvalue = 0; //exercise 4 counter
        public int intvalue = 0; //exercise 4 counter
        public int longvalue = 0; //exercise 4 counter

        public string nextday (weekday CurrDay)
        {
            int dayIndex = (int)CurrDay;

            return Enum.GetName(typeof(weekday), dayIndex + 1);
        } //exercise 1

        public string whatday (string day)
        {
            if(Array.Exists(Enum.GetNames(typeof(workday)), x => x == day))
            {
                return "Workday";
            }else
            {
                return "Weekday";
            }
        } //exercise 1

        public int calcsum (int maxnum) //exercise 2
        {
            int adder = 0;
            for (int i = 1; i <= maxnum; i++)
            {
                adder = adder + i;
            }
            return adder;
        }

        public int arraysum1(int[] array) //exercise 3
        {
            
            int sum = 0;
            foreach (int item in array)
            {
                sum += item;
            }
                

            return sum;
        }
        
        public int[] set0 (int[] array) //exercise 3
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = 0;
            }
            return array;
        }

        public void readingnum () //Exercise 4
        {
            String input = null;
            Console.WriteLine("To finish, write exit");

            do
            {
                Console.WriteLine("Write a number");
                Console.WriteLine("To write a ushort: Range - 0 - 65,535");
                Console.WriteLine("To write a uint: Range - 65,536 - 4,000,000,000");
                Console.WriteLine("To write a ulong: Range - 4,000,000,000 - V Big Number Bro");
                input = Console.ReadLine();
                if (input == "exit")
                {
                    return;
                }

                ulong inputnum = Convert.ToUInt64(input);
                

                if (inputnum <= ushort.MaxValue)
                {
                    shortvalue++;
                }
                else if (inputnum <= uint.MaxValue)
                {
                    intvalue++;
                }
                else if (inputnum <= ulong.MaxValue)
                {
                    longvalue++;
                }

            } while (input != "exit");

            return;
        } 

        public struct Complex //Exercise 5
        {
            public int real;
            public int imaginary;
            public Complex(int real, int imaginary)
            {
                this.real = real;
                this.imaginary = imaginary;
            }

            public static Complex operator +(Complex one, Complex two)
            {
                return new Complex(one.real + two.real, one.imaginary + two.imaginary);
            }

            public static Complex operator -(Complex one, Complex two)
            {
                return new Complex(one.real - two.real, one.imaginary - two.imaginary);
            }

            public static Complex operator *(Complex one, Complex two)
            {
                return new Complex(one.real * two.real, one.imaginary * two.imaginary);
            }

            public static Complex operator /(Complex one, Complex two)
            {
                return new Complex(one.real / two.real, one.imaginary / two.imaginary);
            }

            public override string ToString()
            {
                return (String.Format("{0} | {1}i", real, imaginary));
            }
        }

        public void complex() //Exercise 5
        {
            String input = null;

            Console.WriteLine("Type add, minus, multiply, divide or exit to finish");

            do
            {
                input = Console.ReadLine();

                Complex val1 = new Complex(7, 1);
                Complex val2 = new Complex(2, 6);

                if (input == "add")
                {
                    // Add both of them
                    Complex res = val1 + val2;
                    Console.WriteLine("First:  {0}", val1);
                    Console.WriteLine("Second: {0}", val2);

                    // display the result
                    Console.WriteLine("Result (Sum): {0}", res);
                   
                }
                else if (input == "minus")
                {
                    Complex res = val1 - val2;
                    Console.WriteLine("First:  {0}", val1);
                    Console.WriteLine("Second: {0}", val2);

                    // display the result
                    Console.WriteLine("Result (Sum): {0}", res);
                    
                }
                else if (input == "multiply")
                {
                    Complex res = val1 * val2;
                    Console.WriteLine("First:  {0}", val1);
                    Console.WriteLine("Second: {0}", val2);

                    // display the result
                    Console.WriteLine("Result (Sum): {0}", res);
                    
                }
                else if (input == "divide")
                {
                    Complex res = val1 - val2;
                    Console.WriteLine("First:  {0}", val1);
                    Console.WriteLine("Second: {0}", val2);

                    // display the result
                    Console.WriteLine("Result (Sum): {0}", res);
                    
                }
            } while (input != "exit");
            return;
        }

        static void Main(string[] args)
        {
            //Exercise 1

            //Program week = new Program();
            //Console.WriteLine(week.nextday(weekday.Monday));
            //Console.WriteLine(week.nextday(weekday.Friday));
            //Console.WriteLine(week.whatday("Monday"));

            //End Exercise 1

            //Exercise 2

            //Program add = new Program();
            //Console.WriteLine(add.calcsum(5));

            //End Exercise 2

            //Exercise 3

            //Program arraysum = new Program();
            //int[] array = new int[] { 1, 2, 3, 4, 5 };
            //Console.WriteLine(arraysum.arraysum1(array));
            //arraysum.set0(array);
            //foreach (var item in array)
            //{
            //    Console.WriteLine(item.ToString());
            //}


            //End Exercise 3

            //Exercise 4

            //Program reader = new Program();
            //reader.readingnum();
            //Console.WriteLine(reader.shortvalue);
            //Console.WriteLine(reader.intvalue);
            //Console.WriteLine(reader.longvalue);

            //End Exercise 4

            //Exercise 5

            Program complexfun = new Program();
            complexfun.complex();

            //End Exercise 5

        }
    }
}