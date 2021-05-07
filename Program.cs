using System;

namespace Interface
{
    interface eating
        {
            void food(); //skapar en "food" interface metod som inte kan ändras
        }
        interface drinking
        {
            void beverage(); //skapar en "beverage" interface metod som inte kan ändras
        }
        //dinner tillåter att impementera i eating och drinking metoderna 
        class dinner : eating, drinking
        {
            void eating.food()
            {
                Console.WriteLine("I am eating food"); //implementerar in en "body" till eating
            }
            void drinking.beverage()
            {
                Console.WriteLine("I am drinking a beverage"); //implementerar in en "body" till drinking
            }
        }
    class Program
    {
        
        static void Main(string[] args)
        {
            //John är den enda som kan äta medans Mike inte kan för han inte har något att äta
            eating John = new dinner(); 
            drinking Mike = new dinner();
            dinner test = new dinner();

            John.food();
            Mike.beverage();

        }
    }
}
