// домашняя работа
// Залдание 1  напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

void Palindrom(int num)
{
      if (num < 10000 ||  num > 990000)
    {
        System.Console.WriteLine("error");
    }
     if (num > 9999 & num < 100000)
    {
        int first = num / 10000;
        int tho = num / 1000;
        int hun = num / 100;
        int dec = num / 10;
        int fifth = num % 10;
        int second = tho % 10;
        int fourth = dec % 10;

        if (first == fifth && second == fourth)
        {
            Console.WriteLine("Число является полиндромом");
        }
        else
        {
            Console.WriteLine("не является полиндроном");
        }
    }
        
}
Console.WriteLine("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
Palindrom(num);              


// void CheckPalindromicNumber(int number)
// {
//     if(number >= 10000)
//     {
//         int division1 = number / 10000;
//         int remainder1 = number % 10;

//             if(division1 == remainder1)
//             {
//                 number = number / 10;
//                 int division2 = number / 100;
//                 int remainder2 = number % 10;
//                 if(division2 == remainder2)
//                     Console.WriteLine("Да");
//             }
//             else 
//             Console.WriteLine("Нет");

//     }
//     else
//     Console.WriteLine("Некорректное число!");
// }

// Console.WriteLine("Введите пятизначное число:");
// int number = int.Parse(Console.ReadLine()!);
// CheckPalindromicNumber(number);

// Задание 2 напишите программу, которая принимает на вход координаты двух точек и находит расстояние межу ними в 3 d пространстве
//d = √ [(x2-x1)2 + (y2-y1)2 + (z2-y1)2], Где (x1, y1, z1), (x2, y2, z2) и (x2, y2, z3) две точки на плоскости xy 

// Console.WriteLine("Введите координату x1 "); 
// int x1 = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine("Введите координату y1 "); 
// int y1 = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine("Введите координату z1 "); 
// int z1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату x2 "); 
// int x2 = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine("Введите координату y2 "); 
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату z2 "); 
// int z2 = Convert.ToInt32(Console.ReadLine()); 


//  void Dist(int a, int b, int c, int d, int e, int f) 
// { 
//     double dist =  Math.Sqrt(Math.Pow(b - a, 2) + Math.Pow(d - c, 2) + Math.Pow(e - f, 2)); 
//     Console.WriteLine("Расстояние между точками " + Math.Round(dist, 2)); 
// } 

// Dist(x1, x2, y1, y2, z1, z2);


// напишите программу, которая на входе принимает число N и выдает таблицу квадратов числе от 1 до N 

// void Table(int number)
// {
//     for (int number1 = 1; number1 <= number; number1++)
//     {
//         Console.Write(Math.Pow(number1, 3)  + " ");
//     }
// }
// System.Console.WriteLine("Введите число:  ");
// int number = Convert.ToInt32(Console.ReadLine());
// Table(number);

