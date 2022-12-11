﻿//Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 6
// 82 -> 10
// 9012 -> 3

Random rnd = new Random(); //Создание объекта для генерации чисел
  
int n = rnd.Next(99999, 1000000);//Получаю первое случайное число 

int number = n; // Новая переменная для вычисления числа из номера

int sum = 0; // Переменная для записи ответа

int temp = 0;

do 
{
    if(number % 10 == 0 )
    {
        Console.WriteLine("Нельзя делить на 0");
        break;
    } 
    temp = number % 10; // запускаю цик do для определения цифр номера
    if (n % temp == 0) // вычисляю является ли цифра делителем
    {
        sum += temp; // операция сложения делителей
    }
    number = number / 10; // вычитаю цифру из номера для определения следующий начиная с конца
}

    
while (number > 0); // если number становится равен 0 то цикл останавливается пройдя все цифры номера и выводит результат
{     
}

Console.WriteLine($"Сумма делителей номера {n} равна {sum}");
