namespace lecture_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vairables 
            //Datatype + Variable name 

            //number 
            //ineger number , double number .
            //integer

            short S = 4; //2byte
            int I = 20; //4byte
            long L = 500;//8byte

            //double
            float F = 20f;
            float f = (float)20;//4byte

            double d = 20;//8byte

            decimal m = 30m;
            decimal M=(decimal)20;//16 byte

            //string 
            //chaar 
            char s = 'm';
            string ss = "MOstafa";

            //bool
            bool b=false;
            bool B = true;

            //Casting
            //Imlicit casting small=>large
            int x = 5;
            long l = x;

            //Explicit Casting Large=>small
            long j = 500;
            int xx = (int)j;

            //Print values 
           // Console.Write("hhh");
          //  Console.WriteLine("hello");
          //  Console.ReadLine();
            String name = Console.ReadLine();
            //parse
            int age =int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());
            //String concatonaation
            Console.WriteLine("hello " + name);
            //Sting format 
            Console.WriteLine("hello{0}", name,age);
            //string interpollition 
            Console.WriteLine($"My name is {name} and my age is {age}");
 
        }
    }
}
