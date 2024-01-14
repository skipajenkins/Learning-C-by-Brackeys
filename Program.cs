// See https://aka.ms/new-console-template for more information
using System;
 namespace My_Awesome_App
{
    {
        static void Main(string[] args)
        {
          //Console is a class(think of it like a container) and it has method, variables/properties and etc.
          //To  have acesss to these methods you use a dot(.) along the class name "Console".
          Console.Title = "Skynet";

          //Change color of the foreground which is the text into any color you want
          Console.ForegroundColor= ConsoleColor.Green;
        
         //.WriteLine is one of the methods of the class "Console" and it displays integers,strings and so on.
          Console.WriteLine("Hello, What's your name?");
        
          //.ReadLine also another method that reads the text inputed by a user(Think of it as the scanf version of c#).
          Console.ReadLine();
         
          Console.WriteLine("My name is Rx-9000.\nI am an Ai robot sent from the future to destroy you.\nWhat is your favourite color?");
          
          Console.ReadLine();

          Console.WriteLine("Mine is desruction.");


          //.ReadKey.It wait for an input before ending the program.
          Console.ReadKey();

          //Short Challenge from the brackeys channel
          //Making a short story using .WriteLine & .ReadLine

          Console.WriteLine("Once Upon Atime lived a woodman called...");
          Console.ReadLine();
          Console.WriteLine("The woodsman was one day attack by....");
          Console.ReadLine();
          Console.WriteLine("But  woodsman fought back using his might with using a/an....");
          Console.ReadLine();
          Console.WriteLine("And came out victrous.Making his way back\nHe meet a/an...");
          Console.ReadLine();
          Console.WriteLine("and got crushed by a rock\nTHE END");
          Console.ReadKey();
        }
    }
}
