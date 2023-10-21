using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*25 - misol
            double x, y;
            Console.Write("x = ");
            x = double.Parse(Console.ReadLine());
            y = Math.Pow(x, 6) * 3 - 6 * (Math.Pow(x, 2)) - 7;
            Console.WriteLine("y = " + y);*/
            /*26 - misol
            double x, y;
            Console.Write("x = ");
            x = double.Parse(Console.ReadLine());
            y = 4 * (Math.Pow(x - 3, 6)) - 7 * (Math.Pow(x - 3, 3)) + 2;
            Console.WriteLine("y = " + y);*/
            /*27 - misol
            double A;
            Console.Write("A = ");
            A = double.Parse(Console.ReadLine());
            Console.WriteLine("A2 = " + Math.Pow(A, 2) + "\n" + "A4 = " + Math.Pow(A, 4) + "\n" +
                                    "A8 = " + Math.Pow(A, 8));*/
            /*28 - misol
            double A;
            Console.Write("A = ");
            A = double.Parse(Console.ReadLine());
            Console.WriteLine($"A2 = {Math.Pow(A, 2)}\nA3 = {Math.Pow(A, 3)}\nA5 = {Math.Pow(A, 5)}\n" +
                $"A10 = {Math.Pow(A, 10)}\nA15 = {Math.Pow(A, 15)}");*/
            /*35 - misol
            double V, U, I1, I2, S1, S2;
            Console.Write("Qayiqning tizligi V = ");
            V = double.Parse(Console.ReadLine());
            Console.Write("Oqimning tizligi U = ");
            U = double.Parse(Console.ReadLine());
            Console.Write("oqim bilan yurgan soat I1 = ");
            I1 = double.Parse(Console.ReadLine());
            Console.Write("oqimga qarshi yurgan soat I2 = ");
            I2 = double.Parse(Console.ReadLine());
            S1 = (V + U) * I1;
            S2 = (V - U) * I2;
            Console.WriteLine($"Oqim bilan yurgan masofa S1 = {S1}\nOqimga qarshi yurgan masofa S2 = {S2}");*/
            /*12 - misol
            int a, b, c;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Natija   " + (a > 0 && b > 0 && c > 0));*/
            /*13 - misol
            int a, b, c;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Natija   " + (a > 0 || b > 0 || c > 0));*/
            /*14 - misol
            int a, b, c;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Natija   " + ((a > 0 && b < 0 && c < 0) || (a < 0 && b > 0 && c < 0) || 
                                 (a < 0 && b < 0 && c > 0)));*/
            /*15 - misol
            int a, b, c;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Natija   " + ((a > 0 && b > 0 && c < 0) || (a < 0 && b > 0 && c > 0) || 
                               (a > 0 && b < 0 && c > 0)));*/
            /*16 - misol
            int a;
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Natija   " + ((a / 10 > 0) && (a / 10 <= 9) && (a % 2 == 0)));*/
            /*17 - misol
            int a;
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Natija   " + ((a / 100 > 0) && (a / 100 <= 9) && (a % 2 == 1)));*/
            /*18 - misol
            int a, b, c;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Natija   " + (a == b || b == c || c == a));*/
            /*19 - misol
            int a, b, c;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Natija   " + ((a * -1 == b || b * -1 == c || c * -1 == a) || 
                                  (a  == b * -1 || b == c * -1 || c == a * -1)));*/
            /*20 - misol
            int a, a1, a2, a3;
            a = int.Parse(Console.ReadLine());
            a1 = a / 100;
            a2 = (a / 10) % 10;
            a3 = a % 10;
            Console.WriteLine("Natija   " + (a1 != a2 && a1 != a3 && a2 != a3));*/
            /*21 - misol
            int a, a1, a2, a3;
            a = int.Parse(Console.ReadLine());
            a1 = a / 100;
            a2 = (a / 10) % 10;
            a3 = a % 10;
            Console.WriteLine("Natija   " + (a1 < a2 && a2 < a3));*/
            /*22 - misol
            int a, a1, a2, a3;
            a = int.Parse(Console.ReadLine());
            a1 = a / 100;
            a2 = (a / 10) % 10;
            a3 = a % 10;
            Console.WriteLine("Natija   " + ((a1 < a2) && (a2 < a3) || (a1 > a2) && (a2 > a3)));*/
            /*23 - misol
            int a, a1, a3;
            a = int.Parse(Console.ReadLine());
            a1 = a / 100;
            a3 = a % 10;
            Console.WriteLine("Natija   " + (a1 == a3));*/
            /*30 - misol
            int a, b, c;
            Console.Write("a tomon = "); a = int.Parse(Console.ReadLine());
            Console.Write("b tomon = "); b = int.Parse(Console.ReadLine());
            Console.Write("c tomon = "); c = int.Parse(Console.ReadLine());
            Console.WriteLine("Natija   " + ((a == b) && (b == c) && (a == c)));*/
            /*31 - misol
            int a, b, c;
            Console.Write("a tomon = "); a = int.Parse(Console.ReadLine());
            Console.Write("b tomon = "); b = int.Parse(Console.ReadLine());
            Console.Write("c tomon = "); c = int.Parse(Console.ReadLine());
            Console.WriteLine("Natija   " + ((a == b && (c > a || c < b)) || (b == c && (a > c || a < c)) || (a == c && (c > b || c < b))));*/
            //32 - misol
            int a, b, c;
            Console.Write("a tomon = "); a = int.Parse(Console.ReadLine());
            Console.Write("b tomon = "); b = int.Parse(Console.ReadLine());
            Console.Write("c tomon = "); c = int.Parse(Console.ReadLine());
            Console.WriteLine("Natija   " + ((a == b && (c > a || c < b)) || (b == c && (a > c || a < c)) || (a == c && (c > b || c < b))));




        }
    }
}
