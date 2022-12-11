// Задача 3: **(Дополнительное, не обязательно)
// Назовём число «интересным» если его произведение цифр делится на их сумму. Напишите программу, которая заполняет массив на 10 «интересных» 
// случайных целых чисел от 10 до 1000. (каждый эл-т массива – сгенерирован случайно)
// [591, 532, 189, 523, 333, 546, 527, 275, 456, 264]


// - - - ЕЩЕ РАБОТАЮ НАД ЗАДАНИЕМ - - - 

// Пока  не понял как добавить генерацию чисел в цикл, массив заполняется одим числом.

Random rnd = new Random(); 
  
int N = rnd.Next(10, 10000); 

Console.WriteLine($"1 {N}");

int n1 = N; 

int n2 = N;

int multiply = 1;

int sum = 0;

int [] array = new int[10];

do{
    multiply = multiply * (n1 % 10);
    n1 = n1 / 10;
    
    sum = sum + n2 % 10;
    n2 = n2 / 10;
 }
 while(n1 > 0 && n2 > 0);
 {}
 Console.WriteLine($"2 {multiply} и {sum}");

 Console.WriteLine((float)multiply / sum);
 
 Console.Write("[");

for (int i = 0; i <= 9; i++)

    {
       if (multiply % sum == 0)
       {
       array[i] = N;  
       Console.Write($"{array[i] }, ");
       }                    
    }

Console.WriteLine("]");

 
 
 
 
 
 
 
 
   
 
// do{
//     sum = sum + n2 % 10;
//     n2 = n2 / 10;
// }
//  while(n2 > 0);
//  {}
//  Console.WriteLine($"3 {sum}");
