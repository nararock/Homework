// Задача: Напишите программу, которая на вход принимает 
//два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число: ");
int firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: "); 
int secondNumber = int.Parse(Console.ReadLine());
if (firstNumber > secondNumber)
{
    Console.WriteLine($"max = {firstNumber}, min = {secondNumber}");
}
else if (firstNumber < secondNumber)
{
    Console.WriteLine($"max = {secondNumber}, min = {firstNumber}");
}
else
{
    Console.WriteLine($"Числа равны");
}


