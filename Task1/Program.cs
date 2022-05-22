// 1. Показать таблицу квадратов чисел от 1 до N

Console.Write("Введите N: "); 
int N = int.Parse(Console.ReadLine());

int Square = 0;
int i = 0;

for (i = 1; i <= N;  i ++)
    {Square = i*i ; 
    Console.Write($"Для числа {i} ");
    Console.WriteLine($"Квадрат равен {Square}");
    }
    

