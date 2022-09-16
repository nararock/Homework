//Задача: Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите первое число: ");
int firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int secondNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int thirdNumber = int.Parse(Console.ReadLine());
if (firstNumber > secondNumber)
{
    if (firstNumber > thirdNumber) Console.WriteLine($"max = {firstNumber}");
    else if (firstNumber < thirdNumber) Console.WriteLine($"max = {thirdNumber}");
    else Console.WriteLine("Максимум отсутствует.");
}
else if ((firstNumber < secondNumber))
{
    if (secondNumber > thirdNumber) Console.WriteLine($"max = {secondNumber}");
    else if (secondNumber < thirdNumber) Console.WriteLine($"max = {thirdNumber}");
    else Console.WriteLine("Максимум отсутствует.");
}
else Console.WriteLine("Максимум отсутствует.");

