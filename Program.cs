using System;

namespace StoryClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Once a fierce lion lived in a jungle. He killed many animals every day.So all the animals of the forest held a meeting. They talked about the matter. ");
            Console.ReadKey();

            Console.WriteLine("The clever fox said, ‘Let us offer to the lion an animal every day. Let us pray to him not to ask for more.");
            Console.ReadKey();

            Console.WriteLine("The animals went to him and said, ‘Oh king of the Jungle, we have come to make you an offer. If you kill so many animals a day, there will be none left very soon. We will send an animal to your den every day. Please eat only one animal a day.");
            Console.ReadKey();

            Console.Write("Lion thoughts it is a good idea and accepts the offer then its time to send animal [enter animal name] :   ");
            string rabbitname = Console.ReadLine();
              
            Animal forest = new Animal(rabbitname, 10);
           

            Console.WriteLine("{0}: was so late and walking too slow because she is thinking on its way how to trick lion", forest._rName);
            Console.ReadKey();

            Console.WriteLine("{0}: reached the cave of: ",forest._rName);
            string lname = Console.ReadLine();
             King lion = new King(lname, 50, 20);

            Console.WriteLine("{0}: Why are you late", lion._rName);
            Console.ReadKey();
            Console.WriteLine("{0}:I am a so sorry, sir. Another lion has come to this forest. He stopped me on the way. He wants to kill you.", forest._rName);
            Console.ReadKey();
            Console.WriteLine("{0}:Lead me to him. I’ll kill him at once.", lname);
            Console.ReadKey();
            Console.WriteLine("{0}:Follow me then, led the lion to a deep well. The hare said, look in here and you will see your enemy", forest._rName);
            Console.ReadKey();
            Console.WriteLine("{0}:looked into the well and saw his own face in the clear water. He roared and the echo came back to him. He thought that another lion was inside the well. He jumped into the well and died.", lname);
            Console.ReadKey();
            Console.WriteLine("{0}:came back to his friends and told them what had happened. All the animals greeted him as the hero of the jungle. ",forest._rName);
            Console.ReadKey();
            Console.WriteLine("Moral: Cleverness can overcome a foe.");
            Console.ReadKey();
            
            

           



          
        }
    }
}
