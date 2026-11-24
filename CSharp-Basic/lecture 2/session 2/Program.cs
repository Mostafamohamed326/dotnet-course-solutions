namespace session_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //control statmewnt
            //1-conition statment 
            int x  = int.Parse(Console.ReadLine());
            if (x > 0 || x<=100)
            {
                Console.WriteLine("hello ");

            }
            else if(x < 0) {
            
                Console.WriteLine("ccccc");
            }
            
            int level  =int .Parse(Console.ReadLine());
            switch (level) {
                case 10:
                case 100:
                    Console.WriteLine("mostafa");
                    break;
                default: Console.WriteLine("cccc");
                    break;
            }
            //switch  >= equilty 
            //Switch expression 

            int day = 3;
            string result = day switch
            {
                1 => "Sturday",
                2 => "monday ",

            _ => "invalid day"
            };

            //loop statment 
            for(int I = 0; I < 5; I++)
            {
                Console.WriteLine("ccccc");
            }

            int i = 0;
            while (i < 5)
            {
                Console.WriteLine("ccccc");
                i++;
            }

            int s = 10;
            do
            {
                Console.WriteLine("ccccc");
                s++;
            } while (i < 5);

        }
    }
}
