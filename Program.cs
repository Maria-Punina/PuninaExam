﻿// Задача: 
// Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. 

// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] array = new string[] { "Hello", "2", "world", ":-)", "1234", "1567", "-2", "computer scienece", "Russia", "Denmark", "Kazan" };
string[] arrayNew = new string[array.Length];

void TaskArr(string[] array, string[] arrayNew)
{
    int count = 0;
    for (int i = 0; i < array.Length; ++i)
    {
        if (array[i].Length <= 3)
        {
            arrayNew[count] = array[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{ 
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

TaskArr(array, arrayNew);
PrintArray(arrayNew);