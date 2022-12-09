// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Не использовать функцию Math.Pow
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Random rnd = new Random(); //Создание объекта для генерации чисел
  
int value1 = rnd.Next(0, 10);//Получить первое случайное число
int value2 = rnd.Next(0, 10); //Получить второе случайное число 

int Raisetodegree(int x, int y) //Создаю метод по возведению в степень первого числа на второе
{
    int result = x; 
    for(int i = 1; i < y; i++)
        result *= x;
    return result;
    
}

int result2 = Raisetodegree(value1, value2); // Объявляю переменную для получения результата из метода, отправляю числа value1 и value2 в метод для возврата ответа.
 
Console.WriteLine($"Число {value1} возведенное в {value2} степень будет равнятся {Raisetodegree(value1, value2)}");