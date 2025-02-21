namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    int a = 5, b = 0, sum;

            //    sum = a / b;
            //}
            //catch (IOException ioe)
            //{
            //    Console.WriteLine(ioe.Message);
            //}
            //catch (ArithmeticException ae)
            //{
            //    Console.WriteLine(ae.Message);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("This always prints no matter what");
            //}

            try
            {
                CheckAge(16);
            }
            catch (UnderageException ue)
            {
                Console.WriteLine(ue.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine (e.Message);
            }


        }

        public static void CheckAge(int age)
        {
            if(age < 21)
            {
                throw new UnderageException("The age is too young, please come back when older");
            }

            Console.WriteLine("Age accepted");
        }
    }
}
