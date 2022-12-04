// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// int Num (){
//     int num = Convert.ToInt32(Console.ReadLine());
//     int hun = num /100;
//     int dec = num /10;
//     return (dec - hun *10);
//     }
// Console.WriteLine("Введите трёхзначное число:");
// int result = Num();
// Console.WriteLine($"Получено число - {result}");

// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
    
// Console.WriteLine("Введите число:");
// int num = Convert.ToInt32(Console.ReadLine());
// int count = 0;
// if (num  /100 >= 1)
// {
//     int Test (){
//         while( (num /1000) >= 1 )
//         {
//             num = num /10;
//             count++;
//         }
//         int help1 = num /10;
//         return (num - help1 *10);
//     }
//     int result = Test();
//     Console.WriteLine($"Получено число - {result}");
// }
// else
//     {
//         Console.WriteLine("Третьего числа нет");
//     }