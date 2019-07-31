using System;

namespace ExceptionContinue
{
    class Help
    {
        private string _name;
        public int Value1 { get; set; }
        public int Value2 { get; set; }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public void Accept()
        {
            try
            {
                Console.Write("Enter name : ");
                Name = Console.ReadLine();
            }
            catch (FormatException ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
        public void Divide()
        {
            try
            {
                Console.Write("Enter Value1 : ");
                Value1 = Int32.Parse(Console.ReadLine());

                Console.Write("Enter Value2 : ");
                Value2 = Int32.Parse(Console.ReadLine());

                double result = Value1 / Value2;
                Console.WriteLine("Result is {0}",result);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void Test()
        {
            var a = new Help();
            a.Divide();
        }

    }
}
