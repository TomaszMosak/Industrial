﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Program1 //WEEK2
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

        private static ulong commondevisor(ulong a, ulong b) //Exercise 6
        {
            while (a != 0 && b != 0) // both have to have a value
            {
                if (a > b) // as long as a is greater than b do...
                {
                    a %= b; // a mod b
                }
                else // if the above if condition isnt met do this
                {
                    b %= a; // b mod a
                }
            }
            return a == 0 ? b : a; // condition ? consequent : alternative

        }

        private static int[,] matrixmult(int[,] A, int[,] B) //Exercise 7
        {

            int[,] C = new int[A.GetLength(0), B.GetLength(1)]; //find the amount of multiplications required
            if (A.GetLength(0) != B.GetLength(1)) //
                return null;

            for (int i = 0; i < C.GetLength(0); i++)
            {
                for (int j = 0; j < C.GetLength(1); j++)
                {
                    int sum = 0;
                    for (int k = 0; k < A.GetLength(1); k++)
                    {
                        sum += C[i, j] + A[i, k] * B[k, j];
                    }

                    C[i, j] = sum;


                }

            }
            return C;
        }

        static void Main(string[] args)
        {
            //---------------------------------------------------------------------------------------------- WEEK 2

            //Exercise 1

            //Program1 week = new Program1();
            //Console.WriteLine(week.nextday(weekday.Monday));
            //Console.WriteLine(week.nextday(weekday.Friday));
            //Console.WriteLine(week.whatday("Monday"));

            //End Exercise 1

            //Exercise 2

            //Program1 add = new Program1();
            //Console.WriteLine(add.calcsum(5));

            //End Exercise 2

            //Exercise 3

            //Program1 arraysum = new Program1();
            //int[] array = new int[] { 1, 2, 3, 4, 5 };
            //Console.WriteLine(arraysum.arraysum1(array));
            //arraysum.set0(array);
            //foreach (var item in array)
            //{
            //    Console.WriteLine(item.ToString());
            //}


            //End Exercise 3

            //Exercise 4

            //Program1 reader = new Program1();
            //reader.readingnum();
            //Console.WriteLine(reader.shortvalue);
            //Console.WriteLine(reader.intvalue);
            //Console.WriteLine(reader.longvalue);

            //End Exercise 4

            //Exercise 5

            //Program1 complexfun = new Program1();
            //complexfun.complex();

            //End Exercise 5

            //Exercise 6

            //ulong a = 10;
            //ulong b = 26;
            //commondevisor(a, b); //woo
            //Console.WriteLine("Euclid’s greatest common divisor algorithm");
            //Console.Write("Inputs:");
            //Console.Write(a);
            //Console.Write(",");
            //Console.WriteLine(b);
            //Console.Write("Answer:");
            //Console.WriteLine(commondevisor(a, b));

            //END Exercise 6


            //Exercise 7

            //int[,] A = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            //int[,] B = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
            //matrixmult(A, B);
            //int[,] D = matrixmult(A, B);
            //Console.WriteLine("Matrix Multiplication");
            //Console.WriteLine("Printing Matrix: ");
            //for (int i = 0; i < A.GetLength(0); i++)
            //{
            //    for (int j = 0; j < A.GetLength(1); j++)
            //    {
            //        Console.Write(string.Format("{0} ", A[i, j]));
            //    }
            //    Console.Write(Environment.NewLine + Environment.NewLine);
            //}
            //Console.WriteLine("Printing Matrix: ");
            //for (int i = 0; i < B.GetLength(0); i++)
            //{
            //    for (int j = 0; j < B.GetLength(1); j++)
            //    {
            //        Console.Write(string.Format("{0} ", B[i, j]));
            //    }
            //    Console.Write(Environment.NewLine + Environment.NewLine);
            //}

            //Console.WriteLine("Answer:");
            //for (int i = 0; i < D.GetLength(0); i++)
            //{
            //    for (int j = 0; j < D.GetLength(1); j++)
            //    {
            //        Console.Write(string.Format("{0} ", D[i, j]));
            //    }
            //    Console.Write(Environment.NewLine + Environment.NewLine);
            //}

            //END Exercise 7

            //---------------------------------------------------------------------------------------------- WEEK 2

        }
    }

    class Program2 //WEEK 3
    {
        class BankAccount
        {
            protected static ulong latestAccNo = 1000;
            protected ulong AccNo;
            protected decimal balance;
            protected string name;


            public BankAccount(String Name)
            {
                latestAccNo++;
                this.AccNo = latestAccNo;
                this.name = Name;
                this.balance = 0M;
            }

            public BankAccount(ulong Account, String Name)
            {
                this.AccNo = Account;
                this.name = Name;
                this.balance = 0M;
            }

            public void Deposit (decimal x)
            {
                this.balance += x;
            }

            public virtual void Withdrawl (decimal x)
            {
                if (this.balance >= x)
                {
                    this.balance -= x;
                }
                //else
                //{
                //    throw new Exception();
                //}
            }

            public decimal GetBalance()
            {
                return this.balance;
            }

            public void ShowBalance()
            {
                Console.WriteLine("Your balance is: ", this.balance.ToString());
            }

            public virtual void ShowAccount()
            {
                Console.WriteLine("Account Number: {0}/tAccount Name: {1}/tCurrent Balance: {2}/t", this.AccNo, this.name, this.balance.ToString());
            }

            public void RunTrans()
            {
                this.ShowAccount();
                this.ShowBalance();
                this.Deposit(600);
                Console.WriteLine("Deposited: ", 600);
                this.ShowBalance();
                this.Withdrawl(300);
                Console.WriteLine("Withdrew: ", 300);
                this.ShowBalance();
                this.ShowAccount();
            }

            static void Main(string[] args)
            {
                BankAccount first = new BankAccount("Tomasz");
                first.RunTrans();
            }
        }
       
    }
}
