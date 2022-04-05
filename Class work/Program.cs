using System;

namespace Class_work
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3,4,7,2};
            Array.Resize(ref arr, 3);

            Console.WriteLine(arr[2]);
        }

        

    }

}


#region Task 1 
//string Num1 = Console.ReadLine();
//string Num2 = Console.ReadLine();
//string Num3 = Console.ReadLine();
////string Num4 = Console.ReadLine();
//int a = int.Parse(Num1);
//int b = int.Parse(Num2);
//int c = int.Parse(Num3);
////int d = int.Parse(Num4);
//Console.WriteLine("En boyuk deyer");
//Max(a, b, c);
//            //Max(a, b, c, d);
//            //Doub(a, b, c);







//        }

//        static int Max(int a, int b, int c)
//{
//    int max = 0;

//    if (a > b && a > c)
//    {
//        max = a;
//    }
//    if (b > a && b > c)
//    {
//        max = b;
//    }
//    if (c > a && c > b)
//    {
//        max = c;
//    }

//    Console.WriteLine(max);
//    return max;




//}
//static int Max(int a, int b, int c, int d)
//{
//    int max = 0;

//    if (a > b && a > c && a > d)
//    {
//        max = a;
//    }
//    if (b > a && b > c && b > d)
//    {
//        max = b;
//    }
//    if (c > a && c > b && c > d)
//    {
//        max = c;
//    }
//    if (d > a && d > b && d > c)
//    {
//        max = d;
//    }

//    Console.WriteLine(max);
//    return max;



//}
//static double Doub(double a, double b, double c)
//{
//    double max = 0;

//    if (a > b && a > c)
//    {
//        max = a;
//    }
//    if (b > a && b > c)
//    {
//        max = b;
//    }
//    if (c > a && c > b)
//    {
//        max = c;
//    }

//    Console.WriteLine(max);
//    return max;
#endregion

#region Task 2
//    back(356);
//    back(787);
//    back(111);




//}
//static int back(int num1)
//{

//    int num2 = 0;
//    int num3 = 0;
//    int sum = 0;

//    num2 = num1 % 10;
//    num1 = (num1 - num2) / 10;
//    num3 = num1 % 10;
//    num1 = (num1 - num3) / 10;
//    sum = num1 + num2 + num3;

//    Console.WriteLine(sum);
//    return sum;
#endregion

#region task 3
//companiya(23, 67, 970);
//companiya(526, 968, 874);

//static double companiya(double price1, double price2, double price3)

//{

//    double sum = 0;

//    if (price1 < price2 && price1 < price3)
//    {
//        sum = price2 + price3;
//    }if (price2 < price1 && price2 < price3)
//    {
//        sum = price1 + price3;
//    }if(price3 < price2 && price3 < price1)
//    {
//        sum = price2 + price1;
//    }
//    Console.WriteLine(sum);





//    return sum;
//}

#endregion
