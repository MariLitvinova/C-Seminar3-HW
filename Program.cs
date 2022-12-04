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
//         while( num /1000 >= 1 )
//         {
//             num = num /10;
//             count++;
//         }
//         int help1 = num /10;
//         return (num - help1 *10);
//     }
//     int result = Test();
//     Console.WriteLine($"Получена цифра - {result}");
// }
// else
//     {
//         Console.WriteLine("Третьей цифры нет");
//     }


// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// void Week(int day){
//     if (day == 6){
//         Console.WriteLine("да");
//     }
//     else if (day == 7){
//         Console.WriteLine("да");
//     }
//     else{
//         Console.WriteLine("нет");
//     }
// }
// Console.WriteLine("Введите число, соответствующее дню недели:");
// int day = Convert.ToInt32(Console.ReadLine());
// Week(day);