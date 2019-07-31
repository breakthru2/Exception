using System;

namespace ExceptionContinue
{
    class Nested
    {
        public void Nesting()
        {
            Console.Write("Enter Y/N");
            try
            {
                char value = Char.Parse(Console.ReadLine());
                Console.Write("Enter 1 for a, 2 for b");
                try
                {
                    int option = Int32.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {

                    Console.WriteLine("Error : {0}",ex.Message);
                }

            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error : {0}",ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : {0}", ex.Message);
            }
        }
    }
}
