/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее.

Console.Clear();
Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

if (a > b){
    Console.WriteLine(a + " больше чем " + b);
}
else{
    Console.WriteLine(b + " больше чем " + a);
}
*/



/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт 
максимальное из этих чисел.

Console.Clear();
Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите третее число: ");
int c = int.Parse(Console.ReadLine());
int max = 0;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
Console.WriteLine("Наибольшее значение: " + max);
*/


/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).

Console.Clear();
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!);

if (a % 2 == 0){
    Console.WriteLine("Число " + a + " является четным!");
}
else{
    Console.WriteLine("Введеное число не является четным");
}
*/

/*Задача 8: Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.


Console.Clear();
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
int count = 1;

while (count <= N){
    if (count % 2 == 0){
        Console.Write($"{count}, ");
        count++;
    }
    else{
        count++;
    }
}
*/