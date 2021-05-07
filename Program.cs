using System;

namespace Interface
{
    class Program
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
        class dinner : drinking, eating
        {
            public void food()
            {
                Console.WriteLine("I am eating food"); //implementerar in en "body" till eating
            }
            public void beverage()
            {
                Console.WriteLine("I am drinking a beverage"); //implementerar in en "body" till drinking
            }
        }
        static void Main(string[] args)
        {
            //John är den enda som kan äta medans Mike inte kan för han inte har något att äta
            eating John = new dinner(); 
            drinking Mike = new dinner();

            John.food();
            Mike.beverage();

        }
    }
}
