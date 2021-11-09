using System;


namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var number = "1234";
                byte i = Convert.ToByte(number);
                Console.WriteLine(i);

            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte."); 
               
            }

          
        }
    }
}
