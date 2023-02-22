// HomeWork 5
// Задача 1. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
	
    /*
	Console.WriteLine("Инициализация программы");
	Console.WriteLine("Задаётся массив заполненный случайными положительными трёхзначными числами");
	int[] array = GetRandomArray(10, 100, 999);
	int count = findNumber(array);
	

	int[] GetRandomArray(int Length, int minEl, int maxEl)
	{
	    int[] array = new int[Length];
	    Random random = new Random();
	

	    for (int i = 0; i < Length; i++)
	    {
	        array[i] = random.Next(minEl, maxEl+1);
	    }
	    return array;
	}
	

	int findNumber(int[] array)
	{
	    int count = 0;
	

	    for (int i = 0; i < array.Length; i++)
	    {
	        if (array[i] % 2 == 0)
	        {
	           count++;
	        }
	    }
	    return count;
	}
	Console.WriteLine($"Полученный массив [{string.Join(", ", array)}] - {count} четных чисел");
	Console.WriteLine("Программа завершила работу");
/*

// Задача 2. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.


	Console.WriteLine("Инициализация программы");
	Console.WriteLine("Задаётся массив заполненный случайными  числами");
	int[] array = GetRandomArray(10, -999, 999);
	int sum = sumOddNumber(array);
	

	int[] GetRandomArray(int Length, int minEl, int maxEl)
	{
	    int[] array = new int[Length];
	    Random random = new Random();
	

	    for (int i = 0; i < Length; i++)
	    {
	        array[i] = random.Next(minEl, maxEl+1);
	    }
	    return array;
	}
	

	int sumOddNumber(int[] array)
	{
	    int sum = 0;
	

	    for (int i = 0;  i < array.Length; i++)
	    {
	        if (i % 2 == 0)
	        {
	            sum += array[i];
	            i++;
	        }
	        else 
	        {
	            i++;
	        }
	    }
	    return  sum;
	}
	

	Console.WriteLine($"Полученный массив [{string.Join(", ", array)}] - {sum} сумма элементов на нечетной позиции");
	Console.WriteLine("Программа завершила работу");

*/

// Задача 3. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
	Console.WriteLine("Инициализация программы");
	Console.WriteLine("Задаётся массив заполненный вещественными числами");
	

	int[] array = GetRandomArray(10, 0, 999);
	int max = maxNumbArr(array);
	int min = minNumbArr(array);
	

	int[] GetRandomArray(int Length, int minEl, int maxEl)
	{
	    int[] array = new int[Length];
	    Random random = new Random();
	

	    for (int i = 0; i < Length; i++)
	    {
	        array[i] = random.Next(minEl, maxEl+1);
	    }
	    return array;
	}
	

	int maxNumbArr(int[] array) 
	{
	    int max = array[0];
	

	    for (int i = 1; i < array.Length; i++)
	    {
	        if (max < array[i])
	        {
	            max = array[i];
	        }
	    }
	

	    return max;
	}    
	

	int minNumbArr(int[] array) 
	{
	    int min = array[0];
	

	    for (int i = 1; i < array.Length; i++)
	    {
	        if (min > array[i])
	        {
	            min = array[i];
	        }
	    }
	

	    return min;
	}    
	Console.WriteLine($"Задан массив [{string.Join(", ", array)}], Min элемент = {min}, Max элемент = {max}, Разница между Min и Max = {max - min}");
	Console.WriteLine("Программа завершила работу");



