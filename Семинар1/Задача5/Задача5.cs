// Задача 5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

Console. WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
N = Math.Abs(N);
int i = -N;
while(N >= i) {
    Console.WriteLine(i++);
}