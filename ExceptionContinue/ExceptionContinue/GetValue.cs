using System;

namespace ExceptionContinue
{
    class GetValue
    {
        private int age;

        public void AcceptAge()
        {
            Console.Write("Enter your age : ");
            age = Int32.Parse(Console.ReadLine());
            if (age <= 0)
            {
                throw new CustomException("You must be at least 1 year old");
            }
            else
            {                
                
                Console.WriteLine("You are allowed");
            }
        }
        public static void GetValueTest()
        {
            var obj = new GetValue();

            try
            {
                obj.AcceptAge();
            }
            catch (CustomException ex)
            {

                Console.WriteLine("Error : {0}", ex.Message);
            }
        }
    }
}
