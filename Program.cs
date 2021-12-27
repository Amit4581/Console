using System;

//public class Fabonacci
//{
//    public static void Main(string[] args)
//    {
//        int a = 0, b = 1, c, i, num;
//        Console.WriteLine("Enter the th numer upto which u want to find");
//        num = int.Parse(Console.ReadLine());
//        Console.WriteLine(a + " " + b + "");
//        for (i = 2; i < num; ++i)
//        {
//            c = a + b;
//            Console.WriteLine(c + "");
//            a = b;
//            b = c;
//        }
//    }
//}


// ------------------For Prime Number----------------------------------------

//public class PrimeNumberExample
//{
//    public static void Main(string[] args)
//    {
//        int a, b = 0,i, flag = 0;
//        Console.Write("Enter the Number to check Prime: ");
//        a = int.Parse(Console.ReadLine());
//        b = a / 2;
//        for (i = 2; i <= b; i++)
//        {
//            if (a % i == 0)
//            {
//                Console.Write("Number is not Prime.");
//                flag = 1;
//                break;
//            }
//        }
//        if (flag == 0)
//            Console.Write("Number is Prime.");
//    }
//}


//----------------Factorial-------------------
//public class FactorialExample
//{
//    public static void Main(string[] args)
//    {
//        int i, fact = 1, number;
//        Console.Write("Enter any Number: ");
//        number = int.Parse(Console.ReadLine());
//        for (i = 1; i <= number; i++)
//        {
//            fact = fact * i;
//        }
//        Console.Write("Factorial of " + number + " is: " + fact);
//    }
//}


//-------------Sum of Digits-----------------
//public class SumExample
//{
//    public static void Main(string[] args)
//    {
//        int n, sum = 0, m;
//        Console.Write("Enter a number: ");
//        n = int.Parse(Console.ReadLine());
//        while (n > 0)
//        {
//            m = n % 10;
//            sum = sum + m;
//            n = n / 10;
//        }
//        Console.Write("Sum is= " + sum);
//    }
//}

//----------------------reverse given number.-----------------
//public class ReverseExample
//{
//    public static void Main(string[] args)
//    {
//        int n, reverse = 0, rem;
//        Console.Write("Enter a number: ");
//        n = int.Parse(Console.ReadLine());
//        while (n != 0)
//        {
//            rem = n % 10;
//            reverse = reverse * 10 + rem;
//            n /= 10;
//        }
//        Console.Write("Reversed Number: " + reverse);
//    }
//}


//-----------------