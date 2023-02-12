// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A 
//в натуральную степень B. Не использовать Math.Pow
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
int InputInt(string message)
{
    System.Console.WriteLine(message);
    int a = Convert.ToInt32(Console.ReadLine());
return a;
}

int Degree(int number, int degree)
{
    if (degree == 0)
    {
        return 1;
    }
    int result = number;
    for (int i = 2; i <= degree; i++)
    {
        result = result * number;
    }
    return result;
}
int figure = InputInt("Какое число хотим возвести в степень?");
int degree = InputInt($"В какую степень хотим возвести число {figure}?");
int result = Degree (figure,degree);
System.Console.WriteLine($"{figure} в степени {degree} = {result}");