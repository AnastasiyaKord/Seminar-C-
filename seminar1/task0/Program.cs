// Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).

// Например:
// 4 -> 16 
// -3 -> 9 
// -7 -> 49

// Console.WriteLine("Введите число");
// string userAnswer = Console.ReadLine();
// int userNumber = Convert.ToInt32(userAnswer);

// Console.WriteLine(userNumber * userNumber);


// Напишите программу, которая на вход принимает два числа и проверяет, 
// является ли первое число квадратом второго.

// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3, b = 9 -> нет
// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница


// Console.WriteLine("Введите число а");

// string answerA = Console.ReadLine();
// int a = Convert.ToInt32(answerA);

// Console.WriteLine("Введите число b");

// string answerB = Console.ReadLine();
// int b = Convert.ToInt32(answerB);

// if (a == (b * b))
// {
//     Console.WriteLine("ДА");
// }

// else Console.WriteLine("НЕТ");

// Console.WriteLine("Введите число ");

// string answer = Console.ReadLine();
// int number = Convert.ToInt32(answer);

// if (number == 1){Console.WriteLine("Понедельник");}
// if (number == 2){Console.WriteLine("Вторник");}
// if (number == 3){Console.WriteLine("Среда");}
// if (number == 4){Console.WriteLine("Четверг");}
// if (number == 5){Console.WriteLine("Пятница");}
// if (number == 6){Console.WriteLine("Суббота");}
// if (number == 7){Console.WriteLine("Воскресение");}
// if (number > 7){Console.WriteLine("НЕТ ТАКОГО ДНЯ НЕДЕЛИ");}
// if (number < 1){Console.WriteLine("НЕТ ТАКОГО ДНЯ НЕДЕЛИ");}

// Console.WriteLine("start third task");
// Console.Write("Input number: ");
// string daysString = Console.ReadLine();
// int numberDay = Convert.ToInt32(daysString);
// string[] days = new string[] {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресение"};
// Console.WriteLine(days[numberDay-1]);

// See https://aka.ms/new-console-template for more information

// Console.WriteLine("Введите число а");
// int numberA = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число b");
// int numberB = Convert.ToInt32(Console.ReadLine());

// if(numberB * numberB == numberA)
// {
//     Console.WriteLine("Да");
// }
// else{
//     Console.WriteLine("Нет");
// }

// Console.WriteLine("Введите число");
// int day = Convert.ToInt32(Console.ReadLine());

// if(day == 1)
// {
//     Console.WriteLine("Понедельник");
// }
// else if(day = 2)
// {
//     Console.WriteLine("Вторник");
// }
// else
// {
//     Console.WriteLine("нет такого дня недели");
// }



// Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

// Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

// int digit3 = 456 % 10;
// Console.WriteLine(digit3);

int n = 5;
for(int i= -n; i <= n; i++)
{
    Console.Write(i + " ");
}