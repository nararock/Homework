// Задача: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("введите число");
int number = int.Parse(Console.ReadLine());
int counter = 1;
while(counter!= number)
{
    counter++;
    if (counter % 2 == 0) Console.Write(counter + " ");
}
