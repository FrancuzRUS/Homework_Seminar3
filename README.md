1. Показать таблицу квадратов чисел от 1 до N

Console.Write("Введите N: "); 
int N = int.Parse(Console.ReadLine());

int Square = 0;
int i = 0;

for (i = 1; i <= N;  i ++)
    {Square = i*i ; 
    Console.Write($"Для числа {i} ");
    Console.WriteLine($"Квадрат равен {Square}");
    }
    


2. Найти кубы чисел от 1 до N

Console.Write("Введите N: "); 
int N = int.Parse(Console.ReadLine());

int Qube = 0;
int i = 0;

for (i = 1; i <= N;  i ++)
    {Qube = i*i*i ; 
    Console.Write($"Для числа {i} ");
    Console.WriteLine($"Куб равен {Qube}");
    }



3. Найти сумму чисел от 1 до А

Console.Write("Введите A: "); 
int A = int.Parse(Console.ReadLine());

int Sum = 0;
int i = 0;

for (i = 1; i <= A;  i ++) Sum = Sum+i ; 

Console.WriteLine($"Сумма чисел равна {Sum}");
    


4. Возведите число А в натуральную степень B используя цикл

Console.Write("Введите число А:");
int A = int.Parse(Console.ReadLine());

Console.Write("Введите число B:");
int B = int.Parse(Console.ReadLine());

int C = 1;
int i = 1;

for (i = 1; i <= B; i++) C = A*C; 
Console.WriteLine($"Число А в степени В = {C}");



5. Подсчитать сумму цифр в числе

Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine());

int Sum = 0; 

while (N >= 1)
{
    Sum = Sum + N%10;
    N = (N-N%10)/10;
}
 Console.WriteLine ($"Сумма цифр в числе равна  {Sum}");



6. Показать кубы чисел, заканчивающихся на четную цифру

Console.Write("Введите четное число N: "); 
int N = int.Parse(Console.ReadLine());
int Qube = 0;

if (N%2 != 0) Console.WriteLine("Вы ввели нечетное число!");

else 
{
   Qube = N*N*N ; 
    Console.WriteLine($"Куб равен {Qube}");
}



7. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0,2);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int[] array = new int[8];

FillArray(array);
PrintArray(array);
