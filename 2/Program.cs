// Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

int Prompt (string message)
{
    System.Console.WriteLine(message + ":");
    return int.Parse(Console.ReadLine());
}
void Sum(int start, int finish)
{
    if (start > finish)
    {
        return;
    }
    int sum = 0;
    for (int i = start; i < finish; i++)
    {
        sum += i;
    }
    
    System.Console.Write($"{sum};");
    ShowNumbers(start + 1, finish);
}
int number1 = Prompt("Введите число N");
int number2 = Prompt("Введите число M");

Sum(number1, number2);
