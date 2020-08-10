using System;

class program 
{
   


  public static void Main (string[] args) 
  {
    string ops;
    double firstnum;
    double secondnum;
    double answer;
   
    string confirm;
    do
   { Console.WriteLine("*****************");
    Console.WriteLine("calculator in c #");
    Console.WriteLine("*****************");

    Console.WriteLine(" enter first number ");
    firstnum = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine(" select an operator (+,-,/,*,)");
    ops = Console.ReadLine();

    Console.WriteLine(" enter second number ");
    secondnum = Convert.ToDouble(Console.ReadLine());

    if (ops == "+")
    {
      answer = firstnum + secondnum;
      Console.WriteLine(answer);
    }
  

   else if (ops == "-")
    {
      answer = firstnum - secondnum;
      Console.WriteLine(answer);
    }
     
    

   else if (ops == "/")
    {
      answer = firstnum / secondnum;
      Console.WriteLine(answer);
    }


   else if (ops == "*")
    {
      answer = firstnum * secondnum;
      Console.WriteLine(answer);
    }
    
    
    else 
    {
      Console.WriteLine("invalid! select right operator");
      Console.WriteLine("------------------------------"); 
    }
    Console.WriteLine("do you want to restart calculator");
    confirm = Console.ReadLine();
    
   }
   while (confirm == "yes");
   Console.WriteLine("sad to see you goo :-(");
   Console.WriteLine(" develop by zaran");

      
    
    



    


    
  
    

  }
}