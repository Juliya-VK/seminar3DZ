// Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива. 
 
 double[] myArray = { 2.2, 0.4, 9.11, 7.2, 78.98};

        double min = myArray[0];
        double max = myArray[0];
        

        for (int i = 1; i < myArray.Length; i++) 
          { if (myArray[i] < min)
            {
                min = myArray[i];
            }

            if (myArray[i] > max)
            {
                max = myArray[i];
            }
          }

        double difference = max - min;
Console.WriteLine($"Разница между максимальным и минимальным элементами: {difference}");