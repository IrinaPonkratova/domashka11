// Задайте значения M и N. Напишите программу, которая выведет 
//все чётные натуральные числа в промежутке от M до N с помощью рекурсии.

//M = 1; N = 5 -> "2, 4"
//M = 4; N = 8 -> "4, 6, 8"




int Prompt (string message)
{
    System.Console.WriteLine(message + ":");
    return int.Parse(Console.ReadLine());
}

void ShowNumbers(int start, int finish)
{
    if (start > finish)
    {
        return;
    }
    for (int i = start; i < finish; i++)
    {
        if (i % 2 == 0)
        {
            System.Console.WriteLine(i);
        }
    }
    
    System.Console.Write($"{start};");
    ShowNumbers(start + 1, finish);
}
int number1 = Prompt("Введите число N");
int number2 = Prompt("Введите число M");

ShowNumbers(number1, number2);