// 2. Найти кубы чисел от 1 до N


Console.Write("Введите N: "); 
int N = int.Parse(Console.ReadLine());

int Qube = 0;
int i = 0;

for (i = 1; i <= N;  i ++)
    {Qube = i*i*i ; 
    Console.Write($"Для числа {i} ");
    Console.WriteLine($"Куб равен {Qube}");
    }


