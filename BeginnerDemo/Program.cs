namespace BeginnerDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Age = 12;
            char Letter = 'a';

            //pascal case
            //JordansNewEmail


            // adding
            int X = 10;
            int Y = 2;

            int SumAdd = X + Y;

            Console.WriteLine(SumAdd);

            // divide
            int SumDivide = X / Y;

            // multiply
            int SumMultiply = X * Y;

            // modulus
            int SumModulus = X % 3;

            // decimal example
            double Num1 = 9;
            double Num2 = 2;

            double SumOne = Num1 / Num2;
            double SumTwo = Num1 / Num2;

            Console.WriteLine(SumOne);
            Console.WriteLine(SumTwo);

            string name = "Jordan";


            //conditionals
            //if, else if, else
            int score = 103;
            int NewScore = 107;

            if(score > 90 && score < 101)
            {
                Console.WriteLine("You got over 90");
            } 
            else if(score > 80 || NewScore == 107)
            {
                Console.WriteLine("You got over 80");
            }
            else if(score > 70)
            {
                Console.WriteLine("You got over 70");
            }
            else
            {
                Console.WriteLine("You failed");
            }

            //switch statement

            char Symbol = '*';

            switch (Symbol)
            {
                case '-':
                    Console.WriteLine("This is a minus");
                    break;
                case '+':
                    Console.WriteLine("This is a plus");
                        break;
                case '/':
                    Console.WriteLine("This is a divide");
                    break;
                case '*':
                    Console.WriteLine("This is a multiply");
                    break;
            }



        }
    }
}
