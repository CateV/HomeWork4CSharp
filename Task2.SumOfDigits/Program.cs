// Задача 2: Напишите программу, которая принимает на вход число и выдаёт 
// сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int InputInt(string message)
{
    System.Console.WriteLine(message);
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}

int SummOfDigits(int n)
{
    if (n<0)
    {
        n=n*(-1);
    }
    int result = 0;
    while (n > 0)
    {
        result = result + n % 10;
        n = n / 10;
    }
    return result;
}
int number = InputInt("Введите число");
int sum = SummOfDigits(number);
System.Console.WriteLine($"Сумма цифр в числе {number} равна {sum}");
//Вопрос: как правильно поступать с суммой цифр в отрицательных числах?
// Так, как поступила я?
// Или правильнее было сделать вывод "сумма цифр числа -45 равна -9"?