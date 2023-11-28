//Задача 2: Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.

int a = 10;
int[] randomArray = new int[a];

void Mas(int a)
{
for (int i = 0; i < a; i++)
{
randomArray[i] = new Random().Next(0,100);
Console.Write(randomArray[i] + " ");
}
Console.WriteLine();
}

int kol(int[] randomArray)
{
int kol = 0;
for (int i = 0; i < randomArray.Length; i++)
{
if (randomArray[i] % 2 == 0)
kol = kol + 1;
}
return kol;
}

Mas(a);
Console.Write($"\nКоличество чeтных чисел в этом массиве: {kol(randomArray)}");
