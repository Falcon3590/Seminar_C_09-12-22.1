// Задача 3: **(Дополнительное, не обязательно)
// Назовём число «интересным» если его произведение цифр делится на их сумму. Напишите программу, которая заполняет массив на 10 «интересных» 
// случайных целых чисел от 10 до 1000. (каждый эл-т массива – сгенерирован случайно)
// [591, 532, 189, 523, 333, 546, 527, 275, 456, 264]


 int multiply(int N1)
   {  int n1 = N1;
      int multiply = 1;
             
        do{
        multiply = multiply * (n1 % 10);
        n1 = n1 / 10;
        }
        while(n1 > 0);
        //Console.WriteLine($"Произведение всех цифры числа = {multiply}");
        return(multiply);
   }
        
int summ(int N2)

   {  int n2 = N2;
      int sum = 0;
        
        do{
        sum = sum + n2 % 10; 
        n2 = n2 / 10;
        }
        while(n2 > 0);
        //Console.WriteLine($"Сумма всех цифры числа = {sum}");
        return(sum);
   }
  

<<<<<<< HEAD
Console.Write("[");   
=======
Console.WriteLine($"число N = {N}");

int n1 = N; 

int n2 = N;

int multiply = 1;

int sum = 0;

int [] array = new int[10];

do{
    multiply = multiply * (n1 % 10);
    n1 = n1 / 10;
    
    sum = sum + n2 % 10; //1. деление с остатком для определения последней цифры номера
    n2 = n2 / 10;
 }
 
 while(n1 > 0 && n2 > 0);
 
 Console.WriteLine($"произведение чисел = {multiply} и сумма чисел = {sum}");

 Console.WriteLine($"произведенние деленное на сумму = {(float)multiply / sum}");
 
 Console.Write("[");
>>>>>>> 37094360ed093b03a3bcfabd82a52a3f0da26eec

for (int i = 0; i <= 9; i++)
{
   Random rnd = new Random(); 
   int N = rnd.Next(10, 10000); 
   //Console.WriteLine($"генерируемое число{N}");
     
   int [] array = new int[10];   
   int mult = N;
   int sum = N;
   mult = multiply(mult);
   sum = summ(sum);
   int result = mult % sum;
   //Console.WriteLine($"Произведение цифр деленое с остатком на сумму цифр = {result}");
   
   
       if (mult % sum == 0)
       {
       array[i] = N;  
       Console.Write($"{array[i] }, ");
       }
       else
       {
        i--;
       }                    
    }
<<<<<<< HEAD
Console.WriteLine("]");
=======

Console.WriteLine("]");
>>>>>>> 37094360ed093b03a3bcfabd82a52a3f0da26eec
