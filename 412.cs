using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _412
{
   class Program
   {
      static void Main(string[] args)
      {

         String result = "";
         var residents = new Dictionary<String, int>();

         residents.Add("Catu", 1);
         residents.Add("Felicia", 2);
         residents.Add("Mica", 3);
         residents.Add("Glenn", 4);

         Console.WriteLine("Welcome to 412.\n1. Knock.\n2. Leave and never come back.");
         String userInput = Console.ReadLine();

         // Will they stay or leave.
         if (userInput.Equals("1"))
         {
         }
         else
         {
            Console.WriteLine("Good choice.");
            Console.Read();
            return;
         }

         while (true)
         {
            Console.WriteLine("Who would you like to speak to? (C)atu, (M)ica, (F)elicia, (G)lenn");
            ConsoleKeyInfo userKey = Console.ReadKey();
            string userInputString = userKey.Key.ToString();

            switch (userInputString)
            {
               // Approach Catu
               case "C":
                  Console.WriteLine("\nYou approach Catu, who lies in her bed --much like a sloth. She's on her phone.");
                  Console.WriteLine("Reply (1): 'Hey!'\nReply (2): 'The building is on fire.\nReply (3) Dude my day was so ann-'");
                  switch (Console.ReadLine())
                  {
                     case "1":
                        result = "*Ignored.*";
                        Console.WriteLine(result);
                        continue;
                     case "2":
                        result = "Ignored.";
                        Console.WriteLine(result);
                        continue;
                     case "3":
                        result = "'ANDREW??'. Catu leaps from her bed with a vigor and traps you for an eternity as "
                           + "she begins waxing poetry about Andrew's eyes.";
                        Console.WriteLine(result);
                        continue;
                     default:
                        result = "\n*Still ignored.*";
                        Console.WriteLine(result);
                        continue;
                  }
                  Console.WriteLine("You head back out in search of someone else.");
                  break;
               case "G":
                  Console.WriteLine("\nYou go into the bedroom to the right. softboi is empty. Mica is watching ANTM.");
                  Console.WriteLine("Reply (1): 'Hey Mica, where's Glenn?' (2): Get into softboi and sleep.");
                  switch (Console.ReadLine())
                  {
                     case "1":
                        result = "'News? Waterpolo? Florida? It's a mystery...', she replies. 'A case for the FBI'.'";
                        Console.WriteLine(result);
                        continue;
                     case "2":
                        result = "You fall into a deep dreamless state of unconsciousness. As you fade into dreamland, "
                           + "you think you hear a cackle.";
                        Console.WriteLine(result);
                        continue;
                     default:
                        result = "\n*Die*";
                        Console.WriteLine(result);
                        continue;
                  }
                  Console.WriteLine("You head back out in search of someone else.");
                  break;
               case "M":
                  Console.WriteLine("\nMica is napping.");
                  Console.WriteLine("Reply (1): 'Isn't it 1 pm?'\nReply (2): Wake her up.");
                  switch (Console.ReadLine())
                  {
                     case "1":
                        result = "*snoring sounds*";
                        Console.WriteLine(result);
                        continue;
                     case "2":
                        result = "Bold move. You try valiantly but ultimately fail.";
                        Console.WriteLine(result);
                        continue;
                     default:
                        result = "\n*snore*";
                        Console.WriteLine(result);
                        continue;
                  }
                  Console.WriteLine("You head back out in search of someone else.");
                  break;
               case "F":
                  Console.WriteLine("\nFelicia is sitting on the couch, journaling in Arabic.");
                  Console.WriteLine("Reply (1): 'Hey, can you help me with fundies?'\nReply (2): 'German?!'");
                  switch (Console.ReadLine())
                  {
                     case "1":
                        result = "'Sure', she replies and takes out a box of Franzia hidden beneath a pillow. 'Give me a second.'";
                        Console.WriteLine(result);
                        continue;
                     case "2":
                        result = "'oh yeah', she replies carelessly. 'I took it up over the weekend, it's chill.'";
                        Console.WriteLine(result);
                        continue;
                     default:
                        result = "\n*snore*";
                        Console.WriteLine(result);
                        continue;
                  }
                  Console.WriteLine("You head back out in search of someone else.");
                  break;
               default:
                  Console.WriteLine("\nThere's literally no one else here.");
                  continue;
            }
            break;
         }
      }
   }
}
