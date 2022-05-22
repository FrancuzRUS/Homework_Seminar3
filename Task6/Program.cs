//6. Показать кубы чисел, заканчивающихся на четную цифру

Console.Write("Введите четное число N: "); 
int N = int.Parse(Console.ReadLine());
int Qube = 0;

if (N%2 != 0) Console.WriteLine("Вы ввели нечетное число!");

else 
{
   Qube = N*N*N ; 
    Console.WriteLine($"Куб равен {Qube}");
}


