// Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.

int[] myArray = { 1, 8, 43, 4, 55, 60, 3, 2, 1, 3 };
int count = 0;
        for (int i = 0; i < myArray.Length; i++)
        {
            int num = myArray[i]; 
           if (num % 2 == 0)
            {
                count++;
            }
        }

        Console.WriteLine($"Количество четных чисел в массиве: {count}");