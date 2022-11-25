using System;  
  class Sum
   {  
     public static void Main(string[] args)  
      {  
       int  number, sum=0, m;         
       Console.Write("Enter a number: ");      
       number = int.Parse(Console.ReadLine());     
       while(number > 0)      
       {      
        m = number % 10;      
        sum = sum + m;      
        number = number / 10;      
       }      
       Console.Write("Sum is= "+sum);       
     }  
  }  