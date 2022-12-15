// Задача 3: **(Дополнительное, не обязательно)
// Назовём число «интересным» если его произведение цифр делится на их сумму. Напишите программу, которая заполняет массив на 10 «интересных» 
// случайных целых чисел от 10 до 1000. (каждый эл-т массива – сгенерирован случайно)
// [591, 532, 189, 523, 333, 546, 527, 275, 456, 264]


int product_digits_number(int N1)
   {  
   int n1 = N1;

   int multiply = 1;
             
      do
      {
      multiply = multiply * (n1 % 10);
      n1 = n1 / 10;
      }
      
      while(n1 > 0);
      
      //Console.WriteLine($"Произведение всех цифры числа = {multiply}");
      
      return(multiply);
   }
        
int  sum_digits_number(int N2)

   {  
   int n2 = N2;
   
   int sum = 0;
        
      do
      {
      sum = sum + n2 % 10; 
       n2 = n2 / 10;
      }
        
      while(n2 > 0);
        
      //Console.WriteLine($"Сумма всех цифры числа = {sum}");
        
      return(sum);
   }
  

Console.Write("["); 
int count = 0;  

while (count != 10)
   {
   Random rnd = new Random(); 
   
   int N = rnd.Next(10, 10000); 
   
   //Console.WriteLine($"генерируемое число{N}");
     
   int [] array = new int[10];   
   
   int mult = N;
   
   int sum = N;
   
   mult = product_digits_number(mult);
   
   sum = sum_digits_number(sum);
   
   int result = mult % sum;
   
   //Console.WriteLine($"Произведение цифр деленое с остатком на сумму цифр = {result}");
   
   
      if (mult % sum == 0)
      {
      array[count] = N;  
      Console.Write($"{array[count] }, ");
      count++;
      }

}
   
Console.WriteLine("]");

