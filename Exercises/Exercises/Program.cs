using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises {
    class Program //week 2
    {
        public enum weekday { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday } //exercise 1 list
        public enum workday { Monday, Tuesday, Wednesday, Thursday, Friday } //exercise 1 list

        public int shortvalue = 0; //exercise 4 counter
        public int intvalue = 0; //exercise 4 counter
        public int longvalue = 0; //exercise 4 counter

        public string nextday(weekday CurrDay) {
            int dayIndex = (int)CurrDay;

            return Enum.GetName(typeof(weekday), dayIndex + 1);
        } //exercise 1

        public string whatday(string day) {
            if (Array.Exists(Enum.GetNames(typeof(workday)), x => x == day)) {
                return "Workday";
            } else {
                return "Weekday";
            }
        } //exercise 1

        public int calcsum(int maxnum) //exercise 2
        {
            int adder = 0;
            for (int i = 1; i <= maxnum; i++) {
                adder = adder + i;
            }
            return adder;
        }

        public int arraysum1(int[] array) //exercise 3
        {

            int sum = 0;
            foreach (int item in array) {
                sum += item;
            }


            return sum;
        }

        public int[] set0(int[] array) //exercise 3
        {
            for (int i = 0; i < array.Length; i++) {
                array[i] = 0;
            }
            return array;
        }

        public void readingnum() //Exercise 4
        {
            String input = null;
            Console.WriteLine("To finish, write exit");
            Console.WriteLine("Write a number");
            Console.WriteLine("To write a ushort: Range from 0 - 65,535");
            Console.WriteLine("To write a uint: Range from 65,536 - 4,000,000,000");
            Console.WriteLine("To write a ulong: Range from 4,000,000,000 - V Big Number Bro");

            do {
                
                input = Console.ReadLine();
                if (input == "exit") {
                    return;
                }

                ulong inputnum = Convert.ToUInt64(input);


                if (inputnum <= ushort.MaxValue) {
                    shortvalue++;
                } else if (inputnum <= uint.MaxValue) {
                    intvalue++;
                } else if (inputnum <= ulong.MaxValue) {
                    longvalue++;
                }

            } while (input != "exit");

            return;
        }

        public struct Complex //Exercise 5
        {
            public int real;
            public int imaginary;
            public Complex(int real, int imaginary) {
                this.real = real;
                this.imaginary = imaginary;
            }

            public static Complex operator +(Complex one, Complex two) {
                return new Complex(one.real + two.real, one.imaginary + two.imaginary);
            }

            public static Complex operator -(Complex one, Complex two) {
                return new Complex(one.real - two.real, one.imaginary - two.imaginary);
            }

            public static Complex operator *(Complex one, Complex two) {
                return new Complex(one.real * two.real, one.imaginary * two.imaginary);
            }

            public static Complex operator /(Complex one, Complex two) {
                return new Complex(one.real / two.real, one.imaginary / two.imaginary);
            }

            public override string ToString() {
                return (String.Format("{0} | {1}i", real, imaginary));
            }
        }

        public void complex() //Exercise 5
        {
            String input = null;

            Console.WriteLine("Type add, minus, multiply, divide or exit to finish");

            do {
                input = Console.ReadLine();

                Complex val1 = new Complex(7, 1);
                Complex val2 = new Complex(2, 6);

                if (input == "add") {
                    // Add both of them
                    Complex res = val1 + val2;
                    Console.WriteLine("First:  {0}", val1);
                    Console.WriteLine("Second: {0}", val2);

                    // display the result
                    Console.WriteLine("Result (Sum): {0}", res);

                } else if (input == "minus") {
                    Complex res = val1 - val2;
                    Console.WriteLine("First:  {0}", val1);
                    Console.WriteLine("Second: {0}", val2);

                    // display the result
                    Console.WriteLine("Result (Sum): {0}", res);

                } else if (input == "multiply") {
                    Complex res = val1 * val2;
                    Console.WriteLine("First:  {0}", val1);
                    Console.WriteLine("Second: {0}", val2);

                    // display the result
                    Console.WriteLine("Result (Sum): {0}", res);

                } else if (input == "divide") {
                    Complex res = val1 - val2;
                    Console.WriteLine("First:  {0}", val1);
                    Console.WriteLine("Second: {0}", val2);

                    // display the result
                    Console.WriteLine("Result (Sum): {0}", res);

                }
            } while (input != "exit");
            return;
        }

        abstract class Shape {

            public abstract override string ToString();
         
        }

        class Rectangle : Shape {
            public virtual double Width { get; set; }
            public virtual double Height { get; set; }

            public Rectangle(double Height, double Width) {
                this.Height = Height;
                this.Width = Width;
            }
           public double Area(double Height, double Width) {
                return Height * Width;
            }

            public override string ToString() {
                return string.Format("This is a Rectangle Class:\n Height: {0}\n Width: {1}\n Area: {2}", Height, Width, Area(Height, Width));
            }
        }

        class Square : Rectangle {
            public override double Width {
                get { return Height; }
                set { Height = value; } }

            public Square(int Width) : base(Width, Width) {
                this.Width = Width;
                this.Height = Width;

            }

            public double Area(double Width) {
                return Math.Pow(Width, 2);
            }

            public override string ToString() {
                return string.Format("This is a Square Class:\n Width: {0}\n Area: {1}", Width, Area(Width));
            }

        }

        class Circle : Shape {
            private double radius;

            public double Radius {
                get { return radius; }
                set { radius = value; }
            }

            public Circle(double Radius) {
                this.Radius = Radius;
            }

            public double Area (double Radius) {
                return Math.PI * Math.Pow(Radius, 2);
            }

            public override string ToString() {
                return string.Format("This is a Circle Class:\n Radius: {0}\n Area: {1}", Radius, Area(Radius));
            }
        }
     
    
         
        

        static void Main(string[] args) {
            //----------------------------------------------------------------------------  WEEK 2  ----------------------------------
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

            //Program complexfun = new Program();
            //complexfun.complex();

            //End Exercise 5


            //----------------------------------------------------------------------------  WEEK 3  ----------------------------------

            //Exercise 1

            //Shape[] arrayofshapes = new Shape[3];
            //arrayofshapes[0] = new Rectangle(30, 10);
            //arrayofshapes[1] = new Square(20);
            //arrayofshapes[2] = new Circle(15.2);

            //foreach (var item in arrayofshapes) {
            //    Console.WriteLine(item.ToString());
            //}
            //Console.ReadKey();

            //End Exercise 1

            //BST

            BST<int> binary = new BST<int>();
            binary.Add(12);
            binary.Add(5);
            binary.Add(2);
            binary.Add(7);
            binary.Add(15);
            binary.Add(27);

            
            Console.WriteLine("Number of Nodes: {0}",binary.Count);

            binary.inorderTraversal(binary.Root);

            Console.WriteLine("Max value in Tree: {0}", binary.MaxValue);
            Console.WriteLine("Min value in Tree: {0}", binary.MinValue);

            Console.WriteLine("Does the tree cointain 5?: {0}", binary.Contains(5));
            Console.WriteLine("Does the tree cointain 9?: {0}", binary.Contains(9));

            binary.Clear();

            binary.Add(69);
            binary.inorderTraversal(binary.Root);
            Console.WriteLine("Number of Nodes: {0}", binary.Count);


            //END BST

        }
    }

}
